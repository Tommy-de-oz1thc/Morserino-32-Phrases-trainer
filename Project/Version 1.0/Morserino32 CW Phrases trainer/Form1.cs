using System.Windows.Forms;
using MorseGen;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Linq;
using System;

namespace Morserino32_CW_Phrases_trainer
{
    public partial class Form1 : Form
    {
        List<string> avable_Ports = new List<string>();
        string choosenLesson = "";
        string cw_Text = "";
        private char answer = 't';
        public string s, sa = "";
        private bool wait_time = false;
        int nr = 0;
        int totalPhrases = 0, correctPhrases = 0, wrongPhrases = 0;
        List<string> lines = new List<string>();
        private Thread workerThread = null;
        private Thread playerThread = null;
        private Thread waitThread = null;
        private Thread answerThread = null;
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;
        private SerialPort port;
        private bool stopProcess = false;
        private bool stopPlay = false;
        private string[] r;
        private MorseGenerator mgen = new MorseGenerator();
        private MorseGenerator agen = new MorseGenerator();
        private int Farnsworth_Words;
        private int Farnsworth_Letters;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCheckPorts_Click(object sender, System.EventArgs e)
        {

            avable_Ports.Clear();
            avable_Ports = Morserino32_CW_Phrases_trainer.Ports.PortControl();

            comPort.Items.Clear();
            for (int a = 0; a < avable_Ports.Count; a++)
            {
                comPort.Items.Add(avable_Ports[a]);
            }
            btnConnect.Visible = true;
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {



            try
            {
                port = new SerialPort(comPort.Text,
      115200, Parity.None, 8, StopBits.One);
                port.Open();

                this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);

                if (port.IsOpen)
                {
                    btnConnect.Visible = false;
                    btnDisConntect.Visible = true;
                    this.workerThread = new Thread(new ThreadStart(this.Morserino_Receive));
                    this.answerThread = new Thread(new ThreadStart(this.play_Sound_for_Answer));
                    this.playerThread = new Thread(new ThreadStart(this.play_Sound_for_Lesson));
                    this.playerThread.IsBackground = true;
                    
                }
            }
            catch { }
        }

        

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }



        private void btnCheckLesson_Click(object sender, System.EventArgs e)
        {
            comLessons.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo("Phrases");
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                comLessons.Items.Add(file.Name);
            }
            btnLessonLoad.Visible = true;
        }

        private void btnLessonLoad_Click(object sender, System.EventArgs e)
        {

            try
            {
                lines = File.ReadLines("Phrases/" + choosenLesson).ToList();

                btnStart.Visible = true;
                btnLessonLoad.Visible = false;
                btnCheckLesson.Visible = false;
            }
            catch { MessageBox.Show("You have to choose a lesson frist"); }


        }

        private void comLessons_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            choosenLesson = comLessons.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPreview.Visible = false;
            }
            else
            {
                txtPreview.Visible = true;
            }
        }

        private async void play_Sound_for_Lesson()
        {


            mgen.Picth = Convert.ToInt32(numPitch.Value);
            mgen.Volume = Convert.ToInt32(numVolume.Value);
            mgen.WPM = Convert.ToInt32(numWPM.Value);
            myTimer.Interval = (int)numTimer.Value;
            try
            {
                
                mgen.PlayMorse(cw_Text);
            }
            catch { }

        }

        private async void play_Sound_for_Answer()
        {
           

            agen.Picth = Convert.ToInt32(numPitch.Value);
            agen.Volume = Convert.ToInt32(numVolume.Value);
            agen.WPM = Convert.ToInt32(numWPM.Value);
            myTimer.Interval = (int)numTimer.Value;
            try
            {
                agen.PlayMorse(answer.ToString());
            }
            catch { }
            wait_time = true;
        }

        private void ChooseText()
        {
            sa = "";


            Random rand = new Random();
            cw_Text = lines[rand.Next(0, lines.Count - 1)].ToLower();
            try
            {
                playerThread.Start();
            }
            catch { play_Sound_for_Lesson(); }

            txtPreview.Text = cw_Text;
            btnStart.Visible = false;
            btnStop.Visible = true;
            try
            {
                this.workerThread.Start();
                btnLessonLoad.Visible = false;
            }
            catch { }
        }
        private void btnStart_Click(object sender, System.EventArgs e)
        {
            
            totalPhrases = 0;
            correctPhrases = 0;
            wrongPhrases = 0;
            myTimer.Start();
            myTimer.Interval = (int)numTimer.Value;
            Update_Phrases();
           
            ChooseText();

           
        }
        

        private void Update_Phrases()
        {
            txtTotalPhases.Text = totalPhrases.ToString();
            txtCorrectPhrases.Text = correctPhrases.ToString();
            txtWrongPhrases.Text = wrongPhrases.ToString();
            try
            {
                mgen.StopMorse();
                
            }
            catch {  }
            if((answer=='w') || (answer == 'r'))
                {
                   play_Sound_for_Answer();
                }
        }


        private void btnStop_Click(object sender, System.EventArgs e)
        {
            mgen.StopMorse();
            btnCheckLesson.Visible = true;
            btnStart.Visible = true;
            btnStop.Visible = false;
            txtMorserino.Text = "";
            txtPreview.Text = "";
            cw_Text = "";
            btnStart.Visible = false;
            btnLessonLoad.Visible = true;
            sa = "";
            
            myTimer.Stop();
        }

        private void UpdateStatus()
        {

            txtMorserino.Text = sa.TrimStart();
            
            Update_Phrases();
           
            
        }

        private void btnDisConntect_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
                btnDisConntect.Visible = false;
                btnConnect.Visible = true;
            }
            catch { }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                mgen.StopMorse();
            }
            catch { }
            Environment.Exit(Environment.ExitCode);
            
        }

        private void numTimer_ValueChanged(object sender, EventArgs e)
        {
            myTimer.Interval = (int)numTimer.Value;
        }

        private void numPitch_ValueChanged(object sender, EventArgs e)
        {
            mgen.Picth = Convert.ToInt32(numPitch.Value);
        }

        private void numWPM_ValueChanged(object sender, EventArgs e)
        {
            mgen.WPM = Convert.ToInt32(numWPM.Value);
        }

        private void numVolume_ValueChanged(object sender, EventArgs e)
        {
            mgen.Volume = Convert.ToInt32(numVolume.Value);
        }

        

        private void numFarnsworth_Words_ValueChanged(object sender, EventArgs e)
        {

            Farnsworth_Words = Convert.ToInt32(numFarnsworth_Words.Value);
            MorseProvider.Set_Farnsworth_Words = Farnsworth_Words;
        }

        private void numFarnsworth_Letters_ValueChanged(object sender, EventArgs e)
        {

            Farnsworth_Letters = Convert.ToInt32(numFarnsworth_Letters.Value);
            MorseProvider.Set_Farnsworth_Letters = Farnsworth_Letters;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (wait_time)
            {
                Next_Phrases();
                wait_time = false;
            }
        }

       

        private void Next_Phrases()
        {
           
            txtPreview.Text = "";
            txtMorserino.Text = "";
            sa = "";
            s = "";
            
            cw_Text = "";
            try
            {
                mgen.StopMorse();
                agen.StopMorse();
            }
            catch { }
           
            
            ChooseText();
        }

       

        private void Morserino_Receive()
        {
              
            
            s = "";
           
            while (true)
            {
               
                try
                {
                    string t = Convert.ToChar(port.ReadChar()).ToString();
                   
                    if (t == "=")
                    {
                        try
                        {


                            s = s.TrimStart();
                            s = s.ToLower().Trim() + " =";
                            cw_Text = cw_Text.ToLower().Trim();
                            if (String.Equals(s, cw_Text))
                            {
                                sa = " - OK";
                                correctPhrases++;
                                answer = 'r';
                            }
                            else
                            {
                                sa = " - Error - " + " " + s;
                                wrongPhrases++;
                                answer = 'w';
                            };
                            totalPhrases++;
                            s = "";
                            t = "";
                            nr++;
                            
                        }
                        catch { this.workerThread.Abort(); }
                        
                    }
                    else
                    {
                        s += t;

                        sa += t;
                       
                    }

                   

                    if (t == "*")
                    {

                        

                       
                        
                            r = sa.Split(' ');
                            r = r.Where(w => w != r.Last()).ToArray();
                            r = r.Where(w => w != r.Last()).ToArray();
                            t = "";
                            int f = 0;
                            sa = "";
                            s = "";
                            foreach (string a in r)
                            {
                               
                                if (f != r.Length - 1)
                                {
                                   
                                    sa += a.Trim() + " ";
                                }
                                else if(f!=0)
                                {
                                   
                                    sa += a.Trim();
                                }

                               

                                f++;
                            }

                       
                      
                        
                    }

                    

                    if (!this.stopProcess)
                    {
                       
                      
                        // Show progress
                        this.Invoke(this.updateStatusDelegate);
                       
                    }
                    answer = 't';
                }
                catch { }

            }
            
        }


    }
}

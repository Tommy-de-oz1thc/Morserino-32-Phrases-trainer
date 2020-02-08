using System.Windows.Forms;
using MorseGen;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Linq;
using System;
using Morserino_32;

namespace Morserino32_CW_Phrases_trainer
{
    public partial class Start : Form
    {
        private List<string> avable_Ports = new List<string>();
        private static SerialPort comPort = new SerialPort();
        private Ports port = new Ports();
        string choosenLesson = "";
        string cw_Text = "";
        private char answer = 't';
        private string s, sa = "";
        private bool wait_time = false;
        private int nr = 0;
        private int totalPhrases = 0, correctPhrases = 0, wrongPhrases = 0;
        private List<string> lines = new List<string>();
        private List<string> text_Words = new List<string>();
        private Thread workerThread = null;
        private Thread playerThread = null;
        private Thread waitThread = null;
        private Thread answerThread = null;
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;
        private Morserino m32 = new Morserino();
        private bool stopProcess = false;
        private bool stopPlay = false;
        private string[] r;
        private MorseGenerator mgen = new MorseGenerator();
        private MorseGenerator agen = new MorseGenerator();
        private int Farnsworth_Words;
        private int Farnsworth_Letters;
       
        public Start()
        {
            InitializeComponent();
            
        }

        private void btnCheckPorts_Click(object sender, System.EventArgs e)
        {

            avable_Ports.Clear();
            avable_Ports = port.PortControl();

            comboPort.Items.Clear();
            for (int a = 0; a < avable_Ports.Count; a++)
            {
                comboPort.Items.Add(avable_Ports[a]);
            }
            btnConnect.Visible = true;
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {



            try
            {
                Connect_to_ComPort(comboPort.Text);

                this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);

               
                btnConnect.Visible = false;
                btn_Dis_Connect.Visible = true;
                this.workerThread = new Thread(new ThreadStart(this.Morserino_Receive));
                this.answerThread = new Thread(new ThreadStart(this.play_Sound_for_Answer));
                this.playerThread = new Thread(new ThreadStart(this.play_Sound_for_Lesson));
                this.playerThread.IsBackground = true;
                    
                
            }
            catch { }
        }
        private void Connect_to_ComPort(string comboPort)
        {

            comPort = port.Connect(comboPort);


        }
        private void PortControl()
        {
            avable_Ports = port.PortControl();
            Fill_ComPort();
        }
        private void Fill_ComPort()
        {

            comboPort.Items.Clear();
            for (int a = 0; a < avable_Ports.Count; a++)
            {
                comboPort.Items.Add(avable_Ports[a]);
            }
            btnConnect.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            PortControl();
            btn_Dis_Connect.Visible = false;

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

       

        private void btnDisConntect_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
                btn_Dis_Connect.Visible = false;
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

            string w = "";
            s = "";
           
            while (true)
            {

                try
                {
                    w = m32.Read_Word_from_M32(comPort);
                    w.TrimStart();
                    if (w == "*")
                    {
                        try
                        {
                            if (text_Words[text_Words.Count - 1].Trim() != "")
                            {

                                text_Words.RemoveAt(text_Words.Count - 1);
                            }
                            else
                            {
                                text_Words.RemoveAt(text_Words.Count - 1);
                                text_Words.RemoveAt(text_Words.Count - 1);

                            }


                        }
                        catch { }
                    }


                    else
                    {
                        if (w.TrimStart() != "")
                        {
                            text_Words.Add(w.TrimStart());
                        }
                    }
                }

                catch { }
                        if (w.Contains("="))
                        {
                    
                            try
                            {
                                
                                string s = "";
                        
                                for (int a = 0; a < text_Words.Count; a++)
                                {
                                     s += text_Words[a];
                                      
                                }

                                s = s.TrimStart();
                                s = s.ToLower().Trim();
                                cw_Text = cw_Text.ToLower().Trim();
                                text_Words.Clear();
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
                                text_Words.Add(sa);
                                totalPhrases++;
                                s = "";
                                w = "";
                                nr++;

                            }
                            catch 
                            {
                                 string v = "";
                            }
                        
                        }
                    

                   
                    

                    if (!this.stopProcess)
                    {
                       
                      
                        // Show progress
                        this.Invoke(this.updateStatusDelegate);
                       
                    }
                    answer = 't';
                
                

            }
           
        }
        private void UpdateStatus()
        {

            txtMorserino.Text = "";
            string t = "";
            for (int i = 0; i < text_Words.Count; i++)
            {
                t += text_Words[i];
                txtMorserino.Text = t;
            }
            if ((t.Contains("="))||(t.Contains("Error"))||(t.Contains("OK")))
            {
                text_Words.Clear();
            }
                txtMorserino.Text = t.TrimStart();

            Update_Phrases();


        }

    }
}

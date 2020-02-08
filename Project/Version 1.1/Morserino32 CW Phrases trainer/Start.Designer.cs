namespace Morserino32_CW_Phrases_trainer
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckPorts = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.comLessons = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckLesson = new System.Windows.Forms.Button();
            this.btnLessonLoad = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numWPM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtMorserino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Dis_Connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numPitch = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPhases = new System.Windows.Forms.TextBox();
            this.txtCorrectPhrases = new System.Windows.Forms.TextBox();
            this.txtWrongPhrases = new System.Windows.Forms.TextBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numVolume = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numFarnsworth_Words = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numFarnsworth_Letters = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.checkVoice = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFarnsworth_Words)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFarnsworth_Letters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Port for the Morserino Connect:";
            // 
            // btnCheckPorts
            // 
            this.btnCheckPorts.Location = new System.Drawing.Point(690, 34);
            this.btnCheckPorts.Name = "btnCheckPorts";
            this.btnCheckPorts.Size = new System.Drawing.Size(75, 23);
            this.btnCheckPorts.TabIndex = 2;
            this.btnCheckPorts.Text = "Check";
            this.btnCheckPorts.UseVisualStyleBackColor = true;
            this.btnCheckPorts.Click += new System.EventHandler(this.btnCheckPorts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(689, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // comLessons
            // 
            this.comLessons.FormattingEnabled = true;
            this.comLessons.Location = new System.Drawing.Point(13, 36);
            this.comLessons.Name = "comLessons";
            this.comLessons.Size = new System.Drawing.Size(510, 21);
            this.comLessons.TabIndex = 4;
            this.comLessons.SelectedIndexChanged += new System.EventHandler(this.comLessons_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lessons:";
            // 
            // btnCheckLesson
            // 
            this.btnCheckLesson.Location = new System.Drawing.Point(67, 7);
            this.btnCheckLesson.Name = "btnCheckLesson";
            this.btnCheckLesson.Size = new System.Drawing.Size(75, 23);
            this.btnCheckLesson.TabIndex = 6;
            this.btnCheckLesson.Text = "Check";
            this.btnCheckLesson.UseVisualStyleBackColor = true;
            this.btnCheckLesson.Click += new System.EventHandler(this.btnCheckLesson_Click);
            // 
            // btnLessonLoad
            // 
            this.btnLessonLoad.Location = new System.Drawing.Point(158, 7);
            this.btnLessonLoad.Name = "btnLessonLoad";
            this.btnLessonLoad.Size = new System.Drawing.Size(104, 23);
            this.btnLessonLoad.TabIndex = 7;
            this.btnLessonLoad.Text = "Load Lesson";
            this.btnLessonLoad.UseVisualStyleBackColor = true;
            this.btnLessonLoad.Visible = false;
            this.btnLessonLoad.Click += new System.EventHandler(this.btnLessonLoad_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numWPM
            // 
            this.numWPM.Location = new System.Drawing.Point(566, 100);
            this.numWPM.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numWPM.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numWPM.Name = "numWPM";
            this.numWPM.Size = new System.Drawing.Size(118, 20);
            this.numWPM.TabIndex = 10;
            this.numWPM.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWPM.ValueChanged += new System.EventHandler(this.numWPM_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "WPM for the PC Sound:\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Hide preview Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtPreview
            // 
            this.txtPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(13, 184);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.Size = new System.Drawing.Size(752, 31);
            this.txtPreview.TabIndex = 13;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(15, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtMorserino
            // 
            this.txtMorserino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorserino.Location = new System.Drawing.Point(12, 266);
            this.txtMorserino.Name = "txtMorserino";
            this.txtMorserino.ReadOnly = true;
            this.txtMorserino.Size = new System.Drawing.Size(752, 31);
            this.txtMorserino.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sent text from morserino32:\r\nBreak with  = Text will first change when a = is sen" +
    "t.";
            // 
            // btn_Dis_Connect
            // 
            this.btn_Dis_Connect.Location = new System.Drawing.Point(689, 97);
            this.btn_Dis_Connect.Name = "btn_Dis_Connect";
            this.btn_Dis_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Dis_Connect.TabIndex = 17;
            this.btn_Dis_Connect.Text = "DisConnect";
            this.btn_Dis_Connect.UseVisualStyleBackColor = true;
            this.btn_Dis_Connect.Visible = false;
            this.btn_Dis_Connect.Click += new System.EventHandler(this.btnDisConntect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Picth for Sound:";
            // 
            // numPitch
            // 
            this.numPitch.Location = new System.Drawing.Point(566, 71);
            this.numPitch.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numPitch.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPitch.Name = "numPitch";
            this.numPitch.Size = new System.Drawing.Size(118, 20);
            this.numPitch.TabIndex = 19;
            this.numPitch.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.numPitch.ValueChanged += new System.EventHandler(this.numPitch_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Phrases sent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Correct Phrases sent:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Wrong of Phrases sent:";
            // 
            // txtTotalPhases
            // 
            this.txtTotalPhases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPhases.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalPhases.Location = new System.Drawing.Point(15, 369);
            this.txtTotalPhases.Name = "txtTotalPhases";
            this.txtTotalPhases.ReadOnly = true;
            this.txtTotalPhases.Size = new System.Drawing.Size(83, 31);
            this.txtTotalPhases.TabIndex = 23;
            // 
            // txtCorrectPhrases
            // 
            this.txtCorrectPhrases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectPhrases.ForeColor = System.Drawing.Color.Green;
            this.txtCorrectPhrases.Location = new System.Drawing.Point(189, 373);
            this.txtCorrectPhrases.Name = "txtCorrectPhrases";
            this.txtCorrectPhrases.ReadOnly = true;
            this.txtCorrectPhrases.Size = new System.Drawing.Size(83, 31);
            this.txtCorrectPhrases.TabIndex = 24;
            // 
            // txtWrongPhrases
            // 
            this.txtWrongPhrases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrongPhrases.ForeColor = System.Drawing.Color.Red;
            this.txtWrongPhrases.Location = new System.Drawing.Point(348, 373);
            this.txtWrongPhrases.Name = "txtWrongPhrases";
            this.txtWrongPhrases.ReadOnly = true;
            this.txtWrongPhrases.Size = new System.Drawing.Size(83, 31);
            this.txtWrongPhrases.TabIndex = 25;
            // 
            // myTimer
            // 
            this.myTimer.Interval = 50000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Timer delay = :";
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(566, 131);
            this.numTimer.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numTimer.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(118, 20);
            this.numTimer.TabIndex = 28;
            this.numTimer.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTimer.ValueChanged += new System.EventHandler(this.numTimer_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Timer: delay after =:  100-15000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "WPM: 15-140";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(666, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Pitch:  500-1200";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Volume:";
            // 
            // numVolume
            // 
            this.numVolume.Location = new System.Drawing.Point(403, 5);
            this.numVolume.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numVolume.Name = "numVolume";
            this.numVolume.Size = new System.Drawing.Size(120, 20);
            this.numVolume.TabIndex = 34;
            this.numVolume.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numVolume.ValueChanged += new System.EventHandler(this.numVolume_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(652, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Volume :  5-100";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "* (6 dit) delete the last word sent";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(398, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Farnsworth :";
            // 
            // numFarnsworth_Words
            // 
            this.numFarnsworth_Words.Location = new System.Drawing.Point(507, 157);
            this.numFarnsworth_Words.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFarnsworth_Words.Name = "numFarnsworth_Words";
            this.numFarnsworth_Words.Size = new System.Drawing.Size(62, 20);
            this.numFarnsworth_Words.TabIndex = 38;
            this.numFarnsworth_Words.ValueChanged += new System.EventHandler(this.numFarnsworth_Words_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(563, 417);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(197, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Farnsworth: Words: 0-20  Letters 0 - 100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(460, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Words:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(574, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Letters:";
            // 
            // numFarnsworth_Letters
            // 
            this.numFarnsworth_Letters.Location = new System.Drawing.Point(622, 157);
            this.numFarnsworth_Letters.Name = "numFarnsworth_Letters";
            this.numFarnsworth_Letters.Size = new System.Drawing.Size(62, 20);
            this.numFarnsworth_Letters.TabIndex = 42;
            this.numFarnsworth_Letters.ValueChanged += new System.EventHandler(this.numFarnsworth_Letters_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 428);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(424, 13);
            this.label20.TabIndex = 43;
            this.label20.Text = "Version: 1.1 ~ Last Update: 08-02-2020             @ Tommy Clemmensen Jo55jh Denm" +
    "ark";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(566, 35);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(118, 21);
            this.comboPort.TabIndex = 44;
            // 
            // checkVoice
            // 
            this.checkVoice.AutoSize = true;
            this.checkVoice.Location = new System.Drawing.Point(689, 243);
            this.checkVoice.Name = "checkVoice";
            this.checkVoice.Size = new System.Drawing.Size(75, 17);
            this.checkVoice.TabIndex = 45;
            this.checkVoice.Text = "Add Voice";
            this.checkVoice.UseVisualStyleBackColor = true;
            this.checkVoice.CheckedChanged += new System.EventHandler(this.checkVoice_CheckedChanged);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkVoice);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.numFarnsworth_Letters);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numFarnsworth_Words);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numVolume);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWrongPhrases);
            this.Controls.Add(this.txtCorrectPhrases);
            this.Controls.Add(this.txtTotalPhases);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numPitch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Dis_Connect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMorserino);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numWPM);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLessonLoad);
            this.Controls.Add(this.btnCheckLesson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comLessons);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCheckPorts);
            this.Controls.Add(this.label1);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morserino32 Phrases Trainer (by oz1thc)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFarnsworth_Words)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFarnsworth_Letters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox comLessons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckLesson;
        private System.Windows.Forms.Button btnLessonLoad;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numWPM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtMorserino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Dis_Connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPhases;
        private System.Windows.Forms.TextBox txtCorrectPhrases;
        private System.Windows.Forms.TextBox txtWrongPhrases;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numVolume;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numFarnsworth_Words;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numFarnsworth_Letters;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.CheckBox checkVoice;
    }
}


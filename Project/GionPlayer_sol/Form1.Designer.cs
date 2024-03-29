namespace GionPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            next = new Button();
            Select = new Button();
            previous = new Button();
            MXB = new AxWMPLib.AxWindowsMediaPlayer();
            MuteBtn = new Button();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            playtime = new Label();
            alltime = new Label();
            label1 = new Label();
            Volume = new TrackBar();
            label2 = new Label();
            OneWorld = new Button();
            MPInfo = new Label();
            library = new Button();
            Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)MXB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(175, 173);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "-5 sec";
            button1.UseVisualStyleBackColor = true;
            button1.Click += minus5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 173);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Pause";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Pause_Click;
            // 
            // button3
            // 
            button3.Location = new Point(337, 173);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Play";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Play_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(129, 13);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(608, 124);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(418, 173);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Stop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Stop_Click;
            // 
            // button5
            // 
            button5.Location = new Point(499, 173);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "+5 sec";
            button5.UseVisualStyleBackColor = true;
            button5.Click += plus5_Click;
            // 
            // next
            // 
            next.Location = new Point(580, 173);
            next.Name = "next";
            next.Size = new Size(75, 23);
            next.TabIndex = 7;
            next.Text = ">>";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // Select
            // 
            Select.Location = new Point(31, 13);
            Select.Name = "Select";
            Select.Size = new Size(75, 23);
            Select.TabIndex = 9;
            Select.Text = "Add Files";
            Select.UseVisualStyleBackColor = true;
            Select.Click += Add_Files_Click;
            // 
            // previous
            // 
            previous.Location = new Point(94, 173);
            previous.Name = "previous";
            previous.Size = new Size(75, 23);
            previous.TabIndex = 11;
            previous.Text = "<<";
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // MXB
            // 
            MXB.Enabled = true;
            MXB.Location = new Point(457, 56);
            MXB.Name = "MXB";
            MXB.OcxState = (AxHost.State)resources.GetObject("MXB.OcxState");
            MXB.Size = new Size(220, 60);
            MXB.TabIndex = 13;
            MXB.PlayStateChange += PlayState_Change;
            MXB.StatusChange += MXBStatusChange;
            // 
            // MuteBtn
            // 
            MuteBtn.Location = new Point(661, 173);
            MuteBtn.Name = "MuteBtn";
            MuteBtn.Size = new Size(75, 23);
            MuteBtn.TabIndex = 14;
            MuteBtn.Text = "Mute";
            MuteBtn.UseVisualStyleBackColor = true;
            MuteBtn.Click += MuteBtn_Click;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.White;
            progressBar.Location = new Point(95, 154);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(642, 13);
            progressBar.Step = 1;
            progressBar.TabIndex = 15;
            // 
            // timer1
            // 
            timer1.Tick += Timer1_Tick;
            // 
            // playtime
            // 
            playtime.AutoSize = true;
            playtime.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playtime.Location = new Point(41, 149);
            playtime.Name = "playtime";
            playtime.Size = new Size(48, 18);
            playtime.TabIndex = 16;
            playtime.Text = "00:00";
            // 
            // alltime
            // 
            alltime.AutoSize = true;
            alltime.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alltime.Location = new Point(743, 149);
            alltime.Name = "alltime";
            alltime.Size = new Size(48, 18);
            alltime.TabIndex = 18;
            alltime.Text = "00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 199);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 19;
            label1.Text = "Playing info";
            // 
            // Volume
            // 
            Volume.Location = new Point(743, 12);
            Volume.Maximum = 100;
            Volume.Name = "Volume";
            Volume.Orientation = Orientation.Vertical;
            Volume.RightToLeft = RightToLeft.No;
            Volume.Size = new Size(45, 104);
            Volume.TabIndex = 20;
            Volume.TickFrequency = 0;
            Volume.TickStyle = TickStyle.Both;
            Volume.Scroll += Volume_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(746, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 30);
            label2.TabIndex = 21;
            label2.Text = "🔊";
            // 
            // OneWorld
            // 
            OneWorld.Location = new Point(31, 42);
            OneWorld.Name = "OneWorld";
            OneWorld.Size = new Size(75, 23);
            OneWorld.TabIndex = 22;
            OneWorld.Text = "Add radio";
            OneWorld.UseVisualStyleBackColor = true;
            OneWorld.Click += Radio_Click;
            // 
            // MPInfo
            // 
            MPInfo.AutoSize = true;
            MPInfo.BackColor = Color.FromArgb(128, 255, 128);
            MPInfo.Font = new Font("Arial Black", 9.75F, FontStyle.Bold);
            MPInfo.Location = new Point(129, 226);
            MPInfo.Name = "MPInfo";
            MPInfo.Size = new Size(36, 18);
            MPInfo.TabIndex = 23;
            MPInfo.Text = "Info";
            // 
            // library
            // 
            library.Location = new Point(31, 71);
            library.Name = "library";
            library.Size = new Size(75, 23);
            library.TabIndex = 24;
            library.Text = "Add Libray";
            library.UseVisualStyleBackColor = true;
            library.Click += Libray_Click;
            library.MouseHover += Library_Hover;
            // 
            // Clear
            // 
            Clear.Location = new Point(31, 100);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 25;
            Clear.Text = "Clear All";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 252);
            Controls.Add(Clear);
            Controls.Add(library);
            Controls.Add(MPInfo);
            Controls.Add(OneWorld);
            Controls.Add(label2);
            Controls.Add(Volume);
            Controls.Add(label1);
            Controls.Add(alltime);
            Controls.Add(playtime);
            Controls.Add(progressBar);
            Controls.Add(MuteBtn);
            Controls.Add(MXB);
            Controls.Add(previous);
            Controls.Add(Select);
            Controls.Add(next);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GPlayer";
            ((System.ComponentModel.ISupportInitialize)MXB).EndInit();
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
        private Button button5;
        private Button next;
        private new Button Select;
        private Button previous;
        private AxWMPLib.AxWindowsMediaPlayer MXB;
        private Button MuteBtn;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private Label playtime;
        private Label alltime;
        private Label label1;
        private TrackBar Volume;
        private Label label2;
        private Button OneWorld;
        private Label MPInfo;
        private Button library;
        private Button Clear;
    }
}

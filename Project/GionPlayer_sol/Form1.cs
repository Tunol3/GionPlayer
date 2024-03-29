namespace GionPlayer
{
    public partial class Form1 : Form
    {
        Form2 form2 = new();
        // declarations for paths and files
        private List<string> paths, files = new();
        private int index = 0;
        
        public Form1()
        {
            InitializeComponent();

            // set upmedia player
            MXB.Ctlcontrols.stop();
            MXB.Visible = false;
            // setup volume
            Volume.Value = MXB.settings.volume;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex <= index)
            {
                MXB.URL = paths[listBox1.SelectedIndex];
                MXB.Ctlcontrols.stop();
                string txt = files[listBox1.SelectedIndex].Split(".mp3")[0];
                label1.Text = "Now playing " + txt;

            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MXB.Ctlcontrols.play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            MXB.Ctlcontrols.stop();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            MXB.Ctlcontrols.pause();

        }

        private void MuteBtn_Click(object sender, EventArgs e)
        {
            if (MXB.settings.mute == false)
            {
                MXB.settings.mute = true;
                Volume.Value = 0;
                MuteBtn.Text = "Unmute";
            }
            else
            {
                MXB.settings.mute = false;
                Volume.Value = MXB.settings.volume;
                MuteBtn.Text = "Mute";
            }
        }

        private void PlayState_Change(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MXB.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)MXB.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (MXB.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (MXB.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                progressBar.Value = 0;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            playtime.Text = MXB.Ctlcontrols.currentPositionString;
            alltime.Text = MXB.Ctlcontrols.currentItem.durationString.ToString();
            if (MXB.playState == WMPLib.WMPPlayState.wmppsPlaying && !MXB.URL.Contains("http"))
            {
                try
                {
                    progressBar.Value = (int)MXB.Ctlcontrols.currentPosition;
                }
                catch { }
            }

        }

        private void Add_Files_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] newfiles = ofd.SafeFileNames;
                string[] newpaths = ofd.FileNames;

                for (int i = 0; i < newfiles.Length; i++)
                {
                    listBox1.Items.Add(newfiles[i].Replace(".mp3", ""));
                    if (paths == null)
                    {
                        paths = new List<string>();
                    }

                    // Add file and path to respective lists
                    files.Add(newfiles[i]);
                    paths.Add(newpaths[i]);

                    index++;
                }
            }
        }

        private void minus5_Click(object sender, EventArgs e)
        {
            MXB.Ctlcontrols.currentPosition -= 5;

        }

        private void plus5_Click(object sender, EventArgs e)
        {
            MXB.Ctlcontrols.currentPosition += 5;
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex--;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex++;
            }
        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            MXB.settings.volume = Volume.Value;
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form2
            Form2 newForm2 = new Form2();

            // Attach the event handler to the FormClosed event
            newForm2.FormClosed += Form2_FormClosed;

            // Show the new instance of Form2
            newForm2.Show();
        }

        private void Form2_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is Form2 form)
            {
                // Detach the event handler from the closed instance of Form2
                form.FormClosed -= Form2_FormClosed;
                if (form.RadioName != null && form.RadioURL != null)
                {
                    // Add data to lists and update UI as needed
                    files.Add(form.RadioName);
                    paths ??= new List<string>(); // Null-coalescing operator to initialize paths if null
                    paths.Add(form.RadioURL);
                    listBox1.Items.Add(form.RadioName);
                    index++;
                }
            }
        }

        private void MXBStatusChange(object sender, EventArgs e)
        {
            MPInfo.Text = MXB.status;
        }

        private void Libray_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;
                        string[] text;
                        while ((line = sr.ReadLine()) != null)
                        {
                            text = line.Split(',');
                            files.Add(text[0]);
                            paths ??= new List<string>(); // Null-coalescing operator to initialize paths if null
                            paths.Add(text[1]);
                            listBox1.Items.Add(text[0]);
                            index++;
                        }
                    }
                }
                catch (Exception) { }
            }
        }

        private void Library_Hover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.library, "Choose a .txt file witch contains the following dictionary:\n" +
                                                "\t { display_name,URL/path }\n" +
                                                " These will be written on separate lines");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
                files.Clear();
                paths.Clear();
                MessageBox.Show("List Cleared!", "Clear files from list");
            }
        }
    }
}

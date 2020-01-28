using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace JWMSMediaPlayer
{
    public partial class VideoPlayerForm : Form
    {
        public VideoPlayerForm()
        {
            InitializeComponent();

            playPauseButton.Tag = "Play";
            playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.play;

            label1.Text = "00:00:00";
            volumeBar.Value = (mediaPlayer.settings.volume/10);
            muteUnmuteButton.Tag = "Unmuted";

            mediaPlayer.stretchToFit = true;
        }

        private DataTable dtCountries = new DataTable();

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            //Stop Video from Playing 
            mediaPlayer.Ctlcontrols.stop();

            base.Hide();
            HomeScreenForm hsf = new HomeScreenForm();
            hsf.Show();
        }

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "All Files|*.*|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    //videoList.DataSource = files;

                    /*
                    foreach(MediaFile f in files)
                    {
                        if (videoList.Items.Contains(f)) continue;
                        videoList.Items.Add(f);
                    }*/
                    LoadData(files);
                }
            }
        }

        private DataTable LoadData(List<MediaFile> files)
        {
            if (!(dtCountries.Columns.Contains("Country")))
            {
                dtCountries.Columns.Add("Country", typeof(string));
            }
            if (!(dtCountries.Columns.Contains("Name")))
            {
                dtCountries.Columns.Add("Name", typeof(string));
            }

            dtCountries.PrimaryKey = new DataColumn[] { dtCountries.Columns["Country"] };

            foreach (MediaFile f in files)
            {
                if(!(dtCountries.Rows.Contains(f.FileName))){
                    dtCountries.Rows.Add(f.FileName, f.Path);
                    dtCountries.NewRow();
                }
            }

            videoList.DataSource = dtCountries;
            videoList.DisplayMember = "Country";

            return dtCountries;
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            MediaFile file = videoList.SelectedItem as MediaFile;
            if (file != null)
            {
                video.setPath(file.Path);
            }
            */
            DataRowView drv = (DataRowView)videoList.SelectedItem;
            String valueOfItem = drv["Name"].ToString();
        
            //MessageBox.Show(valueOfItem);
            video.setPath(valueOfItem);
            /*
            if(file != null)
            {
                mediaPlayer.URL = file.Path;
                //mediaPlayer.Ctlcontrols.pause();
                mediaPlayer.Ctlcontrols.stop();
            }
            */
            //playPauseButton.Tag = "Pause";
            //playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
        }

        private void VideoPlayerForm_Load(object sender, EventArgs e)
        {
            videoList.ValueMember = "Path";
            videoList.DisplayMember = "FileName";
            mediaPlayer.Ctlcontrols.pause();

            timer1.Interval = 1000;
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {   
            if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                playPauseButton.Tag = "Play";
                playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.play;
                mediaPlayer.Ctlcontrols.pause();
            }
            else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                if (mediaPlayer.URL == video.getPath())
                {
                    playPauseButton.Tag = "Pause";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                    mediaPlayer.Ctlcontrols.play();
                }
                else if (mediaPlayer.URL != video.getPath())
                {
                    mediaPlayer.URL = video.getPath();
                    playPauseButton.Tag = "Pause";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                    mediaPlayer.Ctlcontrols.play();
                }
            }
            else if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                if (mediaPlayer.URL == video.getPath())
                {
                    playPauseButton.Tag = "Pause";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                    mediaPlayer.Ctlcontrols.play();
                }
                else if (mediaPlayer.URL != video.getPath())
                {
                    mediaPlayer.URL = video.getPath();
                    playPauseButton.Tag = "Pause";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                    mediaPlayer.Ctlcontrols.play();
                }
            }
            else if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsUndefined)
            {
                mediaPlayer.URL = video.getPath();
                playPauseButton.Tag = "Pause";
                playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                mediaPlayer.Ctlcontrols.play();
            }
        }

        private void mediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //media player control's playstate change event handler
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar1.Maximum = (int)mediaPlayer.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                trackBar1.Value = 0;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar1.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;
            }
            TimeSpan time = TimeSpan.FromSeconds(trackBar1.Value);
            string str = time.ToString(@"hh\:mm\:ss");
            label1.Text = str;

            trackBar1.Minimum = 0;
            trackBar1.Maximum = (int)mediaPlayer.Ctlcontrols.currentItem.duration;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            mediaPlayer.Ctlcontrols.pause();
            Thread.Sleep(1000);
            mediaPlayer.Ctlcontrols.currentPosition = (double)trackBar1.Value;
            Thread.Sleep(1000);
            mediaPlayer.Ctlcontrols.play();

            TimeSpan time = TimeSpan.FromSeconds(trackBar1.Value);
            string str = time.ToString(@"hh\:mm\:ss");

        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = volumeBar.Value * 10;
        }

        private void muteUnmuteButton_Click(object sender, EventArgs e)
        {
            if(muteUnmuteButton.Tag.Equals("Unmuted"))
            {
                muteUnmuteButton.Tag =  "Muted";
                mediaPlayer.settings.mute = true;
                muteUnmuteButton.Image = JWMSMediaPlayer.Properties.Resources.mute;
            }
            else if(muteUnmuteButton.Tag.Equals("Muted"))
            {
                muteUnmuteButton.Tag = "Unmuted";
                mediaPlayer.settings.mute = false;
                muteUnmuteButton.Image = JWMSMediaPlayer.Properties.Resources.unmuute;
            }
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            //mediaPlayer.fullScreen = true;
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizeButton.Image = JWMSMediaPlayer.Properties.Resources.minimize;

                //hide first column upon maximization
                this.tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.ColumnStyles[0].Width = 0;

                //hide first row upon maximization
                this.tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.RowStyles[0].Height = 0;

                //hide last row upon maximization
                this.tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.RowStyles[3].Height = 0;

            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                maximizeButton.Image = JWMSMediaPlayer.Properties.Resources.maximize;

                //enable first column upon minimization
                this.tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.ColumnStyles[0].Width = 160;

                //enable first row upon minimization
                this.tableLayoutPanel1.RowStyles[0].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.RowStyles[0].Height = 40;
            }
        }

        private void mediaPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.RowStyles[3].Height = 45;
            }
        }

        private void nextItemButton_Click(object sender, EventArgs e)
        {
            if (videoList.SelectedIndex < videoList.Items.Count - 1)
            {
                videoList.SelectedIndex = videoList.SelectedIndex + 1;
            }

            MediaFile file = videoList.SelectedItem as MediaFile;
            if (file != null)
            {
                video.setPath(file.Path);
            }

            mediaPlayer.URL = video.getPath();
            //Set to play
            mediaPlayer.Ctlcontrols.play();

            //Reset buttons:
            playPauseButton.Tag = "Pause";
            playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
        }

        private void previousItemButton_Click(object sender, EventArgs e)
        {
            if (videoList.SelectedIndex > 0)
            {
                videoList.SelectedIndex = videoList.SelectedIndex - 1;
            }

            MediaFile file = videoList.SelectedItem as MediaFile;
            if (file != null)
            {
                video.setPath(file.Path);
            }

            mediaPlayer.URL = video.getPath();
            //Set to play
            mediaPlayer.Ctlcontrols.play();

            //Reset buttons:
            playPauseButton.Tag = "Pause";
            playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            /*
            MediaFile file = videoList.SelectedItem as MediaFile;

            while (videoList.SelectedItems.Count != 0)
            {
                if(video.getPath() == mediaPlayer.URL)
                {
                    MessageBox.Show("Cannot remove the video that is currently being played");
                    break;
                }
                else
                {
                    DataRowView drv = (DataRowView)videoList.SelectedItem;
                    String valueOfItem = drv["Name"].ToString();
                    drv.Delete();
                }
            }
            */
            if (videoList.Items.Count > 0)
            {
                if(video.getPath() == mediaPlayer.URL)
                {
                    MessageBox.Show("Cannot remove the video that is currently being played");
                }
                else
                {
                    File.Delete(video.getPath());
                    DataRowView drv = (DataRowView)videoList.SelectedItem;
                    String valueOfItem = drv["Name"].ToString();
                    drv.Delete();
                    File.Delete(video.getPath());
                }
            }
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            if(videoList.Items.Count > 0)
            {
                DataView dvEmployeeView = dtCountries.DefaultView;
                dvEmployeeView.RowFilter = "Country LIKE '%" + filterBox.Text + "%'";
            }

        }

        private void filterBox_Click(object sender, EventArgs e)
        {
            filterBox.Text = "";
        }
    }
}

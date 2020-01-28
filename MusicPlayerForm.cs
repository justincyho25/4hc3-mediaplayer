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
using AxWMPLib;
using System.Collections.Specialized;

namespace JWMSMediaPlayer
{


    public partial class MusicPlayerForm : Form
    {
        public string selectedPlaylist;
        int rowNum;
        public List<string>list2 = new List<string>();
        public List<string> Allsongs = new List<string>();
        public Dictionary<string, List<string>> playlister = new Dictionary<string, List<string>>();
        public string playlistval;
        
        public int plcounter = 0;
        public MusicPlayerForm()
        {
            InitializeComponent();

            playPauseButton.Tag = "Play";
            playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.play;

            label1.Text = "00:00:00";
            volumeBar.Value = (mediaPlayer.settings.volume / 10);
            muteUnmuteButton.Tag = "Unmuted";


            mediaPlayer.stretchToFit = true;
            playList.Items.Clear();
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
        string[] files, paths;

        private void addVideoButton_Click(object sender, EventArgs e)
        {
            string sTitle;
            string sSinger;
            string spath;
            OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "All Files|*.*|WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" };
            
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {

                    byte[] b = new byte[128];

                    FileStream fs = new FileStream(paths[i], FileMode.Open, FileAccess.Read);
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(b, 0, 128);
                    bool isSet = false;
                    String sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
                    if (sFlag.CompareTo("TAG") == 0)
                    {
                        System.Console.WriteLine("Tag   is   setted! ");
                        isSet = true;
                    }

                    if (!Allsongs.Contains(paths[i] )){

                      if  (isSet)
                    {
                            //get   title   of   song; 


                            sTitle = System.Text.Encoding.Default.GetString(b, 3, 30);
                            sSinger = System.Text.Encoding.Default.GetString(b, 33, 30);

                            if (sTitle.Contains("\0"))
                            {
                                spath = paths[i];
                                sTitle = Path.GetFileName(spath);
                            }

                            spath = paths[i];
                            songs.Rows.Add(sSinger, sTitle, spath);
                            sTitle = null;
                            Allsongs.Add(spath);



                            //get   singer; 


                        }

                    else if (isSet == false)
                        {
                            string sNamer = ofd.SafeFileName;
                            //get   title   of   song; 
                            spath = paths[i];
                            sTitle = Path.GetFileName(spath);
                            songs.Rows.Add(" ", sTitle, spath);
                            Allsongs.Add(spath);
                        }
                        fs.Close();



                    }
                 
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
                if (!(dtCountries.Rows.Contains(f.FileName)))
                {
                    dtCountries.Rows.Add(f.FileName, f.Path);
                    dtCountries.NewRow();
                }
            }

            playList.DataSource = dtCountries;
            playList.DisplayMember = "Country";

            return dtCountries;
        }




        private void VideoPlayerForm_Load(object sender, EventArgs e)
        {
            playList.ValueMember = "Path";
            playList.DisplayMember = "FileName";
            mediaPlayer.Ctlcontrols.pause();

            timer1.Interval = 1000;
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            rowNum = songs.CurrentCell.RowIndex;
            string currentSong= (string)songs[2, rowNum].Value;

            try
            {

                if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {

                    playPauseButton.Tag = "Play";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.play;
                    mediaPlayer.Ctlcontrols.pause();
                }
                else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
                {

                   
                    

                    if (mediaPlayer.URL == currentSong)
                    {
                        playPauseButton.Tag = "Pause";
                        playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                        mediaPlayer.Ctlcontrols.play();
                    }
                    else if (mediaPlayer.URL != currentSong)
                    {

                        mediaPlayer.URL = currentSong;
                        playPauseButton.Tag = "Pause";
                        playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                        mediaPlayer.Ctlcontrols.play();
                    }
                }
                else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                {

                    string urlLast = (string)songs[2, rowNum].Value;
                    if (mediaPlayer.URL == urlLast)
                    {
                        playPauseButton.Tag = "Pause";
                        playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                        mediaPlayer.Ctlcontrols.play();
                    }
                    else if (mediaPlayer.URL != currentSong)
                    {
                        mediaPlayer.URL = currentSong;
                        playPauseButton.Tag = "Pause";
                        playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                        mediaPlayer.Ctlcontrols.play();
                    }
                }
                else if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsUndefined)
                {
                    rowNum = songs.CurrentCell.RowIndex;
                    mediaPlayer.URL = (string)songs[2, rowNum].Value;

                    mediaPlayer.URL = currentSong;
                    playPauseButton.Tag = "Pause";
                    playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
                    mediaPlayer.Ctlcontrols.play();
                }
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("No Song playing");
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
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
            if (muteUnmuteButton.Tag.Equals("Unmuted"))
            {
                muteUnmuteButton.Tag = "Muted";
                mediaPlayer.settings.mute = true;
                muteUnmuteButton.Image = JWMSMediaPlayer.Properties.Resources.mute;
            }
            else if (muteUnmuteButton.Tag.Equals("Muted"))
            {
                muteUnmuteButton.Tag = "Unmuted";
                mediaPlayer.settings.mute = false;
                muteUnmuteButton.Image = JWMSMediaPlayer.Properties.Resources.unmuute;
            }
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            //mediaPlayer.fullScreen = true;
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                //maximizeButton.Image = JWMSMediaPlayer.Properties.Resources.minimize;

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
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                //maximizeButton.Image = JWMSMediaPlayer.Properties.Resources.maximize;

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
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.tableLayoutPanel1.RowStyles[3].SizeType = SizeType.Absolute;
                this.tableLayoutPanel1.RowStyles[3].Height = 45;
            }
        }

        private void nextItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                songs.Rows[rowNum].Selected = false;
                rowNum++;
                songs.Rows[rowNum].Selected = true;

                mediaPlayer.URL = (string)songs[2, rowNum].Value;
                //if (playList.SelectedIndex < playList.Items.Count - 1)
                //{
                //    playList.SelectedIndex = playList.SelectedIndex + 1;
                //}

                //MediaFile file = playList.SelectedItem as MediaFile;
                //if (file != null)
                //{
                //    video.setPath(file.Path);
                //}

                //mediaPlayer.URL = video.getPath();
                ////Set to play

                mediaPlayer.Ctlcontrols.play();

                ////Reset buttons:
                playPauseButton.Tag = "Pause";
                playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
            }
            catch (Exception)
            {
            }
           
        }

        private void previousItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                songs.Rows[rowNum].Selected = false;
                rowNum--;
                songs.Rows[rowNum].Selected = true;

                mediaPlayer.URL = (string)songs[2, rowNum].Value;

                mediaPlayer.URL = video.getPath();
                //Set to play
                mediaPlayer.Ctlcontrols.play();

                //Reset buttons:
                playPauseButton.Tag = "Pause";
                playPauseButton.Image = JWMSMediaPlayer.Properties.Resources.pause;
            }

            catch (Exception)
            {

            }
        }
        private void removeButton_Click(object sender, EventArgs e)
        {

            playList.Items.Remove(playList.SelectedItem);
            button2.PerformClick();
        }




        private void addToPlayList_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                selectedPlaylist = playList.SelectedItem.ToString();
                string playlistString;
                string artist;
                string songNamer;
                string pathName;

                List<DataGridViewRow> rows_with_checked_column = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in songs.Rows)
                {
                    
                    if (Convert.ToBoolean(row.Cells[Selection.Name].Value) == true)
                    {
                        artist = (string)row.Cells[Artist.Name].Value;
                        artist = artist.Replace("\0", string.Empty);
                        songNamer = (string)row.Cells[song.Name].Value;
                        songNamer.Replace("\0", string.Empty);
                        pathName = (string)row.Cells[path.Name].Value;
                        pathName.Replace("\0", string.Empty);
                        playlistString = (selectedPlaylist + " " + pathName);
                        if (!list2.Contains(playlistString))
                        {
                            list2.Add(playlistString);
                            count++;
                        }
                        

                    }
                   

                }
                MessageBox.Show(count + " songs have been added to "+selectedPlaylist);

            }
            catch(NullReferenceException)
            {
                MessageBox.Show("no songs to add");
            }

            }
        private void playList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
      //      list<string> paths  = new list<string>()
            try {
                string findplayList;
                string getplaylistName;
                string foundplaylist;
                string playListword;
                int playListWordLength;

                songs.Rows.Clear();
                songs.Refresh();
                playListword = (playList.SelectedItem.ToString());
                playListWordLength = playListword.Length;

                for (int i = 0; i < list2.Count; i++)
                {
                    findplayList = list2[i];
                    getplaylistName = findplayList.Substring(0, playListWordLength);

                    if (getplaylistName == playList.SelectedItem.ToString())
                    {
                        foundplaylist = list2[i];
                        string[] playlistValues = foundplaylist.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                        string filepath = foundplaylist.Substring(playlistValues[0].Length + 1, foundplaylist.Length - (playlistValues[0].Length + 1)).Replace(@"\\", @"\");
                        byte[] b = new byte[128];
                        string sTitle;
                        string sSinger;
                        string spath;
                        FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                        fs.Seek(-128, SeekOrigin.End);
                        fs.Read(b, 0, 128);
                        bool isSet = false;
                        String sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
                        if (sFlag.CompareTo("TAG") == 0)
                        {
                            System.Console.WriteLine("Tag   is   setted! ");
                            isSet = true;
                        }

                        if (isSet)
                        {
                            //get   title   of   song; 


                            sTitle = System.Text.Encoding.Default.GetString(b, 3, 30);
                            sSinger = System.Text.Encoding.Default.GetString(b, 33, 30);

                            if (sTitle.Contains("\0"))
                            {
                                spath = filepath;
                                sTitle = Path.GetFileName(spath);
                            }

                            spath = filepath;
                            songs.Rows.Add(sSinger, sTitle, spath);
                            sTitle = null;




                            //get   singer; 


                        }

                        else if (isSet == false)
                        {
                            //get   title   of   song; 
                            spath = filepath;
                            sTitle = Path.GetFileName(spath);
                            songs.Rows.Add(" ", sTitle, spath);

                        }
                        fs.Close();
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please Create a Playlist");
            }
            }



        private void DeleteSong_Click(object sender, EventArgs e)
        {

            try
            {
                RemoveForm rm = new RemoveForm();
                rm.ShowDialog();
                string option;
                option = rm.optionValue;
                List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                foreach (DataGridViewCell c in this.songs.SelectedCells)

                {

                    c.Selected = false;

                }
                foreach (DataGridViewRow row in songs.Rows)
                {
                    if (option == "ML")
                    {
                        if (Convert.ToBoolean(row.Cells[Selection.Name].Value) == true)
                        {
                            //songs.Rows.Remove();
                            rowsToDelete.Add(row);
                        }
                    }

                    else if (option == "MLC")
                    {
                        if (Convert.ToBoolean(row.Cells[Selection.Name].Value) == true)
                        {
                            rowsToDelete.Add(row);
                            string pathtoDelete = row.Cells[2].Value.ToString();
                            {
                                File.Delete(pathtoDelete);
                            }
                        }
                    }
                }

                foreach (DataGridViewRow row in rowsToDelete)
                {
                    songs.Rows.Remove(row);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("no song to delete");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("please enter option name");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PlaylistName pln = new PlaylistName();
                pln.ShowDialog();

                string test = pln.PlayListNameFormValue;
                playList.Items.Add(test);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("please enter playList name");
            }



        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            songs.Rows.Clear();
            songs.Refresh();
            try
            {
                songs.Rows.Clear();
                for (int i = 0; i < Allsongs.Count; i++)
                {

                    byte[] b = new byte[128];
                    string sTitle;
                    string sSinger;
                    string spath;
                    FileStream fs = new FileStream(Allsongs[i], FileMode.Open, FileAccess.Read);
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(b, 0, 128);
                    bool isSet = false;
                    String sFlag = System.Text.Encoding.Default.GetString(b, 0, 3);
                    if (sFlag.CompareTo("TAG") == 0)
                    {
                        System.Console.WriteLine("Tag   is   setted! ");
                        isSet = true;
                    }

                    if (isSet)
                    {

                        sTitle = System.Text.Encoding.Default.GetString(b, 3, 30);
                        sSinger = System.Text.Encoding.Default.GetString(b, 33, 30);

                        if (sTitle.Contains("\0"))
                        {
                            spath = Allsongs[i];
                            sTitle = Path.GetFileName(spath);
                        }

                        spath = Allsongs[i];
                        songs.Rows.Add(sSinger, sTitle, spath);
                        sTitle = null;
                        

                        //get   singer; 

                    }

                    else if (isSet == false)
                    {
                        //get   title   of   song; 
                        spath = Allsongs[i];
                        sTitle = Path.GetFileName(spath);
                        songs.Rows.Add(" ", sTitle, spath);
                    }
                    fs.Close();

                }
                songs.Refresh();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("please add song");
            }
        }



    }
}

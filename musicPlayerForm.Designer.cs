namespace JWMSMediaPlayer
{
    partial class MusicPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.muteUnmuteButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.nextItemButton = new System.Windows.Forms.Button();
            this.previousItemButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.addMusicButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteSong = new System.Windows.Forms.Button();
            this.addToPlayList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.songs = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.playList = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98638F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.01363F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.playList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.528428F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.47157F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1173, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(178, 601);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(992, 28);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.51145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.48855F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.muteUnmuteButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.playPauseButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextItemButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.previousItemButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.volumeBar, 8, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(178, 635);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(992, 44);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // muteUnmuteButton
            // 
            this.muteUnmuteButton.Image = global::JWMSMediaPlayer.Properties.Resources.unmuute;
            this.muteUnmuteButton.Location = new System.Drawing.Point(805, 3);
            this.muteUnmuteButton.Name = "muteUnmuteButton";
            this.muteUnmuteButton.Size = new System.Drawing.Size(42, 38);
            this.muteUnmuteButton.TabIndex = 7;
            this.muteUnmuteButton.UseVisualStyleBackColor = true;
            this.muteUnmuteButton.Click += new System.EventHandler(this.muteUnmuteButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Image = global::JWMSMediaPlayer.Properties.Resources.play;
            this.playPauseButton.Location = new System.Drawing.Point(436, 3);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(53, 38);
            this.playPauseButton.TabIndex = 4;
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // nextItemButton
            // 
            this.nextItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextItemButton.Image = global::JWMSMediaPlayer.Properties.Resources.media_next;
            this.nextItemButton.Location = new System.Drawing.Point(495, 3);
            this.nextItemButton.Name = "nextItemButton";
            this.nextItemButton.Size = new System.Drawing.Size(100, 38);
            this.nextItemButton.TabIndex = 9;
            this.nextItemButton.UseVisualStyleBackColor = true;
            this.nextItemButton.Click += new System.EventHandler(this.nextItemButton_Click);
            // 
            // previousItemButton
            // 
            this.previousItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousItemButton.Image = global::JWMSMediaPlayer.Properties.Resources.media_previous;
            this.previousItemButton.Location = new System.Drawing.Point(331, 3);
            this.previousItemButton.Name = "previousItemButton";
            this.previousItemButton.Size = new System.Drawing.Size(99, 38);
            this.previousItemButton.TabIndex = 10;
            this.previousItemButton.UseVisualStyleBackColor = true;
            this.previousItemButton.Click += new System.EventHandler(this.previousItemButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(857, 3);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(120, 38);
            this.volumeBar.TabIndex = 6;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.53226F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.46774F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(992, 45);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.addMusicButton, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(158, 39);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // addMusicButton
            // 
            this.addMusicButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMusicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMusicButton.Location = new System.Drawing.Point(3, 3);
            this.addMusicButton.Name = "addMusicButton";
            this.addMusicButton.Size = new System.Drawing.Size(152, 33);
            this.addMusicButton.TabIndex = 2;
            this.addMusicButton.Text = "Add Music";
            this.addMusicButton.UseVisualStyleBackColor = true;
            this.addMusicButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.20242F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.79758F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel9.Controls.Add(this.DeleteSong, 4, 0);
            this.tableLayoutPanel9.Controls.Add(this.addToPlayList, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(167, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(822, 39);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // DeleteSong
            // 
            this.DeleteSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteSong.Location = new System.Drawing.Point(688, 3);
            this.DeleteSong.Name = "DeleteSong";
            this.DeleteSong.Size = new System.Drawing.Size(131, 33);
            this.DeleteSong.TabIndex = 6;
            this.DeleteSong.Text = "Delete Song ";
            this.DeleteSong.UseVisualStyleBackColor = true;
            this.DeleteSong.Click += new System.EventHandler(this.DeleteSong_Click);
            // 
            // addToPlayList
            // 
            this.addToPlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addToPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addToPlayList.Location = new System.Drawing.Point(543, 3);
            this.addToPlayList.Name = "addToPlayList";
            this.addToPlayList.Size = new System.Drawing.Size(139, 33);
            this.addToPlayList.TabIndex = 3;
            this.addToPlayList.Text = "Add to PlayList";
            this.addToPlayList.UseVisualStyleBackColor = true;
            this.addToPlayList.Click += new System.EventHandler(this.addToPlayList_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(407, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "All Songs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(169, 45);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.mainMenuButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(163, 39);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(3, 3);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(157, 33);
            this.mainMenuButton.TabIndex = 3;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.77962F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(178, 54);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.02797F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(992, 541);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.songs, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.mediaPlayer, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.00935F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.990654F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(986, 535);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // songs
            // 
            this.songs.AllowUserToAddRows = false;
            this.songs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.songs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.songs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.songs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.song,
            this.path,
            this.Selection});
            this.songs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songs.Location = new System.Drawing.Point(3, 3);
            this.songs.Name = "songs";
            this.songs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.songs.Size = new System.Drawing.Size(980, 513);
            this.songs.TabIndex = 18;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // song
            // 
            this.song.HeaderText = "Song";
            this.song.Name = "song";
            // 
            // path
            // 
            this.path.HeaderText = "path";
            this.path.Name = "path";
            this.path.Visible = false;
            // 
            // Selection
            // 
            this.Selection.HeaderText = "Selection";
            this.Selection.Name = "Selection";
            this.Selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(26, 524);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(934, 6);
            this.mediaPlayer.TabIndex = 3;
            this.mediaPlayer.Visible = false;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.playList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.playList.FormattingEnabled = true;
            this.playList.Items.AddRange(new object[] {
            ""});
            this.playList.Location = new System.Drawing.Point(3, 54);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(169, 541);
            this.playList.TabIndex = 1;
            this.playList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.playList_MouseDoubleClick);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(3, 601);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(169, 28);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove Playlist";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MusicPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MusicPlayerForm";
            this.Text = "VideoPlayerForm";
            this.Load += new System.EventHandler(this.VideoPlayerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button muteUnmuteButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.Button nextItemButton;
        private System.Windows.Forms.Button previousItemButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button addMusicButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button DeleteSong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addToPlayList;
        private System.Windows.Forms.DataGridView songs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn song;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}
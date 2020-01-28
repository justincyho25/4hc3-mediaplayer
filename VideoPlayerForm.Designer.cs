namespace JWMSMediaPlayer
{
    partial class VideoPlayerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayerForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.videoList = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.muteUnmuteButton = new System.Windows.Forms.Button();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.nextItemButton = new System.Windows.Forms.Button();
            this.previousItemButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.addVideoButton = new System.Windows.Forms.Button();
            this.filterBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98638F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.01363F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.mediaPlayer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.521739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.47826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(173, 42);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(962, 553);
            this.mediaPlayer.TabIndex = 0;
            this.mediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayer_PlayStateChange);
            this.mediaPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.mediaPlayer_MouseMoveEvent);
            // 
            // videoList
            // 
            this.videoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoList.FormattingEnabled = true;
            this.videoList.Location = new System.Drawing.Point(3, 42);
            this.videoList.Name = "videoList";
            this.videoList.Size = new System.Drawing.Size(164, 553);
            this.videoList.TabIndex = 1;
            this.videoList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(173, 601);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(962, 28);
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.maximizeButton, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.volumeBar, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.muteUnmuteButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.playPauseButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextItemButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.previousItemButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(173, 635);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(962, 44);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Image = global::JWMSMediaPlayer.Properties.Resources.maximize;
            this.maximizeButton.Location = new System.Drawing.Point(874, 3);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(63, 38);
            this.maximizeButton.TabIndex = 8;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(735, 3);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(132, 38);
            this.volumeBar.TabIndex = 6;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // muteUnmuteButton
            // 
            this.muteUnmuteButton.Image = global::JWMSMediaPlayer.Properties.Resources.unmuute;
            this.muteUnmuteButton.Location = new System.Drawing.Point(687, 3);
            this.muteUnmuteButton.Name = "muteUnmuteButton";
            this.muteUnmuteButton.Size = new System.Drawing.Size(42, 38);
            this.muteUnmuteButton.TabIndex = 7;
            this.muteUnmuteButton.UseVisualStyleBackColor = true;
            this.muteUnmuteButton.Click += new System.EventHandler(this.muteUnmuteButton_Click);
            // 
            // playPauseButton
            // 
            this.playPauseButton.Image = global::JWMSMediaPlayer.Properties.Resources.play;
            this.playPauseButton.Location = new System.Drawing.Point(431, 3);
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
            this.nextItemButton.Location = new System.Drawing.Point(490, 3);
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
            this.previousItemButton.Location = new System.Drawing.Point(326, 3);
            this.previousItemButton.Name = "previousItemButton";
            this.previousItemButton.Size = new System.Drawing.Size(99, 38);
            this.previousItemButton.TabIndex = 10;
            this.previousItemButton.UseVisualStyleBackColor = true;
            this.previousItemButton.Click += new System.EventHandler(this.previousItemButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(3, 601);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(164, 28);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.89529F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.10471F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel3.Controls.Add(this.addVideoButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.filterBox, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(173, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(962, 33);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // addVideoButton
            // 
            this.addVideoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addVideoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVideoButton.Location = new System.Drawing.Point(3, 3);
            this.addVideoButton.Name = "addVideoButton";
            this.addVideoButton.Size = new System.Drawing.Size(146, 27);
            this.addVideoButton.TabIndex = 2;
            this.addVideoButton.Text = "Add Video";
            this.addVideoButton.UseVisualStyleBackColor = true;
            this.addVideoButton.Click += new System.EventHandler(this.addVideoButton_Click);
            // 
            // filterBox
            // 
            this.filterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBox.Location = new System.Drawing.Point(767, 3);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(192, 26);
            this.filterBox.TabIndex = 3;
            this.filterBox.Text = "Filter...";
            this.filterBox.Click += new System.EventHandler(this.filterBox_Click);
            this.filterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.mainMenuButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 33);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuButton.Location = new System.Drawing.Point(3, 3);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(158, 27);
            this.mainMenuButton.TabIndex = 3;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VideoPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VideoPlayerForm";
            this.Text = "VideoPlayerForm";
            this.Load += new System.EventHandler(this.VideoPlayerForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.ListBox videoList;
        private System.Windows.Forms.Button addVideoButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button muteUnmuteButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button nextItemButton;
        private System.Windows.Forms.Button previousItemButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Timer timer2;
    }
}
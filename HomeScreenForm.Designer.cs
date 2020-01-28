namespace JWMSMediaPlayer
{
    partial class HomeScreenForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.musicPlayerButton = new System.Windows.Forms.Button();
            this.videoPlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.7757F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.2243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Controls.Add(this.musicPlayerButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoPlayerButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.35294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1117, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // musicPlayerButton
            // 
            this.musicPlayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicPlayerButton.Image = global::JWMSMediaPlayer.Properties.Resources.Music_Button1;
            this.musicPlayerButton.Location = new System.Drawing.Point(273, 280);
            this.musicPlayerButton.Name = "musicPlayerButton";
            this.musicPlayerButton.Size = new System.Drawing.Size(573, 139);
            this.musicPlayerButton.TabIndex = 0;
            this.musicPlayerButton.UseVisualStyleBackColor = true;
            this.musicPlayerButton.Click += new System.EventHandler(this.musicPlayerButton_Click);
            // 
            // videoPlayerButton
            // 
            this.videoPlayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayerButton.Image = global::JWMSMediaPlayer.Properties.Resources.Video_Player_Icon1;
            this.videoPlayerButton.Location = new System.Drawing.Point(273, 469);
            this.videoPlayerButton.Name = "videoPlayerButton";
            this.videoPlayerButton.Size = new System.Drawing.Size(573, 135);
            this.videoPlayerButton.TabIndex = 1;
            this.videoPlayerButton.UseVisualStyleBackColor = true;
            this.videoPlayerButton.Click += new System.EventHandler(this.videoPlayerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 277);
            this.label1.TabIndex = 2;
            this.label1.Text = "JWMS Media Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 697);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HomeScreenForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button musicPlayerButton;
        private System.Windows.Forms.Button videoPlayerButton;
        private System.Windows.Forms.Label label1;
    }
}


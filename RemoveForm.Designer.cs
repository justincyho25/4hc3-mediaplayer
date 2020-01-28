namespace JWMSMediaPlayer
{
    partial class RemoveForm
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
            this.rmML = new System.Windows.Forms.CheckBox();
            this.rmMLC = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rmML
            // 
            this.rmML.AutoSize = true;
            this.rmML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmML.Location = new System.Drawing.Point(145, 180);
            this.rmML.Name = "rmML";
            this.rmML.Size = new System.Drawing.Size(192, 24);
            this.rmML.TabIndex = 0;
            this.rmML.Text = "Delete From Media List";
            this.rmML.UseVisualStyleBackColor = true;
            // 
            // rmMLC
            // 
            this.rmMLC.AutoSize = true;
            this.rmMLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmMLC.Location = new System.Drawing.Point(145, 254);
            this.rmMLC.Name = "rmMLC";
            this.rmMLC.Size = new System.Drawing.Size(294, 24);
            this.rmMLC.TabIndex = 1;
            this.rmMLC.Text = "Delete from Media List And Computer";
            this.rmMLC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(145, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm Deletion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose from the following deletion options:";
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rmMLC);
            this.Controls.Add(this.rmML);
            this.Name = "RemoveForm";
            this.Text = "Remove Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rmML;
        private System.Windows.Forms.CheckBox rmMLC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
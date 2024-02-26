namespace HashComparer
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.topPanel = new System.Windows.Forms.Panel();
            this.softLabel = new System.Windows.Forms.Label();
            this.picGit_btn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.topPanel.Controls.Add(this.pictureBox3);
            this.topPanel.Controls.Add(this.softLabel);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(309, 35);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // softLabel
            // 
            this.softLabel.AutoSize = true;
            this.softLabel.Font = new System.Drawing.Font("Consolas", 10.75F, System.Drawing.FontStyle.Bold);
            this.softLabel.ForeColor = System.Drawing.Color.White;
            this.softLabel.Location = new System.Drawing.Point(39, 10);
            this.softLabel.Name = "softLabel";
            this.softLabel.Size = new System.Drawing.Size(48, 18);
            this.softLabel.TabIndex = 4;
            this.softLabel.Text = "About";
            // 
            // picGit_btn
            // 
            this.picGit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGit_btn.Image = global::HashComparer.Properties.Resources.phonk_skull;
            this.picGit_btn.Location = new System.Drawing.Point(81, 43);
            this.picGit_btn.Name = "picGit_btn";
            this.picGit_btn.Size = new System.Drawing.Size(150, 140);
            this.picGit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGit_btn.TabIndex = 5;
            this.picGit_btn.TabStop = false;
            this.picGit_btn.Click += new System.EventHandler(this.picGit_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HashComparer.Properties.Resources.hash_logo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::HashComparer.Properties.Resources.Close;
            this.closeBtn.Location = new System.Drawing.Point(273, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Simple hash comparer tool \r\n      By k3rnel-dev";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(309, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGit_btn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HashComparer - [ Form: About ]";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label softLabel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox picGit_btn;
        private System.Windows.Forms.Label label1;
    }
}
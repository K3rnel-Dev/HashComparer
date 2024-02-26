namespace HashComparer
{
    partial class Comparer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparer));
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.softLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.compare_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFileCompare_btn = new System.Windows.Forms.Button();
            this.selectFile_box = new System.Windows.Forms.TextBox();
            this.hashToCompare_Line = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusLabel = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.topPanel.Size = new System.Drawing.Size(453, 35);
            this.topPanel.TabIndex = 1;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
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
            // softLabel
            // 
            this.softLabel.AutoSize = true;
            this.softLabel.Font = new System.Drawing.Font("Consolas", 10.75F, System.Drawing.FontStyle.Bold);
            this.softLabel.ForeColor = System.Drawing.Color.White;
            this.softLabel.Location = new System.Drawing.Point(39, 10);
            this.softLabel.Name = "softLabel";
            this.softLabel.Size = new System.Drawing.Size(208, 18);
            this.softLabel.TabIndex = 4;
            this.softLabel.Text = "HashComparer - [ V. 1.0 ]";
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::HashComparer.Properties.Resources.Close;
            this.closeBtn.Location = new System.Drawing.Point(419, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // compare_btn
            // 
            this.compare_btn.BackColor = System.Drawing.Color.Black;
            this.compare_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.compare_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compare_btn.ForeColor = System.Drawing.Color.White;
            this.compare_btn.Location = new System.Drawing.Point(141, 160);
            this.compare_btn.Name = "compare_btn";
            this.compare_btn.Size = new System.Drawing.Size(191, 47);
            this.compare_btn.TabIndex = 7;
            this.compare_btn.Text = "COMPARE";
            this.compare_btn.UseVisualStyleBackColor = false;
            this.compare_btn.Click += new System.EventHandler(this.compare_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MATCHED - Hash is match\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "PATH FILE";
            // 
            // selectFileCompare_btn
            // 
            this.selectFileCompare_btn.BackColor = System.Drawing.Color.Black;
            this.selectFileCompare_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.selectFileCompare_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileCompare_btn.ForeColor = System.Drawing.Color.White;
            this.selectFileCompare_btn.Location = new System.Drawing.Point(388, 123);
            this.selectFileCompare_btn.Name = "selectFileCompare_btn";
            this.selectFileCompare_btn.Size = new System.Drawing.Size(61, 25);
            this.selectFileCompare_btn.TabIndex = 13;
            this.selectFileCompare_btn.Text = "SELECT";
            this.selectFileCompare_btn.UseVisualStyleBackColor = false;
            this.selectFileCompare_btn.Click += new System.EventHandler(this.selectFileCompare_btn_Click);
            // 
            // selectFile_box
            // 
            this.selectFile_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selectFile_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectFile_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFile_box.ForeColor = System.Drawing.Color.LightGreen;
            this.selectFile_box.Location = new System.Drawing.Point(116, 126);
            this.selectFile_box.Multiline = true;
            this.selectFile_box.Name = "selectFile_box";
            this.selectFile_box.Size = new System.Drawing.Size(272, 22);
            this.selectFile_box.TabIndex = 11;
            // 
            // hashToCompare_Line
            // 
            this.hashToCompare_Line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hashToCompare_Line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashToCompare_Line.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hashToCompare_Line.ForeColor = System.Drawing.Color.LightGreen;
            this.hashToCompare_Line.Location = new System.Drawing.Point(110, 85);
            this.hashToCompare_Line.Multiline = true;
            this.hashToCompare_Line.Name = "hashToCompare_Line";
            this.hashToCompare_Line.Size = new System.Drawing.Size(339, 22);
            this.hashToCompare_Line.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "FILE HASH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(2, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOMATCHED - Hash is no match\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 81);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMATION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(3, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "FORM [ HASH-COMPARE ] - HASH: MD5";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.statusLabel.Location = new System.Drawing.Point(211, 297);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(142, 23);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "STATUS: idle";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.Black;
            this.reset_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Location = new System.Drawing.Point(21, 160);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(103, 47);
            this.reset_btn.TabIndex = 20;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Comparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(453, 332);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashToCompare_Line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFileCompare_btn);
            this.Controls.Add(this.selectFile_box);
            this.Controls.Add(this.compare_btn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comparer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashComparer - [ Form: Comparer ]";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label softLabel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Button compare_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectFileCompare_btn;
        private System.Windows.Forms.TextBox selectFile_box;
        private System.Windows.Forms.TextBox hashToCompare_Line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button reset_btn;
    }
}
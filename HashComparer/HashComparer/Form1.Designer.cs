namespace HashComparer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.softLabel = new System.Windows.Forms.Label();
            this.selectFile_box = new System.Windows.Forms.TextBox();
            this.selectFile_Label = new System.Windows.Forms.Button();
            this.hashLog_Panel = new System.Windows.Forms.RichTextBox();
            this.clearLog_btn = new System.Windows.Forms.Button();
            this.copyClipboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.openComporer_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.minimazeBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.topPanel.Controls.Add(this.pictureBox3);
            this.topPanel.Controls.Add(this.softLabel);
            this.topPanel.Controls.Add(this.minimazeBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(577, 35);
            this.topPanel.TabIndex = 0;
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
            this.softLabel.Size = new System.Drawing.Size(208, 18);
            this.softLabel.TabIndex = 4;
            this.softLabel.Text = "HashComparer - [ V. 1.0 ]";
            // 
            // selectFile_box
            // 
            this.selectFile_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.selectFile_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectFile_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectFile_box.ForeColor = System.Drawing.Color.LightGreen;
            this.selectFile_box.Location = new System.Drawing.Point(98, 89);
            this.selectFile_box.Multiline = true;
            this.selectFile_box.Name = "selectFile_box";
            this.selectFile_box.Size = new System.Drawing.Size(308, 22);
            this.selectFile_box.TabIndex = 1;
            // 
            // selectFile_Label
            // 
            this.selectFile_Label.BackColor = System.Drawing.Color.Black;
            this.selectFile_Label.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.selectFile_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile_Label.ForeColor = System.Drawing.Color.White;
            this.selectFile_Label.Location = new System.Drawing.Point(412, 86);
            this.selectFile_Label.Name = "selectFile_Label";
            this.selectFile_Label.Size = new System.Drawing.Size(90, 25);
            this.selectFile_Label.TabIndex = 6;
            this.selectFile_Label.Text = "SELECT";
            this.selectFile_Label.UseVisualStyleBackColor = false;
            this.selectFile_Label.Click += new System.EventHandler(this.selectFile_Label_Click);
            // 
            // hashLog_Panel
            // 
            this.hashLog_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hashLog_Panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashLog_Panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hashLog_Panel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hashLog_Panel.ForeColor = System.Drawing.Color.LightGreen;
            this.hashLog_Panel.Location = new System.Drawing.Point(12, 128);
            this.hashLog_Panel.Name = "hashLog_Panel";
            this.hashLog_Panel.Size = new System.Drawing.Size(551, 300);
            this.hashLog_Panel.TabIndex = 7;
            this.hashLog_Panel.Text = "HashComparer Tool: Ready";
            // 
            // clearLog_btn
            // 
            this.clearLog_btn.BackColor = System.Drawing.Color.Black;
            this.clearLog_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.clearLog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLog_btn.ForeColor = System.Drawing.Color.White;
            this.clearLog_btn.Location = new System.Drawing.Point(139, 435);
            this.clearLog_btn.Name = "clearLog_btn";
            this.clearLog_btn.Size = new System.Drawing.Size(108, 30);
            this.clearLog_btn.TabIndex = 8;
            this.clearLog_btn.Text = "CLEAR-FORMS";
            this.clearLog_btn.UseVisualStyleBackColor = false;
            this.clearLog_btn.Click += new System.EventHandler(this.clearLog_btn_Click);
            // 
            // copyClipboard_btn
            // 
            this.copyClipboard_btn.BackColor = System.Drawing.Color.Black;
            this.copyClipboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.copyClipboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyClipboard_btn.ForeColor = System.Drawing.Color.White;
            this.copyClipboard_btn.Location = new System.Drawing.Point(16, 435);
            this.copyClipboard_btn.Name = "copyClipboard_btn";
            this.copyClipboard_btn.Size = new System.Drawing.Size(117, 30);
            this.copyClipboard_btn.TabIndex = 9;
            this.copyClipboard_btn.Text = "Copy all to clipboard";
            this.copyClipboard_btn.UseVisualStyleBackColor = false;
            this.copyClipboard_btn.Click += new System.EventHandler(this.copyClipboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "PATH FILE";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "FORM [ HASH-GET ]";
            // 
            // openComporer_btn
            // 
            this.openComporer_btn.BackColor = System.Drawing.Color.Black;
            this.openComporer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.openComporer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openComporer_btn.ForeColor = System.Drawing.Color.White;
            this.openComporer_btn.Location = new System.Drawing.Point(253, 435);
            this.openComporer_btn.Name = "openComporer_btn";
            this.openComporer_btn.Size = new System.Drawing.Size(161, 30);
            this.openComporer_btn.TabIndex = 12;
            this.openComporer_btn.Text = "HASH-COMPARER-FORM";
            this.openComporer_btn.UseVisualStyleBackColor = false;
            this.openComporer_btn.Click += new System.EventHandler(this.openComporer_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 10);
            this.panel1.TabIndex = 13;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.Location = new System.Drawing.Point(426, 434);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(137, 30);
            this.aboutBtn.TabIndex = 14;
            this.aboutBtn.Text = "ABOUT PROGRAM";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
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
            // minimazeBtn
            // 
            this.minimazeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimazeBtn.Image = global::HashComparer.Properties.Resources.Minimize_Window;
            this.minimazeBtn.Location = new System.Drawing.Point(516, 4);
            this.minimazeBtn.Name = "minimazeBtn";
            this.minimazeBtn.Size = new System.Drawing.Size(27, 25);
            this.minimazeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimazeBtn.TabIndex = 2;
            this.minimazeBtn.TabStop = false;
            this.minimazeBtn.Click += new System.EventHandler(this.minimazeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = global::HashComparer.Properties.Resources.Close;
            this.closeBtn.Location = new System.Drawing.Point(545, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(577, 486);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openComporer_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyClipboard_btn);
            this.Controls.Add(this.clearLog_btn);
            this.Controls.Add(this.hashLog_Panel);
            this.Controls.Add(this.selectFile_Label);
            this.Controls.Add(this.selectFile_box);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HashComprare - [ MAIN ] ";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimazeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimazeBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label softLabel;
        private System.Windows.Forms.TextBox selectFile_box;
        private System.Windows.Forms.Button selectFile_Label;
        private System.Windows.Forms.RichTextBox hashLog_Panel;
        private System.Windows.Forms.Button clearLog_btn;
        private System.Windows.Forms.Button copyClipboard_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openComporer_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button aboutBtn;
    }
}


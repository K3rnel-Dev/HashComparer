using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace HashComparer
{
    public partial class Comparer : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;


        public Comparer()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void selectFileCompare_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Any File";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    string selectedFilePath = openFileDialog1.FileName;

                    selectFile_box.Text = selectedFilePath;

                }
                else
                {
                    MessageBox.Show("Selected file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select file cancelled!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void compare_btn_Click(object sender, EventArgs e)
        {
            string filePath = selectFile_box.Text;
            string hashToCompare = hashToCompare_Line.Text.Trim();


            if (string.IsNullOrEmpty(hashToCompare))
            {
                MessageBox.Show("Hash form cannot be empty!");
                return;
            }

            if (File.Exists(filePath))
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        byte[] hash = md5.ComputeHash(stream);
                        string fileHash = BitConverter.ToString(hash).Replace("-", "").ToLower();

                        if (fileHash.Equals(hashToCompare, StringComparison.OrdinalIgnoreCase))
                        {
                            statusLabel.Text = "STATUS: MATCHED";
                            statusLabel.ForeColor = System.Drawing.Color.LightGreen;
                        }
                        else
                        {
                            statusLabel.Text = "STATUS: NOT MATCHED";
                            statusLabel.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Entered file does exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Aquamarine;
            statusLabel.Text = "STATUS: idle";

            hashToCompare_Line.Clear();
            selectFile_box.Clear();
        }
    }
}

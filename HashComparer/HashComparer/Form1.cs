using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashComparer
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void clearLog_btn_Click(object sender, EventArgs e)
        {
            hashLog_Panel.Clear();
            selectFile_box.Clear();
        }

        private void selectFile_Label_Click(object sender, EventArgs e)
        {
            hashLog_Panel.Clear();
            openFileDialog1.Title = "Open Any File";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    string selectedFilePath = openFileDialog1.FileName;

                    selectFile_box.Text = selectedFilePath;

                    CalculateHashes(selectedFilePath);
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

        private void CalculateHashes(string filePath)
        {
            try
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                {

                    using (MD5 md5 = MD5.Create())
                    using (SHA1 sha1 = SHA1.Create())
                    using (SHA256 sha256 = SHA256.Create())
                    using (CRC32 crc32 = new CRC32())
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;
                        long totalBytesRead = 0;

                        while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            md5.TransformBlock(buffer, 0, bytesRead, null, 0);
                            sha1.TransformBlock(buffer, 0, bytesRead, null, 0);
                            sha256.TransformBlock(buffer, 0, bytesRead, null, 0);
                            crc32.TransformBlock(buffer, 0, bytesRead, null, 0);
                            totalBytesRead += bytesRead;
                        }

                        md5.TransformFinalBlock(buffer, 0, 0);
                        byte[] md5Hash = md5.Hash;
                        DisplayHash("MD5", md5Hash);

                        sha1.TransformFinalBlock(buffer, 0, 0);
                        byte[] sha1Hash = sha1.Hash;
                        DisplayHash("SHA1", sha1Hash);

                        sha256.TransformFinalBlock(buffer, 0, 0);
                        byte[] sha256Hash = sha256.Hash;
                        DisplayHash("SHA256", sha256Hash);

                        crc32.TransformFinalBlock(buffer, 0, 0);
                        byte[] crc32Hash = crc32.Hash;
                        DisplayHash("CRC32", crc32Hash);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating hashes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayHash(string algorithm, byte[] hash)
        {
            StringBuilder hashBuilder = new StringBuilder();
            hashBuilder.Append($"{algorithm} Hash: ");
            foreach (byte b in hash)
            {
                hashBuilder.Append(b.ToString("x2"));
            }
            hashBuilder.AppendLine();
            AppendTextToHashLog(hashBuilder.ToString());
        }

        private void AppendTextToHashLog(string text)
        {
            if (hashLog_Panel.InvokeRequired)
            {
                hashLog_Panel.Invoke(new MethodInvoker(delegate {
                    AppendTextToHashLog(text);
                }));
            }
            else
            {
                hashLog_Panel.AppendText(text);
            }
        }

        private void copyClipboard_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(hashLog_Panel.Text))
            {
                MessageBox.Show("Text copied!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText(hashLog_Panel.Text);

            } else
            {
                MessageBox.Show("Log form is null!");
            }
         }

        private void openComporer_btn_Click(object sender, EventArgs e)
        {
            Comparer formComparer = new Comparer();
            formComparer.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }
    }

    public class CRC32 : HashAlgorithm
    {
        private uint _currentCrcValue = uint.MaxValue;
        private const uint Poly = 0xedb88320;
        private static readonly uint[] Table;
        
        static CRC32()
        {
            Table = new uint[256];
            for (uint i = 0; i < 256; i++)
            {
                uint crc = i;
                for (uint j = 8; j > 0; j--)
                {
                    if ((crc & 1) == 1)
                        crc = (crc >> 1) ^ Poly;
                    else
                        crc >>= 1;
                }
                Table[i] = crc;
            }
        }

        public CRC32()
        {
            HashSizeValue = 32;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            for (int i = ibStart; i < cbSize; i++)
            {
                _currentCrcValue = (_currentCrcValue >> 8) ^ Table[array[i] ^ (_currentCrcValue & 0x000000FF)];
            }
        }

        protected override byte[] HashFinal()
        {
            byte[] hash = BitConverter.GetBytes(~_currentCrcValue);
            HashValue = hash;
            return hash;
        }

        public override void Initialize()
        {
            _currentCrcValue = uint.MaxValue;
        }
    }
}
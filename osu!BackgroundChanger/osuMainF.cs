using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

namespace osu_BackgroundChanger
{
    public partial class osuMainF : Form
    {
        public osuMainF()
        {
            InitializeComponent();
        }

        //I'll do a explaination for those who want read the src
        //So this is for drag the window because I disable the Form Border Style

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void osuMainF_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //The close button is for close the window
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //This one is for minimize the window
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //The info button, it will display a pop up with the text below
        private void InfoButton_Click(object sender, EventArgs e)
        {
            new InfoForms().Show();
        }

        //The convert button will convert your png in jpg
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opnfd.Filter = "Image Files (*.png)|*.png";
            opnfd.Title = "Choose an image please uwu";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                ImagePreview.Image = new Bitmap(opnfd.FileName);
                MessageBox.Show("Done !");
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image Files (*.jpg)|*.jpg";
                sfd.Title = "Save me aaaaaaaaaa";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImagePreview.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        //Import button, it will delete all the seasonal images and replace by your imported image
        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            opnfd.Title = "Select an image pleaseee";
            opnfd.Filter = "Image Files (*.jpg)|*.jpg";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                ImagePreview.Image = new Bitmap(opnfd.FileName);
                label2.Visible = false;
                string title = "Backup confirmation";
                string message = "Do you want to do a backup?";
                string title2 = "Finish";
                string message2 = "Backed up successfully!";
                var result = MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveFileDialog svfd = new SaveFileDialog();
                    svfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    svfd.Filter = "All files(*.*)|*.*";
                    svfd.Title = "Save me";
                    if (svfd.ShowDialog() == DialogResult.OK)
                    {
                        string backupPath = Path.GetFullPath(svfd.FileName);
                        string osuPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"osu!", @"Data", @"bg");
                        DirectoryInfo d = new DirectoryInfo(osuPath);
                        FileInfo[] files = d.GetFiles("*.jpg");
                        var xfiles = Directory.GetFiles(osuPath, "*.jpg");
                        var oldNames = new List<string>(xfiles);
                        foreach (var file in d.GetFiles("*.jpg"))
                        {
                            Directory.Move(file.FullName, backupPath + file.Name);
                        }
                        MessageBox.Show(message2, title2);
                        string source = opnfd.FileName;
                        string destination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"osu!", @"Data", @"bg", Path.GetFileName(source));

                        for (var i = 0; i < oldNames.Count; i++)
                        {
                            File.Copy(source, oldNames[i]);
                        }
                        foreach (var file in d.GetFiles("*.jpg"))
                        {
                            // Lock the file to prevent osu! from redownloading them
                            FileStream fileStream = new FileStream(file.FullName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
                        }
                    }
                }
                if (result == DialogResult.No)
                {
                    string osuPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"osu!", @"Data", @"bg");
                    DirectoryInfo d = new DirectoryInfo(osuPath);
                    FileInfo[] files = d.GetFiles("*.jpg");
                    var xfiles = Directory.GetFiles(osuPath, "*.jpg");
                    var oldNames = new List<string>(xfiles);
                    int fileCount = files.Length;
                    foreach (var file in d.GetFiles("*.jpg"))
                    {
                        file.Delete();
                    }

                    var source = opnfd.FileName;
                    var destination = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"osu!", @"Data", @"bg", Path.GetFileName(source));
                    for (var i = 0; i < oldNames.Count; i++)
                    {
                        File.Copy(source, oldNames[i]);
                    }
                    foreach (var file in d.GetFiles("*.jpg"))
                    {
                        // Lock the file to prevent osu! from redownloading them
                        FileStream fileStream = new FileStream(file.FullName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
                    }
                    string xtitle = "Finished";
                    string xmsg = "Replaced successfully!";
                    MessageBox.Show(xmsg, xtitle);
                }
                MessageBox.Show("Please keep this program open to prevent OSU! from replacing the wallpaper!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //The reset button will delete every files in the osu!\Data\bg path, so the seasonal background will be reset
        private void ResetButton_Click(object sender, EventArgs e)
        {
            string osuPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"osu!", @"Data", @"bg");
            DirectoryInfo d = new DirectoryInfo(osuPath);
            foreach (var file in d.GetFiles())
            {
                file.Delete();
            }
            string title = "Reset";
            string message = "Seasonal background has been resetted successfully!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
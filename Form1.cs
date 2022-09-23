using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Alpays_Radio
{
    public partial class FirstWindow : Form
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        private void OfflineButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath).Where(x => x.EndsWith(".mp3")).ToArray();

                    if (files.Length > 0) 
                    {
                        // Go to next window.
                        OfflineWindow OW = new OfflineWindow();
                        OW.fileNames = files;
                        ActiveForm.Hide();
                        OW.Show();
                    }
                    else 
                    {
                        MessageBox.Show("No mp3 files found in that folder.");
                        return;
                    }
                }
            }
        }

        private void OnlineButton_Click(object sender, EventArgs e)
        {
            OnlineWindow OW = new OnlineWindow();
            ActiveForm.Hide();
            OW.Show();
        }
    }
}

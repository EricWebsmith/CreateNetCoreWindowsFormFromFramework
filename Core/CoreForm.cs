using System;
using System.Windows.Forms;

namespace Core
{
    public partial class CoreForm : Form
    {
        public CoreForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Subtitle files (*.srt)|*.srt";
            if(openFileDlg.ShowDialog() ==DialogResult.OK  )
            {
                srtFileTextBox.Text = openFileDlg.FileName;
            }
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            //do something
            Application.Exit();
        }
    }
}

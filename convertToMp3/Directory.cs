using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace convertToMp3
{
    public partial class Directory : UserControl
    {

        static bool check = false;
        public Directory()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void ChooseDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog ()== DialogResult.OK)
            {
                textBox1.Text = System.IO.Directory.GetCurrentDirectory();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool hasUserEnteredDir()
        {
            return check;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            check = true;
        }
    }
}

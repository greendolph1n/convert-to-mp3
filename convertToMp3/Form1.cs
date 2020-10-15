using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertToMp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Converter.Hide();
            Directory.Hide();
            ErrorNoDir.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool check = Directory.hasUserEnteredDir();

            if (check) {
                Converter.Show();
                Directory.Hide();
                ErrorNoDir.Hide();
            }

            else
            {
                Converter.Hide();
                Directory.Hide();
                ErrorNoDir.Show();
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            Converter.Hide();
            Directory.Show();
            ErrorNoDir.Hide();
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            Converter.Hide();
            Directory.Hide();
            ErrorNoDir.Hide();

        }

        private void ErrorNoDir_Load(object sender, EventArgs e)
        {

        }
    }
}

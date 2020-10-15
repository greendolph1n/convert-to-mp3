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
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool check = userControl21.hasUserEnteredDir();

            if (check) {
                userControl11.Show();
                userControl21.Hide();
                userControl31.Hide();
            }

            else
            {
                userControl11.Hide();
                userControl21.Hide();
                userControl31.Show();
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();

        }
    }
}

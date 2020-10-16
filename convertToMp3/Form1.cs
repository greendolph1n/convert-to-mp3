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

            this.Text = "Youtube to MP3 Converter";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Converter.Hide();
            Directory.Hide();
            playlistConverter1.Hide();
    

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
                playlistConverter1.Hide();

            }

            else
            {
                Converter.Hide();
                Directory.Hide();
                playlistConverter1.Hide();
                MessageBox.Show("You have not specified a directory", "Error");
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            Converter.Hide();
            Directory.Show();
            playlistConverter1.Hide();

        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            bool check = Directory.hasUserEnteredDir();
            if (check)
            {
                Converter.Hide();
                Directory.Hide();
                playlistConverter1.Show();

            }

            else
            {
                Converter.Hide();
                Directory.Hide();
                playlistConverter1.Hide();
                MessageBox.Show("You have not specified a directory", "Error");
            }
        }

    

        private void ErrorNoDir_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void playlistConverter1_Load(object sender, EventArgs e)
        {

        }
    }
}

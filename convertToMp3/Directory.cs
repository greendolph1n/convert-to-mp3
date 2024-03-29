﻿using System;
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
                textBox1.Text = FBD.SelectedPath;
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
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("You haven't entered a directory", "Error");
            }

            else
            {
                ConfirmButton.BackColor = Color.LightGreen;
                string dir = textBox1.Text;
                Converter conv = new Converter();
                conv.getDir(dir);
                PlaylistConverter pconv = new PlaylistConverter();
                pconv.getDir(dir);
                check = true;
            }
        }
    }
}

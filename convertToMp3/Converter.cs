using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace convertToMp3
{

 
    public partial class Converter : UserControl
    {
     

        static string directory;
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            string url = URLbox.Text;
            MessageBox.Show("current directory is"+  directory);
            YoutubeConverter converter = new YoutubeConverter();
            converter.convertURL(url, directory);
        }

        public void getDir(string dir)
        {
             directory = dir.ToString();
        }

        private void URLbox_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}

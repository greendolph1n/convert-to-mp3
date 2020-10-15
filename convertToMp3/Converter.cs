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
     
        public Converter()
        {
            InitializeComponent();
        }

        private void Converter_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {

            string dir = new Directory().getDir();
            string url = URLbox.Text;
            YoutubeConverter converter = new YoutubeConverter();
            converter.convertURL(url, dir);
        }

        private void URLbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgMng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFS_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxFiNa.Text = openFileDialog1.FileName;
            }
        }

        private void buttonSt_Click(object sender, EventArgs e)
        {
            string filename = textBoxFiNa.Text;
            

            Bitmap bmp = new Bitmap(filename);

            for (int i = 0; i < bmp.PropertyItems.Length; i++)
            {
                if (bmp.PropertyItems[i].Id == 0x9C9E)
                {
                    //データがunicodeの場合
                    string str = System.Text.Encoding.Unicode.GetString(bmp.PropertyItems[i].Value);
                    str = str.Trim(new char[] { '\0' });
                    textBoxOut.Text +=  str;
                }
                
            }
            
        }
    }
}

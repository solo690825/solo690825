using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] A01 = new string[] { "菊花", "企鵝", "沙漠", "無尾熊", "鬱金香" };
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(A01[0] + ".jpg");
            label1.Text = "圖片名稱:" + A01[0];
            trackBar1.Minimum = 0;
            trackBar1.Maximum = A01.GetUpperBound(0);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int A02 = trackBar1.Value;
            pictureBox1.Image = new Bitmap(A01[A02] + ".jpg");
            label1.Text = "圖片名稱:" + A01[A02];
        }
    }
}

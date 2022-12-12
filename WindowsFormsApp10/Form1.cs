using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            int side = Convert.ToInt32(textBox1.Text);
            int perimetr = side * 4;
            int square = side * side;
            label3.Text = $"P={perimetr};S*{square}";

            int scale = 1;

            while (side > pictureBox1.Width && side > pictureBox1.Height)
            {
                side = side / 2;
                scale++;
            }
            label1.Text = $"Масштаб 1: {scale}";


            int centr_with = pictureBox1.Width / 2;
            int centr_height = pictureBox1.Height / 2;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            Pen maroonPen = new Pen(Brushes.Maroon);
            maroonPen.Width = 4;
            graph.DrawRectangle(maroonPen, centr_with - side / 2, centr_height - side / 2, side, side);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab0
{
    public partial class Form1 : Form
    {
        Point current = new Point();
        Point old = new Point();
        Pen p = new Pen(Color.Black, 5);
        Graphics g;
        Bitmap img;
        Neuron neuron = new Neuron();
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            //Установление случайных весов_________________________________________
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < 100; i++)
                for (int j = 0; j < 100; j++)
                    neuron.WeightArray[i, j] = Convert.ToDouble(rand.Next(-3, 4) / 10.0);
            //_____________________________________________________________________
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                img = (Bitmap)pictureBox1.Image;
                g = Graphics.FromImage(img);
                g.DrawLine(p, old, current);
                pictureBox1.Image = img;
                old = current;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(ofd.FileName);
                pictureBox1.Image = img;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) //если в pictureBox есть изображение
            {
                DateTime now = DateTime.Now;
                pictureBox1.Image.Save($"{now:mm'-'ss}.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            neuron.Learn(img);

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Imag0136\Pictures\text.txt");
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    sw.Write($"{Math.Round(neuron.WeightArray[i, j])} ");
                }
                sw.WriteLine();
            }
            sw.Close();
        }
    }
}

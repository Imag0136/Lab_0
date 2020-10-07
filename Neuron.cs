using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab0
{
    class Neuron
    {
        //public byte t = 0;
        public byte error = 0;
        public int limit = 0;
        public double sum = 0;
        public int[,] imgArray;
        public double[,] WeightArray { get; set; } = new double[100, 100];
        public double alpha = 0.5; //Скорость обучения
        public double delta;

        public void Learn(Bitmap img)
        {
            sum = 0;
            error = 0;
            imgArray = new int[100, 100];
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (img.GetPixel(i, j) == Color.FromArgb(255, 0, 0, 0))
                    {
                        imgArray[i, j] = 1;
                        sum += imgArray[i, j] * WeightArray[i, j];
                    }
                }
            }

            if (sum > limit)
            {
                DialogResult res = MessageBox.Show("Это крестик?", "Нейрон", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.No)
                {
                    delta = 0 - 1;
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            WeightArray[i, j] += alpha * delta * imgArray[i, j];
                        }
                    }
                    error = 1;
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Это нолик?", "Нейрон", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.No)
                {
                    delta = 1 - 0;
                    for (int i = 0; i < img.Width; i++)
                    {
                        for (int j = 0; j < img.Height; j++)
                        {
                            WeightArray[i, j] += alpha * delta * imgArray[i, j];
                        }
                    }
                    error = 1;
                }
            }

            StreamWriter sw1 = new StreamWriter(@"C:\Users\Imag0136\Pictures\text1.txt");
            StreamWriter sw2 = new StreamWriter(@"C:\Users\Imag0136\Pictures\text2.txt");
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    sw1.Write($"{imgArray[i, j]} ");
                    sw2.Write($"{Math.Round(WeightArray[i, j])} ");
                }
                sw1.WriteLine();
                sw2.WriteLine();
            }
            sw1.Close();
            sw2.Close();

            //return error == 0;

            //StreamWriter sw = new StreamWriter(@"C:\Users\Imag0136\Pictures\text.txt");
            //for (int i = 0; i < img.Height; i++)
            //{
            //    for (int j = 0; j < img.Width; j++)
            //    {
            //        sw.Write($"{imgArray[j, i]}");
            //    }
            //    sw.WriteLine();
            //}
            //sw.Close();
        }
    }
}

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
        public byte t = 0;
        public byte error = 0;
        public int limit = 0;
        public double sum = 0;
        public int[,] imgArray;
        public double[,] WeightArray { get; set; } = new double[100, 100];
        public double alpha = 0.5; //Скорость обучения
        public double delta;
        public string PathX;
        public string PathO;
        public int y;
        public int yk;

        public void GetRandomFile()
        {
            Random rand = new Random();
            string[] files1 = Directory.GetFiles(Directory.GetCurrentDirectory(), "*Крестик*.jpg");
            string[] files2 = Directory.GetFiles(Directory.GetCurrentDirectory(), "*Нолик*.jpg");
            Console.WriteLine(files1[rand.Next(files1.Length)]);
            PathX = files1[rand.Next(files1.Length)];
            PathO = files2[rand.Next(files2.Length)];
            //return files1[rand.Next(files1.Length)];
        }

        public void Learn(Bitmap img)
        {
            t += 1;
            error = 0;
            for (int k = 0; k < 10; k++)
            {
                sum = 0;
                imgArray = new int[100, 100];
                img = k < 5 ? new Bitmap($"Крестик{k}.jpg") : new Bitmap($"Нолик{k}.jpg");
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
                y = sum > limit ? 1 : 0;
                yk = k < 5 ? 1 : 0;

                if (y != yk)
                {
                    delta = yk - y;
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

            if (error == 1) Learn(img);
            else Console.WriteLine($"Количество эпох: {t}");



            //StreamWriter sw1 = new StreamWriter(@"C:\Users\Imag0136\Pictures\text1.txt");
            //StreamWriter sw2 = new StreamWriter(@"C:\Users\Imag0136\Pictures\text2.txt");
            //for (int i = 0; i < img.Height; i++)
            //{
            //    for (int j = 0; j < img.Width; j++)
            //    {
            //        sw1.Write($"{imgArray[i, j]} ");
            //        sw2.Write($"{Math.Round(WeightArray[i, j])} ");
            //    }
            //    sw1.WriteLine();
            //    sw2.WriteLine();
            //}
            //sw1.Close();
            //sw2.Close();
        }

        public void Recognize(Bitmap img)
        {
            sum = 0;
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

            if (sum > limit) MessageBox.Show("Это крестик");
            else MessageBox.Show("Это нолик");
        }
    }
}

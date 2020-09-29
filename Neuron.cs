using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab0
{
    class Neuron
    {
        //public int T { get; set; }
        int error;

        int picturesCount;

        static public int[,] ImageToArray(Bitmap img)
        {
            int[,] imgArray = new int[img.Width,img.Height];
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    if (img.GetPixel(i,j) == Color.FromArgb(255, 0, 0, 0))
                    {
                        imgArray[i, j] = 1;
                    }
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Imag0136\Pictures\text.txt");
            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    sw.Write($"{imgArray[j, i]}");
                }
                sw.WriteLine();
            }
            sw.Close();        
            return imgArray;
        }        
    }
}

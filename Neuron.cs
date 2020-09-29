using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return imgArray;
        }
        
    }
}

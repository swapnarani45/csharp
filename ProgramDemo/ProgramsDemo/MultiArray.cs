using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class MultiArray
    {
        static void Main()
        {
            int[,] a = new int[3, 3];

            //initialization
            a[0, 0] = 100;
            a[1, 1] = 200;
            a[2, 2] = 300;

            //transverse
            for(int i=0;i<3;i++)
            {
                for (int j= 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+ " ");

                }
                Console.WriteLine();

            }
            int[,] b = { { 11, 22, 33 }, { 1, 2, 3 }, { 99, 88, 77 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");

                }
                Console.WriteLine();

            }
            Console.WriteLine("the size of 2-D array is" + b.Length);
            Console.WriteLine("Dimension of array is" + b.Rank);

            int[,] c = new int[5, 10]; 

            Console.WriteLine("the no.of rows is" + c.GetLength(0));
            Console.WriteLine("the no.of columns is" + c.GetLength(1));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class JaggedArraysDemo
    {
       static void Main(String[] args)
        {
            int[][] a = new int[2][]; //declare jagged array

            //initalize the array
            a[0] = new int[] { 20, 30, 40 };
            a[1] = new int[] { 11,22,33,44,55 };

            //transverse the array
            for(int i=0;i<=a.Length;i++)
            {
                for(int j=0;j <a[i].Length;j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}

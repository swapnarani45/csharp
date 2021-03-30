﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class CommandLineDemo2
    {
        static void Main(String[] args)
        {
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);

            int sum = a + b + c;
            float avg = sum / 3;

            Console.WriteLine("the sum of three nos is :" + sum);

            Console.WriteLine("the avg of three nos is :{0,0,00}:" +avg);
            Console.WriteLine("the avg of three nos is :{0:0.###}:" , avg);
            Console.WriteLine("the avg of three nos is :{0:C}" ,avg);

            Console.WriteLine(string.Format(new CultureInfo("en-US"), "{0:c}", avg));
            Console.WriteLine(string.Format(new CultureInfo("en-GB"), "{0:c}", avg));
            Console.ReadKey();
        }
    }
}

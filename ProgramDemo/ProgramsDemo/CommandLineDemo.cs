﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class CommandLineDemo
    {
         static void  Main(String[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);

            foreach (var a in args)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}

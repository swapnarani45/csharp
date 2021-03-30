﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1
{
    class Mammal
    {
        private int age;
        public Mammal(int age)
        {
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Sleep()
        {
            Console.WriteLine("Shhhh! I'm Sleeping !");
            Console.ReadKey();
        }
    }    }


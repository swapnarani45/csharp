using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    class Developer
    {
        public  virtual void getInfo() //virtual methods should be overridden
        {
            Console.WriteLine("I'm a team leader");

        }
    }
    class CSharpdeveloper : Developer
    {
        public override void getInfo()
        {
            Console.WriteLine("I'm a C# Developer");
        }
    }
    class OverRide
    {
        static void Main()
        {
            CSharpdeveloper c1 = new CSharpdeveloper();
            c1.getInfo();

            Developer D1 = new Developer();
            D1.getInfo();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1
{
    class SuperClass
    {
        public void display()
        {
            Console.WriteLine("Base class method");
        }

    }
    class DerivedClass : SuperClass
    {
        public new void display()
        {
            Console.WriteLine("Derived class method");
        }
    }
    class MethodHidingDemo
    {
        public static void Main()
        {
            DerivedClass d1 = new DerivedClass();
            d1.display();
            Console.ReadKey();
        }
    }
}

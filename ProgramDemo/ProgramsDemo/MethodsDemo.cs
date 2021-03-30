using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// pass by value to methods Example
namespace ProgramsDemo
{
    class MethodsDemo
    {
        public static void Multiplication(int x)
        {
            x *= x;
            Console.WriteLine("variable value inside method{0}", x);

        }
        public static void Multiplication1(ref int x)
        {
            x *= x;
            Console.WriteLine("variable value inside method{0}", x);

        }
        public static void Multiplication2(out int x)
        {
            x = 10;
            x *= 10;
            Console.WriteLine("variable value inside method{0} ", x);

        }


        static void Main()
        {
            int a = 10;
            int b;
            Console.WriteLine("*****Pass By Value***********");
            Console.WriteLine(" the value of A before method call {0}  ",a);
            Multiplication(a);//passing parameters by value
            Console.WriteLine(" the value of A after method call {0} ",a);

            Console.WriteLine("*****Pass By Reference***********");
            Console.WriteLine(" the value of A before method call {0} ",a);
            Multiplication1(ref a);//passing parameters by value
            Console.WriteLine(" the value of A after method call {0}",a);
            /* In c#, out keyword is used to pass arguments to the method as a reference type.
             * The out keyword same as the ref keyword but the only difference is out doesn’t
             * require a variable to be initialized before we pass it as an argument to the
               * method but the variable must be initialized in called method before it returns a
                 * value to the calling method. */

            Console.WriteLine("*****Pass By Out***********");
            

            Multiplication2(out b);//passing parameters by value
            Console.WriteLine(" the value of B after method call {0}", b);

            Console.ReadKey();
        }

    
    }
}

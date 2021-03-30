using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDemo
{
    class First
    {
        static void Main(String[] args)
        {
            int a, b, sum = 0;
            string name;
            decimal salary;
            double age;

            Console.WriteLine("my first program in c#");
            Console.WriteLine("enter the name,salary and age");
            name = Console.ReadLine();
            salary = Convert.ToDecimal(Console.ReadLine());
           age= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hello {0} with age:{1} your salary is:{2}", name, age, salary);

            Console.WriteLine("Arithmetic operations");
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;
            Console.WriteLine("the addition of {0} and {1} is",sum);
            Console.ReadKey();


        }
    }
}

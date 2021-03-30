using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Ternary
    {
        /* Ternary operator are a substitute for if...else statement.
    
     Syntax : Condition ? Expression1 : Expression2;
    */
        static void Main()
        {
            int number = 2;
            bool isEven;
            String a;

            isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
            a = (number % 2 == 0) ? " even number " : "odd number";
            Console.WriteLine(a);

            int n1 = 20, n2 = 30;
            String b;

            b = n1 > n2 ? "n1 greater than n2" : n1 < n2 ? "n1 lesser than n2 " : "n1 euals n2";
           
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}

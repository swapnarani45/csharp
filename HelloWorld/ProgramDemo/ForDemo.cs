using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDemo
{
    class ForDemo
    {
        public static void Main(String[] args)
        {
            for(int i=1; i<=5; i++)
            {
                Console.WriteLine("c# for loop :iteration {0}", i);
                
               
                //multiple iterations and iterator expressions

                for( int k=0,j=0;i+j<=5;k++,j++)
                {
                    Console.WriteLine("i={0} and j={1}", i, j);
                    
                }
                //for loop without iterations and iterator statements
                int m = 1;
                for(;m<=5;)
                {
                    Console.WriteLine("c# for loop :iteration {0}", m);
                    m++;
                    Console.ReadKey();
                }

            //infinite loops
            for(; ; )
                {
                    Console.WriteLine("infinite loop");
                    Console.ReadKey();

                }

            }
        }
    }
}

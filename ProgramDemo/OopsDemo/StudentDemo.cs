using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class StudentDemo
    {
        public static void Main(String[] args)
        {
            Student s1 = new Student(101,"Mary");
            s1.Course1 = "computer science";
            /* s1.Name = "Steve"; compiler time error bcoz we are accessing read only property*/
            Console.WriteLine(s1.Rollno2 + " " + s1.Name1" " + s1.Course1);

            Console.ReadKey();
        }
    }
}

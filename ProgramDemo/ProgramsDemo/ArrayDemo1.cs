using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class ArrayDemo1
    {
        public static void Main()
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            Console.WriteLine("***Displaying EvenNums Array***");
            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);



            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;



            Console.WriteLine("***Displaying EvenNUms Array Added with 10***");
            foreach (var item in evenNums)
                Console.WriteLine(item);



            Console.WriteLine("***Displaying Cities***");
            foreach (var city in cities)
                Console.WriteLine(city);



            Array.Sort(nums); // sorts array
            Console.WriteLine("***Ascending order***");
            foreach (var item in nums)
                Console.WriteLine(item);

            Console.WriteLine("***BinarySearch***");
            Console.WriteLine(Array.BinarySearch(nums, 15));// binary search



            Console.WriteLine("***Decending order***");
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array



           
            Console.ReadKey();
        }
    }
}

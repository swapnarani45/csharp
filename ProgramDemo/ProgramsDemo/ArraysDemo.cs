using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramsDemo
{
    class ArraysDemo
    {
        public static void Main(String[] args)
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            int[] nums = new int[5] { 10, 15, 16, 8, 6 };

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;

            foreach (var item in evenNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);

            Array.Sort(nums); // sorts array 
            Array.Reverse(nums); // sorts array in descending order
            Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array
            Array.BinarySearch(nums, 5);// binary search 

            Console.ReadKey();
        }
    }
}

/* ReadLine(): The ReadLine() method reads the next line of input from the standard input stream. It returns the same string.
Read(): The Read() method reads the next character from the standard input stream. It returns the ascii value of the character.
ReadKey(): The ReadKey() method obtains the next key pressed by user. This method is usually used to hold the screen until user press a key.*/using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramDemo
{
    class ReadDemo
    {
		public static void Main(string[] args)
		{
			int userInput;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			Console.WriteLine();

			Console.Write("Input using Read() - ");
			userInput = Console.Read();
			Console.WriteLine("Ascii Value = {0}", userInput);
			Console.ReadKey();
		}
	}
}

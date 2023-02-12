using System;
using System.Collections.Generic;

namespace test
{
	class LessThreeLetters
	{
		public static string[] LessThreeLetters(string[] array) {
			List<string> result_array = new List<string>();
			foreach(string item in array) {
				if(item.Length <= 3) {
					result_array.Add(item);
				}
			}
			return result_array.ToArray();
		}
		
		public static void WriteLineArray(string[] array) {
			if(array.Length == 0) {
				Console.WriteLine("[]");
			} else {
				Console.WriteLine("[\"{0}\"]", string.Join("\", \"", array));
			}
		}
		
		public static void Main(string[] args)
		{
			string[] arrayInput1 = {"hello", "2", "world", ":-)"};
			WriteLineArray(LessThreeLetters(arrayInput1));

			string[] arrayInput2 = {"1234", "1567", "-2", "computer science"};
			WriteLineArray(LessThreeLetters(arrayInput2));

			string[] arrayInput3 = {"Russia", "Denmark", "Kazan"};
			WriteLineArray(LessThreeLetters(arrayInput3));
				
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
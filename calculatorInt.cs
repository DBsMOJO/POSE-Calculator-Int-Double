/*-----------------------------------------------
*			HTBLA-Leonding / Class: 3ACIF
*-----------------------------------------------
*			Daniel Binder
*-----------------------------------------------
* Description:
* Calculator
*-----------------------------------------------
*/

using System;

namespace calculatorInt
{
	class calculator
	{
		public static void Main()
		{
			string first, secound;
			int result;
			
			// entry
			Console.WriteLine("************************************");
			Console.WriteLine("* Calculator - Ihr Zahlenbegleiter *");
			Console.WriteLine("************************************");
			Console.WriteLine();
			
			// input
			Console.Write("Erste Zahl: ");
			first = Console.ReadLine();
			
			Console.Write("Zweite Zahl: ");
			secound = Console.ReadLine();
			
			Console.WriteLine();
			
			// calculation
			
			result = Int32.Parse(first) + Int32.Parse(secound);
			
			// output
			Console.WriteLine("Ergebnis:");
			Console.WriteLine("===============");
			Console.WriteLine("{0, 15}", first);
			Console.WriteLine("+" + "{0, 14}", secound);
			Console.WriteLine("---------------");
			Console.WriteLine("=" + "{0, 14}", result);
			Console.WriteLine("===============");
			
			
		}
	}
}
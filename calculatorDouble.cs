/*-----------------------------------------------
*			HTBLA-Leonding / Class: 3ACIF
*-----------------------------------------------
*			Daniel Binder
*-----------------------------------------------
* Description:
* Calculator - double
*-----------------------------------------------
*/

using System;

namespace calculatorDouble
{
	class calculator
	{
		public static void Main()
		{
			string first, secound;
			double result;
			
			//entry
			Console.WriteLine("***********************");
			Console.WriteLine("* Calculator - double *");
			Console.WriteLine("***********************");
			Console.WriteLine();
			
			// input
			Console.Write("First number: ");
			first = Console.ReadLine();
			Console.Write("Secound number: ");
			secound = Console.ReadLine();
			Console.WriteLine();
			
			// calculation
			result = Convert.ToDouble(first) + Convert.ToDouble(secound);
			
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
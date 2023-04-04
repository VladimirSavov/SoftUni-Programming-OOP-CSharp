using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        static void Main()
        {
			try
			{
				int n = int.Parse(Console.ReadLine());
				if(n < 0)
				{
					throw new Exception();
				}
				else
				{
					Console.WriteLine(Math.Sqrt(n));
					Console.WriteLine("Goodbye.");
				}
			}
			catch (Exception)
			{

				Console.WriteLine("Invalid number.");
				Console.WriteLine("Goodbye.");
			}
        }
    }
}

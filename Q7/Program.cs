using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double n1 = 1.234567;
			double n2 = 123.4567;

			double sum = n1 + n2;

			Console.WriteLine(sum.ToString("0.00"));
		}
	}
}

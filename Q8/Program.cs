using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入手機號碼: ");
			string input = Console.ReadLine();

			string result = input.Substring(0,4) + "****" + input.Substring(8);
			Console.WriteLine(result);
		}
	}
}

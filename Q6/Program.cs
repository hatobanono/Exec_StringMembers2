using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入Allen(區分大小寫): ");
			string input =	Console.ReadLine();

			string result = (input == "Allen") ? "輸入正確" : "輸入錯誤";
			Console.WriteLine(result);
		}
	}
}

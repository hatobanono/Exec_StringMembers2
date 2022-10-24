using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str1 = "1100225";
			int year = Convert.ToInt32(str1.Substring(0, 3));
			string str2 = Convert.ToString(year+1911) + str1.Substring(3);
			Console.WriteLine(str2);
		}
	}
}

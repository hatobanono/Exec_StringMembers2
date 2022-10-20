using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string account = "aLLeN kUO";
			string[] words = account.ToLower().Split(' ');

			for (int i = 0; i < words.Length; i++) 
			{
				words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
			}

			string reslut = string.Join(" ", words);
			Console.WriteLine(reslut);

		}
	}
}

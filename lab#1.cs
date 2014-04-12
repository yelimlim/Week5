using System;

namespace practice2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int loop = 1; loop <= 5; loop++) {
				for (int Loop = 1; Loop <= loop; Loop++) {
					Console.Write ("*");
				}
				Console.WriteLine ("");
			}
		}
	}
}

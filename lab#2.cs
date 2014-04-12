using System;

namespace lab2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int a = 1; a <= 9; a++) {
				Console.WriteLine ("[{0} times table]", a);
				for (int b = 1; b <= 9; b++) {
					int c = a * b;
					Console.WriteLine ("{0} * {1} = {2}", a, b, c);
				}
				Console.WriteLine ("");
			}
		}
	}
}

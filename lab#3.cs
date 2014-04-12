using System;

namespace lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random random = new Random ();

			int a = random.Next (1, 100);

			Console.WriteLine ("Guess a number from 1 to 99. I'll give you 6 tries.");

			for (int loop = 0; loop < 6; loop++) {


				int b = int.Parse (Console.ReadLine ());

				if (a == b) {
					Console.WriteLine ("You're right");
					return;
				} else if (a > b) {
					Console.WriteLine ("Too low!");
				} else if (a < b) {
					Console.WriteLine ("Too high");
				}
				
			}
			Console.WriteLine ("No more guess");


		}
	}
}

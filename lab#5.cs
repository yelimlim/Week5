using System;

namespace lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.WriteLine ("sausage bun     ketchup mustard onion");
			string space = "       ";

			for (int sausage = 0; sausage < 2; sausage++) {
				Console.Write (sausage);
				Console.Write (space);

				for (int bun = 0; bun <2; bun++) {
					if (bun == 1) {
						Console.Write (sausage);
						Console.Write (space);
					}

					Console.Write (bun);
					Console.Write (space);

					for (int ketchup = 0; ketchup <2; ketchup++) {
						if (ketchup == 1) {
							Console.Write (sausage);
							Console.Write (space);
							Console.Write (bun);
							Console.Write (space);
						}

						Console.Write (ketchup);
						Console.Write (space);

						for (int mustard = 0; mustard <2; mustard++) {
							if (mustard == 1) {
								Console.Write (sausage);
								Console.Write (space);
								Console.Write (bun);
								Console.Write (space);
								Console.Write (ketchup);
								Console.Write (space);
							}

							Console.Write (mustard);
							Console.Write (space);

							for (int onion = 0; onion < 2; onion++) {
								if (onion == 1) {
									Console.Write (sausage);
									Console.Write (space);
									Console.Write (bun);
									Console.Write (space);
									Console.Write (ketchup);
									Console.Write (space);
									Console.Write (mustard);
									Console.Write (space);
								}

								Console.Write (onion);
								Console.Write (space);
								Console.WriteLine ("");

							}

						}

					}




				}
			}
		}
	}
}

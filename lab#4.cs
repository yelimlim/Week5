using System;

namespace lab4
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			do {

				string opr;
				int result;

				Console.Write ("Enter the operation[+,-,*,/](If you want to quit, enter 'q'): ");
			opr = Console.ReadLine ();

			if (opr == "q") {
				Console.WriteLine ("Bye!");
				break;
				}

				if(opr == "+"|| opr == "-" || opr == "*" || opr == "/"){


			Console.Write ("Enter the first number: ");
			int a = int.Parse (Console.ReadLine ());

			Console.Write ("Enter the second number: ");
			int b = int.Parse (Console.ReadLine ());



			switch (opr) {

			case "+":
				result = a + b;
				break;

			case "-":
				result = a - b;
				break;

			case "*":
				result = a * b;
				break;

			case "/":
				result = a / b;
				break;

				default:
				break;
			}

			Console.WriteLine ("Result: {0}", result);
				}
				else{
					Console.WriteLine ("You entered wrong operation. Only +,-,*,/,q are allowed");
				}
					
				Console.WriteLine ("");	
			}
		while(true);
			//} while(opr == "q");


		}
	}
}

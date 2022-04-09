using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public static class ConsoleWriter
	{

		public static void WriteLineStatus(string value)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("STATUS: " + value);
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void WriteLineError(string value, Exception? e=null)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("ERROR: "+value);
			
			if (e != null)
			{
				Console.WriteLine();
				Console.WriteLine("INTERNAL_ERROR: " + e.ToString());
			}
			Console.ForegroundColor = ConsoleColor.White;
		}


		public static bool AskForYesNo(string question)
		{
			Console.WriteLine(question+" (y/n)");
			while (true)
			{
				Console.Write(">");
				var awnser = Console.ReadLine().ToLower();
				if (awnser == "y" || awnser == "yes")
				{
					return true;

				}
				else if (awnser == "n" || awnser == "no")
				{
					return false;
				}
				Console.WriteLine($"'{awnser}' Was not a valid value (y/n)");

			}

		}


		public static string? AskForString(string question, Func<string?, bool>? validate=null)
		{
			while (true)
			{
				Console.WriteLine(question);
				Console.Write(">");

				var awnser = Console.ReadLine();

				if (validate == null)
				{
					return awnser;
				}
				if (validate.Invoke(awnser))
				{
					return awnser;
				}


				WriteLineError($"'{awnser}' was not valid");
			}
			

		}


	}
}

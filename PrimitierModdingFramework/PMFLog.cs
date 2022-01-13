using MelonLoader;
using PrimitierModdingFramework.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public class PMFLog : PMFSystem
	{
		public static MelonLogger.Instance Logger { get { return Mod.LoggerInstance; } }



		public static void Message(string message, ConsoleColor color = ConsoleColor.White)
		{
			Logger.Msg(color, message);
		}
		public static void Message(object obj, ConsoleColor color = ConsoleColor.White)
		{
			Logger.Msg(color, obj);
		}
		public static void Message(string message, ConsoleColor color = ConsoleColor.White, params object[] args)
		{
			Logger.Msg(color, message, args);
		}
		public static void Message(string message, params object[] args)
		{
			Logger.Msg(message, args);
		}


		public static void Warning(string message)
		{
			Logger.Warning(message);
		}
		public static void Warning(object obj)
		{
			Logger.Warning(obj);
		}
		public static void Warning(string message, params object[] args)
		{
			Logger.Warning(message, args);
		}

		
		public static void Error(string message)
		{
			Logger.Error(message);
		}
		public static void Error(object obj)
		{
			Logger.Warning(obj);
		}
		public static void Error(string message, params object[] args)
		{
			Logger.Error(message, args);
		}

	}
}

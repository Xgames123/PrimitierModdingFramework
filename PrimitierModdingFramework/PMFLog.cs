using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public static class PMFLog
	{
		public static MelonLogger.Instance MelonLogger;

		public static void Message(string message, ConsoleColor color = ConsoleColor.White)
		{
			MelonLogger.Msg(color, message);
		}
		public static void Message(object obj, ConsoleColor color = ConsoleColor.White)
		{
			MelonLogger.Msg(color, obj);
		}
		public static void Message(string message, ConsoleColor color = ConsoleColor.White, params object[] args)
		{
			MelonLogger.Msg(color, message, args);
		}
		public static void Message(string message, params object[] args)
		{
			MelonLogger.Msg(message, args);
		}


		public static void Warning(string message)
		{
			MelonLogger.Warning(message);
		}
		public static void Warning(object obj)
		{
			MelonLogger.Warning(obj);
		}
		public static void Warning(string message, params object[] args)
		{
			MelonLogger.Warning(message, args);
		}

		
		public static void Error(string message)
		{
			MelonLogger.Error(message);
		}
		public static void Error(object obj)
		{
			MelonLogger.Warning(obj);
		}
		public static void Error(string message, params object[] args)
		{
			MelonLogger.Error(message, args);
		}

	}
}

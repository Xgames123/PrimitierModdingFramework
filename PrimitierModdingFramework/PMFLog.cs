using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework
{
	public class PMFLog : PMFSystem
	{
		public static bool IsEnabled { get; private set; } = false;

		public static MelonLogger.Instance Logger { get { return Mod.LoggerInstance; } }


		public override void OnSystemEnabled()
		{
			IsEnabled = true;
		}
		public override void OnSystemDisabled()
		{
			IsEnabled = false;
		}


		public static void Message(string message, ConsoleColor color = ConsoleColor.White)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Msg(color, message);
		}
		public static void Message(object obj, ConsoleColor color = ConsoleColor.White)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Msg(color, obj);
		}
		public static void Message(string message, ConsoleColor color = ConsoleColor.White, params object[] args)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Msg(color, message, args);
		}
		public static void Message(string message, params object[] args)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Msg(message, args);
		}


		public static void Warning(string message)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Warning(message);
		}
		public static void Warning(object obj)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Warning(obj);
		}
		public static void Warning(string message, params object[] args)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Warning(message, args);
		}

		
		public static void Error(string message)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Error(message);
		}
		public static void Error(object obj)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Warning(obj);
		}
		public static void Error(string message, params object[] args)
		{
			if (!IsEnabled)
				throw new PMFSystemNotEnabledException(typeof(PMFLog));
			Logger.Error(message, args);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrimitierModManager
{
	public class ActionCommand : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		public Action<object?> Action;

		public bool CanExecute(object? parameter)
		{
			return true;
		}

		public void Execute(object? parameter)
		{
			Action?.Invoke(parameter);
		}

		public ActionCommand(Action<object?> action)
		{
			Action = action;
		}

	}
}

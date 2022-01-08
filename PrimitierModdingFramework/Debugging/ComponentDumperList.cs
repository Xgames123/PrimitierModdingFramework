using Il2CppSystem.Collections.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitierModdingFramework.Debugging
{
	public class ComponentDumperList
	{
		private List<ComponentDumper> _InternalList = new List<ComponentDumper>();

		public IReadOnlyList<ComponentDumper> List { get { return _InternalList; } }

		public static readonly ComponentDumperList Empty = new ComponentDumperList();

		public int Count { get { return _InternalList.Count;} }


		public ComponentDumperList(params ComponentDumper[] componentDumpers)
		{
			_InternalList.AddRange(componentDumpers);
		}
		public ComponentDumperList()
		{

		}

		public void Add(ComponentDumper componentDumper)
		{
			_InternalList.Add(componentDumper);
		}
		public void Add(ComponentDumperList componentDumperList)
		{
			_InternalList.AddRange(componentDumperList.List);
		}

		public void Remove(ComponentDumper componentDumper)
		{
			_InternalList.Remove(componentDumper);
		}
		public ComponentDumper Get(int index)
		{
			return _InternalList[index];
		}


	}
}

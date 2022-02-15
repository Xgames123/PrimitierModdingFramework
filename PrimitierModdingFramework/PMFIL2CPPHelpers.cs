using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnhollowerBaseLib;

namespace PrimitierModdingFramework
{
	/// <summary>
	/// Helpers for IL2CPP
	/// </summary>
	public static class PMFIL2CPPHelpers
	{
		private static Il2CppSystem.Collections.Generic.List<Il2CppSystem.Object> s_GarbageCollectBlock = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Object>();

		private static List<System.Type> _AllValueTypes = new List<System.Type>();

		/// <summary>
		/// All the value types in the current AppDomain
		/// </summary>
		public static IReadOnlyList<System.Type> AllValueTypes { get { return _AllValueTypes; } }


		/// <summary>
		/// Regenerates the AllValueTypes list
		/// </summary>
		public static void RegenerateValueTypeList()
		{
			_AllValueTypes.Clear();
			foreach (var asm in System.AppDomain.CurrentDomain.GetAssemblies())
			{
				foreach (var type in asm.GetTypes())
				{
					if (type.IsValueType)
					{
						_AllValueTypes.Add(type);
					}

				}
			}

		}




		/// <summary>
		/// Automatically finds type to unbox to.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public static object AutoUnbox(Il2CppSystem.Object obj)
		{
			throw new System.NotImplementedException();

			var unboxed = IL2CPP.il2cpp_object_unbox(obj.Pointer);
			if (unboxed == System.IntPtr.Zero)
			{
				return null;
			}
	
			var name = IL2CPP.Il2CppStringToManaged(IL2CPP.il2cpp_class_get_name(IL2CPP.il2cpp_object_get_class(unboxed))); 

			if (_AllValueTypes.Count == 0)
			{
				RegenerateValueTypeList();
			}
			

			foreach (var structType in AllValueTypes)
			{
				if (structType.Name == name)
				{
					return Marshal.PtrToStructure(unboxed, structType);
				}
			}
			return null;
		}

		/// <summary>
		/// Unboxes using a System.Type instead of a T
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public static object UnboxUsingType(Il2CppSystem.Object obj, System.Type type)
		{
			return Marshal.PtrToStructure(IL2CPP.il2cpp_object_unbox(obj.Pointer), type);
		}

	}
}

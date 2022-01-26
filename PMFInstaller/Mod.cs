using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace PMFInstaller
{



	[Serializable]
	public class Mod : IEquatable<Mod>
	{
		[JsonProperty(Required = Required.Always)] public string DisplayName { get; set; }
		[JsonProperty(Required = Required.DisallowNull)] public string Authors { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)] public string Description { get; set; } = "";
		[JsonProperty(Required = Required.DisallowNull)] public string Version { get; set; } = "v1.0";

		[JsonIgnore] public int ModHash { get { if (_ModHash == -1) RegenerateHash(); return _ModHash; } }
		[JsonIgnore] public ICommand OnDisableCommand { get; set; }
		[JsonIgnore] public ICommand OnEnableCommand { get; set; }
		[JsonIgnore] public ICommand OnDeleteCommand { get; set; }
		[JsonIgnore] public string FileName;

		[JsonIgnore] private int _ModHash = -1;

		[JsonIgnore] public BitmapImage Image { get; private set; }


		private void OnEnable(object? param)
		{
			ModManager.EnableMod(this);

		}
		private void OnDisable(object? param)
		{
			ModManager.DisableMod(this);
		}
		private void OnDelete(object? param)
		{

			ModManager.DeleteMod(this);
		}

		public void InitUI()
		{
			OnEnableCommand = new ActionCommand(OnEnable);
			OnDisableCommand = new ActionCommand(OnDisable);
			OnDeleteCommand = new ActionCommand(OnDelete);
		}


		public void RegenerateHash()
		{
			
			_ModHash = HashCode.Combine(
				Authors.GetHashCode(StringComparison.Ordinal),
				DisplayName.GetHashCode(StringComparison.Ordinal),
				Version.GetHashCode(StringComparison.Ordinal));
		}

		public bool Equals(Mod? other)
		{
			if (other == null)
			{
				return false;
			}

			if (other.ModHash == ModHash)
			{
				return true;
			}

			return false;
		}

		public override bool Equals(object? obj)
		{
			if (obj == null)
				return false;

			Mod objAsMod = obj as Mod;
			if (objAsMod == null)
				return false;
			else
				return Equals(objAsMod);
		}

		public override int GetHashCode()
		{
			return ModHash;
		}


		


	}
}

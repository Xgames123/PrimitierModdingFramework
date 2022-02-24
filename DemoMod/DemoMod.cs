using Il2CppSystem;
using PrimitierModdingFramework;
using PrimitierModdingFramework.Debugging;
using PrimitierModdingFramework.SubstanceModding;
using UnityEngine;


namespace DemoMod
{
	public class DemoMod : PrimitierMod
    {
		
		Vector3 creativeBlockSize = new Vector3(0.25f,0.25f,0.25f);
		float upperBlockSizeLim = 2f;
		float lowerBlockSizeLim = 0.05f;
		float creativeBlockSizeInc = 0.05f;
		float creativeBlockSizeDec = 0.05f;
		Vector3 creativeBlockGenerationOffset = new Vector3(.75f, 0.0f, -0.75f);

		DateTime sysTime = new DateTime();

		long lastTimeBtnPressed = 0;

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			base.OnSceneWasLoaded(buildIndex, sceneName);

			var demoMenu = InGameDebugTool.CreateMenu("Demo", "MainMenu");

			var creativeMenu = CreateCreativeMenu();

			var creativeBlockBuilderMenu = CreateCreativeBlockBuilderMenu();

			var spawnMenu = CreateSpawnMenu();
			
			LoadCustomSubstances();

		}

		public InGameDebugMenu CreateCreativeMenu(){
			var newmenu = InGameDebugTool.CreateMenu("CreativeMenu", "MainMenu");
			return newmenu;
		}

		public InGameDebugMenu CreateCreativeBlockBuilderMenu(){
			var newmenu = InGameDebugTool.CreateMenu("BlockuilderMenu", "CreativeMenu");
			//Increment Buttons
			newmenu.CreateButton("IncX", new System.Action(() =>
			{
				if(creativeBlockSize.x+creativeBlockSizeInc < upperBlockSizeLim){
					creativeBlockSize.x += creativeBlockSizeInc;
					newmenu.UpdateLabelWidgetText("Xcounter",creativeBlockSize.x.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));
			newmenu.CreateButton("IncY", new System.Action(() =>
			{
				if(creativeBlockSize.y+creativeBlockSizeInc < upperBlockSizeLim){
					creativeBlockSize.y += creativeBlockSizeInc;
					newmenu.UpdateLabelWidgetText("Ycounter",creativeBlockSize.y.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));
			newmenu.CreateButton("IncZ", new System.Action(() =>
			{
				if(creativeBlockSize.z+creativeBlockSizeInc < upperBlockSizeLim){
					creativeBlockSize.z += creativeBlockSizeInc;
					newmenu.UpdateLabelWidgetText("Zcounter",creativeBlockSize.z.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));
			//Label Widgets
			newmenu.CreateLabelWidget("Xcounter", creativeBlockSize.x.ToString("0.00"));
			newmenu.CreateLabelWidget("Ycounter", creativeBlockSize.y.ToString("0.00"));
			newmenu.CreateLabelWidget("Zcounter", creativeBlockSize.z.ToString("0.00"));
			//Decrement Buttons
			newmenu.CreateButton("DecX", new System.Action(() =>
			{
				if(creativeBlockSize.x-creativeBlockSizeDec > lowerBlockSizeLim){
					creativeBlockSize.x -= creativeBlockSizeDec;
					newmenu.UpdateLabelWidgetText("Xcounter",creativeBlockSize.x.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));
			newmenu.CreateButton("DecY", new System.Action(() =>
			{
				if(creativeBlockSize.y-creativeBlockSizeDec > lowerBlockSizeLim){
					creativeBlockSize.y -= creativeBlockSizeDec;
					newmenu.UpdateLabelWidgetText("Ycounter",creativeBlockSize.y.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));
			newmenu.CreateButton("DecZ", new System.Action(() =>
			{
				if(creativeBlockSize.z-creativeBlockSizeDec > lowerBlockSizeLim){
					creativeBlockSize.z -= creativeBlockSizeDec;
					newmenu.UpdateLabelWidgetText("Zcounter",creativeBlockSize.z.ToString("0.00"));
				}
				UpdateLastRecordedButtonPress();
			}));

			newmenu.CreateButton("Leaf", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position + creativeBlockGenerationOffset, creativeBlockSize, Substance.Leaf);
			}));
			newmenu.CreateButton("Wood", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position + creativeBlockGenerationOffset, creativeBlockSize, Substance.Wood);
			}));
			newmenu.CreateButton("AncAll", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position + creativeBlockGenerationOffset, creativeBlockSize, Substance.AncientAlloy);
			}));

			return newmenu;
		}

		public void UpdateLastRecordedButtonPress(){
			lastTimeBtnPressed = sysTime.Ticks;
		}
		public long TimeSinceLastButtonPress(){
			return sysTime.Ticks - lastTimeBtnPressed;
		}

		public InGameDebugMenu CreateSpawnMenu(){
			InGameDebugMenu newmenu = InGameDebugTool.CreateMenu("Spawn", "Demo");

			newmenu.CreateButton("Tree", new System.Action(() =>
			{
				CubeGenerator.GenerateTree(newmenu.transform.position, 0.1f, CubeGenerator.TreeType.Conifer);
			}));
			newmenu.CreateButton("Leaf", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position, new Vector3(0.1f, 0.1f, 0.1f), Substance.Leaf, temperature:999);
			}));
			newmenu.CreateButton("Custom", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position, new Vector3(0.025f, 0.5f, 0.01f), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
			}));
			newmenu.CreateButton("Unobtainium", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position, new Vector3(0.1f, 1f, 1f), CustomSubstanceSystem.GetSubstanceByName("SUB_UNOB"));
			}));
			newmenu.CreateButton("Unobtainaminium", new System.Action(() =>
			{
				CubeGenerator.GenerateCube(newmenu.transform.position, new Vector3(0.1f, 1f, 1f), CustomSubstanceSystem.GetSubstanceByName("SUB_UNAL"));
			}));
			return newmenu;
		}

		public void LoadCustomSubstances(){
			var customSubstance = CustomMaterial();
			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);

			customSubstance = CreateUnobtainium();
			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);

			customSubstance = CreateUnobtainaminium();
			CustomSubstanceSystem.LoadCustomSubstance(customSubstance);
		}

		public SubstanceParameters.Param CustomMaterial()
		{
			var customMat = CustomSubstanceSystem.CreateCustomMaterial("Iron");
			customMat.name = "CustomMat";
			customMat.color = new Color(0, 1, 1);
			

			CustomSubstanceSystem.LoadCustomMaterial(customMat);

			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Iron);

			customSubstance.displayNameKey = "SUB_CUSTOM";
			customSubstance.collisionSound = "metal1";
			customSubstance.isEdible = true;
			customSubstance.material = "CustomMat";
			customSubstance.stiffness = 9999999; //Damage
        	customSubstance.density = 50; //Mass through =m/v relationship?
			customSubstance.strength = 99999; //HP

			return customSubstance;
		}

		public SubstanceParameters.Param CreateUnobtainium()
		{
			var customMat = CustomSubstanceSystem.CreateCustomMaterial("AncientAlloy");
			customMat.name = "Unobtainium";
			customMat.color = new Color(1f, 0.3f, 1f);
			

			CustomSubstanceSystem.LoadCustomMaterial(customMat);

			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.AncientAlloy);

			customSubstance.displayNameKey = "SUB_UNOB";
			customSubstance.collisionSound = "papa1";
			customSubstance.isFlammable = false;
			customSubstance.isEdible = false;
			customSubstance.material = "Unobtainium";
			customSubstance.stiffness = 10; //Damage
        	customSubstance.density = 0.5f; //Mass through =m/v relationship?
			customSubstance.strength = 99999; //HP

			return customSubstance;
		}

		public SubstanceParameters.Param CreateUnobtainaminium()
		{
			var customMat = CustomSubstanceSystem.CreateCustomMaterial("Leaf");
			customMat.name = "Unobtainaminium";
			customMat.color = new Color(0.8f,1f,0.6f);
			

			CustomSubstanceSystem.LoadCustomMaterial(customMat);

			var customSubstance = CustomSubstanceSystem.CreateCustomSubstance(Substance.Leaf);

			customSubstance.displayNameKey = "SUB_UNAL";
			customSubstance.collisionSound = "leaf1";
			customSubstance.isFlammable = false;
			customSubstance.isEdible = false;
			customSubstance.material = "Unobtainaminium";
			customSubstance.stiffness = 10; //Damage
        	customSubstance.density = 0.01f; //Mass through =m/v relationship?
			customSubstance.strength = 99999; //HP

			return customSubstance;
		}

		public override void OnApplicationStart()
		{
			base.OnApplicationStart();
			PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();
			PMFSystem.EnableSystem<CustomSubstanceSystem>();
			PMFSystem.EnableSystem<CustomAssetSystem>();


		}
		public override void OnUpdate()
		{
			base.OnUpdate();


		}

		public override void OnFixedUpdate()
		{
					

		}



	}
}

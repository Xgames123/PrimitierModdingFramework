# ICustomSavable
ICustomSavable can be used to make a cube behaviour save data into the save file

## Making a cube behaviour save data
First add this to OnApplicationStart if you haven't already
```cs
PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly());
```
(make sure you add this after ```PMFSystem.EnableSystem<PMFHelper>();```)

Than add ICustomSavable to your behaviour and implement the interface
```cs
public class SaveFileTestingObject : MonoBehaviour, ICustomCubeBehaviour, ICustomSavable
{
    public class SaveData
    {
        public Color32 overlayColor;
    }

    public SaveFileTestingObject(System.IntPtr ptr) : base(ptr){}


    public string Save()
    {
        PMFLog.Message("Saveing...");

        var saveData = new SaveData()
        {
            overlayColor = GetComponent<MeshRenderer>().material.color 

        }

        return JsonConvert.SerializeObject(saveData);
    }

    public void Load(string json)
    {
        PMFLog.Message("Loading... "+json);

        
        var saveData = JsonConvert.DeserializeObject<SaveData>(json);
        if (saveData != null)
        {
            GetComponent<MeshRenderer>().material.color = saveData.overlayColor;

            return;
        }

    }
}

```
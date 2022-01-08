/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 40: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6069-6241

namespace TMPro
{
	[AddComponentMenu] // 0x000000018003BD90-0x000000018003BE10
	[RequireComponent] // 0x000000018003BD90-0x000000018003BE10
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 6104
	{
		// Fields
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private RectTransform m_Template; // 0xF8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TMP_Text m_CaptionText; // 0x100
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Image m_CaptionImage; // 0x108
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Graphic m_Placeholder; // 0x110
		[SerializeField] // 0x0000000180032C20-0x0000000180032C50
		[Space] // 0x0000000180032C20-0x0000000180032C50
		private TMP_Text m_ItemText; // 0x118
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Image m_ItemImage; // 0x120
		[SerializeField] // 0x0000000180032C50-0x0000000180032C80
		[Space] // 0x0000000180032C50-0x0000000180032C80
		private int m_Value; // 0x128
		[SerializeField] // 0x0000000180032C50-0x0000000180032C80
		[Space] // 0x0000000180032C50-0x0000000180032C80
		private OptionDataList m_Options; // 0x130
		[SerializeField] // 0x0000000180032C50-0x0000000180032C80
		[Space] // 0x0000000180032C50-0x0000000180032C80
		private DropdownEvent m_OnValueChanged; // 0x138
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_AlphaFadeSpeed; // 0x140
		private GameObject m_Dropdown; // 0x148
		private GameObject m_Blocker; // 0x150
		private List<DropdownItem> m_Items; // 0x158
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
		private bool validTemplate; // 0x168
		private Coroutine m_Coroutine; // 0x170
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x000000018026A2D0-0x000000018026A2E0 0x0000000180377600-0x0000000180377610
		public TMP_Text captionText { get; set; } // 0x000000018026A2E0-0x000000018026A2F0 0x0000000180377580-0x0000000180377590
		public Image captionImage { get; set; } // 0x0000000180377500-0x0000000180377510 0x0000000180377570-0x0000000180377580
		public Graphic placeholder { get; set; } // 0x0000000180287BF0-0x0000000180287C00 0x00000001803775F0-0x0000000180377600
		public TMP_Text itemText { get; set; } // 0x0000000180377510-0x0000000180377520 0x00000001803775A0-0x00000001803775B0
		public Image itemImage { get; set; } // 0x00000001803138E0-0x00000001803138F0 0x0000000180377590-0x00000001803775A0
		public List<OptionData> options { get; set; } // 0x0000000180377530-0x0000000180377550 0x00000001803775C0-0x00000001803775F0
		public DropdownEvent onValueChanged { get; set; } // 0x0000000180377520-0x0000000180377530 0x00000001803775B0-0x00000001803775C0
		public float alphaFadeSpeed { get; set; } // 0x00000001803774F0-0x0000000180377500 0x0000000180377560-0x0000000180377570
		public int value { get; set; } // 0x0000000180377550-0x0000000180377560 0x0000000180377610-0x0000000180377620
		public bool IsExpanded { get; } // 0x0000000180377490-0x00000001803774F0 
	
		// Nested types
		protected internal class DropdownItem : MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 6098
		{
			// Fields
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private TMP_Text m_Text; // 0x18
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private Image m_Image; // 0x20
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private RectTransform m_RectTransform; // 0x28
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
			public Image image { get; set; } // 0x0000000180268FF0-0x0000000180269000 0x000000018026C0A0-0x000000018026C0B0
			public RectTransform rectTransform { get; set; } // 0x0000000180268FD0-0x0000000180268FE0 0x00000001802A43E0-0x00000001802A43F0
			public Toggle toggle { get; set; } // 0x00000001802684F0-0x0000000180268500 0x00000001802A43C0-0x00000001802A43D0
	
			// Constructors
			public DropdownItem(); // 0x0000000180265240-0x0000000180265250
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x0000000180882DF0-0x0000000180882E70
			public virtual void OnCancel(BaseEventData eventData); // 0x0000000180882D60-0x0000000180882DF0
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 6099
		{
			// Fields
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private string m_Text; // 0x10
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
			public Sprite image { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018026BFE0-0x000000018026BFF0
	
			// Constructors
			public OptionData(); // 0x00000001802650F0-0x0000000180265100
			public OptionData(string text); // 0x00000001802A9A60-0x00000001802A9A90
			public OptionData(Sprite image); // 0x00000001802ACBD0-0x00000001802ACC00
			public OptionData(string text, Sprite image); // 0x000000018028A110-0x000000018028A150
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 6100
		{
			// Fields
			[SerializeField] // 0x0000000180014D50-0x0000000180014D60
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x0000000180268FC0-0x0000000180268FD0 0x000000018028FF80-0x000000018028FF90
	
			// Constructors
			public OptionDataList(); // 0x0000000180882FC0-0x0000000180883030
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 6101
		{
			// Constructors
			public DropdownEvent(); // 0x0000000180882D20-0x0000000180882D60
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class __c__DisplayClass69_0 // TypeDefIndex: 6102
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown __4__this; // 0x18
	
			// Constructors
			public __c__DisplayClass69_0(); // 0x00000001802650F0-0x0000000180265100
	
			// Methods
			internal void _Show_b__0(bool x); // 0x0000000180884E80-0x0000000180884EB0
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _DelayedDestroyDropdownList_d__81 : IEnumerator<object> // TypeDefIndex: 6103
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown __4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _DelayedDestroyDropdownList_d__81(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180883970-0x0000000180883A20
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180883A20-0x0000000180883A60
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x0000000180377390-0x0000000180377490
		static TMP_Dropdown(); // 0x0000000180377330-0x0000000180377390
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x0000000180375A70-0x0000000180375A80
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x003A1EF6 */); // 0x0000000180375A80-0x0000000180375BE0
		protected override void Awake(); // 0x0000000180374850-0x0000000180374980
		protected override void Start(); // 0x0000000180377290-0x0000000180377330
		protected override void OnDisable(); // 0x00000001803754F0-0x00000001803755A0
		public void RefreshShownValue(); // 0x00000001803756E0-0x00000001803759B0
		public void AddOptions(List<OptionData> options); // 0x0000000180374570-0x00000001803745E0
		public void AddOptions(List<string> options); // 0x0000000180374460-0x0000000180374570
		public void AddOptions(List<Sprite> options); // 0x0000000180374350-0x0000000180374460
		public void ClearOptions(); // 0x0000000180374980-0x0000000180374A30
		private void SetupTemplate(); // 0x0000000180375BE0-0x0000000180376340
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x00000001803755A0-0x00000001803755B0
		public virtual void OnSubmit(BaseEventData eventData); // 0x00000001803755A0-0x00000001803755B0
		public virtual void OnCancel(BaseEventData eventData); // 0x00000001803754E0-0x00000001803754F0
		public void Show(); // 0x0000000180376340-0x0000000180377290
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x0000000180374A30-0x0000000180374EF0
		protected virtual void DestroyBlocker(GameObject blocker); // 0x0000000180375050-0x00000001803750B0
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x0000000180374EF0-0x0000000180374F60
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x00000001803750B0-0x0000000180375110
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x0000000180374F60-0x0000000180374FD0
		protected virtual void DestroyItem(DropdownItem item); // 0x0000000180265310-0x0000000180265320
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x0000000180374060-0x0000000180374350
		private void AlphaFadeList(float duration, float alpha); // 0x00000001803745E0-0x0000000180374670
		private void AlphaFadeList(float duration, float start, float end); // 0x0000000180374670-0x0000000180374850
		private void SetAlpha(float alpha); // 0x00000001803759B0-0x0000000180375A70
		public void Hide(); // 0x0000000180375110-0x0000000180375300
		[IteratorStateMachine] // 0x000000018003BE10-0x000000018003BE60
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x0000000180374FD0-0x0000000180375050
		private void ImmediateDestroyDropdownList(); // 0x0000000180375300-0x00000001803754E0
		private void OnSelectItem(Toggle toggle); // 0x00000001803755B0-0x00000001803756E0
	}
}

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
	[AddComponentMenu] // 0x000000018003BFB0-0x000000018003BFE0
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 6142
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0xF8
		private static readonly char[] kSeparators; // 0x00
		protected RectTransform m_RectTransform; // 0x100
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected RectTransform m_TextViewport; // 0x108
		protected RectMask2D m_TextComponentRectMask; // 0x110
		protected RectMask2D m_TextViewportRectMask; // 0x118
		private Rect m_CachedViewportRect; // 0x120
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_Text m_TextComponent; // 0x130
		protected RectTransform m_TextComponentRectTransform; // 0x138
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Graphic m_Placeholder; // 0x140
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected Scrollbar m_VerticalScrollbar; // 0x148
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x150
		private bool m_IsDrivenByLayoutComponents; // 0x158
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LayoutGroup m_LayoutGroup; // 0x160
		private IScrollHandler m_IScrollHandlerParent; // 0x168
		private float m_ScrollPosition; // 0x170
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected float m_ScrollSensitivity; // 0x174
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private ContentType m_ContentType; // 0x178
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private InputType m_InputType; // 0x17C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private char m_AsteriskChar; // 0x180
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TouchScreenKeyboardType m_KeyboardType; // 0x184
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private LineType m_LineType; // 0x188
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_HideMobileInput; // 0x18C
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_HideSoftKeyboard; // 0x18D
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private CharacterValidation m_CharacterValidation; // 0x190
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private string m_RegexValue; // 0x198
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private float m_GlobalPointSize; // 0x1A0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private int m_CharacterLimit; // 0x1A4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private SubmitEvent m_OnEndEdit; // 0x1A8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private SubmitEvent m_OnSubmit; // 0x1B0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private SelectionEvent m_OnSelect; // 0x1B8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private SelectionEvent m_OnDeselect; // 0x1C0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextSelectionEvent m_OnTextSelection; // 0x1C8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TextSelectionEvent m_OnEndTextSelection; // 0x1D0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private OnChangeEvent m_OnValueChanged; // 0x1D8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1E0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private OnValidateInput m_OnValidateInput; // 0x1E8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_CaretColor; // 0x1F0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_CustomCaretColor; // 0x200
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private Color m_SelectionColor; // 0x204
		[SerializeField] // 0x000000018003BFE0-0x000000018003C020
		[TextArea] // 0x000000018003BFE0-0x000000018003C020
		protected string m_Text; // 0x218
		[Range] // 0x0000000180033660-0x00000001800336A0
		[SerializeField] // 0x0000000180033660-0x00000001800336A0
		private float m_CaretBlinkRate; // 0x220
		[Range] // 0x0000000180032B10-0x0000000180032B50
		[SerializeField] // 0x0000000180032B10-0x0000000180032B50
		private int m_CaretWidth; // 0x224
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_ReadOnly; // 0x228
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_RichText; // 0x229
		protected int m_StringPosition; // 0x22C
		protected int m_StringSelectPosition; // 0x230
		protected int m_CaretPosition; // 0x234
		protected int m_CaretSelectPosition; // 0x238
		private RectTransform caretRectTrans; // 0x240
		protected UIVertex[] m_CursorVerts; // 0x248
		private CanvasRenderer m_CachedInputRenderer; // 0x250
		private Vector2 m_LastPosition; // 0x258
		[NonSerialized]
		protected Mesh m_Mesh; // 0x260
		private bool m_AllowInput; // 0x268
		private bool m_ShouldActivateNextUpdate; // 0x269
		private bool m_UpdateDrag; // 0x26A
		private bool m_DragPositionOutOfBounds; // 0x26B
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x003A1F1F
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x003A1F23
		protected bool m_CaretVisible; // 0x26C
		private Coroutine m_BlinkCoroutine; // 0x270
		private float m_BlinkStartTime; // 0x278
		private Coroutine m_DragCoroutine; // 0x280
		private string m_OriginalText; // 0x288
		private bool m_WasCanceled; // 0x290
		private bool m_HasDoneFocusTransition; // 0x291
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x298
		private bool m_PreventCallback; // 0x2A0
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x2A1
		private bool m_IsTextComponentUpdateRequired; // 0x2A2
		private bool m_isLastKeyBackspace; // 0x2A3
		private float m_PointerDownClickStartTime; // 0x2A4
		private float m_KeyDownStartTime; // 0x2A8
		private float m_DoubleClickDelay; // 0x2AC
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x003A1F27
		private bool m_IsCompositionActive; // 0x2B0
		private bool m_ShouldUpdateIMEWindowPosition; // 0x2B1
		private int m_PreviousIMEInsertionLine; // 0x2B4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_FontAsset m_GlobalFontAsset; // 0x2B8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_OnFocusSelectAll; // 0x2C0
		protected bool m_isSelectAll; // 0x2C1
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_ResetOnDeActivation; // 0x2C2
		private bool m_SelectionStillActive; // 0x2C3
		private bool m_ReleaseSelection; // 0x2C4
		private GameObject m_PreviouslySelectedObject; // 0x2C8
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		private bool m_RestoreOriginalTextOnEscape; // 0x2D0
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected bool m_isRichTextEditingAllowed; // 0x2D1
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected int m_LineLimit; // 0x2D4
		[SerializeField] // 0x0000000180014D50-0x0000000180014D60
		protected TMP_InputValidator m_InputValidator; // 0x2D8
		private bool m_isSelected; // 0x2E0
		private bool m_IsStringPositionDirty; // 0x2E1
		private bool m_IsCaretPositionDirty; // 0x2E2
		private bool m_forceRectTransformAdjustment; // 0x2E3
		private UnityEngine.Event m_ProcessingEvent; // 0x2E8
	
		// Properties
		private BaseInput inputSystem { get; } // 0x000000018052BF90-0x000000018052C0C0 
		private string compositionString { get; } // 0x000000018052BE10-0x000000018052BEC0 
		private int compositionLength { get; } // 0x000000018052BDE0-0x000000018052BE10 
		protected Mesh mesh { get; } // 0x000000018052C120-0x000000018052C1D0 
		public bool shouldHideMobileInput { get; set; } // 0x000000018052C650-0x000000018052C680 0x000000018052DB70-0x000000018052DBF0
		public bool shouldHideSoftKeyboard { get; set; } // 0x000000018052C680-0x000000018052C6E0 0x000000018052DBF0-0x000000018052DD10
		public string text { get; set; } // 0x000000018052C6E0-0x000000018052C6F0 0x000000018052DF50-0x000000018052DF60
		public bool isFocused { get; } // 0x00000001803E8AB0-0x00000001803E8AC0 
		public float caretBlinkRate { get; set; } // 0x000000018052BCB0-0x000000018052BCC0 0x000000018052C7B0-0x000000018052C820
		public int caretWidth { get; set; } // 0x000000018052BDA0-0x000000018052BDB0 0x000000018052CA80-0x000000018052CB20
		public RectTransform textViewport { get; set; } // 0x0000000180377500-0x0000000180377510 0x000000018052DF00-0x000000018052DF50
		public TMP_Text textComponent { get; set; } // 0x000000018046A620-0x000000018046A630 0x000000018052DEA0-0x000000018052DF00
		public Graphic placeholder { get; set; } // 0x00000001803135E0-0x00000001803135F0 0x000000018052D550-0x000000018052D5A0
		public Scrollbar verticalScrollbar { get; set; } // 0x000000018052C6F0-0x000000018052C700 0x000000018052DF60-0x000000018052E130
		public float scrollSensitivity { get; set; } // 0x000000018052C5B0-0x000000018052C5C0 0x000000018052D7F0-0x000000018052D890
		public Color caretColor { get; set; } // 0x000000018052BCC0-0x000000018052BD20 0x000000018052C820-0x000000018052C8A0
		public bool customCaretColor { get; set; } // 0x000000018052BED0-0x000000018052BEE0 0x000000018052CE00-0x000000018052CE70
		public Color selectionColor { get; set; } // 0x000000018052C5C0-0x000000018052C5D0 0x000000018052D930-0x000000018052D9B0
		public SubmitEvent onEndEdit { get; set; } // 0x00000001802879C0-0x00000001802879D0 0x000000018052D2C0-0x000000018052D310
		public SubmitEvent onSubmit { get; set; } // 0x0000000180288520-0x0000000180288530 0x000000018052D3C0-0x000000018052D410
		public SelectionEvent onSelect { get; set; } // 0x00000001803E42C0-0x00000001803E42D0 0x000000018052D370-0x000000018052D3C0
		public SelectionEvent onDeselect { get; set; } // 0x0000000180288530-0x0000000180288540 0x000000018052D270-0x000000018052D2C0
		public TextSelectionEvent onTextSelection { get; set; } // 0x00000001803EB1A0-0x00000001803EB1B0 0x000000018052D410-0x000000018052D460
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x000000018052C200-0x000000018052C210 0x000000018052D310-0x000000018052D360
		public OnChangeEvent onValueChanged { get; set; } // 0x000000018052C230-0x000000018052C240 0x000000018052D500-0x000000018052D550
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x000000018052C220-0x000000018052C230 0x000000018052D460-0x000000018052D4B0
		public OnValidateInput onValidateInput { get; set; } // 0x00000001803F5770-0x00000001803F5780 0x000000018052D4B0-0x000000018052D500
		public int characterLimit { get; set; } // 0x000000018052BDB0-0x000000018052BDC0 0x000000018052CB20-0x000000018052CBD0
		public float pointSize { get; set; } // 0x000000018052C240-0x000000018052C250 0x000000018052D5A0-0x000000018052D720
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018052BEF0-0x000000018052BF00 0x000000018052CE70-0x000000018052CFB0
		public bool onFocusSelectAll { get; set; } // 0x000000018052C210-0x000000018052C220 0x000000018052D360-0x000000018052D370
		public bool resetOnDeActivation { get; set; } // 0x000000018052C580-0x000000018052C590 0x000000018052D730-0x000000018052D740
		public bool restoreOriginalTextOnEscape { get; set; } // 0x000000018052C590-0x000000018052C5A0 0x000000018052D740-0x000000018052D750
		public bool isRichTextEditingAllowed { get; set; } // 0x000000018052C0E0-0x000000018052C0F0 0x000000018052D090-0x000000018052D0A0
		public ContentType contentType { get; set; } // 0x000000018052BEC0-0x000000018052BED0 0x000000018052CC50-0x000000018052CE00
		public LineType lineType { get; set; } // 0x000000018052C110-0x000000018052C120 0x000000018052D180-0x000000018052D270
		public int lineLimit { get; set; } // 0x000000018052C100-0x000000018052C110 0x000000018052D110-0x000000018052D180
		public InputType inputType { get; set; } // 0x000000018052C0C0-0x000000018052C0D0 0x000000018052CFB0-0x000000018052D020
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x000000018052C0F0-0x000000018052C100 0x000000018052D0A0-0x000000018052D110
		public CharacterValidation characterValidation { get; set; } // 0x000000018052BDC0-0x000000018052BDD0 0x000000018052CBD0-0x000000018052CC40
		public TMP_InputValidator inputValidator { get; set; } // 0x000000018052C0D0-0x000000018052C0E0 0x000000018052D020-0x000000018052D090
		public bool readOnly { get; set; } // 0x000000018052C570-0x000000018052C580 0x000000018052D720-0x000000018052D730
		public bool richText { get; set; } // 0x000000018052C5A0-0x000000018052C5B0 0x000000018052D750-0x000000018052D7F0
		public bool multiLine { get; } // 0x000000018052C1E0-0x000000018052C200 
		public char asteriskChar { get; set; } // 0x000000018052BCA0-0x000000018052BCB0 0x000000018052C750-0x000000018052C7B0
		public bool wasCanceled { get; } // 0x000000018052C700-0x000000018052C710 
		protected int caretPositionInternal { get; set; } // 0x000000018052BD20-0x000000018052BD60 0x000000018052C8A0-0x000000018052C900
		protected int stringPositionInternal { get; set; } // 0x000000018052C5D0-0x000000018052C610 0x000000018052DD10-0x000000018052DD60
		protected int caretSelectPositionInternal { get; set; } // 0x000000018052BD60-0x000000018052BDA0 0x000000018052CA20-0x000000018052CA80
		protected int stringSelectPositionInternal { get; set; } // 0x000000018052C610-0x000000018052C650 0x000000018052DE50-0x000000018052DEA0
		private new bool hasSelection { get; } // 0x000000018052BF00-0x000000018052BF90 
		public int caretPosition { get; set; } // 0x000000018052BD60-0x000000018052BDA0 0x000000018052C900-0x000000018052CA20
		public int selectionAnchorPosition { get; set; } // 0x000000018052BD20-0x000000018052BD60 0x000000018052D890-0x000000018052D930
		public int selectionFocusPosition { get; set; } // 0x000000018052BD60-0x000000018052BDA0 0x000000018052D9B0-0x000000018052DA50
		public int stringPosition { get; set; } // 0x000000018052C610-0x000000018052C650 0x000000018052DD60-0x000000018052DE50
		public int selectionStringAnchorPosition { get; set; } // 0x000000018052C5D0-0x000000018052C610 0x000000018052DA50-0x000000018052DAE0
		public int selectionStringFocusPosition { get; set; } // 0x000000018052C610-0x000000018052C650 0x000000018052DAE0-0x000000018052DB70
		private static string clipboard { get; set; } // 0x000000018052BDD0-0x000000018052BDE0 0x000000018052CC40-0x000000018052CC50
		public virtual float minWidth { get; } // 0x000000018052C1D0-0x000000018052C1E0 
		public virtual float preferredWidth { get; } // 0x000000018052C3E0-0x000000018052C570 
		public virtual float flexibleWidth { get; } // 0x000000018052BEE0-0x000000018052BEF0 
		public virtual float minHeight { get; } // 0x000000018052C1D0-0x000000018052C1E0 
		public virtual float preferredHeight { get; } // 0x000000018052C250-0x000000018052C3E0 
		public virtual float flexibleHeight { get; } // 0x000000018052BEE0-0x000000018052BEF0 
		public virtual int layoutPriority { get; } // 0x0000000180398E30-0x0000000180398E40 
		Transform ICanvasElement.transform { get; } // 0x0000000180473370-0x0000000180473380 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 6129
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}
	
		public enum InputType // TypeDefIndex: 6130
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 6131
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}
	
		public enum LineType // TypeDefIndex: 6132
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 6133; 0x0000000180854010-0x00000001808544B0
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 6134
		{
			// Constructors
			public SubmitEvent(); // 0x00000001808835A0-0x00000001808835E0
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 6135
		{
			// Constructors
			public OnChangeEvent(); // 0x0000000180882ED0-0x0000000180882F10
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 6136
		{
			// Constructors
			public SelectionEvent(); // 0x0000000180883030-0x0000000180883070
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 6137
		{
			// Constructors
			public TextSelectionEvent(); // 0x0000000180883780-0x00000001808837C0
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 6138
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x00000001808837C0-0x0000000180883800
		}
	
		protected enum EditState // TypeDefIndex: 6139
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _CaretBlink_d__276 : IEnumerator<object> // TypeDefIndex: 6140
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _CaretBlink_d__276(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x0000000180883800-0x0000000180883930
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180883930-0x0000000180883970
		}
	
		[CompilerGenerated] // 0x0000000180014D50-0x0000000180014D60
		private sealed class _MouseDragOutsideRect_d__294 : IEnumerator<object> // TypeDefIndex: 6141
		{
			// Fields
			private int __1__state; // 0x10
			private object __2__current; // 0x18
			public TMP_InputField __4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
			object IEnumerator.Current { [DebuggerHidden] /* 0x0000000180014D50-0x0000000180014D60 */ get; } // 0x0000000180268C10-0x0000000180268C20 
	
			// Constructors
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			public _MouseDragOutsideRect_d__294(int __1__state); // 0x0000000180296FE0-0x0000000180297010
	
			// Methods
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IDisposable.Dispose(); // 0x0000000180265310-0x0000000180265320
			private bool MoveNext(); // 0x00000001808848F0-0x0000000180884B90
			[DebuggerHidden] // 0x0000000180014D50-0x0000000180014D60
			void IEnumerator.Reset(); // 0x0000000180884B90-0x0000000180884BD0
		}
	
		// Constructors
		protected TMP_InputField(); // 0x000000018052B980-0x000000018052BCA0
		static TMP_InputField(); // 0x000000018052B900-0x000000018052B980
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x000000018052C710-0x000000018052C750
		public void SetTextWithoutNotify(string input); // 0x000000018052A2B0-0x000000018052A2C0
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x003A1F1D */); // 0x000000018052A2C0-0x000000018052A420
		protected void ClampStringPos(ref int pos); // 0x000000018051FB20-0x000000018051FB60
		protected void ClampCaretPos(ref int pos); // 0x000000018051FAC0-0x000000018051FB20
		protected override void OnEnable(); // 0x0000000180527300-0x0000000180527AF0
		protected override void OnDisable(); // 0x00000001805269D0-0x0000000180526D80
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001805266B0-0x0000000180526930
		[IteratorStateMachine] // 0x000000018003C020-0x000000018003C070
		private IEnumerator CaretBlink(); // 0x000000018051FA50-0x000000018051FAC0
		private void SetCaretVisible(); // 0x0000000180529F20-0x0000000180529F60
		private void SetCaretActive(); // 0x0000000180529E70-0x0000000180529F20
		protected void OnFocus(); // 0x00000001805280F0-0x0000000180528110
		protected void SelectAll(); // 0x00000001805299A0-0x0000000180529A20
		public void MoveTextEnd(bool shift); // 0x0000000180525990-0x0000000180525B90
		public void MoveTextStart(bool shift); // 0x0000000180525B90-0x0000000180525D30
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x0000000180525D30-0x0000000180526030
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x0000000180526030-0x0000000180526350
		private bool InPlaceEditing(); // 0x0000000180522560-0x0000000180522610
		private void UpdateStringPositionFromKeyboard(); // 0x000000018052ACB0-0x000000018052B010
		protected virtual void LateUpdate(); // 0x0000000180522C50-0x00000001805233A0
		private bool MayDrag(PointerEventData eventData); // 0x0000000180523930-0x0000000180523A40
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x0000000180526930-0x0000000180526960
		public virtual void OnDrag(PointerEventData eventData); // 0x0000000180526D80-0x0000000180527300
		[IteratorStateMachine] // 0x000000018003C070-0x000000018003C0C0
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x0000000180523A40-0x0000000180523AC0
		public virtual void OnEndDrag(PointerEventData eventData); // 0x0000000180527AF0-0x0000000180527B20
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000180528140-0x0000000180528BE0
		protected EditState KeyPressed(UnityEngine.Event evt); // 0x00000001805227B0-0x0000000180522C50
		protected virtual bool IsValidChar(char c); // 0x0000000180522790-0x00000001805227B0
		public void ProcessEvent(UnityEngine.Event e); // 0x0000000180529810-0x0000000180529820
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x0000000180528F50-0x0000000180529120
		public virtual void OnScroll(PointerEventData eventData); // 0x0000000180528BE0-0x0000000180528E20
		private float GetScrollPositionRelativeToViewport(); // 0x0000000180522280-0x00000001805223E0
		private string GetSelectedString(); // 0x00000001805223E0-0x00000001805224D0
		private int FindNextWordBegin(); // 0x0000000180520740-0x0000000180520880
		private void MoveRight(bool shift, bool ctrl); // 0x00000001805250B0-0x0000000180525990
		private int FindPrevWordBegin(); // 0x0000000180520880-0x0000000180520990
		private void MoveLeft(bool shift, bool ctrl); // 0x0000000180523E40-0x0000000180524610
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x0000000180523640-0x00000001805238D0
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x00000001805233A0-0x0000000180523640
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x0000000180529490-0x0000000180529810
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x0000000180529120-0x0000000180529490
		private void MoveDown(bool shift); // 0x0000000180523AC0-0x0000000180523AD0
		private void MoveDown(bool shift, bool goToLastChar); // 0x0000000180523AD0-0x0000000180523E40
		private void MoveUp(bool shift); // 0x0000000180526350-0x0000000180526360
		private void MoveUp(bool shift, bool goToFirstChar); // 0x0000000180526360-0x00000001805266B0
		private void MovePageUp(bool shift); // 0x0000000180524B70-0x0000000180524B80
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x0000000180524B80-0x00000001805250B0
		private void MovePageDown(bool shift); // 0x0000000180524B60-0x0000000180524B70
		private void MovePageDown(bool shift, bool goToLastChar); // 0x0000000180524610-0x0000000180524B60
		private void Delete(); // 0x0000000180520290-0x00000001805205A0
		private void DeleteKey(); // 0x000000018051FF60-0x0000000180520290
		private void Backspace(); // 0x000000018051F630-0x000000018051FA50
		protected virtual void Append(string input); // 0x000000018051EEA0-0x000000018051EF50
		protected virtual void Append(char input); // 0x000000018051E910-0x000000018051EEA0
		private void Insert(char c); // 0x0000000180522610-0x0000000180522790
		private void UpdateTouchKeyboardFromEditChanges(); // 0x000000018052B010-0x000000018052B060
		private void SendOnValueChangedAndUpdateLabel(); // 0x0000000180529D50-0x0000000180529DB0
		private void SendOnValueChanged(); // 0x0000000180529DB0-0x0000000180529E00
		protected void SendOnEndEdit(); // 0x0000000180529A20-0x0000000180529A70
		protected void SendOnSubmit(); // 0x0000000180529C10-0x0000000180529C60
		protected void SendOnFocus(); // 0x0000000180529BC0-0x0000000180529C10
		protected void SendOnFocusLost(); // 0x0000000180529B70-0x0000000180529BC0
		protected void SendOnTextSelection(); // 0x0000000180529C60-0x0000000180529D50
		protected void SendOnEndTextSelection(); // 0x0000000180529A70-0x0000000180529B70
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x0000000180529E00-0x0000000180529E70
		protected void UpdateLabel(); // 0x000000018052A570-0x000000018052AB90
		private void UpdateScrollbar(); // 0x000000018052AB90-0x000000018052ACB0
		private void OnScrollbarValueChange(float value); // 0x0000000180528E20-0x0000000180528E60
		private void UpdateMaskRegions(); // 0x0000000180265310-0x0000000180265320
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x000000018051E640-0x000000018051E910
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x0000000180522150-0x00000001805221E0
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x00000001805221E0-0x0000000180522280
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x0000000180522150-0x00000001805221E0
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x00000001805224D0-0x0000000180522560
		public void ForceLabelUpdate(); // 0x0000000180520990-0x00000001805209A0
		private void MarkGeometryAsDirty(); // 0x00000001805238D0-0x0000000180523930
		public virtual void Rebuild(CanvasUpdate update); // 0x0000000180529820-0x00000001805298F0
		public virtual void LayoutComplete(); // 0x0000000180265310-0x0000000180265320
		public virtual void GraphicUpdateComplete(); // 0x0000000180265310-0x0000000180265320
		private void UpdateGeometry(); // 0x000000018052A4B0-0x000000018052A570
		private void AssignPositioningIfNeeded(); // 0x000000018051EF50-0x000000018051F630
		private void OnFillVBO(Mesh vbo); // 0x0000000180527B20-0x00000001805280F0
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001805209A0-0x0000000180521670
		private void CreateCursorVerts(); // 0x000000018051FB60-0x000000018051FD00
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x0000000180521670-0x0000000180522150
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x000000018051DE80-0x000000018051E640
		protected char Validate(string text, int pos, char ch); // 0x000000018052B060-0x000000018052B900
		public void ActivateInputField(); // 0x000000018051DD30-0x000000018051DE80
		private void ActivateInputFieldInternal(); // 0x000000018051D830-0x000000018051DD30
		public override void OnSelect(BaseEventData eventData); // 0x0000000180528E60-0x0000000180528EC0
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000180528110-0x0000000180528140
		public void OnControlClick(); // 0x0000000180265310-0x0000000180265320
		public void ReleaseSelection(); // 0x00000001805298F0-0x00000001805299A0
		public void DeactivateInputField(bool clearSelection = false /* Metadata: 0x003A1F1E */); // 0x000000018051FD00-0x000000018051FF60
		public override void OnDeselect(BaseEventData eventData); // 0x0000000180526960-0x00000001805269D0
		public virtual void OnSubmit(BaseEventData eventData); // 0x0000000180528EC0-0x0000000180528F50
		private void EnforceContentType(); // 0x00000001805205D0-0x0000000180520740
		private void SetTextComponentWrapMode(); // 0x000000018052A1F0-0x000000018052A2B0
		private void SetTextComponentRichTextMode(); // 0x000000018052A160-0x000000018052A1F0
		private void SetToCustomIfContentTypeIsNot(params /* 0x0000000180014D50-0x0000000180014D60 */ ContentType[] allowedContentTypes); // 0x000000018052A420-0x000000018052A490
		private void SetToCustom(); // 0x000000018052A490-0x000000018052A4B0
		private void SetToCustom(CharacterValidation characterValidation); // 0x000000018052A490-0x000000018052A4B0
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x00000001805205A0-0x00000001805205D0
		public virtual void CalculateLayoutInputHorizontal(); // 0x0000000180265310-0x0000000180265320
		public virtual void CalculateLayoutInputVertical(); // 0x0000000180265310-0x0000000180265320
		public void SetGlobalPointSize(float pointSize); // 0x000000018052A060-0x000000018052A160
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x0000000180529F60-0x000000018052A060
	}
}

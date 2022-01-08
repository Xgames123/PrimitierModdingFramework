/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 50: SteamVR.dll - Assembly: SteamVR, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7133-7547

namespace Valve.VR.InteractionSystem
{
	[RequireComponent] // 0x0000000180025490-0x00000001800254E0
	public class ItemPackageSpawner : MonoBehaviour // TypeDefIndex: 7427
	{
		// Fields
		public ItemPackage _itemPackage; // 0x18
		public bool useItemPackagePreview; // 0x20
		private bool useFadedPreview; // 0x21
		private GameObject previewObject; // 0x28
		public bool requireGrabActionToTake; // 0x30
		public bool requireReleaseActionToReturn; // 0x31
		public bool showTriggerHint; // 0x32
		[EnumFlags] // 0x0000000180024D60-0x0000000180024D70
		public Hand.AttachmentFlags attachmentFlags; // 0x34
		public bool takeBackItem; // 0x38
		public bool acceptDifferentItems; // 0x39
		private GameObject spawnedItem; // 0x40
		private bool itemIsSpawned; // 0x48
		public UnityEvent pickupEvent; // 0x50
		public UnityEvent dropEvent; // 0x58
		public bool justPickedUpItem; // 0x60
	
		// Properties
		public ItemPackage itemPackage { get; set; } // 0x0000000180268C10-0x0000000180268C20 0x000000018035AD50-0x000000018035AD60
	
		// Constructors
		public ItemPackageSpawner(); // 0x000000018035AD30-0x000000018035AD50
	
		// Methods
		private void CreatePreviewObject(); // 0x0000000180359D10-0x0000000180359F70
		private void Start(); // 0x000000018035AB70-0x000000018035AC30
		private void VerifyItemPackage(); // 0x000000018035AB70-0x000000018035AC30
		private void ItemPackageNotValid(); // 0x000000018035A1A0-0x000000018035A2A0
		private void ClearPreview(); // 0x00000001803599D0-0x0000000180359D10
		private void Update(); // 0x000000018035AC90-0x000000018035AD30
		private void OnHandHoverBegin(Hand hand); // 0x000000018035A2A0-0x000000018035A3A0
		private void TakeBackItem(Hand hand); // 0x000000018035AC30-0x000000018035AC90
		private ItemPackage GetAttachedItemPackage(Hand hand); // 0x0000000180359F70-0x000000018035A060
		private void HandHoverUpdate(Hand hand); // 0x000000018035A060-0x000000018035A1A0
		private void OnHandHoverEnd(Hand hand); // 0x000000018035A3A0-0x000000018035A3E0
		private void RemoveMatchingItemsFromHandStack(ItemPackage package, Hand hand); // 0x000000018035A570-0x000000018035A790
		private void RemoveMatchingItemTypesFromHand(ItemPackage.ItemPackageType packageType, Hand hand); // 0x000000018035A3E0-0x000000018035A570
		private void SpawnAndAttachObject(Hand hand, GrabTypes grabType); // 0x000000018035A790-0x000000018035AB70
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 66: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8552-8785

namespace Pinwheel.Jupiter
{
	public static class JMat // TypeDefIndex: 8725
	{
		// Fields
		public static readonly int NOISE_TEX; // 0x00
		public static readonly int CLOUD_TEX; // 0x04
		public static readonly int SKY_COLOR; // 0x08
		public static readonly int HORIZON_COLOR; // 0x0C
		public static readonly int GROUND_COLOR; // 0x10
		public static readonly int HORIZON_THICKNESS; // 0x14
		public static readonly int HORIZON_EXPONENT; // 0x18
		public static readonly int HORIZON_STEP; // 0x1C
		public static readonly int FOG_COLOR; // 0x20
		public static readonly string KW_STARS; // 0x28
		public static readonly string KW_STARS_LAYER_0; // 0x30
		public static readonly string KW_STARS_LAYER_1; // 0x38
		public static readonly string KW_STARS_LAYER_2; // 0x40
		public static readonly int STARS_START; // 0x48
		public static readonly int STARS_END; // 0x4C
		public static readonly int STARS_OPACITY; // 0x50
		public static readonly int STARS_COLOR_0; // 0x54
		public static readonly int STARS_COLOR_1; // 0x58
		public static readonly int STARS_COLOR_2; // 0x5C
		public static readonly int STARS_DENSITY_0; // 0x60
		public static readonly int STARS_DENSITY_1; // 0x64
		public static readonly int STARS_DENSITY_2; // 0x68
		public static readonly int STARS_SIZE_0; // 0x6C
		public static readonly int STARS_SIZE_1; // 0x70
		public static readonly int STARS_SIZE_2; // 0x74
		public static readonly int STARS_GLOW_0; // 0x78
		public static readonly int STARS_GLOW_1; // 0x7C
		public static readonly int STARS_GLOW_2; // 0x80
		public static readonly int STARS_TWINKLE_0; // 0x84
		public static readonly int STARS_TWINKLE_1; // 0x88
		public static readonly int STARS_TWINKLE_2; // 0x8C
		public static readonly string KW_STARS_BAKED; // 0x90
		public static readonly int STARS_CUBEMAP; // 0x98
		public static readonly int STARS_TWINKLE_MAP; // 0x9C
		public static readonly string KW_SUN; // 0xA0
		public static readonly string KW_SUN_USE_TEXTURE; // 0xA8
		public static readonly int SUN_TEX; // 0xB0
		public static readonly int SUN_COLOR; // 0xB4
		public static readonly int SUN_SIZE; // 0xB8
		public static readonly int SUN_SOFT_EDGE; // 0xBC
		public static readonly int SUN_GLOW; // 0xC0
		public static readonly int SUN_DIRECTION; // 0xC4
		public static readonly int SUN_TRANSFORM_MATRIX; // 0xC8
		public static readonly int SUN_LIGHT_COLOR; // 0xCC
		public static readonly int SUN_LIGHT_INTENSITY; // 0xD0
		public static readonly string KW_SUN_BAKED; // 0xD8
		public static readonly int SUN_CUBEMAP; // 0xE0
		public static readonly int SUN_ROTATION_MATRIX; // 0xE4
		public static readonly string KW_MOON; // 0xE8
		public static readonly string KW_MOON_USE_TEXTURE; // 0xF0
		public static readonly int MOON_TEX; // 0xF8
		public static readonly int MOON_COLOR; // 0xFC
		public static readonly int MOON_SIZE; // 0x100
		public static readonly int MOON_SOFT_EDGE; // 0x104
		public static readonly int MOON_GLOW; // 0x108
		public static readonly int MOON_DIRECTION; // 0x10C
		public static readonly int MOON_TRANSFORM_MATRIX; // 0x110
		public static readonly int MOON_LIGHT_COLOR; // 0x114
		public static readonly int MOON_LIGHT_INTENSITY; // 0x118
		public static readonly string KW_MOON_BAKED; // 0x120
		public static readonly int MOON_CUBEMAP; // 0x128
		public static readonly int MOON_ROTATION_MATRIX; // 0x12C
		public static readonly string KW_HORIZON_CLOUD; // 0x130
		public static readonly int HORIZON_CLOUD_COLOR; // 0x138
		public static readonly int HORIZON_CLOUD_START; // 0x13C
		public static readonly int HORIZON_CLOUD_END; // 0x140
		public static readonly int HORIZON_CLOUD_SIZE; // 0x144
		public static readonly int HORIZON_CLOUD_STEP; // 0x148
		public static readonly int HORIZON_CLOUD_ANIMATION_SPEED; // 0x14C
		public static readonly string KW_OVERHEAD_CLOUD; // 0x150
		public static readonly int OVERHEAD_CLOUD_COLOR; // 0x158
		public static readonly int OVERHEAD_CLOUD_ALTITUDE; // 0x15C
		public static readonly int OVERHEAD_CLOUD_SIZE; // 0x160
		public static readonly int OVERHEAD_CLOUD_STEP; // 0x164
		public static readonly int OVERHEAD_CLOUD_ANIMATION_SPEED; // 0x168
		public static readonly int OVERHEAD_CLOUD_FLOW_X; // 0x16C
		public static readonly int OVERHEAD_CLOUD_FLOW_Z; // 0x170
		public static readonly int OVERHEAD_CLOUD_REMAP_MIN; // 0x174
		public static readonly int OVERHEAD_CLOUD_REMAP_MAX; // 0x178
		public static readonly int OVERHEAD_CLOUD_SHADOW_CLIP_MASK; // 0x17C
		public static readonly string KW_DETAIL_OVERLAY; // 0x180
		public static readonly string KW_DETAIL_OVERLAY_ROTATION; // 0x188
		public static readonly int DETAIL_OVERLAY_COLOR; // 0x190
		public static readonly int DETAIL_OVERLAY_CUBEMAP; // 0x194
		public static readonly int DETAIL_OVERLAY_LAYER; // 0x198
		public static readonly int DETAIL_OVERLAY_ROTATION_SPEED; // 0x19C
		public static readonly string KW_ALLOW_STEP_EFFECT; // 0x1A0
		private static Material activeMaterial; // 0x1A8
	
		// Constructors
		static JMat(); // 0x0000000180310F80-0x0000000180311EA0
	
		// Methods
		public static void SetActiveMaterial(Material mat); // 0x0000000180310220-0x0000000180310290
		public static void GetColor(int prop, ref Color value); // 0x000000018030FB70-0x000000018030FCE0
		public static void GetFloat(int prop, ref float value); // 0x000000018030FCE0-0x000000018030FE40
		public static void GetVector(int prop, ref Vector4 value); // 0x00000001803100B0-0x0000000180310220
		public static void GetTexture(int prop, ref Texture value); // 0x000000018030FF50-0x00000001803100B0
		public static void GetKeywordEnabled(string kw, ref bool value); // 0x000000018030FE40-0x000000018030FF50
		public static void SetColor(int prop, Color value); // 0x0000000180310320-0x0000000180310490
		public static void SetFloat(int prop, float value); // 0x0000000180310520-0x0000000180310680
		public static void SetVector(int prop, Vector4 value); // 0x0000000180310D80-0x0000000180310EF0
		public static void SetTexture(int prop, Texture value); // 0x0000000180310C20-0x0000000180310D80
		public static void SetMatrix(int prop, Matrix4x4 value); // 0x00000001803107E0-0x0000000180310980
		public static void SetKeywordEnable(string kw, bool enable); // 0x0000000180310680-0x00000001803107E0
		public static void SetOverrideTag(string tag, string value); // 0x0000000180310980-0x0000000180310A10
		public static void SetRenderQueue(int queue); // 0x0000000180310A10-0x0000000180310A90
		public static void SetRenderQueue(RenderQueue queue); // 0x0000000180310A90-0x0000000180310B10
		public static void SetSourceBlend(UnityEngine.Rendering.BlendMode mode); // 0x0000000180310B90-0x0000000180310C20
		public static void SetDestBlend(UnityEngine.Rendering.BlendMode mode); // 0x0000000180310490-0x0000000180310520
		public static void SetZWrite(bool value); // 0x0000000180310EF0-0x0000000180310F80
		public static void SetBlend(bool value); // 0x0000000180310290-0x0000000180310320
		public static void SetShader(Shader shader); // 0x0000000180310B10-0x0000000180310B90
	}
}

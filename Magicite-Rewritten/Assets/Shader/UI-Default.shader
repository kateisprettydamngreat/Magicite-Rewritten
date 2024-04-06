//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "UI/Default" {
Properties {
[PerRendererData]  _MainTex ("Sprite Texture", 2D) = "white" { }
 _Color ("Tint", Color) = (1,1,1,1)
 _StencilComp ("Stencil Comparison", Float) = 8
 _Stencil ("Stencil ID", Float) = 0
 _StencilOp ("Stencil Operation", Float) = 0
 _StencilWriteMask ("Stencil Write Mask", Float) = 255
 _StencilReadMask ("Stencil Read Mask", Float) = 255
 _ColorMask ("Color Mask", Float) = 15
}
SubShader { 
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="true" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="true" }
  ZTest [unity_GUIZTestMode]
  ZWrite Off
  Cull Off
  Stencil {
   Ref [_Stencil]
   ReadMask [_StencilReadMask]
   WriteMask [_StencilWriteMask]
   Comp [_StencilComp]
   Pass [_StencilOp]
  }
  Blend SrcAlpha OneMinusSrcAlpha
  ColorMask [_ColorMask]
  GpuProgramID 29864
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_Color]
Vector 4 [_ScreenParams]
"vs_2_0
def c6, -1, 1, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord v2
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp4 r0.x, c0, v0
dp4 r0.y, c1, v0
mov r1.x, c6.x
add r0.zw, r1.x, c4
mad oPos.xy, r0.zwzw, c6, r0
mul oD0, v1, c5
mov oT0.xy, v2
mov oT1, v0

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 2 [_ClipRect]
Vector 0 [_TextureSampleAdd]
Float 3 [_UseAlphaClip]
Float 1 [_UseClipRect]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c4, 1, 0, -0.00100000005, 0
dcl v0
dcl_pp t0.xy
dcl t1.xy
dcl_2d s0
texld r0, t0, s0
add r1.x, -t1.x, c2.z
add r1.y, -t1.y, c2.w
cmp r1.xy, r1, c4.x, c4.y
add r1.zw, t1.wzyx, -c2.wzyx
cmp r1.xy, r1.wzyx, r1, c4.y
mul r1.x, r1.y, r1.x
add r0, r0, c0
mul_pp r0, r0, v0
mul_pp r1, r1.x, r0
cmp_pp r0, -c1.x, r0, r1
add_pp r1.x, r0.w, c4.z
mov_pp oC0, r0
mul_pp r0, r1.x, c3.x
texkill r0

"
}
}
 }
}
}
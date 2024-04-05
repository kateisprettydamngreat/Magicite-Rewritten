//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/CubeCopy" {
Properties {
 _MainTex ("Main", CUBE) = "" { }
 _Level ("Level", Float) = 0
}
SubShader { 
 LOD 200
 Tags { "RenderType"="Opaque" }
 Pass {
  Tags { "RenderType"="Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 16705
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
"vs_3_0
dcl_position v0
dcl_texcoord v1
dcl_position o0
dcl_texcoord o1
dp4 o0.x, c0, v0
dp4 o0.y, c1, v0
dp4 o0.z, c2, v0
dp4 o0.w, c3, v0
mov o1, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Level]
SetTexture 0 [_MainTex] CUBE 0
"ps_3_0
dcl_texcoord_pp v0.xyz
dcl_cube s0
mov_pp r0.xyz, v0
mov_pp r0.w, c0.x
texldl oC0, r0, s0

"
}
}
 }
}
SubShader { 
 LOD 200
 Tags { "RenderType"="Opaque" }
 Pass {
  Tags { "RenderType"="Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 110530
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
"vs_2_0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov oT0, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Level]
SetTexture 0 [_MainTex] CUBE 0
"ps_2_0
dcl_pp t0.xyz
dcl_cube s0
mov_pp r0.xyz, t0
mov_pp r0.w, c0.x
texldb r0, r0, s0
mov oC0, r0

"
}
}
 }
}
}
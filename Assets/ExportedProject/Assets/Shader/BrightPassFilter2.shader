//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/BrightPassFilter2" {
Properties {
 _MainTex ("Base (RGB)", 2D) = "" { }
}
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 54406
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
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [_Threshhold]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 0, 0, 0, 0
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
add_pp r1.xyz, r0, -c0.x
max_pp r0.xyz, r1, c1.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 113940
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
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [_Threshhold]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 0, 0, 0, 0
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
add_pp r1.xyz, r0, -c0
max_pp r0.xyz, r1, c1.x
mov_pp oC0, r0

"
}
}
 }
}
Fallback Off
}
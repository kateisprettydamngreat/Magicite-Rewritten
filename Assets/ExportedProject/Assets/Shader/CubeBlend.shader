//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/CubeBlend" {
Properties {
[NoScaleOffset]  _TexA ("Cubemap", CUBE) = "grey" { }
[NoScaleOffset]  _TexB ("Cubemap", CUBE) = "grey" { }
 _value ("Value", Range(0,1)) = 0.5
}
SubShader { 
 Tags { "QUEUE"="Background" "RenderType"="Background" }
 Pass {
  Tags { "QUEUE"="Background" "RenderType"="Background" }
  ZTest Always
  ZWrite Off
  GpuProgramID 17682
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
"vs_3_0
dcl_position v0
dcl_texcoord v1
dcl_position o0
dcl_texcoord o1.xyz
dp4 o0.x, c0, v0
dp4 o0.y, c1, v0
dp4 o0.z, c2, v0
dp4 o0.w, c3, v0
mov o1.xyz, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 2 [_Level]
Vector 0 [_TexA_HDR]
Vector 1 [_TexB_HDR]
Float 3 [_value]
SetTexture 0 [_TexA] CUBE 0
SetTexture 1 [_TexB] CUBE 1
"ps_3_0
def c4, 1, 0, 0, 0
dcl_texcoord_pp v0.xyz
dcl_cube s0
dcl_cube s1
mov_pp r0.xyz, v0
mov_pp r0.w, c2.x
texldl_pp r1, r0, s0
texldl_pp r0, r0, s1
pow_pp r2.x, r1.w, c0.y
mul_pp r1.w, r2.x, c0.x
mul_pp r1.xyz, r1, r1.w
pow_pp r1.w, r0.w, c1.y
mul_pp r0.w, r1.w, c1.x
mad r0.xyz, r0.w, r0, -r1
mad_pp oC0.xyz, c3.x, r0, r1
mov_pp oC0.w, c4.x

"
}
}
 }
}
SubShader { 
 Tags { "QUEUE"="Background" "RenderType"="Background" }
 Pass {
  Tags { "QUEUE"="Background" "RenderType"="Background" }
  ZTest Always
  ZWrite Off
  GpuProgramID 113859
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
mov oT0.xyz, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 2 [_Level]
Vector 0 [_TexA_HDR]
Vector 1 [_TexB_HDR]
Float 3 [_value]
SetTexture 0 [_TexA] CUBE 0
SetTexture 1 [_TexB] CUBE 1
"ps_2_0
def c4, 1, 0, 0, 0
dcl_pp t0.xyz
dcl_cube s0
dcl_cube s1
mov_pp r0.xyz, t0
mov_pp r0.w, c2.x
texldb_pp r1, r0, s0
texldb_pp r0, r0, s1
pow_pp r2.w, r1.w, c0.y
mul_pp r1.w, r2.w, c0.x
mul_pp r1.xyz, r1, r1.w
pow_pp r1.w, r0.w, c1.y
mul_pp r0.w, r1.w, c1.x
mad r0.xyz, r0.w, r0, -r1
mad_pp r0.xyz, c3.x, r0, r1
mov_pp r0.w, c4.x
mov_pp oC0, r0

"
}
}
 }
}
Fallback Off
}
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/LensFlareCreate" {
Properties {
 _MainTex ("Base (RGB)", 2D) = "" { }
}
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Blend One One
  GpuProgramID 20397
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
"vs_2_0
def c4, -0.5, -0.850000024, 0.5, -1.45000005
def c5, -2.54999995, 0.5, -4.1500001, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
add r0, v1.xyxy, c4.x
mad oT0.xy, r0.zwzw, c4.y, c4.z
mad oT1.xy, r0.zwzw, c4.w, c4.z
mad oT2.xy, r0, c5.x, c5.y
mad oT3.xy, r0.zwzw, c5.z, c5.y

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [colorA]
Vector 1 [colorB]
Vector 2 [colorC]
Vector 3 [colorD]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl t0.xy
dcl t1.xy
dcl t2.xy
dcl t3.xy
dcl_2d s0
texld r0, t1, s0
texld r1, t0, s0
texld r2, t2, s0
texld r3, t3, s0
mul r0, r0, c1
mad_pp r0, r1, c0, r0
mad_pp r0, r2, c2, r0
mad_pp r0, r3, c3, r0
mov_pp oC0, r0

"
}
}
 }
}
Fallback Off
}
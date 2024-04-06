//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/BlendForBloom" {
Properties {
 _MainTex ("Screen Blended", 2D) = "" { }
 _ColorBuffer ("Color", 2D) = "" { }
}
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 57851
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Intensity]
SetTexture 0 [_ColorBuffer] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
def c1, 1, 0, 0, 0
dcl t0.xy
dcl t1.xy
dcl_2d s0
dcl_2d s1
texld r0, t0, s1
texld_pp r1, t1, s0
mov r2.w, c1.x
mad_pp r0, r0, -c0.x, r2.w
add_pp r1, -r1, c1.x
mad_pp r0, r0, -r1, c1.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 70419
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Intensity]
SetTexture 0 [_ColorBuffer] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
dcl t0.xy
dcl t1.xy
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s1
texld_pp r1, t1, s0
mad_pp r0, c0.x, r0, r1
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 159112
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_MainTex_TexelSize]
"vs_2_0
def c5, 0.5, -0.5, 0, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.xy, c4
mad oT0.xy, r0, c5.x, v1
mad oT1.xy, r0, -c5.x, v1
mad oT2.xy, r0, -c5, v1
mad oT3.xy, r0, c5, v1
mov oT4.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl t0.xy
dcl t1.xy
dcl t2.xy
dcl t3.xy
dcl t4.xy
dcl_2d s0
texld_pp r0, t4, s0
texld_pp r1, t0, s0
texld_pp r2, t1, s0
texld_pp r3, t2, s0
texld_pp r4, t3, s0
max_pp r5, r0, r1
max_pp r0, r5, r2
max_pp r1, r0, r3
max_pp r0, r1, r4
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 243015
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_ColorBuffer] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
dcl t0.xy
dcl_2d s0
dcl_2d s1
texld r0, t0, s1
texld r1, t0, s0
mul_pp r0, r0, r1
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 295431
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Intensity]
SetTexture 0 [_ColorBuffer] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
def c1, 1, 0, 0, 0
dcl t0.xy
dcl t1.xy
dcl_2d s0
dcl_2d s1
texld r0, t0, s1
texld_pp r1, t1, s0
mov r2.w, c1.x
mad_pp r0, r0, -c0.x, r2.w
add_pp r1, -r1, c1.x
mad_pp r0, r0, -r1, c1.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 375373
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Intensity]
SetTexture 0 [_ColorBuffer] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
dcl t0.xy
dcl t1.xy
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s1
texld_pp r1, t1, s0
mad_pp r0, c0.x, r0, r1
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 413446
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_MainTex_TexelSize]
"vs_2_0
def c5, 0.5, -0.5, 0, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.xy, c4
mad oT0.xy, r0, c5.x, v1
mad oT1.xy, r0, -c5.x, v1
mad oT2.xy, r0, -c5, v1
mad oT3.xy, r0, c5, v1
mov oT4.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, 0.25, 0, 0, 0
dcl t0.xy
dcl t1.xy
dcl t2.xy
dcl t3.xy
dcl_2d s0
texld_pp r0, t0, s0
texld r1, t1, s0
texld r2, t2, s0
texld r3, t3, s0
add_pp r0, r0, r1
add_pp r0, r2, r0
add_pp r0, r3, r0
mul_pp r0, r0, c0.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Blend Zero SrcAlpha
  GpuProgramID 464982
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_ColorBuffer] 2D 0
"ps_2_0
def c0, 1, 0, 0, 0
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mov_pp r0.w, r0.x
mov_pp r0.xyz, c0.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 574249
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
"ps_2_0
def c0, 0, 0, 0, 0
mov_pp r0, c0.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Blend One One
  GpuProgramID 652785
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Intensity]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0, r0, c0.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Blend One One
 BlendOp Max
  GpuProgramID 720571
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ColorBuffer_TexelSize]
"vs_2_0
def c5, 0, -2, 1, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.x, c5.x
slt r0.x, c4.y, r0.x
mad r0.y, v1.y, c5.y, c5.z
mad oT1.y, r0.x, r0.y, v1.y
mov oT0.xy, v1
mov oT1.x, v1.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mov_pp oC0, r0

"
}
}
 }
}
Fallback Off
}
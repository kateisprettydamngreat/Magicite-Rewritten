//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/BlurAndFlares" {
Properties {
 _MainTex ("Base (RGB)", 2D) = "" { }
 _NonBlurredTex ("Base (RGB)", 2D) = "" { }
}
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 13775
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
Vector 0 [unity_ColorSpaceLuminance]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 2, 1.5, 0, 0
dcl_pp t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r1.xyz, r0, c0
add_pp r1.z, r1.z, r1.x
mul_pp r1.z, r1.z, r1.y
add_pp r1.x, r1.y, r1.x
mad_pp r1.x, r0.z, c0.z, r1.x
rsq_pp r1.y, r1.z
rcp_pp r1.y, r1.y
mul_pp r1.y, r1.y, c0.w
mad_pp r1.x, r1.y, c1.x, r1.x
add_pp r1.x, r1.x, c1.y
rcp r1.x, r1.x
mul_pp r0, r0, r1.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 113141
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_Offsets]
Float 5 [_StretchWidth]
"vs_2_0
def c6, 4, 6, 0, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
add r0.x, c5.x, c5.x
mad oT1.xy, r0.x, c4, v1
mad oT2.xy, r0.x, -c4, v1
mov r0.x, c5.x
mul r0, r0.x, c6.xxyy
mad oT3.xy, r0, c4, v1
mad oT4.xy, r0, -c4, v1
mad oT5.xy, r0.zwzw, c4, v1
mad oT6.xy, r0.zwzw, -c4, v1
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl_pp t0.xy
dcl_pp t1.xy
dcl_pp t2.xy
dcl_pp t3.xy
dcl_pp t4.xy
dcl_pp t5.xy
dcl_pp t6.xy
dcl_2d s0
texld_pp r0, t0, s0
texld_pp r1, t1, s0
texld_pp r2, t2, s0
texld_pp r3, t3, s0
texld_pp r4, t4, s0
texld_pp r5, t5, s0
texld_pp r6, t6, s0
max_pp r7, r0, r1
max_pp r0, r7, r2
max_pp r1, r0, r3
max_pp r0, r1, r4
max_pp r1, r0, r5
max_pp r0, r1, r6
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 148306
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_MainTex_TexelSize]
Vector 4 [_Offsets]
"vs_2_0
def c6, 0.5, 1.5, 2.5, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.xy, c4
mul r0.xy, r0, c5
mad oT1.xy, r0, c6.x, v1
mad oT2.xy, r0, -c6.x, v1
mad oT3.xy, r0, c6.y, v1
mad oT4.xy, r0, -c6.y, v1
mad oT5.xy, r0, c6.z, v1
mad oT6.xy, r0, -c6.z, v1
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 3 [_Saturation]
Vector 2 [_Threshhold]
Vector 1 [_TintColor]
Vector 0 [unity_ColorSpaceLuminance]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c4, 0.142857149, 0, 2, 0
dcl_pp t0.xy
dcl_pp t1.xy
dcl_pp t2.xy
dcl_pp t3.xy
dcl_pp t4.xy
dcl_pp t5.xy
dcl_pp t6.xy
dcl_2d s0
texld_pp r0, t0, s0
texld r1, t1, s0
texld r2, t2, s0
texld r3, t3, s0
texld r4, t4, s0
texld r5, t5, s0
texld r6, t6, s0
add_pp r0, r0, r1
add_pp r0, r2, r0
add_pp r0, r3, r0
add_pp r0, r4, r0
add_pp r0, r5, r0
add_pp r0, r6, r0
mov r1.x, c4.x
mad_pp r0, r0, r1.x, -c2.x
max_pp r1, r0, c4.y
mul_pp r0.xyz, r1, c0
add_pp r0.z, r0.z, r0.x
mul_pp r0.z, r0.z, r0.y
add_pp r0.x, r0.y, r0.x
mad_pp r0.x, r1.z, c0.z, r0.x
rsq_pp r0.y, r0.z
rcp_pp r0.y, r0.y
mul_pp r0.y, r0.y, c0.w
mad_pp r0.x, r0.y, c4.z, r0.x
lrp_pp r2.xyz, c3.x, r1, r0.x
mul_pp r1.xyz, r2, c1
mov_pp oC0, r1

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 227819
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_MainTex_TexelSize]
Vector 4 [_Offsets]
"vs_2_0
def c6, 0.5, 1.5, 2.5, 0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.xy, c4
mul r0.xy, r0, c5
mad oT1.xy, r0, c6.x, v1
mad oT2.xy, r0, -c6.x, v1
mad oT3.xy, r0, c6.y, v1
mad oT4.xy, r0, -c6.y, v1
mad oT5.xy, r0, c6.z, v1
mad oT6.xy, r0, -c6.z, v1
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [unity_ColorSpaceLuminance]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 2, 7.5, 0, 0
dcl_pp t0.xy
dcl_pp t1.xy
dcl_pp t2.xy
dcl_pp t3.xy
dcl_pp t4.xy
dcl_pp t5.xy
dcl_pp t6.xy
dcl_2d s0
texld_pp r0, t0, s0
texld r1, t1, s0
texld r2, t2, s0
texld r3, t3, s0
texld r4, t4, s0
texld r5, t5, s0
texld r6, t6, s0
add_pp r0, r0, r1
add_pp r0, r2, r0
add_pp r0, r3, r0
add_pp r0, r4, r0
add_pp r0, r5, r0
add_pp r0, r6, r0
mul_pp r1.xyz, r0, c0
add_pp r1.z, r1.z, r1.x
mul_pp r1.z, r1.z, r1.y
add_pp r1.x, r1.y, r1.x
mad_pp r1.x, r0.z, c0.z, r1.x
rsq_pp r1.y, r1.z
rcp_pp r1.y, r1.y
mul_pp r1.y, r1.y, c0.w
mad_pp r1.x, r1.y, c1.x, r1.x
add_pp r1.x, r1.x, c1.y
rcp r1.x, r1.x
mul_pp r0, r0, r1.x
mov_pp oC0, r0

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 272114
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_Offsets]
"vs_2_0
def c5, 1, -1, 2, -2
def c6, 3, -3, 5, -5
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mov r0.xy, c4
mad oT1, r0.xyxy, c5.xxyy, v1.xyxy
mad oT2, r0.xyxy, c5.zzww, v1.xyxy
mad oT3, r0.xyxy, c6.xxyy, v1.xyxy
mad oT4, r0.xyxy, c6.zzww, v1.xyxy
mov oT0.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, 0.0524999984, 0, 0, 0
def c1, 0.150000006, 0.224999994, 0.109999999, 0.075000003
dcl_pp t0.xy
dcl_pp t1
dcl_pp t2
dcl_pp t3
dcl_pp t4
dcl_2d s0
mov_pp r0.x, t1.z
mov_pp r0.y, t1.w
mov_pp r1.x, t2.z
mov_pp r1.y, t2.w
mov_pp r2.x, t3.z
mov_pp r2.y, t3.w
mov_pp r3.x, t4.z
mov_pp r3.y, t4.w
texld r4, t1, s0
texld r5, t0, s0
texld r0, r0, s0
texld r6, t2, s0
texld r1, r1, s0
texld r7, t3, s0
texld r2, r2, s0
texld r8, t4, s0
texld r3, r3, s0
mul r4, r4, c1.x
mad_pp r4, r5, c1.y, r4
mad_pp r0, r0, c1.x, r4
mad_pp r0, r6, c1.z, r0
mad_pp r0, r1, c1.z, r0
mad_pp r0, r7, c1.w, r0
mad_pp r0, r2, c1.w, r0
mad_pp r0, r8, c0.x, r0
mad_pp r0, r3, c0.x, r0
mov_pp oC0, r0

"
}
}
 }
}
Fallback Off
}
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/CubeBlur" {
Properties {
 _MainTex ("Main", CUBE) = "" { }
 _Texel ("Texel", Float) = 0.0078125
 _Level ("Level", Float) = 0
 _Scale ("Scale", Float) = 1
}
SubShader { 
 LOD 200
 Tags { "RenderType"="Opaque" }
 Pass {
  Tags { "RenderType"="Opaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 13554
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
Float 1 [_Level]
Float 2 [_Scale]
Float 0 [_Texel]
SetTexture 0 [_MainTex] CUBE 0
"ps_3_0
def c3, 1, 0, 3, 5
def c4, -1, 0, 1, 1.44269502
def c5, 1.5, 2.5, 0.5, 2
dcl_texcoord_pp v0.xyz
dcl_cube s0
mov r0, c3
mad_pp r0.xyz, c2.x, r0.xyyw, r0.yzww
add r1.xyz, c4.x, v0_abs
cmp_pp r1.xyz, -r1_abs, v0, c4.y
add_pp r2.xyz, -r1_abs, c4.z
mul_pp r2.xyz, r2, v0
dp3_pp r0.w, r2, r2
add_pp r0.w, r0.w, c4.z
rsq_pp r0.w, r0.w
mul_pp r1.w, r0.w, r0.w
mul_pp r2.x, r0.w, r1.w
mul_pp r2.yz, r2.x, c2.x
mul_pp r0.xyz, r0, r2
mul_pp r0.xyz, r0, -r0
mul_pp r0.xyz, r0, c4.w
exp_pp r2.x, r0.x
exp_pp r2.y, r0.y
exp_pp r2.z, r0.z
mul_pp r0.xyz, r2.z, r2
mov_pp r3.w, c1.x
mul_pp r4.xyz, r1.zxyw, c0.x
mad_pp r5.xyz, r4, -c5.x, v0
mad_pp r6.xyz, r4.zxyw, -c5.y, r5
max_pp r7.xyz, r6, c4.x
min_pp r8.xyz, r7, c4.z
add_pp r6.xyz, r6, -r8
max_pp r0.w, r6_abs.x, r6_abs.y
max_pp r1.w, r0.w, r6_abs.z
mad_pp r3.xyz, r1.w, -r1, r8
texldl_pp r3, r3, s0
max_pp r6, r3, c4.y
mov_pp r3.w, c1.x
mad_pp r7.xyz, r4, c5.x, v0
mad_pp r8.xyz, r4.zxyw, -c5.y, r7
max_pp r9.xyz, r8, c4.x
min_pp r10.xyz, r9, c4.z
add_pp r8.xyz, r8, -r10
max_pp r0.w, r8_abs.x, r8_abs.y
max_pp r1.w, r0.w, r8_abs.z
mad_pp r3.xyz, r1.w, -r1, r10
texldl r3, r3, s0
max r8, r3, c4.y
add_pp r3, r6, r8
mul_pp r3, r0.y, r3
mov_pp r6.w, c1.x
mad_pp r8.xyz, r4.zxyw, -c5.y, v0
max_pp r9.xyz, r8, c4.x
min_pp r10.xyz, r9, c4.z
add_pp r8.xyz, r8, -r10
max_pp r0.w, r8_abs.x, r8_abs.y
max_pp r1.w, r0.w, r8_abs.z
mad_pp r8.xyz, r1.w, -r1, r10
mad_pp r6.xyz, r4, -c5.z, r8
mad_pp r8.xyz, r4, c5.z, r8
texldl_pp r6, r6, s0
max_pp r9, r6, c4.y
mov_pp r8.w, c1.x
texldl r6, r8, s0
max r8, r6, c4.y
add_pp r6, r8, r9
mad_pp r3, r0.x, r6, r3
mov_pp r6.w, c1.x
mad_pp r8.xyz, r4, -c5.y, v0
mad_pp r9.xyz, r4.zxyw, -c5.y, r8
max_pp r10.xyz, r9, c4.x
min_pp r11.xyz, r10, c4.z
add_pp r9.xyz, r9, -r11
max_pp r0.w, r9_abs.x, r9_abs.y
max_pp r1.w, r0.w, r9_abs.z
mad_pp r6.xyz, r1.w, -r1, r11
texldl_pp r6, r6, s0
max_pp r9, r6, c4.y
mov_pp r6.w, c1.x
mad_pp r10.xyz, r4, c5.y, v0
mad_pp r11.xyz, r4.zxyw, -c5.y, r10
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r0.w, r11_abs.x, r11_abs.y
max_pp r1.w, r0.w, r11_abs.z
mad_pp r6.xyz, r1.w, -r1, r13
texldl r6, r6, s0
max r11, r6, c4.y
add_pp r6, r9, r11
mad_pp r3, r0.z, r6, r3
mul_pp r6.xyz, r2.y, r2
mul_pp r2.xyz, r2.x, r2
mov_pp r9.w, c1.x
mad_pp r11.xyz, r4.zxyw, -c5.x, r10
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r0.w, r11_abs.x, r11_abs.y
max_pp r1.w, r0.w, r11_abs.z
mad_pp r9.xyz, r1.w, -r1, r13
texldl_pp r9, r9, s0
max_pp r11, r9, c4.y
mov_pp r9.w, c1.x
mad_pp r12.xyz, r4.zxyw, -c5.x, r8
max_pp r13.xyz, r12, c4.x
min_pp r14.xyz, r13, c4.z
add_pp r12.xyz, r12, -r14
max_pp r0.w, r12_abs.x, r12_abs.y
max_pp r1.w, r0.w, r12_abs.z
mad_pp r9.xyz, r1.w, -r1, r14
texldl r9, r9, s0
max r12, r9, c4.y
add_pp r9, r11, r12
mad_pp r3, r6.z, r9, r3
mov_pp r9.w, c1.x
mad_pp r11.xyz, r4.zxyw, -c5.x, r7
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r0.w, r11_abs.x, r11_abs.y
max_pp r1.w, r0.w, r11_abs.z
mad_pp r9.xyz, r1.w, -r1, r13
texldl_pp r9, r9, s0
max_pp r11, r9, c4.y
mov_pp r9.w, c1.x
mad_pp r12.xyz, r4.zxyw, -c5.x, r5
max_pp r13.xyz, r12, c4.x
min_pp r14.xyz, r13, c4.z
add_pp r12.xyz, r12, -r14
max_pp r0.w, r12_abs.x, r12_abs.y
max_pp r1.w, r0.w, r12_abs.z
mad_pp r9.xyz, r1.w, -r1, r14
texldl r9, r9, s0
max r12, r9, c4.y
add_pp r9, r11, r12
mul_pp r9, r6.y, r9
mov_pp r11.w, c1.x
mad_pp r12.xyz, r4.zxyw, -c5.x, v0
max_pp r13.xyz, r12, c4.x
min_pp r14.xyz, r13, c4.z
add_pp r12.xyz, r12, -r14
max_pp r0.w, r12_abs.x, r12_abs.y
max_pp r1.w, r0.w, r12_abs.z
mad_pp r12.xyz, r1.w, -r1, r14
mad_pp r11.xyz, r4, c5.z, r12
mad_pp r12.xyz, r4, -c5.z, r12
texldl_pp r11, r11, s0
max_pp r13, r11, c4.y
mov_pp r12.w, c1.x
texldl r11, r12, s0
max r12, r11, c4.y
add_pp r11, r12, r13
mad_pp r9, r6.x, r11, r9
add_pp r3, r3, r9
mov_pp r9.w, c1.x
max_pp r11.xyz, r8, c4.x
min_pp r12.xyz, r11, c4.z
add_pp r11.xyz, r8, -r12
max_pp r0.w, r11_abs.x, r11_abs.y
max_pp r1.w, r0.w, r11_abs.z
mad_pp r11.xyz, r1.w, -r1, r12
mad_pp r9.xyz, r4.zxyw, -c5.z, r11
mad_pp r11.xyz, r4.zxyw, c5.z, r11
texldl_pp r9, r9, s0
max_pp r12, r9, c4.y
mov_pp r9.w, c1.x
max_pp r13.xyz, r10, c4.x
min_pp r14.xyz, r13, c4.z
add_pp r13.xyz, r10, -r14
max_pp r0.w, r13_abs.x, r13_abs.y
max_pp r1.w, r0.w, r13_abs.z
mad_pp r13.xyz, r1.w, -r1, r14
mad_pp r9.xyz, r4.zxyw, -c5.z, r13
mad_pp r13.xyz, r4.zxyw, c5.z, r13
texldl r9, r9, s0
max r14, r9, c4.y
add_pp r9, r12, r14
mad_pp r3, r2.z, r9, r3
mov_pp r9.w, c1.x
max_pp r12.xyz, r5, c4.x
min_pp r14.xyz, r12, c4.z
add_pp r12.xyz, r5, -r14
max_pp r0.w, r12_abs.x, r12_abs.y
max_pp r1.w, r0.w, r12_abs.z
mad_pp r12.xyz, r1.w, -r1, r14
mad_pp r9.xyz, r4.zxyw, -c5.z, r12
mad_pp r12.xyz, r4.zxyw, c5.z, r12
texldl_pp r9, r9, s0
max_pp r14, r9, c4.y
mov_pp r9.w, c1.x
max_pp r15.xyz, r7, c4.x
min_pp r16.xyz, r15, c4.z
add_pp r15.xyz, r7, -r16
max_pp r0.w, r15_abs.x, r15_abs.y
max_pp r1.w, r0.w, r15_abs.z
mad_pp r15.xyz, r1.w, -r1, r16
mad_pp r9.xyz, r4.zxyw, -c5.z, r15
mad_pp r15.xyz, r4.zxyw, c5.z, r15
texldl r9, r9, s0
max r16, r9, c4.y
add_pp r9, r14, r16
mul_pp r9, r2.y, r9
mov_pp r14.w, c1.x
mad_pp r16.xyz, r4, -c5.z, v0
mad_pp r14.xyz, r4.zxyw, -c5.z, r16
mad_pp r16.xyz, r4.zxyw, c5.z, r16
texldl_pp r14, r14, s0
max_pp r17, r14, c4.y
mov_pp r14.w, c1.x
mad_pp r18.xyz, r4, c5.z, v0
mad_pp r14.xyz, r4.zxyw, -c5.z, r18
mad_pp r18.xyz, r4.zxyw, c5.z, r18
texldl r14, r14, s0
max r19, r14, c4.y
add_pp r14, r17, r19
mad_pp r9, r2.x, r14, r9
add_pp r3, r3, r9
mov_pp r13.w, c1.x
texldl_pp r9, r13, s0
max_pp r13, r9, c4.y
mov_pp r11.w, c1.x
texldl r9, r11, s0
max r11, r9, c4.y
add_pp r9, r11, r13
mad_pp r3, r2.z, r9, r3
mov_pp r15.w, c1.x
texldl_pp r9, r15, s0
max_pp r11, r9, c4.y
mov_pp r12.w, c1.x
texldl r9, r12, s0
max r12, r9, c4.y
add_pp r9, r11, r12
mul_pp r9, r2.y, r9
mov_pp r18.w, c1.x
texldl_pp r11, r18, s0
max_pp r12, r11, c4.y
mov_pp r16.w, c1.x
texldl r11, r16, s0
max r13, r11, c4.y
add_pp r11, r12, r13
mad_pp r9, r2.x, r11, r9
dp3_pp r0.w, r2, c5.w
add_pp r2, r3, r9
mov_pp r3.w, c1.x
mad_pp r9.xyz, r4.zxyw, c5.x, r8
mad_pp r8.xyz, r4.zxyw, c5.y, r8
max_pp r11.xyz, r9, c4.x
min_pp r12.xyz, r11, c4.z
add_pp r9.xyz, r9, -r12
max_pp r1.w, r9_abs.x, r9_abs.y
max_pp r4.w, r1.w, r9_abs.z
mad_pp r3.xyz, r4.w, -r1, r12
texldl_pp r3, r3, s0
max_pp r9, r3, c4.y
mov_pp r3.w, c1.x
mad_pp r11.xyz, r4.zxyw, c5.x, r10
mad_pp r10.xyz, r4.zxyw, c5.y, r10
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r1.w, r11_abs.x, r11_abs.y
max_pp r4.w, r1.w, r11_abs.z
mad_pp r3.xyz, r4.w, -r1, r13
texldl r3, r3, s0
max r11, r3, c4.y
add_pp r3, r9, r11
mad_pp r2, r6.z, r3, r2
mov_pp r3.w, c1.x
mad_pp r9.xyz, r4.zxyw, c5.x, r5
mad_pp r5.xyz, r4.zxyw, c5.y, r5
max_pp r11.xyz, r9, c4.x
min_pp r12.xyz, r11, c4.z
add_pp r9.xyz, r9, -r12
max_pp r1.w, r9_abs.x, r9_abs.y
max_pp r4.w, r1.w, r9_abs.z
mad_pp r3.xyz, r4.w, -r1, r12
texldl_pp r3, r3, s0
max_pp r9, r3, c4.y
mov_pp r3.w, c1.x
mad_pp r11.xyz, r4.zxyw, c5.x, r7
mad_pp r7.xyz, r4.zxyw, c5.y, r7
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r1.w, r11_abs.x, r11_abs.y
max_pp r4.w, r1.w, r11_abs.z
mad_pp r3.xyz, r4.w, -r1, r13
texldl r3, r3, s0
max r11, r3, c4.y
add_pp r3, r9, r11
mul_pp r3, r3, r6.y
mov_pp r9.w, c1.x
mad_pp r11.xyz, r4.zxyw, c5.x, v0
max_pp r12.xyz, r11, c4.x
min_pp r13.xyz, r12, c4.z
add_pp r11.xyz, r11, -r13
max_pp r1.w, r11_abs.x, r11_abs.y
max_pp r4.w, r1.w, r11_abs.z
mad_pp r11.xyz, r4.w, -r1, r13
mad_pp r9.xyz, r4, -c5.z, r11
mad_pp r11.xyz, r4, c5.z, r11
texldl_pp r9, r9, s0
max_pp r12, r9, c4.y
mov_pp r11.w, c1.x
texldl r9, r11, s0
max r11, r9, c4.y
add_pp r9, r11, r12
mad_pp r3, r6.x, r9, r3
dp3_pp r1.w, r6, c5.w
add_pp r2, r2, r3
max_pp r3.xyz, r10, c4.x
min_pp r6.xyz, r3, c4.z
add_pp r3.xyz, -r6, r10
max_pp r4.w, r3_abs.x, r3_abs.y
max_pp r5.w, r4.w, r3_abs.z
mad_pp r3.xyz, r5.w, -r1, r6
mov_pp r3.w, c1.x
texldl_pp r3, r3, s0
max_pp r6, r3, c4.y
max_pp r3.xyz, r8, c4.x
min_pp r9.xyz, r3, c4.z
add_pp r3.xyz, r8, -r9
max_pp r4.w, r3_abs.x, r3_abs.y
max_pp r5.w, r4.w, r3_abs.z
mad_pp r3.xyz, r5.w, -r1, r9
mov_pp r3.w, c1.x
texldl r3, r3, s0
max r8, r3, c4.y
add_pp r3, r6, r8
mad_pp r2, r0.z, r3, r2
mad_pp r3.xyz, r4.zxyw, c5.y, v0
max_pp r6.xyz, r3, c4.x
min_pp r8.xyz, r6, c4.z
add_pp r3.xyz, r3, -r8
max_pp r4.w, r3_abs.x, r3_abs.y
max_pp r5.w, r4.w, r3_abs.z
mad_pp r3.xyz, r5.w, -r1, r8
mad_pp r6.xyz, r4, c5.z, r3
mad_pp r3.xyz, r4, -c5.z, r3
mov_pp r6.w, c1.x
texldl_pp r4, r6, s0
max_pp r6, r4, c4.y
mov_pp r3.w, c1.x
texldl r3, r3, s0
max r4, r3, c4.y
add_pp r3, r4, r6
max_pp r4.xyz, r7, c4.x
min_pp r6.xyz, r4, c4.z
add_pp r4.xyz, -r6, r7
max_pp r5.w, r4_abs.x, r4_abs.y
max_pp r6.w, r5.w, r4_abs.z
mad_pp r4.xyz, r6.w, -r1, r6
mov_pp r4.w, c1.x
texldl_pp r4, r4, s0
max_pp r6, r4, c4.y
max_pp r4.xyz, r5, c4.x
min_pp r7.xyz, r4, c4.z
add_pp r4.xyz, r5, -r7
max_pp r5.x, r4_abs.x, r4_abs.y
max_pp r7.w, r5.x, r4_abs.z
mad_pp r4.xyz, r7.w, -r1, r7
mov_pp r4.w, c1.x
texldl r4, r4, s0
max r5, r4, c4.y
add_pp r4, r5, r6
mul_pp r4, r0.y, r4
mad_pp r3, r0.x, r3, r4
dp3_pp r0.x, r0, c5.w
add_pp r2, r2, r3
add_pp r0.y, r1.w, r0.x
mad_pp r0.y, r0.w, c5.w, r0.y
add_pp r0.y, r1.w, r0.y
add_pp r0.x, r0.x, r0.y
rcp r0.x, r0.x
mul_pp oC0, r0.x, r2

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
  GpuProgramID 85008
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
texldb_pp r0, r0, s0
mov_pp oC0, r0

"
}
}
 }
}
}
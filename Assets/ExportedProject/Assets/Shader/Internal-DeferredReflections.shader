//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Internal-DeferredReflections" {
Properties {
 _SrcBlend ("", Float) = 1
 _DstBlend ("", Float) = 1
}
SubShader { 
 Pass {
  ZWrite Off
  Blend [_SrcBlend] [_DstBlend]
  GpuProgramID 34194
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "normal" Normal
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Float 9 [_LightAsQuad]
Vector 7 [_ProjectionParams]
Vector 8 [_ScreenParams]
"vs_3_0
def c10, 0.5, -1, 1, 0
dcl_position v0
dcl_normal v1
dcl_position o0
dcl_texcoord o1
dcl_texcoord1 o2.xyz
dp4 r0.y, c1, v0
mul r1.x, r0.y, c7.x
mul r1.w, r1.x, c10.x
dp4 r0.x, c0, v0
dp4 r0.w, c3, v0
mul r1.xz, r0.xyww, c10.x
mad o1.xy, r1.z, c8.zwzw, r1.xwzw
dp4 r1.x, c4, v0
dp4 r1.y, c5, v0
dp4 r1.z, c6, v0
mul r2.xyz, r1, c10.yyzw
mad r1.xyz, r1, -c10.yyzw, v1
mad o2.xyz, c9.x, r1, r2
dp4 r0.z, c2, v0
mov o0, r0
mov o1.zw, r0

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Matrix 0 [_CameraToWorld] 3
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 6 [unity_SpecCube0_BoxMax]
Vector 7 [unity_SpecCube0_BoxMin]
Vector 9 [unity_SpecCube0_HDR]
Vector 8 [unity_SpecCube0_ProbePosition]
Vector 10 [unity_SpecCube1_ProbePosition]
SetTexture 0 [unity_SpecCube0] CUBE 0
SetTexture 1 [_CameraDepthTexture] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c11, 0.5, 0.75, 7, 0
def c12, 1, 2, -1, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_cube s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s1
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c12.x
dp4_pp r2.x, c0, r0
dp4_pp r2.y, c1, r0
dp4_pp r2.z, c2, r0
texld_pp r0, r1, s2
texld_pp r3, r1, s3
texld_pp r1, r1, s4
mad_pp r0.xyz, r1, c12.y, c12.z
nrm_pp r1.xyz, r0
add r0.xyz, r2, -c3
nrm_pp r4.xyz, r0
max_pp r0.x, r3.x, r3.y
max_pp r1.w, r0.x, r3.z
add_pp r0.x, -r1.w, c12.x
dp3 r0.y, r4, r1
add r0.y, r0.y, r0.y
mad_pp r5.xyz, r1, -r0.y, r4
mov r1.w, c12.w
if_lt -c8.w, r1.w
mov r1.w, c10.w
add r6.xyz, -r1.w, c7
add r7.xyz, r1.w, c6
nrm_pp r8.xyz, r5
add r9.xyz, -r2, r7
rcp r10.x, r8.x
rcp r10.y, r8.y
rcp r10.z, r8.z
mul_pp r9.xyz, r9, r10
add r11.xyz, -r2, r6
mul_pp r10.xyz, r10, r11
cmp_pp r9.xyz, -r8, r10, r9
min_pp r0.y, r9.y, r9.x
min_pp r1.w, r9.z, r0.y
add r6.xyz, r6, r7
mov r7.x, c11.x
mad r7.xyz, r6, r7.x, -c8
add r7.xyz, r2, r7
mad r7.xyz, r8, r1.w, r7
mad_pp r5.xyz, r6, -c11.x, r7
endif
add_pp r0.y, -r3.w, c12.x
pow_pp r1.w, r0.y, c11.y
mul_pp r5.w, r1.w, c11.z
texldl_pp r5, r5, s0
pow_pp r0.y, r5.w, c9.y
mul_pp r0.y, r0.y, c9.x
mul_pp r5.xyz, r5, r0.y
mul_pp r0.yzw, r0.w, r5.xxyz
dp3_pp r1.x, r1, -r4
add_pp r0.x, -r0.x, r3.w
add_sat_pp r0.x, r0.x, c12.x
add_pp r1.y, -r1.x, c12.x
cmp_pp r1.x, r1.x, r1.y, c12.x
mul_pp r1.y, r1.x, r1.x
mul_pp r1.y, r1.y, r1.y
mul_pp r1.x, r1.x, r1.y
lrp_pp r4.xyz, r1.x, r0.x, r3
mul_pp oC0.xyz, r0.yzww, r4
add_pp r0.xyz, r2, -c6
add_pp r1.xyz, -r2, c7
max_pp r2.xyz, r0, r1
max_pp r0.xyz, r2, c12.w
dp3_pp r0.x, r0, r0
rsq_pp r0.x, r0.x
rcp r0.x, r0.x
rcp r0.y, c10.w
mad_sat_pp oC0.w, r0.x, -r0.y, c12.x

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Blend [_SrcBlend] [_DstBlend]
  GpuProgramID 127983
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ProjectionParams]
Vector 5 [_ScreenParams]
"vs_3_0
def c6, 0.5, 0, 0, 0
dcl_position v0
dcl_texcoord o0.xy
dcl_position o1
dp4 o1.z, c2, v0
dp4 r0.y, c1, v0
mul r0.z, r0.y, c4.x
dp4 r0.x, c0, v0
dp4 r0.w, c3, v0
mul r1.xzw, r0.xywz, c6.x
mov o1.xyw, r0
mad o0.xy, r1.z, c5.zwzw, r1.xwzw

"
}
SubProgram "d3d9 " {
Keywords { "UNITY_HDR_ON" }
Bind "vertex" Vertex
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_ProjectionParams]
Vector 5 [_ScreenParams]
"vs_3_0
def c6, 0.5, 0, 0, 0
dcl_position v0
dcl_texcoord o0.xy
dcl_position o1
dp4 o1.z, c2, v0
dp4 r0.y, c1, v0
mul r0.z, r0.y, c4.x
dp4 r0.x, c0, v0
dp4 r0.w, c3, v0
mul r1.xzw, r0.xywz, c6.x
mov o1.xyw, r0
mad o0.xy, r1.z, c5.zwzw, r1.xwzw

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_CameraReflectionsTexture] 2D 0
"ps_3_0
def c0, 0, 0, 0, 0
dcl_texcoord v0.xy
dcl_2d s0
texld_pp r0, v0, s0
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c0.x

"
}
SubProgram "d3d9 " {
Keywords { "UNITY_HDR_ON" }
SetTexture 0 [_CameraReflectionsTexture] 2D 0
"ps_3_0
def c0, 0, 0, 0, 0
dcl_texcoord v0.xy
dcl_2d s0
texld_pp r0, v0, s0
mov_pp oC0.xyz, r0
mov_pp oC0.w, c0.x

"
}
}
 }
}
Fallback Off
}
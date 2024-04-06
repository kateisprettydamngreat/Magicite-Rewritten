//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Internal-PrePassLighting" {
Properties {
 _LightTexture0 ("", any) = "" { }
 _LightTextureB0 ("", 2D) = "" { }
 _ShadowMapTexture ("", any) = "" { }
}
SubShader { 
 Pass {
  Tags { "SHADOWSUPPORT"="true" }
  ZWrite Off
  Blend DstColor Zero
  GpuProgramID 57115
Program "vp" {
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
Keywords { "POINT" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c9
mul_pp r0.xyw, r0.xyzz, c7.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c7.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c7.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s2
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c11.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c8.xyzz
add r4.xyz, r4, -c6
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c6.w, r0.z, r3.z
mad r0.z, r0.z, c10.z, c10.w
add_sat r0.z, -r0.z, c11.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c8.w
texld r4, r0.w, s1
mul_pp r3.xyz, r2.x, r3.xyww
mad r2.xyz, r2.yzww, -r0.y, -r3
nrm_pp r5.xyz, r2
mad_pp r1.xyz, r1, c11.y, c11.z
mul_pp r0.y, r1.w, c12.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -r3, r2
max_pp r1.y, r0.w, c11.w
pow r2.x, r1.y, r0.y
mov_sat r0.y, r4.x
mul r0.w, r4.x, r1.x
mul_pp r1.yzw, r0.w, c9.xxyz
cmp_pp r1.xyz, r1.x, r1.yzww, c11.w
mul r0.y, r0.y, r2.x
mul_pp r1.w, r0.x, r0.y
mul_pp r0, r0.z, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
texld_pp r1, r1, s1
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c11.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c6.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c6.w, r0.x, r2.z
mad r0.x, r0.x, c10.z, c10.w
add_sat r0.x, -r0.x, c11.x
dp3 r0.y, r3, r3
rsq r0.y, r0.y
mad r0.yzw, r3.xxyz, -r0.y, -c8.xxyz
nrm_pp r2.xyz, r0.yzww
mad_pp r0.yzw, r1.xxyz, c11.y, c11.z
mul_pp r1.x, r1.w, c12.x
nrm_pp r3.xyz, r0.yzww
dp3_pp r0.y, r2, r3
dp3_pp r0.z, -c8, r3
max_pp r1.y, r0.y, c11.w
pow r0.y, r1.y, r1.x
mov r1.xyz, c9
mul_pp r1.xyw, r1.xyzz, c7.xyzz
add_pp r1.xw, r1.yyzw, r1.x
mul_pp r0.w, r1.w, r1.y
mad_pp r1.x, r1.z, c7.z, r1.x
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.w, c7.w, r0.w, r1.x
mul_pp r1.w, r0.w, r0.y
mul_pp r2.xyz, r0.z, c9
cmp_pp r1.xyz, r0.z, r2, c11.w
mul_pp r0, r0.x, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
Matrix 4 [_CameraToWorld] 3
Matrix 0 [_LightMatrix0]
Vector 13 [_LightColor]
Vector 12 [_LightPos]
Vector 8 [_ProjectionParams]
Vector 7 [_WorldSpaceCameraPos]
Vector 9 [_ZBufferParams]
Vector 11 [unity_ColorSpaceLuminance]
Vector 14 [unity_LightmapFade]
Vector 10 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c15, 1, 0, 2, -1
def c16, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
mov r0.xyz, c13
mul_pp r0.xyw, r0.xyzz, c11.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c11.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c11.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c8.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c9.x, r2.x, c9.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c15.x
dp4 r4.x, c4, r3
dp4 r4.y, c5, r3
dp4 r4.z, c6, r3
mov r4.w, c15.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp r6, r5, s2
add r2.yzw, -r4.xxyz, c12.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c12.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r7, r0.z, s1
mul r0.y, r6.w, r7.x
cmp r0.y, r5.w, c15.y, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c7.xyzz
add r4.xyz, r4, -c10
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c10.w, r0.w, r3.z
mad r0.w, r0.w, c14.z, c14.w
add_sat r0.w, -r0.w, c15.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c15.z, c15.w
mul_pp r1.w, r1.w, c16.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2.yzww, r3
max_pp r2.x, r1.y, c15.y
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c13
max_pp r0.y, r1.x, c15.y
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.w, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c12
mul_pp r0.xyw, r0.xyzz, c10.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c10.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c10.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c14.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c14.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c11.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c11.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r6, r0.z, s1
mul r0.y, r5.w, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c9
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c9.w, r0.w, r3.z
mad r0.w, r0.w, c13.z, c13.w
add_sat r0.w, -r0.w, c14.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c12
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.w, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 11 [_LightColor]
Vector 10 [_LightDir]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c13, 1, 2, -1, 0
def c14, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v0.w
mul r0.yz, r0.y, v0.xxyw
texld_pp r1, r0.yzzw, s2
texld r2, r0.yzzw, s0
mad r0.y, c7.x, r2.x, c7.y
rcp r0.y, r0.y
mul_pp r0.z, r1.w, c14.x
mad_pp r1.xyz, r1, c13.y, c13.z
nrm_pp r2.xyz, r1
rcp r0.w, v1.z
mul r0.w, r0.w, c6.z
mul r1.xyz, r0.w, v1
mul r3.xyz, r0.y, r1
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r1.xyw, r4.xyzz, -c5.xyzz
dp3 r0.w, r1.xyww, r1.xyww
rsq r0.w, r0.w
mad r1.xyw, r1, -r0.w, -c10.xyzz
nrm_pp r5.xyz, r1.xyww
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -c10, r2
max_pp r1.y, r0.w, c13.w
pow r2.x, r1.y, r0.z
mov r4.w, c13.x
dp4 r3.x, c3, r4
dp4 r3.y, c4, r4
add r2.yzw, r4.xxyz, -c8.xxyz
dp3 r0.z, r2.yzww, r2.yzww
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.y, r1.z, -r0.y, r0.z
mad r0.y, c8.w, r0.y, r3.z
mad r0.y, r0.y, c12.z, c12.w
add_sat r0.y, -r0.y, c13.x
texld r3, r3, s1
mov_sat r0.z, r3.w
mul r0.w, r1.x, r3.w
mul_pp r1.yzw, r0.w, c11.xxyz
cmp_pp r1.xyz, r1.x, r1.yzww, c13.w
mul r0.z, r0.z, r2.x
mul_pp r1.w, r0.x, r0.z
mul_pp r0, r0.y, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
Matrix 8 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 18 [_LightColor]
Vector 17 [_LightPos]
Vector 14 [_LightShadowData]
Vector 12 [_ProjectionParams]
Vector 11 [_WorldSpaceCameraPos]
Vector 13 [_ZBufferParams]
Vector 16 [unity_ColorSpaceLuminance]
Vector 19 [unity_LightmapFade]
Vector 15 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c20, 1, 0, 2, -1
def c21, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c20.x
rcp r0.y, v1.z
mul r0.y, r0.y, c12.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c13.x, r2.x, c13.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c20.x
dp4 r4.x, c8, r3
dp4 r4.y, c9, r3
dp4 r4.z, c10, r3
mov r4.w, c20.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp_pp r5, r5, s3
lrp_pp r2.y, r5.x, r0.x, c14.x
add r0.xyz, r4, -c15
dp3 r0.x, r0, r0
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.w, -r2.x, r0.x
mad r0.x, c15.w, r0.x, r3.z
mad_sat r0.y, r0.x, c14.z, c14.w
mad r0.x, r0.x, c19.z, c19.w
add_sat r0.x, -r0.x, c20.x
add_sat_pp r0.y, r0.y, r2.y
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c17
add r3.xyz, r4, -c11
dp3 r0.z, r2, r2
mul r0.w, r0.z, c17.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.y, r0.y, r0.z
cmp r0.y, r2.w, c20.y, r0.y
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c20.z, c20.w
mul_pp r0.w, r1.w, c21.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c20.y
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c18
max_pp r0.y, r1.x, c20.y
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c18
mul_pp r1.xyw, r1.xyzz, c16.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c16.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c16.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.y
mul_pp r0, r0.x, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Vector 10 [_LightColor]
Vector 9 [_LightDir]
Vector 6 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_ColorSpaceLuminance]
Vector 11 [unity_LightmapFade]
Vector 7 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c12, 1, 2, -1, 0
def c13, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c12.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c7.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c7.w, r0.x, r2.z
mad_sat r0.y, r0.x, c6.z, c6.w
mad r0.x, r0.x, c11.z, c11.w
add_sat r0.x, -r0.x, c12.x
texld r2, r1, s1
texld_pp r1, r1, s2
add_sat_pp r0.y, r0.y, r2.x
dp3 r0.z, r3, r3
rsq r0.z, r0.z
mad r2.xyz, r3, -r0.z, -c9
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c12.y, c12.z
mul_pp r0.z, r1.w, c13.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r3, r2
dp3_pp r1.x, -c9, r2
max_pp r2.x, r1.x, c12.w
mul r1.x, r0.y, r2.x
mul_pp r1.xyz, r1.x, c10
max_pp r2.x, r0.w, c12.w
pow r3.x, r2.x, r0.z
mul r0.y, r0.y, r3.x
mov r2.xyz, c10
mul_pp r2.xyw, r2.xyzz, c8.xyzz
add_pp r0.zw, r2.xyyw, r2.x
mul_pp r0.w, r0.w, r2.y
mad_pp r0.z, r2.z, c8.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c8.w, r0.w, r0.z
mul_pp r1.w, r0.z, r0.y
mul_pp r0, r0.x, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 12 [_LightColor]
Vector 11 [_LightDir]
Vector 8 [_LightShadowData]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_ShadowMapTexture] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c14.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c9.xyzz
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c9.w, r0.x, r2.z
mad_sat r0.y, r0.x, c8.z, c8.w
mad r0.x, r0.x, c13.z, c13.w
add_sat r0.x, -r0.x, c14.x
texld r2, r1, s2
texld_pp r1, r1, s3
add_sat_pp r0.y, r0.y, r2.x
mov r3.w, c14.x
dp4 r2.x, c3, r3
dp4 r2.y, c4, r3
add r3.xyz, r3, -c5
texld r2, r2, s1
mul r0.y, r0.y, r2.w
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r2.xyz, r3, -r0.w, -c11
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r0.w, r1.w, c15.x
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -c11, r2
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c12
max_pp r0.y, r1.x, c14.w
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c12
mul_pp r1.xyw, r1.xyzz, c10.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c10.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c10.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.y
mul_pp r0, r0.x, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.970000029, 2, -1
def c14, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c10.xyzz
add r4.xyz, r4, -c8
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c8.w, r0.z, r3.z
mad r0.z, r0.z, c12.z, c12.w
add_sat r0.z, -r0.z, c13.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c10.w
texld r4, r0.w, s1
mul_pp r4.yzw, r2.x, r3.xxyw
texld r3, r3.xyww, s2
rcp r0.w, r2.x
mul r0.w, r0.w, c6.w
mad r0.w, r0.w, -c13.y, r3.x
mov r2.x, c13.x
cmp_pp r0.w, r0.w, r2.x, c7.x
mul r0.w, r0.w, r4.x
mad r2.xyz, r2.yzww, -r0.y, -r4.yzww
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c13.z, c13.w
mul_pp r0.y, r1.w, c14.y
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -r4.yzww, r2
max_pp r2.x, r1.y, c14.x
mul r1.y, r0.w, r2.x
mov_sat r0.w, r0.w
mul_pp r2.xyz, r1.y, c11
max_pp r3.x, r1.x, c14.x
pow r1.x, r3.x, r0.y
mul r0.y, r0.w, r1.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.z, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.970000029, 2, -1
def c17, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c13.xxyz
texld r6, r2.yzww, s3
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r7, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r0.y, r0.y, -c16.y, r6.x
mov r3.x, c16.x
cmp_pp r0.y, r0.y, r3.x, c10.x
mul r0.y, r0.y, r7.x
mul r0.y, r5.w, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c16.z, c16.w
mul_pp r1.w, r1.w, c17.y
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.x
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c14
max_pp r0.y, r1.x, c17.x
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.w, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
Matrix 12 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 22 [_LightColor]
Vector 21 [_LightPos]
Vector 18 [_LightShadowData]
Vector 16 [_ProjectionParams]
Vector 8 [_ShadowOffsets0]
Vector 9 [_ShadowOffsets1]
Vector 10 [_ShadowOffsets2]
Vector 11 [_ShadowOffsets3]
Vector 15 [_WorldSpaceCameraPos]
Vector 17 [_ZBufferParams]
Vector 20 [unity_ColorSpaceLuminance]
Vector 23 [unity_LightmapFade]
Vector 19 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c24, 1, 0.25, 0, -2
def c25, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c24.x
rcp r0.y, v1.z
mul r0.y, r0.y, c16.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c17.x, r2.x, c17.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c24.x
dp4 r4.x, c12, r3
dp4 r4.y, c13, r3
dp4 r4.z, c14, r3
mov r4.w, c24.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
rcp r0.y, r5.w
mad r6, r5, r0.y, c8
texldp_pp r6, r6, s3
mad r7, r5, r0.y, c9
texldp_pp r7, r7, s3
mov_pp r6.y, r7.x
mad r7, r5, r0.y, c10
mad r5, r5, r0.y, c11
texldp_pp r5, r5, s3
mov_pp r6.w, r5.x
texldp_pp r5, r7, s3
mov_pp r6.z, r5.x
lrp_pp r5, r6, r0.x, c18.x
dp4_pp r0.x, r5, c24.y
add r2.yzw, r4.xxyz, -c19.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
rcp r0.y, r0.y
mad r0.y, r0.w, -r2.x, r0.y
mad r0.y, c19.w, r0.y, r3.z
mad_sat r0.z, r0.y, c18.z, c18.w
mad r0.y, r0.y, c23.z, c23.w
add_sat r0.y, -r0.y, c24.x
add_sat_pp r0.x, r0.z, r0.x
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c21
add r3.xyz, r4, -c15
dp3 r0.z, r2, r2
mul r0.w, r0.z, c21.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.x, r0.x, r0.z
cmp r0.x, r2.w, c24.z, r0.x
mov_sat r0.z, r0.x
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, -c24.w, -c24.x
mul_pp r0.w, r1.w, c25.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c24.z
mul r0.x, r0.x, r2.x
mul_pp r2.xyz, r0.x, c22
max_pp r0.x, r1.x, c24.z
pow r1.x, r0.x, r0.w
mul r0.x, r0.z, r1.x
mov r1.xyz, c22
mul_pp r1.xyw, r1.xyzz, c20.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c20.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c20.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.x
mul_pp r0, r0.y, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.0078125, -0.0078125, 0.970000029
def c14, 0.25, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c10.xxyz
add r3.xyw, r2.yzzw, c13.y
texld r5, r3.xyww, s2
add r3.xyw, r2.yzzw, c13.zzzy
texld r6, r3.xyww, s2
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c13.zyzz
texld r6, r3.xyww, s2
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c13.yzzz
texld r6, r3.xyww, s2
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c10.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c6.w
mad r5, r0.y, -c13.w, r5
mov r3.x, c13.x
cmp_pp r5, r5, r3.x, c7.x
dp4_pp r0.y, r5, c14.x
mul r0.y, r0.y, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c3.xyzz
add r4.xyz, r4, -c8
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c8.w, r0.w, r3.z
mad r0.w, r0.w, c12.z, c12.w
add_sat r0.w, -r0.w, c13.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c11
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.w, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.0078125, -0.0078125, 0.970000029
def c17, 0.25, 2, -1, 0
def c18, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c13.xxyz
add r3.xyw, r2.yzzw, c16.y
texld r5, r3.xyww, s3
add r3.xyw, r2.yzzw, c16.zzzy
texld r6, r3.xyww, s3
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c16.zyzz
texld r6, r3.xyww, s3
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c16.yzzz
texld r6, r3.xyww, s3
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r5, r0.y, -c16.w, r5
mov r3.x, c16.x
cmp_pp r5, r5, r3.x, c10.x
dp4_pp r0.y, r5, c17.x
mul r0.y, r0.y, r6.x
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
mul r0.y, r0.y, r5.w
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c17.y, c17.z
mul_pp r1.w, r1.w, c18.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c14
max_pp r0.y, r1.x, c17.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp r0, r0.w, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
exp_pp oC0.w, -r0.w

"
}
}
 }
 Pass {
  Tags { "SHADOWSUPPORT"="true" }
  ZWrite Off
  Blend One One
  GpuProgramID 113408
Program "vp" {
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
Keywords { "POINT" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c9
mul_pp r0.xyw, r0.xyzz, c7.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c7.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c7.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s2
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c11.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c8.xyzz
add r4.xyz, r4, -c6
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c6.w, r0.z, r3.z
mad r0.z, r0.z, c10.z, c10.w
add_sat r0.z, -r0.z, c11.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c8.w
texld r4, r0.w, s1
mul_pp r3.xyz, r2.x, r3.xyww
mad r2.xyz, r2.yzww, -r0.y, -r3
nrm_pp r5.xyz, r2
mad_pp r1.xyz, r1, c11.y, c11.z
mul_pp r0.y, r1.w, c12.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -r3, r2
max_pp r1.y, r0.w, c11.w
pow r2.x, r1.y, r0.y
mov_sat r0.y, r4.x
mul r0.w, r4.x, r1.x
mul_pp r1.yzw, r0.w, c9.xxyz
cmp_pp r1.xyz, r1.x, r1.yzww, c11.w
mul r0.y, r0.y, r2.x
mul_pp r1.w, r0.x, r0.y
mul_pp oC0, r0.z, r1

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
texld_pp r1, r1, s1
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c11.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c6.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c6.w, r0.x, r2.z
mad r0.x, r0.x, c10.z, c10.w
add_sat r0.x, -r0.x, c11.x
dp3 r0.y, r3, r3
rsq r0.y, r0.y
mad r0.yzw, r3.xxyz, -r0.y, -c8.xxyz
nrm_pp r2.xyz, r0.yzww
mad_pp r0.yzw, r1.xxyz, c11.y, c11.z
mul_pp r1.x, r1.w, c12.x
nrm_pp r3.xyz, r0.yzww
dp3_pp r0.y, r2, r3
dp3_pp r0.z, -c8, r3
max_pp r1.y, r0.y, c11.w
pow r0.y, r1.y, r1.x
mov r1.xyz, c9
mul_pp r1.xyw, r1.xyzz, c7.xyzz
add_pp r1.xw, r1.yyzw, r1.x
mul_pp r0.w, r1.w, r1.y
mad_pp r1.x, r1.z, c7.z, r1.x
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.w, c7.w, r0.w, r1.x
mul_pp r1.w, r0.w, r0.y
mul_pp r2.xyz, r0.z, c9
cmp_pp r1.xyz, r0.z, r2, c11.w
mul_pp oC0, r0.x, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
Matrix 4 [_CameraToWorld] 3
Matrix 0 [_LightMatrix0]
Vector 13 [_LightColor]
Vector 12 [_LightPos]
Vector 8 [_ProjectionParams]
Vector 7 [_WorldSpaceCameraPos]
Vector 9 [_ZBufferParams]
Vector 11 [unity_ColorSpaceLuminance]
Vector 14 [unity_LightmapFade]
Vector 10 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c15, 1, 0, 2, -1
def c16, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
mov r0.xyz, c13
mul_pp r0.xyw, r0.xyzz, c11.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c11.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c11.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c8.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c9.x, r2.x, c9.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c15.x
dp4 r4.x, c4, r3
dp4 r4.y, c5, r3
dp4 r4.z, c6, r3
mov r4.w, c15.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp r6, r5, s2
add r2.yzw, -r4.xxyz, c12.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c12.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r7, r0.z, s1
mul r0.y, r6.w, r7.x
cmp r0.y, r5.w, c15.y, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c7.xyzz
add r4.xyz, r4, -c10
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c10.w, r0.w, r3.z
mad r0.w, r0.w, c14.z, c14.w
add_sat r0.w, -r0.w, c15.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c15.z, c15.w
mul_pp r1.w, r1.w, c16.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2.yzww, r3
max_pp r2.x, r1.y, c15.y
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c13
max_pp r0.y, r1.x, c15.y
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c12
mul_pp r0.xyw, r0.xyzz, c10.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c10.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c10.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c14.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c14.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c11.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c11.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r6, r0.z, s1
mul r0.y, r5.w, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c9
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c9.w, r0.w, r3.z
mad r0.w, r0.w, c13.z, c13.w
add_sat r0.w, -r0.w, c14.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c12
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 11 [_LightColor]
Vector 10 [_LightDir]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c13, 1, 2, -1, 0
def c14, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v0.w
mul r0.yz, r0.y, v0.xxyw
texld_pp r1, r0.yzzw, s2
texld r2, r0.yzzw, s0
mad r0.y, c7.x, r2.x, c7.y
rcp r0.y, r0.y
mul_pp r0.z, r1.w, c14.x
mad_pp r1.xyz, r1, c13.y, c13.z
nrm_pp r2.xyz, r1
rcp r0.w, v1.z
mul r0.w, r0.w, c6.z
mul r1.xyz, r0.w, v1
mul r3.xyz, r0.y, r1
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r1.xyw, r4.xyzz, -c5.xyzz
dp3 r0.w, r1.xyww, r1.xyww
rsq r0.w, r0.w
mad r1.xyw, r1, -r0.w, -c10.xyzz
nrm_pp r5.xyz, r1.xyww
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -c10, r2
max_pp r1.y, r0.w, c13.w
pow r2.x, r1.y, r0.z
mov r4.w, c13.x
dp4 r3.x, c3, r4
dp4 r3.y, c4, r4
add r2.yzw, r4.xxyz, -c8.xxyz
dp3 r0.z, r2.yzww, r2.yzww
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.y, r1.z, -r0.y, r0.z
mad r0.y, c8.w, r0.y, r3.z
mad r0.y, r0.y, c12.z, c12.w
add_sat r0.y, -r0.y, c13.x
texld r3, r3, s1
mov_sat r0.z, r3.w
mul r0.w, r1.x, r3.w
mul_pp r1.yzw, r0.w, c11.xxyz
cmp_pp r1.xyz, r1.x, r1.yzww, c13.w
mul r0.z, r0.z, r2.x
mul_pp r1.w, r0.x, r0.z
mul_pp oC0, r0.y, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
Matrix 8 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 18 [_LightColor]
Vector 17 [_LightPos]
Vector 14 [_LightShadowData]
Vector 12 [_ProjectionParams]
Vector 11 [_WorldSpaceCameraPos]
Vector 13 [_ZBufferParams]
Vector 16 [unity_ColorSpaceLuminance]
Vector 19 [unity_LightmapFade]
Vector 15 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c20, 1, 0, 2, -1
def c21, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c20.x
rcp r0.y, v1.z
mul r0.y, r0.y, c12.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c13.x, r2.x, c13.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c20.x
dp4 r4.x, c8, r3
dp4 r4.y, c9, r3
dp4 r4.z, c10, r3
mov r4.w, c20.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp_pp r5, r5, s3
lrp_pp r2.y, r5.x, r0.x, c14.x
add r0.xyz, r4, -c15
dp3 r0.x, r0, r0
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.w, -r2.x, r0.x
mad r0.x, c15.w, r0.x, r3.z
mad_sat r0.y, r0.x, c14.z, c14.w
mad r0.x, r0.x, c19.z, c19.w
add_sat r0.x, -r0.x, c20.x
add_sat_pp r0.y, r0.y, r2.y
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c17
add r3.xyz, r4, -c11
dp3 r0.z, r2, r2
mul r0.w, r0.z, c17.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.y, r0.y, r0.z
cmp r0.y, r2.w, c20.y, r0.y
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c20.z, c20.w
mul_pp r0.w, r1.w, c21.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c20.y
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c18
max_pp r0.y, r1.x, c20.y
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c18
mul_pp r1.xyw, r1.xyzz, c16.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c16.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c16.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.y
mul_pp oC0, r0.x, r2

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Vector 10 [_LightColor]
Vector 9 [_LightDir]
Vector 6 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_ColorSpaceLuminance]
Vector 11 [unity_LightmapFade]
Vector 7 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c12, 1, 2, -1, 0
def c13, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c12.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c7.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c7.w, r0.x, r2.z
mad_sat r0.y, r0.x, c6.z, c6.w
mad r0.x, r0.x, c11.z, c11.w
add_sat r0.x, -r0.x, c12.x
texld r2, r1, s1
texld_pp r1, r1, s2
add_sat_pp r0.y, r0.y, r2.x
dp3 r0.z, r3, r3
rsq r0.z, r0.z
mad r2.xyz, r3, -r0.z, -c9
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c12.y, c12.z
mul_pp r0.z, r1.w, c13.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r3, r2
dp3_pp r1.x, -c9, r2
max_pp r2.x, r1.x, c12.w
mul r1.x, r0.y, r2.x
mul_pp r1.xyz, r1.x, c10
max_pp r2.x, r0.w, c12.w
pow r3.x, r2.x, r0.z
mul r0.y, r0.y, r3.x
mov r2.xyz, c10
mul_pp r2.xyw, r2.xyzz, c8.xyzz
add_pp r0.zw, r2.xyyw, r2.x
mul_pp r0.w, r0.w, r2.y
mad_pp r0.z, r2.z, c8.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c8.w, r0.w, r0.z
mul_pp r1.w, r0.z, r0.y
mul_pp oC0, r0.x, r1

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 12 [_LightColor]
Vector 11 [_LightDir]
Vector 8 [_LightShadowData]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_ShadowMapTexture] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c14.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c9.xyzz
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c9.w, r0.x, r2.z
mad_sat r0.y, r0.x, c8.z, c8.w
mad r0.x, r0.x, c13.z, c13.w
add_sat r0.x, -r0.x, c14.x
texld r2, r1, s2
texld_pp r1, r1, s3
add_sat_pp r0.y, r0.y, r2.x
mov r3.w, c14.x
dp4 r2.x, c3, r3
dp4 r2.y, c4, r3
add r3.xyz, r3, -c5
texld r2, r2, s1
mul r0.y, r0.y, r2.w
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r2.xyz, r3, -r0.w, -c11
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r0.w, r1.w, c15.x
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -c11, r2
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c12
max_pp r0.y, r1.x, c14.w
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c12
mul_pp r1.xyw, r1.xyzz, c10.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c10.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c10.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.y
mul_pp oC0, r0.x, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.970000029, 2, -1
def c14, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c10.xyzz
add r4.xyz, r4, -c8
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c8.w, r0.z, r3.z
mad r0.z, r0.z, c12.z, c12.w
add_sat r0.z, -r0.z, c13.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c10.w
texld r4, r0.w, s1
mul_pp r4.yzw, r2.x, r3.xxyw
texld r3, r3.xyww, s2
rcp r0.w, r2.x
mul r0.w, r0.w, c6.w
mad r0.w, r0.w, -c13.y, r3.x
mov r2.x, c13.x
cmp_pp r0.w, r0.w, r2.x, c7.x
mul r0.w, r0.w, r4.x
mad r2.xyz, r2.yzww, -r0.y, -r4.yzww
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c13.z, c13.w
mul_pp r0.y, r1.w, c14.y
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -r4.yzww, r2
max_pp r2.x, r1.y, c14.x
mul r1.y, r0.w, r2.x
mov_sat r0.w, r0.w
mul_pp r2.xyz, r1.y, c11
max_pp r3.x, r1.x, c14.x
pow r1.x, r3.x, r0.y
mul r0.y, r0.w, r1.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.z, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.970000029, 2, -1
def c17, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c13.xxyz
texld r6, r2.yzww, s3
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r7, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r0.y, r0.y, -c16.y, r6.x
mov r3.x, c16.x
cmp_pp r0.y, r0.y, r3.x, c10.x
mul r0.y, r0.y, r7.x
mul r0.y, r5.w, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c16.z, c16.w
mul_pp r1.w, r1.w, c17.y
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.x
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c14
max_pp r0.y, r1.x, c17.x
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
Matrix 12 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 22 [_LightColor]
Vector 21 [_LightPos]
Vector 18 [_LightShadowData]
Vector 16 [_ProjectionParams]
Vector 8 [_ShadowOffsets0]
Vector 9 [_ShadowOffsets1]
Vector 10 [_ShadowOffsets2]
Vector 11 [_ShadowOffsets3]
Vector 15 [_WorldSpaceCameraPos]
Vector 17 [_ZBufferParams]
Vector 20 [unity_ColorSpaceLuminance]
Vector 23 [unity_LightmapFade]
Vector 19 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c24, 1, 0.25, 0, -2
def c25, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c24.x
rcp r0.y, v1.z
mul r0.y, r0.y, c16.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c17.x, r2.x, c17.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c24.x
dp4 r4.x, c12, r3
dp4 r4.y, c13, r3
dp4 r4.z, c14, r3
mov r4.w, c24.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
rcp r0.y, r5.w
mad r6, r5, r0.y, c8
texldp_pp r6, r6, s3
mad r7, r5, r0.y, c9
texldp_pp r7, r7, s3
mov_pp r6.y, r7.x
mad r7, r5, r0.y, c10
mad r5, r5, r0.y, c11
texldp_pp r5, r5, s3
mov_pp r6.w, r5.x
texldp_pp r5, r7, s3
mov_pp r6.z, r5.x
lrp_pp r5, r6, r0.x, c18.x
dp4_pp r0.x, r5, c24.y
add r2.yzw, r4.xxyz, -c19.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
rcp r0.y, r0.y
mad r0.y, r0.w, -r2.x, r0.y
mad r0.y, c19.w, r0.y, r3.z
mad_sat r0.z, r0.y, c18.z, c18.w
mad r0.y, r0.y, c23.z, c23.w
add_sat r0.y, -r0.y, c24.x
add_sat_pp r0.x, r0.z, r0.x
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c21
add r3.xyz, r4, -c15
dp3 r0.z, r2, r2
mul r0.w, r0.z, c21.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.x, r0.x, r0.z
cmp r0.x, r2.w, c24.z, r0.x
mov_sat r0.z, r0.x
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, -c24.w, -c24.x
mul_pp r0.w, r1.w, c25.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c24.z
mul r0.x, r0.x, r2.x
mul_pp r2.xyz, r0.x, c22
max_pp r0.x, r1.x, c24.z
pow r1.x, r0.x, r0.w
mul r0.x, r0.z, r1.x
mov r1.xyz, c22
mul_pp r1.xyw, r1.xyzz, c20.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c20.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c20.w, r0.w, r0.z
mul_pp r2.w, r0.z, r0.x
mul_pp oC0, r0.y, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.0078125, -0.0078125, 0.970000029
def c14, 0.25, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c10.xxyz
add r3.xyw, r2.yzzw, c13.y
texld r5, r3.xyww, s2
add r3.xyw, r2.yzzw, c13.zzzy
texld r6, r3.xyww, s2
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c13.zyzz
texld r6, r3.xyww, s2
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c13.yzzz
texld r6, r3.xyww, s2
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c10.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c6.w
mad r5, r0.y, -c13.w, r5
mov r3.x, c13.x
cmp_pp r5, r5, r3.x, c7.x
dp4_pp r0.y, r5, c14.x
mul r0.y, r0.y, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c3.xyzz
add r4.xyz, r4, -c8
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c8.w, r0.w, r3.z
mad r0.w, r0.w, c12.z, c12.w
add_sat r0.w, -r0.w, c13.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c11
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.0078125, -0.0078125, 0.970000029
def c17, 0.25, 2, -1, 0
def c18, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c13.xxyz
add r3.xyw, r2.yzzw, c16.y
texld r5, r3.xyww, s3
add r3.xyw, r2.yzzw, c16.zzzy
texld r6, r3.xyww, s3
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c16.zyzz
texld r6, r3.xyww, s3
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c16.yzzz
texld r6, r3.xyww, s3
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r5, r0.y, -c16.w, r5
mov r3.x, c16.x
cmp_pp r5, r5, r3.x, c10.x
dp4_pp r0.y, r5, c17.x
mul r0.y, r0.y, r6.x
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
mul r0.y, r0.y, r5.w
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c17.y, c17.z
mul_pp r1.w, r1.w, c18.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.w
mul r0.y, r0.y, r2.x
mul_pp r2.xyz, r0.y, c14
max_pp r0.y, r1.x, c17.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.w, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
}
 }
 Pass {
  Tags { "SHADOWSUPPORT"="true" }
  ZWrite Off
  Blend One One
  GpuProgramID 155461
Program "vp" {
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
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
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
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
Keywords { "POINT" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c9
mul_pp r0.xyw, r0.xyzz, c7.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c7.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c7.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s2
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c11.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c8.xyzz
add r4.xyz, r4, -c6
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c6.w, r0.z, r3.z
mad r0.z, r0.z, c10.z, c10.w
add_sat r0.z, -r0.z, c11.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c8.w
texld r4, r0.w, s1
mul_pp r3.xyz, r2.x, r3.xyww
mad r2.xyz, r2.yzww, -r0.y, -r3
nrm_pp r5.xyz, r2
mad_pp r1.xyz, r1, c11.y, c11.z
mul_pp r0.y, r1.w, c12.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -r3, r2
max_pp r1.y, r0.w, c11.w
pow r2.x, r1.y, r0.y
mov_sat r0.y, r4.x
mul r0.w, r4.x, r1.x
mul_pp r1.yzw, r0.w, c9.xxyz
cmp_pp r1.yzw, r1.x, r1, c11.w
mul r0.y, r0.y, r2.x
mul_pp r1.x, r0.x, r0.y
mul_pp oC0, r0.z, r1

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 7 [unity_ColorSpaceLuminance]
Vector 10 [unity_LightmapFade]
Vector 6 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
texld_pp r1, r1, s1
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c11.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c6.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c6.w, r0.x, r2.z
mad r0.x, r0.x, c10.z, c10.w
add_sat r0.x, -r0.x, c11.x
dp3 r0.y, r3, r3
rsq r0.y, r0.y
mad r0.yzw, r3.xxyz, -r0.y, -c8.xxyz
nrm_pp r2.xyz, r0.yzww
mad_pp r0.yzw, r1.xxyz, c11.y, c11.z
mul_pp r1.x, r1.w, c12.x
nrm_pp r3.xyz, r0.yzww
dp3_pp r0.y, r2, r3
dp3_pp r0.z, -c8, r3
max_pp r1.y, r0.y, c11.w
pow r0.y, r1.y, r1.x
mov r1.xyz, c9
mul_pp r1.xyw, r1.xyzz, c7.xyzz
add_pp r1.xw, r1.yyzw, r1.x
mul_pp r0.w, r1.w, r1.y
mad_pp r1.x, r1.z, c7.z, r1.x
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.w, c7.w, r0.w, r1.x
mul_pp r1.x, r0.w, r0.y
mul_pp r2.xyz, r0.z, c9
cmp_pp r1.yzw, r0.z, r2.xxyz, c11.w
mul_pp oC0, r0.x, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
Matrix 4 [_CameraToWorld] 3
Matrix 0 [_LightMatrix0]
Vector 13 [_LightColor]
Vector 12 [_LightPos]
Vector 8 [_ProjectionParams]
Vector 7 [_WorldSpaceCameraPos]
Vector 9 [_ZBufferParams]
Vector 11 [unity_ColorSpaceLuminance]
Vector 14 [unity_LightmapFade]
Vector 10 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c15, 1, 0, 2, -1
def c16, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
mov r0.xyz, c13
mul_pp r0.xyw, r0.xyzz, c11.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c11.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c11.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c8.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c9.x, r2.x, c9.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c15.x
dp4 r4.x, c4, r3
dp4 r4.y, c5, r3
dp4 r4.z, c6, r3
mov r4.w, c15.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp r6, r5, s2
add r2.yzw, -r4.xxyz, c12.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c12.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r7, r0.z, s1
mul r0.y, r6.w, r7.x
cmp r0.y, r5.w, c15.y, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c7.xyzz
add r4.xyz, r4, -c10
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c10.w, r0.w, r3.z
mad r0.w, r0.w, c14.z, c14.w
add_sat r0.w, -r0.w, c15.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c15.z, c15.w
mul_pp r1.w, r1.w, c16.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2.yzww, r3
max_pp r2.x, r1.y, c15.y
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c13.xxyz
max_pp r0.y, r1.x, c15.y
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c12
mul_pp r0.xyw, r0.xyzz, c10.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c10.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c10.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c14.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c14.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c11.xxyz
dp3 r0.y, r2.yzww, r2.yzww
mul r0.z, r0.y, c11.w
rsq r0.y, r0.y
mul_pp r2.yzw, r0.y, r2
texld r6, r0.z, s1
mul r0.y, r5.w, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c9
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c9.w, r0.w, r3.z
mad r0.w, r0.w, c13.z, c13.w
add_sat r0.w, -r0.w, c14.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c12.xxyz
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 11 [_LightColor]
Vector 10 [_LightDir]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c13, 1, 2, -1, 0
def c14, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v0.w
mul r0.yz, r0.y, v0.xxyw
texld_pp r1, r0.yzzw, s2
texld r2, r0.yzzw, s0
mad r0.y, c7.x, r2.x, c7.y
rcp r0.y, r0.y
mul_pp r0.z, r1.w, c14.x
mad_pp r1.xyz, r1, c13.y, c13.z
nrm_pp r2.xyz, r1
rcp r0.w, v1.z
mul r0.w, r0.w, c6.z
mul r1.xyz, r0.w, v1
mul r3.xyz, r0.y, r1
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r1.xyw, r4.xyzz, -c5.xyzz
dp3 r0.w, r1.xyww, r1.xyww
rsq r0.w, r0.w
mad r1.xyw, r1, -r0.w, -c10.xyzz
nrm_pp r5.xyz, r1.xyww
dp3_pp r0.w, r5, r2
dp3_pp r1.x, -c10, r2
max_pp r1.y, r0.w, c13.w
pow r2.x, r1.y, r0.z
mov r4.w, c13.x
dp4 r3.x, c3, r4
dp4 r3.y, c4, r4
add r2.yzw, r4.xxyz, -c8.xxyz
dp3 r0.z, r2.yzww, r2.yzww
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.y, r1.z, -r0.y, r0.z
mad r0.y, c8.w, r0.y, r3.z
mad r0.y, r0.y, c12.z, c12.w
add_sat r0.y, -r0.y, c13.x
texld r3, r3, s1
mov_sat r0.z, r3.w
mul r0.w, r1.x, r3.w
mul_pp r1.yzw, r0.w, c11.xxyz
cmp_pp r1.yzw, r1.x, r1, c13.w
mul r0.z, r0.z, r2.x
mul_pp r1.x, r0.x, r0.z
mul_pp oC0, r0.y, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
Matrix 8 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 18 [_LightColor]
Vector 17 [_LightPos]
Vector 14 [_LightShadowData]
Vector 12 [_ProjectionParams]
Vector 11 [_WorldSpaceCameraPos]
Vector 13 [_ZBufferParams]
Vector 16 [unity_ColorSpaceLuminance]
Vector 19 [unity_LightmapFade]
Vector 15 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c20, 1, 0, 2, -1
def c21, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c20.x
rcp r0.y, v1.z
mul r0.y, r0.y, c12.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c13.x, r2.x, c13.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c20.x
dp4 r4.x, c8, r3
dp4 r4.y, c9, r3
dp4 r4.z, c10, r3
mov r4.w, c20.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
texldp_pp r5, r5, s3
lrp_pp r2.y, r5.x, r0.x, c14.x
add r0.xyz, r4, -c15
dp3 r0.x, r0, r0
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.w, -r2.x, r0.x
mad r0.x, c15.w, r0.x, r3.z
mad_sat r0.y, r0.x, c14.z, c14.w
mad r0.x, r0.x, c19.z, c19.w
add_sat r0.x, -r0.x, c20.x
add_sat_pp r0.y, r0.y, r2.y
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c17
add r3.xyz, r4, -c11
dp3 r0.z, r2, r2
mul r0.w, r0.z, c17.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.y, r0.y, r0.z
cmp r0.y, r2.w, c20.y, r0.y
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c20.z, c20.w
mul_pp r0.w, r1.w, c21.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c20.y
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c18.xxyz
max_pp r0.y, r1.x, c20.y
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c18
mul_pp r1.xyw, r1.xyzz, c16.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c16.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c16.w, r0.w, r0.z
mul_pp r2.x, r0.z, r0.y
mul_pp oC0, r0.x, r2

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Vector 10 [_LightColor]
Vector 9 [_LightDir]
Vector 6 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_ColorSpaceLuminance]
Vector 11 [unity_LightmapFade]
Vector 7 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
SetTexture 2 [_CameraNormalsTexture] 2D 2
"ps_3_0
def c12, 1, 2, -1, 0
def c13, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c12.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c7.xyzz
add r3.xyz, r3, -c3
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c7.w, r0.x, r2.z
mad_sat r0.y, r0.x, c6.z, c6.w
mad r0.x, r0.x, c11.z, c11.w
add_sat r0.x, -r0.x, c12.x
texld r2, r1, s1
texld_pp r1, r1, s2
add_sat_pp r0.y, r0.y, r2.x
dp3 r0.z, r3, r3
rsq r0.z, r0.z
mad r2.xyz, r3, -r0.z, -c9
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c12.y, c12.z
mul_pp r0.z, r1.w, c13.x
nrm_pp r2.xyz, r1
dp3_pp r0.w, r3, r2
dp3_pp r1.x, -c9, r2
max_pp r2.x, r1.x, c12.w
mul r1.x, r0.y, r2.x
mul_pp r1.yzw, r1.x, c10.xxyz
max_pp r2.x, r0.w, c12.w
pow r3.x, r2.x, r0.z
mul r0.y, r0.y, r3.x
mov r2.xyz, c10
mul_pp r2.xyw, r2.xyzz, c8.xyzz
add_pp r0.zw, r2.xyyw, r2.x
mul_pp r0.w, r0.w, r2.y
mad_pp r0.z, r2.z, c8.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c8.w, r0.w, r0.z
mul_pp r1.x, r0.z, r0.y
mul_pp oC0, r0.x, r1

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 12 [_LightColor]
Vector 11 [_LightDir]
Vector 8 [_LightShadowData]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 10 [unity_ColorSpaceLuminance]
Vector 13 [unity_LightmapFade]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_ShadowMapTexture] 2D 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c14, 1, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov r2.w, c14.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c9.xyzz
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c9.w, r0.x, r2.z
mad_sat r0.y, r0.x, c8.z, c8.w
mad r0.x, r0.x, c13.z, c13.w
add_sat r0.x, -r0.x, c14.x
texld r2, r1, s2
texld_pp r1, r1, s3
add_sat_pp r0.y, r0.y, r2.x
mov r3.w, c14.x
dp4 r2.x, c3, r3
dp4 r2.y, c4, r3
add r3.xyz, r3, -c5
texld r2, r2, s1
mul r0.y, r0.y, r2.w
mov_sat r0.z, r0.y
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r2.xyz, r3, -r0.w, -c11
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r0.w, r1.w, c15.x
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -c11, r2
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c12.xxyz
max_pp r0.y, r1.x, c14.w
pow r1.x, r0.y, r0.w
mul r0.y, r0.z, r1.x
mov r1.xyz, c12
mul_pp r1.xyw, r1.xyzz, c10.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c10.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c10.w, r0.w, r0.z
mul_pp r2.x, r0.z, r0.y
mul_pp oC0, r0.x, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.970000029, 2, -1
def c14, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c3.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
add r3.xyw, r4.xyzz, -c10.xyzz
add r4.xyz, r4, -c8
dp3 r0.z, r4, r4
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r2.x, r0.z
mad r0.z, c8.w, r0.z, r3.z
mad r0.z, r0.z, c12.z, c12.w
add_sat r0.z, -r0.z, c13.x
dp3 r0.w, r3.xyww, r3.xyww
rsq r2.x, r0.w
mul r0.w, r0.w, c10.w
texld r4, r0.w, s1
mul_pp r4.yzw, r2.x, r3.xxyw
texld r3, r3.xyww, s2
rcp r0.w, r2.x
mul r0.w, r0.w, c6.w
mad r0.w, r0.w, -c13.y, r3.x
mov r2.x, c13.x
cmp_pp r0.w, r0.w, r2.x, c7.x
mul r0.w, r0.w, r4.x
mad r2.xyz, r2.yzww, -r0.y, -r4.yzww
nrm_pp r3.xyz, r2
mad_pp r1.xyz, r1, c13.z, c13.w
mul_pp r0.y, r1.w, c14.y
nrm_pp r2.xyz, r1
dp3_pp r1.x, r3, r2
dp3_pp r1.y, -r4.yzww, r2
max_pp r2.x, r1.y, c14.x
mul r1.y, r0.w, r2.x
mov_sat r0.w, r0.w
mul_pp r2.yzw, r1.y, c11.xxyz
max_pp r3.x, r1.x, c14.x
pow r1.x, r3.x, r0.y
mul r0.y, r0.w, r1.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.z, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.970000029, 2, -1
def c17, 0, 128, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
add r2.yzw, r4.xxyz, -c13.xxyz
texld r6, r2.yzww, s3
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r7, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r0.y, r0.y, -c16.y, r6.x
mov r3.x, c16.x
cmp_pp r0.y, r0.y, r3.x, c10.x
mul r0.y, r0.y, r7.x
mul r0.y, r5.w, r0.y
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c16.z, c16.w
mul_pp r1.w, r1.w, c17.y
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.x
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c14.xxyz
max_pp r0.y, r1.x, c17.x
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
Matrix 12 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 22 [_LightColor]
Vector 21 [_LightPos]
Vector 18 [_LightShadowData]
Vector 16 [_ProjectionParams]
Vector 8 [_ShadowOffsets0]
Vector 9 [_ShadowOffsets1]
Vector 10 [_ShadowOffsets2]
Vector 11 [_ShadowOffsets3]
Vector 15 [_WorldSpaceCameraPos]
Vector 17 [_ZBufferParams]
Vector 20 [unity_ColorSpaceLuminance]
Vector 23 [unity_LightmapFade]
Vector 19 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c24, 1, 0.25, 0, -2
def c25, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
mov r0.x, c24.x
rcp r0.y, v1.z
mul r0.y, r0.y, c16.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c17.x, r2.x, c17.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c24.x
dp4 r4.x, c12, r3
dp4 r4.y, c13, r3
dp4 r4.z, c14, r3
mov r4.w, c24.x
dp4 r5.x, c0, r4
dp4 r5.y, c1, r4
dp4 r5.z, c2, r4
dp4 r5.w, c3, r4
rcp r0.y, r5.w
mad r6, r5, r0.y, c8
texldp_pp r6, r6, s3
mad r7, r5, r0.y, c9
texldp_pp r7, r7, s3
mov_pp r6.y, r7.x
mad r7, r5, r0.y, c10
mad r5, r5, r0.y, c11
texldp_pp r5, r5, s3
mov_pp r6.w, r5.x
texldp_pp r5, r7, s3
mov_pp r6.z, r5.x
lrp_pp r5, r6, r0.x, c18.x
dp4_pp r0.x, r5, c24.y
add r2.yzw, r4.xxyz, -c19.xxyz
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.y, r0.y
rcp r0.y, r0.y
mad r0.y, r0.w, -r2.x, r0.y
mad r0.y, c19.w, r0.y, r3.z
mad_sat r0.z, r0.y, c18.z, c18.w
mad r0.y, r0.y, c23.z, c23.w
add_sat r0.y, -r0.y, c24.x
add_sat_pp r0.x, r0.z, r0.x
dp4 r2.x, c4, r4
dp4 r2.y, c5, r4
dp4 r2.z, c6, r4
dp4 r2.w, c7, r4
texldp r3, r2, s2
add r2.xyz, -r4, c21
add r3.xyz, r4, -c15
dp3 r0.z, r2, r2
mul r0.w, r0.z, c21.w
rsq r0.z, r0.z
mul_pp r2.xyz, r0.z, r2
texld r4, r0.w, s1
mul r0.z, r3.w, r4.x
mul r0.x, r0.x, r0.z
cmp r0.x, r2.w, c24.z, r0.x
mov_sat r0.z, r0.x
dp3 r0.w, r3, r3
rsq r0.w, r0.w
mad r3.xyz, r3, -r0.w, r2
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, -c24.w, -c24.x
mul_pp r0.w, r1.w, c25.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, r2, r3
max_pp r2.x, r1.y, c24.z
mul r0.x, r0.x, r2.x
mul_pp r2.yzw, r0.x, c22.xxyz
max_pp r0.x, r1.x, c24.z
pow r1.x, r0.x, r0.w
mul r0.x, r0.z, r1.x
mov r1.xyz, c22
mul_pp r1.xyw, r1.xyzz, c20.xyzz
add_pp r0.zw, r1.xyyw, r1.x
mul_pp r0.w, r0.w, r1.y
mad_pp r0.z, r1.z, c20.z, r0.z
rsq_pp r0.w, r0.w
rcp_pp r0.w, r0.w
dp2add_pp r0.z, c20.w, r0.w, r0.z
mul_pp r2.x, r0.z, r0.x
mul_pp oC0, r0.y, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 9 [unity_ColorSpaceLuminance]
Vector 12 [unity_LightmapFade]
Vector 8 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraNormalsTexture] 2D 3
"ps_3_0
def c13, 1, 0.0078125, -0.0078125, 0.970000029
def c14, 0.25, 2, -1, 0
def c15, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
mov r0.xyz, c11
mul_pp r0.xyw, r0.xyzz, c9.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c9.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c9.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c4.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s3
mad r2.x, c5.x, r2.x, c5.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c13.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c10.xxyz
add r3.xyw, r2.yzzw, c13.y
texld r5, r3.xyww, s2
add r3.xyw, r2.yzzw, c13.zzzy
texld r6, r3.xyww, s2
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c13.zyzz
texld r6, r3.xyww, s2
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c13.yzzz
texld r6, r3.xyww, s2
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c10.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c6.w
mad r5, r0.y, -c13.w, r5
mov r3.x, c13.x
cmp_pp r5, r5, r3.x, c7.x
dp4_pp r0.y, r5, c14.x
mul r0.y, r0.y, r6.x
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c3.xyzz
add r4.xyz, r4, -c8
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c8.w, r0.w, r3.z
mad r0.w, r0.w, c12.z, c12.w
add_sat r0.w, -r0.w, c13.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c14.y, c14.z
mul_pp r1.w, r1.w, c15.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c14.w
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c11.xxyz
max_pp r0.y, r1.x, c14.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 14 [_LightColor]
Vector 13 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 12 [unity_ColorSpaceLuminance]
Vector 15 [unity_LightmapFade]
Vector 11 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraNormalsTexture] 2D 4
"ps_3_0
def c16, 1, 0.0078125, -0.0078125, 0.970000029
def c17, 0.25, 2, -1, 0
def c18, 128, 0, 0, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
mov r0.xyz, c14
mul_pp r0.xyw, r0.xyzz, c12.xyzz
add_pp r0.xw, r0.yyzw, r0.x
mul_pp r0.y, r0.w, r0.y
mad_pp r0.x, r0.z, c12.z, r0.x
rsq_pp r0.y, r0.y
rcp_pp r0.y, r0.y
dp2add_pp r0.x, c12.w, r0.y, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c7.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
texld_pp r1, r1, s4
mad r2.x, c8.x, r2.x, c8.y
rcp r2.x, r2.x
mul r3.xyz, r0.yzww, r2.x
mov r3.w, c16.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
add r2.yzw, r4.xxyz, -c13.xxyz
add r3.xyw, r2.yzzw, c16.y
texld r5, r3.xyww, s3
add r3.xyw, r2.yzzw, c16.zzzy
texld r6, r3.xyww, s3
mov r5.y, r6.x
add r3.xyw, r2.yzzw, c16.zyzz
texld r6, r3.xyww, s3
mov r5.z, r6.x
add r3.xyw, r2.yzzw, c16.yzzz
texld r6, r3.xyww, s3
mov r5.w, r6.x
dp3 r0.y, r2.yzww, r2.yzww
rsq r0.z, r0.y
mul r0.y, r0.y, c13.w
texld r6, r0.y, s1
rcp r0.y, r0.z
mul_pp r2.yzw, r0.z, r2
mul r0.y, r0.y, c9.w
mad r5, r0.y, -c16.w, r5
mov r3.x, c16.x
cmp_pp r5, r5, r3.x, c10.x
dp4_pp r0.y, r5, c17.x
mul r0.y, r0.y, r6.x
mov r4.w, c16.x
dp4 r5.x, c3, r4
dp4 r5.y, c4, r4
dp4 r5.z, c5, r4
texld r5, r5, s2
mul r0.y, r0.y, r5.w
mov_sat r0.z, r0.y
add r3.xyw, r4.xyzz, -c6.xyzz
add r4.xyz, r4, -c11
dp3 r4.x, r4, r4
rsq r4.x, r4.x
rcp r4.x, r4.x
mad r0.w, r0.w, -r2.x, r4.x
mad r0.w, c11.w, r0.w, r3.z
mad r0.w, r0.w, c15.z, c15.w
add_sat r0.w, -r0.w, c16.x
dp3 r2.x, r3.xyww, r3.xyww
rsq r2.x, r2.x
mad r3.xyz, r3.xyww, -r2.x, -r2.yzww
nrm_pp r4.xyz, r3
mad_pp r1.xyz, r1, c17.y, c17.z
mul_pp r1.w, r1.w, c18.x
nrm_pp r3.xyz, r1
dp3_pp r1.x, r4, r3
dp3_pp r1.y, -r2.yzww, r3
max_pp r2.x, r1.y, c17.w
mul r0.y, r0.y, r2.x
mul_pp r2.yzw, r0.y, c14.xxyz
max_pp r0.y, r1.x, c17.w
pow r3.x, r0.y, r1.w
mul r0.y, r0.z, r3.x
mul_pp r2.x, r0.x, r0.y
mul_pp oC0, r0.w, r2

"
}
}
 }
}
Fallback Off
}
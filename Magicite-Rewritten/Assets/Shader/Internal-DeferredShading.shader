//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Internal-DeferredShading" {
Properties {
 _LightTexture0 ("", any) = "" { }
 _LightTextureB0 ("", 2D) = "" { }
 _ShadowMapTexture ("", any) = "" { }
 _SrcBlend ("", Float) = 1
 _DstBlend ("", Float) = 1
}
SubShader { 
 Pass {
  Tags { "SHADOWSUPPORT"="true" }
  ZWrite Off
  Blend [_SrcBlend] [_DstBlend]
  GpuProgramID 36028
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
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_OFF" "UNITY_HDR_ON" }
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
Keywords { "DIRECTIONAL" "SHADOWS_OFF" "UNITY_HDR_ON" }
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
Keywords { "SPOT" "SHADOWS_OFF" "UNITY_HDR_ON" }
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
Keywords { "POINT_COOKIE" "SHADOWS_OFF" "UNITY_HDR_ON" }
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
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" "UNITY_HDR_ON" }
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
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" "UNITY_HDR_ON" }
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
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" "UNITY_HDR_ON" }
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
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" "UNITY_HDR_ON" }
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
Keywords { "POINT" "SHADOWS_CUBE" "UNITY_HDR_ON" }
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
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "UNITY_HDR_ON" }
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
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" "UNITY_HDR_ON" }
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
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" "UNITY_HDR_ON" }
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
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" "UNITY_HDR_ON" }
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
Vector 7 [_LightColor]
Vector 6 [_LightPos]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c9, 1, 2, -1, 0
def c10, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c11, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c9.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c6
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c6.w
texld r4, r0.x, s1
mul_pp r0.xzw, r4.x, c7.xyyz
mad_pp r4.xyz, r2, -r0.y, -r3
mul_pp r2.xyz, r0.y, r2
dp3_pp r0.y, r4, r4
add r1.z, -r0.y, c10.x
rsq_pp r0.y, r0.y
cmp_pp r0.y, r1.z, c10.y, r0.y
mul_pp r4.xyz, r0.y, r4
texld_pp r5, r1, s4
mad_pp r5.xyz, r5, c9.y, c9.z
nrm_pp r6.xyz, r5
dp3_pp r0.y, r6, r4
dp3_pp r1.z, -r2, r4
dp3_pp r1.w, r6, -r2
dp3_pp r2.x, r6, -r3
max_pp r3.x, r2.x, c9.w
max_pp r2.x, r1.w, c9.w
max_pp r2.y, r1.z, c9.w
max_pp r1.z, r0.y, c9.w
texld_pp r4, r1, s3
texld_pp r5, r1, s2
add_pp r0.y, -r4.w, c9.x
add_pp r1.x, -r0.y, c9.x
mad_pp r1.x, r1.x, c11.x, c11.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c10.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c9.x
mul_pp r1.x, r1.x, c8.y
pow_pp r2.z, r1.z, r1.y
mul_pp r1.x, r1.x, r2.z
mul_pp r1.y, r0.y, r0.y
mul_pp r1.z, r1.y, c8.w
mov r6.x, c9.x
mad_pp r1.y, r1.y, -c8.w, r6.x
mad_pp r1.w, r3.x, r1.y, r1.z
add_pp r2.z, -r3.x, c9.x
mad_pp r1.y, r2.x, r1.y, r1.z
mad r1.y, r1.y, r1.w, c10.z
rcp_pp r1.y, r1.y
mul_pp r1.x, r1.x, r1.y
mul_pp r1.x, r2.x, r1.x
mul_pp r1.x, r1.x, c8.x
max_pp r2.w, r1.x, c9.w
mul_pp r1.xyz, r0.xzww, r2.w
add_pp r1.w, -r2.y, c9.x
mul_pp r2.y, r2.y, r2.y
dp2add_pp r0.y, r2.y, r0.y, c11.z
mul_pp r2.y, r1.w, r1.w
mul_pp r2.y, r2.y, r2.y
mul_pp r1.w, r1.w, r2.y
lrp_pp r3.xyz, r1.w, c9.x, r4
mul_pp r1.xyz, r1, r3
mul_pp r1.w, r2.z, r2.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.z, r1.w
mad_pp r1.w, r0.y, r1.w, c9.x
add_pp r2.y, -r2.x, c9.x
mul_pp r2.z, r2.y, r2.y
mul_pp r2.z, r2.z, r2.z
mul_pp r2.y, r2.y, r2.z
mad_pp r0.y, r0.y, r2.y, c9.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.x, r0.y
mul_pp r0.xyz, r0.y, r0.xzww
mad_pp r0.xyz, r5, r0, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c11.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Vector 7 [_LightColor]
Vector 6 [_LightDir]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraGBufferTexture0] 2D 1
SetTexture 2 [_CameraGBufferTexture1] 2D 2
SetTexture 3 [_CameraGBufferTexture2] 2D 3
"ps_3_0
def c9, 1, 2, -1, 0
def c10, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c11, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c9.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mad_pp r2.xyz, r0, -r0.w, -c6
mul_pp r0.xyz, r0.w, r0
dp3_pp r0.w, r2, r2
add r1.z, -r0.w, c10.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c10.y, r0.w
mul_pp r2.xyz, r0.w, r2
texld_pp r3, r1, s3
mad_pp r3.xyz, r3, c9.y, c9.z
nrm_pp r4.xyz, r3
dp3_pp r0.w, r4, r2
dp3_pp r1.z, -c6, r2
max_pp r2.x, r1.z, c9.w
max_pp r1.z, r0.w, c9.w
texld_pp r3, r1, s2
texld_pp r5, r1, s1
add_pp r0.w, -r3.w, c9.x
add_pp r1.x, -r0.w, c9.x
mad_pp r1.x, r1.x, c11.x, c11.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c10.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c9.x
mul_pp r1.x, r1.x, c8.y
pow_pp r2.y, r1.z, r1.y
mul_pp r1.x, r1.x, r2.y
dp3_pp r0.x, r4, -r0
dp3_pp r0.y, r4, -c6
max_pp r1.y, r0.y, c9.w
max_pp r1.z, r0.x, c9.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c8.w
mov r4.x, c9.x
mad_pp r0.x, r0.x, -c8.w, r4.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c9.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c10.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c8.x
mul_pp r2.yzw, r0.x, c7.xxyz
cmp_pp r0.xyz, r0.x, r2.yzww, c9.w
add_pp r1.x, -r2.x, c9.x
mul_pp r1.w, r2.x, r2.x
dp2add_pp r0.w, r1.w, r0.w, c11.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r2.xyz, r1.x, c9.x, r3
mul_pp r0.xyz, r0, r2
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c9.x
add_pp r1.z, -r1.y, c9.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c9.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r1.xyz, r0.w, c7
mad_pp r0.xyz, r5, r1, r0
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c11.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" }
Matrix 4 [_CameraToWorld] 3
Matrix 0 [_LightMatrix0]
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 8 [_ProjectionParams]
Vector 7 [_WorldSpaceCameraPos]
Vector 9 [_ZBufferParams]
Vector 12 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c13, 1, 0, 2, -1
def c14, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c15, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v0.w
mul r0.xy, r0.x, v0
texld_pp r1, r0, s4
add_pp r0.z, -r1.w, c13.x
add_pp r0.w, -r0.z, c13.x
mad_pp r0.w, r0.w, c15.x, c15.y
log_pp r0.w, r0.w
rcp r0.w, r0.w
mul_pp r0.w, r0.w, c14.w
mul_pp r1.w, r0.w, r0.w
mad_pp r0.w, r0.w, r0.w, c13.x
mul_pp r0.w, r0.w, c12.y
texld_pp r2, r0, s5
mad_pp r2.xyz, r2, c13.z, c13.w
nrm_pp r3.xyz, r2
texld r2, r0, s0
texld_pp r4, r0, s3
mad r0.x, c9.x, r2.x, c9.y
rcp r0.x, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c8.z
mul r2.xyz, r0.y, v1
mul r2.xyz, r0.x, r2
mov r2.w, c13.x
dp4 r5.x, c4, r2
dp4 r5.y, c5, r2
dp4 r5.z, c6, r2
add r2.xyz, r5, -c7
nrm_pp r6.xyz, r2
add r2.xyz, -r5, c10
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c10.w
texld r7, r0.x, s1
mad_pp r7.yzw, r2.xxyz, r0.y, -r6.xxyz
dp3_pp r0.x, r3, -r6
max_pp r2.w, r0.x, c13.y
mul_pp r2.xyz, r0.y, r2
dp3_pp r0.x, r7.yzww, r7.yzww
add r0.y, -r0.x, c14.x
rsq_pp r0.x, r0.x
cmp_pp r0.x, r0.y, c14.y, r0.x
mul_pp r6.xyz, r0.x, r7.yzww
dp3_pp r0.x, r3, r6
dp3_pp r0.y, r3, r2
dp3_pp r2.x, r2, r6
max_pp r3.x, r2.x, c13.y
max_pp r2.x, r0.y, c13.y
max_pp r2.y, r0.x, c13.y
pow_pp r0.x, r2.y, r1.w
mul_pp r0.xy, r0.wzzw, r0.xzzw
mul_pp r0.w, r0.y, c12.w
mov r6.x, c13.x
mad_pp r0.y, r0.y, -c12.w, r6.x
mad_pp r1.w, r2.w, r0.y, r0.w
mad_pp r0.y, r2.x, r0.y, r0.w
mad r0.y, r0.y, r1.w, c14.z
rcp_pp r0.y, r0.y
mul_pp r0.x, r0.x, r0.y
mul_pp r0.x, r2.x, r0.x
mul_pp r0.x, r0.x, c12.x
max_pp r1.w, r0.x, c13.y
add_pp r0.x, -r2.w, c13.x
mov r5.w, c13.x
dp4 r6.x, c0, r5
dp4 r6.y, c1, r5
dp4 r6.z, c2, r5
dp4 r6.w, c3, r5
texldp r5, r6, s2
mul r0.y, r7.x, r5.w
mul_pp r2.yzw, r0.y, c11.xxyz
cmp_pp r2.yzw, r6.w, c13.y, r2
mul_pp r3.yzw, r1.w, r2
add_pp r0.y, -r3.x, c13.x
mul_pp r0.w, r3.x, r3.x
dp2add_pp r0.z, r0.w, r0.z, c15.z
mul_pp r0.w, r0.y, r0.y
mul_pp r0.w, r0.w, r0.w
mul_pp r0.y, r0.y, r0.w
lrp_pp r5.xyz, r0.y, c13.x, r1
mul_pp r1.xyz, r3.yzww, r5
mul_pp r0.y, r0.x, r0.x
mul_pp r0.y, r0.y, r0.y
mul_pp r0.x, r0.x, r0.y
mad_pp r0.x, r0.z, r0.x, c13.x
add_pp r0.y, -r2.x, c13.x
mul_pp r0.w, r0.y, r0.y
mul_pp r0.w, r0.w, r0.w
mul_pp r0.y, r0.y, r0.w
mad_pp r0.y, r0.z, r0.y, c13.x
mul_pp r0.x, r0.x, r0.y
mul_pp r0.x, r2.x, r0.x
mul_pp r0.xyz, r0.x, r2.yzww
mad_pp r0.xyz, r4, r0, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c15.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 10 [_LightColor]
Vector 9 [_LightPos]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 11 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c12, 1, 2, -1, 0
def c13, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c14, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c12.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c6
nrm_pp r3.xyz, r0
add r0.xyz, r2, -c9
dp3 r0.w, r0, r0
rsq r1.z, r0.w
mul r0.w, r0.w, c9.w
texld r4, r0.w, s1
mad_pp r4.yzw, r0.xxyz, -r1.z, -r3.xxyz
mul_pp r0.xyz, r0, r1.z
dp3_pp r0.w, r4.yzww, r4.yzww
add r1.z, -r0.w, c13.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c13.y, r0.w
mul_pp r4.yzw, r0.w, r4
texld_pp r5, r1, s5
mad_pp r5.xyz, r5, c12.y, c12.z
nrm_pp r6.xyz, r5
dp3_pp r0.w, r6, r4.yzww
dp3_pp r1.z, -r0, r4.yzww
dp3_pp r0.x, r6, -r0
dp3_pp r0.y, r6, -r3
max_pp r1.w, r0.y, c12.w
max_pp r3.x, r0.x, c12.w
max_pp r0.x, r1.z, c12.w
max_pp r1.z, r0.w, c12.w
texld_pp r5, r1, s4
texld_pp r6, r1, s3
add_pp r0.y, -r5.w, c12.x
add_pp r0.z, -r0.y, c12.x
mad_pp r0.z, r0.z, c14.x, c14.y
log_pp r0.z, r0.z
rcp r0.z, r0.z
mul_pp r0.z, r0.z, c13.w
mul_pp r0.w, r0.z, r0.z
mad_pp r0.z, r0.z, r0.z, c12.x
mul_pp r0.z, r0.z, c11.y
pow_pp r3.y, r1.z, r0.w
mul_pp r0.z, r0.z, r3.y
mul_pp r0.w, r0.y, r0.y
mul_pp r1.x, r0.w, c11.w
mov r7.x, c12.x
mad_pp r0.w, r0.w, -c11.w, r7.x
mad_pp r1.y, r1.w, r0.w, r1.x
add_pp r1.z, -r1.w, c12.x
mad_pp r0.w, r3.x, r0.w, r1.x
mad r0.w, r0.w, r1.y, c13.z
rcp_pp r0.w, r0.w
mul_pp r0.z, r0.z, r0.w
mul_pp r0.z, r3.x, r0.z
mul_pp r0.z, r0.z, c11.x
max_pp r1.x, r0.z, c12.w
mov r2.w, c12.x
dp4 r7.x, c3, r2
dp4 r7.y, c4, r2
dp4 r7.z, c5, r2
texld r2, r7, s2
mul r0.z, r2.w, r4.x
mul_pp r2.xyz, r0.z, c10
mul_pp r1.xyw, r1.x, r2.xyzz
add_pp r0.z, -r0.x, c12.x
mul_pp r0.x, r0.x, r0.x
dp2add_pp r0.x, r0.x, r0.y, c14.z
mul_pp r0.y, r0.z, r0.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r0.z, r0.y
lrp_pp r3.yzw, r0.y, c12.x, r5.xxyz
mul_pp r0.yzw, r1.xxyw, r3
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.x, r1.x, c12.x
add_pp r1.y, -r3.x, c12.x
mul_pp r1.z, r1.y, r1.y
mul_pp r1.z, r1.z, r1.z
mul_pp r1.y, r1.y, r1.z
mad_pp r0.x, r0.x, r1.y, c12.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r3.x, r0.x
mul_pp r1.xyz, r0.x, r2
mad_pp r0.xyz, r6, r1, r0.yzww
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c14.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c13, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c5
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mad_pp r3.xyz, r0, -r0.w, -c8
mul_pp r0.xyz, r0.w, r0
dp3_pp r0.w, r3, r3
add r1.z, -r0.w, c12.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c12.y, r0.w
mul_pp r3.xyz, r0.w, r3
texld_pp r4, r1, s4
mad_pp r4.xyz, r4, c11.y, c11.z
nrm_pp r5.xyz, r4
dp3_pp r0.w, r5, r3
dp3_pp r1.z, -c8, r3
max_pp r3.x, r1.z, c11.w
max_pp r1.z, r0.w, c11.w
texld_pp r4, r1, s3
texld_pp r6, r1, s2
add_pp r0.w, -r4.w, c11.x
add_pp r1.x, -r0.w, c11.x
mad_pp r1.x, r1.x, c13.x, c13.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c12.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c11.x
mul_pp r1.x, r1.x, c10.y
pow_pp r3.y, r1.z, r1.y
mul_pp r1.x, r1.x, r3.y
dp3_pp r0.x, r5, -r0
dp3_pp r0.y, r5, -c8
max_pp r1.y, r0.y, c11.w
max_pp r1.z, r0.x, c11.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c10.w
mov r5.x, c11.x
mad_pp r0.x, r0.x, -c10.w, r5.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c11.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c12.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c10.x
max_pp r1.x, r0.x, c11.w
mov r2.w, c11.x
dp4 r0.x, c3, r2
dp4 r0.y, c4, r2
texld r2, r0, s1
mul_pp r0.xyz, r2.w, c9
mul_pp r2.xyz, r0, r1.x
add_pp r1.x, -r3.x, c11.x
mul_pp r1.w, r3.x, r3.x
dp2add_pp r0.w, r1.w, r0.w, c13.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r3.xyz, r1.x, c11.x, r4
mul_pp r2.xyz, r2, r3
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c11.x
add_pp r1.z, -r1.y, c11.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c11.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r0.xyz, r0.w, r0
mad_pp r0.xyz, r6, r0, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c13.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" }
Matrix 8 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 17 [_LightColor]
Vector 16 [_LightPos]
Vector 14 [_LightShadowData]
Vector 12 [_ProjectionParams]
Vector 11 [_WorldSpaceCameraPos]
Vector 13 [_ZBufferParams]
Vector 18 [unity_LightGammaCorrectionConsts]
Vector 15 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c19, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c20, 0.967999995, 0.0299999993, -0.5, 0.5
def c21, 1, 0, 2, -1
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
mov r0.x, c21.x
rcp r0.y, v1.z
mul r0.y, r0.y, c12.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
mad r1.z, c13.x, r2.x, c13.y
rcp r1.z, r1.z
mul r2.xyz, r0.yzww, r1.z
mov r2.w, c21.x
dp4 r3.x, c8, r2
dp4 r3.y, c9, r2
dp4 r3.z, c10, r2
mov r3.w, c21.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
dp4 r4.w, c3, r3
texldp_pp r4, r4, s3
lrp_pp r1.w, r4.x, r0.x, c14.x
add r2.xyw, r3.xyzz, -c15.xyzz
dp3 r0.y, r2.xyww, r2.xyww
rsq r0.y, r0.y
rcp r0.y, r0.y
mad r0.y, r0.w, -r1.z, r0.y
mad r0.y, c15.w, r0.y, r2.z
mad_sat r0.y, r0.y, c14.z, c14.w
add_sat_pp r0.y, r0.y, r1.w
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r2.z, c6, r3
dp4 r2.w, c7, r3
texldp r4, r2, s2
add r2.xyz, -r3, c16
add r3.xyz, r3, -c11
nrm_pp r4.xyz, r3
dp3 r0.z, r2, r2
mul r0.w, r0.z, c16.w
rsq r0.z, r0.z
texld r3, r0.w, s1
mul r0.w, r3.x, r4.w
mul r0.y, r0.y, r0.w
mul_pp r3.xyz, r0.y, c17
cmp_pp r3.xyz, r2.w, c21.y, r3
mad_pp r5.xyz, r2, r0.z, -r4
mul_pp r0.yzw, r0.z, r2.xxyz
dp3_pp r1.z, r5, r5
add r1.w, -r1.z, c19.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c19.y, r1.z
mul_pp r2.xyz, r1.z, r5
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, c21.z, c21.w
nrm_pp r6.xyz, r5
dp3_pp r1.z, r6, r2
dp3_pp r1.w, r0.yzww, r2
dp3_pp r0.y, r6, r0.yzww
dp3_pp r0.z, r6, -r4
max_pp r2.x, r0.z, c21.y
max_pp r2.y, r0.y, c21.y
max_pp r0.y, r1.w, c21.y
max_pp r0.z, r1.z, c21.y
texld_pp r4, r1, s5
texld_pp r1, r1, s4
add_pp r0.w, -r4.w, c21.x
add_pp r1.w, -r0.w, c21.x
mad_pp r1.w, r1.w, c20.x, c20.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c19.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c21.x
mul_pp r1.w, r1.w, c18.y
pow_pp r3.w, r0.z, r2.z
mul_pp r0.z, r1.w, r3.w
mul_pp r1.w, r0.w, r0.w
mul_pp r2.z, r1.w, c18.w
mad_pp r0.x, r1.w, -c18.w, r0.x
mad_pp r1.w, r2.x, r0.x, r2.z
add_pp r2.x, -r2.x, c21.x
mad_pp r0.x, r2.y, r0.x, r2.z
mad r0.x, r0.x, r1.w, c19.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r0.z, r0.x
mul_pp r0.x, r2.y, r0.x
mul_pp r0.x, r0.x, c18.x
max_pp r1.w, r0.x, c21.y
mul_pp r5.xyz, r3, r1.w
add_pp r0.x, -r0.y, c21.x
mul_pp r0.yz, r0.xyxw, r0.xyxw
dp2add_pp r0.y, r0.y, r0.w, c20.z
mul_pp r0.z, r0.z, r0.z
mul_pp r0.x, r0.x, r0.z
lrp_pp r6.xyz, r0.x, c21.x, r4
mul_pp r0.xzw, r5.xyyz, r6.xyyz
mul_pp r1.w, r2.x, r2.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.x, r1.w
mad_pp r1.w, r0.y, r1.w, c21.x
add_pp r2.x, -r2.y, c21.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r0.y, r0.y, r2.x, c21.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r2.xyz, r0.y, r3
mad_pp r0.xyz, r1, r2, r0.xzww
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c20.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 6 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
Vector 7 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c11, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c12, 1, 2, -1, 0
def c13, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov_pp r2.w, c12.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c3.xyzz
add r3.xyz, r3, -c7
dp3 r0.x, r3, r3
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c7.w, r0.x, r2.z
mad_sat r0.x, r0.x, c6.z, c6.w
dp3 r0.y, r2.xyww, r2.xyww
rsq r0.y, r0.y
mad_pp r3.xyz, r2.xyww, -r0.y, -c8
mul_pp r0.yzw, r0.y, r2.xxyw
dp3_pp r1.z, r3, r3
add r1.w, -r1.z, c11.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c11.y, r1.z
mul_pp r2.xyz, r1.z, r3
texld_pp r3, r1, s4
mad_pp r3.xyz, r3, c12.y, c12.z
nrm_pp r4.xyz, r3
dp3_pp r1.z, r4, r2
dp3_pp r1.w, -c8, r2
max_pp r2.x, r1.w, c12.w
max_pp r2.y, r1.z, c12.w
texld_pp r3, r1, s3
add_pp r1.z, -r3.w, c12.x
add_pp r1.w, -r1.z, c12.x
mad_pp r1.w, r1.w, c13.x, c13.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c11.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c12.x
mul_pp r1.w, r1.w, c10.y
pow_pp r3.w, r2.y, r2.z
mul_pp r1.w, r1.w, r3.w
dp3_pp r0.y, r4, -r0.yzww
dp3_pp r0.z, r4, -c8
max_pp r2.y, r0.z, c12.w
max_pp r2.z, r0.y, c12.w
mul_pp r0.y, r1.z, r1.z
mul_pp r0.z, r0.y, c10.w
mov r4.x, c12.x
mad_pp r0.y, r0.y, -c10.w, r4.x
mad_pp r0.w, r2.z, r0.y, r0.z
add_pp r2.z, -r2.z, c12.x
mad_pp r0.y, r2.y, r0.y, r0.z
mad r0.y, r0.y, r0.w, c11.z
rcp_pp r0.y, r0.y
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r0.y, r0.y, c10.x
texld r4, r1, s1
texld_pp r5, r1, s2
add_sat_pp r0.x, r0.x, r4.x
mul_pp r0.xzw, r0.x, c9.xyyz
mul_pp r1.xyw, r0.xzzw, r0.y
cmp_pp r1.xyw, r0.y, r1, c12.w
add_pp r0.y, -r2.x, c12.x
mul_pp r2.x, r2.x, r2.x
dp2add_pp r1.z, r2.x, r1.z, c13.z
mul_pp r2.x, r0.y, r0.y
mul_pp r2.x, r2.x, r2.x
mul_pp r0.y, r0.y, r2.x
lrp_pp r4.xyz, r0.y, c12.x, r3
mul_pp r1.xyw, r1, r4.xyzz
mul_pp r0.y, r2.z, r2.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r2.z, r0.y
mad_pp r0.y, r1.z, r0.y, c12.x
add_pp r2.x, -r2.y, c12.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r1.z, r1.z, r2.x, c12.x
mul_pp r0.y, r0.y, r1.z
mul_pp r0.y, r2.y, r0.y
mul_pp r0.xyz, r0.y, r0.xzww
mad_pp r0.xyz, r5, r0, r1.xyww
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c13.w

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 11 [_LightColor]
Vector 10 [_LightDir]
Vector 8 [_LightShadowData]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 12 [unity_LightGammaCorrectionConsts]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_ShadowMapTexture] 2D 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c13, 1, 2, -1, 0
def c14, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c15, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov_pp r2.w, c13.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c9.xyzz
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c9.w, r0.x, r2.z
mad_sat r0.x, r0.x, c8.z, c8.w
texld r2, r1, s2
add_sat_pp r0.x, r0.x, r2.x
mov_pp r3.w, c13.x
dp4 r2.x, c3, r3
dp4 r2.y, c4, r3
add r0.yzw, r3.xxyz, -c5.xxyz
texld r2, r2, s1
mul r0.x, r0.x, r2.w
mul_pp r2.xyz, r0.x, c11
dp3 r0.x, r0.yzww, r0.yzww
rsq r0.x, r0.x
mad_pp r3.xyz, r0.yzww, -r0.x, -c10
mul_pp r0.xyz, r0.x, r0.yzww
dp3_pp r0.w, r3, r3
add r1.z, -r0.w, c14.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c14.y, r0.w
mul_pp r3.xyz, r0.w, r3
texld_pp r4, r1, s5
mad_pp r4.xyz, r4, c13.y, c13.z
nrm_pp r5.xyz, r4
dp3_pp r0.w, r5, r3
dp3_pp r1.z, -c10, r3
max_pp r2.w, r1.z, c13.w
max_pp r1.z, r0.w, c13.w
texld_pp r3, r1, s4
texld_pp r4, r1, s3
add_pp r0.w, -r3.w, c13.x
add_pp r1.x, -r0.w, c13.x
mad_pp r1.x, r1.x, c15.x, c15.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c14.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c13.x
mul_pp r1.x, r1.x, c12.y
pow_pp r3.w, r1.z, r1.y
mul_pp r1.x, r1.x, r3.w
dp3_pp r0.x, r5, -r0
dp3_pp r0.y, r5, -c10
max_pp r1.y, r0.y, c13.w
max_pp r1.z, r0.x, c13.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c12.w
mov r5.x, c13.x
mad_pp r0.x, r0.x, -c12.w, r5.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c13.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c14.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c12.x
max_pp r1.x, r0.x, c13.w
mul_pp r0.xyz, r2, r1.x
add_pp r1.x, -r2.w, c13.x
mul_pp r1.w, r2.w, r2.w
dp2add_pp r0.w, r1.w, r0.w, c15.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r5.xyz, r1.x, c13.x, r3
mul_pp r0.xyz, r0, r5
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c13.x
add_pp r1.z, -r1.y, c13.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c13.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r1.xyz, r0.w, r2
mad_pp r0.xyz, r4, r1, r0
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c15.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c11, 1, 0.970000029, 2, -1
def c12, 0, 0.00100000005, 31.622776, 9.99999975e-005
def c13, 0.967999995, 0.0299999993, 10, -0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c8
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c8.w
texld r4, r0.x, s1
mad_pp r0.xzw, r2.xyyz, -r0.y, -r3.xyyz
dp3_pp r1.z, r0.xzww, r0.xzww
add r1.w, -r1.z, c12.y
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c12.z, r1.z
mul_pp r0.xzw, r0, r1.z
texld_pp r5, r1, s5
mad_pp r4.yzw, r5.xxyz, c11.z, c11.w
nrm_pp r5.xyz, r4.yzww
dp3_pp r1.z, r5, r0.xzww
max_pp r2.w, r1.z, c12.x
texld_pp r6, r1, s4
texld_pp r1, r1, s3
add_pp r1.w, -r6.w, c11.x
add_pp r3.w, -r1.w, c11.x
mad_pp r3.w, r3.w, c13.x, c13.y
log_pp r3.w, r3.w
rcp r3.w, r3.w
mul_pp r3.w, r3.w, c13.z
mul_pp r4.y, r3.w, r3.w
mad_pp r3.w, r3.w, r3.w, c11.x
mul_pp r3.w, r3.w, c10.y
pow_pp r5.w, r2.w, r4.y
mul_pp r2.w, r3.w, r5.w
dp3_pp r3.x, r5, -r3
max_pp r4.y, r3.x, c12.x
mul_pp r3.x, r1.w, r1.w
mul_pp r3.y, r3.x, c10.w
mov r7.x, c11.x
mad_pp r3.x, r3.x, -c10.w, r7.x
mad_pp r3.z, r4.y, r3.x, r3.y
add_pp r3.w, -r4.y, c11.x
mul_pp r4.yzw, r0.y, r2.xxyz
texld r8, r2, s2
rcp r0.y, r0.y
mul r0.y, r0.y, c6.w
mad r0.y, r0.y, -c11.y, r8.x
cmp_pp r0.y, r0.y, r7.x, c7.x
mul r0.y, r0.y, r4.x
mul_pp r2.xyz, r0.y, c9
dp3_pp r0.y, r5, -r4.yzww
dp3_pp r0.x, -r4.yzww, r0.xzww
max_pp r4.x, r0.x, c12.x
max_pp r4.y, r0.y, c12.x
mad_pp r0.x, r4.y, r3.x, r3.y
mad r0.x, r0.x, r3.z, c12.w
rcp_pp r0.x, r0.x
mul_pp r0.x, r2.w, r0.x
mul_pp r0.x, r4.y, r0.x
mul_pp r0.x, r0.x, c10.x
max_pp r2.w, r0.x, c12.x
mul_pp r0.xyz, r2, r2.w
add_pp r0.w, -r4.x, c11.x
mul_pp r2.w, r4.x, r4.x
dp2add_pp r1.w, r2.w, r1.w, c13.w
mul_pp r2.w, r0.w, r0.w
mul_pp r2.w, r2.w, r2.w
mul_pp r0.w, r0.w, r2.w
lrp_pp r3.xyz, r0.w, c11.x, r6
mul_pp r0.w, r3.w, r3.w
mul_pp r0.w, r0.w, r0.w
mul_pp r0, r3, r0
mad_pp r0.w, r1.w, r0.w, c11.x
add_pp r2.w, -r4.y, c11.x
mul_pp r3.x, r2.w, r2.w
mul_pp r3.x, r3.x, r3.x
mul_pp r2.w, r2.w, r3.x
mad_pp r1.w, r1.w, r2.w, c11.x
mul_pp r0.w, r0.w, r1.w
mul_pp r0.w, r4.y, r0.w
mul_pp r2.xyz, r0.w, r2
mad_pp r0.xyz, r1, r2, r0
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, -c13.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 13 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c14, 1, 0.970000029, 2, -1
def c15, 0, 0.00100000005, 31.622776, 9.99999975e-005
def c16, 0.967999995, 0.0299999993, 10, -0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c14.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c6
nrm_pp r3.xyz, r0
add r0.xyz, r2, -c11
dp3 r0.w, r0, r0
rsq r1.z, r0.w
mul r0.w, r0.w, c11.w
texld r4, r0.w, s1
mad_pp r4.yzw, r0.xxyz, -r1.z, -r3.xxyz
dp3_pp r0.w, r4.yzww, r4.yzww
add r1.w, -r0.w, c15.y
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.w, c15.z, r0.w
mul_pp r4.yzw, r0.w, r4
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, c14.z, c14.w
nrm_pp r6.xyz, r5
dp3_pp r0.w, r6, r4.yzww
max_pp r1.w, r0.w, c15.x
texld_pp r5, r1, s5
texld_pp r7, r1, s4
add_pp r0.w, -r5.w, c14.x
add_pp r1.x, -r0.w, c14.x
mad_pp r1.x, r1.x, c16.x, c16.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c16.z
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c14.x
mul_pp r1.x, r1.x, c13.y
pow_pp r3.w, r1.w, r1.y
mul_pp r1.x, r1.x, r3.w
dp3_pp r1.y, r6, -r3
max_pp r3.x, r1.y, c15.x
mul_pp r1.y, r0.w, r0.w
mul_pp r1.w, r1.y, c13.w
mov r8.x, c14.x
mad_pp r1.y, r1.y, -c13.w, r8.x
mad_pp r3.y, r3.x, r1.y, r1.w
add_pp r3.x, -r3.x, c14.x
mul_pp r8.yzw, r0.xxyz, r1.z
texld r9, r0, s3
rcp r0.x, r1.z
mul r0.x, r0.x, c9.w
mad r0.x, r0.x, -c14.y, r9.x
cmp_pp r0.x, r0.x, r8.x, c10.x
mul r0.x, r0.x, r4.x
dp3_pp r0.y, r6, -r8.yzww
dp3_pp r0.z, -r8.yzww, r4.yzww
max_pp r1.z, r0.z, c15.x
max_pp r3.z, r0.y, c15.x
mad_pp r0.y, r3.z, r1.y, r1.w
mad r0.y, r0.y, r3.y, c15.w
rcp_pp r0.y, r0.y
mul_pp r0.y, r1.x, r0.y
mul_pp r0.y, r3.z, r0.y
mul_pp r0.y, r0.y, c13.x
max_pp r1.x, r0.y, c15.x
mov_pp r2.w, c14.x
dp4 r4.x, c3, r2
dp4 r4.y, c4, r2
dp4 r4.z, c5, r2
texld r2, r4, s2
mul r0.x, r0.x, r2.w
mul_pp r0.xyz, r0.x, c12
mul_pp r1.xyw, r0.xyzz, r1.x
add_pp r2.x, -r1.z, c14.x
mul_pp r1.z, r1.z, r1.z
dp2add_pp r0.w, r1.z, r0.w, c16.w
mul_pp r1.z, r2.x, r2.x
mul_pp r1.z, r1.z, r1.z
mul_pp r1.z, r2.x, r1.z
lrp_pp r2.xyz, r1.z, c14.x, r5
mul_pp r1.xyz, r1.xyww, r2
mul_pp r1.w, r3.x, r3.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r3.x, r1.w
mad_pp r1.w, r0.w, r1.w, c14.x
add_pp r2.x, -r3.z, c14.x
mul_pp r2.y, r2.x, r2.x
mul_pp r2.y, r2.y, r2.y
mul_pp r2.x, r2.x, r2.y
mad_pp r0.w, r0.w, r2.x, c14.x
mul_pp r0.w, r1.w, r0.w
mul_pp r0.w, r3.z, r0.w
mul_pp r0.xyz, r0.w, r0
mad_pp r0.xyz, r7, r0, r1
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, -c16.w

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" }
Matrix 12 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 21 [_LightColor]
Vector 20 [_LightPos]
Vector 18 [_LightShadowData]
Vector 16 [_ProjectionParams]
Vector 8 [_ShadowOffsets0]
Vector 9 [_ShadowOffsets1]
Vector 10 [_ShadowOffsets2]
Vector 11 [_ShadowOffsets3]
Vector 15 [_WorldSpaceCameraPos]
Vector 17 [_ZBufferParams]
Vector 22 [unity_LightGammaCorrectionConsts]
Vector 19 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c23, 1, 0.25, 0, -2
def c24, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c25, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
mov r0.x, c23.x
rcp r0.y, v1.z
mul r0.y, r0.y, c16.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
mad r1.z, c17.x, r2.x, c17.y
rcp r1.z, r1.z
mul r2.xyz, r0.yzww, r1.z
mov r2.w, c23.x
dp4 r3.x, c12, r2
dp4 r3.y, c13, r2
dp4 r3.z, c14, r2
mov r3.w, c23.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
dp4 r4.w, c3, r3
rcp r0.y, r4.w
mad r5, r4, r0.y, c8
texldp_pp r5, r5, s3
mad r6, r4, r0.y, c9
texldp_pp r6, r6, s3
mov_pp r5.y, r6.x
mad r6, r4, r0.y, c10
mad r4, r4, r0.y, c11
texldp_pp r4, r4, s3
mov_pp r5.w, r4.x
texldp_pp r4, r6, s3
mov_pp r5.z, r4.x
lrp_pp r4, r5, r0.x, c18.x
dp4_pp r0.y, r4, c23.y
add r2.xyw, r3.xyzz, -c19.xyzz
dp3 r0.z, r2.xyww, r2.xyww
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r1.z, r0.z
mad r0.z, c19.w, r0.z, r2.z
mad_sat r0.z, r0.z, c18.z, c18.w
add_sat_pp r0.y, r0.z, r0.y
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r2.z, c6, r3
dp4 r2.w, c7, r3
texldp r4, r2, s2
add r2.xyz, -r3, c20
add r3.xyz, r3, -c15
nrm_pp r4.xyz, r3
dp3 r0.z, r2, r2
mul r0.w, r0.z, c20.w
rsq r0.z, r0.z
texld r3, r0.w, s1
mul r0.w, r3.x, r4.w
mul r0.y, r0.y, r0.w
mul_pp r3.xyz, r0.y, c21
cmp_pp r3.xyz, r2.w, c23.z, r3
mad_pp r5.xyz, r2, r0.z, -r4
mul_pp r0.yzw, r0.z, r2.xxyz
dp3_pp r1.z, r5, r5
add r1.w, -r1.z, c24.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c24.y, r1.z
mul_pp r2.xyz, r1.z, r5
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, -c23.w, -c23.x
nrm_pp r6.xyz, r5
dp3_pp r1.z, r6, r2
dp3_pp r1.w, r0.yzww, r2
dp3_pp r0.y, r6, r0.yzww
dp3_pp r0.z, r6, -r4
max_pp r2.x, r0.z, c23.z
max_pp r2.y, r0.y, c23.z
max_pp r0.y, r1.w, c23.z
max_pp r0.z, r1.z, c23.z
texld_pp r4, r1, s5
texld_pp r1, r1, s4
add_pp r0.w, -r4.w, c23.x
add_pp r1.w, -r0.w, c23.x
mad_pp r1.w, r1.w, c25.x, c25.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c24.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c23.x
mul_pp r1.w, r1.w, c22.y
pow_pp r3.w, r0.z, r2.z
mul_pp r0.z, r1.w, r3.w
mul_pp r1.w, r0.w, r0.w
mul_pp r2.z, r1.w, c22.w
mad_pp r0.x, r1.w, -c22.w, r0.x
mad_pp r1.w, r2.x, r0.x, r2.z
add_pp r2.x, -r2.x, c23.x
mad_pp r0.x, r2.y, r0.x, r2.z
mad r0.x, r0.x, r1.w, c24.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r0.z, r0.x
mul_pp r0.x, r2.y, r0.x
mul_pp r0.x, r0.x, c22.x
max_pp r1.w, r0.x, c23.z
mul_pp r5.xyz, r3, r1.w
add_pp r0.x, -r0.y, c23.x
mul_pp r0.yz, r0.xyxw, r0.xyxw
dp2add_pp r0.y, r0.y, r0.w, c25.z
mul_pp r0.z, r0.z, r0.z
mul_pp r0.x, r0.x, r0.z
lrp_pp r6.xyz, r0.x, c23.x, r4
mul_pp r0.xzw, r5.xyyz, r6.xyyz
mul_pp r1.w, r2.x, r2.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.x, r1.w
mad_pp r1.w, r0.y, r1.w, c23.x
add_pp r2.x, -r2.y, c23.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r0.y, r0.y, r2.x, c23.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r2.xyz, r0.y, r3
mad_pp r0.xyz, r1, r2, r0.xzww
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c25.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c11, 1, 0.0078125, -0.0078125, 0.970000029
def c12, 0.25, 2, -1, 0
def c13, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c14, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c8
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c8.w
texld r4, r0.x, s1
mad_pp r0.xzw, r2.xyyz, -r0.y, -r3.xyyz
dp3_pp r1.z, r0.xzww, r0.xzww
add r1.w, -r1.z, c13.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c13.y, r1.z
mul_pp r0.xzw, r0, r1.z
texld_pp r5, r1, s5
mad_pp r4.yzw, r5.xxyz, c12.y, c12.z
nrm_pp r5.xyz, r4.yzww
dp3_pp r1.z, r5, r0.xzww
max_pp r2.w, r1.z, c12.w
texld_pp r6, r1, s4
texld_pp r1, r1, s3
add_pp r1.w, -r6.w, c11.x
add_pp r3.w, -r1.w, c11.x
mad_pp r3.w, r3.w, c14.x, c14.y
log_pp r3.w, r3.w
rcp r3.w, r3.w
mul_pp r3.w, r3.w, c13.w
mul_pp r4.y, r3.w, r3.w
mad_pp r3.w, r3.w, r3.w, c11.x
mul_pp r3.w, r3.w, c10.y
pow_pp r5.w, r2.w, r4.y
mul_pp r2.w, r3.w, r5.w
dp3_pp r3.x, r5, -r3
max_pp r4.y, r3.x, c12.w
mul_pp r3.x, r1.w, r1.w
mul_pp r3.y, r3.x, c10.w
mov r7.x, c11.x
mad_pp r3.x, r3.x, -c10.w, r7.x
mad_pp r3.z, r4.y, r3.x, r3.y
add_pp r3.w, -r4.y, c11.x
mul_pp r4.yzw, r0.y, r2.xxyz
rcp r0.y, r0.y
mul r0.y, r0.y, c6.w
dp3_pp r5.x, r5, -r4.yzww
dp3_pp r0.x, -r4.yzww, r0.xzww
max_pp r4.y, r0.x, c12.w
max_pp r0.x, r5.x, c12.w
mad_pp r0.z, r0.x, r3.x, r3.y
mad r0.z, r0.z, r3.z, c13.z
rcp_pp r0.z, r0.z
mul_pp r0.z, r2.w, r0.z
mul_pp r0.z, r0.x, r0.z
mul_pp r0.z, r0.z, c10.x
max_pp r2.w, r0.z, c12.w
add r3.xyz, r2, c11.y
texld r5, r3, s2
add r3.xyz, r2, c11.zzyw
texld r8, r3, s2
mov r5.y, r8.x
add r3.xyz, r2, c11.zyzw
add r2.xyz, r2, c11.yzzw
texld r8, r2, s2
mov r5.w, r8.x
texld r8, r3, s2
mov r5.z, r8.x
mad r5, r0.y, -c11.w, r5
cmp_pp r5, r5, r7.x, c7.x
dp4_pp r0.y, r5, c12.x
mul r0.y, r0.y, r4.x
mul_pp r0.yzw, r0.y, c9.xxyz
mul_pp r2.xyz, r0.yzww, r2.w
add_pp r2.w, -r4.y, c11.x
mul_pp r3.x, r4.y, r4.y
dp2add_pp r1.w, r3.x, r1.w, c14.z
mul_pp r3.x, r2.w, r2.w
mul_pp r3.x, r3.x, r3.x
mul_pp r2.w, r2.w, r3.x
lrp_pp r3.xyz, r2.w, c11.x, r6
mul_pp r2.w, r3.w, r3.w
mul_pp r2.w, r2.w, r2.w
mul_pp r2, r3, r2
mad_pp r2.w, r1.w, r2.w, c11.x
add_pp r3.x, -r0.x, c11.x
mul_pp r3.y, r3.x, r3.x
mul_pp r3.y, r3.y, r3.y
mul_pp r3.x, r3.x, r3.y
mad_pp r1.w, r1.w, r3.x, c11.x
mul_pp r1.w, r2.w, r1.w
mul_pp r0.x, r0.x, r1.w
mul_pp r0.xyz, r0.x, r0.yzww
mad_pp r0.xyz, r1, r0, r2
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c14.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 13 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c14, 1, 0.0078125, -0.0078125, 0.970000029
def c15, 0.25, 2, -1, 0
def c16, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c17, 0.967999995, 0.0299999993, -0.5, 0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c14.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
mov r2.w, c14.x
dp4 r0.x, c3, r2
dp4 r0.y, c4, r2
dp4 r0.z, c5, r2
texld r0, r0, s2
add r0.xyz, r2, -c11
add r2.xyz, r2, -c6
nrm_pp r3.xyz, r2
add r2.xyz, r0, c14.y
texld r2, r2, s3
add r4.xyz, r0, c14.zzyw
texld r4, r4, s3
mov r2.y, r4.x
add r4.xyz, r0, c14.zyzw
texld r4, r4, s3
mov r2.z, r4.x
add r4.xyz, r0, c14.yzzw
texld r4, r4, s3
mov r2.w, r4.x
dp3 r1.z, r0, r0
rsq r1.w, r1.z
mul r1.z, r1.z, c11.w
texld r4, r1.z, s1
rcp r1.z, r1.w
mul r1.z, r1.z, c9.w
mad r2, r1.z, -c14.w, r2
mov r5.x, c14.x
cmp_pp r2, r2, r5.x, c10.x
dp4_pp r1.z, r2, c15.x
mul r1.z, r1.z, r4.x
mul r0.w, r0.w, r1.z
mul_pp r2.xyz, r0.w, c12
mad_pp r4.xyz, r0, -r1.w, -r3
mul_pp r0.xyz, r0, r1.w
dp3_pp r0.w, r4, r4
add r1.z, -r0.w, c16.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c16.y, r0.w
mul_pp r4.xyz, r0.w, r4
texld_pp r6, r1, s6
mad_pp r5.yzw, r6.xxyz, c15.y, c15.z
nrm_pp r6.xyz, r5.yzww
dp3_pp r0.w, r6, r4
dp3_pp r1.z, -r0, r4
dp3_pp r0.x, r6, -r0
dp3_pp r0.y, r6, -r3
max_pp r1.w, r0.y, c15.w
max_pp r2.w, r0.x, c15.w
max_pp r0.x, r1.z, c15.w
max_pp r1.z, r0.w, c15.w
texld_pp r3, r1, s5
texld_pp r4, r1, s4
add_pp r0.y, -r3.w, c14.x
add_pp r0.z, -r0.y, c14.x
mad_pp r0.z, r0.z, c17.x, c17.y
log_pp r0.z, r0.z
rcp r0.z, r0.z
mul_pp r0.z, r0.z, c16.w
mul_pp r0.w, r0.z, r0.z
mad_pp r0.z, r0.z, r0.z, c14.x
mul_pp r0.z, r0.z, c13.y
pow_pp r3.w, r1.z, r0.w
mul_pp r0.z, r0.z, r3.w
mul_pp r0.w, r0.y, r0.y
mul_pp r1.x, r0.w, c13.w
mad_pp r0.w, r0.w, -c13.w, r5.x
mad_pp r1.y, r1.w, r0.w, r1.x
add_pp r1.z, -r1.w, c14.x
mad_pp r0.w, r2.w, r0.w, r1.x
mad r0.w, r0.w, r1.y, c16.z
rcp_pp r0.w, r0.w
mul_pp r0.z, r0.z, r0.w
mul_pp r0.z, r2.w, r0.z
mul_pp r0.z, r0.z, c13.x
max_pp r1.x, r0.z, c15.w
mul_pp r1.xyw, r2.xyzz, r1.x
add_pp r0.z, -r0.x, c14.x
mul_pp r0.x, r0.x, r0.x
dp2add_pp r0.x, r0.x, r0.y, c17.z
mul_pp r0.y, r0.z, r0.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r0.z, r0.y
lrp_pp r5.xyz, r0.y, c14.x, r3
mul_pp r0.yzw, r1.xxyw, r5.xxyz
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.x, r1.x, c14.x
add_pp r1.y, -r2.w, c14.x
mul_pp r1.z, r1.y, r1.y
mul_pp r1.z, r1.z, r1.z
mul_pp r1.y, r1.y, r1.z
mad_pp r0.x, r0.x, r1.y, c14.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r2.w, r0.x
mul_pp r1.xyz, r0.x, r2
mad_pp r0.xyz, r4, r1, r0.yzww
exp_pp oC0.x, -r0.x
exp_pp oC0.y, -r0.y
exp_pp oC0.z, -r0.z
mov_pp oC0.w, c17.w

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_OFF" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Vector 7 [_LightColor]
Vector 6 [_LightPos]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c9, 1, 2, -1, 0
def c10, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c11, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c9.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c6
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c6.w
texld r4, r0.x, s1
mul_pp r0.xzw, r4.x, c7.xyyz
mad_pp r4.xyz, r2, -r0.y, -r3
mul_pp r2.xyz, r0.y, r2
dp3_pp r0.y, r4, r4
add r1.z, -r0.y, c10.x
rsq_pp r0.y, r0.y
cmp_pp r0.y, r1.z, c10.y, r0.y
mul_pp r4.xyz, r0.y, r4
texld_pp r5, r1, s4
mad_pp r5.xyz, r5, c9.y, c9.z
nrm_pp r6.xyz, r5
dp3_pp r0.y, r6, r4
dp3_pp r1.z, -r2, r4
dp3_pp r1.w, r6, -r2
dp3_pp r2.x, r6, -r3
max_pp r3.x, r2.x, c9.w
max_pp r2.x, r1.w, c9.w
max_pp r2.y, r1.z, c9.w
max_pp r1.z, r0.y, c9.w
texld_pp r4, r1, s3
texld_pp r5, r1, s2
add_pp r0.y, -r4.w, c9.x
add_pp r1.x, -r0.y, c9.x
mad_pp r1.x, r1.x, c11.x, c11.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c10.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c9.x
mul_pp r1.x, r1.x, c8.y
pow_pp r2.z, r1.z, r1.y
mul_pp r1.x, r1.x, r2.z
mul_pp r1.y, r0.y, r0.y
mul_pp r1.z, r1.y, c8.w
mov r6.x, c9.x
mad_pp r1.y, r1.y, -c8.w, r6.x
mad_pp r1.w, r3.x, r1.y, r1.z
add_pp r2.z, -r3.x, c9.x
mad_pp r1.y, r2.x, r1.y, r1.z
mad r1.y, r1.y, r1.w, c10.z
rcp_pp r1.y, r1.y
mul_pp r1.x, r1.x, r1.y
mul_pp r1.x, r2.x, r1.x
mul_pp r1.x, r1.x, c8.x
max_pp r2.w, r1.x, c9.w
mul_pp r1.xyz, r0.xzww, r2.w
add_pp r1.w, -r2.y, c9.x
mul_pp r2.y, r2.y, r2.y
dp2add_pp r0.y, r2.y, r0.y, c11.z
mul_pp r2.y, r1.w, r1.w
mul_pp r2.y, r2.y, r2.y
mul_pp r1.w, r1.w, r2.y
lrp_pp r3.xyz, r1.w, c9.x, r4
mul_pp r1.xyz, r1, r3
mul_pp r1.w, r2.z, r2.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.z, r1.w
mad_pp r1.w, r0.y, r1.w, c9.x
add_pp r2.y, -r2.x, c9.x
mul_pp r2.z, r2.y, r2.y
mul_pp r2.z, r2.z, r2.z
mul_pp r2.y, r2.y, r2.z
mad_pp r0.y, r0.y, r2.y, c9.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.x, r0.y
mul_pp r0.xyz, r0.y, r0.xzww
mad_pp oC0.xyz, r5, r0, r1
mov_pp oC0.w, c9.x

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_OFF" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Vector 7 [_LightColor]
Vector 6 [_LightDir]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 8 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraGBufferTexture0] 2D 1
SetTexture 2 [_CameraGBufferTexture1] 2D 2
SetTexture 3 [_CameraGBufferTexture2] 2D 3
"ps_3_0
def c9, 1, 2, -1, 0
def c10, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c11, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c9.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mad_pp r2.xyz, r0, -r0.w, -c6
mul_pp r0.xyz, r0.w, r0
dp3_pp r0.w, r2, r2
add r1.z, -r0.w, c10.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c10.y, r0.w
mul_pp r2.xyz, r0.w, r2
texld_pp r3, r1, s3
mad_pp r3.xyz, r3, c9.y, c9.z
nrm_pp r4.xyz, r3
dp3_pp r0.w, r4, r2
dp3_pp r1.z, -c6, r2
max_pp r2.x, r1.z, c9.w
max_pp r1.z, r0.w, c9.w
texld_pp r3, r1, s2
texld_pp r5, r1, s1
add_pp r0.w, -r3.w, c9.x
add_pp r1.x, -r0.w, c9.x
mad_pp r1.x, r1.x, c11.x, c11.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c10.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c9.x
mul_pp r1.x, r1.x, c8.y
pow_pp r2.y, r1.z, r1.y
mul_pp r1.x, r1.x, r2.y
dp3_pp r0.x, r4, -r0
dp3_pp r0.y, r4, -c6
max_pp r1.y, r0.y, c9.w
max_pp r1.z, r0.x, c9.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c8.w
mov r4.x, c9.x
mad_pp r0.x, r0.x, -c8.w, r4.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c9.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c10.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c8.x
mul_pp r2.yzw, r0.x, c7.xxyz
cmp_pp r0.xyz, r0.x, r2.yzww, c9.w
add_pp r1.x, -r2.x, c9.x
mul_pp r1.w, r2.x, r2.x
dp2add_pp r0.w, r1.w, r0.w, c11.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r2.xyz, r1.x, c9.x, r3
mul_pp r0.xyz, r0, r2
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c9.x
add_pp r1.z, -r1.y, c9.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c9.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r1.xyz, r0.w, c7
mad_pp oC0.xyz, r5, r1, r0
mov_pp oC0.w, c9.x

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_OFF" "UNITY_HDR_ON" }
Matrix 4 [_CameraToWorld] 3
Matrix 0 [_LightMatrix0]
Vector 11 [_LightColor]
Vector 10 [_LightPos]
Vector 8 [_ProjectionParams]
Vector 7 [_WorldSpaceCameraPos]
Vector 9 [_ZBufferParams]
Vector 12 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c13, 1, 0, 2, -1
def c14, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c15, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v0.w
mul r0.xy, r0.x, v0
texld_pp r1, r0, s4
add_pp r0.z, -r1.w, c13.x
add_pp r0.w, -r0.z, c13.x
mad_pp r0.w, r0.w, c15.x, c15.y
log_pp r0.w, r0.w
rcp r0.w, r0.w
mul_pp r0.w, r0.w, c14.w
mul_pp r1.w, r0.w, r0.w
mad_pp r0.w, r0.w, r0.w, c13.x
mul_pp r0.w, r0.w, c12.y
texld_pp r2, r0, s5
mad_pp r2.xyz, r2, c13.z, c13.w
nrm_pp r3.xyz, r2
texld r2, r0, s0
texld_pp r4, r0, s3
mad r0.x, c9.x, r2.x, c9.y
rcp r0.x, r0.x
rcp r0.y, v1.z
mul r0.y, r0.y, c8.z
mul r2.xyz, r0.y, v1
mul r2.xyz, r0.x, r2
mov r2.w, c13.x
dp4 r5.x, c4, r2
dp4 r5.y, c5, r2
dp4 r5.z, c6, r2
add r2.xyz, r5, -c7
nrm_pp r6.xyz, r2
add r2.xyz, -r5, c10
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c10.w
texld r7, r0.x, s1
mad_pp r7.yzw, r2.xxyz, r0.y, -r6.xxyz
dp3_pp r0.x, r3, -r6
max_pp r2.w, r0.x, c13.y
mul_pp r2.xyz, r0.y, r2
dp3_pp r0.x, r7.yzww, r7.yzww
add r0.y, -r0.x, c14.x
rsq_pp r0.x, r0.x
cmp_pp r0.x, r0.y, c14.y, r0.x
mul_pp r6.xyz, r0.x, r7.yzww
dp3_pp r0.x, r3, r6
dp3_pp r0.y, r3, r2
dp3_pp r2.x, r2, r6
max_pp r3.x, r2.x, c13.y
max_pp r2.x, r0.y, c13.y
max_pp r2.y, r0.x, c13.y
pow_pp r0.x, r2.y, r1.w
mul_pp r0.xy, r0.wzzw, r0.xzzw
mul_pp r0.w, r0.y, c12.w
mov r6.x, c13.x
mad_pp r0.y, r0.y, -c12.w, r6.x
mad_pp r1.w, r2.w, r0.y, r0.w
mad_pp r0.y, r2.x, r0.y, r0.w
mad r0.y, r0.y, r1.w, c14.z
rcp_pp r0.y, r0.y
mul_pp r0.x, r0.x, r0.y
mul_pp r0.x, r2.x, r0.x
mul_pp r0.x, r0.x, c12.x
max_pp r1.w, r0.x, c13.y
add_pp r0.x, -r2.w, c13.x
mov r5.w, c13.x
dp4 r6.x, c0, r5
dp4 r6.y, c1, r5
dp4 r6.z, c2, r5
dp4 r6.w, c3, r5
texldp r5, r6, s2
mul r0.y, r7.x, r5.w
mul_pp r2.yzw, r0.y, c11.xxyz
cmp_pp r2.yzw, r6.w, c13.y, r2
mul_pp r3.yzw, r1.w, r2
add_pp r0.y, -r3.x, c13.x
mul_pp r0.w, r3.x, r3.x
dp2add_pp r0.z, r0.w, r0.z, c15.z
mul_pp r0.w, r0.y, r0.y
mul_pp r0.w, r0.w, r0.w
mul_pp r0.y, r0.y, r0.w
lrp_pp r5.xyz, r0.y, c13.x, r1
mul_pp r1.xyz, r3.yzww, r5
mul_pp r0.y, r0.x, r0.x
mul_pp r0.y, r0.y, r0.y
mul_pp r0.x, r0.x, r0.y
mad_pp r0.x, r0.z, r0.x, c13.x
add_pp r0.y, -r2.x, c13.x
mul_pp r0.w, r0.y, r0.y
mul_pp r0.w, r0.w, r0.w
mul_pp r0.y, r0.y, r0.w
mad_pp r0.y, r0.z, r0.y, c13.x
mul_pp r0.x, r0.x, r0.y
mul_pp r0.x, r2.x, r0.x
mul_pp r0.xyz, r0.x, r2.yzww
mad_pp oC0.xyz, r4, r0, r1
mov_pp oC0.w, c13.x

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_OFF" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 10 [_LightColor]
Vector 9 [_LightPos]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 11 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c12, 1, 2, -1, 0
def c13, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c14, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c12.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c6
nrm_pp r3.xyz, r0
add r0.xyz, r2, -c9
dp3 r0.w, r0, r0
rsq r1.z, r0.w
mul r0.w, r0.w, c9.w
texld r4, r0.w, s1
mad_pp r4.yzw, r0.xxyz, -r1.z, -r3.xxyz
mul_pp r0.xyz, r0, r1.z
dp3_pp r0.w, r4.yzww, r4.yzww
add r1.z, -r0.w, c13.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c13.y, r0.w
mul_pp r4.yzw, r0.w, r4
texld_pp r5, r1, s5
mad_pp r5.xyz, r5, c12.y, c12.z
nrm_pp r6.xyz, r5
dp3_pp r0.w, r6, r4.yzww
dp3_pp r1.z, -r0, r4.yzww
dp3_pp r0.x, r6, -r0
dp3_pp r0.y, r6, -r3
max_pp r1.w, r0.y, c12.w
max_pp r3.x, r0.x, c12.w
max_pp r0.x, r1.z, c12.w
max_pp r1.z, r0.w, c12.w
texld_pp r5, r1, s4
texld_pp r6, r1, s3
add_pp r0.y, -r5.w, c12.x
add_pp r0.z, -r0.y, c12.x
mad_pp r0.z, r0.z, c14.x, c14.y
log_pp r0.z, r0.z
rcp r0.z, r0.z
mul_pp r0.z, r0.z, c13.w
mul_pp r0.w, r0.z, r0.z
mad_pp r0.z, r0.z, r0.z, c12.x
mul_pp r0.z, r0.z, c11.y
pow_pp r3.y, r1.z, r0.w
mul_pp r0.z, r0.z, r3.y
mul_pp r0.w, r0.y, r0.y
mul_pp r1.x, r0.w, c11.w
mov r7.x, c12.x
mad_pp r0.w, r0.w, -c11.w, r7.x
mad_pp r1.y, r1.w, r0.w, r1.x
add_pp r1.z, -r1.w, c12.x
mad_pp r0.w, r3.x, r0.w, r1.x
mad r0.w, r0.w, r1.y, c13.z
rcp_pp r0.w, r0.w
mul_pp r0.z, r0.z, r0.w
mul_pp r0.z, r3.x, r0.z
mul_pp r0.z, r0.z, c11.x
max_pp r1.x, r0.z, c12.w
mov r2.w, c12.x
dp4 r7.x, c3, r2
dp4 r7.y, c4, r2
dp4 r7.z, c5, r2
texld r2, r7, s2
mul r0.z, r2.w, r4.x
mul_pp r2.xyz, r0.z, c10
mul_pp r1.xyw, r1.x, r2.xyzz
add_pp r0.z, -r0.x, c12.x
mul_pp r0.x, r0.x, r0.x
dp2add_pp r0.x, r0.x, r0.y, c14.z
mul_pp r0.y, r0.z, r0.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r0.z, r0.y
lrp_pp r3.yzw, r0.y, c12.x, r5.xxyz
mul_pp r0.yzw, r1.xxyw, r3
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.x, r1.x, c12.x
add_pp r1.y, -r3.x, c12.x
mul_pp r1.z, r1.y, r1.y
mul_pp r1.z, r1.z, r1.z
mul_pp r1.y, r1.y, r1.z
mad_pp r0.x, r0.x, r1.y, c12.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r3.x, r0.x
mul_pp r1.xyz, r0.x, r2
mad_pp oC0.xyz, r6, r1, r0.yzww
mov_pp oC0.w, c12.x

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_OFF" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c11, 1, 2, -1, 0
def c12, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c13, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c5
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mad_pp r3.xyz, r0, -r0.w, -c8
mul_pp r0.xyz, r0.w, r0
dp3_pp r0.w, r3, r3
add r1.z, -r0.w, c12.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c12.y, r0.w
mul_pp r3.xyz, r0.w, r3
texld_pp r4, r1, s4
mad_pp r4.xyz, r4, c11.y, c11.z
nrm_pp r5.xyz, r4
dp3_pp r0.w, r5, r3
dp3_pp r1.z, -c8, r3
max_pp r3.x, r1.z, c11.w
max_pp r1.z, r0.w, c11.w
texld_pp r4, r1, s3
texld_pp r6, r1, s2
add_pp r0.w, -r4.w, c11.x
add_pp r1.x, -r0.w, c11.x
mad_pp r1.x, r1.x, c13.x, c13.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c12.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c11.x
mul_pp r1.x, r1.x, c10.y
pow_pp r3.y, r1.z, r1.y
mul_pp r1.x, r1.x, r3.y
dp3_pp r0.x, r5, -r0
dp3_pp r0.y, r5, -c8
max_pp r1.y, r0.y, c11.w
max_pp r1.z, r0.x, c11.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c10.w
mov r5.x, c11.x
mad_pp r0.x, r0.x, -c10.w, r5.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c11.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c12.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c10.x
max_pp r1.x, r0.x, c11.w
mov r2.w, c11.x
dp4 r0.x, c3, r2
dp4 r0.y, c4, r2
texld r2, r0, s1
mul_pp r0.xyz, r2.w, c9
mul_pp r2.xyz, r0, r1.x
add_pp r1.x, -r3.x, c11.x
mul_pp r1.w, r3.x, r3.x
dp2add_pp r0.w, r1.w, r0.w, c13.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r3.xyz, r1.x, c11.x, r4
mul_pp r2.xyz, r2, r3
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c11.x
add_pp r1.z, -r1.y, c11.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c11.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r0.xyz, r0.w, r0
mad_pp oC0.xyz, r6, r0, r2
mov_pp oC0.w, c11.x

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_NATIVE" "UNITY_HDR_ON" }
Matrix 8 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 17 [_LightColor]
Vector 16 [_LightPos]
Vector 14 [_LightShadowData]
Vector 12 [_ProjectionParams]
Vector 11 [_WorldSpaceCameraPos]
Vector 13 [_ZBufferParams]
Vector 18 [unity_LightGammaCorrectionConsts]
Vector 15 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c19, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c20, 0.967999995, 0.0299999993, -0.5, 0
def c21, 1, 0, 2, -1
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
mov r0.x, c21.x
rcp r0.y, v1.z
mul r0.y, r0.y, c12.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
mad r1.z, c13.x, r2.x, c13.y
rcp r1.z, r1.z
mul r2.xyz, r0.yzww, r1.z
mov r2.w, c21.x
dp4 r3.x, c8, r2
dp4 r3.y, c9, r2
dp4 r3.z, c10, r2
mov r3.w, c21.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
dp4 r4.w, c3, r3
texldp_pp r4, r4, s3
lrp_pp r1.w, r4.x, r0.x, c14.x
add r2.xyw, r3.xyzz, -c15.xyzz
dp3 r0.y, r2.xyww, r2.xyww
rsq r0.y, r0.y
rcp r0.y, r0.y
mad r0.y, r0.w, -r1.z, r0.y
mad r0.y, c15.w, r0.y, r2.z
mad_sat r0.y, r0.y, c14.z, c14.w
add_sat_pp r0.y, r0.y, r1.w
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r2.z, c6, r3
dp4 r2.w, c7, r3
texldp r4, r2, s2
add r2.xyz, -r3, c16
add r3.xyz, r3, -c11
nrm_pp r4.xyz, r3
dp3 r0.z, r2, r2
mul r0.w, r0.z, c16.w
rsq r0.z, r0.z
texld r3, r0.w, s1
mul r0.w, r3.x, r4.w
mul r0.y, r0.y, r0.w
mul_pp r3.xyz, r0.y, c17
cmp_pp r3.xyz, r2.w, c21.y, r3
mad_pp r5.xyz, r2, r0.z, -r4
mul_pp r0.yzw, r0.z, r2.xxyz
dp3_pp r1.z, r5, r5
add r1.w, -r1.z, c19.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c19.y, r1.z
mul_pp r2.xyz, r1.z, r5
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, c21.z, c21.w
nrm_pp r6.xyz, r5
dp3_pp r1.z, r6, r2
dp3_pp r1.w, r0.yzww, r2
dp3_pp r0.y, r6, r0.yzww
dp3_pp r0.z, r6, -r4
max_pp r2.x, r0.z, c21.y
max_pp r2.y, r0.y, c21.y
max_pp r0.y, r1.w, c21.y
max_pp r0.z, r1.z, c21.y
texld_pp r4, r1, s5
texld_pp r1, r1, s4
add_pp r0.w, -r4.w, c21.x
add_pp r1.w, -r0.w, c21.x
mad_pp r1.w, r1.w, c20.x, c20.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c19.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c21.x
mul_pp r1.w, r1.w, c18.y
pow_pp r3.w, r0.z, r2.z
mul_pp r0.z, r1.w, r3.w
mul_pp r1.w, r0.w, r0.w
mul_pp r2.z, r1.w, c18.w
mad_pp r0.x, r1.w, -c18.w, r0.x
mad_pp r1.w, r2.x, r0.x, r2.z
add_pp r2.x, -r2.x, c21.x
mad_pp r0.x, r2.y, r0.x, r2.z
mad r0.x, r0.x, r1.w, c19.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r0.z, r0.x
mul_pp r0.x, r2.y, r0.x
mul_pp r0.x, r0.x, c18.x
max_pp r1.w, r0.x, c21.y
mul_pp r5.xyz, r3, r1.w
add_pp r0.x, -r0.y, c21.x
mul_pp r0.yz, r0.xyxw, r0.xyxw
dp2add_pp r0.y, r0.y, r0.w, c20.z
mul_pp r0.z, r0.z, r0.z
mul_pp r0.x, r0.x, r0.z
lrp_pp r6.xyz, r0.x, c21.x, r4
mul_pp r0.xzw, r5.xyyz, r6.xyyz
mul_pp r1.w, r2.x, r2.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.x, r1.w
mad_pp r1.w, r0.y, r1.w, c21.x
add_pp r2.x, -r2.y, c21.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r0.y, r0.y, r2.x, c21.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r2.xyz, r0.y, r3
mad_pp oC0.xyz, r1, r2, r0.xzww
mov_pp oC0.w, c21.x

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL" "SHADOWS_SCREEN" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightDir]
Vector 6 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
Vector 7 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
SetTexture 2 [_CameraGBufferTexture0] 2D 2
SetTexture 3 [_CameraGBufferTexture1] 2D 3
SetTexture 4 [_CameraGBufferTexture2] 2D 4
"ps_3_0
def c11, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c12, 1, 2, -1, 0
def c13, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov_pp r2.w, c12.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c3.xyzz
add r3.xyz, r3, -c7
dp3 r0.x, r3, r3
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c7.w, r0.x, r2.z
mad_sat r0.x, r0.x, c6.z, c6.w
dp3 r0.y, r2.xyww, r2.xyww
rsq r0.y, r0.y
mad_pp r3.xyz, r2.xyww, -r0.y, -c8
mul_pp r0.yzw, r0.y, r2.xxyw
dp3_pp r1.z, r3, r3
add r1.w, -r1.z, c11.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c11.y, r1.z
mul_pp r2.xyz, r1.z, r3
texld_pp r3, r1, s4
mad_pp r3.xyz, r3, c12.y, c12.z
nrm_pp r4.xyz, r3
dp3_pp r1.z, r4, r2
dp3_pp r1.w, -c8, r2
max_pp r2.x, r1.w, c12.w
max_pp r2.y, r1.z, c12.w
texld_pp r3, r1, s3
add_pp r1.z, -r3.w, c12.x
add_pp r1.w, -r1.z, c12.x
mad_pp r1.w, r1.w, c13.x, c13.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c11.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c12.x
mul_pp r1.w, r1.w, c10.y
pow_pp r3.w, r2.y, r2.z
mul_pp r1.w, r1.w, r3.w
dp3_pp r0.y, r4, -r0.yzww
dp3_pp r0.z, r4, -c8
max_pp r2.y, r0.z, c12.w
max_pp r2.z, r0.y, c12.w
mul_pp r0.y, r1.z, r1.z
mul_pp r0.z, r0.y, c10.w
mov r4.x, c12.x
mad_pp r0.y, r0.y, -c10.w, r4.x
mad_pp r0.w, r2.z, r0.y, r0.z
add_pp r2.z, -r2.z, c12.x
mad_pp r0.y, r2.y, r0.y, r0.z
mad r0.y, r0.y, r0.w, c11.z
rcp_pp r0.y, r0.y
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r0.y, r0.y, c10.x
texld r4, r1, s1
texld_pp r5, r1, s2
add_sat_pp r0.x, r0.x, r4.x
mul_pp r0.xzw, r0.x, c9.xyyz
mul_pp r1.xyw, r0.xzzw, r0.y
cmp_pp r1.xyw, r0.y, r1, c12.w
add_pp r0.y, -r2.x, c12.x
mul_pp r2.x, r2.x, r2.x
dp2add_pp r1.z, r2.x, r1.z, c13.z
mul_pp r2.x, r0.y, r0.y
mul_pp r2.x, r2.x, r2.x
mul_pp r0.y, r0.y, r2.x
lrp_pp r4.xyz, r0.y, c12.x, r3
mul_pp r1.xyw, r1, r4.xyzz
mul_pp r0.y, r2.z, r2.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r2.z, r0.y
mad_pp r0.y, r1.z, r0.y, c12.x
add_pp r2.x, -r2.y, c12.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r1.z, r1.z, r2.x, c12.x
mul_pp r0.y, r0.y, r1.z
mul_pp r0.y, r2.y, r0.y
mul_pp r0.xyz, r0.y, r0.xzww
mad_pp oC0.xyz, r5, r0, r1.xyww
mov_pp oC0.w, c12.x

"
}
SubProgram "d3d9 " {
Keywords { "DIRECTIONAL_COOKIE" "SHADOWS_SCREEN" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 2
Vector 11 [_LightColor]
Vector 10 [_LightDir]
Vector 8 [_LightShadowData]
Vector 6 [_ProjectionParams]
Vector 5 [_WorldSpaceCameraPos]
Vector 7 [_ZBufferParams]
Vector 12 [unity_LightGammaCorrectionConsts]
Vector 9 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTexture0] 2D 1
SetTexture 2 [_ShadowMapTexture] 2D 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c13, 1, 2, -1, 0
def c14, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c15, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c6.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c7.x, r2.x, c7.y
rcp r0.w, r0.w
mul r2.xyz, r0.w, r0
mov_pp r2.w, c13.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
add r2.xyw, r3.xyzz, -c9.xyzz
dp3 r0.x, r2.xyww, r2.xyww
rsq r0.x, r0.x
rcp r0.x, r0.x
mad r0.x, r0.z, -r0.w, r0.x
mad r0.x, c9.w, r0.x, r2.z
mad_sat r0.x, r0.x, c8.z, c8.w
texld r2, r1, s2
add_sat_pp r0.x, r0.x, r2.x
mov_pp r3.w, c13.x
dp4 r2.x, c3, r3
dp4 r2.y, c4, r3
add r0.yzw, r3.xxyz, -c5.xxyz
texld r2, r2, s1
mul r0.x, r0.x, r2.w
mul_pp r2.xyz, r0.x, c11
dp3 r0.x, r0.yzww, r0.yzww
rsq r0.x, r0.x
mad_pp r3.xyz, r0.yzww, -r0.x, -c10
mul_pp r0.xyz, r0.x, r0.yzww
dp3_pp r0.w, r3, r3
add r1.z, -r0.w, c14.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c14.y, r0.w
mul_pp r3.xyz, r0.w, r3
texld_pp r4, r1, s5
mad_pp r4.xyz, r4, c13.y, c13.z
nrm_pp r5.xyz, r4
dp3_pp r0.w, r5, r3
dp3_pp r1.z, -c10, r3
max_pp r2.w, r1.z, c13.w
max_pp r1.z, r0.w, c13.w
texld_pp r3, r1, s4
texld_pp r4, r1, s3
add_pp r0.w, -r3.w, c13.x
add_pp r1.x, -r0.w, c13.x
mad_pp r1.x, r1.x, c15.x, c15.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c14.w
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c13.x
mul_pp r1.x, r1.x, c12.y
pow_pp r3.w, r1.z, r1.y
mul_pp r1.x, r1.x, r3.w
dp3_pp r0.x, r5, -r0
dp3_pp r0.y, r5, -c10
max_pp r1.y, r0.y, c13.w
max_pp r1.z, r0.x, c13.w
mul_pp r0.x, r0.w, r0.w
mul_pp r0.y, r0.x, c12.w
mov r5.x, c13.x
mad_pp r0.x, r0.x, -c12.w, r5.x
mad_pp r0.z, r1.z, r0.x, r0.y
add_pp r1.z, -r1.z, c13.x
mad_pp r0.x, r1.y, r0.x, r0.y
mad r0.x, r0.x, r0.z, c14.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r1.y, r0.x
mul_pp r0.x, r0.x, c12.x
max_pp r1.x, r0.x, c13.w
mul_pp r0.xyz, r2, r1.x
add_pp r1.x, -r2.w, c13.x
mul_pp r1.w, r2.w, r2.w
dp2add_pp r0.w, r1.w, r0.w, c15.z
mul_pp r1.w, r1.x, r1.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.x, r1.x, r1.w
lrp_pp r5.xyz, r1.x, c13.x, r3
mul_pp r0.xyz, r0, r5
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.w, r1.x, c13.x
add_pp r1.z, -r1.y, c13.x
mul_pp r1.w, r1.z, r1.z
mul_pp r1.w, r1.w, r1.w
mul_pp r1.z, r1.z, r1.w
mad_pp r0.w, r0.w, r1.z, c13.x
mul_pp r0.w, r1.x, r0.w
mul_pp r0.w, r1.y, r0.w
mul_pp r1.xyz, r0.w, r2
mad_pp oC0.xyz, r4, r1, r0
mov_pp oC0.w, c13.x

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c11, 1, 0.970000029, 2, -1
def c12, 0, 0.00100000005, 31.622776, 9.99999975e-005
def c13, 0.967999995, 0.0299999993, 10, -0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c8
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c8.w
texld r4, r0.x, s1
mad_pp r0.xzw, r2.xyyz, -r0.y, -r3.xyyz
dp3_pp r1.z, r0.xzww, r0.xzww
add r1.w, -r1.z, c12.y
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c12.z, r1.z
mul_pp r0.xzw, r0, r1.z
texld_pp r5, r1, s5
mad_pp r4.yzw, r5.xxyz, c11.z, c11.w
nrm_pp r5.xyz, r4.yzww
dp3_pp r1.z, r5, r0.xzww
max_pp r2.w, r1.z, c12.x
texld_pp r6, r1, s4
texld_pp r1, r1, s3
add_pp r1.w, -r6.w, c11.x
add_pp r3.w, -r1.w, c11.x
mad_pp r3.w, r3.w, c13.x, c13.y
log_pp r3.w, r3.w
rcp r3.w, r3.w
mul_pp r3.w, r3.w, c13.z
mul_pp r4.y, r3.w, r3.w
mad_pp r3.w, r3.w, r3.w, c11.x
mul_pp r3.w, r3.w, c10.y
pow_pp r5.w, r2.w, r4.y
mul_pp r2.w, r3.w, r5.w
dp3_pp r3.x, r5, -r3
max_pp r4.y, r3.x, c12.x
mul_pp r3.x, r1.w, r1.w
mul_pp r3.y, r3.x, c10.w
mov r7.x, c11.x
mad_pp r3.x, r3.x, -c10.w, r7.x
mad_pp r3.z, r4.y, r3.x, r3.y
add_pp r3.w, -r4.y, c11.x
mul_pp r4.yzw, r0.y, r2.xxyz
texld r8, r2, s2
rcp r0.y, r0.y
mul r0.y, r0.y, c6.w
mad r0.y, r0.y, -c11.y, r8.x
cmp_pp r0.y, r0.y, r7.x, c7.x
mul r0.y, r0.y, r4.x
mul_pp r2.xyz, r0.y, c9
dp3_pp r0.y, r5, -r4.yzww
dp3_pp r0.x, -r4.yzww, r0.xzww
max_pp r4.x, r0.x, c12.x
max_pp r4.y, r0.y, c12.x
mad_pp r0.x, r4.y, r3.x, r3.y
mad r0.x, r0.x, r3.z, c12.w
rcp_pp r0.x, r0.x
mul_pp r0.x, r2.w, r0.x
mul_pp r0.x, r4.y, r0.x
mul_pp r0.x, r0.x, c10.x
max_pp r2.w, r0.x, c12.x
mul_pp r0.xyz, r2, r2.w
add_pp r0.w, -r4.x, c11.x
mul_pp r2.w, r4.x, r4.x
dp2add_pp r1.w, r2.w, r1.w, c13.w
mul_pp r2.w, r0.w, r0.w
mul_pp r2.w, r2.w, r2.w
mul_pp r0.w, r0.w, r2.w
lrp_pp r3.xyz, r0.w, c11.x, r6
mul_pp r0.w, r3.w, r3.w
mul_pp r0.w, r0.w, r0.w
mul_pp r0, r3, r0
mad_pp r0.w, r1.w, r0.w, c11.x
add_pp r2.w, -r4.y, c11.x
mul_pp r3.x, r2.w, r2.w
mul_pp r3.x, r3.x, r3.x
mul_pp r2.w, r2.w, r3.x
mad_pp r1.w, r1.w, r2.w, c11.x
mul_pp r0.w, r0.w, r1.w
mul_pp r0.w, r4.y, r0.w
mul_pp r2.xyz, r0.w, r2
mad_pp oC0.xyz, r1, r2, r0
mov_pp oC0.w, c11.x

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 13 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c14, 1, 0.970000029, 2, -1
def c15, 0, 0.00100000005, 31.622776, 9.99999975e-005
def c16, 0.967999995, 0.0299999993, 10, -0.5
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c14.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c6
nrm_pp r3.xyz, r0
add r0.xyz, r2, -c11
dp3 r0.w, r0, r0
rsq r1.z, r0.w
mul r0.w, r0.w, c11.w
texld r4, r0.w, s1
mad_pp r4.yzw, r0.xxyz, -r1.z, -r3.xxyz
dp3_pp r0.w, r4.yzww, r4.yzww
add r1.w, -r0.w, c15.y
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.w, c15.z, r0.w
mul_pp r4.yzw, r0.w, r4
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, c14.z, c14.w
nrm_pp r6.xyz, r5
dp3_pp r0.w, r6, r4.yzww
max_pp r1.w, r0.w, c15.x
texld_pp r5, r1, s5
texld_pp r7, r1, s4
add_pp r0.w, -r5.w, c14.x
add_pp r1.x, -r0.w, c14.x
mad_pp r1.x, r1.x, c16.x, c16.y
log_pp r1.x, r1.x
rcp r1.x, r1.x
mul_pp r1.x, r1.x, c16.z
mul_pp r1.y, r1.x, r1.x
mad_pp r1.x, r1.x, r1.x, c14.x
mul_pp r1.x, r1.x, c13.y
pow_pp r3.w, r1.w, r1.y
mul_pp r1.x, r1.x, r3.w
dp3_pp r1.y, r6, -r3
max_pp r3.x, r1.y, c15.x
mul_pp r1.y, r0.w, r0.w
mul_pp r1.w, r1.y, c13.w
mov r8.x, c14.x
mad_pp r1.y, r1.y, -c13.w, r8.x
mad_pp r3.y, r3.x, r1.y, r1.w
add_pp r3.x, -r3.x, c14.x
mul_pp r8.yzw, r0.xxyz, r1.z
texld r9, r0, s3
rcp r0.x, r1.z
mul r0.x, r0.x, c9.w
mad r0.x, r0.x, -c14.y, r9.x
cmp_pp r0.x, r0.x, r8.x, c10.x
mul r0.x, r0.x, r4.x
dp3_pp r0.y, r6, -r8.yzww
dp3_pp r0.z, -r8.yzww, r4.yzww
max_pp r1.z, r0.z, c15.x
max_pp r3.z, r0.y, c15.x
mad_pp r0.y, r3.z, r1.y, r1.w
mad r0.y, r0.y, r3.y, c15.w
rcp_pp r0.y, r0.y
mul_pp r0.y, r1.x, r0.y
mul_pp r0.y, r3.z, r0.y
mul_pp r0.y, r0.y, c13.x
max_pp r1.x, r0.y, c15.x
mov_pp r2.w, c14.x
dp4 r4.x, c3, r2
dp4 r4.y, c4, r2
dp4 r4.z, c5, r2
texld r2, r4, s2
mul r0.x, r0.x, r2.w
mul_pp r0.xyz, r0.x, c12
mul_pp r1.xyw, r0.xyzz, r1.x
add_pp r2.x, -r1.z, c14.x
mul_pp r1.z, r1.z, r1.z
dp2add_pp r0.w, r1.z, r0.w, c16.w
mul_pp r1.z, r2.x, r2.x
mul_pp r1.z, r1.z, r1.z
mul_pp r1.z, r2.x, r1.z
lrp_pp r2.xyz, r1.z, c14.x, r5
mul_pp r1.xyz, r1.xyww, r2
mul_pp r1.w, r3.x, r3.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r3.x, r1.w
mad_pp r1.w, r0.w, r1.w, c14.x
add_pp r2.x, -r3.z, c14.x
mul_pp r2.y, r2.x, r2.x
mul_pp r2.y, r2.y, r2.y
mul_pp r2.x, r2.x, r2.y
mad_pp r0.w, r0.w, r2.x, c14.x
mul_pp r0.w, r1.w, r0.w
mul_pp r0.w, r3.z, r0.w
mul_pp r0.xyz, r0.w, r0
mad_pp oC0.xyz, r7, r0, r1
mov_pp oC0.w, c14.x

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "SHADOWS_DEPTH" "SHADOWS_SOFT" "SHADOWS_NATIVE" "UNITY_HDR_ON" }
Matrix 12 [_CameraToWorld] 3
Matrix 4 [_LightMatrix0]
Matrix 0 [unity_World2Shadow0]
Vector 21 [_LightColor]
Vector 20 [_LightPos]
Vector 18 [_LightShadowData]
Vector 16 [_ProjectionParams]
Vector 8 [_ShadowOffsets0]
Vector 9 [_ShadowOffsets1]
Vector 10 [_ShadowOffsets2]
Vector 11 [_ShadowOffsets3]
Vector 15 [_WorldSpaceCameraPos]
Vector 17 [_ZBufferParams]
Vector 22 [unity_LightGammaCorrectionConsts]
Vector 19 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] 2D 2
SetTexture 3 [_ShadowMapTexture] 2D 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c23, 1, 0.25, 0, -2
def c24, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c25, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
mov r0.x, c23.x
rcp r0.y, v1.z
mul r0.y, r0.y, c16.z
mul r0.yzw, r0.y, v1.xxyz
rcp r1.x, v0.w
mul r1.xy, r1.x, v0
texld r2, r1, s0
mad r1.z, c17.x, r2.x, c17.y
rcp r1.z, r1.z
mul r2.xyz, r0.yzww, r1.z
mov r2.w, c23.x
dp4 r3.x, c12, r2
dp4 r3.y, c13, r2
dp4 r3.z, c14, r2
mov r3.w, c23.x
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
dp4 r4.w, c3, r3
rcp r0.y, r4.w
mad r5, r4, r0.y, c8
texldp_pp r5, r5, s3
mad r6, r4, r0.y, c9
texldp_pp r6, r6, s3
mov_pp r5.y, r6.x
mad r6, r4, r0.y, c10
mad r4, r4, r0.y, c11
texldp_pp r4, r4, s3
mov_pp r5.w, r4.x
texldp_pp r4, r6, s3
mov_pp r5.z, r4.x
lrp_pp r4, r5, r0.x, c18.x
dp4_pp r0.y, r4, c23.y
add r2.xyw, r3.xyzz, -c19.xyzz
dp3 r0.z, r2.xyww, r2.xyww
rsq r0.z, r0.z
rcp r0.z, r0.z
mad r0.z, r0.w, -r1.z, r0.z
mad r0.z, c19.w, r0.z, r2.z
mad_sat r0.z, r0.z, c18.z, c18.w
add_sat_pp r0.y, r0.z, r0.y
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r2.z, c6, r3
dp4 r2.w, c7, r3
texldp r4, r2, s2
add r2.xyz, -r3, c20
add r3.xyz, r3, -c15
nrm_pp r4.xyz, r3
dp3 r0.z, r2, r2
mul r0.w, r0.z, c20.w
rsq r0.z, r0.z
texld r3, r0.w, s1
mul r0.w, r3.x, r4.w
mul r0.y, r0.y, r0.w
mul_pp r3.xyz, r0.y, c21
cmp_pp r3.xyz, r2.w, c23.z, r3
mad_pp r5.xyz, r2, r0.z, -r4
mul_pp r0.yzw, r0.z, r2.xxyz
dp3_pp r1.z, r5, r5
add r1.w, -r1.z, c24.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c24.y, r1.z
mul_pp r2.xyz, r1.z, r5
texld_pp r5, r1, s6
mad_pp r5.xyz, r5, -c23.w, -c23.x
nrm_pp r6.xyz, r5
dp3_pp r1.z, r6, r2
dp3_pp r1.w, r0.yzww, r2
dp3_pp r0.y, r6, r0.yzww
dp3_pp r0.z, r6, -r4
max_pp r2.x, r0.z, c23.z
max_pp r2.y, r0.y, c23.z
max_pp r0.y, r1.w, c23.z
max_pp r0.z, r1.z, c23.z
texld_pp r4, r1, s5
texld_pp r1, r1, s4
add_pp r0.w, -r4.w, c23.x
add_pp r1.w, -r0.w, c23.x
mad_pp r1.w, r1.w, c25.x, c25.y
log_pp r1.w, r1.w
rcp r1.w, r1.w
mul_pp r1.w, r1.w, c24.w
mul_pp r2.z, r1.w, r1.w
mad_pp r1.w, r1.w, r1.w, c23.x
mul_pp r1.w, r1.w, c22.y
pow_pp r3.w, r0.z, r2.z
mul_pp r0.z, r1.w, r3.w
mul_pp r1.w, r0.w, r0.w
mul_pp r2.z, r1.w, c22.w
mad_pp r0.x, r1.w, -c22.w, r0.x
mad_pp r1.w, r2.x, r0.x, r2.z
add_pp r2.x, -r2.x, c23.x
mad_pp r0.x, r2.y, r0.x, r2.z
mad r0.x, r0.x, r1.w, c24.z
rcp_pp r0.x, r0.x
mul_pp r0.x, r0.z, r0.x
mul_pp r0.x, r2.y, r0.x
mul_pp r0.x, r0.x, c22.x
max_pp r1.w, r0.x, c23.z
mul_pp r5.xyz, r3, r1.w
add_pp r0.x, -r0.y, c23.x
mul_pp r0.yz, r0.xyxw, r0.xyxw
dp2add_pp r0.y, r0.y, r0.w, c25.z
mul_pp r0.z, r0.z, r0.z
mul_pp r0.x, r0.x, r0.z
lrp_pp r6.xyz, r0.x, c23.x, r4
mul_pp r0.xzw, r5.xyyz, r6.xyyz
mul_pp r1.w, r2.x, r2.x
mul_pp r1.w, r1.w, r1.w
mul_pp r1.w, r2.x, r1.w
mad_pp r1.w, r0.y, r1.w, c23.x
add_pp r2.x, -r2.y, c23.x
mul_pp r2.z, r2.x, r2.x
mul_pp r2.z, r2.z, r2.z
mul_pp r2.x, r2.x, r2.z
mad_pp r0.y, r0.y, r2.x, c23.x
mul_pp r0.y, r1.w, r0.y
mul_pp r0.y, r2.y, r0.y
mul_pp r2.xyz, r0.y, r3
mad_pp oC0.xyz, r1, r2, r0.xzww
mov_pp oC0.w, c23.x

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "SHADOWS_CUBE" "SHADOWS_SOFT" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Vector 9 [_LightColor]
Vector 8 [_LightPos]
Vector 6 [_LightPositionRange]
Vector 7 [_LightShadowData]
Vector 4 [_ProjectionParams]
Vector 3 [_WorldSpaceCameraPos]
Vector 5 [_ZBufferParams]
Vector 10 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_ShadowMapTexture] CUBE 2
SetTexture 3 [_CameraGBufferTexture0] 2D 3
SetTexture 4 [_CameraGBufferTexture1] 2D 4
SetTexture 5 [_CameraGBufferTexture2] 2D 5
"ps_3_0
def c11, 1, 0.0078125, -0.0078125, 0.970000029
def c12, 0.25, 2, -1, 0
def c13, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c14, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
rcp r0.x, v1.z
mul r0.x, r0.x, c4.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c5.x, r2.x, c5.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov_pp r0.w, c11.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
add r0.xyz, r2, -c3
add r2.xyz, r2, -c8
nrm_pp r3.xyz, r0
dp3 r0.x, r2, r2
rsq r0.y, r0.x
mul r0.x, r0.x, c8.w
texld r4, r0.x, s1
mad_pp r0.xzw, r2.xyyz, -r0.y, -r3.xyyz
dp3_pp r1.z, r0.xzww, r0.xzww
add r1.w, -r1.z, c13.x
rsq_pp r1.z, r1.z
cmp_pp r1.z, r1.w, c13.y, r1.z
mul_pp r0.xzw, r0, r1.z
texld_pp r5, r1, s5
mad_pp r4.yzw, r5.xxyz, c12.y, c12.z
nrm_pp r5.xyz, r4.yzww
dp3_pp r1.z, r5, r0.xzww
max_pp r2.w, r1.z, c12.w
texld_pp r6, r1, s4
texld_pp r1, r1, s3
add_pp r1.w, -r6.w, c11.x
add_pp r3.w, -r1.w, c11.x
mad_pp r3.w, r3.w, c14.x, c14.y
log_pp r3.w, r3.w
rcp r3.w, r3.w
mul_pp r3.w, r3.w, c13.w
mul_pp r4.y, r3.w, r3.w
mad_pp r3.w, r3.w, r3.w, c11.x
mul_pp r3.w, r3.w, c10.y
pow_pp r5.w, r2.w, r4.y
mul_pp r2.w, r3.w, r5.w
dp3_pp r3.x, r5, -r3
max_pp r4.y, r3.x, c12.w
mul_pp r3.x, r1.w, r1.w
mul_pp r3.y, r3.x, c10.w
mov r7.x, c11.x
mad_pp r3.x, r3.x, -c10.w, r7.x
mad_pp r3.z, r4.y, r3.x, r3.y
add_pp r3.w, -r4.y, c11.x
mul_pp r4.yzw, r0.y, r2.xxyz
rcp r0.y, r0.y
mul r0.y, r0.y, c6.w
dp3_pp r5.x, r5, -r4.yzww
dp3_pp r0.x, -r4.yzww, r0.xzww
max_pp r4.y, r0.x, c12.w
max_pp r0.x, r5.x, c12.w
mad_pp r0.z, r0.x, r3.x, r3.y
mad r0.z, r0.z, r3.z, c13.z
rcp_pp r0.z, r0.z
mul_pp r0.z, r2.w, r0.z
mul_pp r0.z, r0.x, r0.z
mul_pp r0.z, r0.z, c10.x
max_pp r2.w, r0.z, c12.w
add r3.xyz, r2, c11.y
texld r5, r3, s2
add r3.xyz, r2, c11.zzyw
texld r8, r3, s2
mov r5.y, r8.x
add r3.xyz, r2, c11.zyzw
add r2.xyz, r2, c11.yzzw
texld r8, r2, s2
mov r5.w, r8.x
texld r8, r3, s2
mov r5.z, r8.x
mad r5, r0.y, -c11.w, r5
cmp_pp r5, r5, r7.x, c7.x
dp4_pp r0.y, r5, c12.x
mul r0.y, r0.y, r4.x
mul_pp r0.yzw, r0.y, c9.xxyz
mul_pp r2.xyz, r0.yzww, r2.w
add_pp r2.w, -r4.y, c11.x
mul_pp r3.x, r4.y, r4.y
dp2add_pp r1.w, r3.x, r1.w, c14.z
mul_pp r3.x, r2.w, r2.w
mul_pp r3.x, r3.x, r3.x
mul_pp r2.w, r2.w, r3.x
lrp_pp r3.xyz, r2.w, c11.x, r6
mul_pp r2.w, r3.w, r3.w
mul_pp r2.w, r2.w, r2.w
mul_pp r2, r3, r2
mad_pp r2.w, r1.w, r2.w, c11.x
add_pp r3.x, -r0.x, c11.x
mul_pp r3.y, r3.x, r3.x
mul_pp r3.y, r3.y, r3.y
mul_pp r3.x, r3.x, r3.y
mad_pp r1.w, r1.w, r3.x, c11.x
mul_pp r1.w, r2.w, r1.w
mul_pp r0.x, r0.x, r1.w
mul_pp r0.xyz, r0.x, r0.yzww
mad_pp oC0.xyz, r1, r0, r2
mov_pp oC0.w, c11.x

"
}
SubProgram "d3d9 " {
Keywords { "POINT_COOKIE" "SHADOWS_CUBE" "SHADOWS_SOFT" "UNITY_HDR_ON" }
Matrix 0 [_CameraToWorld] 3
Matrix 3 [_LightMatrix0] 3
Vector 12 [_LightColor]
Vector 11 [_LightPos]
Vector 9 [_LightPositionRange]
Vector 10 [_LightShadowData]
Vector 7 [_ProjectionParams]
Vector 6 [_WorldSpaceCameraPos]
Vector 8 [_ZBufferParams]
Vector 13 [unity_LightGammaCorrectionConsts]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_LightTextureB0] 2D 1
SetTexture 2 [_LightTexture0] CUBE 2
SetTexture 3 [_ShadowMapTexture] CUBE 3
SetTexture 4 [_CameraGBufferTexture0] 2D 4
SetTexture 5 [_CameraGBufferTexture1] 2D 5
SetTexture 6 [_CameraGBufferTexture2] 2D 6
"ps_3_0
def c14, 1, 0.0078125, -0.0078125, 0.970000029
def c15, 0.25, 2, -1, 0
def c16, 0.00100000005, 31.622776, 9.99999975e-005, 10
def c17, 0.967999995, 0.0299999993, -0.5, 0
dcl_texcoord v0.xyw
dcl_texcoord1 v1.xyz
dcl_2d s0
dcl_2d s1
dcl_cube s2
dcl_cube s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
rcp r0.x, v1.z
mul r0.x, r0.x, c7.z
mul r0.xyz, r0.x, v1
rcp r0.w, v0.w
mul r1.xy, r0.w, v0
texld r2, r1, s0
mad r0.w, c8.x, r2.x, c8.y
rcp r0.w, r0.w
mul r0.xyz, r0.w, r0
mov r0.w, c14.x
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
mov r2.w, c14.x
dp4 r0.x, c3, r2
dp4 r0.y, c4, r2
dp4 r0.z, c5, r2
texld r0, r0, s2
add r0.xyz, r2, -c11
add r2.xyz, r2, -c6
nrm_pp r3.xyz, r2
add r2.xyz, r0, c14.y
texld r2, r2, s3
add r4.xyz, r0, c14.zzyw
texld r4, r4, s3
mov r2.y, r4.x
add r4.xyz, r0, c14.zyzw
texld r4, r4, s3
mov r2.z, r4.x
add r4.xyz, r0, c14.yzzw
texld r4, r4, s3
mov r2.w, r4.x
dp3 r1.z, r0, r0
rsq r1.w, r1.z
mul r1.z, r1.z, c11.w
texld r4, r1.z, s1
rcp r1.z, r1.w
mul r1.z, r1.z, c9.w
mad r2, r1.z, -c14.w, r2
mov r5.x, c14.x
cmp_pp r2, r2, r5.x, c10.x
dp4_pp r1.z, r2, c15.x
mul r1.z, r1.z, r4.x
mul r0.w, r0.w, r1.z
mul_pp r2.xyz, r0.w, c12
mad_pp r4.xyz, r0, -r1.w, -r3
mul_pp r0.xyz, r0, r1.w
dp3_pp r0.w, r4, r4
add r1.z, -r0.w, c16.x
rsq_pp r0.w, r0.w
cmp_pp r0.w, r1.z, c16.y, r0.w
mul_pp r4.xyz, r0.w, r4
texld_pp r6, r1, s6
mad_pp r5.yzw, r6.xxyz, c15.y, c15.z
nrm_pp r6.xyz, r5.yzww
dp3_pp r0.w, r6, r4
dp3_pp r1.z, -r0, r4
dp3_pp r0.x, r6, -r0
dp3_pp r0.y, r6, -r3
max_pp r1.w, r0.y, c15.w
max_pp r2.w, r0.x, c15.w
max_pp r0.x, r1.z, c15.w
max_pp r1.z, r0.w, c15.w
texld_pp r3, r1, s5
texld_pp r4, r1, s4
add_pp r0.y, -r3.w, c14.x
add_pp r0.z, -r0.y, c14.x
mad_pp r0.z, r0.z, c17.x, c17.y
log_pp r0.z, r0.z
rcp r0.z, r0.z
mul_pp r0.z, r0.z, c16.w
mul_pp r0.w, r0.z, r0.z
mad_pp r0.z, r0.z, r0.z, c14.x
mul_pp r0.z, r0.z, c13.y
pow_pp r3.w, r1.z, r0.w
mul_pp r0.z, r0.z, r3.w
mul_pp r0.w, r0.y, r0.y
mul_pp r1.x, r0.w, c13.w
mad_pp r0.w, r0.w, -c13.w, r5.x
mad_pp r1.y, r1.w, r0.w, r1.x
add_pp r1.z, -r1.w, c14.x
mad_pp r0.w, r2.w, r0.w, r1.x
mad r0.w, r0.w, r1.y, c16.z
rcp_pp r0.w, r0.w
mul_pp r0.z, r0.z, r0.w
mul_pp r0.z, r2.w, r0.z
mul_pp r0.z, r0.z, c13.x
max_pp r1.x, r0.z, c15.w
mul_pp r1.xyw, r2.xyzz, r1.x
add_pp r0.z, -r0.x, c14.x
mul_pp r0.x, r0.x, r0.x
dp2add_pp r0.x, r0.x, r0.y, c17.z
mul_pp r0.y, r0.z, r0.z
mul_pp r0.y, r0.y, r0.y
mul_pp r0.y, r0.z, r0.y
lrp_pp r5.xyz, r0.y, c14.x, r3
mul_pp r0.yzw, r1.xxyw, r5.xxyz
mul_pp r1.x, r1.z, r1.z
mul_pp r1.x, r1.x, r1.x
mul_pp r1.x, r1.z, r1.x
mad_pp r1.x, r0.x, r1.x, c14.x
add_pp r1.y, -r2.w, c14.x
mul_pp r1.z, r1.y, r1.y
mul_pp r1.z, r1.z, r1.z
mul_pp r1.y, r1.y, r1.z
mad_pp r0.x, r0.x, r1.y, c14.x
mul_pp r0.x, r1.x, r0.x
mul_pp r0.x, r2.w, r0.x
mul_pp r1.xyz, r0.x, r2
mad_pp oC0.xyz, r4, r1, r0.yzww
mov_pp oC0.w, c14.x

"
}
}
 }
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  Stencil {
   Ref [_StencilNonBackground]
   ReadMask [_StencilNonBackground]
   CompFront Equal
   CompBack Equal
  }
  GpuProgramID 123303
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
"vs_3_0
dcl_position v0
dcl_texcoord v1
dcl_position o0
dcl_texcoord o1.xy
dp4 o0.x, c0, v0
dp4 o0.y, c1, v0
dp4 o0.z, c2, v0
dp4 o0.w, c3, v0
mov o1.xy, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_LightBuffer] 2D 0
"ps_3_0
dcl_texcoord v0.xy
dcl_2d s0
texld r0, v0, s0
log_pp r1.x, r0.x
log_pp r1.y, r0.y
log_pp r1.z, r0.z
log_pp r1.w, r0.w
mov_pp oC0, -r1

"
}
}
 }
}
Fallback Off
}
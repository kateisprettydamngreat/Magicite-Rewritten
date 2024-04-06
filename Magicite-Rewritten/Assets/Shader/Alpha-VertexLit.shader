//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Legacy Shaders/Transparent/VertexLit" {
Properties {
 _Color ("Main Color", Color) = (1,1,1,1)
 _SpecColor ("Spec Color", Color) = (1,1,1,0)
 _Emission ("Emissive Color", Color) = (0,0,0,0)
 _Shininess ("Shininess", Range(0.1,1)) = 0.7
 _MainTex ("Base (RGB) Trans (A)", 2D) = "white" { }
}
SubShader { 
 LOD 100
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "LIGHTMODE"="Vertex" "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Blend SrcAlpha OneMinusSrcAlpha
  ColorMask RGB
  GpuProgramID 218
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 23 [glstate_matrix_invtrans_modelview0] 3
Matrix 20 [glstate_matrix_modelview0] 3
Matrix 16 [glstate_matrix_mvp]
Vector 27 [_Color]
Vector 29 [_Emission]
Vector 31 [_MainTex_ST]
Float 30 [_Shininess]
Vector 28 [_SpecColor]
Vector 26 [glstate_lightmodel_ambient]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c32, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
mad r0, v0.xyzx, c32.xxxy, c32.yyyx
dp4 oPos.w, c19, r0
dp4 r1.x, c20, r0
dp4 r1.y, c21, r0
dp4 r1.z, c22, r0
nrm r2.xyz, r1
dp3 r1.x, c23, v1
dp3 r1.y, c24, v1
dp3 r1.z, c25, v1
nrm r3.xyz, r1
mov r1.yz, c32
mul r4.zw, r1.z, c30.x
mov r5.xyz, c27
mov r6.xyz, c26
mad r1.xzw, r5.xyyz, r6.xyyz, c29.xyyz
mov r5.xyz, r1.xzww
mov r6.xyz, c32.y
loop aL, i0
add r7.xyz, -r2, c8[aL]
nrm r8.xyz, r7
dp3 r2.w, r3, r8
max r4.xy, r2.w, c32.y
lit r7, r4
min r2.w, r7.z, c32.x
mul r2.w, r2.w, c32.w
dp3 r3.w, r3, c8[aL]
max r3.w, r3.w, c32.y
slt r4.x, c32.y, r3.w
mul r7.xyz, r2.w, c0[aL]
mad r6.xyz, r4.x, r7, r6
mul r7.xyz, r3.w, c27
mul r7.xyz, r7, c0[aL]
mul r7.xyz, r7, c32.w
min r7.xyz, r7, c32.x
add r5.xyz, r5, r7
endloop
max r2.xyz, r5, c32.y
max r2.w, r1.y, c27.w
min oD0, r2, c32.x
mul r1.xyz, r6, c28
max r1.xyz, r1, c32.y
min oD1.xyz, r1, c32.x
mad oT0.xy, v2, c31, c31.zwzw
dp4 oPos.x, c16, r0
dp4 oPos.y, c17, r0
dp4 oPos.z, c18, r0

"
}
SubProgram "d3d9 " {
Keywords { "POINT" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 31 [glstate_matrix_invtrans_modelview0] 3
Matrix 28 [glstate_matrix_modelview0] 3
Matrix 24 [glstate_matrix_mvp]
Vector 35 [_Color]
Vector 37 [_Emission]
Vector 39 [_MainTex_ST]
Float 38 [_Shininess]
Vector 36 [_SpecColor]
Vector 34 [glstate_lightmodel_ambient]
Vector 16 [unity_LightAtten0]
Vector 17 [unity_LightAtten1]
Vector 18 [unity_LightAtten2]
Vector 19 [unity_LightAtten3]
Vector 20 [unity_LightAtten4]
Vector 21 [unity_LightAtten5]
Vector 22 [unity_LightAtten6]
Vector 23 [unity_LightAtten7]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c40, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
dp3 r0.x, c31, v1
dp3 r0.y, c32, v1
dp3 r0.z, c33, v1
nrm r1.xyz, r0
mad r0, v0.xyzx, c40.xxxy, c40.yyyx
dp4 r2.x, c28, r0
dp4 r2.y, c29, r0
dp4 r2.z, c30, r0
mov r3.yz, c40
mul r4.zw, r3.z, c38.x
nrm r5.xyz, r2
mov r6.xyz, c35
mov r7.xyz, c34
mad r3.xzw, r6.xyyz, r7.xyyz, c37.xyyz
mov r6.xyz, r3.xzww
mov r7.xyz, c40.y
loop aL, i0
mad r8.xyz, r2, -c8[aL].w, c8[aL]
dp3 r1.w, r8, r8
rsq r2.w, r1.w
mad r9.xyz, r8, r2.w, -r5
nrm r10.xyz, r9
dp3 r5.w, r1, r10
max r4.xy, r5.w, c40.y
lit r9, r4
mul r4.x, c8[aL].w, c8[aL].w
slt r4.x, -r4.x, r4.x
slt r4.y, c16[aL].w, r1.w
mul r4.x, r4.y, r4.x
mul r1.w, r1.w, c16[aL].z
add r1.w, r1.w, c40.x
rcp r1.w, r1.w
mad r1.w, r4.x, -r1.w, r1.w
mul r1.w, r1.w, c40.w
min r4.x, r9.z, c40.x
mul r4.x, r1.w, r4.x
mul r8.xyz, r2.w, r8
dp3 r2.w, r1, r8
max r2.w, r2.w, c40.y
slt r4.y, c40.y, r2.w
mul r8.xyz, r4.x, c0[aL]
mad r7.xyz, r4.y, r8, r7
mul r8.xyz, r2.w, c35
mul r8.xyz, r8, c0[aL]
mul r8.xyz, r1.w, r8
min r8.xyz, r8, c40.x
add r6.xyz, r6, r8
endloop
dp4 oPos.w, c27, r0
max r1.xyz, r6, c40.y
max r1.w, r3.y, c35.w
min oD0, r1, c40.x
mul r1.xyz, r7, c36
max r1.xyz, r1, c40.y
min oD1.xyz, r1, c40.x
mad oT0.xy, v2, c39, c39.zwzw
dp4 oPos.x, c24, r0
dp4 oPos.y, c25, r0
dp4 oPos.z, c26, r0

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 39 [glstate_matrix_invtrans_modelview0] 3
Matrix 36 [glstate_matrix_modelview0] 3
Matrix 32 [glstate_matrix_mvp]
Vector 43 [_Color]
Vector 45 [_Emission]
Vector 47 [_MainTex_ST]
Float 46 [_Shininess]
Vector 44 [_SpecColor]
Vector 42 [glstate_lightmodel_ambient]
Vector 16 [unity_LightAtten0]
Vector 17 [unity_LightAtten1]
Vector 18 [unity_LightAtten2]
Vector 19 [unity_LightAtten3]
Vector 20 [unity_LightAtten4]
Vector 21 [unity_LightAtten5]
Vector 22 [unity_LightAtten6]
Vector 23 [unity_LightAtten7]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
Vector 24 [unity_SpotDirection0]
Vector 25 [unity_SpotDirection1]
Vector 26 [unity_SpotDirection2]
Vector 27 [unity_SpotDirection3]
Vector 28 [unity_SpotDirection4]
Vector 29 [unity_SpotDirection5]
Vector 30 [unity_SpotDirection6]
Vector 31 [unity_SpotDirection7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c48, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
dp3 r0.x, c39, v1
dp3 r0.y, c40, v1
dp3 r0.z, c41, v1
nrm r1.xyz, r0
mad r0, v0.xyzx, c48.xxxy, c48.yyyx
dp4 r2.x, c36, r0
dp4 r2.y, c37, r0
dp4 r2.z, c38, r0
mov r3.yz, c48
mul r4.zw, r3.z, c46.x
nrm r5.xyz, r2
mov r6.xyz, c43
mov r7.xyz, c42
mad r3.xzw, r6.xyyz, r7.xyyz, c45.xyyz
mov r6.xyz, r3.xzww
mov r7.xyz, c48.y
loop aL, i0
mad r8.xyz, r2, -c8[aL].w, c8[aL]
dp3 r1.w, r8, r8
rsq r2.w, r1.w
mad r9.xyz, r8, r2.w, -r5
nrm r10.xyz, r9
dp3 r5.w, r1, r10
max r4.xy, r5.w, c48.y
lit r9, r4
mul r4.x, c8[aL].w, c8[aL].w
slt r4.x, -r4.x, r4.x
slt r4.y, c16[aL].w, r1.w
mul r4.x, r4.y, r4.x
mul r1.w, r1.w, c16[aL].z
add r1.w, r1.w, c48.x
rcp r1.w, r1.w
mad r1.w, r4.x, -r1.w, r1.w
min r4.x, r9.z, c48.x
mul r8.xyz, r2.w, r8
dp3 r2.w, r1, r8
dp3 r4.y, r8, c24[aL]
max r4.y, r4.y, c48.y
add r4.y, r4.y, -c16[aL].x
mul r4.y, r4.y, c16[aL].y
max r4.y, r4.y, c48.y
min r4.y, r4.y, c48.x
mul r1.w, r1.w, r4.y
mul r1.w, r1.w, c48.w
max r2.w, r2.w, c48.y
slt r4.y, c48.y, r2.w
mul r4.x, r4.x, r1.w
mul r8.xyz, r4.x, c0[aL]
mad r7.xyz, r4.y, r8, r7
mul r8.xyz, r2.w, c43
mul r8.xyz, r8, c0[aL]
mul r8.xyz, r1.w, r8
min r8.xyz, r8, c48.x
add r6.xyz, r6, r8
endloop
dp4 oPos.w, c35, r0
max r1.xyz, r6, c48.y
max r1.w, r3.y, c43.w
min oD0, r1, c48.x
mul r1.xyz, r7, c44
max r1.xyz, r1, c48.y
min oD1.xyz, r1, c48.x
mad oT0.xy, v2, c47, c47.zwzw
dp4 oPos.x, c32, r0
dp4 oPos.y, c33, r0
dp4 oPos.z, c34, r0

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 23 [glstate_matrix_invtrans_modelview0] 3
Matrix 20 [glstate_matrix_modelview0] 3
Matrix 16 [glstate_matrix_mvp]
Vector 28 [_Color]
Vector 30 [_Emission]
Vector 32 [_MainTex_ST]
Float 31 [_Shininess]
Vector 29 [_SpecColor]
Vector 26 [glstate_lightmodel_ambient]
Vector 27 [unity_FogParams]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c33, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
mad r0, v0.xyzx, c33.xxxy, c33.yyyx
dp4 oPos.w, c19, r0
dp3 r1.x, c23, v1
dp3 r1.y, c24, v1
dp3 r1.z, c25, v1
nrm r2.xyz, r1
dp4 r1.x, c20, r0
dp4 r1.y, c21, r0
dp4 r1.z, c22, r0
dp3 r1.w, r1, r1
rsq r1.w, r1.w
mov r3.yz, c33
mul r4.zw, r3.z, c31.x
mov r5.xyz, c28
mov r6.xyz, c26
mad r3.xzw, r5.xyyz, r6.xyyz, c30.xyyz
mov r5.xyz, r3.xzww
mov r6.xyz, c33.y
loop aL, i0
mad r7.xyz, r1, -r1.w, c8[aL]
nrm r8.xyz, r7
dp3 r2.w, r2, r8
max r4.xy, r2.w, c33.y
lit r7, r4
min r2.w, r7.z, c33.x
mul r2.w, r2.w, c33.w
dp3 r4.x, r2, c8[aL]
max r4.x, r4.x, c33.y
slt r4.y, c33.y, r4.x
mul r7.xyz, r2.w, c0[aL]
mad r6.xyz, r4.y, r7, r6
mul r7.xyz, r4.x, c28
mul r7.xyz, r7, c0[aL]
mul r7.xyz, r7, c33.w
min r7.xyz, r7, c33.x
add r5.xyz, r5, r7
endloop
max r2.xyz, r5, c33.y
max r2.w, r3.y, c28.w
min oD0, r2, c33.x
mul r1.xyz, r6, c29
max r1.xyz, r1, c33.y
min oD1.xyz, r1, c33.x
rcp r1.x, r1.w
mul r1.x, r1.x, c27.x
mul r1.x, r1.x, -r1.x
expp oT1.x, r1.x
mad oT0.xy, v2, c32, c32.zwzw
dp4 oPos.x, c16, r0
dp4 oPos.y, c17, r0
dp4 oPos.z, c18, r0

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "FOG_EXP2" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 31 [glstate_matrix_invtrans_modelview0] 3
Matrix 28 [glstate_matrix_modelview0] 3
Matrix 24 [glstate_matrix_mvp]
Vector 36 [_Color]
Vector 38 [_Emission]
Vector 40 [_MainTex_ST]
Float 39 [_Shininess]
Vector 37 [_SpecColor]
Vector 34 [glstate_lightmodel_ambient]
Vector 35 [unity_FogParams]
Vector 16 [unity_LightAtten0]
Vector 17 [unity_LightAtten1]
Vector 18 [unity_LightAtten2]
Vector 19 [unity_LightAtten3]
Vector 20 [unity_LightAtten4]
Vector 21 [unity_LightAtten5]
Vector 22 [unity_LightAtten6]
Vector 23 [unity_LightAtten7]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c41, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
mad r0, v0.xyzx, c41.xxxy, c41.yyyx
dp4 oPos.w, c27, r0
dp3 r1.x, c31, v1
dp3 r1.y, c32, v1
dp3 r1.z, c33, v1
nrm r2.xyz, r1
dp4 r1.x, c28, r0
dp4 r1.y, c29, r0
dp4 r1.z, c30, r0
dp3 r1.w, r1, r1
rsq r1.w, r1.w
mov r3.yz, c41
mul r4.zw, r3.z, c39.x
mov r5.xyz, c36
mov r6.xyz, c34
mad r3.xzw, r5.xyyz, r6.xyyz, c38.xyyz
mov r5.xyz, r3.xzww
mov r6.xyz, c41.y
loop aL, i0
mad r7.xyz, r1, -c8[aL].w, c8[aL]
dp3 r2.w, r7, r7
rsq r5.w, r2.w
mul r7.xyz, r5.w, r7
mad r8.xyz, r1, -r1.w, r7
nrm r9.xyz, r8
dp3 r5.w, r2, r9
max r4.xy, r5.w, c41.y
lit r8, r4
mul r4.x, c8[aL].w, c8[aL].w
slt r4.x, -r4.x, r4.x
slt r4.y, c16[aL].w, r2.w
mul r4.x, r4.y, r4.x
mul r2.w, r2.w, c16[aL].z
add r2.w, r2.w, c41.x
rcp r2.w, r2.w
mad r2.w, r4.x, -r2.w, r2.w
mul r2.w, r2.w, c41.w
min r4.x, r8.z, c41.x
mul r4.x, r2.w, r4.x
dp3 r4.y, r2, r7
max r4.y, r4.y, c41.y
slt r5.w, c41.y, r4.y
mul r7.xyz, r4.x, c0[aL]
mad r6.xyz, r5.w, r7, r6
mul r7.xyz, r4.y, c36
mul r7.xyz, r7, c0[aL]
mul r7.xyz, r2.w, r7
min r7.xyz, r7, c41.x
add r5.xyz, r5, r7
endloop
max r2.xyz, r5, c41.y
max r2.w, r3.y, c36.w
min oD0, r2, c41.x
mul r1.xyz, r6, c37
max r1.xyz, r1, c41.y
min oD1.xyz, r1, c41.x
rcp r1.x, r1.w
mul r1.x, r1.x, c35.x
mul r1.x, r1.x, -r1.x
expp oT1.x, r1.x
mad oT0.xy, v2, c40, c40.zwzw
dp4 oPos.x, c24, r0
dp4 oPos.y, c25, r0
dp4 oPos.z, c26, r0

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "FOG_EXP2" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 39 [glstate_matrix_invtrans_modelview0] 3
Matrix 36 [glstate_matrix_modelview0] 3
Matrix 32 [glstate_matrix_mvp]
Vector 44 [_Color]
Vector 46 [_Emission]
Vector 48 [_MainTex_ST]
Float 47 [_Shininess]
Vector 45 [_SpecColor]
Vector 42 [glstate_lightmodel_ambient]
Vector 43 [unity_FogParams]
Vector 16 [unity_LightAtten0]
Vector 17 [unity_LightAtten1]
Vector 18 [unity_LightAtten2]
Vector 19 [unity_LightAtten3]
Vector 20 [unity_LightAtten4]
Vector 21 [unity_LightAtten5]
Vector 22 [unity_LightAtten6]
Vector 23 [unity_LightAtten7]
Vector 0 [unity_LightColor0]
Vector 1 [unity_LightColor1]
Vector 2 [unity_LightColor2]
Vector 3 [unity_LightColor3]
Vector 4 [unity_LightColor4]
Vector 5 [unity_LightColor5]
Vector 6 [unity_LightColor6]
Vector 7 [unity_LightColor7]
Vector 8 [unity_LightPosition0]
Vector 9 [unity_LightPosition1]
Vector 10 [unity_LightPosition2]
Vector 11 [unity_LightPosition3]
Vector 12 [unity_LightPosition4]
Vector 13 [unity_LightPosition5]
Vector 14 [unity_LightPosition6]
Vector 15 [unity_LightPosition7]
Vector 24 [unity_SpotDirection0]
Vector 25 [unity_SpotDirection1]
Vector 26 [unity_SpotDirection2]
Vector 27 [unity_SpotDirection3]
Vector 28 [unity_SpotDirection4]
Vector 29 [unity_SpotDirection5]
Vector 30 [unity_SpotDirection6]
Vector 31 [unity_SpotDirection7]
VectorInt 0 [unity_VertexLightParams] 4
"vs_2_0
def c49, 1, 0, 128, 0.5
dcl_position v0
dcl_normal v1
dcl_texcoord v2
mad r0, v0.xyzx, c49.xxxy, c49.yyyx
dp4 oPos.w, c35, r0
dp3 r1.x, c39, v1
dp3 r1.y, c40, v1
dp3 r1.z, c41, v1
nrm r2.xyz, r1
dp4 r1.x, c36, r0
dp4 r1.y, c37, r0
dp4 r1.z, c38, r0
dp3 r1.w, r1, r1
rsq r1.w, r1.w
mov r3.yz, c49
mul r4.zw, r3.z, c47.x
mov r5.xyz, c44
mov r6.xyz, c42
mad r3.xzw, r5.xyyz, r6.xyyz, c46.xyyz
mov r5.xyz, r3.xzww
mov r6.xyz, c49.y
loop aL, i0
mad r7.xyz, r1, -c8[aL].w, c8[aL]
dp3 r2.w, r7, r7
rsq r5.w, r2.w
mul r7.xyz, r5.w, r7
mad r8.xyz, r1, -r1.w, r7
nrm r9.xyz, r8
dp3 r5.w, r2, r9
max r4.xy, r5.w, c49.y
lit r8, r4
mul r4.x, c8[aL].w, c8[aL].w
slt r4.x, -r4.x, r4.x
slt r4.y, c16[aL].w, r2.w
mul r4.x, r4.y, r4.x
mul r2.w, r2.w, c16[aL].z
add r2.w, r2.w, c49.x
rcp r2.w, r2.w
mad r2.w, r4.x, -r2.w, r2.w
dp3 r4.x, r7, c24[aL]
max r4.x, r4.x, c49.y
add r4.x, r4.x, -c16[aL].x
mul r4.x, r4.x, c16[aL].y
max r4.x, r4.x, c49.y
min r4.x, r4.x, c49.x
mul r2.w, r2.w, r4.x
mul r2.w, r2.w, c49.w
min r4.x, r8.z, c49.x
mul r4.x, r2.w, r4.x
dp3 r4.y, r2, r7
max r4.y, r4.y, c49.y
slt r5.w, c49.y, r4.y
mul r7.xyz, r4.x, c0[aL]
mad r6.xyz, r5.w, r7, r6
mul r7.xyz, r4.y, c44
mul r7.xyz, r7, c0[aL]
mul r7.xyz, r2.w, r7
min r7.xyz, r7, c49.x
add r5.xyz, r5, r7
endloop
max r2.xyz, r5, c49.y
max r2.w, r3.y, c44.w
min oD0, r2, c49.x
mul r1.xyz, r6, c45
max r1.xyz, r1, c49.y
min oD1.xyz, r1, c49.x
rcp r1.x, r1.w
mul r1.x, r1.x, c43.x
mul r1.x, r1.x, -r1.x
expp oT1.x, r1.x
mad oT0.xy, v2, c48, c48.zwzw
dp4 oPos.x, c32, r0
dp4 oPos.y, c33, r0
dp4 oPos.z, c34, r0

"
}
}
Program "fp" {
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r1.xyz, r0, c0.x, v1
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "POINT" }
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r1.xyz, r0, c0.x, v1
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" }
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r1.xyz, r0, c0.x, v1
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Vector 0 [unity_FogColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_pp t1.x
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r0.xyz, r0, c1.x, v1
lrp_pp r1.xyz, t1.x, r0, c0
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "POINT" "FOG_EXP2" }
Vector 0 [unity_FogColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_pp t1.x
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r0.xyz, r0, c1.x, v1
lrp_pp r1.xyz, t1.x, r0, c0
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "SPOT" "FOG_EXP2" }
Vector 0 [unity_FogColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 2, 0, 0, 0
dcl v0
dcl v1.xyz
dcl t0.xy
dcl_pp t1.x
dcl_2d s0
texld_pp r0, t0, s0
mul_pp r0.xyz, r0, v0
mul_pp r1.w, r0.w, v0.w
mad_pp r0.xyz, r0, c1.x, v1
lrp_pp r1.xyz, t1.x, r0, c0
mov_pp oC0, r1

"
}
}
 }
 Pass {
  Tags { "LIGHTMODE"="VertexLM" "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Blend SrcAlpha OneMinusSrcAlpha
  ColorMask RGB
  GpuProgramID 120521
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_MainTex_ST]
Vector 4 [unity_LightmapST]
"vs_2_0
def c6, 0, 1, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord1 v2
dcl_texcoord v3
max r0, v1, c6.x
min oD0, r0, c6.y
mad oT0.xy, v2, c4, c4.zwzw
mad oT1.xy, v3, c5, c5.zwzw
mad r0, v0.xyzx, c6.yyyx, c6.xxxy
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 9 [_MainTex_ST]
Vector 7 [unity_FogParams]
Vector 8 [unity_LightmapST]
"vs_2_0
def c10, 1, 0, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord1 v2
dcl_texcoord v3
max r0, v1, c10.y
min oD0, r0, c10.x
mad oT0.xy, v2, c8, c8.zwzw
mad oT1.xy, v3, c9, c9.zwzw
mad r0, v0.xyzx, c10.xxxy, c10.yyyx
dp4 r1.x, c4, r0
dp4 r1.y, c5, r0
dp4 r1.z, c6, r0
dp3 r1.x, r1, r1
rsq r1.x, r1.x
rcp r1.x, r1.x
mul r1.x, r1.x, c7.x
mul r1.x, r1.x, -r1.x
expp oT2.x, r1.x
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [_Color]
SetTexture 0 [unity_Lightmap] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
dcl v0
dcl t0.xy
dcl t1.xy
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s0
texld_pp r1, t1, s1
mul_pp r0.xyz, r0, c0
mul_pp r0.xyz, r0, r1
mul_pp r1.w, r1.w, v0.w
add_pp r1.xyz, r0, r0
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Vector 1 [_Color]
Vector 0 [unity_FogColor]
SetTexture 0 [unity_Lightmap] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
def c2, 2, 0, 0, 0
dcl v0
dcl t0.xy
dcl t1.xy
dcl_pp t2.x
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s0
texld_pp r1, t1, s1
mul_pp r0.xyz, r0, c1
mul_pp r0.xyz, r0, r1
mul_pp r1.w, r1.w, v0.w
mov r2.xyz, c0
mad_pp r0.xyz, r0, c2.x, -r2
mad_pp r1.xyz, t2.x, r0, c0
mov_pp oC0, r1

"
}
}
 }
 Pass {
  Tags { "LIGHTMODE"="VertexLMRGBM" "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Blend SrcAlpha OneMinusSrcAlpha
  ColorMask RGB
  GpuProgramID 193573
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 0 [glstate_matrix_mvp]
Vector 6 [_MainTex_ST]
Vector 4 [unity_LightmapST]
Vector 5 [unity_Lightmap_ST]
"vs_2_0
def c7, 0, 1, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord1 v2
dcl_texcoord v3
max r0, v1, c7.x
min oD0, r0, c7.y
mad oT0.xy, v2, c4, c4.zwzw
mad oT1.xy, v2, c5, c5.zwzw
mad oT2.xy, v3, c6, c6.zwzw
mad r0, v0.xyzx, c7.yyyx, c7.xxxy
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 10 [_MainTex_ST]
Vector 7 [unity_FogParams]
Vector 8 [unity_LightmapST]
Vector 9 [unity_Lightmap_ST]
"vs_2_0
def c11, 1, 0, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord1 v2
dcl_texcoord v3
max r0, v1, c11.y
min oD0, r0, c11.x
mad oT0.xy, v2, c8, c8.zwzw
mad oT1.xy, v2, c9, c9.zwzw
mad oT2.xy, v3, c10, c10.zwzw
mad r0, v0.xyzx, c11.xxxy, c11.yyyx
dp4 r1.x, c4, r0
dp4 r1.y, c5, r0
dp4 r1.z, c6, r0
dp3 r1.x, r1, r1
rsq r1.x, r1.x
rcp r1.x, r1.x
mul r1.x, r1.x, c7.x
mul r1.x, r1.x, -r1.x
expp oT3.x, r1.x
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Vector 0 [_Color]
SetTexture 0 [unity_Lightmap] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
def c1, 4, 0, 0, 0
dcl v0
dcl t0.xy
dcl t2.xy
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s0
texld_pp r1, t2, s1
mul_pp r0.xyz, r0.w, r0
mul_pp r0.xyz, r0, c0
add_pp r0.xyz, r0, r0
mul_pp r0.xyz, r0, r1
mul_pp r1.w, r1.w, v0.w
mul_pp r1.xyz, r0, c1.x
mov_pp oC0, r1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Vector 1 [_Color]
Vector 0 [unity_FogColor]
SetTexture 0 [unity_Lightmap] 2D 0
SetTexture 1 [_MainTex] 2D 1
"ps_2_0
def c2, 4, 0, 0, 0
dcl v0
dcl t0.xy
dcl t2.xy
dcl_pp t3.x
dcl_2d s0
dcl_2d s1
texld_pp r0, t0, s0
texld_pp r1, t2, s1
mul_pp r0.xyz, r0.w, r0
mul_pp r0.xyz, r0, c1
add_pp r0.xyz, r0, r0
mul_pp r0.xyz, r0, r1
mul_pp r1.w, r1.w, v0.w
mov r2.xyz, c0
mad_pp r0.xyz, r0, c2.x, -r2
mad_pp r1.xyz, t3.x, r0, c0
mov_pp oC0, r1

"
}
}
 }
}
}
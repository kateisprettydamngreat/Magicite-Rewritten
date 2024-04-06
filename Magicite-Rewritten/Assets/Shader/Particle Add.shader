//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Particles/Additive" {
Properties {
 _TintColor ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
 _MainTex ("Particle Texture", 2D) = "white" { }
 _InvFade ("Soft Particles Factor", Range(0.01,3)) = 1
}
SubShader { 
 Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
 Pass {
  Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" }
  ZWrite Off
  Cull Off
  Blend SrcAlpha One
  ColorMask RGB
  GpuProgramID 62330
Program "vp" {
SubProgram "d3d9 " {
Keywords { "SOFTPARTICLES_OFF" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_MainTex_ST]
"vs_2_0
dcl_position v0
dcl_color v1
dcl_texcoord v2
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mad oT0.xy, v2, c4, c4.zwzw
mov oD0, v1

"
}
SubProgram "d3d9 " {
Keywords { "SOFTPARTICLES_ON" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 9 [_MainTex_ST]
Vector 7 [_ProjectionParams]
Vector 8 [_ScreenParams]
"vs_2_0
def c10, 0.5, 0, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord v2
dp4 oPos.z, c2, v0
dp4 r0.y, c1, v0
mul r0.z, r0.y, c7.x
dp4 r0.x, c0, v0
dp4 r0.w, c3, v0
mul r1.xzw, r0.xywz, c10.x
mov oPos.xyw, r0
mov oT2.w, r0.w
mad oT2.xy, r1.z, c8.zwzw, r1.xwzw
dp4 r0.x, c6, v0
mov oT2.z, -r0.x
mad oT0.xy, v2, c9, c9.zwzw
mov oD0, v1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" "SOFTPARTICLES_OFF" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_MainTex_ST]
Vector 4 [unity_FogParams]
"vs_2_0
dcl_position v0
dcl_color v1
dcl_texcoord v2
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.w, c3, v0
mad oT0.xy, v2, c5, c5.zwzw
dp4 r0.x, c2, v0
mul r0.y, r0.x, c4.x
mov oPos.z, r0.x
mul r0.x, r0.y, -r0.y
exp oT1.x, r0.x
mov oD0, v1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" "SOFTPARTICLES_ON" }
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 10 [_MainTex_ST]
Vector 7 [_ProjectionParams]
Vector 8 [_ScreenParams]
Vector 9 [unity_FogParams]
"vs_2_0
def c11, 0.5, 0, 0, 0
dcl_position v0
dcl_color v1
dcl_texcoord v2
dp4 r0.y, c1, v0
mul r1.x, r0.y, c7.x
mul r1.w, r1.x, c11.x
dp4 r0.x, c0, v0
dp4 r0.w, c3, v0
mul r1.xz, r0.xyww, c11.x
mad oT2.xy, r1.z, c8.zwzw, r1.xwzw
dp4 r1.x, c6, v0
mov oT2.z, -r1.x
mad oT0.xy, v2, c10, c10.zwzw
dp4 r0.z, c2, v0
mul r1.x, r0.z, c9.x
mov oPos, r0
mov oT2.w, r0.w
mul r0.x, r1.x, -r1.x
exp oT1.x, r0.x
mov oD0, v1

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Keywords { "SOFTPARTICLES_OFF" }
Vector 0 [_TintColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl v0
dcl t0.xy
dcl_2d s0
texld r0, t0, s0
mul r1, v0, c0
add r1, r1, r1
mul_pp r0, r0, r1
mov_pp oC0, r0

"
}
SubProgram "d3d9 " {
Keywords { "SOFTPARTICLES_ON" }
Float 2 [_InvFade]
Vector 1 [_TintColor]
Vector 0 [_ZBufferParams]
SetTexture 0 [_MainTex] 2D 0
SetTexture 1 [_CameraDepthTexture] 2D 1
"ps_2_0
def c3, 2, 0, 0, 0
dcl v0
dcl t0.xy
dcl t2
dcl_2d s0
dcl_2d s1
texldp r0, t2, s1
texld r1, t0, s0
mad r0.x, c0.z, r0.x, c0.w
rcp r0.x, r0.x
add r0.x, r0.x, -t2.z
mul_sat r0.x, r0.x, c2.x
mul_pp r0.x, r0.x, v0.w
mul r0.x, r0.x, c3.x
mul r0.w, r0.x, c1.w
mov r2.xyz, v0
mul r2.xyz, r2, c1
mul r0.xyz, r2, c3.x
mul_pp r0, r1, r0
mov_pp oC0, r0

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" "SOFTPARTICLES_OFF" }
Vector 0 [_TintColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl v0
dcl t0.xy
dcl t1.x
dcl_2d s0
texld r0, t0, s0
mul r1, v0, c0
add r1, r1, r1
mul_pp r0, r0, r1
mov_sat r1.x, t1.x
mul_pp r0.xyz, r0, r1.x
mov_pp oC0, r0

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" "SOFTPARTICLES_ON" }
Float 2 [_InvFade]
Vector 1 [_TintColor]
Vector 0 [_ZBufferParams]
SetTexture 0 [_MainTex] 2D 0
SetTexture 1 [_CameraDepthTexture] 2D 1
"ps_2_0
def c3, 2, 0, 0, 0
dcl v0
dcl t0.xy
dcl t1.x
dcl t2
dcl_2d s0
dcl_2d s1
texldp r0, t2, s1
texld r1, t0, s0
mad r0.x, c0.z, r0.x, c0.w
rcp r0.x, r0.x
add r0.x, r0.x, -t2.z
mul_sat r0.x, r0.x, c2.x
mul_pp r0.x, r0.x, v0.w
mul r0.x, r0.x, c3.x
mul r0.w, r0.x, c1.w
mov r2.xyz, v0
mul r2.xyz, r2, c1
mul r0.xyz, r2, c3.x
mul_pp r0, r1, r0
mov_sat r1.x, t1.x
mul_pp r0.xyz, r0, r1.x
mov_pp oC0, r0

"
}
}
 }
}
}
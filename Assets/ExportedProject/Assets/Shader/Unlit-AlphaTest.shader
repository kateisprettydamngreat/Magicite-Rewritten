//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Unlit/Transparent Cutout" {
Properties {
 _MainTex ("Base (RGB) Trans (A)", 2D) = "white" { }
 _Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
}
SubShader { 
 LOD 100
 Tags { "QUEUE"="AlphaTest" "IGNOREPROJECTOR"="true" "RenderType"="TransparentCutout" }
 Pass {
  Tags { "QUEUE"="AlphaTest" "IGNOREPROJECTOR"="true" "RenderType"="TransparentCutout" }
  GpuProgramID 36113
Program "vp" {
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_MainTex_ST]
"vs_2_0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mad oT0.xy, v1, c4, c4.zwzw

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 5 [_MainTex_ST]
Vector 4 [unity_FogParams]
"vs_2_0
dcl_position v0
dcl_texcoord v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.w, c3, v0
mad oT0.xy, v1, c5, c5.zwzw
dp4 r0.x, c2, v0
mul r0.y, r0.x, c4.x
mov oPos.z, r0.x
mul r0.x, r0.y, -r0.y
exp oT1.x, r0.x

"
}
}
Program "fp" {
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl_pp t0.xy
dcl_2d s0
texld_pp r0, t0, s0
add_pp r1, r0.w, -c0.x
mov_pp oC0, r0
texkill r1

"
}
SubProgram "d3d9 " {
Keywords { "FOG_EXP2" }
Float 1 [_Cutoff]
Vector 0 [unity_FogColor]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
dcl_pp t0.xy
dcl t1.x
dcl_2d s0
texld_pp r0, t0, s0
add_pp r1, r0.w, -c1.x
texkill r1
mov_sat r1.x, t1.x
lrp_pp r2.xyz, r1.x, r0, c0
mov_pp r2.w, r0.w
mov_pp oC0, r2

"
}
}
 }
}
}
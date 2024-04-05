//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Camera-DepthNormalTexture" {
Properties {
 _MainTex ("", 2D) = "white" { }
 _Cutoff ("", Float) = 0.5
 _Color ("", Color) = (1,1,1,1)
}
SubShader { 
 Tags { "RenderType"="Opaque" }
 Pass {
  Tags { "RenderType"="Opaque" }
  GpuProgramID 37153
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



varying vec4 xlv_TEXCOORD0;
void main ()
{
  vec4 tmpvar_1;
  mat3 tmpvar_2;
  tmpvar_2[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_2[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_2[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_2 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * gl_Vertex).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * gl_Vertex);
  xlv_TEXCOORD0 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
varying vec4 xlv_TEXCOORD0;
void main ()
{
  vec4 enc_1;
  vec2 enc_2;
  enc_2 = (xlv_TEXCOORD0.xy / (xlv_TEXCOORD0.z + 1.0));
  enc_2 = (enc_2 / 1.7777);
  enc_2 = ((enc_2 * 0.5) + 0.5);
  enc_1.xy = enc_2;
  vec2 enc_3;
  vec2 tmpvar_4;
  tmpvar_4 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD0.w));
  enc_3.y = tmpvar_4.y;
  enc_3.x = (tmpvar_4.x - (tmpvar_4.y * 0.003921569));
  enc_1.zw = enc_3;
  gl_FragData[0] = enc_1;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "normal" Normal
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 10 [_ProjectionParams]
"vs_2_0
dcl_position v0
dcl_normal v1
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT0.xyz, r0.w, r0
dp4 r0.x, c6, v0
mul r0.x, r0.x, c10.w
mov oT0.w, -r0.x

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "normal" Normal
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
"vs_4_0
root12:aaacaaaa
eefiecedpjomaidannfoomkleeehflpappmfocbdabaaaaaaimadaaaaadaaaaaa
cmaaaaaakaaaaaaapiaaaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaaaaaafaepfdejfeejepeoaaeoepfcenebemaafeeffiedepepfceeaaklklkl
epfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaa
fdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklfdeieefcimacaaaa
eaaaabaakdaaaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaa
abaaaaaaalaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaadpccabaaaabaaaaaagiaaaaac
abaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaabaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaa
egiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaai
hcaabaaaaaaaaaaafgbfbaaaabaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaabaaaaaaaiaaaaaaagbabaaaabaaaaaaegacbaaa
aaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaa
abaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaah
hccabaaaabaaaaaapgapbaaaaaaaaaaaegacbaaaaaaaaaaadiaaaaaibcaabaaa
aaaaaaaabkbabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaa
aaaaaaaackiacaaaabaaaaaaaeaaaaaaakbabaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaackbabaaaaaaaaaaa
akaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaa
dkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaabaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
varying highp vec4 xlv_TEXCOORD0;
void main ()
{
  highp vec4 tmpvar_1;
  highp mat3 tmpvar_2;
  tmpvar_2[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_2[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_2[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_2 * _glesNormal));
  tmpvar_1.w = -(((glstate_matrix_modelview0 * _glesVertex).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
varying highp vec4 xlv_TEXCOORD0;
void main ()
{
  lowp vec4 tmpvar_1;
  highp vec4 enc_2;
  highp vec2 enc_3;
  enc_3 = (xlv_TEXCOORD0.xy / (xlv_TEXCOORD0.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  highp vec2 enc_4;
  highp vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD0.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  tmpvar_1 = enc_2;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "normal" Normal
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
"vs_4_0_level_9_1
root12:aaacaaaa
eefiecedjgnijdamglbcpdemjoeedgcigidoahbkabaaaaaadaafaaaaaeaaaaaa
daaaaaaanaabaaaageaeaaaaniaeaaaaebgpgodjjiabaaaajiabaaaaaaacpopp
fiabaaaaeaaaaaaaacaaceaaaaaadmaaaaaadmaaaaaaceaaabaadmaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaaaaaaaaaaaacpoppbpaaaaac
afaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjaafaaaaadaaaaahiaabaaffja
alaaoekaaeaaaaaeaaaaahiaakaaoekaabaaaajaaaaaoeiaaeaaaaaeaaaaahia
amaaoekaabaakkjaaaaaoeiaaiaaaaadaaaaaiiaaaaaoeiaaaaaoeiaahaaaaac
aaaaaiiaaaaappiaafaaaaadaaaaahoaaaaappiaaaaaoeiaafaaaaadaaaaabia
aaaaffjaahaakkkaaeaaaaaeaaaaabiaagaakkkaaaaaaajaaaaaaaiaaeaaaaae
aaaaabiaaiaakkkaaaaakkjaaaaaaaiaaeaaaaaeaaaaabiaajaakkkaaaaappja
aaaaaaiaafaaaaadaaaaabiaaaaaaaiaabaappkaabaaaaacaaaaaioaaaaaaaib
afaaaaadaaaaapiaaaaaffjaadaaoekaaeaaaaaeaaaaapiaacaaoekaaaaaaaja
aaaaoeiaaeaaaaaeaaaaapiaaeaaoekaaaaakkjaaaaaoeiaaeaaaaaeaaaaapia
afaaoekaaaaappjaaaaaoeiaaeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeia
abaaaaacaaaaammaaaaaoeiappppaaaafdeieefcimacaaaaeaaaabaakdaaaaaa
fjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaa
fpaaaaadpcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaaghaaaaaepccabaaa
aaaaaaaaabaaaaaagfaaaaadpccabaaaabaaaaaagiaaaaacabaaaaaadiaaaaai
pcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaak
pcaabaaaaaaaaaaaegiocaaaabaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaa
aaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaacaaaaaakgbkbaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaa
adaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaa
fgbfbaaaabaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaa
egiccaaaabaaaaaaaiaaaaaaagbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaa
aaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaa
eeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaabaaaaaa
pgapbaaaaaaaaaaaegacbaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaabkbabaaa
aaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
abaaaaaaaeaaaaaaakbabaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaa
aaaaaaaackiacaaaabaaaaaaagaaaaaackbabaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaadkbabaaaaaaaaaaa
akaabaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaa
aaaaaaaaafaaaaaadgaaaaagiccabaaaabaaaaaaakaabaiaebaaaaaaaaaaaaaa
doaaaaabejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
ahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafaepfdej
feejepeoaaeoepfcenebemaafeeffiedepepfceeaaklklklepfdeheofaaaaaaa
acaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaa
eeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaafdfgfpfaepfdejfe
ejepeoaafeeffiedepepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
out highp vec4 vs_TEXCOORD0;
highp vec4 t0;
highp float t3;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t3 = dot(t0.xyz, t0.xyz);
    t3 = inversesqrt(t3);
    vs_TEXCOORD0.xyz = vec3(t3) * t0.xyz;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * in_POSITION0.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * in_POSITION0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD0.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
in highp vec4 vs_TEXCOORD0;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec2 t1;
void main()
{
    t0.x = vs_TEXCOORD0.z + 1.0;
    t0.xy = vs_TEXCOORD0.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t1.xy = vs_TEXCOORD0.ww * vec2(1.0, 255.0);
    t1.xy = fract(t1.xy);
    t0.z = (-t1.y) * 0.00392156886 + t1.x;
    t0.w = t1.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
out vec4 vs_TEXCOORD0;
vec4 t0;
float t3;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t3 = dot(t0.xyz, t0.xyz);
    t3 = inversesqrt(t3);
    vs_TEXCOORD0.xyz = vec3(t3) * t0.xyz;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * in_POSITION0.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * in_POSITION0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD0.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
in  vec4 vs_TEXCOORD0;
out vec4 SV_Target0;
vec2 t0;
void main()
{
    t0.x = vs_TEXCOORD0.z + 1.0;
    t0.xy = vs_TEXCOORD0.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD0.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
"ps_2_0
def c0, 1, 0.281262308, 0.5, 0.00392156886
def c1, 1, 255, 0, 0
dcl t0
add r0.w, t0.z, c0.x
rcp r0.x, r0.w
mul r0.xy, r0.x, t0
mad_pp r0.xy, r0, c0.y, c0.z
mul r1.xy, t0.w, c1
frc r1.xy, r1
mad_pp r0.z, r1.y, -c0.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
"ps_4_0
root12:aaaaaaaa
eefiecedgningppdhdkaeoblkhckpdmipnfedcoaabaaaaaaniabaaaaadaaaaaa
cmaaaaaaieaaaaaaliaaaaaaejfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcbiabaaaa
eaaaaaaaegaaaaaagcbaaaadpcbabaaaabaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacabaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaabaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaabaaaaaaagaabaaaaaaaaaaa
dcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaak
dcaabaaaaaaaaaaapgbpbaaaabaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaa
aaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaa
dgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
"ps_4_0_level_9_1
root12:aaaaaaaa
eefiecedjpndamchlnfihklhcifkchncgidfnldmabaaaaaaneacaaaaaeaaaaaa
daaaaaaaciabaaaaeiacaaaakaacaaaaebgpgodjpaaaaaaapaaaaaaaaaacpppp
mmaaaaaaceaaaaaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaacpppp
fbaaaaafaaaaapkaaaaaiadpjnabjadoaaaaaadpibiaiadlfbaaaaafabaaapka
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabpaaaaacaaaaaaiaaaaaaplaacaaaaad
aaaaaiiaaaaakklaaaaaaakaagaaaaacaaaaabiaaaaappiaafaaaaadaaaaadia
aaaaaaiaaaaaoelaaeaaaaaeaaaacdiaaaaaoeiaaaaaffkaaaaakkkaafaaaaad
abaaadiaaaaapplaabaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaaaaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcbiabaaaaeaaaaaaaegaaaaaagcbaaaadpcbabaaa
abaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaaaaaaaahbcaabaaa
aaaaaaaackbabaaaabaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaa
egbabaaaabaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaa
aaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadp
aaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaabaaaaaa
aceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaa
egaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaa
abeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaa
aaaaaaaadoaaaaabejfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl
epfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TransparentCutout" }
 Pass {
  Tags { "RenderType"="TransparentCutout" }
  GpuProgramID 106902
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _MainTex_ST;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  mat3 tmpvar_2;
  tmpvar_2[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_2[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_2[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_2 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * gl_Vertex).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * gl_Vertex);
  xlv_TEXCOORD0 = ((gl_MultiTexCoord0.xy * _MainTex_ST.xy) + _MainTex_ST.zw);
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
uniform vec4 _Color;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * _Color.w) - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 11 [_MainTex_ST]
Vector 10 [_ProjectionParams]
"vs_2_0
dcl_position v0
dcl_normal v1
dcl_texcoord v2
dp4 oPos.x, c0, v0
dp4 oPos.y, c1, v0
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
mad oT0.xy, v2, c11, c11.zwzw
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT1.xyz, r0.w, r0
dp4 r0.x, c6, v0
mul r0.x, r0.x, c10.w
mov oT1.w, -r0.x

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "$Globals" 144
Vector 96 [_MainTex_ST]
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedommkkpkdplcbccclnbmgjoenngghnnbnabaaaaaapiadaaaaadaaaaaa
cmaaaaaakaaaaaaabaabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apadaaaafaepfdejfeejepeoaaeoepfcenebemaafeeffiedepepfceeaaklklkl
epfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaa
fmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfe
ejepeoaafeeffiedepepfceeaaklklklfdeieefcoaacaaaaeaaaabaaliaaaaaa
fjaaaaaeegiocaaaaaaaaaaaahaaaaaafjaaaaaeegiocaaaabaaaaaaagaaaaaa
fjaaaaaeegiocaaaacaaaaaaalaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaad
hcbabaaaabaaaaaafpaaaaaddcbabaaaacaaaaaaghaaaaaepccabaaaaaaaaaaa
abaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagiaaaaac
abaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaal
dccabaaaabaaaaaaegbabaaaacaaaaaaegiacaaaaaaaaaaaagaaaaaaogikcaaa
aaaaaaaaagaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaabaaaaaaegiccaaa
acaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaacaaaaaaaiaaaaaa
agbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
acaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaa
dkaabaaaaaaaaaaadiaaaaahhccabaaaacaaaaaapgapbaaaaaaaaaaaegacbaaa
aaaaaaaadiaaaaaibcaabaaaaaaaaaaabkbabaaaaaaaaaaackiacaaaacaaaaaa
afaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaaeaaaaaaakbabaaa
aaaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaa
agaaaaaackbabaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaa
ckiacaaaacaaaaaaahaaaaaadkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaai
bcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaaabaaaaaaafaaaaaadgaaaaag
iccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp vec4 _MainTex_ST;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  highp vec4 tmpvar_1;
  highp mat3 tmpvar_2;
  tmpvar_2[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_2[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_2[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_2 * _glesNormal));
  tmpvar_1.w = -(((glstate_matrix_modelview0 * _glesVertex).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = ((_glesMultiTexCoord0.xy * _MainTex_ST.xy) + _MainTex_ST.zw);
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
uniform lowp vec4 _Color;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float x_2;
  x_2 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * _Color.w) - _Cutoff);
  if ((x_2 < 0.0)) {
    discard;
  };
  highp vec4 enc_3;
  highp vec2 enc_4;
  enc_4 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_4 = (enc_4 / 1.7777);
  enc_4 = ((enc_4 * 0.5) + 0.5);
  enc_3.xy = enc_4;
  highp vec2 enc_5;
  highp vec2 tmpvar_6;
  tmpvar_6 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_5.y = tmpvar_6.y;
  enc_5.x = (tmpvar_6.x - (tmpvar_6.y * 0.003921569));
  enc_3.zw = enc_5;
  tmpvar_1 = enc_3;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "$Globals" 144
Vector 96 [_MainTex_ST]
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedlfjngnblpiidmhjfheoopmnfcknmcflhabaaaaaamiafaaaaaeaaaaaa
daaaaaaapmabaaaaoeaeaaaafiafaaaaebgpgodjmeabaaaameabaaaaaaacpopp
hiabaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaagaa
abaaabaaaaaaaaaaabaaafaaabaaacaaaaaaaaaaacaaaaaaalaaadaaaaaaaaaa
aaaaaaaaaaacpoppbpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapja
bpaaaaacafaaaciaacaaapjaaeaaaaaeaaaaadoaacaaoejaabaaoekaabaaooka
afaaaaadaaaaahiaabaaffjaamaaoekaaeaaaaaeaaaaahiaalaaoekaabaaaaja
aaaaoeiaaeaaaaaeaaaaahiaanaaoekaabaakkjaaaaaoeiaaiaaaaadaaaaaiia
aaaaoeiaaaaaoeiaahaaaaacaaaaaiiaaaaappiaafaaaaadabaaahoaaaaappia
aaaaoeiaafaaaaadaaaaabiaaaaaffjaaiaakkkaaeaaaaaeaaaaabiaahaakkka
aaaaaajaaaaaaaiaaeaaaaaeaaaaabiaajaakkkaaaaakkjaaaaaaaiaaeaaaaae
aaaaabiaakaakkkaaaaappjaaaaaaaiaafaaaaadaaaaabiaaaaaaaiaacaappka
abaaaaacabaaaioaaaaaaaibafaaaaadaaaaapiaaaaaffjaaeaaoekaaeaaaaae
aaaaapiaadaaoekaaaaaaajaaaaaoeiaaeaaaaaeaaaaapiaafaaoekaaaaakkja
aaaaoeiaaeaaaaaeaaaaapiaagaaoekaaaaappjaaaaaoeiaaeaaaaaeaaaaadma
aaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeiappppaaaafdeieefc
oaacaaaaeaaaabaaliaaaaaafjaaaaaeegiocaaaaaaaaaaaahaaaaaafjaaaaae
egiocaaaabaaaaaaagaaaaaafjaaaaaeegiocaaaacaaaaaaalaaaaaafpaaaaad
pcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaafpaaaaaddcbabaaaacaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaad
pccabaaaacaaaaaagiaaaaacabaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpccabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadcaaaaaldccabaaaabaaaaaaegbabaaaacaaaaaaegiacaaa
aaaaaaaaagaaaaaaogikcaaaaaaaaaaaagaaaaaadiaaaaaihcaabaaaaaaaaaaa
fgbfbaaaabaaaaaaegiccaaaacaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaa
egiccaaaacaaaaaaaiaaaaaaagbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaacaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaa
aaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaa
eeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaacaaaaaa
pgapbaaaaaaaaaaaegacbaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaabkbabaaa
aaaaaaaackiacaaaacaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
acaaaaaaaeaaaaaaakbabaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaa
aaaaaaaackiacaaaacaaaaaaagaaaaaackbabaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaahaaaaaadkbabaaaaaaaaaaa
akaabaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaa
abaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaa
doaaaaabejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
ahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaapadaaaafaepfdej
feejepeoaaeoepfcenebemaafeeffiedepepfceeaaklklklepfdeheogiaaaaaa
adaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaa
aaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaafeeffied
epepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _MainTex_ST;
uniform 	lowp float _Cutoff;
uniform 	lowp vec4 _Color;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in highp vec4 in_TEXCOORD0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec4 t0;
highp float t3;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t3 = dot(t0.xyz, t0.xyz);
    t3 = inversesqrt(t3);
    vs_TEXCOORD1.xyz = vec3(t3) * t0.xyz;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * in_POSITION0.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * in_POSITION0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _MainTex_ST;
uniform 	lowp float _Cutoff;
uniform 	lowp vec4 _Color;
uniform lowp sampler2D _MainTex;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
lowp float t10_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t10_1 = t10_0 * _Color.w + (-_Cutoff);
    tb0 = t10_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _MainTex_ST;
uniform 	float _Cutoff;
uniform 	vec4 _Color;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_TEXCOORD0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec4 t0;
float t3;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t3 = dot(t0.xyz, t0.xyz);
    t3 = inversesqrt(t3);
    vs_TEXCOORD1.xyz = vec3(t3) * t0.xyz;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * in_POSITION0.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * in_POSITION0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _MainTex_ST;
uniform 	float _Cutoff;
uniform 	vec4 _Color;
uniform  sampler2D _MainTex;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w * _Color.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Vector 1 [_Color]
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c2, 1, 0.281262308, 0.5, 0.00392156886
def c3, 1, 255, 0, 0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
mov r1.w, c1.w
mad_pp r0, r0.w, r1.w, -c0.x
texkill r0
add r0.x, t1.z, c2.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c2.y, c2.z
mul r1.xy, t1.w, c3
frc r1.xy, r1
mad_pp r0.z, r1.y, -c2.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 144
Float 112 [_Cutoff]
Vector 128 [_Color]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefiecedoeahdgmngjegaolobhcjljmdeephkjcgabaaaaaakeacaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcmmabaaaaeaaaaaaahdaaaaaa
fjaaaaaeegiocaaaaaaaaaaaajaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaae
aahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaam
bcaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaaaaaaaaaaaiaaaaaaakiacaia
ebaaaaaaaaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaa
abeaaaaaaaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaa
ckbabaaaacaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaa
acaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaa
aceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadp
aaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaa
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaa
aaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaa
ibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaa
doaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 144
Float 112 [_Cutoff]
Vector 128 [_Color]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecednifodiklkcnnldgpdjnecpbhheeanpccabaaaaaaaaaeaaaaaeaaaaaa
daaaaaaaiiabaaaafmadaaaammadaaaaebgpgodjfaabaaaafaabaaaaaaacpppp
bmabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaahaaacaaaaaaaaaaaaaaaaacppppfbaaaaafacaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafadaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaaadlabpaaaaacaaaaaaiaabaaaplabpaaaaacaaaaaaja
aaaiapkaecaaaaadaaaacpiaaaaaoelaaaaioekaabaaaaacabaaaiiaabaappka
aeaaaaaeaaaacpiaaaaappiaabaappiaaaaaaakbebaaaaabaaaaapiaacaaaaad
aaaaabiaabaakklaacaaaakaagaaaaacaaaaabiaaaaaaaiaafaaaaadaaaaadia
aaaaaaiaabaaoelaaeaaaaaeaaaacdiaaaaaoeiaacaaffkaacaakkkaafaaaaad
abaaadiaabaapplaadaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaacaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcmmabaaaaeaaaaaaahdaaaaaafjaaaaaeegiocaaa
aaaaaaaaajaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaaaaaaaaaa
ffffaaaagcbaaaaddcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaad
pccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaa
abaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaambcaabaaaaaaaaaaa
dkaabaaaaaaaaaaadkiacaaaaaaaaaaaaiaaaaaaakiacaiaebaaaaaaaaaaaaaa
ahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaaaaaaaaaa
anaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaa
abeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaa
aaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjado
jnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaa
diaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahped
aaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaak
eccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaa
aaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaabejfdeheo
giaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaafmaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaa
feeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl
"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TreeBark" }
 Pass {
  Tags { "RenderType"="TreeBark" }
  GpuProgramID 171880
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _Time;
uniform vec4 _ProjectionParams;



uniform mat4 _Object2World;
uniform vec4 _TreeInstanceScale;
uniform vec4 _SquashPlaneNormal;
uniform float _SquashAmount;
uniform vec4 _Wind;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 tmpvar_2;
  tmpvar_2.w = gl_Vertex.w;
  tmpvar_2.xyz = (gl_Vertex.xyz * _TreeInstanceScale.xyz);
  vec4 pos_3;
  pos_3.w = tmpvar_2.w;
  vec3 bend_4;
  vec4 v_5;
  v_5.x = _Object2World[0].w;
  v_5.y = _Object2World[1].w;
  v_5.z = _Object2World[2].w;
  v_5.w = _Object2World[3].w;
  float tmpvar_6;
  tmpvar_6 = (dot (v_5.xyz, vec3(1.0, 1.0, 1.0)) + gl_Color.x);
  vec2 tmpvar_7;
  tmpvar_7.x = dot (tmpvar_2.xyz, vec3((gl_Color.y + tmpvar_6)));
  tmpvar_7.y = tmpvar_6;
  vec4 tmpvar_8;
  tmpvar_8 = abs(((
    fract((((
      fract(((_Time.yy + tmpvar_7).xxyy * vec4(1.975, 0.793, 0.375, 0.193)))
     * 2.0) - 1.0) + 0.5))
   * 2.0) - 1.0));
  vec4 tmpvar_9;
  tmpvar_9 = ((tmpvar_8 * tmpvar_8) * (3.0 - (2.0 * tmpvar_8)));
  vec2 tmpvar_10;
  tmpvar_10 = (tmpvar_9.xz + tmpvar_9.yw);
  bend_4.xz = ((gl_Color.y * 0.1) * gl_Normal).xz;
  bend_4.y = (gl_MultiTexCoord1.y * 0.3);
  pos_3.xyz = (tmpvar_2.xyz + ((
    (tmpvar_10.xyx * bend_4)
   + 
    ((_Wind.xyz * tmpvar_10.y) * gl_MultiTexCoord1.y)
  ) * _Wind.w));
  pos_3.xyz = (pos_3.xyz + (gl_MultiTexCoord1.x * _Wind.xyz));
  vec4 tmpvar_11;
  tmpvar_11.w = 1.0;
  tmpvar_11.xyz = mix ((pos_3.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_3.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_3.xyz, vec3(_SquashAmount));
  tmpvar_2 = tmpvar_11;
  mat3 tmpvar_12;
  tmpvar_12[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_12[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_12[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_12 * normalize(gl_Normal)));
  tmpvar_1.w = -(((gl_ModelViewMatrix * tmpvar_11).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * tmpvar_11);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 enc_1;
  vec2 enc_2;
  enc_2 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_2 = (enc_2 / 1.7777);
  enc_2 = ((enc_2 * 0.5) + 0.5);
  enc_1.xy = enc_2;
  vec2 enc_3;
  vec2 tmpvar_4;
  tmpvar_4 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_3.y = tmpvar_4.y;
  enc_3.x = (tmpvar_4.x - (tmpvar_4.y * 0.003921569));
  enc_1.zw = enc_3;
  gl_FragData[0] = enc_1;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 4 [_Object2World]
Matrix 11 [glstate_matrix_invtrans_modelview0] 3
Matrix 8 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 15 [_ProjectionParams]
Float 18 [_SquashAmount]
Vector 17 [_SquashPlaneNormal]
Vector 14 [_Time]
Vector 16 [_TreeInstanceScale]
Vector 19 [_Wind]
"vs_2_0
def c20, 1.97500002, 0.792999983, 0.375, 0.193000004
def c21, 1, 2, -0.5, -1
def c22, 2, 3, 0.100000001, 0.300000012
dcl_position v0
dcl_normal v1
dcl_texcoord v2
dcl_texcoord1 v3
dcl_color v4
mov r0.x, c21.x
dp3 r0.x, c7, r0.x
add r0.y, r0.x, v4.x
add r0.z, r0.y, v4.y
mul r1.xyz, v0, c16
dp3 r0.x, r1, r0.z
add r0, r0.xxyy, c14.y
mul r0, r0, c20
frc r0, r0
mad r0, r0, c21.y, c21.z
frc r0, r0
mad r0, r0, c21.y, c21.w
abs r0, r0
mul r2, r0, r0
mad r0, r0, -c22.x, c22.y
mul r0, r0, r2
add r0.xy, r0.ywzw, r0.xzzw
mul r2.xyz, r0.y, c19
mul r2.xyz, r2, v3.y
mul r3.y, r0.y, v3.y
mul r0.y, v4.y, c22.z
mul r3.xz, r0.y, v1
mov r0.z, c22.w
mad r0.xyz, r0.xzxw, r3, r2
mad r0.xyz, r0, c19.w, r1
mad r0.xyz, v3.x, c19, r0
dp3 r0.w, c17, r0
add r0.w, r0.w, c17.w
mad r1.xyz, r0.w, -c17, r0
lrp r2.xyz, c18.x, r0, r1
mov r2.w, c21.x
dp4 oPos.x, c0, r2
dp4 oPos.y, c1, r2
dp4 oPos.z, c2, r2
dp4 oPos.w, c3, r2
dp4 r0.x, c10, r2
mul r0.x, r0.x, c15.w
mov oT1.w, -r0.x
nrm r0.xyz, v1
dp3 r1.x, c11, r0
dp3 r1.y, c12, r0
dp3 r1.z, c13, r0
dp3 r0.x, r1, r1
rsq r0.x, r0.x
mul oT1.xyz, r0.x, r1
mov oT0.xy, v2

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
ConstBuffer "$Globals" 208
Vector 144 [_Wind]
ConstBuffer "UnityPerCamera" 144
Vector 0 [_Time]
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
Matrix 192 [_Object2World]
ConstBuffer "UnityTerrain" 272
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
BindCB  "UnityTerrain" 3
"vs_4_0
root12:aaaeaaaa
eefiecedplekakglmnhmgclhmekdjlnbjihamhmfabaaaaaapmaiaaaaadaaaaaa
cmaaaaaaceabaaaajeabaaaaejfdeheopaaaaaaaaiaaaaaaaiaaaaaamiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaanbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaaaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaaoaaaaaaa
abaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapadaaaaoaaaaaaaacaaaaaaaaaaaaaa
adaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaaagaaaaaa
apaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapadaaaafaepfdej
feejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfceeaaedepem
epfcaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
adamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaklklklfdeieefcgaahaaaaeaaaabaa
niabaaaafjaaaaaeegiocaaaaaaaaaaaakaaaaaafjaaaaaeegiocaaaabaaaaaa
agaaaaaafjaaaaaeegiocaaaacaaaaaaapaaaaaafjaaaaaeegiocaaaadaaaaaa
anaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadhcbabaaaacaaaaaafpaaaaad
dcbabaaaadaaaaaafpaaaaaddcbabaaaaeaaaaaafpaaaaaddcbabaaaahaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaad
pccabaaaacaaaaaagiaaaaacaeaaaaaadgaaaaagbcaabaaaaaaaaaaadkiacaaa
acaaaaaaamaaaaaadgaaaaagccaabaaaaaaaaaaadkiacaaaacaaaaaaanaaaaaa
dgaaaaagecaabaaaaaaaaaaadkiacaaaacaaaaaaaoaaaaaabaaaaaakbcaabaaa
aaaaaaaaegacbaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaaaaa
aaaaaaahccaabaaaaaaaaaaaakaabaaaaaaaaaaaakbabaaaahaaaaaaaaaaaaah
ecaabaaaaaaaaaaabkaabaaaaaaaaaaabkbabaaaahaaaaaadiaaaaaihcaabaaa
abaaaaaaegbcbaaaaaaaaaaaegiccaaaadaaaaaaagaaaaaabaaaaaahbcaabaaa
aaaaaaaaegacbaaaabaaaaaakgakbaaaaaaaaaaaaaaaaaaipcaabaaaaaaaaaaa
agafbaaaaaaaaaaafgifcaaaabaaaaaaaaaaaaaadiaaaaakpcaabaaaaaaaaaaa
egaobaaaaaaaaaaaaceaaaaamnmmpmdpamaceldpaaaamadomlkbefdobkaaaaaf
pcaabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaappcaabaaaaaaaaaaaegaobaaa
aaaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaeaaceaaaaaaaaaaalp
aaaaaalpaaaaaalpaaaaaalpbkaaaaafpcaabaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaappcaabaaaaaaaaaaaegaobaaaaaaaaaaaaceaaaaaaaaaaaeaaaaaaaea
aaaaaaeaaaaaaaeaaceaaaaaaaaaialpaaaaialpaaaaialpaaaaialpdiaaaaaj
pcaabaaaacaaaaaaegaobaiaibaaaaaaaaaaaaaaegaobaiaibaaaaaaaaaaaaaa
dcaaaabapcaabaaaaaaaaaaaegaobaiambaaaaaaaaaaaaaaaceaaaaaaaaaaaea
aaaaaaeaaaaaaaeaaaaaaaeaaceaaaaaaaaaeaeaaaaaeaeaaaaaeaeaaaaaeaea
diaaaaahpcaabaaaaaaaaaaaegaobaaaaaaaaaaaegaobaaaacaaaaaaaaaaaaah
dcaabaaaaaaaaaaangafbaaaaaaaaaaaigaabaaaaaaaaaaadiaaaaaihcaabaaa
acaaaaaafgafbaaaaaaaaaaaegiccaaaaaaaaaaaajaaaaaadiaaaaahhcaabaaa
acaaaaaaegacbaaaacaaaaaafgbfbaaaaeaaaaaadiaaaaahccaabaaaadaaaaaa
bkaabaaaaaaaaaaabkbabaaaaeaaaaaadiaaaaahccaabaaaaaaaaaaabkbabaaa
ahaaaaaaabeaaaaamnmmmmdndiaaaaahfcaabaaaadaaaaaafgafbaaaaaaaaaaa
agbcbaaaacaaaaaadgaaaaafecaabaaaaaaaaaaaabeaaaaajkjjjjdodcaaaaaj
hcaabaaaaaaaaaaaigaabaaaaaaaaaaaegacbaaaadaaaaaaegacbaaaacaaaaaa
dcaaaaakhcaabaaaaaaaaaaaegacbaaaaaaaaaaapgipcaaaaaaaaaaaajaaaaaa
egacbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaagbabaaaaeaaaaaaegiccaaa
aaaaaaaaajaaaaaaegacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaa
adaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaa
aaaaaaaadkiacaaaadaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaia
ebaaaaaaaaaaaaaaegiccaaaadaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaai
hcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaak
hcaabaaaaaaaaaaaagiacaaaadaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaa
abaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaa
aaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaa
acaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaa
egaobaaaabaaaaaaegiocaaaacaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaa
egbabaaaadaaaaaadiaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaa
acaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaaeaaaaaa
akaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
acaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaackiacaaaacaaaaaaahaaaaaadiaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaadkiacaaaabaaaaaaafaaaaaadgaaaaagiccabaaa
acaaaaaaakaabaiaebaaaaaaaaaaaaaabaaaaaahbcaabaaaaaaaaaaaegbcbaaa
acaaaaaaegbcbaaaacaaaaaaeeaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaa
diaaaaahhcaabaaaaaaaaaaaagaabaaaaaaaaaaaegbcbaaaacaaaaaadiaaaaai
hcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaajaaaaaadcaaaaak
lcaabaaaaaaaaaaaegiicaaaacaaaaaaaiaaaaaaagaabaaaaaaaaaaaegaibaaa
abaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaacaaaaaaakaaaaaakgakbaaa
aaaaaaaaegadbaaaaaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaah
hccabaaaacaaaaaapgapbaaaaaaaaaaaegacbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
attribute vec4 _glesMultiTexCoord1;
uniform highp vec4 _Time;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp mat4 _Object2World;
uniform highp vec4 _TreeInstanceScale;
uniform highp vec4 _SquashPlaneNormal;
uniform highp float _SquashAmount;
uniform highp vec4 _Wind;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  tmpvar_1 = _glesColor;
  highp vec4 tmpvar_2;
  highp vec4 tmpvar_3;
  tmpvar_3.w = _glesVertex.w;
  tmpvar_3.xyz = (_glesVertex.xyz * _TreeInstanceScale.xyz);
  highp vec4 tmpvar_4;
  tmpvar_4.xy = tmpvar_1.xy;
  tmpvar_4.zw = _glesMultiTexCoord1.xy;
  highp vec4 pos_5;
  pos_5.w = tmpvar_3.w;
  highp vec3 bend_6;
  highp vec4 v_7;
  v_7.x = _Object2World[0].w;
  v_7.y = _Object2World[1].w;
  v_7.z = _Object2World[2].w;
  v_7.w = _Object2World[3].w;
  highp float tmpvar_8;
  tmpvar_8 = (dot (v_7.xyz, vec3(1.0, 1.0, 1.0)) + tmpvar_4.x);
  highp vec2 tmpvar_9;
  tmpvar_9.x = dot (tmpvar_3.xyz, vec3((tmpvar_4.y + tmpvar_8)));
  tmpvar_9.y = tmpvar_8;
  highp vec4 tmpvar_10;
  tmpvar_10 = abs(((
    fract((((
      fract(((_Time.yy + tmpvar_9).xxyy * vec4(1.975, 0.793, 0.375, 0.193)))
     * 2.0) - 1.0) + 0.5))
   * 2.0) - 1.0));
  highp vec4 tmpvar_11;
  tmpvar_11 = ((tmpvar_10 * tmpvar_10) * (3.0 - (2.0 * tmpvar_10)));
  highp vec2 tmpvar_12;
  tmpvar_12 = (tmpvar_11.xz + tmpvar_11.yw);
  bend_6.xz = ((tmpvar_4.y * 0.1) * _glesNormal).xz;
  bend_6.y = (_glesMultiTexCoord1.y * 0.3);
  pos_5.xyz = (tmpvar_3.xyz + ((
    (tmpvar_12.xyx * bend_6)
   + 
    ((_Wind.xyz * tmpvar_12.y) * _glesMultiTexCoord1.y)
  ) * _Wind.w));
  pos_5.xyz = (pos_5.xyz + (_glesMultiTexCoord1.x * _Wind.xyz));
  highp vec4 tmpvar_13;
  tmpvar_13.w = 1.0;
  tmpvar_13.xyz = mix ((pos_5.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_5.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_5.xyz, vec3(_SquashAmount));
  tmpvar_3 = tmpvar_13;
  highp mat3 tmpvar_14;
  tmpvar_14[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_14[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_14[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_2.xyz = normalize((tmpvar_14 * normalize(_glesNormal)));
  tmpvar_2.w = -(((glstate_matrix_modelview0 * tmpvar_13).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * tmpvar_13);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_2;
}


#endif
#ifdef FRAGMENT
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  highp vec4 enc_2;
  highp vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  highp vec2 enc_4;
  highp vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  tmpvar_1 = enc_2;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
ConstBuffer "$Globals" 208
Vector 144 [_Wind]
ConstBuffer "UnityPerCamera" 144
Vector 0 [_Time]
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
Matrix 192 [_Object2World]
ConstBuffer "UnityTerrain" 272
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
BindCB  "UnityTerrain" 3
"vs_4_0_level_9_1
root12:aaaeaaaa
eefiecedbkibfggkamndmgfgefmjbegjldalmpelabaaaaaafmanaaaaaeaaaaaa
daaaaaaaimaeaaaapealaaaaomamaaaaebgpgodjfeaeaaaafeaeaaaaaaacpopp
niadaaaahmaaaaaaahaaceaaaaaahiaaaaaahiaaaaaaceaaabaahiaaaaaaajaa
abaaabaaaaaaaaaaabaaaaaaabaaacaaaaaaaaaaabaaafaaabaaadaaaaaaaaaa
acaaaaaaalaaaeaaaaaaaaaaacaaamaaadaaapaaaaaaaaaaadaaagaaabaabcaa
aaaaaaaaadaaalaaacaabdaaaaaaaaaaaaaaaaaaaaacpoppfbaaaaafbfaaapka
mnmmpmdpamaceldpaaaamadomlkbefdofbaaaaafbgaaapkaaaaaiadpaaaaaaea
aaaaaalpaaaaialpfbaaaaafbhaaapkaaaaaaaeaaaaaeaeamnmmmmdnjkjjjjdo
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaaciaacaaapjabpaaaaacafaaadia
adaaapjabpaaaaacafaaaeiaaeaaapjabpaaaaacafaaahiaahaaapjaceaaaaac
aaaaahiaacaaoejaafaaaaadabaaahiaaaaaffiaanaaoekaaeaaaaaeaaaaalia
amaakekaaaaaaaiaabaakeiaaeaaaaaeaaaaahiaaoaaoekaaaaakkiaaaaapeia
aiaaaaadaaaaaiiaaaaaoeiaaaaaoeiaahaaaaacaaaaaiiaaaaappiaafaaaaad
abaaahoaaaaappiaaaaaoeiaabaaaaacaaaaabiaapaappkaabaaaaacaaaaacia
baaappkaabaaaaacaaaaaeiabbaappkaaiaaaaadaaaaabiaaaaaoeiabgaaaaka
acaaaaadaaaaaciaaaaaaaiaahaaaajaacaaaaadaaaaaeiaaaaaffiaahaaffja
afaaaaadabaaahiaaaaaoejabcaaoekaaiaaaaadaaaaabiaabaaoeiaaaaakkia
acaaaaadaaaaapiaaaaafaiaacaaffkaafaaaaadaaaaapiaaaaaoeiabfaaoeka
bdaaaaacaaaaapiaaaaaoeiaaeaaaaaeaaaaapiaaaaaoeiabgaaffkabgaakkka
bdaaaaacaaaaapiaaaaaoeiaaeaaaaaeaaaaapiaaaaaoeiabgaaffkabgaappka
cdaaaaacaaaaapiaaaaaoeiaafaaaaadacaaapiaaaaaoeiaaaaaoeiaaeaaaaae
aaaaapiaaaaaoeiabhaaaakbbhaaffkaafaaaaadaaaaapiaaaaaoeiaacaaoeia
acaaaaadaaaaadiaaaaaoniaaaaaoiiaafaaaaadacaaahiaaaaaffiaabaaoeka
afaaaaadacaaahiaacaaoeiaaeaaffjaafaaaaadadaaaciaaaaaffiaaeaaffja
afaaaaadaaaaaciaahaaffjabhaakkkaafaaaaadadaaafiaaaaaffiaacaaoeja
abaaaaacaaaaaeiabhaappkaaeaaaaaeaaaaahiaaaaamiiaadaaoeiaacaaoeia
aeaaaaaeaaaaahiaaaaaoeiaabaappkaabaaoeiaaeaaaaaeaaaaahiaaeaaaaja
abaaoekaaaaaoeiaaiaaaaadaaaaaiiabdaaoekaaaaaoeiaacaaaaadaaaaaiia
aaaappiabdaappkaaeaaaaaeabaaahiaaaaappiabdaaoekbaaaaoeiabcaaaaae
acaaahiabeaaaakaaaaaoeiaabaaoeiaafaaaaadaaaaabiaacaaffiaajaakkka
aeaaaaaeaaaaabiaaiaakkkaacaaaaiaaaaaaaiaaeaaaaaeaaaaabiaakaakkka
acaakkiaaaaaaaiaacaaaaadaaaaabiaaaaaaaiaalaakkkaafaaaaadaaaaabia
aaaaaaiaadaappkaabaaaaacabaaaioaaaaaaaibafaaaaadaaaaapiaacaaffia
afaaoekaaeaaaaaeaaaaapiaaeaaoekaacaaaaiaaaaaoeiaaeaaaaaeaaaaapia
agaaoekaacaakkiaaaaaoeiaacaaaaadaaaaapiaaaaaoeiaahaaoekaaeaaaaae
aaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeiaabaaaaac
aaaaadoaadaaoejappppaaaafdeieefcgaahaaaaeaaaabaaniabaaaafjaaaaae
egiocaaaaaaaaaaaakaaaaaafjaaaaaeegiocaaaabaaaaaaagaaaaaafjaaaaae
egiocaaaacaaaaaaapaaaaaafjaaaaaeegiocaaaadaaaaaaanaaaaaafpaaaaad
hcbabaaaaaaaaaaafpaaaaadhcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaa
fpaaaaaddcbabaaaaeaaaaaafpaaaaaddcbabaaaahaaaaaaghaaaaaepccabaaa
aaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaa
giaaaaacaeaaaaaadgaaaaagbcaabaaaaaaaaaaadkiacaaaacaaaaaaamaaaaaa
dgaaaaagccaabaaaaaaaaaaadkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaa
aaaaaaaadkiacaaaacaaaaaaaoaaaaaabaaaaaakbcaabaaaaaaaaaaaegacbaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaaaaaaaaaaaahccaabaaa
aaaaaaaaakaabaaaaaaaaaaaakbabaaaahaaaaaaaaaaaaahecaabaaaaaaaaaaa
bkaabaaaaaaaaaaabkbabaaaahaaaaaadiaaaaaihcaabaaaabaaaaaaegbcbaaa
aaaaaaaaegiccaaaadaaaaaaagaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaa
abaaaaaakgakbaaaaaaaaaaaaaaaaaaipcaabaaaaaaaaaaaagafbaaaaaaaaaaa
fgifcaaaabaaaaaaaaaaaaaadiaaaaakpcaabaaaaaaaaaaaegaobaaaaaaaaaaa
aceaaaaamnmmpmdpamaceldpaaaamadomlkbefdobkaaaaafpcaabaaaaaaaaaaa
egaobaaaaaaaaaaadcaaaaappcaabaaaaaaaaaaaegaobaaaaaaaaaaaaceaaaaa
aaaaaaeaaaaaaaeaaaaaaaeaaaaaaaeaaceaaaaaaaaaaalpaaaaaalpaaaaaalp
aaaaaalpbkaaaaafpcaabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaappcaabaaa
aaaaaaaaegaobaaaaaaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaea
aceaaaaaaaaaialpaaaaialpaaaaialpaaaaialpdiaaaaajpcaabaaaacaaaaaa
egaobaiaibaaaaaaaaaaaaaaegaobaiaibaaaaaaaaaaaaaadcaaaabapcaabaaa
aaaaaaaaegaobaiambaaaaaaaaaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaea
aaaaaaeaaceaaaaaaaaaeaeaaaaaeaeaaaaaeaeaaaaaeaeadiaaaaahpcaabaaa
aaaaaaaaegaobaaaaaaaaaaaegaobaaaacaaaaaaaaaaaaahdcaabaaaaaaaaaaa
ngafbaaaaaaaaaaaigaabaaaaaaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaa
aaaaaaaaegiccaaaaaaaaaaaajaaaaaadiaaaaahhcaabaaaacaaaaaaegacbaaa
acaaaaaafgbfbaaaaeaaaaaadiaaaaahccaabaaaadaaaaaabkaabaaaaaaaaaaa
bkbabaaaaeaaaaaadiaaaaahccaabaaaaaaaaaaabkbabaaaahaaaaaaabeaaaaa
mnmmmmdndiaaaaahfcaabaaaadaaaaaafgafbaaaaaaaaaaaagbcbaaaacaaaaaa
dgaaaaafecaabaaaaaaaaaaaabeaaaaajkjjjjdodcaaaaajhcaabaaaaaaaaaaa
igaabaaaaaaaaaaaegacbaaaadaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaa
aaaaaaaaegacbaaaaaaaaaaapgipcaaaaaaaaaaaajaaaaaaegacbaaaabaaaaaa
dcaaaaakhcaabaaaaaaaaaaaagbabaaaaeaaaaaaegiccaaaaaaaaaaaajaaaaaa
egacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaadaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaa
adaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaa
egiccaaaadaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaa
egacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
agiacaaaadaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaa
egiocaaaacaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaaegbabaaaadaaaaaa
diaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaacaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaaeaaaaaaakaabaaaaaaaaaaa
bkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaagaaaaaa
ckaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaackiacaaaacaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaadkiacaaaabaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaabaaaaaahbcaabaaaaaaaaaaaegbcbaaaacaaaaaaegbcbaaa
acaaaaaaeeaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaahhcaabaaa
aaaaaaaaagaabaaaaaaaaaaaegbcbaaaacaaaaaadiaaaaaihcaabaaaabaaaaaa
fgafbaaaaaaaaaaaegiccaaaacaaaaaaajaaaaaadcaaaaaklcaabaaaaaaaaaaa
egiicaaaacaaaaaaaiaaaaaaagaabaaaaaaaaaaaegaibaaaabaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaacaaaaaaakaaaaaakgakbaaaaaaaaaaaegadbaaa
aaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaa
eeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaacaaaaaa
pgapbaaaaaaaaaaaegacbaaaaaaaaaaadoaaaaabejfdeheopaaaaaaaaiaaaaaa
aiaaaaaamiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaanbaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaanjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaacaaaaaaahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaa
apadaaaaoaaaaaaaabaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapadaaaaoaaaaaaa
acaaaaaaaaaaaaaaadaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaa
adaaaaaaagaaaaaaapaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaa
apadaaaafaepfdejfeejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffied
epepfceeaaedepemepfcaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _LightColor0;
uniform 	lowp vec4 _SpecColor;
uniform 	mediump vec4 unity_LightGammaCorrectionConsts;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp vec4 _Color;
uniform 	lowp vec3 _TranslucencyColor;
uniform 	lowp float _TranslucencyViewDependency;
uniform 	mediump float _ShadowStrength;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in highp vec4 in_TEXCOORD0;
in highp vec4 in_TEXCOORD1;
in lowp vec4 in_COLOR0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec4 t0;
highp vec4 t1;
highp vec4 t2;
highp vec3 t3;
highp float t4;
highp float t8;
highp float t12;
void main()
{
    t0.x = _Object2World[0].w;
    t0.y = _Object2World[1].w;
    t0.z = _Object2World[2].w;
    t0.x = dot(t0.xyz, vec3(1.0, 1.0, 1.0));
    t0.y = t0.x + in_COLOR0.x;
    t8 = t0.y + in_COLOR0.y;
    t1.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t0.x = dot(t1.xyz, vec3(t8));
    t0 = t0.xxyy + _Time.yyyy;
    t0 = t0 * vec4(1.97500002, 0.792999983, 0.375, 0.193000004);
    t0 = fract(t0);
    t0 = t0 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-0.5, -0.5, -0.5, -0.5);
    t0 = fract(t0);
    t0 = t0 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-1.0, -1.0, -1.0, -1.0);
    t2 = abs(t0) * abs(t0);
    t0 = -abs(t0) * vec4(2.0, 2.0, 2.0, 2.0) + vec4(3.0, 3.0, 3.0, 3.0);
    t0 = t0 * t2;
    t0.xy = vec2(t0.y + t0.x, t0.w + t0.z);
    t2.xyz = t0.yyy * _Wind.xyz;
    t2.xyz = t2.xyz * in_TEXCOORD1.yyy;
    t3.y = t0.y * in_TEXCOORD1.y;
    t4 = in_COLOR0.y * 0.100000001;
    t3.xz = vec2(t4) * in_NORMAL0.xz;
    t0.z = 0.300000012;
    t0.xyz = t0.xzx * t3.xyz + t2.xyz;
    t0.xyz = t0.xyz * _Wind.www + t1.xyz;
    t0.xyz = in_TEXCOORD1.xxx * _Wind.xyz + t0.xyz;
    t12 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t12 = t12 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t12)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t4 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t4;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.x = dot(in_NORMAL0.xyz, in_NORMAL0.xyz);
    t0.x = inversesqrt(t0.x);
    t0.xyz = t0.xxx * in_NORMAL0.xyz;
    t1.xyz = t0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyw = glstate_matrix_invtrans_modelview0[0].xyz * t0.xxx + t1.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * t0.zzz + t0.xyw;
    t12 = dot(t0.xyz, t0.xyz);
    t12 = inversesqrt(t12);
    vs_TEXCOORD1.xyz = vec3(t12) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec2 t1;
void main()
{
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t1.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t1.xy = fract(t1.xy);
    t0.z = (-t1.y) * 0.00392156886 + t1.x;
    t0.w = t1.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _LightColor0;
uniform 	vec4 _SpecColor;
uniform 	vec4 unity_LightGammaCorrectionConsts;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	vec4 _Color;
uniform 	vec3 _TranslucencyColor;
uniform 	float _TranslucencyViewDependency;
uniform 	float _ShadowStrength;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_TEXCOORD0;
in  vec4 in_TEXCOORD1;
in  vec4 in_COLOR0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec4 t0;
vec4 t1;
vec4 t2;
vec3 t3;
float t4;
float t8;
float t12;
void main()
{
    t0.x = _Object2World[0].w;
    t0.y = _Object2World[1].w;
    t0.z = _Object2World[2].w;
    t0.x = dot(t0.xyz, vec3(1.0, 1.0, 1.0));
    t0.y = t0.x + in_COLOR0.x;
    t8 = t0.y + in_COLOR0.y;
    t1.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t0.x = dot(t1.xyz, vec3(t8));
    t0 = t0.xxyy + _Time.yyyy;
    t0 = t0 * vec4(1.97500002, 0.792999983, 0.375, 0.193000004);
    t0 = fract(t0);
    t0 = t0 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-0.5, -0.5, -0.5, -0.5);
    t0 = fract(t0);
    t0 = t0 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-1.0, -1.0, -1.0, -1.0);
    t2 = abs(t0) * abs(t0);
    t0 = -abs(t0) * vec4(2.0, 2.0, 2.0, 2.0) + vec4(3.0, 3.0, 3.0, 3.0);
    t0 = t0 * t2;
    t0.xy = t0.yw + t0.xz;
    t2.xyz = t0.yyy * _Wind.xyz;
    t2.xyz = t2.xyz * in_TEXCOORD1.yyy;
    t3.y = t0.y * in_TEXCOORD1.y;
    t4 = in_COLOR0.y * 0.100000001;
    t3.xz = vec2(t4) * in_NORMAL0.xz;
    t0.z = 0.300000012;
    t0.xyz = t0.xzx * t3.xyz + t2.xyz;
    t0.xyz = t0.xyz * _Wind.www + t1.xyz;
    t0.xyz = in_TEXCOORD1.xxx * _Wind.xyz + t0.xyz;
    t12 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t12 = t12 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t12)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t4 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t4;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.x = dot(in_NORMAL0.xyz, in_NORMAL0.xyz);
    t0.x = inversesqrt(t0.x);
    t0.xyz = t0.xxx * in_NORMAL0.xyz;
    t1.xyz = t0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyw = glstate_matrix_invtrans_modelview0[0].xyz * t0.xxx + t1.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * t0.zzz + t0.xyw;
    t12 = dot(t0.xyz, t0.xyz);
    t12 = inversesqrt(t12);
    vs_TEXCOORD1.xyz = vec3(t12) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
void main()
{
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
"ps_2_0
def c0, 1, 0.281262308, 0.5, 0.00392156886
def c1, 1, 255, 0, 0
dcl t1
add r0.w, t1.z, c0.x
rcp r0.x, r0.w
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c0.y, c0.z
mul r1.xy, t1.w, c1
frc r1.xy, r1
mad_pp r0.z, r1.y, -c0.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
"ps_4_0
root12:aaaaaaaa
eefiecedmaconhlmipicjgfbpnefpheodcjgohaaabaaaaaapaabaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadaaaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcbiabaaaaeaaaaaaaegaaaaaa
gcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
aaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaaabeaaaaaaaaaiadpaoaaaaah
dcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaa
aaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaa
aceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaa
pgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaaf
dcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaa
aaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
"ps_4_0_level_9_1
root12:aaaaaaaa
eefiecedieemlhljdhlbnghbfhglonmhlfjekmnpabaaaaaaomacaaaaaeaaaaaa
daaaaaaaciabaaaaeiacaaaaliacaaaaebgpgodjpaaaaaaapaaaaaaaaaacpppp
mmaaaaaaceaaaaaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaacpppp
fbaaaaafaaaaapkaaaaaiadpjnabjadoaaaaaadpibiaiadlfbaaaaafabaaapka
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabpaaaaacaaaaaaiaabaaaplaacaaaaad
aaaaaiiaabaakklaaaaaaakaagaaaaacaaaaabiaaaaappiaafaaaaadaaaaadia
aaaaaaiaabaaoelaaeaaaaaeaaaacdiaaaaaoeiaaaaaffkaaaaakkkaafaaaaad
abaaadiaabaapplaabaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaaaaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcbiabaaaaeaaaaaaaegaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaaaaaaaahbcaabaaa
aaaaaaaackbabaaaacaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaa
egbabaaaacaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaa
aaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadp
aaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaa
aceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaa
egaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaa
abeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaa
aaaaaaaadoaaaaabejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaadaaaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaa
fdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TreeLeaf" }
 Pass {
  Tags { "RenderType"="TreeLeaf" }
  GpuProgramID 248790
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _Time;
uniform vec4 _ProjectionParams;



uniform mat4 _Object2World;
uniform vec4 _TreeInstanceScale;
uniform vec4 _SquashPlaneNormal;
uniform float _SquashAmount;
uniform vec4 _Wind;
attribute vec4 TANGENT;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 tmpvar_2;
  vec4 pos_3;
  float tmpvar_4;
  tmpvar_4 = (1.0 - abs(TANGENT.w));
  vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = gl_Normal;
  vec4 tmpvar_6;
  tmpvar_6.zw = vec2(0.0, 0.0);
  tmpvar_6.xy = gl_Normal.xy;
  pos_3 = (gl_Vertex + ((tmpvar_6 * gl_ModelViewMatrixInverseTranspose) * tmpvar_4));
  vec3 tmpvar_7;
  tmpvar_7 = mix (gl_Normal, normalize((tmpvar_5 * gl_ModelViewMatrixInverseTranspose)).xyz, vec3(tmpvar_4));
  tmpvar_2.w = pos_3.w;
  tmpvar_2.xyz = (pos_3.xyz * _TreeInstanceScale.xyz);
  vec4 pos_8;
  pos_8.w = tmpvar_2.w;
  vec3 bend_9;
  vec4 v_10;
  v_10.x = _Object2World[0].w;
  v_10.y = _Object2World[1].w;
  v_10.z = _Object2World[2].w;
  v_10.w = _Object2World[3].w;
  float tmpvar_11;
  tmpvar_11 = (dot (v_10.xyz, vec3(1.0, 1.0, 1.0)) + gl_Color.x);
  vec2 tmpvar_12;
  tmpvar_12.x = dot (tmpvar_2.xyz, vec3((gl_Color.y + tmpvar_11)));
  tmpvar_12.y = tmpvar_11;
  vec4 tmpvar_13;
  tmpvar_13 = abs(((
    fract((((
      fract(((_Time.yy + tmpvar_12).xxyy * vec4(1.975, 0.793, 0.375, 0.193)))
     * 2.0) - 1.0) + 0.5))
   * 2.0) - 1.0));
  vec4 tmpvar_14;
  tmpvar_14 = ((tmpvar_13 * tmpvar_13) * (3.0 - (2.0 * tmpvar_13)));
  vec2 tmpvar_15;
  tmpvar_15 = (tmpvar_14.xz + tmpvar_14.yw);
  bend_9.xz = ((gl_Color.y * 0.1) * tmpvar_7).xz;
  bend_9.y = (gl_MultiTexCoord1.y * 0.3);
  pos_8.xyz = (tmpvar_2.xyz + ((
    (tmpvar_15.xyx * bend_9)
   + 
    ((_Wind.xyz * tmpvar_15.y) * gl_MultiTexCoord1.y)
  ) * _Wind.w));
  pos_8.xyz = (pos_8.xyz + (gl_MultiTexCoord1.x * _Wind.xyz));
  vec4 tmpvar_16;
  tmpvar_16.w = 1.0;
  tmpvar_16.xyz = mix ((pos_8.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_8.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_8.xyz, vec3(_SquashAmount));
  tmpvar_2 = tmpvar_16;
  mat3 tmpvar_17;
  tmpvar_17[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_17[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_17[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_17 * normalize(tmpvar_7)));
  tmpvar_1.w = -(((gl_ModelViewMatrix * tmpvar_16).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * tmpvar_16);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = (texture2D (_MainTex, xlv_TEXCOORD0).w - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Bind "tangent" TexCoord4
Matrix 4 [_Object2World]
Matrix 11 [glstate_matrix_invtrans_modelview0] 3
Matrix 8 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 15 [_ProjectionParams]
Float 18 [_SquashAmount]
Vector 17 [_SquashPlaneNormal]
Vector 14 [_Time]
Vector 16 [_TreeInstanceScale]
Vector 19 [_Wind]
"vs_2_0
def c20, 1.97500002, 0.792999983, 0.375, 0.193000004
def c21, 1, 2, -0.5, -1
def c22, 2, 3, 0.100000001, 0.300000012
dcl_position v0
dcl_tangent v1
dcl_normal v2
dcl_texcoord v3
dcl_texcoord1 v4
dcl_color v5
mov r0.x, c21.x
dp3 r0.x, c7, r0.x
add r0.y, r0.x, v5.x
add r0.z, r0.y, v5.y
abs r0.w, v1.w
add r0.w, -r0.w, c21.x
mul r1, v2.y, c12
mad r1, v2.x, c11, r1
mad r2.xyz, r1, r0.w, v0
mad r1, v2.z, c13, r1
mul r2.xyz, r2, c16
dp3 r0.x, r2, r0.z
add r3, r0.xxyy, c14.y
mul r3, r3, c20
frc r3, r3
mad r3, r3, c21.y, c21.z
frc r3, r3
mad r3, r3, c21.y, c21.w
abs r3, r3
mul r4, r3, r3
mad r3, r3, -c22.x, c22.y
mul r3, r3, r4
add r0.xy, r3.ywzw, r3.xzzw
mul r3.xyz, r0.y, c19
mul r3.xyz, r3, v4.y
mul r4.y, r0.y, v4.y
dp4 r0.y, r1, r1
rsq r0.y, r0.y
mad r1.xyz, r1, r0.y, -v2
mad r1.xyz, r0.w, r1, v2
mul r0.y, v5.y, c22.z
mul r4.xz, r1, r0.y
nrm r5.xyz, r1
mov r0.z, c22.w
mad r0.xyz, r0.xzxw, r4, r3
mad r0.xyz, r0, c19.w, r2
mad r0.xyz, v4.x, c19, r0
dp3 r0.w, c17, r0
add r0.w, r0.w, c17.w
mad r1.xyz, r0.w, -c17, r0
lrp r2.xyz, c18.x, r0, r1
mov r2.w, c21.x
dp4 oPos.x, c0, r2
dp4 oPos.y, c1, r2
dp4 oPos.z, c2, r2
dp4 oPos.w, c3, r2
dp4 r0.x, c10, r2
mul r0.x, r0.x, c15.w
mov oT1.w, -r0.x
dp3 r0.x, c11, r5
dp3 r0.y, c12, r5
dp3 r0.z, c13, r5
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT1.xyz, r0.w, r0
mov oT0.xy, v3

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Bind "tangent" TexCoord4
ConstBuffer "$Globals" 208
Vector 144 [_Wind]
ConstBuffer "UnityPerCamera" 144
Vector 0 [_Time]
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
Matrix 192 [_Object2World]
ConstBuffer "UnityTerrain" 272
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
BindCB  "UnityTerrain" 3
"vs_4_0
root12:aaaeaaaa
eefiecedbpdddadeafecbffdjjajhificljlbeanabaaaaaakiakaaaaadaaaaaa
cmaaaaaaceabaaaajeabaaaaejfdeheopaaaaaaaaiaaaaaaaiaaaaaamiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaanbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaiaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaaoaaaaaaa
abaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapadaaaaoaaaaaaaacaaaaaaaaaaaaaa
adaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaaagaaaaaa
apaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapadaaaafaepfdej
feejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfceeaaedepem
epfcaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
adamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaklklklfdeieefcamajaaaaeaaaabaa
edacaaaafjaaaaaeegiocaaaaaaaaaaaakaaaaaafjaaaaaeegiocaaaabaaaaaa
agaaaaaafjaaaaaeegiocaaaacaaaaaaapaaaaaafjaaaaaeegiocaaaadaaaaaa
anaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadicbabaaaabaaaaaafpaaaaad
hcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaafpaaaaaddcbabaaaaeaaaaaa
fpaaaaaddcbabaaaahaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaad
dccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagiaaaaacafaaaaaadgaaaaag
bcaabaaaaaaaaaaadkiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaaaaaaaaaa
dkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaaaaaaaaadkiacaaaacaaaaaa
aoaaaaaabaaaaaakbcaabaaaaaaaaaaaegacbaaaaaaaaaaaaceaaaaaaaaaiadp
aaaaiadpaaaaiadpaaaaaaaaaaaaaaahccaabaaaaaaaaaaaakaabaaaaaaaaaaa
akbabaaaahaaaaaaaaaaaaahecaabaaaaaaaaaaabkaabaaaaaaaaaaabkbabaaa
ahaaaaaaapaaaaaibcaabaaaabaaaaaaegbabaaaacaaaaaaegiacaaaacaaaaaa
aiaaaaaaapaaaaaiccaabaaaabaaaaaaegbabaaaacaaaaaaegiacaaaacaaaaaa
ajaaaaaaapaaaaaiecaabaaaabaaaaaaegbabaaaacaaaaaaegiacaaaacaaaaaa
akaaaaaaaaaaaaaiicaabaaaaaaaaaaadkbabaiambaaaaaaabaaaaaaabeaaaaa
aaaaiadpdcaaaaajhcaabaaaabaaaaaaegacbaaaabaaaaaapgapbaaaaaaaaaaa
egbcbaaaaaaaaaaadiaaaaaihcaabaaaabaaaaaaegacbaaaabaaaaaaegiccaaa
adaaaaaaagaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaabaaaaaakgakbaaa
aaaaaaaaaaaaaaaipcaabaaaacaaaaaaagafbaaaaaaaaaaafgifcaaaabaaaaaa
aaaaaaaadiaaaaakpcaabaaaacaaaaaaegaobaaaacaaaaaaaceaaaaamnmmpmdp
amaceldpaaaamadomlkbefdobkaaaaafpcaabaaaacaaaaaaegaobaaaacaaaaaa
dcaaaaappcaabaaaacaaaaaaegaobaaaacaaaaaaaceaaaaaaaaaaaeaaaaaaaea
aaaaaaeaaaaaaaeaaceaaaaaaaaaaalpaaaaaalpaaaaaalpaaaaaalpbkaaaaaf
pcaabaaaacaaaaaaegaobaaaacaaaaaadcaaaaappcaabaaaacaaaaaaegaobaaa
acaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaeaaceaaaaaaaaaialp
aaaaialpaaaaialpaaaaialpdiaaaaajpcaabaaaadaaaaaaegaobaiaibaaaaaa
acaaaaaaegaobaiaibaaaaaaacaaaaaadcaaaabapcaabaaaacaaaaaaegaobaia
mbaaaaaaacaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaeaaceaaaaa
aaaaeaeaaaaaeaeaaaaaeaeaaaaaeaeadiaaaaahpcaabaaaacaaaaaaegaobaaa
acaaaaaaegaobaaaadaaaaaaaaaaaaahdcaabaaaaaaaaaaangafbaaaacaaaaaa
igaabaaaacaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaaaaaaaaaaegiccaaa
aaaaaaaaajaaaaaadiaaaaahhcaabaaaacaaaaaaegacbaaaacaaaaaafgbfbaaa
aeaaaaaadiaaaaahccaabaaaadaaaaaabkaabaaaaaaaaaaabkbabaaaaeaaaaaa
baaaaaaiicaabaaaaeaaaaaaegbcbaaaacaaaaaaegiccaaaacaaaaaaalaaaaaa
baaaaaaibcaabaaaaeaaaaaaegbcbaaaacaaaaaaegiccaaaacaaaaaaaiaaaaaa
baaaaaaiccaabaaaaeaaaaaaegbcbaaaacaaaaaaegiccaaaacaaaaaaajaaaaaa
baaaaaaiecaabaaaaeaaaaaaegbcbaaaacaaaaaaegiccaaaacaaaaaaakaaaaaa
bbaaaaahccaabaaaaaaaaaaaegaobaaaaeaaaaaaegaobaaaaeaaaaaaeeaaaaaf
ccaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaakhcaabaaaaeaaaaaaegacbaaa
aeaaaaaafgafbaaaaaaaaaaaegbcbaiaebaaaaaaacaaaaaadcaaaaajhcaabaaa
aeaaaaaapgapbaaaaaaaaaaaegacbaaaaeaaaaaaegbcbaaaacaaaaaadiaaaaah
ccaabaaaaaaaaaaabkbabaaaahaaaaaaabeaaaaamnmmmmdndiaaaaahfcaabaaa
adaaaaaaagacbaaaaeaaaaaafgafbaaaaaaaaaaadgaaaaafecaabaaaaaaaaaaa
abeaaaaajkjjjjdodcaaaaajhcaabaaaaaaaaaaaigaabaaaaaaaaaaaegacbaaa
adaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaaaaaaaaaegacbaaaaaaaaaaa
pgipcaaaaaaaaaaaajaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
agbabaaaaeaaaaaaegiccaaaaaaaaaaaajaaaaaaegacbaaaaaaaaaaabaaaaaai
icaabaaaaaaaaaaaegiccaaaadaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaai
icaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaaadaaaaaaalaaaaaadcaaaaal
hcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaaegiccaaaadaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaia
ebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaagiacaaaadaaaaaaamaaaaaa
egacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaa
acaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaa
abaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaa
aaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaaegiocaaaacaaaaaaadaaaaaa
dgaaaaafdccabaaaabaaaaaaegbabaaaadaaaaaabaaaaaahicaabaaaaaaaaaaa
egacbaaaaeaaaaaaegacbaaaaeaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaa
aaaaaaaadiaaaaahhcaabaaaabaaaaaapgapbaaaaaaaaaaaegacbaaaaeaaaaaa
diaaaaaihcaabaaaacaaaaaafgafbaaaabaaaaaaegiccaaaacaaaaaaajaaaaaa
dcaaaaaklcaabaaaabaaaaaaegiicaaaacaaaaaaaiaaaaaaagaabaaaabaaaaaa
egaibaaaacaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaakaaaaaa
kgakbaaaabaaaaaaegadbaaaabaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaa
abaaaaaaegacbaaaabaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaa
diaaaaahhccabaaaacaaaaaapgapbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
ccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaacaaaaaaafaaaaaadcaaaaak
bcaabaaaaaaaaaaackiacaaaacaaaaaaaeaaaaaaakaabaaaaaaaaaaabkaabaaa
aaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaagaaaaaackaabaaa
aaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaa
ckiacaaaacaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaa
dkiacaaaabaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesTANGENT;
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
attribute vec4 _glesMultiTexCoord1;
uniform highp vec4 _Time;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp mat4 _Object2World;
uniform highp vec4 _TreeInstanceScale;
uniform highp vec4 _SquashPlaneNormal;
uniform highp float _SquashAmount;
uniform highp vec4 _Wind;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  highp vec3 tmpvar_1;
  tmpvar_1 = _glesNormal;
  lowp vec4 tmpvar_2;
  tmpvar_2 = _glesColor;
  highp vec4 tmpvar_3;
  highp vec4 tmpvar_4;
  highp vec4 pos_5;
  highp float tmpvar_6;
  tmpvar_6 = (1.0 - abs(_glesTANGENT.w));
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = tmpvar_1;
  highp vec4 tmpvar_8;
  tmpvar_8.zw = vec2(0.0, 0.0);
  tmpvar_8.xy = tmpvar_1.xy;
  pos_5 = (_glesVertex + ((tmpvar_8 * glstate_matrix_invtrans_modelview0) * tmpvar_6));
  highp vec3 tmpvar_9;
  tmpvar_9 = mix (_glesNormal, normalize((tmpvar_7 * glstate_matrix_invtrans_modelview0)).xyz, vec3(tmpvar_6));
  tmpvar_4.w = pos_5.w;
  tmpvar_4.xyz = (pos_5.xyz * _TreeInstanceScale.xyz);
  highp vec4 tmpvar_10;
  tmpvar_10.xy = tmpvar_2.xy;
  tmpvar_10.zw = _glesMultiTexCoord1.xy;
  highp vec4 pos_11;
  pos_11.w = tmpvar_4.w;
  highp vec3 bend_12;
  highp vec4 v_13;
  v_13.x = _Object2World[0].w;
  v_13.y = _Object2World[1].w;
  v_13.z = _Object2World[2].w;
  v_13.w = _Object2World[3].w;
  highp float tmpvar_14;
  tmpvar_14 = (dot (v_13.xyz, vec3(1.0, 1.0, 1.0)) + tmpvar_10.x);
  highp vec2 tmpvar_15;
  tmpvar_15.x = dot (tmpvar_4.xyz, vec3((tmpvar_10.y + tmpvar_14)));
  tmpvar_15.y = tmpvar_14;
  highp vec4 tmpvar_16;
  tmpvar_16 = abs(((
    fract((((
      fract(((_Time.yy + tmpvar_15).xxyy * vec4(1.975, 0.793, 0.375, 0.193)))
     * 2.0) - 1.0) + 0.5))
   * 2.0) - 1.0));
  highp vec4 tmpvar_17;
  tmpvar_17 = ((tmpvar_16 * tmpvar_16) * (3.0 - (2.0 * tmpvar_16)));
  highp vec2 tmpvar_18;
  tmpvar_18 = (tmpvar_17.xz + tmpvar_17.yw);
  bend_12.xz = ((tmpvar_10.y * 0.1) * tmpvar_9).xz;
  bend_12.y = (_glesMultiTexCoord1.y * 0.3);
  pos_11.xyz = (tmpvar_4.xyz + ((
    (tmpvar_18.xyx * bend_12)
   + 
    ((_Wind.xyz * tmpvar_18.y) * _glesMultiTexCoord1.y)
  ) * _Wind.w));
  pos_11.xyz = (pos_11.xyz + (_glesMultiTexCoord1.x * _Wind.xyz));
  highp vec4 tmpvar_19;
  tmpvar_19.w = 1.0;
  tmpvar_19.xyz = mix ((pos_11.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_11.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_11.xyz, vec3(_SquashAmount));
  tmpvar_4 = tmpvar_19;
  highp mat3 tmpvar_20;
  tmpvar_20[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_20[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_20[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_3.xyz = normalize((tmpvar_20 * normalize(tmpvar_9)));
  tmpvar_3.w = -(((glstate_matrix_modelview0 * tmpvar_19).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * tmpvar_19);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_3;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float alpha_2;
  lowp float tmpvar_3;
  tmpvar_3 = texture2D (_MainTex, xlv_TEXCOORD0).w;
  alpha_2 = tmpvar_3;
  mediump float x_4;
  x_4 = (alpha_2 - _Cutoff);
  if ((x_4 < 0.0)) {
    discard;
  };
  highp vec4 enc_5;
  highp vec2 enc_6;
  enc_6 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_6 = (enc_6 / 1.7777);
  enc_6 = ((enc_6 * 0.5) + 0.5);
  enc_5.xy = enc_6;
  highp vec2 enc_7;
  highp vec2 tmpvar_8;
  tmpvar_8 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_7.y = tmpvar_8.y;
  enc_7.x = (tmpvar_8.x - (tmpvar_8.y * 0.003921569));
  enc_5.zw = enc_7;
  tmpvar_1 = enc_5;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Bind "tangent" TexCoord4
ConstBuffer "$Globals" 208
Vector 144 [_Wind]
ConstBuffer "UnityPerCamera" 144
Vector 0 [_Time]
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
Matrix 192 [_Object2World]
ConstBuffer "UnityTerrain" 272
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityPerDraw" 2
BindCB  "UnityTerrain" 3
"vs_4_0_level_9_1
root12:aaaeaaaa
eefiecedljapjdaobmonmkhhkkgjpbikmjifemblabaaaaaabmbaaaaaaeaaaaaa
daaaaaaakaafaaaaleaoaaaakmapaaaaebgpgodjgiafaaaagiafaaaaaaacpopp
piaeaaaahaaaaaaaagaaceaaaaaagmaaaaaagmaaaaaaceaaabaagmaaaaaaajaa
abaaabaaaaaaaaaaabaaaaaaabaaacaaaaaaaaaaabaaafaaabaaadaaaaaaaaaa
acaaaaaaapaaaeaaaaaaaaaaadaaagaaabaabdaaaaaaaaaaadaaalaaacaabeaa
aaaaaaaaaaaaaaaaaaacpoppfbaaaaafbgaaapkamnmmpmdpamaceldpaaaamado
mlkbefdofbaaaaafbhaaapkaaaaaiadpaaaaaaeaaaaaaalpaaaaialpfbaaaaaf
biaaapkaaaaaaaeaaaaaeaeamnmmmmdnjkjjjjdobpaaaaacafaaaaiaaaaaapja
bpaaaaacafaaabiaabaaapjabpaaaaacafaaaciaacaaapjabpaaaaacafaaadia
adaaapjabpaaaaacafaaaeiaaeaaapjabpaaaaacafaaahiaahaaapjaaiaaaaad
aaaaaiiaacaaoejaapaaoekaaiaaaaadaaaaabiaacaaoejaamaaoekaaiaaaaad
aaaaaciaacaaoejaanaaoekaaiaaaaadaaaaaeiaacaaoejaaoaaoekaajaaaaad
aaaaaiiaaaaaoeiaaaaaoeiaahaaaaacaaaaaiiaaaaappiaaeaaaaaeaaaaahia
aaaaoeiaaaaappiaacaaoejbcdaaaaacaaaaaiiaabaappjaacaaaaadaaaaaiia
aaaappibbhaaaakaaeaaaaaeaaaaahiaaaaappiaaaaaoeiaacaaoejaceaaaaac
abaaahiaaaaaoeiaafaaaaadacaaahiaabaaffiaanaaoekaaeaaaaaeabaaalia
amaakekaabaaaaiaacaakeiaaeaaaaaeabaaahiaaoaaoekaabaakkiaabaapeia
aiaaaaadaaaaaciaabaaoeiaabaaoeiaahaaaaacaaaaaciaaaaaffiaafaaaaad
abaaahoaaaaaffiaabaaoeiaafaaaaadaaaaaciaahaaffjabiaakkkaafaaaaad
aaaaafiaaaaaoeiaaaaaffiaafaaaaadabaaadiaacaaoejaamaaoekaacaaaaad
abaaabiaabaaffiaabaaaaiaafaaaaadacaaadiaacaaoejaanaaoekaacaaaaad
abaaaciaacaaffiaacaaaaiaafaaaaadacaaadiaacaaoejaaoaaoekaacaaaaad
abaaaeiaacaaffiaacaaaaiaaeaaaaaeabaaahiaabaaoeiaaaaappiaaaaaoeja
afaaaaadabaaahiaabaaoeiabdaaoekaabaaaaacacaaabiabaaappkaabaaaaac
acaaaciabbaappkaabaaaaacacaaaeiabcaappkaaiaaaaadaaaaaiiaacaaoeia
bhaaaakaacaaaaadacaaaciaaaaappiaahaaaajaacaaaaadaaaaaiiaacaaffia
ahaaffjaaiaaaaadacaaabiaabaaoeiaaaaappiaacaaaaadacaaapiaacaafaia
acaaffkaafaaaaadacaaapiaacaaoeiabgaaoekabdaaaaacacaaapiaacaaoeia
aeaaaaaeacaaapiaacaaoeiabhaaffkabhaakkkabdaaaaacacaaapiaacaaoeia
aeaaaaaeacaaapiaacaaoeiabhaaffkabhaappkacdaaaaacacaaapiaacaaoeia
afaaaaadadaaapiaacaaoeiaacaaoeiaaeaaaaaeacaaapiaacaaoeiabiaaaakb
biaaffkaafaaaaadacaaapiaacaaoeiaadaaoeiaacaaaaadacaaadiaacaaonia
acaaoiiaafaaaaadadaaahiaacaaffiaabaaoekaafaaaaadadaaahiaadaaoeia
aeaaffjaafaaaaadaaaaaciaacaaffiaaeaaffjaabaaaaacacaaaeiabiaappka
aeaaaaaeaaaaahiaacaamiiaaaaaoeiaadaaoeiaaeaaaaaeaaaaahiaaaaaoeia
abaappkaabaaoeiaaeaaaaaeaaaaahiaaeaaaajaabaaoekaaaaaoeiaaiaaaaad
aaaaaiiabeaaoekaaaaaoeiaacaaaaadaaaaaiiaaaaappiabeaappkaaeaaaaae
abaaahiaaaaappiabeaaoekbaaaaoeiabcaaaaaeacaaahiabfaaaakaaaaaoeia
abaaoeiaafaaaaadaaaaabiaacaaffiaajaakkkaaeaaaaaeaaaaabiaaiaakkka
acaaaaiaaaaaaaiaaeaaaaaeaaaaabiaakaakkkaacaakkiaaaaaaaiaacaaaaad
aaaaabiaaaaaaaiaalaakkkaafaaaaadaaaaabiaaaaaaaiaadaappkaabaaaaac
abaaaioaaaaaaaibafaaaaadaaaaapiaacaaffiaafaaoekaaeaaaaaeaaaaapia
aeaaoekaacaaaaiaaaaaoeiaaeaaaaaeaaaaapiaagaaoekaacaakkiaaaaaoeia
acaaaaadaaaaapiaaaaaoeiaahaaoekaaeaaaaaeaaaaadmaaaaappiaaaaaoeka
aaaaoeiaabaaaaacaaaaammaaaaaoeiaabaaaaacaaaaadoaadaaoejappppaaaa
fdeieefcamajaaaaeaaaabaaedacaaaafjaaaaaeegiocaaaaaaaaaaaakaaaaaa
fjaaaaaeegiocaaaabaaaaaaagaaaaaafjaaaaaeegiocaaaacaaaaaaapaaaaaa
fjaaaaaeegiocaaaadaaaaaaanaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaad
icbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaa
fpaaaaaddcbabaaaaeaaaaaafpaaaaaddcbabaaaahaaaaaaghaaaaaepccabaaa
aaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaa
giaaaaacafaaaaaadgaaaaagbcaabaaaaaaaaaaadkiacaaaacaaaaaaamaaaaaa
dgaaaaagccaabaaaaaaaaaaadkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaa
aaaaaaaadkiacaaaacaaaaaaaoaaaaaabaaaaaakbcaabaaaaaaaaaaaegacbaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaaaaaaaaaaaahccaabaaa
aaaaaaaaakaabaaaaaaaaaaaakbabaaaahaaaaaaaaaaaaahecaabaaaaaaaaaaa
bkaabaaaaaaaaaaabkbabaaaahaaaaaaapaaaaaibcaabaaaabaaaaaaegbabaaa
acaaaaaaegiacaaaacaaaaaaaiaaaaaaapaaaaaiccaabaaaabaaaaaaegbabaaa
acaaaaaaegiacaaaacaaaaaaajaaaaaaapaaaaaiecaabaaaabaaaaaaegbabaaa
acaaaaaaegiacaaaacaaaaaaakaaaaaaaaaaaaaiicaabaaaaaaaaaaadkbabaia
mbaaaaaaabaaaaaaabeaaaaaaaaaiadpdcaaaaajhcaabaaaabaaaaaaegacbaaa
abaaaaaapgapbaaaaaaaaaaaegbcbaaaaaaaaaaadiaaaaaihcaabaaaabaaaaaa
egacbaaaabaaaaaaegiccaaaadaaaaaaagaaaaaabaaaaaahbcaabaaaaaaaaaaa
egacbaaaabaaaaaakgakbaaaaaaaaaaaaaaaaaaipcaabaaaacaaaaaaagafbaaa
aaaaaaaafgifcaaaabaaaaaaaaaaaaaadiaaaaakpcaabaaaacaaaaaaegaobaaa
acaaaaaaaceaaaaamnmmpmdpamaceldpaaaamadomlkbefdobkaaaaafpcaabaaa
acaaaaaaegaobaaaacaaaaaadcaaaaappcaabaaaacaaaaaaegaobaaaacaaaaaa
aceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaeaaceaaaaaaaaaaalpaaaaaalp
aaaaaalpaaaaaalpbkaaaaafpcaabaaaacaaaaaaegaobaaaacaaaaaadcaaaaap
pcaabaaaacaaaaaaegaobaaaacaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaea
aaaaaaeaaceaaaaaaaaaialpaaaaialpaaaaialpaaaaialpdiaaaaajpcaabaaa
adaaaaaaegaobaiaibaaaaaaacaaaaaaegaobaiaibaaaaaaacaaaaaadcaaaaba
pcaabaaaacaaaaaaegaobaiambaaaaaaacaaaaaaaceaaaaaaaaaaaeaaaaaaaea
aaaaaaeaaaaaaaeaaceaaaaaaaaaeaeaaaaaeaeaaaaaeaeaaaaaeaeadiaaaaah
pcaabaaaacaaaaaaegaobaaaacaaaaaaegaobaaaadaaaaaaaaaaaaahdcaabaaa
aaaaaaaangafbaaaacaaaaaaigaabaaaacaaaaaadiaaaaaihcaabaaaacaaaaaa
fgafbaaaaaaaaaaaegiccaaaaaaaaaaaajaaaaaadiaaaaahhcaabaaaacaaaaaa
egacbaaaacaaaaaafgbfbaaaaeaaaaaadiaaaaahccaabaaaadaaaaaabkaabaaa
aaaaaaaabkbabaaaaeaaaaaabaaaaaaiicaabaaaaeaaaaaaegbcbaaaacaaaaaa
egiccaaaacaaaaaaalaaaaaabaaaaaaibcaabaaaaeaaaaaaegbcbaaaacaaaaaa
egiccaaaacaaaaaaaiaaaaaabaaaaaaiccaabaaaaeaaaaaaegbcbaaaacaaaaaa
egiccaaaacaaaaaaajaaaaaabaaaaaaiecaabaaaaeaaaaaaegbcbaaaacaaaaaa
egiccaaaacaaaaaaakaaaaaabbaaaaahccaabaaaaaaaaaaaegaobaaaaeaaaaaa
egaobaaaaeaaaaaaeeaaaaafccaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaak
hcaabaaaaeaaaaaaegacbaaaaeaaaaaafgafbaaaaaaaaaaaegbcbaiaebaaaaaa
acaaaaaadcaaaaajhcaabaaaaeaaaaaapgapbaaaaaaaaaaaegacbaaaaeaaaaaa
egbcbaaaacaaaaaadiaaaaahccaabaaaaaaaaaaabkbabaaaahaaaaaaabeaaaaa
mnmmmmdndiaaaaahfcaabaaaadaaaaaaagacbaaaaeaaaaaafgafbaaaaaaaaaaa
dgaaaaafecaabaaaaaaaaaaaabeaaaaajkjjjjdodcaaaaajhcaabaaaaaaaaaaa
igaabaaaaaaaaaaaegacbaaaadaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaa
aaaaaaaaegacbaaaaaaaaaaapgipcaaaaaaaaaaaajaaaaaaegacbaaaabaaaaaa
dcaaaaakhcaabaaaaaaaaaaaagbabaaaaeaaaaaaegiccaaaaaaaaaaaajaaaaaa
egacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaadaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaa
adaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaa
egiccaaaadaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaa
egacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
agiacaaaadaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaa
egiocaaaacaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaaegbabaaaadaaaaaa
baaaaaahicaabaaaaaaaaaaaegacbaaaaeaaaaaaegacbaaaaeaaaaaaeeaaaaaf
icaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhcaabaaaabaaaaaapgapbaaa
aaaaaaaaegacbaaaaeaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaaabaaaaaa
egiccaaaacaaaaaaajaaaaaadcaaaaaklcaabaaaabaaaaaaegiicaaaacaaaaaa
aiaaaaaaagaabaaaabaaaaaaegaibaaaacaaaaaadcaaaaakhcaabaaaabaaaaaa
egiccaaaacaaaaaaakaaaaaakgakbaaaabaaaaaaegadbaaaabaaaaaabaaaaaah
icaabaaaaaaaaaaaegacbaaaabaaaaaaegacbaaaabaaaaaaeeaaaaaficaabaaa
aaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaacaaaaaapgapbaaaaaaaaaaa
egacbaaaabaaaaaadiaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaa
acaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaacaaaaaaaeaaaaaa
akaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
acaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaackiacaaaacaaaaaaahaaaaaadiaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaadkiacaaaabaaaaaaafaaaaaadgaaaaagiccabaaa
acaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaabejfdeheopaaaaaaaaiaaaaaa
aiaaaaaamiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaanbaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaiaaaanjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaacaaaaaaahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaa
apadaaaaoaaaaaaaabaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapadaaaaoaaaaaaa
acaaaaaaaaaaaaaaadaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaa
adaaaaaaagaaaaaaapaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaa
apadaaaafaepfdejfeejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffied
epepfceeaaedepemepfcaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _LightColor0;
uniform 	lowp vec4 _SpecColor;
uniform 	mediump vec4 unity_LightGammaCorrectionConsts;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp vec4 _Color;
uniform 	lowp vec3 _TranslucencyColor;
uniform 	lowp float _TranslucencyViewDependency;
uniform 	mediump float _ShadowStrength;
uniform 	lowp float _Cutoff;
in highp vec4 in_POSITION0;
in highp vec4 in_TANGENT0;
in highp vec3 in_NORMAL0;
in highp vec4 in_TEXCOORD0;
in highp vec4 in_TEXCOORD1;
in lowp vec4 in_COLOR0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec3 t0;
highp vec4 t1;
highp vec4 t2;
highp vec4 t3;
highp vec4 t4;
highp float t5;
highp float t10;
highp float t15;
void main()
{
    t0.x = _Object2World[0].w;
    t0.y = _Object2World[1].w;
    t0.z = _Object2World[2].w;
    t0.x = dot(t0.xyz, vec3(1.0, 1.0, 1.0));
    t0.y = t0.x + in_COLOR0.x;
    t10 = t0.y + in_COLOR0.y;
    t1.x = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[0].xy);
    t1.y = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[1].xy);
    t1.z = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[2].xy);
    t15 = -abs(in_TANGENT0.w) + 1.0;
    t1.xyz = t1.xyz * vec3(t15) + in_POSITION0.xyz;
    t1.xyz = t1.xyz * _TreeInstanceScale.xyz;
    t0.x = dot(t1.xyz, vec3(t10));
    t2 = t0.xxyy + _Time.yyyy;
    t2 = t2 * vec4(1.97500002, 0.792999983, 0.375, 0.193000004);
    t2 = fract(t2);
    t2 = t2 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-0.5, -0.5, -0.5, -0.5);
    t2 = fract(t2);
    t2 = t2 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-1.0, -1.0, -1.0, -1.0);
    t3 = abs(t2) * abs(t2);
    t2 = -abs(t2) * vec4(2.0, 2.0, 2.0, 2.0) + vec4(3.0, 3.0, 3.0, 3.0);
    t2 = t2 * t3;
    t0.xy = vec2(t2.y + t2.x, t2.w + t2.z);
    t2.xyz = t0.yyy * _Wind.xyz;
    t2.xyz = t2.xyz * in_TEXCOORD1.yyy;
    t3.y = t0.y * in_TEXCOORD1.y;
    t4.w = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[3].xyz);
    t4.x = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[0].xyz);
    t4.y = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[1].xyz);
    t4.z = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[2].xyz);
    t5 = dot(t4, t4);
    t5 = inversesqrt(t5);
    t4.xyz = t4.xyz * vec3(t5) + (-in_NORMAL0.xyz);
    t4.xyz = vec3(t15) * t4.xyz + in_NORMAL0.xyz;
    t5 = in_COLOR0.y * 0.100000001;
    t3.xz = t4.xz * vec2(t5);
    t0.z = 0.300000012;
    t0.xyz = t0.xzx * t3.xyz + t2.xyz;
    t0.xyz = t0.xyz * _Wind.www + t1.xyz;
    t0.xyz = in_TEXCOORD1.xxx * _Wind.xyz + t0.xyz;
    t15 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t15 = t15 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t15)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t15 = dot(t4.xyz, t4.xyz);
    t15 = inversesqrt(t15);
    t1.xyz = vec3(t15) * t4.xyz;
    t2.xyz = t1.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t1.xyw = glstate_matrix_invtrans_modelview0[0].xyz * t1.xxx + t2.xyz;
    t1.xyz = glstate_matrix_invtrans_modelview0[2].xyz * t1.zzz + t1.xyw;
    t15 = dot(t1.xyz, t1.xyz);
    t15 = inversesqrt(t15);
    vs_TEXCOORD1.xyz = vec3(t15) * t1.xyz;
    t5 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t5;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _LightColor0;
uniform 	lowp vec4 _SpecColor;
uniform 	mediump vec4 unity_LightGammaCorrectionConsts;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp vec4 _Color;
uniform 	lowp vec3 _TranslucencyColor;
uniform 	lowp float _TranslucencyViewDependency;
uniform 	mediump float _ShadowStrength;
uniform 	lowp float _Cutoff;
uniform lowp sampler2D _MainTex;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
mediump float t16_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t16_1 = t10_0 + (-_Cutoff);
    tb0 = t16_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _LightColor0;
uniform 	vec4 _SpecColor;
uniform 	vec4 unity_LightGammaCorrectionConsts;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	vec4 _Color;
uniform 	vec3 _TranslucencyColor;
uniform 	float _TranslucencyViewDependency;
uniform 	float _ShadowStrength;
uniform 	float _Cutoff;
in  vec4 in_POSITION0;
in  vec4 in_TANGENT0;
in  vec3 in_NORMAL0;
in  vec4 in_TEXCOORD0;
in  vec4 in_TEXCOORD1;
in  vec4 in_COLOR0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec3 t0;
vec4 t1;
vec4 t2;
vec4 t3;
vec4 t4;
float t5;
float t10;
float t15;
void main()
{
    t0.x = _Object2World[0].w;
    t0.y = _Object2World[1].w;
    t0.z = _Object2World[2].w;
    t0.x = dot(t0.xyz, vec3(1.0, 1.0, 1.0));
    t0.y = t0.x + in_COLOR0.x;
    t10 = t0.y + in_COLOR0.y;
    t1.x = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[0].xy);
    t1.y = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[1].xy);
    t1.z = dot(in_NORMAL0.xy, glstate_matrix_invtrans_modelview0[2].xy);
    t15 = -abs(in_TANGENT0.w) + 1.0;
    t1.xyz = t1.xyz * vec3(t15) + in_POSITION0.xyz;
    t1.xyz = t1.xyz * _TreeInstanceScale.xyz;
    t0.x = dot(t1.xyz, vec3(t10));
    t2 = t0.xxyy + _Time.yyyy;
    t2 = t2 * vec4(1.97500002, 0.792999983, 0.375, 0.193000004);
    t2 = fract(t2);
    t2 = t2 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-0.5, -0.5, -0.5, -0.5);
    t2 = fract(t2);
    t2 = t2 * vec4(2.0, 2.0, 2.0, 2.0) + vec4(-1.0, -1.0, -1.0, -1.0);
    t3 = abs(t2) * abs(t2);
    t2 = -abs(t2) * vec4(2.0, 2.0, 2.0, 2.0) + vec4(3.0, 3.0, 3.0, 3.0);
    t2 = t2 * t3;
    t0.xy = t2.yw + t2.xz;
    t2.xyz = t0.yyy * _Wind.xyz;
    t2.xyz = t2.xyz * in_TEXCOORD1.yyy;
    t3.y = t0.y * in_TEXCOORD1.y;
    t4.w = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[3].xyz);
    t4.x = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[0].xyz);
    t4.y = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[1].xyz);
    t4.z = dot(in_NORMAL0.xyz, glstate_matrix_invtrans_modelview0[2].xyz);
    t5 = dot(t4, t4);
    t5 = inversesqrt(t5);
    t4.xyz = t4.xyz * vec3(t5) + (-in_NORMAL0.xyz);
    t4.xyz = vec3(t15) * t4.xyz + in_NORMAL0.xyz;
    t5 = in_COLOR0.y * 0.100000001;
    t3.xz = t4.xz * vec2(t5);
    t0.z = 0.300000012;
    t0.xyz = t0.xzx * t3.xyz + t2.xyz;
    t0.xyz = t0.xyz * _Wind.www + t1.xyz;
    t0.xyz = in_TEXCOORD1.xxx * _Wind.xyz + t0.xyz;
    t15 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t15 = t15 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t15)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t15 = dot(t4.xyz, t4.xyz);
    t15 = inversesqrt(t15);
    t1.xyz = vec3(t15) * t4.xyz;
    t2.xyz = t1.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t1.xyw = glstate_matrix_invtrans_modelview0[0].xyz * t1.xxx + t2.xyz;
    t1.xyz = glstate_matrix_invtrans_modelview0[2].xyz * t1.zzz + t1.xyw;
    t15 = dot(t1.xyz, t1.xyz);
    t15 = inversesqrt(t15);
    vs_TEXCOORD1.xyz = vec3(t15) * t1.xyz;
    t5 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t5;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _LightColor0;
uniform 	vec4 _SpecColor;
uniform 	vec4 unity_LightGammaCorrectionConsts;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	vec4 _Color;
uniform 	vec3 _TranslucencyColor;
uniform 	float _TranslucencyViewDependency;
uniform 	float _ShadowStrength;
uniform 	float _Cutoff;
uniform  sampler2D _MainTex;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 1, 0.281262308, 0.5, 0.00392156886
def c2, 1, 255, 0, 0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
add_pp r0, r0.w, -c0.x
texkill r0
add r0.x, t1.z, c1.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c1.y, c1.z
mul r1.xy, t1.w, c2
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 208
Float 196 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefieceddhhfcejmapjelekpkaijcoinfihicnjoabaaaaaajiacaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcmaabaaaaeaaaaaaahaaaaaaa
fjaaaaaeegiocaaaaaaaaaaaanaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaae
aahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaaaaaaaaaj
bcaabaaaaaaaaaaadkaabaaaaaaaaaaabkiacaiaebaaaaaaaaaaaaaaamaaaaaa
dbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaaaaaaaaaaanaaaead
akaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaaaaaaaaaa
dcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaak
dcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaa
aaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaa
dgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 208
Float 196 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecednmbhmmjafefjaiinfnkjcdcfbcodnioeabaaaaaaoeadaaaaaeaaaaaa
daaaaaaahiabaaaaeaadaaaalaadaaaaebgpgodjeaabaaaaeaabaaaaaaacpppp
amabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaamaaabaaaaaaaaaaaaaaaaacppppfbaaaaafabaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafacaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaaadlabpaaaaacaaaaaaiaabaaaplabpaaaaacaaaaaaja
aaaiapkaecaaaaadaaaacpiaaaaaoelaaaaioekaacaaaaadaaaacpiaaaaappia
aaaaffkbebaaaaabaaaaapiaacaaaaadaaaaabiaabaakklaabaaaakaagaaaaac
aaaaabiaaaaaaaiaafaaaaadaaaaadiaaaaaaaiaabaaoelaaeaaaaaeaaaacdia
aaaaoeiaabaaffkaabaakkkaafaaaaadabaaadiaabaapplaacaaoekabdaaaaac
abaaadiaabaaoeiaaeaaaaaeaaaaceiaabaaffiaabaappkbabaaaaiaabaaaaac
aaaaciiaabaaffiaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcmaabaaaa
eaaaaaaahaaaaaaafjaaaaaeegiocaaaaaaaaaaaanaaaaaafkaaaaadaagabaaa
aaaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaa
gcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaaaaaaaaajbcaabaaaaaaaaaaadkaabaaaaaaaaaaabkiacaiaebaaaaaa
aaaaaaaaamaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaa
aaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaa
acaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaa
agaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaa
jnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaa
aaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadp
aaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
dcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadl
akaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab
ejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
fmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaafdfgfpfaepfdejfe
ejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaa
caaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgf
heaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TreeOpaque" "DisableBatching"="true" }
 Pass {
  Tags { "RenderType"="TreeOpaque" "DisableBatching"="true" }
  GpuProgramID 270309
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _TreeInstanceScale;
uniform mat4 _TerrainEngineBendTree;
uniform vec4 _SquashPlaneNormal;
uniform float _SquashAmount;
varying vec4 xlv_TEXCOORD0;
void main ()
{
  vec4 tmpvar_1;
  vec4 pos_2;
  pos_2.w = gl_Vertex.w;
  pos_2.xyz = (gl_Vertex.xyz * _TreeInstanceScale.xyz);
  vec4 tmpvar_3;
  tmpvar_3.w = 0.0;
  tmpvar_3.xyz = pos_2.xyz;
  pos_2.xyz = mix (pos_2.xyz, (_TerrainEngineBendTree * tmpvar_3).xyz, gl_Color.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = mix ((pos_2.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_2.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_2.xyz, vec3(_SquashAmount));
  pos_2 = tmpvar_4;
  mat3 tmpvar_5;
  tmpvar_5[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_5[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_5[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_5 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * tmpvar_4).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * tmpvar_4);
  xlv_TEXCOORD0 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
varying vec4 xlv_TEXCOORD0;
void main ()
{
  vec4 enc_1;
  vec2 enc_2;
  enc_2 = (xlv_TEXCOORD0.xy / (xlv_TEXCOORD0.z + 1.0));
  enc_2 = (enc_2 / 1.7777);
  enc_2 = ((enc_2 * 0.5) + 0.5);
  enc_1.xy = enc_2;
  vec2 enc_3;
  vec2 tmpvar_4;
  tmpvar_4 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD0.w));
  enc_3.y = tmpvar_4.y;
  enc_3.x = (tmpvar_4.x - (tmpvar_4.y * 0.003921569));
  enc_1.zw = enc_3;
  gl_FragData[0] = enc_1;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Matrix 10 [_TerrainEngineBendTree] 3
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 13 [_ProjectionParams]
Float 16 [_SquashAmount]
Vector 15 [_SquashPlaneNormal]
Vector 14 [_TreeInstanceScale]
"vs_2_0
def c17, 1, 0, 0, 0
dcl_position v0
dcl_normal v1
dcl_color v2
mul r0.xyz, v0, c14
dp3 r1.x, c10, r0
dp3 r1.y, c11, r0
dp3 r1.z, c12, r0
mad r1.xyz, v0, -c14, r1
mad r0.xyz, v2.w, r1, r0
dp3 r0.w, c15, r0
add r0.w, r0.w, c15.w
mad r1.xyz, r0.w, -c15, r0
lrp r2.xyz, c16.x, r0, r1
mov r2.w, c17.x
dp4 oPos.x, c0, r2
dp4 oPos.y, c1, r2
dp4 oPos.z, c2, r2
dp4 oPos.w, c3, r2
dp4 r0.x, c6, r2
mul r0.x, r0.x, c13.w
mov oT0.w, -r0.x
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT0.xyz, r0.w, r0

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefiecededgkoifelblcldkikbdhokjknaajkohcabaaaaaaciafaaaaadaaaaaa
cmaaaaaajmaaaaaapeaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaiaaaafaepfdejfeejepeoaaeoepfcenebemaaedepemepfcaaklklepfdeheo
faaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaklklklfdeieefccmaeaaaaeaaaabaa
alabaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaa
alaaaaaafjaaaaaeegiocaaaacaaaaaaanaaaaaafpaaaaadhcbabaaaaaaaaaaa
fpaaaaadhcbabaaaabaaaaaafpaaaaadicbabaaaacaaaaaaghaaaaaepccabaaa
aaaaaaaaabaaaaaagfaaaaadpccabaaaabaaaaaagiaaaaacacaaaaaadiaaaaai
hcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaadiaaaaai
hcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaaiaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaacaaaaaaahaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaajaaaaaakgakbaaa
aaaaaaaaegacbaaaabaaaaaadcaaaaalhcaabaaaabaaaaaaegbcbaiaebaaaaaa
aaaaaaaaegiccaaaacaaaaaaagaaaaaaegacbaaaabaaaaaadcaaaaajhcaabaaa
aaaaaaaapgbpbaaaacaaaaaaegacbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaai
icaabaaaaaaaaaaaegiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaai
icaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaaacaaaaaaalaaaaaadcaaaaal
hcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaia
ebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaagiacaaaacaaaaaaamaaaaaa
egacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaa
aaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaa
abaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaa
abaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaa
aaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaaegiocaaaabaaaaaaadaaaaaa
diaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaaaaaaaaa
bkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaa
ckaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaackiacaaaabaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaabaaaaaaakaabaia
ebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaabaaaaaaegiccaaa
abaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaaiaaaaaa
agbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
abaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaa
dkaabaaaaaaaaaaadiaaaaahhccabaaaabaaaaaapgapbaaaaaaaaaaaegacbaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp vec4 _TreeInstanceScale;
uniform highp mat4 _TerrainEngineBendTree;
uniform highp vec4 _SquashPlaneNormal;
uniform highp float _SquashAmount;
varying highp vec4 xlv_TEXCOORD0;
void main ()
{
  lowp vec4 tmpvar_1;
  tmpvar_1 = _glesColor;
  highp vec4 tmpvar_2;
  highp vec4 pos_3;
  pos_3.w = _glesVertex.w;
  highp float alpha_4;
  alpha_4 = tmpvar_1.w;
  pos_3.xyz = (_glesVertex.xyz * _TreeInstanceScale.xyz);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = pos_3.xyz;
  pos_3.xyz = mix (pos_3.xyz, (_TerrainEngineBendTree * tmpvar_5).xyz, vec3(alpha_4));
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = mix ((pos_3.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_3.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_3.xyz, vec3(_SquashAmount));
  pos_3 = tmpvar_6;
  highp mat3 tmpvar_7;
  tmpvar_7[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_7[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_7[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_2.xyz = normalize((tmpvar_7 * _glesNormal));
  tmpvar_2.w = -(((glstate_matrix_modelview0 * tmpvar_6).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * tmpvar_6);
  xlv_TEXCOORD0 = tmpvar_2;
}


#endif
#ifdef FRAGMENT
varying highp vec4 xlv_TEXCOORD0;
void main ()
{
  lowp vec4 tmpvar_1;
  highp vec4 enc_2;
  highp vec2 enc_3;
  enc_3 = (xlv_TEXCOORD0.xy / (xlv_TEXCOORD0.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  highp vec2 enc_4;
  highp vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD0.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  tmpvar_1 = enc_2;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefieceddojdhpohaapocoecpicebiiihbipmdohabaaaaaakaahaaaaaeaaaaaa
daaaaaaakeacaaaaniagaaaaeiahaaaaebgpgodjgmacaaaagmacaaaaaaacpopp
beacaaaafiaaaaaaaeaaceaaaaaafeaaaaaafeaaaaaaceaaabaafeaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaacaaagaaaeaaanaaaaaaaaaa
acaaalaaacaabbaaaaaaaaaaaaaaaaaaaaacpoppbpaaaaacafaaaaiaaaaaapja
bpaaaaacafaaabiaabaaapjabpaaaaacafaaaciaacaaapjaafaaaaadaaaaahia
abaaffjaalaaoekaaeaaaaaeaaaaahiaakaaoekaabaaaajaaaaaoeiaaeaaaaae
aaaaahiaamaaoekaabaakkjaaaaaoeiaaiaaaaadaaaaaiiaaaaaoeiaaaaaoeia
ahaaaaacaaaaaiiaaaaappiaafaaaaadaaaaahoaaaaappiaaaaaoeiaafaaaaad
aaaaahiaaaaaoejaanaaoekaafaaaaadabaaahiaaaaaffiaapaaoekaaeaaaaae
abaaahiaaoaaoekaaaaaaaiaabaaoeiaaeaaaaaeabaaahiabaaaoekaaaaakkia
abaaoeiaaeaaaaaeabaaahiaaaaaoejaanaaoekbabaaoeiaaeaaaaaeaaaaahia
acaappjaabaaoeiaaaaaoeiaaiaaaaadaaaaaiiabbaaoekaaaaaoeiaacaaaaad
aaaaaiiaaaaappiabbaappkaaeaaaaaeabaaahiaaaaappiabbaaoekbaaaaoeia
bcaaaaaeacaaahiabcaaaakaaaaaoeiaabaaoeiaafaaaaadaaaaabiaacaaffia
ahaakkkaaeaaaaaeaaaaabiaagaakkkaacaaaaiaaaaaaaiaaeaaaaaeaaaaabia
aiaakkkaacaakkiaaaaaaaiaacaaaaadaaaaabiaaaaaaaiaajaakkkaafaaaaad
aaaaabiaaaaaaaiaabaappkaabaaaaacaaaaaioaaaaaaaibafaaaaadaaaaapia
acaaffiaadaaoekaaeaaaaaeaaaaapiaacaaoekaacaaaaiaaaaaoeiaaeaaaaae
aaaaapiaaeaaoekaacaakkiaaaaaoeiaacaaaaadaaaaapiaaaaaoeiaafaaoeka
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
ppppaaaafdeieefccmaeaaaaeaaaabaaalabaaaafjaaaaaeegiocaaaaaaaaaaa
agaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaafjaaaaaeegiocaaaacaaaaaa
anaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaafpaaaaad
icbabaaaacaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaadpccabaaa
abaaaaaagiaaaaacacaaaaaadiaaaaaihcaabaaaaaaaaaaaegbcbaaaaaaaaaaa
egiccaaaacaaaaaaagaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiccaaaacaaaaaaaiaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaa
ahaaaaaaagaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaa
egiccaaaacaaaaaaajaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaal
hcaabaaaabaaaaaaegbcbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaa
egacbaaaabaaaaaadcaaaaajhcaabaaaaaaaaaaapgbpbaaaacaaaaaaegacbaaa
abaaaaaaegacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaacaaaaaa
alaaaaaaegacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaa
dkiacaaaacaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaa
aaaaaaaaegiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaa
aaaaaaaaagiacaaaacaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaa
diaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaa
dcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaa
egaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaa
kgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaa
abaaaaaaegiocaaaabaaaaaaadaaaaaadiaaaaaiccaabaaaaaaaaaaabkaabaaa
aaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
abaaaaaaaeaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaakbcaabaaa
aaaaaaaackiacaaaabaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaa
aaaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaa
diaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaa
dgaaaaagiccabaaaabaaaaaaakaabaiaebaaaaaaaaaaaaaadiaaaaaihcaabaaa
aaaaaaaafgbfbaaaabaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaa
aaaaaaaaegiccaaaabaaaaaaaiaaaaaaagbabaaaabaaaaaaegacbaaaaaaaaaaa
dcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaaabaaaaaa
egacbaaaaaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaa
aaaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaa
abaaaaaapgapbaaaaaaaaaaaegacbaaaaaaaaaaadoaaaaabejfdeheogiaaaaaa
adaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaa
fjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaagaaaaaaaaaaaaaaa
aaaaaaaaadaaaaaaacaaaaaaapaiaaaafaepfdejfeejepeoaaeoepfcenebemaa
edepemepfcaaklklepfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl
"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in lowp vec4 in_COLOR0;
out highp vec4 vs_TEXCOORD0;
highp vec3 t0;
highp vec4 t1;
highp float t2;
highp float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD0.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    vs_TEXCOORD0.xyz = vec3(t6) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
in highp vec4 vs_TEXCOORD0;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec2 t1;
void main()
{
    t0.x = vs_TEXCOORD0.z + 1.0;
    t0.xy = vs_TEXCOORD0.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t1.xy = vs_TEXCOORD0.ww * vec2(1.0, 255.0);
    t1.xy = fract(t1.xy);
    t0.z = (-t1.y) * 0.00392156886 + t1.x;
    t0.w = t1.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_COLOR0;
out vec4 vs_TEXCOORD0;
vec3 t0;
vec4 t1;
float t2;
float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD0.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    vs_TEXCOORD0.xyz = vec3(t6) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
in  vec4 vs_TEXCOORD0;
out vec4 SV_Target0;
vec2 t0;
void main()
{
    t0.x = vs_TEXCOORD0.z + 1.0;
    t0.xy = vs_TEXCOORD0.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD0.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
"ps_2_0
def c0, 1, 0.281262308, 0.5, 0.00392156886
def c1, 1, 255, 0, 0
dcl t0
add r0.w, t0.z, c0.x
rcp r0.x, r0.w
mul r0.xy, r0.x, t0
mad_pp r0.xy, r0, c0.y, c0.z
mul r1.xy, t0.w, c1
frc r1.xy, r1
mad_pp r0.z, r1.y, -c0.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
"ps_4_0
root12:aaaaaaaa
eefiecedgningppdhdkaeoblkhckpdmipnfedcoaabaaaaaaniabaaaaadaaaaaa
cmaaaaaaieaaaaaaliaaaaaaejfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcbiabaaaa
eaaaaaaaegaaaaaagcbaaaadpcbabaaaabaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacabaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaabaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaabaaaaaaagaabaaaaaaaaaaa
dcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaak
dcaabaaaaaaaaaaapgbpbaaaabaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaa
aaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaa
dgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
"ps_4_0_level_9_1
root12:aaaaaaaa
eefiecedjpndamchlnfihklhcifkchncgidfnldmabaaaaaaneacaaaaaeaaaaaa
daaaaaaaciabaaaaeiacaaaakaacaaaaebgpgodjpaaaaaaapaaaaaaaaaacpppp
mmaaaaaaceaaaaaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaaaceaaaaacpppp
fbaaaaafaaaaapkaaaaaiadpjnabjadoaaaaaadpibiaiadlfbaaaaafabaaapka
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabpaaaaacaaaaaaiaaaaaaplaacaaaaad
aaaaaiiaaaaakklaaaaaaakaagaaaaacaaaaabiaaaaappiaafaaaaadaaaaadia
aaaaaaiaaaaaoelaaeaaaaaeaaaacdiaaaaaoeiaaaaaffkaaaaakkkaafaaaaad
abaaadiaaaaapplaabaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaaaaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcbiabaaaaeaaaaaaaegaaaaaagcbaaaadpcbabaaa
abaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaaaaaaaahbcaabaaa
aaaaaaaackbabaaaabaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaa
egbabaaaabaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaa
aaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadp
aaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaabaaaaaa
aceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaa
egaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaa
abeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaa
aaaaaaaadoaaaaabejfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl
epfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TreeTransparentCutout" "DisableBatching"="true" }
 Pass {
  Tags { "RenderType"="TreeTransparentCutout" "DisableBatching"="true" }
  GpuProgramID 374526
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _TreeInstanceScale;
uniform mat4 _TerrainEngineBendTree;
uniform vec4 _SquashPlaneNormal;
uniform float _SquashAmount;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 pos_2;
  pos_2.w = gl_Vertex.w;
  pos_2.xyz = (gl_Vertex.xyz * _TreeInstanceScale.xyz);
  vec4 tmpvar_3;
  tmpvar_3.w = 0.0;
  tmpvar_3.xyz = pos_2.xyz;
  pos_2.xyz = mix (pos_2.xyz, (_TerrainEngineBendTree * tmpvar_3).xyz, gl_Color.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = mix ((pos_2.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_2.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_2.xyz, vec3(_SquashAmount));
  pos_2 = tmpvar_4;
  mat3 tmpvar_5;
  tmpvar_5[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_5[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_5[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_5 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * tmpvar_4).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * tmpvar_4);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = (texture2D (_MainTex, xlv_TEXCOORD0).w - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 10 [_TerrainEngineBendTree] 3
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 13 [_ProjectionParams]
Float 16 [_SquashAmount]
Vector 15 [_SquashPlaneNormal]
Vector 14 [_TreeInstanceScale]
"vs_2_0
def c17, 1, 0, 0, 0
dcl_position v0
dcl_normal v1
dcl_color v2
dcl_texcoord v3
mul r0.xyz, v0, c14
dp3 r1.x, c10, r0
dp3 r1.y, c11, r0
dp3 r1.z, c12, r0
mad r1.xyz, v0, -c14, r1
mad r0.xyz, v2.w, r1, r0
dp3 r0.w, c15, r0
add r0.w, r0.w, c15.w
mad r1.xyz, r0.w, -c15, r0
lrp r2.xyz, c16.x, r0, r1
mov r2.w, c17.x
dp4 oPos.x, c0, r2
dp4 oPos.y, c1, r2
dp4 oPos.z, c2, r2
dp4 oPos.w, c3, r2
dp4 r0.x, c6, r2
mul r0.x, r0.x, c13.w
mov oT1.w, -r0.x
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT1.xyz, r0.w, r0
mov oT0.xy, v3

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefieceddipeaphmfgaaagcghplapcdjbjpdkfahabaaaaaaimafaaaaadaaaaaa
cmaaaaaalmaaaaaacmabaaaaejfdeheoiiaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaahbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaahiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaiaaaahoaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaafaepfdej
feejepeoaaeoepfcenebemaaedepemepfcaafeeffiedepepfceeaaklepfdeheo
giaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaa
feeffiedepepfceeaaklklklfdeieefcfiaeaaaaeaaaabaabgabaaaafjaaaaae
egiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaafjaaaaae
egiocaaaacaaaaaaanaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadhcbabaaa
abaaaaaafpaaaaadicbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaaghaaaaae
pccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaagiaaaaacacaaaaaadiaaaaaihcaabaaaaaaaaaaaegbcbaaaaaaaaaaa
egiccaaaacaaaaaaagaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiccaaaacaaaaaaaiaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaa
ahaaaaaaagaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaa
egiccaaaacaaaaaaajaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaal
hcaabaaaabaaaaaaegbcbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaa
egacbaaaabaaaaaadcaaaaajhcaabaaaaaaaaaaapgbpbaaaacaaaaaaegacbaaa
abaaaaaaegacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaacaaaaaa
alaaaaaaegacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaa
dkiacaaaacaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaa
aaaaaaaaegiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaa
aaaaaaaaagiacaaaacaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaa
diaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaa
dcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaa
egaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaa
kgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaa
abaaaaaaegiocaaaabaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaaegbabaaa
adaaaaaadiaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaa
afaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaa
aaaaaaaabkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaa
agaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaa
akaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaa
akaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaa
akaabaiaebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaabaaaaaa
egiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaa
aiaaaaaaagbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaa
egiccaaaabaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaah
icaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaa
aaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaacaaaaaapgapbaaaaaaaaaaa
egacbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp vec4 _TreeInstanceScale;
uniform highp mat4 _TerrainEngineBendTree;
uniform highp vec4 _SquashPlaneNormal;
uniform highp float _SquashAmount;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  tmpvar_1 = _glesColor;
  highp vec4 tmpvar_2;
  highp vec4 pos_3;
  pos_3.w = _glesVertex.w;
  highp float alpha_4;
  alpha_4 = tmpvar_1.w;
  pos_3.xyz = (_glesVertex.xyz * _TreeInstanceScale.xyz);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = pos_3.xyz;
  pos_3.xyz = mix (pos_3.xyz, (_TerrainEngineBendTree * tmpvar_5).xyz, vec3(alpha_4));
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = mix ((pos_3.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_3.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_3.xyz, vec3(_SquashAmount));
  pos_3 = tmpvar_6;
  highp mat3 tmpvar_7;
  tmpvar_7[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_7[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_7[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_2.xyz = normalize((tmpvar_7 * _glesNormal));
  tmpvar_2.w = -(((glstate_matrix_modelview0 * tmpvar_6).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * tmpvar_6);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float alpha_2;
  lowp float tmpvar_3;
  tmpvar_3 = texture2D (_MainTex, xlv_TEXCOORD0).w;
  alpha_2 = tmpvar_3;
  mediump float x_4;
  x_4 = (alpha_2 - _Cutoff);
  if ((x_4 < 0.0)) {
    discard;
  };
  highp vec4 enc_5;
  highp vec2 enc_6;
  enc_6 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_6 = (enc_6 / 1.7777);
  enc_6 = ((enc_6 * 0.5) + 0.5);
  enc_5.xy = enc_6;
  highp vec2 enc_7;
  highp vec2 tmpvar_8;
  tmpvar_8 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_7.y = tmpvar_8.y;
  enc_7.x = (tmpvar_8.x - (tmpvar_8.y * 0.003921569));
  enc_5.zw = enc_7;
  tmpvar_1 = enc_5;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedeafjoeenagekmaeoamlaamblfadibcfjabaaaaaabmaiaaaaaeaaaaaa
daaaaaaalmacaaaabmahaaaakmahaaaaebgpgodjieacaaaaieacaaaaaaacpopp
cmacaaaafiaaaaaaaeaaceaaaaaafeaaaaaafeaaaaaaceaaabaafeaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaacaaagaaaeaaanaaaaaaaaaa
acaaalaaacaabbaaaaaaaaaaaaaaaaaaaaacpoppbpaaaaacafaaaaiaaaaaapja
bpaaaaacafaaabiaabaaapjabpaaaaacafaaaciaacaaapjabpaaaaacafaaadia
adaaapjaafaaaaadaaaaahiaabaaffjaalaaoekaaeaaaaaeaaaaahiaakaaoeka
abaaaajaaaaaoeiaaeaaaaaeaaaaahiaamaaoekaabaakkjaaaaaoeiaaiaaaaad
aaaaaiiaaaaaoeiaaaaaoeiaahaaaaacaaaaaiiaaaaappiaafaaaaadabaaahoa
aaaappiaaaaaoeiaafaaaaadaaaaahiaaaaaoejaanaaoekaafaaaaadabaaahia
aaaaffiaapaaoekaaeaaaaaeabaaahiaaoaaoekaaaaaaaiaabaaoeiaaeaaaaae
abaaahiabaaaoekaaaaakkiaabaaoeiaaeaaaaaeabaaahiaaaaaoejaanaaoekb
abaaoeiaaeaaaaaeaaaaahiaacaappjaabaaoeiaaaaaoeiaaiaaaaadaaaaaiia
bbaaoekaaaaaoeiaacaaaaadaaaaaiiaaaaappiabbaappkaaeaaaaaeabaaahia
aaaappiabbaaoekbaaaaoeiabcaaaaaeacaaahiabcaaaakaaaaaoeiaabaaoeia
afaaaaadaaaaabiaacaaffiaahaakkkaaeaaaaaeaaaaabiaagaakkkaacaaaaia
aaaaaaiaaeaaaaaeaaaaabiaaiaakkkaacaakkiaaaaaaaiaacaaaaadaaaaabia
aaaaaaiaajaakkkaafaaaaadaaaaabiaaaaaaaiaabaappkaabaaaaacabaaaioa
aaaaaaibafaaaaadaaaaapiaacaaffiaadaaoekaaeaaaaaeaaaaapiaacaaoeka
acaaaaiaaaaaoeiaaeaaaaaeaaaaapiaaeaaoekaacaakkiaaaaaoeiaacaaaaad
aaaaapiaaaaaoeiaafaaoekaaeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeia
abaaaaacaaaaammaaaaaoeiaabaaaaacaaaaadoaadaaoejappppaaaafdeieefc
fiaeaaaaeaaaabaabgabaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaae
egiocaaaabaaaaaaalaaaaaafjaaaaaeegiocaaaacaaaaaaanaaaaaafpaaaaad
hcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaafpaaaaadicbabaaaacaaaaaa
fpaaaaaddcbabaaaadaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaad
dccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagiaaaaacacaaaaaadiaaaaai
hcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaadiaaaaai
hcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaaiaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaacaaaaaaahaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaajaaaaaakgakbaaa
aaaaaaaaegacbaaaabaaaaaadcaaaaalhcaabaaaabaaaaaaegbcbaiaebaaaaaa
aaaaaaaaegiccaaaacaaaaaaagaaaaaaegacbaaaabaaaaaadcaaaaajhcaabaaa
aaaaaaaapgbpbaaaacaaaaaaegacbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaai
icaabaaaaaaaaaaaegiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaai
icaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaaacaaaaaaalaaaaaadcaaaaal
hcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaia
ebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaagiacaaaacaaaaaaamaaaaaa
egacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaa
aaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaa
abaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaa
abaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaa
aaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaaegiocaaaabaaaaaaadaaaaaa
dgaaaaafdccabaaaabaaaaaaegbabaaaadaaaaaadiaaaaaiccaabaaaaaaaaaaa
bkaabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaaaaaaaaaa
ckiacaaaabaaaaaaaeaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaak
bcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaackiacaaaabaaaaaa
ahaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaaaaaaaaaa
afaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadiaaaaai
hcaabaaaaaaaaaaafgbfbaaaabaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaabaaaaaaaiaaaaaaagbabaaaabaaaaaaegacbaaa
aaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaa
abaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaah
hccabaaaacaaaaaapgapbaaaaaaaaaaaegacbaaaaaaaaaaadoaaaaabejfdeheo
iiaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apahaaaahbaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaahiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaiaaaahoaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaadaaaaaaapadaaaafaepfdejfeejepeoaaeoepfcenebemaaedepemep
fcaafeeffiedepepfceeaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in lowp vec4 in_COLOR0;
in highp vec4 in_TEXCOORD0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec3 t0;
highp vec4 t1;
highp float t2;
highp float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    vs_TEXCOORD1.xyz = vec3(t6) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
uniform lowp sampler2D _MainTex;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
mediump float t16_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t16_1 = t10_0 + (-_Cutoff);
    tb0 = t16_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_COLOR0;
in  vec4 in_TEXCOORD0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec3 t0;
vec4 t1;
float t2;
float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    vs_TEXCOORD1.xyz = vec3(t6) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
uniform  sampler2D _MainTex;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 1, 0.281262308, 0.5, 0.00392156886
def c2, 1, 255, 0, 0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
add_pp r0, r0.w, -c0.x
texkill r0
add r0.x, t1.z, c1.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c1.y, c1.z
mul r1.xy, t1.w, c2
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefiecedhnedfgmofmhnoggdlmaclnnnacfkdgnaabaaaaaajiacaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcmaabaaaaeaaaaaaahaaaaaaa
fjaaaaaeegiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaae
aahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaaaaaaaaaj
bcaabaaaaaaaaaaadkaabaaaaaaaaaaaakiacaiaebaaaaaaaaaaaaaaahaaaaaa
dbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaaaaaaaaaaanaaaead
akaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaaaaaaaaaa
dcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaak
dcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaa
aaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaa
dgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecedhkliddnkmmkndoapbcechhjpdfidgoceabaaaaaaoeadaaaaaeaaaaaa
daaaaaaahiabaaaaeaadaaaalaadaaaaebgpgodjeaabaaaaeaabaaaaaaacpppp
amabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaahaaabaaaaaaaaaaaaaaaaacppppfbaaaaafabaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafacaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaaadlabpaaaaacaaaaaaiaabaaaplabpaaaaacaaaaaaja
aaaiapkaecaaaaadaaaacpiaaaaaoelaaaaioekaacaaaaadaaaacpiaaaaappia
aaaaaakbebaaaaabaaaaapiaacaaaaadaaaaabiaabaakklaabaaaakaagaaaaac
aaaaabiaaaaaaaiaafaaaaadaaaaadiaaaaaaaiaabaaoelaaeaaaaaeaaaacdia
aaaaoeiaabaaffkaabaakkkaafaaaaadabaaadiaabaapplaacaaoekabdaaaaac
abaaadiaabaaoeiaaeaaaaaeaaaaceiaabaaffiaabaappkbabaaaaiaabaaaaac
aaaaciiaabaaffiaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcmaabaaaa
eaaaaaaahaaaaaaafjaaaaaeegiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaa
aaaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaa
gcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaaaaaaaaajbcaabaaaaaaaaaaadkaabaaaaaaaaaaaakiacaiaebaaaaaa
aaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaa
aaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaa
acaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaa
agaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaa
jnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaa
aaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadp
aaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
dcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadl
akaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab
ejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
fmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaafdfgfpfaepfdejfe
ejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaa
caaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgf
heaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
 Pass {
  Tags { "RenderType"="TreeTransparentCutout" "DisableBatching"="true" }
  Cull Front
  GpuProgramID 416529
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _TreeInstanceScale;
uniform mat4 _TerrainEngineBendTree;
uniform vec4 _SquashPlaneNormal;
uniform float _SquashAmount;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 pos_2;
  pos_2.w = gl_Vertex.w;
  pos_2.xyz = (gl_Vertex.xyz * _TreeInstanceScale.xyz);
  vec4 tmpvar_3;
  tmpvar_3.w = 0.0;
  tmpvar_3.xyz = pos_2.xyz;
  pos_2.xyz = mix (pos_2.xyz, (_TerrainEngineBendTree * tmpvar_3).xyz, gl_Color.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = mix ((pos_2.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_2.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_2.xyz, vec3(_SquashAmount));
  pos_2 = tmpvar_4;
  mat3 tmpvar_5;
  tmpvar_5[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_5[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_5[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = -(normalize((tmpvar_5 * gl_Normal)));
  tmpvar_1.w = -(((gl_ModelViewMatrix * tmpvar_4).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * tmpvar_4);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = (texture2D (_MainTex, xlv_TEXCOORD0).w - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 10 [_TerrainEngineBendTree] 3
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 13 [_ProjectionParams]
Float 16 [_SquashAmount]
Vector 15 [_SquashPlaneNormal]
Vector 14 [_TreeInstanceScale]
"vs_2_0
def c17, 1, 0, 0, 0
dcl_position v0
dcl_normal v1
dcl_color v2
dcl_texcoord v3
mul r0.xyz, v0, c14
dp3 r1.x, c10, r0
dp3 r1.y, c11, r0
dp3 r1.z, c12, r0
mad r1.xyz, v0, -c14, r1
mad r0.xyz, v2.w, r1, r0
dp3 r0.w, c15, r0
add r0.w, r0.w, c15.w
mad r1.xyz, r0.w, -c15, r0
lrp r2.xyz, c16.x, r0, r1
mov r2.w, c17.x
dp4 oPos.x, c0, r2
dp4 oPos.y, c1, r2
dp4 oPos.z, c2, r2
dp4 oPos.w, c3, r2
dp4 r0.x, c6, r2
mul r0.x, r0.x, c13.w
mov oT1.w, -r0.x
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
nrm r1.xyz, r0
mov oT1.xyz, -r1
mov oT0.xy, v3

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefiecedgfepkaceigemekadjdddljbocjdbmenaabaaaaaakeafaaaaadaaaaaa
cmaaaaaalmaaaaaacmabaaaaejfdeheoiiaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapahaaaahbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaahiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apaiaaaahoaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaafaepfdej
feejepeoaaeoepfcenebemaaedepemepfcaafeeffiedepepfceeaaklepfdeheo
giaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaa
feeffiedepepfceeaaklklklfdeieefchaaeaaaaeaaaabaabmabaaaafjaaaaae
egiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaafjaaaaae
egiocaaaacaaaaaaanaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadhcbabaaa
abaaaaaafpaaaaadicbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaaghaaaaae
pccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaagiaaaaacacaaaaaadiaaaaaihcaabaaaaaaaaaaaegbcbaaaaaaaaaaa
egiccaaaacaaaaaaagaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiccaaaacaaaaaaaiaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaa
ahaaaaaaagaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaa
egiccaaaacaaaaaaajaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaal
hcaabaaaabaaaaaaegbcbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaa
egacbaaaabaaaaaadcaaaaajhcaabaaaaaaaaaaapgbpbaaaacaaaaaaegacbaaa
abaaaaaaegacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaacaaaaaa
alaaaaaaegacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaa
dkiacaaaacaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaa
aaaaaaaaegiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaa
aaaaaaaaagiacaaaacaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaa
diaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaa
dcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaa
egaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaa
kgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaa
abaaaaaaegiocaaaabaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaaegbabaaa
adaaaaaadiaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaa
afaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaa
aaaaaaaabkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaa
agaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaa
akaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaa
akaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaa
akaabaiaebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaabaaaaaa
egiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaa
aiaaaaaaagbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaa
egiccaaaabaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaah
icaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaa
aaaaaaaadkaabaaaaaaaaaaadiaaaaahhcaabaaaaaaaaaaapgapbaaaaaaaaaaa
egacbaaaaaaaaaaadgaaaaaghccabaaaacaaaaaaegacbaiaebaaaaaaaaaaaaaa
doaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform highp vec4 _TreeInstanceScale;
uniform highp mat4 _TerrainEngineBendTree;
uniform highp vec4 _SquashPlaneNormal;
uniform highp float _SquashAmount;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  tmpvar_1 = _glesColor;
  highp vec4 tmpvar_2;
  highp vec4 pos_3;
  pos_3.w = _glesVertex.w;
  highp float alpha_4;
  alpha_4 = tmpvar_1.w;
  pos_3.xyz = (_glesVertex.xyz * _TreeInstanceScale.xyz);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = pos_3.xyz;
  pos_3.xyz = mix (pos_3.xyz, (_TerrainEngineBendTree * tmpvar_5).xyz, vec3(alpha_4));
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = mix ((pos_3.xyz - (
    (dot (_SquashPlaneNormal.xyz, pos_3.xyz) + _SquashPlaneNormal.w)
   * _SquashPlaneNormal.xyz)), pos_3.xyz, vec3(_SquashAmount));
  pos_3 = tmpvar_6;
  highp mat3 tmpvar_7;
  tmpvar_7[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_7[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_7[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_2.xyz = -(normalize((tmpvar_7 * _glesNormal)));
  tmpvar_2.w = -(((glstate_matrix_modelview0 * tmpvar_6).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * tmpvar_6);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float x_2;
  x_2 = (texture2D (_MainTex, xlv_TEXCOORD0).w - _Cutoff);
  if ((x_2 < 0.0)) {
    discard;
  };
  highp vec4 enc_3;
  highp vec2 enc_4;
  enc_4 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_4 = (enc_4 / 1.7777);
  enc_4 = ((enc_4 * 0.5) + 0.5);
  enc_3.xy = enc_4;
  highp vec2 enc_5;
  highp vec2 tmpvar_6;
  tmpvar_6 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_5.y = tmpvar_6.y;
  enc_5.x = (tmpvar_6.x - (tmpvar_6.y * 0.003921569));
  enc_3.zw = enc_5;
  tmpvar_1 = enc_3;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Matrix 112 [_TerrainEngineBendTree]
Vector 96 [_TreeInstanceScale]
Vector 176 [_SquashPlaneNormal]
Float 192 [_SquashAmount]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedmmglnefdiafpplemdccdhfddblhmdldbabaaaaaacaaiaaaaaeaaaaaa
daaaaaaakiacaaaacaahaaaalaahaaaaebgpgodjhaacaaaahaacaaaaaaacpopp
biacaaaafiaaaaaaaeaaceaaaaaafeaaaaaafeaaaaaaceaaabaafeaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaacaaagaaaeaaanaaaaaaaaaa
acaaalaaacaabbaaaaaaaaaaaaaaaaaaaaacpoppbpaaaaacafaaaaiaaaaaapja
bpaaaaacafaaabiaabaaapjabpaaaaacafaaaciaacaaapjabpaaaaacafaaadia
adaaapjaafaaaaadaaaaahiaabaaffjaalaaoekaaeaaaaaeaaaaahiaakaaoeka
abaaaajaaaaaoeiaaeaaaaaeaaaaahiaamaaoekaabaakkjaaaaaoeiaceaaaaac
abaaahiaaaaaoeiaabaaaaacabaaahoaabaaoeibafaaaaadaaaaahiaaaaaoeja
anaaoekaafaaaaadabaaahiaaaaaffiaapaaoekaaeaaaaaeabaaahiaaoaaoeka
aaaaaaiaabaaoeiaaeaaaaaeabaaahiabaaaoekaaaaakkiaabaaoeiaaeaaaaae
abaaahiaaaaaoejaanaaoekbabaaoeiaaeaaaaaeaaaaahiaacaappjaabaaoeia
aaaaoeiaaiaaaaadaaaaaiiabbaaoekaaaaaoeiaacaaaaadaaaaaiiaaaaappia
bbaappkaaeaaaaaeabaaahiaaaaappiabbaaoekbaaaaoeiabcaaaaaeacaaahia
bcaaaakaaaaaoeiaabaaoeiaafaaaaadaaaaabiaacaaffiaahaakkkaaeaaaaae
aaaaabiaagaakkkaacaaaaiaaaaaaaiaaeaaaaaeaaaaabiaaiaakkkaacaakkia
aaaaaaiaacaaaaadaaaaabiaaaaaaaiaajaakkkaafaaaaadaaaaabiaaaaaaaia
abaappkaabaaaaacabaaaioaaaaaaaibafaaaaadaaaaapiaacaaffiaadaaoeka
aeaaaaaeaaaaapiaacaaoekaacaaaaiaaaaaoeiaaeaaaaaeaaaaapiaaeaaoeka
acaakkiaaaaaoeiaacaaaaadaaaaapiaaaaaoeiaafaaoekaaeaaaaaeaaaaadma
aaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeiaabaaaaacaaaaadoa
adaaoejappppaaaafdeieefchaaeaaaaeaaaabaabmabaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaafjaaaaaeegiocaaa
acaaaaaaanaaaaaafpaaaaadhcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaa
fpaaaaadicbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaaghaaaaaepccabaaa
aaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaa
giaaaaacacaaaaaadiaaaaaihcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaaa
acaaaaaaagaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaa
acaaaaaaaiaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaahaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaa
acaaaaaaajaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaalhcaabaaa
abaaaaaaegbcbaiaebaaaaaaaaaaaaaaegiccaaaacaaaaaaagaaaaaaegacbaaa
abaaaaaadcaaaaajhcaabaaaaaaaaaaapgbpbaaaacaaaaaaegacbaaaabaaaaaa
egacbaaaaaaaaaaabaaaaaaiicaabaaaaaaaaaaaegiccaaaacaaaaaaalaaaaaa
egacbaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaadkaabaaaaaaaaaaadkiacaaa
acaaaaaaalaaaaaadcaaaaalhcaabaaaabaaaaaapgapbaiaebaaaaaaaaaaaaaa
egiccaaaacaaaaaaalaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaa
egacbaaaaaaaaaaaegacbaiaebaaaaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
agiacaaaacaaaaaaamaaaaaaegacbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaaaaaaaaaipccabaaaaaaaaaaaegaobaaaabaaaaaa
egiocaaaabaaaaaaadaaaaaadgaaaaafdccabaaaabaaaaaaegbabaaaadaaaaaa
diaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaaaaaaaaa
bkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaa
ckaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaackiacaaaabaaaaaaahaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaabaaaaaaegiccaaa
abaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaaiaaaaaa
agbabaaaabaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
abaaaaaaakaaaaaakgbkbaaaabaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaa
dkaabaaaaaaaaaaadiaaaaahhcaabaaaaaaaaaaapgapbaaaaaaaaaaaegacbaaa
aaaaaaaadgaaaaaghccabaaaacaaaaaaegacbaiaebaaaaaaaaaaaaaadoaaaaab
ejfdeheoiiaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapahaaaahbaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaa
hiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaiaaaahoaaaaaaaaaaaaaa
aaaaaaaaadaaaaaaadaaaaaaapadaaaafaepfdejfeejepeoaaeoepfcenebemaa
edepemepfcaafeeffiedepepfceeaaklepfdeheogiaaaaaaadaaaaaaaiaaaaaa
faaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaa
aaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaa
acaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl
"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in lowp vec4 in_COLOR0;
in highp vec4 in_TEXCOORD0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec3 t0;
highp vec4 t1;
highp float t2;
highp float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    t0.xyz = vec3(t6) * t0.xyz;
    vs_TEXCOORD1.xyz = (-t0.xyz);
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
uniform lowp sampler2D _MainTex;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
lowp float t10_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t10_1 = t10_0 + (-_Cutoff);
    tb0 = t10_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_COLOR0;
in  vec4 in_TEXCOORD0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec3 t0;
vec4 t1;
float t2;
float t6;
void main()
{
    t0.xyz = in_POSITION0.xyz * _TreeInstanceScale.xyz;
    t1.xyz = t0.yyy * _TerrainEngineBendTree[1].xyz;
    t1.xyz = _TerrainEngineBendTree[0].xyz * t0.xxx + t1.xyz;
    t1.xyz = _TerrainEngineBendTree[2].xyz * t0.zzz + t1.xyz;
    t1.xyz = (-in_POSITION0.xyz) * _TreeInstanceScale.xyz + t1.xyz;
    t0.xyz = in_COLOR0.www * t1.xyz + t0.xyz;
    t6 = dot(_SquashPlaneNormal.xyz, t0.xyz);
    t6 = t6 + _SquashPlaneNormal.w;
    t1.xyz = (-vec3(t6)) * _SquashPlaneNormal.xyz + t0.xyz;
    t0.xyz = t0.xyz + (-t1.xyz);
    t0.xyz = vec3(_SquashAmount) * t0.xyz + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = t1 + glstate_matrix_mvp[3];
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = t0.x + glstate_matrix_modelview0[3].z;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t6 = dot(t0.xyz, t0.xyz);
    t6 = inversesqrt(t6);
    t0.xyz = vec3(t6) * t0.xyz;
    vs_TEXCOORD1.xyz = (-t0.xyz);
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
uniform  sampler2D _MainTex;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 1, 0.281262308, 0.5, 0.00392156886
def c2, 1, 255, 0, 0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
add_pp r0, r0.w, -c0.x
texkill r0
add r0.x, t1.z, c1.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c1.y, c1.z
mul r1.xy, t1.w, c2
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefiecedhnedfgmofmhnoggdlmaclnnnacfkdgnaabaaaaaajiacaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcmaabaaaaeaaaaaaahaaaaaaa
fjaaaaaeegiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaae
aahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaaaaaaaaaj
bcaabaaaaaaaaaaadkaabaaaaaaaaaaaakiacaiaebaaaaaaaaaaaaaaahaaaaaa
dbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaaaaaaaaaaanaaaead
akaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaaaaaaaaaa
dcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadiaaaaak
dcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahpedaaaaaaaa
aaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaakeccabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaaaaaaaaaa
dgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecedhkliddnkmmkndoapbcechhjpdfidgoceabaaaaaaoeadaaaaaeaaaaaa
daaaaaaahiabaaaaeaadaaaalaadaaaaebgpgodjeaabaaaaeaabaaaaaaacpppp
amabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaahaaabaaaaaaaaaaaaaaaaacppppfbaaaaafabaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafacaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaaadlabpaaaaacaaaaaaiaabaaaplabpaaaaacaaaaaaja
aaaiapkaecaaaaadaaaacpiaaaaaoelaaaaioekaacaaaaadaaaacpiaaaaappia
aaaaaakbebaaaaabaaaaapiaacaaaaadaaaaabiaabaakklaabaaaakaagaaaaac
aaaaabiaaaaaaaiaafaaaaadaaaaadiaaaaaaaiaabaaoelaaeaaaaaeaaaacdia
aaaaoeiaabaaffkaabaakkkaafaaaaadabaaadiaabaapplaacaaoekabdaaaaac
abaaadiaabaaoeiaaeaaaaaeaaaaceiaabaaffiaabaappkbabaaaaiaabaaaaac
aaaaciiaabaaffiaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcmaabaaaa
eaaaaaaahaaaaaaafjaaaaaeegiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaa
aaaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaa
gcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaaaaaaaaajbcaabaaaaaaaaaaadkaabaaaaaaaaaaaakiacaiaebaaaaaa
aaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaa
aaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaa
acaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaa
agaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaa
jnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaa
aaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadp
aaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
dcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadl
akaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab
ejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
fmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaafdfgfpfaepfdejfe
ejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaa
caaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgf
heaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="TreeBillboard" }
 Pass {
  Tags { "RenderType"="TreeBillboard" }
  Cull Off
  GpuProgramID 510283
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;


uniform vec3 _TreeBillboardCameraRight;
uniform vec4 _TreeBillboardCameraUp;
uniform vec4 _TreeBillboardCameraFront;
uniform vec4 _TreeBillboardCameraPos;
uniform vec4 _TreeBillboardDistances;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec2 tmpvar_1;
  vec4 tmpvar_2;
  vec4 pos_3;
  pos_3 = gl_Vertex;
  vec2 offset_4;
  offset_4 = gl_MultiTexCoord1.xy;
  float offsetz_5;
  offsetz_5 = gl_MultiTexCoord0.y;
  vec3 tmpvar_6;
  tmpvar_6 = (gl_Vertex.xyz - _TreeBillboardCameraPos.xyz);
  float tmpvar_7;
  tmpvar_7 = dot (tmpvar_6, tmpvar_6);
  if ((tmpvar_7 > _TreeBillboardDistances.x)) {
    offsetz_5 = 0.0;
    offset_4 = vec2(0.0, 0.0);
  };
  pos_3.xyz = (gl_Vertex.xyz + (_TreeBillboardCameraRight * offset_4.x));
  pos_3.xyz = (pos_3.xyz + (_TreeBillboardCameraUp.xyz * mix (offset_4.y, offsetz_5, _TreeBillboardCameraPos.w)));
  pos_3.xyz = (pos_3.xyz + ((_TreeBillboardCameraFront.xyz * 
    abs(offset_4.x)
  ) * _TreeBillboardCameraUp.w));
  tmpvar_1.x = gl_MultiTexCoord0.x;
  tmpvar_1.y = float((gl_MultiTexCoord0.y > 0.0));
  tmpvar_2.xyz = vec3(0.0, 0.0, 1.0);
  tmpvar_2.w = -(((gl_ModelViewMatrix * pos_3).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * pos_3);
  xlv_TEXCOORD0 = tmpvar_1;
  xlv_TEXCOORD1 = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = (texture2D (_MainTex, xlv_TEXCOORD0).w - 0.001);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 7 [_ProjectionParams]
Vector 10 [_TreeBillboardCameraFront]
Vector 11 [_TreeBillboardCameraPos]
Vector 8 [_TreeBillboardCameraRight]
Vector 9 [_TreeBillboardCameraUp]
Vector 12 [_TreeBillboardDistances]
"vs_2_0
def c13, 0, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_texcoord1 v2
add r0.xyz, v0, -c11
dp3 r0.x, r0, r0
slt r0.x, c12.x, r0.x
mov r1.xy, v2
mov r1.z, v1.y
mad r0.xyz, r0.x, -r1, r1
mad r1.xyz, c8, r0.x, v0
lrp r1.w, c11.w, r0.z, r0.y
abs r0.x, r0.x
mul r0.xyz, r0.x, c10
mad r1.xyz, c9, r1.w, r1
mad r0.xyz, r0, c9.w, r1
mov r0.w, v0.w
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0
dp4 r0.x, c6, r0
mul r0.x, r0.x, c7.w
mov oT1.w, -r0.x
slt oT0.y, c13.x, v1.y
mov oT0.x, v1.x
mov oT1.xyz, c13.xxyw

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 196 [_TreeBillboardCameraRight] 3
Vector 208 [_TreeBillboardCameraUp]
Vector 224 [_TreeBillboardCameraFront]
Vector 240 [_TreeBillboardCameraPos]
Vector 256 [_TreeBillboardDistances]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefiecedncfkkapjlkejflhjfamhfcikclodpbciabaaaaaacmafaaaaadaaaaaa
cmaaaaaaleaaaaaaceabaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaahbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaaaaaahhaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apadaaaahhaaaaaaabaaaaaaaaaaaaaaadaaaaaaadaaaaaaadadaaaafaepfdej
feejepeoaaedepemepfcaafeeffiedepepfceeaaepfdeheogiaaaaaaadaaaaaa
aiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaaabaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklfdeieefcaaaeaaaaeaaaabaaaaabaaaafjaaaaaeegiocaaaaaaaaaaa
agaaaaaafjaaaaaeegiocaaaabaaaaaaaiaaaaaafjaaaaaeegiocaaaacaaaaaa
bbaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaacaaaaaafpaaaaad
dcbabaaaadaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaagiaaaaacacaaaaaaaaaaaaajhcaabaaa
aaaaaaaaegbcbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaapaaaaaabaaaaaah
bcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaadbaaaaaibcaabaaa
aaaaaaaaakiacaaaacaaaaaabaaaaaaaakaabaaaaaaaaaaadgaaaaafdcaabaaa
abaaaaaaegbabaaaadaaaaaadgaaaaafecaabaaaabaaaaaabkbabaaaacaaaaaa
dhaaaaamhcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaaaaa
aaaaaaaaaaaaaaaaegacbaaaabaaaaaaaaaaaaaiecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaackaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaadkiacaaa
acaaaaaaapaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaakhcaabaaa
abaaaaaajgihcaaaacaaaaaaamaaaaaaagaabaaaaaaaaaaaegbcbaaaaaaaaaaa
diaaaaajncaabaaaaaaaaaaaagaabaiaibaaaaaaaaaaaaaaagijcaaaacaaaaaa
aoaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaanaaaaaafgafbaaa
aaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaigadbaaaaaaaaaaa
pgipcaaaacaaaaaaanaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaa
fgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaa
egiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaapgbpbaaa
aaaaaaaaegaobaaaabaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaaaaaaaaaa
bkbabaaaacaaaaaaabaaaaahcccabaaaabaaaaaadkaabaaaaaaaaaaaabeaaaaa
aaaaiadpdgaaaaafbccabaaaabaaaaaaakbabaaaacaaaaaadiaaaaaiccaabaaa
aaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaa
aaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaackaabaaaaaaaaaaa
akaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaa
dkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaa
aaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadgaaaaaihccabaaaacaaaaaaaceaaaaaaaaaaaaaaaaaaaaa
aaaaiadpaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesMultiTexCoord0;
attribute vec4 _glesMultiTexCoord1;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp vec3 _TreeBillboardCameraRight;
uniform highp vec4 _TreeBillboardCameraUp;
uniform highp vec4 _TreeBillboardCameraFront;
uniform highp vec4 _TreeBillboardCameraPos;
uniform highp vec4 _TreeBillboardDistances;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  highp vec4 tmpvar_1;
  tmpvar_1 = _glesMultiTexCoord0;
  highp vec2 tmpvar_2;
  highp vec4 tmpvar_3;
  highp vec4 pos_4;
  pos_4 = _glesVertex;
  highp vec2 offset_5;
  offset_5 = _glesMultiTexCoord1.xy;
  highp float offsetz_6;
  offsetz_6 = tmpvar_1.y;
  highp vec3 tmpvar_7;
  tmpvar_7 = (_glesVertex.xyz - _TreeBillboardCameraPos.xyz);
  highp float tmpvar_8;
  tmpvar_8 = dot (tmpvar_7, tmpvar_7);
  if ((tmpvar_8 > _TreeBillboardDistances.x)) {
    offsetz_6 = 0.0;
    offset_5 = vec2(0.0, 0.0);
  };
  pos_4.xyz = (_glesVertex.xyz + (_TreeBillboardCameraRight * offset_5.x));
  pos_4.xyz = (pos_4.xyz + (_TreeBillboardCameraUp.xyz * mix (offset_5.y, offsetz_6, _TreeBillboardCameraPos.w)));
  pos_4.xyz = (pos_4.xyz + ((_TreeBillboardCameraFront.xyz * 
    abs(offset_5.x)
  ) * _TreeBillboardCameraUp.w));
  tmpvar_2.x = tmpvar_1.x;
  tmpvar_2.y = float((_glesMultiTexCoord0.y > 0.0));
  tmpvar_3.xyz = vec3(0.0, 0.0, 1.0);
  tmpvar_3.w = -(((glstate_matrix_modelview0 * pos_4).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * pos_4);
  xlv_TEXCOORD0 = tmpvar_2;
  xlv_TEXCOORD1 = tmpvar_3;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float x_2;
  x_2 = (texture2D (_MainTex, xlv_TEXCOORD0).w - 0.001);
  if ((x_2 < 0.0)) {
    discard;
  };
  highp vec4 enc_3;
  highp vec2 enc_4;
  enc_4 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_4 = (enc_4 / 1.7777);
  enc_4 = ((enc_4 * 0.5) + 0.5);
  enc_3.xy = enc_4;
  highp vec2 enc_5;
  highp vec2 tmpvar_6;
  tmpvar_6 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_5.y = tmpvar_6.y;
  enc_5.x = (tmpvar_6.x - (tmpvar_6.y * 0.003921569));
  enc_3.zw = enc_5;
  tmpvar_1 = enc_3;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "texcoord" TexCoord0
Bind "texcoord1" TexCoord1
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 196 [_TreeBillboardCameraRight] 3
Vector 208 [_TreeBillboardCameraUp]
Vector 224 [_TreeBillboardCameraFront]
Vector 240 [_TreeBillboardCameraPos]
Vector 256 [_TreeBillboardDistances]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedaidmmenfmlmdaoannaenljmahdleciababaaaaaaimahaaaaaeaaaaaa
daaaaaaaimacaaaajeagaaaabmahaaaaebgpgodjfeacaaaafeacaaaaaaacpopp
aiacaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaaiaaacaaaaaaaaaaacaaamaaafaaakaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafapaaapkaaaaaaaaaaaaaiadpaaaaaaaaaaaaaaaa
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaaciaacaaapjabpaaaaacafaaadia
adaaapjaamaaaaadaaaaacoaapaaaakaacaaffjaacaaaaadaaaaahiaaaaaoeja
anaaoekbaiaaaaadaaaaabiaaaaaoeiaaaaaoeiaamaaaaadaaaaabiaaoaaaaka
aaaaaaiaabaaaaacabaaadiaadaaoejaabaaaaacabaaaeiaacaaffjaaeaaaaae
aaaaahiaaaaaaaiaabaaoeibabaaoeiaaeaaaaaeabaaahiaakaapjkaaaaaaaia
aaaaoejabcaaaaaeabaaaiiaanaappkaaaaakkiaaaaaffiacdaaaaacaaaaabia
aaaaaaiaafaaaaadaaaaahiaaaaaaaiaamaaoekaaeaaaaaeabaaahiaalaaoeka
abaappiaabaaoeiaaeaaaaaeaaaaahiaaaaaoeiaalaappkaabaaoeiaafaaaaad
aaaaaiiaaaaaffiaahaakkkaaeaaaaaeaaaaaiiaagaakkkaaaaaaaiaaaaappia
aeaaaaaeaaaaaiiaaiaakkkaaaaakkiaaaaappiaaeaaaaaeaaaaaiiaajaakkka
aaaappjaaaaappiaafaaaaadaaaaaiiaaaaappiaabaappkaabaaaaacabaaaioa
aaaappibafaaaaadabaaapiaaaaaffiaadaaoekaaeaaaaaeabaaapiaacaaoeka
aaaaaaiaabaaoeiaaeaaaaaeaaaaapiaaeaaoekaaaaakkiaabaaoeiaaeaaaaae
aaaaapiaafaaoekaaaaappjaaaaaoeiaaeaaaaaeaaaaadmaaaaappiaaaaaoeka
aaaaoeiaabaaaaacaaaaammaaaaaoeiaabaaaaacaaaaaboaacaaaajaabaaaaac
abaaahoaapaanakappppaaaafdeieefcaaaeaaaaeaaaabaaaaabaaaafjaaaaae
egiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaiaaaaaafjaaaaae
egiocaaaacaaaaaabbaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaa
acaaaaaafpaaaaaddcbabaaaadaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaa
gfaaaaaddccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagiaaaaacacaaaaaa
aaaaaaajhcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaa
apaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaa
dbaaaaaibcaabaaaaaaaaaaaakiacaaaacaaaaaabaaaaaaaakaabaaaaaaaaaaa
dgaaaaafdcaabaaaabaaaaaaegbabaaaadaaaaaadgaaaaafecaabaaaabaaaaaa
bkbabaaaacaaaaaadhaaaaamhcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaegacbaaaabaaaaaaaaaaaaaiecaabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaackaabaaaaaaaaaaadcaaaaakccaabaaa
aaaaaaaadkiacaaaacaaaaaaapaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaa
dcaaaaakhcaabaaaabaaaaaajgihcaaaacaaaaaaamaaaaaaagaabaaaaaaaaaaa
egbcbaaaaaaaaaaadiaaaaajncaabaaaaaaaaaaaagaabaiaibaaaaaaaaaaaaaa
agijcaaaacaaaaaaaoaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaa
anaaaaaafgafbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
igadbaaaaaaaaaaapgipcaaaacaaaaaaanaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaa
adaaaaaapgbpbaaaaaaaaaaaegaobaaaabaaaaaadbaaaaahicaabaaaaaaaaaaa
abeaaaaaaaaaaaaabkbabaaaacaaaaaaabaaaaahcccabaaaabaaaaaadkaabaaa
aaaaaaaaabeaaaaaaaaaiadpdgaaaaafbccabaaaabaaaaaaakbabaaaacaaaaaa
diaaaaaiccaabaaaaaaaaaaabkaabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaaaaaaaaa
bkaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaa
ckaabaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
abaaaaaaahaaaaaadkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaa
acaaaaaaakaabaiaebaaaaaaaaaaaaaadgaaaaaihccabaaaacaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaiadpaaaaaaaadoaaaaabejfdeheoiaaaaaaaaeaaaaaa
aiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaahbaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaahhaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapadaaaahhaaaaaaabaaaaaaaaaaaaaaadaaaaaaadaaaaaa
adadaaaafaepfdejfeejepeoaaedepemepfcaafeeffiedepepfceeaaepfdeheo
giaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaafmaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaa
feeffiedepepfceeaaklklkl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
in highp vec4 in_POSITION0;
in highp vec4 in_TEXCOORD0;
in highp vec2 in_TEXCOORD1;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec4 t0;
bool tb0;
highp vec4 t1;
highp float t2;
highp float t4;
bool tb6;
void main()
{
    t0.xyz = in_POSITION0.xyz + (-_TreeBillboardCameraPos.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    tb0 = _TreeBillboardDistances.x<t0.x;
    t1.xy = in_TEXCOORD1.xy;
    t1.z = in_TEXCOORD0.y;
    t0.xyz = (bool(tb0)) ? vec3(0.0, 0.0, 0.0) : t1.xyz;
    t4 = (-t0.y) + t0.z;
    t2 = _TreeBillboardCameraPos.w * t4 + t0.y;
    t1.xyz = _TreeBillboardCameraRight.xxyz.yzw * t0.xxx + in_POSITION0.xyz;
    t0.xzw = abs(t0.xxx) * _TreeBillboardCameraFront.xyz;
    t1.xyz = _TreeBillboardCameraUp.xyz * vec3(t2) + t1.xyz;
    t0.xyz = t0.xzw * _TreeBillboardCameraUp.www + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t1;
    tb6 = 0.0<in_TEXCOORD0.y;
    vs_TEXCOORD0.y = tb6 ? 1.0 : float(0.0);
    vs_TEXCOORD0.x = in_TEXCOORD0.x;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    vs_TEXCOORD1.xyz = vec3(0.0, 0.0, 1.0);
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform lowp sampler2D _MainTex;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
lowp float t10_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t10_1 = t10_0 + -0.00100000005;
    tb0 = t10_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
in  vec4 in_POSITION0;
in  vec4 in_TEXCOORD0;
in  vec2 in_TEXCOORD1;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec4 t0;
bool tb0;
vec4 t1;
float t2;
float t4;
bool tb6;
void main()
{
    t0.xyz = in_POSITION0.xyz + (-_TreeBillboardCameraPos.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    tb0 = _TreeBillboardDistances.x<t0.x;
    t1.xy = in_TEXCOORD1.xy;
    t1.z = in_TEXCOORD0.y;
    t0.xyz = (bool(tb0)) ? vec3(0.0, 0.0, 0.0) : t1.xyz;
    t4 = (-t0.y) + t0.z;
    t2 = _TreeBillboardCameraPos.w * t4 + t0.y;
    t1.xyz = _TreeBillboardCameraRight.xxyz.yzw * t0.xxx + in_POSITION0.xyz;
    t0.xzw = abs(t0.xxx) * _TreeBillboardCameraFront.xyz;
    t1.xyz = _TreeBillboardCameraUp.xyz * vec3(t2) + t1.xyz;
    t0.xyz = t0.xzw * _TreeBillboardCameraUp.www + t1.xyz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t1;
    tb6 = 0.0<in_TEXCOORD0.y;
    vs_TEXCOORD0.y = tb6 ? 1.0 : float(0.0);
    vs_TEXCOORD0.x = in_TEXCOORD0.x;
    t2 = t0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t0.x + t2;
    t0.x = glstate_matrix_modelview0[2].z * t0.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    vs_TEXCOORD1.xyz = vec3(0.0, 0.0, 1.0);
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform  sampler2D _MainTex;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
mediump float t16_0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t16_0 = t10_0.w + -0.00100000005;
    tb0 = t16_0<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c0, -0.00100000005, 1, 0.281262308, 0.5
def c1, 1, 255, 0.00392156886, 0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
add_pp r0, r0.w, c0.x
texkill r0
add r0.x, t1.z, c0.y
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c0.z, c0.w
mul r1.xy, t1.w, c1
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.z, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
"ps_4_0
root12:abaaabaa
eefieceddljjlhdbgaandfdgcppangjjhcbhipmnabaaaaaaiaacaaaaadaaaaaa
cmaaaaaajmaaaaaanaaaaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaafmaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafmaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheo
cmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
apaaaaaafdfgfpfegbhcghgfheaaklklfdeieefckiabaaaaeaaaaaaagkaaaaaa
fkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaagcbaaaad
dcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacabaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaadkaabaaaaaaaaaaa
abeaaaaagpbcidlkdbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaa
aaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaa
acaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaa
agaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaa
jnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaa
aaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadp
aaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
dcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadl
akaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaab
"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
"ps_4_0_level_9_1
root12:abaaabaa
eefiecedjcepkalcmimemjfbpndlibhmalhfkcccabaaaaaamaadaaaaaeaaaaaa
daaaaaaagmabaaaabmadaaaaimadaaaaebgpgodjdeabaaaadeabaaaaaaacpppp
amabaaaaciaaaaaaaaaaciaaaaaaciaaaaaaciaaabaaceaaaaaaciaaaaaaaaaa
aaacppppfbaaaaafaaaaapkagpbcidlkaaaaiadpjnabjadoaaaaaadpfbaaaaaf
abaaapkaaaaaiadpaaaahpedibiaiadlaaaaaaaabpaaaaacaaaaaaiaaaaaadla
bpaaaaacaaaaaaiaabaaaplabpaaaaacaaaaaajaaaaiapkaecaaaaadaaaacpia
aaaaoelaaaaioekaacaaaaadaaaacpiaaaaappiaaaaaaakaebaaaaabaaaaapia
acaaaaadaaaaabiaabaakklaaaaaffkaagaaaaacaaaaabiaaaaaaaiaafaaaaad
aaaaadiaaaaaaaiaabaaoelaaeaaaaaeaaaacdiaaaaaoeiaaaaakkkaaaaappka
afaaaaadabaaadiaabaapplaabaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaae
aaaaceiaabaaffiaabaakkkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaac
aaaicpiaaaaaoeiappppaaaafdeieefckiabaaaaeaaaaaaagkaaaaaafkaaaaad
aagabaaaaaaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaagcbaaaaddcbabaaa
abaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaac
abaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaa
aagabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaadkaabaaaaaaaaaaaabeaaaaa
gpbcidlkdbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaaabeaaaaaaaaaaaaa
anaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaackbabaaaacaaaaaa
abeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaaacaaaaaaagaabaaa
aaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjado
jnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaa
diaaaaakdcaabaaaaaaaaaaapgbpbaaaacaaaaaaaceaaaaaaaaaiadpaaaahped
aaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaadcaaaaak
eccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaibiaiadlakaabaaa
aaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaadoaaaaabejfdeheo
giaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaafmaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaafmaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaa
feeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl
"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="GrassBillboard" }
 Pass {
  Tags { "RenderType"="GrassBillboard" }
  Cull Off
  GpuProgramID 543493
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _WavingTint;
uniform vec4 _WaveAndDistance;
uniform vec4 _CameraPosition;
uniform vec3 _CameraRight;
uniform vec3 _CameraUp;
attribute vec4 TANGENT;
varying vec4 xlv_COLOR;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 pos_2;
  pos_2 = gl_Vertex;
  vec2 offset_3;
  offset_3 = TANGENT.xy;
  vec3 tmpvar_4;
  tmpvar_4 = (gl_Vertex.xyz - _CameraPosition.xyz);
  float tmpvar_5;
  tmpvar_5 = dot (tmpvar_4, tmpvar_4);
  if ((tmpvar_5 > _WaveAndDistance.w)) {
    offset_3 = vec2(0.0, 0.0);
  };
  pos_2.xyz = (gl_Vertex.xyz + (offset_3.x * _CameraRight));
  pos_2.xyz = (pos_2.xyz + (offset_3.y * _CameraUp));
  vec4 vertex_6;
  vertex_6.yw = pos_2.yw;
  vec4 color_7;
  color_7.xyz = gl_Color.xyz;
  vec3 waveMove_8;
  vec4 s_9;
  vec4 waves_10;
  waves_10 = (pos_2.x * (vec4(0.012, 0.02, 0.06, 0.024) * _WaveAndDistance.y));
  waves_10 = (waves_10 + (pos_2.z * (vec4(0.006, 0.02, 0.02, 0.05) * _WaveAndDistance.y)));
  waves_10 = (waves_10 + (_WaveAndDistance.x * vec4(1.2, 2.0, 1.6, 4.8)));
  vec4 tmpvar_11;
  tmpvar_11 = fract(waves_10);
  waves_10 = tmpvar_11;
  vec4 val_12;
  vec4 s_13;
  val_12 = ((tmpvar_11 * 6.408849) - 3.141593);
  vec4 tmpvar_14;
  tmpvar_14 = (val_12 * val_12);
  vec4 tmpvar_15;
  tmpvar_15 = (tmpvar_14 * val_12);
  vec4 tmpvar_16;
  tmpvar_16 = (tmpvar_15 * tmpvar_14);
  s_13 = (((val_12 + 
    (tmpvar_15 * -0.1616162)
  ) + (tmpvar_16 * 0.0083333)) + ((tmpvar_16 * tmpvar_14) * -0.00019841));
  s_9 = (s_13 * s_13);
  s_9 = (s_9 * s_9);
  float tmpvar_17;
  tmpvar_17 = (dot (s_9, vec4(0.6741998, 0.6741998, 0.2696799, 0.13484)) * 0.7);
  s_9 = (s_9 * TANGENT.y);
  waveMove_8.y = 0.0;
  waveMove_8.x = dot (s_9, vec4(0.024, 0.04, -0.12, 0.096));
  waveMove_8.z = dot (s_9, vec4(0.006, 0.02, -0.02, 0.1));
  vertex_6.xz = (pos_2.xz - (waveMove_8.xz * _WaveAndDistance.z));
  vec3 tmpvar_18;
  tmpvar_18 = (vertex_6.xyz - _CameraPosition.xyz);
  color_7.w = clamp (((2.0 * 
    (_WaveAndDistance.w - dot (tmpvar_18, tmpvar_18))
  ) * _CameraPosition.w), 0.0, 1.0);
  vec4 tmpvar_19;
  tmpvar_19.xyz = ((2.0 * mix (vec3(0.5, 0.5, 0.5), _WavingTint.xyz, vec3(tmpvar_17))) * gl_Color.xyz);
  tmpvar_19.w = color_7.w;
  mat3 tmpvar_20;
  tmpvar_20[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_20[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_20[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_20 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * vertex_6).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * vertex_6);
  xlv_COLOR = tmpvar_19;
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
varying vec4 xlv_COLOR;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * xlv_COLOR.w) - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "tangent" TexCoord4
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 13 [_CameraPosition]
Vector 14 [_CameraRight]
Vector 15 [_CameraUp]
Vector 10 [_ProjectionParams]
Vector 12 [_WaveAndDistance]
Vector 11 [_WavingTint]
"vs_2_0
def c16, 1.20000005, 2, 1.60000002, 4.80000019
def c17, 6.40884876, -3.14159274, 0.00833330024, -0.000198409994
def c18, 0.00600000005, 0.0199999996, 0.0500000007, -0.161616161
def c19, 0.674199879, 0.269679934, 0.134839967, 0.699999988
def c20, 0.0240000002, 0.0399999991, -0.119999997, 0.0960000008
def c21, 0.00600000005, 0.0199999996, -0.0199999996, 0.100000001
def c22, -0.5, 0.5, 0, 1
def c23, 0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002
dcl_position v0
dcl_tangent v1
dcl_normal v2
dcl_texcoord v3
dcl_color v4
add r0.xyz, v0, -c13
dp3 r0.x, r0, r0
slt r0.x, c12.w, r0.x
mad r0.xy, r0.x, -v1, v1
mad r0.xzw, r0.x, c14.xyyz, v0.xyyz
mad r0.xyz, r0.y, c15, r0.xzww
mul r1.xy, r0.xzzw, c12.y
mul r2, r1.y, c18.xyyz
mad r1, r1.x, c23, r2
mov r2.x, c12.x
mad r1, r2.x, c16, r1
frc r1, r1
mad r1, r1, c17.x, c17.y
mul r2, r1, r1
mul r3, r1, r2
mad r1, r3, c18.w, r1
mul r3, r2, r3
mul r2, r2, r3
mad r1, r3, c17.z, r1
mad r1, r2, c17.w, r1
mul r1, r1, r1
mul r1, r1, r1
mul r2, r1, v1.y
dp4 r1.x, r1, c19.xxyz
mul r1.x, r1.x, c19.w
dp4 r3.x, r2, c20
dp4 r3.z, r2, c21
mad r0.xz, r3, -c12.z, r0
add r1.yzw, r0.xxyz, -c13.xxyz
dp3 r1.y, r1.yzww, r1.yzww
add r1.y, -r1.y, c12.w
add r1.y, r1.y, r1.y
mul r1.y, r1.y, c13.w
max r1.y, r1.y, c22.z
min oD0.w, r1.y, c22.w
mov r2.x, c22.x
add r1.yzw, r2.x, c11.xxyz
mad r1.xyz, r1.x, r1.yzww, c22.y
mul r1.xyz, r1, v4
add oD0.xyz, r1, r1
mov r0.w, v0.w
dp4 oPos.x, c0, r0
dp4 oPos.y, c1, r0
dp4 oPos.z, c2, r0
dp4 oPos.w, c3, r0
dp4 r0.x, c6, r0
mul r0.x, r0.x, c10.w
mov oT1.w, -r0.x
dp3 r0.x, c7, v2
dp3 r0.y, c8, v2
dp3 r0.z, c9, v2
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT1.xyz, r0.w, r0
mov oT0.xy, v3

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "tangent" TexCoord4
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 0 [_WavingTint]
Vector 16 [_WaveAndDistance]
Vector 32 [_CameraPosition]
Vector 48 [_CameraRight] 3
Vector 64 [_CameraUp] 3
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefiecedhmncgelabcbdaabnliopgmdbndocidppabaaaaaakmajaaaaadaaaaaa
cmaaaaaaceabaaaalaabaaaaejfdeheopaaaaaaaaiaaaaaaaiaaaaaamiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaanbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapadaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaaoaaaaaaa
abaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapaaaaaaoaaaaaaaacaaaaaaaaaaaaaa
adaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaaagaaaaaa
apaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapahaaaafaepfdej
feejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfceeaaedepem
epfcaaklepfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
apaaaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadamaaaahkaaaaaa
abaaaaaaaaaaaaaaadaaaaaaadaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaa
edepemepfcaafeeffiedepepfceeaaklfdeieefcpeahaaaaeaaaabaapnabaaaa
fjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaa
fjaaaaaeegiocaaaacaaaaaaafaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaad
dcbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaa
fpaaaaadhcbabaaaahaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaad
pccabaaaabaaaaaagfaaaaaddccabaaaacaaaaaagfaaaaadpccabaaaadaaaaaa
giaaaaacaeaaaaaaaaaaaaajhcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaia
ebaaaaaaacaaaaaaacaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaadbaaaaaibcaabaaaaaaaaaaadkiacaaaacaaaaaaabaaaaaa
akaabaaaaaaaaaaadhaaaaamdcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaegbabaaaabaaaaaadcaaaaakncaabaaa
aaaaaaaaagaabaaaaaaaaaaaagijcaaaacaaaaaaadaaaaaaagbjbaaaaaaaaaaa
dcaaaaakhcaabaaaaaaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaaeaaaaaa
igadbaaaaaaaaaaadiaaaaaidcaabaaaabaaaaaaigaabaaaaaaaaaaafgifcaaa
acaaaaaaabaaaaaadiaaaaakpcaabaaaacaaaaaafgafbaaaabaaaaaaaceaaaaa
kgjlmedlaknhkddmaknhkddmmnmmemdndcaaaaampcaabaaaabaaaaaaagaabaaa
abaaaaaaaceaaaaakgjleedmaknhkddmipmchfdnkgjlmedmegaobaaaacaaaaaa
dcaaaaanpcaabaaaabaaaaaaagiacaaaacaaaaaaabaaaaaaaceaaaaajkjjjjdp
aaaaaaeamnmmmmdpjkjjjjeaegaobaaaabaaaaaabkaaaaafpcaabaaaabaaaaaa
egaobaaaabaaaaaadcaaaaappcaabaaaabaaaaaaegaobaaaabaaaaaaaceaaaaa
ekbfmneaekbfmneaekbfmneaekbfmneaaceaaaaanlapejmanlapejmanlapejma
nlapejmadiaaaaahpcaabaaaacaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaa
diaaaaahpcaabaaaadaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadcaaaaam
pcaabaaaabaaaaaaegaobaaaadaaaaaaaceaaaaalfhocflolfhocflolfhocflo
lfhocfloegaobaaaabaaaaaadiaaaaahpcaabaaaadaaaaaaegaobaaaacaaaaaa
egaobaaaadaaaaaadiaaaaahpcaabaaaacaaaaaaegaobaaaacaaaaaaegaobaaa
adaaaaaadcaaaaampcaabaaaabaaaaaaegaobaaaadaaaaaaaceaaaaagfiiaidm
gfiiaidmgfiiaidmgfiiaidmegaobaaaabaaaaaadcaaaaampcaabaaaabaaaaaa
egaobaaaacaaaaaaaceaaaaaehamfaljehamfaljehamfaljehamfaljegaobaaa
abaaaaaadiaaaaahpcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaa
diaaaaahpcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaadiaaaaah
pcaabaaaacaaaaaaegaobaaaabaaaaaafgbfbaaaabaaaaaabbaaaaakicaabaaa
aaaaaaaaegaobaaaabaaaaaaaceaaaaafnjicmdpfnjicmdphnbdikdohnbdakdo
diaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaaabeaaaaadddddddpbbaaaaak
bcaabaaaabaaaaaaegaobaaaacaaaaaaaceaaaaakgjlmedmaknhcddnipmcpfln
kgjlmednbbaaaaakecaabaaaabaaaaaaegaobaaaacaaaaaaaceaaaaakgjlmedl
aknhkddmaknhkdlmmnmmmmdndcaaaaalfcaabaaaaaaaaaaaagacbaiaebaaaaaa
abaaaaaakgikcaaaacaaaaaaabaaaaaaagacbaaaaaaaaaaadiaaaaaipcaabaaa
abaaaaaafgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaa
abaaaaaaegiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaa
dcaaaaakpcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaaaaaaaaaa
egaobaaaabaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaa
pgbpbaaaaaaaaaaaegaobaaaabaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaa
aaaaaaaackiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaaabaaaaaackiacaaa
abaaaaaaaeaaaaaaakaabaaaaaaaaaaaakaabaaaabaaaaaadcaaaaakbcaabaaa
abaaaaaackiacaaaabaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaa
aaaaaaajhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaa
acaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaa
aaaaaaajbcaabaaaaaaaaaaaakaabaiaebaaaaaaaaaaaaaadkiacaaaacaaaaaa
abaaaaaaapcaaaaiiccabaaaabaaaaaapgipcaaaacaaaaaaacaaaaaaagaabaaa
aaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaadkbabaaa
aaaaaaaaakaabaaaabaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaa
dkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaaadaaaaaaakaabaiaebaaaaaa
aaaaaaaaaaaaaaalhcaabaaaaaaaaaaaegiccaaaacaaaaaaaaaaaaaaaceaaaaa
aaaaaalpaaaaaalpaaaaaalpaaaaaaaadcaaaaamhcaabaaaaaaaaaaapgapbaaa
aaaaaaaaegacbaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaadpaaaaaaaa
aaaaaaahhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaadiaaaaah
hccabaaaabaaaaaaegacbaaaaaaaaaaaegbcbaaaahaaaaaadgaaaaafdccabaaa
acaaaaaaegbabaaaadaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaacaaaaaa
egiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaa
aiaaaaaaagbabaaaacaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaa
egiccaaaabaaaaaaakaaaaaakgbkbaaaacaaaaaaegacbaaaaaaaaaaabaaaaaah
icaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaa
aaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaadaaaaaapgapbaaaaaaaaaaa
egacbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesTANGENT;
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform lowp vec4 _WavingTint;
uniform highp vec4 _WaveAndDistance;
uniform highp vec4 _CameraPosition;
uniform highp vec3 _CameraRight;
uniform highp vec3 _CameraUp;
varying lowp vec4 xlv_COLOR;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  highp vec4 tmpvar_1;
  tmpvar_1 = _glesMultiTexCoord0;
  lowp vec4 tmpvar_2;
  tmpvar_2 = _glesColor;
  highp vec4 tmpvar_3;
  highp vec4 pos_4;
  pos_4 = _glesVertex;
  highp vec2 offset_5;
  offset_5 = _glesTANGENT.xy;
  highp vec3 tmpvar_6;
  tmpvar_6 = (_glesVertex.xyz - _CameraPosition.xyz);
  highp float tmpvar_7;
  tmpvar_7 = dot (tmpvar_6, tmpvar_6);
  if ((tmpvar_7 > _WaveAndDistance.w)) {
    offset_5 = vec2(0.0, 0.0);
  };
  pos_4.xyz = (_glesVertex.xyz + (offset_5.x * _CameraRight));
  pos_4.xyz = (pos_4.xyz + (offset_5.y * _CameraUp));
  highp vec4 vertex_8;
  vertex_8.yw = pos_4.yw;
  lowp vec4 color_9;
  color_9.xyz = tmpvar_2.xyz;
  lowp vec3 waveColor_10;
  highp vec3 waveMove_11;
  highp vec4 s_12;
  highp vec4 waves_13;
  waves_13 = (pos_4.x * (vec4(0.012, 0.02, 0.06, 0.024) * _WaveAndDistance.y));
  waves_13 = (waves_13 + (pos_4.z * (vec4(0.006, 0.02, 0.02, 0.05) * _WaveAndDistance.y)));
  waves_13 = (waves_13 + (_WaveAndDistance.x * vec4(1.2, 2.0, 1.6, 4.8)));
  highp vec4 tmpvar_14;
  tmpvar_14 = fract(waves_13);
  waves_13 = tmpvar_14;
  highp vec4 val_15;
  highp vec4 s_16;
  val_15 = ((tmpvar_14 * 6.408849) - 3.141593);
  highp vec4 tmpvar_17;
  tmpvar_17 = (val_15 * val_15);
  highp vec4 tmpvar_18;
  tmpvar_18 = (tmpvar_17 * val_15);
  highp vec4 tmpvar_19;
  tmpvar_19 = (tmpvar_18 * tmpvar_17);
  s_16 = (((val_15 + 
    (tmpvar_18 * -0.1616162)
  ) + (tmpvar_19 * 0.0083333)) + ((tmpvar_19 * tmpvar_17) * -0.00019841));
  s_12 = (s_16 * s_16);
  s_12 = (s_12 * s_12);
  highp float tmpvar_20;
  tmpvar_20 = (dot (s_12, vec4(0.6741998, 0.6741998, 0.2696799, 0.13484)) * 0.7);
  s_12 = (s_12 * _glesTANGENT.y);
  waveMove_11.y = 0.0;
  waveMove_11.x = dot (s_12, vec4(0.024, 0.04, -0.12, 0.096));
  waveMove_11.z = dot (s_12, vec4(0.006, 0.02, -0.02, 0.1));
  vertex_8.xz = (pos_4.xz - (waveMove_11.xz * _WaveAndDistance.z));
  highp vec3 tmpvar_21;
  tmpvar_21 = mix (vec3(0.5, 0.5, 0.5), _WavingTint.xyz, vec3(tmpvar_20));
  waveColor_10 = tmpvar_21;
  highp vec3 tmpvar_22;
  tmpvar_22 = (vertex_8.xyz - _CameraPosition.xyz);
  highp float tmpvar_23;
  tmpvar_23 = clamp (((2.0 * 
    (_WaveAndDistance.w - dot (tmpvar_22, tmpvar_22))
  ) * _CameraPosition.w), 0.0, 1.0);
  color_9.w = tmpvar_23;
  lowp vec4 tmpvar_24;
  tmpvar_24.xyz = ((2.0 * waveColor_10) * _glesColor.xyz);
  tmpvar_24.w = color_9.w;
  highp mat3 tmpvar_25;
  tmpvar_25[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_25[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_25[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_3.xyz = normalize((tmpvar_25 * _glesNormal));
  tmpvar_3.w = -(((glstate_matrix_modelview0 * vertex_8).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * vertex_8);
  xlv_COLOR = tmpvar_24;
  xlv_TEXCOORD0 = tmpvar_1.xy;
  xlv_TEXCOORD1 = tmpvar_3;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying lowp vec4 xlv_COLOR;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float x_2;
  x_2 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * xlv_COLOR.w) - _Cutoff);
  if ((x_2 < 0.0)) {
    discard;
  };
  highp vec4 enc_3;
  highp vec2 enc_4;
  enc_4 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_4 = (enc_4 / 1.7777);
  enc_4 = ((enc_4 * 0.5) + 0.5);
  enc_3.xy = enc_4;
  highp vec2 enc_5;
  highp vec2 tmpvar_6;
  tmpvar_6 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_5.y = tmpvar_6.y;
  enc_5.x = (tmpvar_6.x - (tmpvar_6.y * 0.003921569));
  enc_3.zw = enc_5;
  tmpvar_1 = enc_3;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Bind "tangent" TexCoord4
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 0 [_WavingTint]
Vector 16 [_WaveAndDistance]
Vector 32 [_CameraPosition]
Vector 48 [_CameraRight] 3
Vector 64 [_CameraUp] 3
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedaipagddojgancoppbocbphaplobmjbdlabaaaaaaomaoaaaaaeaaaaaa
daaaaaaagmafaaaagianaaaagaaoaaaaebgpgodjdeafaaaadeafaaaaaaacpopp
oiaeaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaacaaaaaaafaaanaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafbcaaapkakgjlmedlaknhkddmmnmmemdnlfhocflo
fbaaaaafbdaaapkajkjjjjdpaaaaaaeamnmmmmdpjkjjjjeafbaaaaafbeaaapka
ekbfmneanlapejmagfiiaidmehamfaljfbaaaaafbfaaapkafnjicmdphnbdikdo
hnbdakdodddddddpfbaaaaafbgaaapkakgjleedmaknhkddmipmchfdnkgjlmedm
fbaaaaafbhaaapkakgjlmedmaknhcddnipmcpflnkgjlmednfbaaaaafbiaaapka
kgjlmedlaknhkddmaknhkdlmmnmmmmdnfbaaaaafbjaaapkaaaaaaalpaaaaaadp
aaaaaaaaaaaaiadpbpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapja
bpaaaaacafaaaciaacaaapjabpaaaaacafaaadiaadaaapjabpaaaaacafaaahia
ahaaapjaacaaaaadaaaaahiaaaaaoejaapaaoekbaiaaaaadaaaaabiaaaaaoeia
aaaaoeiaamaaaaadaaaaabiaaoaappkaaaaaaaiaaeaaaaaeaaaaadiaaaaaaaia
abaaoejbabaaoejaaeaaaaaeaaaaaniaaaaaaaiabaaajekaaaaajejaaeaaaaae
aaaaahiaaaaaffiabbaaoekaaaaapiiaafaaaaadabaaadiaaaaaoiiaaoaaffka
afaaaaadacaaapiaabaaffiabcaajekaaeaaaaaeabaaapiaabaaaaiabgaaoeka
acaaoeiaabaaaaacacaaabiaaoaaaakaaeaaaaaeabaaapiaacaaaaiabdaaoeka
abaaoeiabdaaaaacabaaapiaabaaoeiaaeaaaaaeabaaapiaabaaoeiabeaaaaka
beaaffkaafaaaaadacaaapiaabaaoeiaabaaoeiaafaaaaadadaaapiaabaaoeia
acaaoeiaaeaaaaaeabaaapiaadaaoeiabcaappkaabaaoeiaafaaaaadadaaapia
acaaoeiaadaaoeiaafaaaaadacaaapiaacaaoeiaadaaoeiaaeaaaaaeabaaapia
adaaoeiabeaakkkaabaaoeiaaeaaaaaeabaaapiaacaaoeiabeaappkaabaaoeia
afaaaaadabaaapiaabaaoeiaabaaoeiaafaaaaadabaaapiaabaaoeiaabaaoeia
afaaaaadacaaapiaabaaoeiaabaaffjaajaaaaadaaaaaiiaabaaoeiabfaajaka
afaaaaadaaaaaiiaaaaappiabfaappkaajaaaaadabaaabiaacaaoeiabhaaoeka
ajaaaaadabaaaeiaacaaoeiabiaaoekaaeaaaaaeaaaaafiaabaaoeiaaoaakkkb
aaaaoeiaacaaaaadabaaahiaaaaaoeiaapaaoekbaiaaaaadabaaabiaabaaoeia
abaaoeiaacaaaaadabaaabiaabaaaaibaoaappkaafaaaaadabaaabiaabaaaaia
apaappkaacaaaaadabaaabiaabaaaaiaabaaaaiaalaaaaadabaaabiaabaaaaia
bjaakkkaakaaaaadaaaaaioaabaaaaiabjaappkaabaaaaacabaaabiabjaaaaka
acaaaaadabaaahiaabaaaaiaanaaoekaaeaaaaaeabaaahiaaaaappiaabaaoeia
bjaaffkaacaaaaadabaaahiaabaaoeiaabaaoeiaafaaaaadaaaaahoaabaaoeia
ahaaoejaafaaaaadabaaahiaacaaffjaalaaoekaaeaaaaaeabaaahiaakaaoeka
acaaaajaabaaoeiaaeaaaaaeabaaahiaamaaoekaacaakkjaabaaoeiaaiaaaaad
aaaaaiiaabaaoeiaabaaoeiaahaaaaacaaaaaiiaaaaappiaafaaaaadacaaahoa
aaaappiaabaaoeiaafaaaaadaaaaaiiaaaaaffiaahaakkkaafaaaaadabaaapia
aaaaffiaadaaoekaaeaaaaaeabaaapiaacaaoekaaaaaaaiaabaaoeiaaeaaaaae
abaaapiaaeaaoekaaaaakkiaabaaoeiaaeaaaaaeabaaapiaafaaoekaaaaappja
abaaoeiaaeaaaaaeaaaaabiaagaakkkaaaaaaaiaaaaappiaaeaaaaaeaaaaabia
aiaakkkaaaaakkiaaaaaaaiaaeaaaaaeaaaaabiaajaakkkaaaaappjaaaaaaaia
afaaaaadaaaaabiaaaaaaaiaabaappkaabaaaaacacaaaioaaaaaaaibaeaaaaae
aaaaadmaabaappiaaaaaoekaabaaoeiaabaaaaacaaaaammaabaaoeiaabaaaaac
abaaadoaadaaoejappppaaaafdeieefcpeahaaaaeaaaabaapnabaaaafjaaaaae
egiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaafjaaaaae
egiocaaaacaaaaaaafaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaa
abaaaaaafpaaaaadhcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaafpaaaaad
hcbabaaaahaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaadpccabaaa
abaaaaaagfaaaaaddccabaaaacaaaaaagfaaaaadpccabaaaadaaaaaagiaaaaac
aeaaaaaaaaaaaaajhcaabaaaaaaaaaaaegbcbaaaaaaaaaaaegiccaiaebaaaaaa
acaaaaaaacaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaa
aaaaaaaadbaaaaaibcaabaaaaaaaaaaadkiacaaaacaaaaaaabaaaaaaakaabaaa
aaaaaaaadhaaaaamdcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaaaaaaaaaa
aaaaaaaaaaaaaaaaaaaaaaaaegbabaaaabaaaaaadcaaaaakncaabaaaaaaaaaaa
agaabaaaaaaaaaaaagijcaaaacaaaaaaadaaaaaaagbjbaaaaaaaaaaadcaaaaak
hcaabaaaaaaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaaeaaaaaaigadbaaa
aaaaaaaadiaaaaaidcaabaaaabaaaaaaigaabaaaaaaaaaaafgifcaaaacaaaaaa
abaaaaaadiaaaaakpcaabaaaacaaaaaafgafbaaaabaaaaaaaceaaaaakgjlmedl
aknhkddmaknhkddmmnmmemdndcaaaaampcaabaaaabaaaaaaagaabaaaabaaaaaa
aceaaaaakgjleedmaknhkddmipmchfdnkgjlmedmegaobaaaacaaaaaadcaaaaan
pcaabaaaabaaaaaaagiacaaaacaaaaaaabaaaaaaaceaaaaajkjjjjdpaaaaaaea
mnmmmmdpjkjjjjeaegaobaaaabaaaaaabkaaaaafpcaabaaaabaaaaaaegaobaaa
abaaaaaadcaaaaappcaabaaaabaaaaaaegaobaaaabaaaaaaaceaaaaaekbfmnea
ekbfmneaekbfmneaekbfmneaaceaaaaanlapejmanlapejmanlapejmanlapejma
diaaaaahpcaabaaaacaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaadiaaaaah
pcaabaaaadaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadcaaaaampcaabaaa
abaaaaaaegaobaaaadaaaaaaaceaaaaalfhocflolfhocflolfhocflolfhocflo
egaobaaaabaaaaaadiaaaaahpcaabaaaadaaaaaaegaobaaaacaaaaaaegaobaaa
adaaaaaadiaaaaahpcaabaaaacaaaaaaegaobaaaacaaaaaaegaobaaaadaaaaaa
dcaaaaampcaabaaaabaaaaaaegaobaaaadaaaaaaaceaaaaagfiiaidmgfiiaidm
gfiiaidmgfiiaidmegaobaaaabaaaaaadcaaaaampcaabaaaabaaaaaaegaobaaa
acaaaaaaaceaaaaaehamfaljehamfaljehamfaljehamfaljegaobaaaabaaaaaa
diaaaaahpcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaadiaaaaah
pcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaabaaaaaadiaaaaahpcaabaaa
acaaaaaaegaobaaaabaaaaaafgbfbaaaabaaaaaabbaaaaakicaabaaaaaaaaaaa
egaobaaaabaaaaaaaceaaaaafnjicmdpfnjicmdphnbdikdohnbdakdodiaaaaah
icaabaaaaaaaaaaadkaabaaaaaaaaaaaabeaaaaadddddddpbbaaaaakbcaabaaa
abaaaaaaegaobaaaacaaaaaaaceaaaaakgjlmedmaknhcddnipmcpflnkgjlmedn
bbaaaaakecaabaaaabaaaaaaegaobaaaacaaaaaaaceaaaaakgjlmedlaknhkddm
aknhkdlmmnmmmmdndcaaaaalfcaabaaaaaaaaaaaagacbaiaebaaaaaaabaaaaaa
kgikcaaaacaaaaaaabaaaaaaagacbaaaaaaaaaaadiaaaaaipcaabaaaabaaaaaa
fgafbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaa
egiocaaaabaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaabaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaapgbpbaaa
aaaaaaaaegaobaaaabaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaa
ckiacaaaabaaaaaaafaaaaaadcaaaaakbcaabaaaabaaaaaackiacaaaabaaaaaa
aeaaaaaaakaabaaaaaaaaaaaakaabaaaabaaaaaadcaaaaakbcaabaaaabaaaaaa
ckiacaaaabaaaaaaagaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaaaaaaaaaj
hcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaacaaaaaa
baaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaaaaaaaaj
bcaabaaaaaaaaaaaakaabaiaebaaaaaaaaaaaaaadkiacaaaacaaaaaaabaaaaaa
apcaaaaiiccabaaaabaaaaaapgipcaaaacaaaaaaacaaaaaaagaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaahaaaaaadkbabaaaaaaaaaaa
akaabaaaabaaaaaadiaaaaaibcaabaaaaaaaaaaaakaabaaaaaaaaaaadkiacaaa
aaaaaaaaafaaaaaadgaaaaagiccabaaaadaaaaaaakaabaiaebaaaaaaaaaaaaaa
aaaaaaalhcaabaaaaaaaaaaaegiccaaaacaaaaaaaaaaaaaaaceaaaaaaaaaaalp
aaaaaalpaaaaaalpaaaaaaaadcaaaaamhcaabaaaaaaaaaaapgapbaaaaaaaaaaa
egacbaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaadpaaaaaaaaaaaaaaah
hcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaadiaaaaahhccabaaa
abaaaaaaegacbaaaaaaaaaaaegbcbaaaahaaaaaadgaaaaafdccabaaaacaaaaaa
egbabaaaadaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaaacaaaaaaegiccaaa
abaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaabaaaaaaaiaaaaaa
agbabaaaacaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
abaaaaaaakaaaaaakgbkbaaaacaaaaaaegacbaaaaaaaaaaabaaaaaahicaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaficaabaaaaaaaaaaa
dkaabaaaaaaaaaaadiaaaaahhccabaaaadaaaaaapgapbaaaaaaaaaaaegacbaaa
aaaaaaaadoaaaaabejfdeheopaaaaaaaaiaaaaaaaiaaaaaamiaaaaaaaaaaaaaa
aaaaaaaaadaaaaaaaaaaaaaaapapaaaanbaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaapadaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaahahaaaa
oaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaaoaaaaaaaabaaaaaa
aaaaaaaaadaaaaaaaeaaaaaaapaaaaaaoaaaaaaaacaaaaaaaaaaaaaaadaaaaaa
afaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaaagaaaaaaapaaaaaa
ojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapahaaaafaepfdejfeejepeo
aafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfceeaaedepemepfcaakl
epfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaapaaaaaa
hkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadamaaaahkaaaaaaabaaaaaa
aaaaaaaaadaaaaaaadaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaaedepemep
fcaafeeffiedepepfceeaakl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
in highp vec4 in_POSITION0;
in highp vec4 in_TANGENT0;
in highp vec3 in_NORMAL0;
in highp vec4 in_TEXCOORD0;
in lowp vec4 in_COLOR0;
out lowp vec4 vs_COLOR0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec4 t0;
bool tb0;
highp vec4 t1;
highp vec4 t2;
highp vec4 t3;
lowp vec3 t10_4;
highp float t15;
void main()
{
    t0.xyz = in_POSITION0.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    tb0 = _WaveAndDistance.w<t0.x;
    t0.xy = (bool(tb0)) ? vec2(0.0, 0.0) : in_TANGENT0.xy;
    t0.xzw = t0.xxx * _CameraRight.xyzx.xyz + in_POSITION0.xyz;
    t0.xyz = t0.yyy * _CameraUp.xyzx.xyz + t0.xzw;
    t1.xy = t0.xz * _WaveAndDistance.yy;
    t2 = t1.yyyy * vec4(0.00600000005, 0.0199999996, 0.0199999996, 0.0500000007);
    t1 = t1.xxxx * vec4(0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002) + t2;
    t1 = _WaveAndDistance.xxxx * vec4(1.20000005, 2.0, 1.60000002, 4.80000019) + t1;
    t1 = fract(t1);
    t1 = t1 * vec4(6.40884876, 6.40884876, 6.40884876, 6.40884876) + vec4(-3.14159274, -3.14159274, -3.14159274, -3.14159274);
    t2 = t1 * t1;
    t3 = t1 * t2;
    t1 = t3 * vec4(-0.161616161, -0.161616161, -0.161616161, -0.161616161) + t1;
    t3 = t2 * t3;
    t2 = t2 * t3;
    t1 = t3 * vec4(0.00833330024, 0.00833330024, 0.00833330024, 0.00833330024) + t1;
    t1 = t2 * vec4(-0.000198409994, -0.000198409994, -0.000198409994, -0.000198409994) + t1;
    t1 = t1 * t1;
    t1 = t1 * t1;
    t2 = t1 * in_TANGENT0.yyyy;
    t15 = dot(t1, vec4(0.674199879, 0.674199879, 0.269679934, 0.134839967));
    t15 = t15 * 0.699999988;
    t1.x = dot(t2, vec4(0.0240000002, 0.0399999991, -0.119999997, 0.0960000008));
    t1.z = dot(t2, vec4(0.00600000005, 0.0199999996, -0.0199999996, 0.100000001));
    t0.xz = (-t1.xz) * _WaveAndDistance.zz + t0.xz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t1;
    t1.x = t0.y * glstate_matrix_modelview0[1].z;
    t1.x = glstate_matrix_modelview0[0].z * t0.x + t1.x;
    t1.x = glstate_matrix_modelview0[2].z * t0.z + t1.x;
    t0.xyz = t0.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = (-t0.x) + _WaveAndDistance.w;
    t0.x = dot(_CameraPosition.ww, t0.xx);
    t0.x = clamp(t0.x, 0.0, 1.0);
    vs_COLOR0.w = t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t1.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t10_4.xyz = _WavingTint.xyz + vec3(-0.5, -0.5, -0.5);
    t10_4.xyz = vec3(t15) * t10_4.xyz + vec3(0.5, 0.5, 0.5);
    t10_4.xyz = t10_4.xyz * in_COLOR0.xyz;
    vs_COLOR0.xyz = t10_4.xyz * vec3(2.0, 2.0, 2.0);
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t15 = dot(t0.xyz, t0.xyz);
    t15 = inversesqrt(t15);
    vs_TEXCOORD1.xyz = vec3(t15) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
uniform lowp sampler2D _MainTex;
in lowp vec4 vs_COLOR0;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
lowp float t10_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t10_1 = t10_0 * vs_COLOR0.w + (-_Cutoff);
    tb0 = t10_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
in  vec4 in_POSITION0;
in  vec4 in_TANGENT0;
in  vec3 in_NORMAL0;
in  vec4 in_TEXCOORD0;
in  vec4 in_COLOR0;
out vec4 vs_COLOR0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec4 t0;
bool tb0;
vec4 t1;
vec4 t2;
vec4 t3;
float t12;
void main()
{
    t0.xyz = in_POSITION0.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    tb0 = _WaveAndDistance.w<t0.x;
    t0.xy = (bool(tb0)) ? vec2(0.0, 0.0) : in_TANGENT0.xy;
    t0.xzw = t0.xxx * _CameraRight.xyzx.xyz + in_POSITION0.xyz;
    t0.xyz = t0.yyy * _CameraUp.xyzx.xyz + t0.xzw;
    t1.xy = t0.xz * _WaveAndDistance.yy;
    t2 = t1.yyyy * vec4(0.00600000005, 0.0199999996, 0.0199999996, 0.0500000007);
    t1 = t1.xxxx * vec4(0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002) + t2;
    t1 = _WaveAndDistance.xxxx * vec4(1.20000005, 2.0, 1.60000002, 4.80000019) + t1;
    t1 = fract(t1);
    t1 = t1 * vec4(6.40884876, 6.40884876, 6.40884876, 6.40884876) + vec4(-3.14159274, -3.14159274, -3.14159274, -3.14159274);
    t2 = t1 * t1;
    t3 = t1 * t2;
    t1 = t3 * vec4(-0.161616161, -0.161616161, -0.161616161, -0.161616161) + t1;
    t3 = t2 * t3;
    t2 = t2 * t3;
    t1 = t3 * vec4(0.00833330024, 0.00833330024, 0.00833330024, 0.00833330024) + t1;
    t1 = t2 * vec4(-0.000198409994, -0.000198409994, -0.000198409994, -0.000198409994) + t1;
    t1 = t1 * t1;
    t1 = t1 * t1;
    t2 = t1 * in_TANGENT0.yyyy;
    t12 = dot(t1, vec4(0.674199879, 0.674199879, 0.269679934, 0.134839967));
    t12 = t12 * 0.699999988;
    t1.x = dot(t2, vec4(0.0240000002, 0.0399999991, -0.119999997, 0.0960000008));
    t1.z = dot(t2, vec4(0.00600000005, 0.0199999996, -0.0199999996, 0.100000001));
    t0.xz = (-t1.xz) * _WaveAndDistance.zz + t0.xz;
    t1 = t0.yyyy * glstate_matrix_mvp[1];
    t1 = glstate_matrix_mvp[0] * t0.xxxx + t1;
    t1 = glstate_matrix_mvp[2] * t0.zzzz + t1;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t1;
    t1.x = t0.y * glstate_matrix_modelview0[1].z;
    t1.x = glstate_matrix_modelview0[0].z * t0.x + t1.x;
    t1.x = glstate_matrix_modelview0[2].z * t0.z + t1.x;
    t0.xyz = t0.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = (-t0.x) + _WaveAndDistance.w;
    vs_COLOR0.w = dot(_CameraPosition.ww, t0.xx);
    vs_COLOR0.w = clamp(vs_COLOR0.w, 0.0, 1.0);
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t1.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = _WavingTint.xyz + vec3(-0.5, -0.5, -0.5);
    t0.xyz = vec3(t12) * t0.xyz + vec3(0.5, 0.5, 0.5);
    t0.xyz = t0.xyz + t0.xyz;
    vs_COLOR0.xyz = t0.xyz * in_COLOR0.xyz;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t12 = dot(t0.xyz, t0.xyz);
    t12 = inversesqrt(t12);
    vs_TEXCOORD1.xyz = vec3(t12) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
uniform  sampler2D _MainTex;
in  vec4 vs_COLOR0;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w * vs_COLOR0.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 1, 0.281262308, 0.5, 0.00392156886
def c2, 1, 255, 0, 0
dcl v0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
mad_pp r0, r0.w, v0.w, -c0.x
texkill r0
add r0.x, t1.z, c1.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c1.y, c1.z
mul r1.xy, t1.w, c2
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefiecedflcgomjenmgaflegamjphihbgabiopgiabaaaaaamiacaaaaadaaaaaa
cmaaaaaaliaaaaaaomaaaaaaejfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaiaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
adadaaaahkaaaaaaabaaaaaaaaaaaaaaadaaaaaaadaaaaaaapapaaaafdfgfpfa
epfdejfeejepeoaaedepemepfcaafeeffiedepepfceeaaklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklklfdeieefcneabaaaaeaaaaaaahfaaaaaafjaaaaae
egiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaa
aaaaaaaaffffaaaagcbaaaadicbabaaaabaaaaaagcbaaaaddcbabaaaacaaaaaa
gcbaaaadpcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaacaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaadcaaaaalbcaabaaaaaaaaaaadkaabaaaaaaaaaaadkbabaaaabaaaaaa
akiacaiaebaaaaaaaaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaa
aaaaaaaaabeaaaaaaaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaa
aaaaaaaackbabaaaadaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaa
egbabaaaadaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaa
aaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadp
aaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaadaaaaaa
aceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaa
egaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaa
abeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecedgjbaocghjihibnkcnbbnokiikkabjfakabaaaaaaceaeaaaaaeaaaaaa
daaaaaaaiiabaaaageadaaaapaadaaaaebgpgodjfaabaaaafaabaaaaaaacpppp
bmabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaahaaabaaaaaaaaaaaaaaaaacppppfbaaaaafabaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafacaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaacplabpaaaaacaaaaaaiaabaaadlabpaaaaacaaaaaaia
acaaaplabpaaaaacaaaaaajaaaaiapkaecaaaaadaaaacpiaabaaoelaaaaioeka
aeaaaaaeaaaacpiaaaaappiaaaaapplaaaaaaakbebaaaaabaaaaapiaacaaaaad
aaaaabiaacaakklaabaaaakaagaaaaacaaaaabiaaaaaaaiaafaaaaadaaaaadia
aaaaaaiaacaaoelaaeaaaaaeaaaacdiaaaaaoeiaabaaffkaabaakkkaafaaaaad
abaaadiaacaapplaacaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaabaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcneabaaaaeaaaaaaahfaaaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaaaaaaaaaa
ffffaaaagcbaaaadicbabaaaabaaaaaagcbaaaaddcbabaaaacaaaaaagcbaaaad
pcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaaj
pcaabaaaaaaaaaaaegbabaaaacaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaa
dcaaaaalbcaabaaaaaaaaaaadkaabaaaaaaaaaaadkbabaaaabaaaaaaakiacaia
ebaaaaaaaaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaa
abeaaaaaaaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaa
ckbabaaaadaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaa
adaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaa
aceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadp
aaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaadaaaaaaaceaaaaa
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaa
aaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaa
ibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaa
doaaaaabejfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
apaiaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadadaaaahkaaaaaa
abaaaaaaaaaaaaaaadaaaaaaadaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaa
edepemepfcaafeeffiedepepfceeaaklepfdeheocmaaaaaaabaaaaaaaiaaaaaa
caaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgf
heaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "RenderType"="Grass" }
 Pass {
  Tags { "RenderType"="Grass" }
  Cull Off
  GpuProgramID 615206
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;



uniform vec4 _WavingTint;
uniform vec4 _WaveAndDistance;
uniform vec4 _CameraPosition;
varying vec4 xlv_COLOR;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  vec4 tmpvar_1;
  vec4 vertex_2;
  vertex_2.yw = gl_Vertex.yw;
  vec4 color_3;
  color_3.xyz = gl_Color.xyz;
  vec3 waveMove_4;
  vec4 s_5;
  vec4 waves_6;
  waves_6 = (gl_Vertex.x * (vec4(0.012, 0.02, 0.06, 0.024) * _WaveAndDistance.y));
  waves_6 = (waves_6 + (gl_Vertex.z * (vec4(0.006, 0.02, 0.02, 0.05) * _WaveAndDistance.y)));
  waves_6 = (waves_6 + (_WaveAndDistance.x * vec4(1.2, 2.0, 1.6, 4.8)));
  vec4 tmpvar_7;
  tmpvar_7 = fract(waves_6);
  waves_6 = tmpvar_7;
  vec4 val_8;
  vec4 s_9;
  val_8 = ((tmpvar_7 * 6.408849) - 3.141593);
  vec4 tmpvar_10;
  tmpvar_10 = (val_8 * val_8);
  vec4 tmpvar_11;
  tmpvar_11 = (tmpvar_10 * val_8);
  vec4 tmpvar_12;
  tmpvar_12 = (tmpvar_11 * tmpvar_10);
  s_9 = (((val_8 + 
    (tmpvar_11 * -0.1616162)
  ) + (tmpvar_12 * 0.0083333)) + ((tmpvar_12 * tmpvar_10) * -0.00019841));
  s_5 = (s_9 * s_9);
  s_5 = (s_5 * s_5);
  float tmpvar_13;
  tmpvar_13 = (dot (s_5, vec4(0.6741998, 0.6741998, 0.2696799, 0.13484)) * 0.7);
  s_5 = (s_5 * (gl_Color.w * _WaveAndDistance.z));
  waveMove_4.y = 0.0;
  waveMove_4.x = dot (s_5, vec4(0.024, 0.04, -0.12, 0.096));
  waveMove_4.z = dot (s_5, vec4(0.006, 0.02, -0.02, 0.1));
  vertex_2.xz = (gl_Vertex.xz - (waveMove_4.xz * _WaveAndDistance.z));
  vec3 tmpvar_14;
  tmpvar_14 = (vertex_2.xyz - _CameraPosition.xyz);
  color_3.w = clamp (((2.0 * 
    (_WaveAndDistance.w - dot (tmpvar_14, tmpvar_14))
  ) * _CameraPosition.w), 0.0, 1.0);
  vec4 tmpvar_15;
  tmpvar_15.xyz = ((2.0 * mix (vec3(0.5, 0.5, 0.5), _WavingTint.xyz, vec3(tmpvar_13))) * gl_Color.xyz);
  tmpvar_15.w = color_3.w;
  mat3 tmpvar_16;
  tmpvar_16[0] = gl_ModelViewMatrixInverseTranspose[0].xyz;
  tmpvar_16[1] = gl_ModelViewMatrixInverseTranspose[1].xyz;
  tmpvar_16[2] = gl_ModelViewMatrixInverseTranspose[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_16 * gl_Normal));
  tmpvar_1.w = -(((gl_ModelViewMatrix * vertex_2).z * _ProjectionParams.w));
  gl_Position = (gl_ModelViewProjectionMatrix * vertex_2);
  xlv_COLOR = tmpvar_15;
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform float _Cutoff;
varying vec4 xlv_COLOR;
varying vec2 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
void main ()
{
  float x_1;
  x_1 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * xlv_COLOR.w) - _Cutoff);
  if ((x_1 < 0.0)) {
    discard;
  };
  vec4 enc_2;
  vec2 enc_3;
  enc_3 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_3 = (enc_3 / 1.7777);
  enc_3 = ((enc_3 * 0.5) + 0.5);
  enc_2.xy = enc_3;
  vec2 enc_4;
  vec2 tmpvar_5;
  tmpvar_5 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_4.y = tmpvar_5.y;
  enc_4.x = (tmpvar_5.x - (tmpvar_5.y * 0.003921569));
  enc_2.zw = enc_4;
  gl_FragData[0] = enc_2;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 7 [glstate_matrix_invtrans_modelview0] 3
Matrix 4 [glstate_matrix_modelview0] 3
Matrix 0 [glstate_matrix_mvp]
Vector 13 [_CameraPosition]
Vector 10 [_ProjectionParams]
Vector 12 [_WaveAndDistance]
Vector 11 [_WavingTint]
"vs_2_0
def c14, 0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002
def c15, 0.00600000005, 0.0199999996, 0.0500000007, -0.161616161
def c16, 1.20000005, 2, 1.60000002, 4.80000019
def c17, 6.40884876, -3.14159274, 0.00833330024, -0.000198409994
def c18, 0.674199879, 0.269679934, 0.134839967, 0.699999988
def c19, 0.0240000002, 0.0399999991, -0.119999997, 0.0960000008
def c20, 0.00600000005, 0.0199999996, -0.0199999996, 0.100000001
def c21, -0.5, 0.5, 0, 1
dcl_position v0
dcl_normal v1
dcl_texcoord v2
dcl_color v3
mul r0.xy, v0.xzzw, c12.y
mul r1, r0.y, c15.xyyz
mad r0, r0.x, c14, r1
mov r1.x, c12.x
mad r0, r1.x, c16, r0
frc r0, r0
mad r0, r0, c17.x, c17.y
mul r1, r0, r0
mul r2, r0, r1
mad r0, r2, c15.w, r0
mul r2, r1, r2
mul r1, r1, r2
mad r0, r2, c17.z, r0
mad r0, r1, c17.w, r0
mul r0, r0, r0
mul r0, r0, r0
mul r1.x, v3.w, c12.z
mul r1, r0, r1.x
dp4 r0.x, r0, c18.xxyz
mul r0.x, r0.x, c18.w
dp4 r2.x, r1, c19
dp4 r2.z, r1, c20
mad r1.xz, r2, -c12.z, v0
mov r1.yw, v0
add r0.yzw, r1.xxyz, -c13.xxyz
dp3 r0.y, r0.yzww, r0.yzww
add r0.y, -r0.y, c12.w
add r0.y, r0.y, r0.y
mul r0.y, r0.y, c13.w
max r0.y, r0.y, c21.z
min oD0.w, r0.y, c21.w
mov r2.x, c21.x
add r0.yzw, r2.x, c11.xxyz
mad r0.xyz, r0.x, r0.yzww, c21.y
mul r0.xyz, r0, v3
add oD0.xyz, r0, r0
dp4 oPos.x, c0, r1
dp4 oPos.y, c1, r1
dp4 oPos.z, c2, r1
dp4 oPos.w, c3, r1
dp4 r0.x, c6, r1
mul r0.x, r0.x, c10.w
mov oT1.w, -r0.x
dp3 r0.x, c7, v1
dp3 r0.y, c8, v1
dp3 r0.z, c9, v1
dp3 r0.w, r0, r0
rsq r0.w, r0.w
mul oT1.xyz, r0.w, r0
mov oT0.xy, v2

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 0 [_WavingTint]
Vector 16 [_WaveAndDistance]
Vector 32 [_CameraPosition]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0
root12:aaadaaaa
eefiecedoijckfbgnoogbcpphpfjjkeopnhkdebbabaaaaaabaajaaaaadaaaaaa
cmaaaaaaceabaaaalaabaaaaejfdeheopaaaaaaaaiaaaaaaaiaaaaaamiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaanbaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaaaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaaoaaaaaaa
abaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapaaaaaaoaaaaaaaacaaaaaaaaaaaaaa
adaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaaagaaaaaa
apaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapapaaaafaepfdej
feejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfceeaaedepem
epfcaaklepfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
apaaaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadamaaaahkaaaaaa
abaaaaaaaaaaaaaaadaaaaaaadaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaa
edepemepfcaafeeffiedepepfceeaaklfdeieefcfiahaaaaeaaaabaangabaaaa
fjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaa
fjaaaaaeegiocaaaacaaaaaaadaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaad
hcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaafpaaaaadpcbabaaaahaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaadpccabaaaabaaaaaagfaaaaad
dccabaaaacaaaaaagfaaaaadpccabaaaadaaaaaagiaaaaacadaaaaaadiaaaaai
dcaabaaaaaaaaaaaigbabaaaaaaaaaaafgifcaaaacaaaaaaabaaaaaadiaaaaak
pcaabaaaabaaaaaafgafbaaaaaaaaaaaaceaaaaakgjlmedlaknhkddmaknhkddm
mnmmemdndcaaaaampcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaakgjleedm
aknhkddmipmchfdnkgjlmedmegaobaaaabaaaaaadcaaaaanpcaabaaaaaaaaaaa
agiacaaaacaaaaaaabaaaaaaaceaaaaajkjjjjdpaaaaaaeamnmmmmdpjkjjjjea
egaobaaaaaaaaaaabkaaaaafpcaabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaap
pcaabaaaaaaaaaaaegaobaaaaaaaaaaaaceaaaaaekbfmneaekbfmneaekbfmnea
ekbfmneaaceaaaaanlapejmanlapejmanlapejmanlapejmadiaaaaahpcaabaaa
abaaaaaaegaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaahpcaabaaaacaaaaaa
egaobaaaaaaaaaaaegaobaaaabaaaaaadcaaaaampcaabaaaaaaaaaaaegaobaaa
acaaaaaaaceaaaaalfhocflolfhocflolfhocflolfhocfloegaobaaaaaaaaaaa
diaaaaahpcaabaaaacaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadiaaaaah
pcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadcaaaaampcaabaaa
aaaaaaaaegaobaaaacaaaaaaaceaaaaagfiiaidmgfiiaidmgfiiaidmgfiiaidm
egaobaaaaaaaaaaadcaaaaampcaabaaaaaaaaaaaegaobaaaabaaaaaaaceaaaaa
ehamfaljehamfaljehamfaljehamfaljegaobaaaaaaaaaaadiaaaaahpcaabaaa
aaaaaaaaegaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaahpcaabaaaaaaaaaaa
egaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaadkbabaaa
ahaaaaaackiacaaaacaaaaaaabaaaaaadiaaaaahpcaabaaaabaaaaaaegaobaaa
aaaaaaaaagaabaaaabaaaaaabbaaaaakbcaabaaaaaaaaaaaegaobaaaaaaaaaaa
aceaaaaafnjicmdpfnjicmdphnbdikdohnbdakdodiaaaaahbcaabaaaaaaaaaaa
akaabaaaaaaaaaaaabeaaaaadddddddpbbaaaaakbcaabaaaacaaaaaaegaobaaa
abaaaaaaaceaaaaakgjlmedmaknhcddnipmcpflnkgjlmednbbaaaaakecaabaaa
acaaaaaaegaobaaaabaaaaaaaceaaaaakgjlmedlaknhkddmaknhkdlmmnmmmmdn
dcaaaaalfcaabaaaabaaaaaaagacbaiaebaaaaaaacaaaaaakgikcaaaacaaaaaa
abaaaaaaagbcbaaaaaaaaaaadiaaaaaipcaabaaaacaaaaaafgbfbaaaaaaaaaaa
egiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaacaaaaaaegiocaaaabaaaaaa
aaaaaaaaagaabaaaabaaaaaaegaobaaaacaaaaaadcaaaaakpcaabaaaacaaaaaa
egiocaaaabaaaaaaacaaaaaakgakbaaaabaaaaaaegaobaaaacaaaaaadcaaaaak
pccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaa
acaaaaaaaaaaaaalocaabaaaaaaaaaaaagijcaaaacaaaaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaalpaaaaaalpaaaaaalpdcaaaaamhcaabaaaaaaaaaaaagaabaaa
aaaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaadpaaaaaaaa
diaaaaahhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegbcbaaaahaaaaaaaaaaaaah
hccabaaaabaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaadgaaaaafccaabaaa
abaaaaaabkbabaaaaaaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaabaaaaaa
egiccaiaebaaaaaaacaaaaaaacaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaa
aaaaaaaaegacbaaaaaaaaaaaaaaaaaajbcaabaaaaaaaaaaaakaabaiaebaaaaaa
aaaaaaaadkiacaaaacaaaaaaabaaaaaaaaaaaaahbcaabaaaaaaaaaaaakaabaaa
aaaaaaaaakaabaaaaaaaaaaadicaaaaiiccabaaaabaaaaaaakaabaaaaaaaaaaa
dkiacaaaacaaaaaaacaaaaaadgaaaaafdccabaaaacaaaaaaegbabaaaadaaaaaa
diaaaaaibcaabaaaaaaaaaaabkbabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaabaaaaaa
akaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaa
ckaabaaaabaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
abaaaaaaahaaaaaadkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaa
adaaaaaaakaabaiaebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaa
acaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
abaaaaaaaiaaaaaaagbabaaaacaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaa
aaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaaacaaaaaaegacbaaaaaaaaaaa
baaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaf
icaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaadaaaaaapgapbaaa
aaaaaaaaegacbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 glstate_matrix_mvp;
uniform highp mat4 glstate_matrix_modelview0;
uniform highp mat4 glstate_matrix_invtrans_modelview0;
uniform lowp vec4 _WavingTint;
uniform highp vec4 _WaveAndDistance;
uniform highp vec4 _CameraPosition;
varying lowp vec4 xlv_COLOR;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  highp vec4 tmpvar_1;
  highp vec4 vertex_2;
  vertex_2.yw = _glesVertex.yw;
  lowp vec4 color_3;
  color_3.xyz = _glesColor.xyz;
  lowp vec3 waveColor_4;
  highp vec3 waveMove_5;
  highp vec4 s_6;
  highp vec4 waves_7;
  waves_7 = (_glesVertex.x * (vec4(0.012, 0.02, 0.06, 0.024) * _WaveAndDistance.y));
  waves_7 = (waves_7 + (_glesVertex.z * (vec4(0.006, 0.02, 0.02, 0.05) * _WaveAndDistance.y)));
  waves_7 = (waves_7 + (_WaveAndDistance.x * vec4(1.2, 2.0, 1.6, 4.8)));
  highp vec4 tmpvar_8;
  tmpvar_8 = fract(waves_7);
  waves_7 = tmpvar_8;
  highp vec4 val_9;
  highp vec4 s_10;
  val_9 = ((tmpvar_8 * 6.408849) - 3.141593);
  highp vec4 tmpvar_11;
  tmpvar_11 = (val_9 * val_9);
  highp vec4 tmpvar_12;
  tmpvar_12 = (tmpvar_11 * val_9);
  highp vec4 tmpvar_13;
  tmpvar_13 = (tmpvar_12 * tmpvar_11);
  s_10 = (((val_9 + 
    (tmpvar_12 * -0.1616162)
  ) + (tmpvar_13 * 0.0083333)) + ((tmpvar_13 * tmpvar_11) * -0.00019841));
  s_6 = (s_10 * s_10);
  s_6 = (s_6 * s_6);
  highp float tmpvar_14;
  tmpvar_14 = (dot (s_6, vec4(0.6741998, 0.6741998, 0.2696799, 0.13484)) * 0.7);
  s_6 = (s_6 * (_glesColor.w * _WaveAndDistance.z));
  waveMove_5.y = 0.0;
  waveMove_5.x = dot (s_6, vec4(0.024, 0.04, -0.12, 0.096));
  waveMove_5.z = dot (s_6, vec4(0.006, 0.02, -0.02, 0.1));
  vertex_2.xz = (_glesVertex.xz - (waveMove_5.xz * _WaveAndDistance.z));
  highp vec3 tmpvar_15;
  tmpvar_15 = mix (vec3(0.5, 0.5, 0.5), _WavingTint.xyz, vec3(tmpvar_14));
  waveColor_4 = tmpvar_15;
  highp vec3 tmpvar_16;
  tmpvar_16 = (vertex_2.xyz - _CameraPosition.xyz);
  highp float tmpvar_17;
  tmpvar_17 = clamp (((2.0 * 
    (_WaveAndDistance.w - dot (tmpvar_16, tmpvar_16))
  ) * _CameraPosition.w), 0.0, 1.0);
  color_3.w = tmpvar_17;
  lowp vec4 tmpvar_18;
  tmpvar_18.xyz = ((2.0 * waveColor_4) * _glesColor.xyz);
  tmpvar_18.w = color_3.w;
  highp mat3 tmpvar_19;
  tmpvar_19[0] = glstate_matrix_invtrans_modelview0[0].xyz;
  tmpvar_19[1] = glstate_matrix_invtrans_modelview0[1].xyz;
  tmpvar_19[2] = glstate_matrix_invtrans_modelview0[2].xyz;
  tmpvar_1.xyz = normalize((tmpvar_19 * _glesNormal));
  tmpvar_1.w = -(((glstate_matrix_modelview0 * vertex_2).z * _ProjectionParams.w));
  gl_Position = (glstate_matrix_mvp * vertex_2);
  xlv_COLOR = tmpvar_18;
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = tmpvar_1;
}


#endif
#ifdef FRAGMENT
uniform sampler2D _MainTex;
uniform lowp float _Cutoff;
varying lowp vec4 xlv_COLOR;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float x_2;
  x_2 = ((texture2D (_MainTex, xlv_TEXCOORD0).w * xlv_COLOR.w) - _Cutoff);
  if ((x_2 < 0.0)) {
    discard;
  };
  highp vec4 enc_3;
  highp vec2 enc_4;
  enc_4 = (xlv_TEXCOORD1.xy / (xlv_TEXCOORD1.z + 1.0));
  enc_4 = (enc_4 / 1.7777);
  enc_4 = ((enc_4 * 0.5) + 0.5);
  enc_3.xy = enc_4;
  highp vec2 enc_5;
  highp vec2 tmpvar_6;
  tmpvar_6 = fract((vec2(1.0, 255.0) * xlv_TEXCOORD1.w));
  enc_5.y = tmpvar_6.y;
  enc_5.x = (tmpvar_6.x - (tmpvar_6.y * 0.003921569));
  enc_3.zw = enc_5;
  tmpvar_1 = enc_3;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
Matrix 64 [glstate_matrix_modelview0]
Matrix 128 [glstate_matrix_invtrans_modelview0]
ConstBuffer "UnityTerrain" 272
Vector 0 [_WavingTint]
Vector 16 [_WaveAndDistance]
Vector 32 [_CameraPosition]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerDraw" 1
BindCB  "UnityTerrain" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedeaonnhnfjngmeenimegmobhjcaeadghnabaaaaaapeanaaaaaeaaaaaa
daaaaaaabaafaaaahaamaaaagianaaaaebgpgodjniaeaaaaniaeaaaaaaacpopp
imaeaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaaaaaalaaacaaaaaaaaaaacaaaaaaadaaanaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafbaaaapkajkjjjjdpaaaaaaeamnmmmmdpjkjjjjea
fbaaaaafbbaaapkaekbfmneanlapejmagfiiaidmehamfaljfbaaaaafbcaaapka
kgjlmedlaknhkddmmnmmemdnlfhocflofbaaaaafbdaaapkafnjicmdphnbdikdo
hnbdakdodddddddpfbaaaaafbeaaapkakgjlmedmaknhcddnipmcpflnkgjlmedn
fbaaaaafbfaaapkakgjlmedlaknhkddmaknhkdlmmnmmmmdnfbaaaaafbgaaapka
aaaaaalpaaaaaadpaaaaaaaaaaaaiadpfbaaaaafbhaaapkakgjleedmaknhkddm
ipmchfdnkgjlmedmbpaaaaacafaaaaiaaaaaapjabpaaaaacafaaaciaacaaapja
bpaaaaacafaaadiaadaaapjabpaaaaacafaaahiaahaaapjaafaaaaadaaaaadia
aaaaoijaaoaaffkaafaaaaadabaaapiaaaaaffiabcaajekaaeaaaaaeaaaaapia
aaaaaaiabhaaoekaabaaoeiaabaaaaacabaaabiaaoaaaakaaeaaaaaeaaaaapia
abaaaaiabaaaoekaaaaaoeiabdaaaaacaaaaapiaaaaaoeiaaeaaaaaeaaaaapia
aaaaoeiabbaaaakabbaaffkaafaaaaadabaaapiaaaaaoeiaaaaaoeiaafaaaaad
acaaapiaaaaaoeiaabaaoeiaaeaaaaaeaaaaapiaacaaoeiabcaappkaaaaaoeia
afaaaaadacaaapiaabaaoeiaacaaoeiaafaaaaadabaaapiaabaaoeiaacaaoeia
aeaaaaaeaaaaapiaacaaoeiabbaakkkaaaaaoeiaaeaaaaaeaaaaapiaabaaoeia
bbaappkaaaaaoeiaafaaaaadaaaaapiaaaaaoeiaaaaaoeiaafaaaaadaaaaapia
aaaaoeiaaaaaoeiaafaaaaadabaaabiaahaappjaaoaakkkaafaaaaadabaaapia
aaaaoeiaabaaaaiaajaaaaadaaaaabiaaaaaoeiabdaajakaafaaaaadaaaaabia
aaaaaaiabdaappkaajaaaaadacaaabiaabaaoeiabeaaoekaajaaaaadacaaaeia
abaaoeiabfaaoekaaeaaaaaeabaaafiaacaaoeiaaoaakkkbaaaaoejaabaaaaac
abaaaciaaaaaffjaacaaaaadaaaaaoiaabaajaiaapaajakbaiaaaaadaaaaacia
aaaapjiaaaaapjiaacaaaaadaaaaaciaaaaaffibaoaappkaafaaaaadaaaaacia
aaaaffiaapaappkaacaaaaadaaaaaciaaaaaffiaaaaaffiaalaaaaadaaaaacia
aaaaffiabgaakkkaakaaaaadaaaaaioaaaaaffiabgaappkaabaaaaacacaaabia
bgaaaakaacaaaaadaaaaaoiaacaaaaiaanaajakaaeaaaaaeaaaaahiaaaaaaaia
aaaapjiabgaaffkaacaaaaadaaaaahiaaaaaoeiaaaaaoeiaafaaaaadaaaaahoa
aaaaoeiaahaaoejaafaaaaadaaaaahiaacaaffjaalaaoekaaeaaaaaeaaaaahia
akaaoekaacaaaajaaaaaoeiaaeaaaaaeaaaaahiaamaaoekaacaakkjaaaaaoeia
aiaaaaadaaaaaiiaaaaaoeiaaaaaoeiaahaaaaacaaaaaiiaaaaappiaafaaaaad
acaaahoaaaaappiaaaaaoeiaafaaaaadaaaaabiaaaaaffjaahaakkkaaeaaaaae
aaaaabiaagaakkkaabaaaaiaaaaaaaiaaeaaaaaeaaaaabiaaiaakkkaabaakkia
aaaaaaiaaeaaaaaeaaaaabiaajaakkkaaaaappjaaaaaaaiaafaaaaadaaaaabia
aaaaaaiaabaappkaabaaaaacacaaaioaaaaaaaibafaaaaadaaaaapiaaaaaffja
adaaoekaaeaaaaaeaaaaapiaacaaoekaabaaaaiaaaaaoeiaaeaaaaaeaaaaapia
aeaaoekaabaakkiaaaaaoeiaaeaaaaaeaaaaapiaafaaoekaaaaappjaaaaaoeia
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
abaaaaacabaaadoaadaaoejappppaaaafdeieefcfiahaaaaeaaaabaangabaaaa
fjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaalaaaaaa
fjaaaaaeegiocaaaacaaaaaaadaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaad
hcbabaaaacaaaaaafpaaaaaddcbabaaaadaaaaaafpaaaaadpcbabaaaahaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaadpccabaaaabaaaaaagfaaaaad
dccabaaaacaaaaaagfaaaaadpccabaaaadaaaaaagiaaaaacadaaaaaadiaaaaai
dcaabaaaaaaaaaaaigbabaaaaaaaaaaafgifcaaaacaaaaaaabaaaaaadiaaaaak
pcaabaaaabaaaaaafgafbaaaaaaaaaaaaceaaaaakgjlmedlaknhkddmaknhkddm
mnmmemdndcaaaaampcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaakgjleedm
aknhkddmipmchfdnkgjlmedmegaobaaaabaaaaaadcaaaaanpcaabaaaaaaaaaaa
agiacaaaacaaaaaaabaaaaaaaceaaaaajkjjjjdpaaaaaaeamnmmmmdpjkjjjjea
egaobaaaaaaaaaaabkaaaaafpcaabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaap
pcaabaaaaaaaaaaaegaobaaaaaaaaaaaaceaaaaaekbfmneaekbfmneaekbfmnea
ekbfmneaaceaaaaanlapejmanlapejmanlapejmanlapejmadiaaaaahpcaabaaa
abaaaaaaegaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaahpcaabaaaacaaaaaa
egaobaaaaaaaaaaaegaobaaaabaaaaaadcaaaaampcaabaaaaaaaaaaaegaobaaa
acaaaaaaaceaaaaalfhocflolfhocflolfhocflolfhocfloegaobaaaaaaaaaaa
diaaaaahpcaabaaaacaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadiaaaaah
pcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadcaaaaampcaabaaa
aaaaaaaaegaobaaaacaaaaaaaceaaaaagfiiaidmgfiiaidmgfiiaidmgfiiaidm
egaobaaaaaaaaaaadcaaaaampcaabaaaaaaaaaaaegaobaaaabaaaaaaaceaaaaa
ehamfaljehamfaljehamfaljehamfaljegaobaaaaaaaaaaadiaaaaahpcaabaaa
aaaaaaaaegaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaahpcaabaaaaaaaaaaa
egaobaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaadkbabaaa
ahaaaaaackiacaaaacaaaaaaabaaaaaadiaaaaahpcaabaaaabaaaaaaegaobaaa
aaaaaaaaagaabaaaabaaaaaabbaaaaakbcaabaaaaaaaaaaaegaobaaaaaaaaaaa
aceaaaaafnjicmdpfnjicmdphnbdikdohnbdakdodiaaaaahbcaabaaaaaaaaaaa
akaabaaaaaaaaaaaabeaaaaadddddddpbbaaaaakbcaabaaaacaaaaaaegaobaaa
abaaaaaaaceaaaaakgjlmedmaknhcddnipmcpflnkgjlmednbbaaaaakecaabaaa
acaaaaaaegaobaaaabaaaaaaaceaaaaakgjlmedlaknhkddmaknhkdlmmnmmmmdn
dcaaaaalfcaabaaaabaaaaaaagacbaiaebaaaaaaacaaaaaakgikcaaaacaaaaaa
abaaaaaaagbcbaaaaaaaaaaadiaaaaaipcaabaaaacaaaaaafgbfbaaaaaaaaaaa
egiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaaacaaaaaaegiocaaaabaaaaaa
aaaaaaaaagaabaaaabaaaaaaegaobaaaacaaaaaadcaaaaakpcaabaaaacaaaaaa
egiocaaaabaaaaaaacaaaaaakgakbaaaabaaaaaaegaobaaaacaaaaaadcaaaaak
pccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaa
acaaaaaaaaaaaaalocaabaaaaaaaaaaaagijcaaaacaaaaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaalpaaaaaalpaaaaaalpdcaaaaamhcaabaaaaaaaaaaaagaabaaa
aaaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaadpaaaaaaaa
diaaaaahhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegbcbaaaahaaaaaaaaaaaaah
hccabaaaabaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaadgaaaaafccaabaaa
abaaaaaabkbabaaaaaaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaabaaaaaa
egiccaiaebaaaaaaacaaaaaaacaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaa
aaaaaaaaegacbaaaaaaaaaaaaaaaaaajbcaabaaaaaaaaaaaakaabaiaebaaaaaa
aaaaaaaadkiacaaaacaaaaaaabaaaaaaaaaaaaahbcaabaaaaaaaaaaaakaabaaa
aaaaaaaaakaabaaaaaaaaaaadicaaaaiiccabaaaabaaaaaaakaabaaaaaaaaaaa
dkiacaaaacaaaaaaacaaaaaadgaaaaafdccabaaaacaaaaaaegbabaaaadaaaaaa
diaaaaaibcaabaaaaaaaaaaabkbabaaaaaaaaaaackiacaaaabaaaaaaafaaaaaa
dcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaaeaaaaaaakaabaaaabaaaaaa
akaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaaabaaaaaaagaaaaaa
ckaabaaaabaaaaaaakaabaaaaaaaaaaadcaaaaakbcaabaaaaaaaaaaackiacaaa
abaaaaaaahaaaaaadkbabaaaaaaaaaaaakaabaaaaaaaaaaadiaaaaaibcaabaaa
aaaaaaaaakaabaaaaaaaaaaadkiacaaaaaaaaaaaafaaaaaadgaaaaagiccabaaa
adaaaaaaakaabaiaebaaaaaaaaaaaaaadiaaaaaihcaabaaaaaaaaaaafgbfbaaa
acaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaa
abaaaaaaaiaaaaaaagbabaaaacaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaa
aaaaaaaaegiccaaaabaaaaaaakaaaaaakgbkbaaaacaaaaaaegacbaaaaaaaaaaa
baaaaaahicaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaeeaaaaaf
icaabaaaaaaaaaaadkaabaaaaaaaaaaadiaaaaahhccabaaaadaaaaaapgapbaaa
aaaaaaaaegacbaaaaaaaaaaadoaaaaabejfdeheopaaaaaaaaiaaaaaaaiaaaaaa
miaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaanbaaaaaaaaaaaaaa
aaaaaaaaadaaaaaaabaaaaaaapaaaaaanjaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
acaaaaaaahahaaaaoaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapadaaaa
oaaaaaaaabaaaaaaaaaaaaaaadaaaaaaaeaaaaaaapaaaaaaoaaaaaaaacaaaaaa
aaaaaaaaadaaaaaaafaaaaaaapaaaaaaoaaaaaaaadaaaaaaaaaaaaaaadaaaaaa
agaaaaaaapaaaaaaojaaaaaaaaaaaaaaaaaaaaaaadaaaaaaahaaaaaaapapaaaa
faepfdejfeejepeoaafeebeoehefeofeaaeoepfcenebemaafeeffiedepepfcee
aaedepemepfcaaklepfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaapaaaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadamaaaa
hkaaaaaaabaaaaaaaaaaaaaaadaaaaaaadaaaaaaapaaaaaafdfgfpfaepfdejfe
ejepeoaaedepemepfcaafeeffiedepepfceeaakl"
}
SubProgram "gles3 " {
"!!GLES3
#ifdef VERTEX
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in highp vec4 in_TEXCOORD0;
in lowp vec4 in_COLOR0;
out lowp vec4 vs_COLOR0;
out highp vec2 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
highp vec4 t0;
highp vec4 t1;
highp vec4 t2;
lowp vec3 t10_3;
highp float t12;
void main()
{
    t0.xy = in_POSITION0.xz * _WaveAndDistance.yy;
    t1 = t0.yyyy * vec4(0.00600000005, 0.0199999996, 0.0199999996, 0.0500000007);
    t0 = t0.xxxx * vec4(0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002) + t1;
    t0 = _WaveAndDistance.xxxx * vec4(1.20000005, 2.0, 1.60000002, 4.80000019) + t0;
    t0 = fract(t0);
    t0 = t0 * vec4(6.40884876, 6.40884876, 6.40884876, 6.40884876) + vec4(-3.14159274, -3.14159274, -3.14159274, -3.14159274);
    t1 = t0 * t0;
    t2 = t0 * t1;
    t0 = t2 * vec4(-0.161616161, -0.161616161, -0.161616161, -0.161616161) + t0;
    t2 = t1 * t2;
    t1 = t1 * t2;
    t0 = t2 * vec4(0.00833330024, 0.00833330024, 0.00833330024, 0.00833330024) + t0;
    t0 = t1 * vec4(-0.000198409994, -0.000198409994, -0.000198409994, -0.000198409994) + t0;
    t0 = t0 * t0;
    t0 = t0 * t0;
    t1.x = in_COLOR0.w * _WaveAndDistance.z;
    t1 = t0 * t1.xxxx;
    t0.x = dot(t0, vec4(0.674199879, 0.674199879, 0.269679934, 0.134839967));
    t0.x = t0.x * 0.699999988;
    t2.x = dot(t1, vec4(0.0240000002, 0.0399999991, -0.119999997, 0.0960000008));
    t2.z = dot(t1, vec4(0.00600000005, 0.0199999996, -0.0199999996, 0.100000001));
    t1.xz = (-t2.xz) * _WaveAndDistance.zz + in_POSITION0.xz;
    t2 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t2 = glstate_matrix_mvp[0] * t1.xxxx + t2;
    t2 = glstate_matrix_mvp[2] * t1.zzzz + t2;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t2;
    t10_3.xyz = _WavingTint.xyz + vec3(-0.5, -0.5, -0.5);
    t10_3.xyz = t0.xxx * t10_3.xyz + vec3(0.5, 0.5, 0.5);
    t10_3.xyz = t10_3.xyz * in_COLOR0.xyz;
    vs_COLOR0.xyz = t10_3.xyz * vec3(2.0, 2.0, 2.0);
    t1.y = in_POSITION0.y;
    t0.xyz = t1.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = (-t0.x) + _WaveAndDistance.w;
    t0.x = dot(_CameraPosition.ww, t0.xx);
    t0.x = clamp(t0.x, 0.0, 1.0);
    vs_COLOR0.w = t0.x;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t1.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * t1.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t12 = dot(t0.xyz, t0.xyz);
    t12 = inversesqrt(t12);
    vs_TEXCOORD1.xyz = vec3(t12) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es
precision highp float;
precision highp int;
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	mediump vec4 unity_4LightAtten0;
uniform 	mediump vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	mediump vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	mediump vec4 unity_SHAr;
uniform 	mediump vec4 unity_SHAg;
uniform 	mediump vec4 unity_SHAb;
uniform 	mediump vec4 unity_SHBr;
uniform 	mediump vec4 unity_SHBg;
uniform 	mediump vec4 unity_SHBb;
uniform 	mediump vec4 unity_SHC;
uniform 	mediump vec3 unity_LightColor0;
uniform 	mediump vec3 unity_LightColor1;
uniform 	mediump vec3 unity_LightColor2;
uniform 	mediump vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	mediump vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	lowp vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	lowp vec4 unity_AmbientSky;
uniform 	lowp vec4 unity_AmbientEquator;
uniform 	lowp vec4 unity_AmbientGround;
uniform 	lowp vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	mediump vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	mediump vec4 unity_SpecCube1_HDR;
uniform 	lowp vec4 unity_ColorSpaceGrey;
uniform 	lowp vec4 unity_ColorSpaceDouble;
uniform 	mediump vec4 unity_ColorSpaceDielectricSpec;
uniform 	mediump vec4 unity_ColorSpaceLuminance;
uniform 	mediump vec4 unity_Lightmap_HDR;
uniform 	mediump vec4 unity_DynamicLightmap_HDR;
uniform 	lowp vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	lowp vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	lowp float _Cutoff;
uniform lowp sampler2D _MainTex;
in lowp vec4 vs_COLOR0;
in highp vec2 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
lowp float t10_0;
bool tb0;
lowp float t10_1;
highp vec2 t2;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy).w;
    t10_1 = t10_0 * vs_COLOR0.w + (-_Cutoff);
    tb0 = t10_1<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t2.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t2.xy = fract(t2.xy);
    t0.z = (-t2.y) * 0.00392156886 + t2.x;
    t0.w = t2.y;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
"!!GL3x
#ifdef VERTEX
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
in  vec4 in_TEXCOORD0;
in  vec4 in_COLOR0;
out vec4 vs_COLOR0;
out vec2 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
vec4 t0;
vec4 t1;
vec4 t2;
vec3 t3;
float t9;
void main()
{
    t0.xy = in_POSITION0.xz * _WaveAndDistance.yy;
    t1 = t0.yyyy * vec4(0.00600000005, 0.0199999996, 0.0199999996, 0.0500000007);
    t0 = t0.xxxx * vec4(0.0120000001, 0.0199999996, 0.0599999987, 0.0240000002) + t1;
    t0 = _WaveAndDistance.xxxx * vec4(1.20000005, 2.0, 1.60000002, 4.80000019) + t0;
    t0 = fract(t0);
    t0 = t0 * vec4(6.40884876, 6.40884876, 6.40884876, 6.40884876) + vec4(-3.14159274, -3.14159274, -3.14159274, -3.14159274);
    t1 = t0 * t0;
    t2 = t0 * t1;
    t0 = t2 * vec4(-0.161616161, -0.161616161, -0.161616161, -0.161616161) + t0;
    t2 = t1 * t2;
    t1 = t1 * t2;
    t0 = t2 * vec4(0.00833330024, 0.00833330024, 0.00833330024, 0.00833330024) + t0;
    t0 = t1 * vec4(-0.000198409994, -0.000198409994, -0.000198409994, -0.000198409994) + t0;
    t0 = t0 * t0;
    t0 = t0 * t0;
    t1.x = in_COLOR0.w * _WaveAndDistance.z;
    t1 = t0 * t1.xxxx;
    t0.x = dot(t0, vec4(0.674199879, 0.674199879, 0.269679934, 0.134839967));
    t0.x = t0.x * 0.699999988;
    t2.x = dot(t1, vec4(0.0240000002, 0.0399999991, -0.119999997, 0.0960000008));
    t2.z = dot(t1, vec4(0.00600000005, 0.0199999996, -0.0199999996, 0.100000001));
    t1.xz = (-t2.xz) * _WaveAndDistance.zz + in_POSITION0.xz;
    t2 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t2 = glstate_matrix_mvp[0] * t1.xxxx + t2;
    t2 = glstate_matrix_mvp[2] * t1.zzzz + t2;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t2;
    t3.xyz = _WavingTint.xyz + vec3(-0.5, -0.5, -0.5);
    t0.xyz = t0.xxx * t3.xyz + vec3(0.5, 0.5, 0.5);
    t0.xyz = t0.xyz * in_COLOR0.xyz;
    vs_COLOR0.xyz = t0.xyz + t0.xyz;
    t1.y = in_POSITION0.y;
    t0.xyz = t1.xyz + (-_CameraPosition.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = (-t0.x) + _WaveAndDistance.w;
    t0.x = t0.x + t0.x;
    vs_COLOR0.w = t0.x * _CameraPosition.w;
    vs_COLOR0.w = clamp(vs_COLOR0.w, 0.0, 1.0);
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    t0.x = in_POSITION0.y * glstate_matrix_modelview0[1].z;
    t0.x = glstate_matrix_modelview0[0].z * t1.x + t0.x;
    t0.x = glstate_matrix_modelview0[2].z * t1.z + t0.x;
    t0.x = glstate_matrix_modelview0[3].z * in_POSITION0.w + t0.x;
    t0.x = t0.x * _ProjectionParams.w;
    vs_TEXCOORD1.w = (-t0.x);
    t0.xyz = in_NORMAL0.yyy * glstate_matrix_invtrans_modelview0[1].xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[0].xyz * in_NORMAL0.xxx + t0.xyz;
    t0.xyz = glstate_matrix_invtrans_modelview0[2].xyz * in_NORMAL0.zzz + t0.xyz;
    t9 = dot(t0.xyz, t0.xyz);
    t9 = inversesqrt(t9);
    vs_TEXCOORD1.xyz = vec3(t9) * t0.xyz;
    return;
}

#endif
#ifdef FRAGMENT
#version 150
#extension GL_ARB_shader_bit_encoding : enable
uniform 	vec4 _Time;
uniform 	vec4 _SinTime;
uniform 	vec4 _CosTime;
uniform 	vec4 unity_DeltaTime;
uniform 	vec3 _WorldSpaceCameraPos;
uniform 	vec4 _ProjectionParams;
uniform 	vec4 _ScreenParams;
uniform 	vec4 _ZBufferParams;
uniform 	vec4 unity_OrthoParams;
uniform 	vec4 unity_CameraWorldClipPlanes[6];
uniform 	mat4 unity_CameraProjection;
uniform 	mat4 unity_CameraInvProjection;
uniform 	vec4 _WorldSpaceLightPos0;
uniform 	vec4 _LightPositionRange;
uniform 	vec4 unity_4LightPosX0;
uniform 	vec4 unity_4LightPosY0;
uniform 	vec4 unity_4LightPosZ0;
uniform 	vec4 unity_4LightAtten0;
uniform 	vec4 unity_LightColor[8];
uniform 	vec4 unity_LightPosition[8];
uniform 	vec4 unity_LightAtten[8];
uniform 	vec4 unity_SpotDirection[8];
uniform 	vec4 unity_SHAr;
uniform 	vec4 unity_SHAg;
uniform 	vec4 unity_SHAb;
uniform 	vec4 unity_SHBr;
uniform 	vec4 unity_SHBg;
uniform 	vec4 unity_SHBb;
uniform 	vec4 unity_SHC;
uniform 	vec3 unity_LightColor0;
uniform 	vec3 unity_LightColor1;
uniform 	vec3 unity_LightColor2;
uniform 	vec3 unity_LightColor3;
uniform 	vec4 unity_ShadowSplitSpheres[4];
uniform 	vec4 unity_ShadowSplitSqRadii;
uniform 	vec4 unity_LightShadowBias;
uniform 	vec4 _LightSplitsNear;
uniform 	vec4 _LightSplitsFar;
uniform 	mat4 unity_World2Shadow[4];
uniform 	vec4 _LightShadowData;
uniform 	vec4 unity_ShadowFadeCenterAndType;
uniform 	mat4 glstate_matrix_mvp;
uniform 	mat4 glstate_matrix_modelview0;
uniform 	mat4 glstate_matrix_invtrans_modelview0;
uniform 	mat4 _Object2World;
uniform 	mat4 _World2Object;
uniform 	vec4 unity_LODFade;
uniform 	vec4 unity_WorldTransformParams;
uniform 	mat4 glstate_matrix_transpose_modelview0;
uniform 	mat4 glstate_matrix_projection;
uniform 	vec4 glstate_lightmodel_ambient;
uniform 	mat4 unity_MatrixV;
uniform 	mat4 unity_MatrixVP;
uniform 	vec4 unity_AmbientSky;
uniform 	vec4 unity_AmbientEquator;
uniform 	vec4 unity_AmbientGround;
uniform 	vec4 unity_FogColor;
uniform 	vec4 unity_FogParams;
uniform 	vec4 unity_LightmapST;
uniform 	vec4 unity_DynamicLightmapST;
uniform 	vec4 unity_SpecCube0_BoxMax;
uniform 	vec4 unity_SpecCube0_BoxMin;
uniform 	vec4 unity_SpecCube0_ProbePosition;
uniform 	vec4 unity_SpecCube0_HDR;
uniform 	vec4 unity_SpecCube1_BoxMax;
uniform 	vec4 unity_SpecCube1_BoxMin;
uniform 	vec4 unity_SpecCube1_ProbePosition;
uniform 	vec4 unity_SpecCube1_HDR;
uniform 	vec4 unity_ColorSpaceGrey;
uniform 	vec4 unity_ColorSpaceDouble;
uniform 	vec4 unity_ColorSpaceDielectricSpec;
uniform 	vec4 unity_ColorSpaceLuminance;
uniform 	vec4 unity_Lightmap_HDR;
uniform 	vec4 unity_DynamicLightmap_HDR;
uniform 	vec4 _WavingTint;
uniform 	vec4 _WaveAndDistance;
uniform 	vec4 _CameraPosition;
uniform 	vec3 _CameraRight;
uniform 	vec3 _CameraUp;
uniform 	vec4 _TreeInstanceColor;
uniform 	vec4 _TreeInstanceScale;
uniform 	mat4 _TerrainEngineBendTree;
uniform 	vec4 _SquashPlaneNormal;
uniform 	float _SquashAmount;
uniform 	vec3 _TreeBillboardCameraRight;
uniform 	vec4 _TreeBillboardCameraUp;
uniform 	vec4 _TreeBillboardCameraFront;
uniform 	vec4 _TreeBillboardCameraPos;
uniform 	vec4 _TreeBillboardDistances;
uniform 	vec4 _Wind;
uniform 	float _Cutoff;
uniform  sampler2D _MainTex;
in  vec4 vs_COLOR0;
in  vec2 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
out vec4 SV_Target0;
vec2 t0;
lowp vec4 t10_0;
bool tb0;
void main()
{
    t10_0 = texture(_MainTex, vs_TEXCOORD0.xy);
    t0.x = t10_0.w * vs_COLOR0.w + (-_Cutoff);
    tb0 = t0.x<0.0;
    if((int(tb0) * int(0xffffffffu))!=0){discard;}
    t0.x = vs_TEXCOORD1.z + 1.0;
    t0.xy = vs_TEXCOORD1.xy / t0.xx;
    SV_Target0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t0.xy = vs_TEXCOORD1.ww * vec2(1.0, 255.0);
    t0.xy = fract(t0.xy);
    SV_Target0.z = (-t0.y) * 0.00392156886 + t0.x;
    SV_Target0.w = t0.y;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "opengl " {
"!!GLSL"
}
SubProgram "d3d9 " {
Float 0 [_Cutoff]
SetTexture 0 [_MainTex] 2D 0
"ps_2_0
def c1, 1, 0.281262308, 0.5, 0.00392156886
def c2, 1, 255, 0, 0
dcl v0
dcl t0.xy
dcl t1
dcl_2d s0
texld_pp r0, t0, s0
mad_pp r0, r0.w, v0.w, -c0.x
texkill r0
add r0.x, t1.z, c1.x
rcp r0.x, r0.x
mul r0.xy, r0.x, t1
mad_pp r0.xy, r0, c1.y, c1.z
mul r1.xy, t1.w, c2
frc r1.xy, r1
mad_pp r0.z, r1.y, -c1.w, r1.x
mov_pp r0.w, r1.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0
root12:abababaa
eefiecedflcgomjenmgaflegamjphihbgabiopgiabaaaaaamiacaaaaadaaaaaa
cmaaaaaaliaaaaaaomaaaaaaejfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaapaiaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
adadaaaahkaaaaaaabaaaaaaaaaaaaaaadaaaaaaadaaaaaaapapaaaafdfgfpfa
epfdejfeejepeoaaedepemepfcaafeeffiedepepfceeaaklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklklfdeieefcneabaaaaeaaaaaaahfaaaaaafjaaaaae
egiocaaaaaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaa
aaaaaaaaffffaaaagcbaaaadicbabaaaabaaaaaagcbaaaaddcbabaaaacaaaaaa
gcbaaaadpcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaacaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaadcaaaaalbcaabaaaaaaaaaaadkaabaaaaaaaaaaadkbabaaaabaaaaaa
akiacaiaebaaaaaaaaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaa
aaaaaaaaabeaaaaaaaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaa
aaaaaaaackbabaaaadaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaa
egbabaaaadaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaa
aaaaaaaaaceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadp
aaaaaadpaaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaadaaaaaa
aceaaaaaaaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaa
egaabaaaaaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaa
abeaaaaaibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_MainTex] 2D 0
ConstBuffer "$Globals" 128
Float 112 [_Cutoff]
BindCB  "$Globals" 0
"ps_4_0_level_9_1
root12:abababaa
eefiecedgjbaocghjihibnkcnbbnokiikkabjfakabaaaaaaceaeaaaaaeaaaaaa
daaaaaaaiiabaaaageadaaaapaadaaaaebgpgodjfaabaaaafaabaaaaaaacpppp
bmabaaaadeaaaaaaabaaciaaaaaadeaaaaaadeaaabaaceaaaaaadeaaaaaaaaaa
aaaaahaaabaaaaaaaaaaaaaaaaacppppfbaaaaafabaaapkaaaaaiadpjnabjado
aaaaaadpibiaiadlfbaaaaafacaaapkaaaaaiadpaaaahpedaaaaaaaaaaaaaaaa
bpaaaaacaaaaaaiaaaaacplabpaaaaacaaaaaaiaabaaadlabpaaaaacaaaaaaia
acaaaplabpaaaaacaaaaaajaaaaiapkaecaaaaadaaaacpiaabaaoelaaaaioeka
aeaaaaaeaaaacpiaaaaappiaaaaapplaaaaaaakbebaaaaabaaaaapiaacaaaaad
aaaaabiaacaakklaabaaaakaagaaaaacaaaaabiaaaaaaaiaafaaaaadaaaaadia
aaaaaaiaacaaoelaaeaaaaaeaaaacdiaaaaaoeiaabaaffkaabaakkkaafaaaaad
abaaadiaacaapplaacaaoekabdaaaaacabaaadiaabaaoeiaaeaaaaaeaaaaceia
abaaffiaabaappkbabaaaaiaabaaaaacaaaaciiaabaaffiaabaaaaacaaaicpia
aaaaoeiappppaaaafdeieefcneabaaaaeaaaaaaahfaaaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafibiaaaeaahabaaaaaaaaaaa
ffffaaaagcbaaaadicbabaaaabaaaaaagcbaaaaddcbabaaaacaaaaaagcbaaaad
pcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacabaaaaaaefaaaaaj
pcaabaaaaaaaaaaaegbabaaaacaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaa
dcaaaaalbcaabaaaaaaaaaaadkaabaaaaaaaaaaadkbabaaaabaaaaaaakiacaia
ebaaaaaaaaaaaaaaahaaaaaadbaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaa
abeaaaaaaaaaaaaaanaaaeadakaabaaaaaaaaaaaaaaaaaahbcaabaaaaaaaaaaa
ckbabaaaadaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegbabaaa
adaaaaaaagaabaaaaaaaaaaadcaaaaapdccabaaaaaaaaaaaegaabaaaaaaaaaaa
aceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadp
aaaaaaaaaaaaaaaadiaaaaakdcaabaaaaaaaaaaapgbpbaaaadaaaaaaaceaaaaa
aaaaiadpaaaahpedaaaaaaaaaaaaaaaabkaaaaafdcaabaaaaaaaaaaaegaabaaa
aaaaaaaadcaaaaakeccabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaa
ibiaiadlakaabaaaaaaaaaaadgaaaaaficcabaaaaaaaaaaabkaabaaaaaaaaaaa
doaaaaabejfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaa
adaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaa
apaiaaaahkaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaadadaaaahkaaaaaa
abaaaaaaaaaaaaaaadaaaaaaadaaaaaaapapaaaafdfgfpfaepfdejfeejepeoaa
edepemepfcaafeeffiedepepfceeaaklepfdeheocmaaaaaaabaaaaaaaiaaaaaa
caaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgf
heaaklkl"
}
SubProgram "gles3 " {
"!!GLES3"
}
SubProgram "glcore " {
"!!GL3x"
}
}
 }
}
Fallback Off
}
//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Internal-CombineDepthNormals" {
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 4591
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX

uniform vec4 _CameraNormalsTexture_ST;
varying vec2 xlv_TEXCOORD0;
void main ()
{
  gl_Position = (gl_ModelViewProjectionMatrix * gl_Vertex);
  xlv_TEXCOORD0 = ((gl_MultiTexCoord0.xy * _CameraNormalsTexture_ST.xy) + _CameraNormalsTexture_ST.zw);
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform sampler2D _CameraDepthTexture;
uniform sampler2D _CameraNormalsTexture;
uniform mat4 _WorldToCamera;
varying vec2 xlv_TEXCOORD0;
void main ()
{
  vec3 n_1;
  float tmpvar_2;
  tmpvar_2 = (1.0/(((_ZBufferParams.x * texture2D (_CameraDepthTexture, xlv_TEXCOORD0).x) + _ZBufferParams.y)));
  mat3 tmpvar_3;
  tmpvar_3[0] = _WorldToCamera[0].xyz;
  tmpvar_3[1] = _WorldToCamera[1].xyz;
  tmpvar_3[2] = _WorldToCamera[2].xyz;
  n_1 = (tmpvar_3 * ((texture2D (_CameraNormalsTexture, xlv_TEXCOORD0) * 2.0) - 1.0).xyz);
  n_1.z = -(n_1.z);
  vec4 tmpvar_4;
  if ((tmpvar_2 < 0.9999846)) {
    vec4 enc_5;
    vec2 enc_6;
    enc_6 = (n_1.xy / (n_1.z + 1.0));
    enc_6 = (enc_6 / 1.7777);
    enc_6 = ((enc_6 * 0.5) + 0.5);
    enc_5.xy = enc_6;
    vec2 enc_7;
    vec2 tmpvar_8;
    tmpvar_8 = fract((vec2(1.0, 255.0) * tmpvar_2));
    enc_7.y = tmpvar_8.y;
    enc_7.x = (tmpvar_8.x - (tmpvar_8.y * 0.003921569));
    enc_5.zw = enc_7;
    tmpvar_4 = enc_5;
  } else {
    tmpvar_4 = vec4(0.5, 0.5, 1.0, 1.0);
  };
  gl_FragData[0] = tmpvar_4;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Vector 4 [_CameraNormalsTexture_ST]
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
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
ConstBuffer "$Globals" 176
Vector 96 [_CameraNormalsTexture_ST]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "$Globals" 0
BindCB  "UnityPerDraw" 1
"vs_4_0
root12:aaacaaaa
eefiecedgonlkjgafniaclaedpnpgjnkochaoaljabaaaaaaamacaaaaadaaaaaa
cmaaaaaaiaaaaaaaniaaaaaaejfdeheoemaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaaebaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafaepfdejfeejepeoaafeeffiedepepfceeaaklkl
epfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaa
fdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklklfdeieefccmabaaaa
eaaaabaaelaaaaaafjaaaaaeegiocaaaaaaaaaaaahaaaaaafjaaaaaeegiocaaa
abaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagiaaaaac
abaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaabaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaa
egiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaal
dccabaaaabaaaaaaegbabaaaabaaaaaaegiacaaaaaaaaaaaagaaaaaaogikcaaa
aaaaaaaaagaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesMultiTexCoord0;
uniform highp mat4 glstate_matrix_mvp;
uniform highp vec4 _CameraNormalsTexture_ST;
varying highp vec2 xlv_TEXCOORD0;
void main ()
{
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = ((_glesMultiTexCoord0.xy * _CameraNormalsTexture_ST.xy) + _CameraNormalsTexture_ST.zw);
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp sampler2D _CameraDepthTexture;
uniform sampler2D _CameraNormalsTexture;
uniform highp mat4 _WorldToCamera;
varying highp vec2 xlv_TEXCOORD0;
void main ()
{
  lowp vec4 tmpvar_1;
  highp vec3 n_2;
  lowp vec3 tmpvar_3;
  tmpvar_3 = ((texture2D (_CameraNormalsTexture, xlv_TEXCOORD0) * 2.0) - 1.0).xyz;
  n_2 = tmpvar_3;
  highp float tmpvar_4;
  tmpvar_4 = (1.0/(((_ZBufferParams.x * texture2D (_CameraDepthTexture, xlv_TEXCOORD0).x) + _ZBufferParams.y)));
  highp mat3 tmpvar_5;
  tmpvar_5[0] = _WorldToCamera[0].xyz;
  tmpvar_5[1] = _WorldToCamera[1].xyz;
  tmpvar_5[2] = _WorldToCamera[2].xyz;
  n_2 = (tmpvar_5 * n_2);
  n_2.z = -(n_2.z);
  highp vec4 tmpvar_6;
  if ((tmpvar_4 < 0.9999846)) {
    highp vec4 enc_7;
    highp vec2 enc_8;
    enc_8 = (n_2.xy / (n_2.z + 1.0));
    enc_8 = (enc_8 / 1.7777);
    enc_8 = ((enc_8 * 0.5) + 0.5);
    enc_7.xy = enc_8;
    highp vec2 enc_9;
    highp vec2 tmpvar_10;
    tmpvar_10 = fract((vec2(1.0, 255.0) * tmpvar_4));
    enc_9.y = tmpvar_10.y;
    enc_9.x = (tmpvar_10.x - (tmpvar_10.y * 0.003921569));
    enc_7.zw = enc_9;
    tmpvar_6 = enc_7;
  } else {
    tmpvar_6 = vec4(0.5, 0.5, 1.0, 1.0);
  };
  tmpvar_1 = tmpvar_6;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "texcoord" TexCoord0
ConstBuffer "$Globals" 176
Vector 96 [_CameraNormalsTexture_ST]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "$Globals" 0
BindCB  "UnityPerDraw" 1
"vs_4_0_level_9_1
root12:aaacaaaa
eefiecedbnncplheoiflngccngahdmicfmebkclcabaaaaaapiacaaaaaeaaaaaa
daaaaaaabiabaaaaemacaaaakaacaaaaebgpgodjoaaaaaaaoaaaaaaaaaacpopp
kaaaaaaaeaaaaaaaacaaceaaaaaadmaaaaaadmaaaaaaceaaabaadmaaaaaaagaa
abaaabaaaaaaaaaaabaaaaaaaeaaacaaaaaaaaaaaaaaaaaaaaacpoppbpaaaaac
afaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjaaeaaaaaeaaaaadoaabaaoeja
abaaoekaabaaookaafaaaaadaaaaapiaaaaaffjaadaaoekaaeaaaaaeaaaaapia
acaaoekaaaaaaajaaaaaoeiaaeaaaaaeaaaaapiaaeaaoekaaaaakkjaaaaaoeia
aeaaaaaeaaaaapiaafaaoekaaaaappjaaaaaoeiaaeaaaaaeaaaaadmaaaaappia
aaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeiappppaaaafdeieefccmabaaaa
eaaaabaaelaaaaaafjaaaaaeegiocaaaaaaaaaaaahaaaaaafjaaaaaeegiocaaa
abaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
ghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaaddccabaaaabaaaaaagiaaaaac
abaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaabaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaa
egiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaal
dccabaaaabaaaaaaegbabaaaabaaaaaaegiacaaaaaaaaaaaagaaaaaaogikcaaa
aaaaaaaaagaaaaaadoaaaaabejfdeheoemaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaaebaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafaepfdejfeejepeoaafeeffiedepepfceeaaklkl
epfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaa
aaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadamaaaa
fdfgfpfaepfdejfeejepeoaafeeffiedepepfceeaaklklkl"
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
uniform 	vec4 _CameraNormalsTexture_ST;
uniform 	mat4 _WorldToCamera;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
out highp vec2 vs_TEXCOORD0;
highp vec4 t0;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _CameraNormalsTexture_ST.xy + _CameraNormalsTexture_ST.zw;
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
uniform 	vec4 _CameraNormalsTexture_ST;
uniform 	mat4 _WorldToCamera;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2D _CameraNormalsTexture;
in highp vec2 vs_TEXCOORD0;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
mediump vec3 t16_0;
lowp vec3 t10_0;
highp vec3 t1;
bool tb3;
highp float t4;
void main()
{
    t10_0.xyz = texture(_CameraNormalsTexture, vs_TEXCOORD0.xy).xyz;
    t16_0.xyz = t10_0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
    t1.xyz = t16_0.yyy * _WorldToCamera[1].xyz;
    t0.xyw = _WorldToCamera[0].xyz * t16_0.xxx + t1.xyz;
    t0.xyz = _WorldToCamera[2].xyz * t16_0.zzz + t0.xyw;
    t4 = (-t0.z) + 1.0;
    t0.xy = t0.xy / vec2(t4);
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t1.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t1.x = _ZBufferParams.x * t1.x + _ZBufferParams.y;
    t1.x = float(1.0) / t1.x;
    tb3 = t1.x<0.999984622;
    t1.xz = t1.xx * vec2(1.0, 255.0);
    t1.xz = fract(t1.xz);
    t0.z = (-t1.z) * 0.00392156886 + t1.x;
    t0.w = t1.z;
    t0 = (bool(tb3)) ? t0 : vec4(0.5, 0.5, 1.0, 1.0);
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
uniform 	vec4 _CameraNormalsTexture_ST;
uniform 	mat4 _WorldToCamera;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
out vec2 vs_TEXCOORD0;
vec4 t0;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy * _CameraNormalsTexture_ST.xy + _CameraNormalsTexture_ST.zw;
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
uniform 	vec4 _CameraNormalsTexture_ST;
uniform 	mat4 _WorldToCamera;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2D _CameraNormalsTexture;
in  vec2 vs_TEXCOORD0;
out vec4 SV_Target0;
vec4 t0;
mediump vec3 t16_0;
lowp vec4 t10_0;
vec3 t1;
lowp vec4 t10_1;
bool tb3;
float t4;
void main()
{
    t10_0 = texture(_CameraNormalsTexture, vs_TEXCOORD0.xy);
    t16_0.xyz = t10_0.xyz * vec3(2.0, 2.0, 2.0) + vec3(-1.0, -1.0, -1.0);
    t1.xyz = t16_0.yyy * _WorldToCamera[1].xyz;
    t0.xyw = _WorldToCamera[0].xyz * t16_0.xxx + t1.xyz;
    t0.xyz = _WorldToCamera[2].xyz * t16_0.zzz + t0.xyw;
    t4 = (-t0.z) + 1.0;
    t0.xy = t0.xy / vec2(t4);
    t0.xy = t0.xy * vec2(0.281262308, 0.281262308) + vec2(0.5, 0.5);
    t10_1 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t1.x = _ZBufferParams.x * t10_1.x + _ZBufferParams.y;
    t1.x = float(1.0) / t1.x;
    tb3 = t1.x<0.999984622;
    t1.xz = t1.xx * vec2(1.0, 255.0);
    t1.xz = fract(t1.xz);
    t0.z = (-t1.z) * 0.00392156886 + t1.x;
    t0.w = t1.z;
    SV_Target0 = (bool(tb3)) ? t0 : vec4(0.5, 0.5, 1.0, 1.0);
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
Matrix 0 [_WorldToCamera] 3
Vector 3 [_ZBufferParams]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
"ps_2_0
def c4, 2, -1, -0.999984622, 1
def c5, 0.281262308, 0.5, 255, 1
def c6, 0.00392156886, 0, 0, 0
def c7, 0.5, 0.5, 1, 1
dcl t0.xy
dcl_2d s0
dcl_2d s1
texld r0, t0, s1
texld r1, t0, s0
mad r0.xyz, r0, c4.x, c4.y
dp3 r0.w, c2, r0
add r0.w, -r0.w, c4.w
rcp r0.w, r0.w
dp3 r2.x, c0, r0
dp3 r2.y, c1, r0
mul r0.xy, r0.w, r2
mad_pp r0.xy, r0, c5.x, c5.y
mad r1.x, c3.x, r1.x, c3.y
rcp r1.x, r1.x
add r1.y, r1.x, c4.z
mul r1.zw, r1.x, c5
frc_pp r1.x, r1.z
frc r1.z, r1.w
mad_pp r0.z, r1.x, -c6.x, r1.z
mov_pp r0.w, r1.x
cmp_pp r0, r1.y, c7, r0
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
ConstBuffer "$Globals" 176
Matrix 112 [_WorldToCamera]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
"ps_4_0
root12:acacacaa
eefiecedbplbdgfcdoiemacjkpmibbmghgikgnmkabaaaaaamiadaaaaadaaaaaa
cmaaaaaaieaaaaaaliaaaaaaejfdeheofaaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaeeaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklklfdeieefcaiadaaaa
eaaaaaaamcaaaaaafjaaaaaeegiocaaaaaaaaaaaakaaaaaafjaaaaaeegiocaaa
abaaaaaaaiaaaaaafkaaaaadaagabaaaaaaaaaaafkaaaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaaddcbabaaaabaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacacaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaabaaaaaaeghobaaaabaaaaaaaagabaaa
abaaaaaadcaaaaaphcaabaaaaaaaaaaaegacbaaaaaaaaaaaaceaaaaaaaaaaaea
aaaaaaeaaaaaaaeaaaaaaaaaaceaaaaaaaaaialpaaaaialpaaaaialpaaaaaaaa
diaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaaaaaaaaaaaiaaaaaa
dcaaaaaklcaabaaaaaaaaaaaegiicaaaaaaaaaaaahaaaaaaagaabaaaaaaaaaaa
egaibaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaaegiccaaaaaaaaaaaajaaaaaa
kgakbaaaaaaaaaaaegadbaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaackaabaia
ebaaaaaaaaaaaaaaabeaaaaaaaaaiadpaoaaaaahdcaabaaaaaaaaaaaegaabaaa
aaaaaaaakgakbaaaaaaaaaaadcaaaaapdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
aceaaaaajnabjadojnabjadoaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadp
aaaaaaaaaaaaaaaaefaaaaajpcaabaaaabaaaaaaegbabaaaabaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaalbcaabaaaabaaaaaaakiacaaaabaaaaaa
ahaaaaaaakaabaaaabaaaaaabkiacaaaabaaaaaaahaaaaaaaoaaaaakbcaabaaa
abaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpakaabaaaabaaaaaa
dbaaaaahccaabaaaabaaaaaaakaabaaaabaaaaaaabeaaaaapopohpdpdiaaaaak
fcaabaaaabaaaaaaagaabaaaabaaaaaaaceaaaaaaaaaiadpaaaaaaaaaaaahped
aaaaaaaabkaaaaaffcaabaaaabaaaaaaagacbaaaabaaaaaadcaaaaakecaabaaa
aaaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaibiaiadlakaabaaaabaaaaaa
dgaaaaaficaabaaaaaaaaaaackaabaaaabaaaaaadhaaaaampccabaaaaaaaaaaa
fgafbaaaabaaaaaaegaobaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaiadp
aaaaiadpdoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_CameraNormalsTexture] 2D 1
ConstBuffer "$Globals" 176
Matrix 112 [_WorldToCamera]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
"ps_4_0_level_9_1
root12:acacacaa
eefiecedmfhmlncdfedglfeoglcjimhnmbfcencpabaaaaaaoiafaaaaaeaaaaaa
daaaaaaaemacaaaafmafaaaaleafaaaaebgpgodjbeacaaaabeacaaaaaaacpppp
naabaaaaeeaaaaaaacaacmaaaaaaeeaaaaaaeeaaacaaceaaaaaaeeaaaaaaaaaa
abababaaaaaaahaaadaaaaaaaaaaaaaaabaaahaaabaaadaaaaaaaaaaaaacpppp
fbaaaaafaeaaapkaaaaaaaeaaaaaialppopohplpaaaaiadpfbaaaaafafaaapka
jnabjadoaaaaaadpaaaahpedaaaaiadpfbaaaaafagaaapkaibiaiadlaaaaaaaa
aaaaaaaaaaaaaaaafbaaaaafahaaapkaaaaaaadpaaaaaadpaaaaiadpaaaaiadp
bpaaaaacaaaaaaiaaaaaadlabpaaaaacaaaaaajaaaaiapkabpaaaaacaaaaaaja
abaiapkaecaaaaadaaaaapiaaaaaoelaabaioekaecaaaaadabaaapiaaaaaoela
aaaioekaaeaaaaaeaaaaahiaaaaaoeiaaeaaaakaaeaaffkaafaaaaadabaaaoia
aaaaffiaabaablkaaeaaaaaeabaaaoiaaaaablkaaaaaaaiaabaaoeiaaeaaaaae
aaaaahiaacaaoekaaaaakkiaabaabliaacaaaaadaaaaaeiaaaaakkibaeaappka
agaaaaacaaaaaeiaaaaakkiaafaaaaadaaaaadiaaaaakkiaaaaaoeiaaeaaaaae
aaaacdiaaaaaoeiaafaaaakaafaaffkaaeaaaaaeabaaabiaadaaaakaabaaaaia
adaaffkaagaaaaacabaaabiaabaaaaiaacaaaaadabaaaciaabaaaaiaaeaakkka
afaaaaadabaaamiaabaaaaiaafaaoekabdaaaaacabaacbiaabaakkiabdaaaaac
abaaaeiaabaappiaaeaaaaaeaaaaceiaabaaaaiaagaaaakbabaakkiaabaaaaac
aaaaciiaabaaaaiafiaaaaaeaaaacpiaabaaffiaahaaoekaaaaaoeiaabaaaaac
aaaicpiaaaaaoeiappppaaaafdeieefcaiadaaaaeaaaaaaamcaaaaaafjaaaaae
egiocaaaaaaaaaaaakaaaaaafjaaaaaeegiocaaaabaaaaaaaiaaaaaafkaaaaad
aagabaaaaaaaaaaafkaaaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaa
ffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaaddcbabaaaabaaaaaa
gfaaaaadpccabaaaaaaaaaaagiaaaaacacaaaaaaefaaaaajpcaabaaaaaaaaaaa
egbabaaaabaaaaaaeghobaaaabaaaaaaaagabaaaabaaaaaadcaaaaaphcaabaaa
aaaaaaaaegacbaaaaaaaaaaaaceaaaaaaaaaaaeaaaaaaaeaaaaaaaeaaaaaaaaa
aceaaaaaaaaaialpaaaaialpaaaaialpaaaaaaaadiaaaaaihcaabaaaabaaaaaa
fgafbaaaaaaaaaaaegiccaaaaaaaaaaaaiaaaaaadcaaaaaklcaabaaaaaaaaaaa
egiicaaaaaaaaaaaahaaaaaaagaabaaaaaaaaaaaegaibaaaabaaaaaadcaaaaak
hcaabaaaaaaaaaaaegiccaaaaaaaaaaaajaaaaaakgakbaaaaaaaaaaaegadbaaa
aaaaaaaaaaaaaaaiecaabaaaaaaaaaaackaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadpaoaaaaahdcaabaaaaaaaaaaaegaabaaaaaaaaaaakgakbaaaaaaaaaaa
dcaaaaapdcaabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaajnabjadojnabjado
aaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaaefaaaaaj
pcaabaaaabaaaaaaegbabaaaabaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaa
dcaaaaalbcaabaaaabaaaaaaakiacaaaabaaaaaaahaaaaaaakaabaaaabaaaaaa
bkiacaaaabaaaaaaahaaaaaaaoaaaaakbcaabaaaabaaaaaaaceaaaaaaaaaiadp
aaaaiadpaaaaiadpaaaaiadpakaabaaaabaaaaaadbaaaaahccaabaaaabaaaaaa
akaabaaaabaaaaaaabeaaaaapopohpdpdiaaaaakfcaabaaaabaaaaaaagaabaaa
abaaaaaaaceaaaaaaaaaiadpaaaaaaaaaaaahpedaaaaaaaabkaaaaaffcaabaaa
abaaaaaaagacbaaaabaaaaaadcaaaaakecaabaaaaaaaaaaackaabaiaebaaaaaa
abaaaaaaabeaaaaaibiaiadlakaabaaaabaaaaaadgaaaaaficaabaaaaaaaaaaa
ckaabaaaabaaaaaadhaaaaampccabaaaaaaaaaaafgafbaaaabaaaaaaegaobaaa
aaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaiadpaaaaiadpdoaaaaabejfdeheo
faaaaaaaacaaaaaaaiaaaaaadiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaaeeaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklkl"
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
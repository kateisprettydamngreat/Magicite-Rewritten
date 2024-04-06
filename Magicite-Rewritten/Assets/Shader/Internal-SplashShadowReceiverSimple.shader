//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/InternalSplashShadowReceiverSimple" {
SubShader { 
 Pass {
  Cull Off
  GpuProgramID 38741
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX
uniform mat4 unity_World2Shadow[4];

varying vec3 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
varying vec2 xlv_TEXCOORD2;
void main ()
{
  vec4 tmpvar_1;
  tmpvar_1.w = 1.0;
  tmpvar_1.xyz = gl_Vertex.xyz;
  vec4 tmpvar_2;
  tmpvar_2 = (unity_World2Shadow[0] * tmpvar_1);
  gl_Position = (gl_ModelViewProjectionMatrix * gl_Vertex);
  xlv_TEXCOORD0 = gl_Normal;
  xlv_TEXCOORD1 = tmpvar_1;
  xlv_TEXCOORD2 = (((tmpvar_2.xy / tmpvar_2.w) * 0.5) + 0.5);
}


#endif
#ifdef FRAGMENT
uniform vec3 unity_LightColor0;
uniform vec3 unity_LightColor1;
uniform mat4 unity_World2Shadow[4];
uniform sampler2D unity_SplashScreenShadowTex0;
uniform sampler2D unity_SplashScreenShadowTex1;
uniform vec3 unity_LightPosition0;
varying vec3 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
varying vec2 xlv_TEXCOORD2;
void main ()
{
  vec4 planeShadows_1;
  vec4 shadowSample1_2;
  vec4 shadowSample0_3;
  shadowSample0_3 = texture2D (unity_SplashScreenShadowTex0, xlv_TEXCOORD2);
  shadowSample1_2 = texture2D (unity_SplashScreenShadowTex1, xlv_TEXCOORD2);
  planeShadows_1 = vec4(0.0, 0.0, 0.0, 0.0);
  mat4 m_4;
  m_4 = unity_World2Shadow[1];
  vec4 v_5;
  v_5.x = m_4[0].x;
  v_5.y = m_4[1].x;
  v_5.z = m_4[2].x;
  v_5.w = m_4[3].x;
  float tmpvar_6;
  tmpvar_6 = dot (v_5, xlv_TEXCOORD1);
  if ((tmpvar_6 > 0.5)) {
    float tmpvar_7;
    tmpvar_7 = clamp ((1.0 - (tmpvar_6 * 0.25)), 0.0, 1.0);
    vec4 tmpvar_8;
    tmpvar_8.yzw = vec3(0.0, 0.0, 0.0);
    tmpvar_8.x = ((shadowSample0_3 * tmpvar_7) + (shadowSample1_2 * (1.0 - tmpvar_7))).x;
    planeShadows_1 = tmpvar_8;
  };
  mat4 m_9;
  m_9 = unity_World2Shadow[1];
  vec4 v_10;
  v_10.x = m_9[0].y;
  v_10.y = m_9[1].y;
  v_10.z = m_9[2].y;
  v_10.w = m_9[3].y;
  float tmpvar_11;
  tmpvar_11 = dot (v_10, xlv_TEXCOORD1);
  if ((tmpvar_11 > 0.5)) {
    float tmpvar_12;
    tmpvar_12 = clamp ((1.0 - (tmpvar_11 * 0.25)), 0.0, 1.0);
    vec4 tmpvar_13;
    tmpvar_13.xzw = planeShadows_1.xzw;
    tmpvar_13.y = ((shadowSample0_3 * tmpvar_12) + (shadowSample1_2 * (1.0 - tmpvar_12))).y;
    planeShadows_1 = tmpvar_13;
  };
  mat4 m_14;
  m_14 = unity_World2Shadow[1];
  vec4 v_15;
  v_15.x = m_14[0].z;
  v_15.y = m_14[1].z;
  v_15.z = m_14[2].z;
  v_15.w = m_14[3].z;
  float tmpvar_16;
  tmpvar_16 = dot (v_15, xlv_TEXCOORD1);
  if ((tmpvar_16 > 0.5)) {
    float tmpvar_17;
    tmpvar_17 = clamp ((1.0 - (tmpvar_16 * 0.25)), 0.0, 1.0);
    vec4 tmpvar_18;
    tmpvar_18.xyw = planeShadows_1.xyw;
    tmpvar_18.z = ((shadowSample0_3 * tmpvar_17) + (shadowSample1_2 * (1.0 - tmpvar_17))).z;
    planeShadows_1 = tmpvar_18;
  };
  mat4 m_19;
  m_19 = unity_World2Shadow[1];
  vec4 v_20;
  v_20.x = m_19[0].w;
  v_20.y = m_19[1].w;
  v_20.z = m_19[2].w;
  v_20.w = m_19[3].w;
  float tmpvar_21;
  tmpvar_21 = dot (v_20, xlv_TEXCOORD1);
  if ((tmpvar_21 > 0.5)) {
    float tmpvar_22;
    tmpvar_22 = clamp ((1.0 - (tmpvar_21 * 0.25)), 0.0, 1.0);
    vec4 tmpvar_23;
    tmpvar_23.xyz = planeShadows_1.xyz;
    tmpvar_23.w = ((shadowSample0_3 * tmpvar_22) + (shadowSample1_2 * (1.0 - tmpvar_22))).w;
    planeShadows_1 = tmpvar_23;
  };
  vec4 tmpvar_24;
  tmpvar_24.w = 1.0;
  tmpvar_24.xyz = mix (unity_LightColor1, unity_LightColor0, vec3((pow (
    clamp (dot (xlv_TEXCOORD0, normalize((unity_LightPosition0 - xlv_TEXCOORD1.xyz))), 0.0, 1.0)
  , 3.0) * (1.0 - 
    max (max (planeShadows_1.x, planeShadows_1.y), max (planeShadows_1.z, planeShadows_1.w))
  ))));
  gl_FragData[0] = tmpvar_24;
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "normal" Normal
Matrix 4 [glstate_matrix_mvp]
Matrix 0 [unity_World2Shadow0]
"vs_2_0
def c8, 1, 0, 0.5, 0
dcl_position v0
dcl_normal v1
dp4 oPos.x, c4, v0
dp4 oPos.y, c5, v0
dp4 oPos.z, c6, v0
dp4 oPos.w, c7, v0
mul r0, v0.xyzx, c8.xxxy
add r1, r0, c8.yyyx
add oT1, r0, c8.yyyx
dp4 r0.x, c3, r1
rcp r0.x, r0.x
dp4 r2.x, c0, r1
dp4 r2.y, c1, r1
mul r0.xy, r0.x, r2
mad oT2.xy, r0, c8.z, c8.z
mov oT0.xyz, v1

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "normal" Normal
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityShadows" 0
BindCB  "UnityPerDraw" 1
"vs_4_0
root12:aaacaaaa
eefiecedldelgpnhcciogfcoehlmckkebhghbdmlabaaaaaaeiadaaaaadaaaaaa
cmaaaaaahmaaaaaaaeabaaaaejfdeheoeiaaaaaaacaaaaaaaiaaaaaadiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaaebaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaafaepfdejfeejepeoaaeoepfcenebemaaepfdeheo
iaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaaheaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaaheaaaaaaacaaaaaaaaaaaaaa
adaaaaaaadaaaaaaadamaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklfdeieefcdmacaaaaeaaaabaaipaaaaaafjaaaaaeegiocaaaaaaaaaaa
amaaaaaafjaaaaaeegiocaaaabaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaa
fpaaaaadhcbabaaaabaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaad
hccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagfaaaaaddccabaaaadaaaaaa
giaaaaacabaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaa
abaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaaaaaaaaa
agbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
abaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaa
aaaaaaaaegiocaaaabaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaa
dgaaaaafhccabaaaabaaaaaaegbcbaaaabaaaaaadgaaaaafhccabaaaacaaaaaa
egbcbaaaaaaaaaaadgaaaaaficcabaaaacaaaaaaabeaaaaaaaaaiadpdiaaaaai
hcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegidcaaaaaaaaaaaajaaaaaadcaaaaak
hcaabaaaaaaaaaaaegidcaaaaaaaaaaaaiaaaaaaagbabaaaaaaaaaaaegacbaaa
aaaaaaaadcaaaaakhcaabaaaaaaaaaaaegidcaaaaaaaaaaaakaaaaaakgbkbaaa
aaaaaaaaegacbaaaaaaaaaaaaaaaaaaihcaabaaaaaaaaaaaegacbaaaaaaaaaaa
egidcaaaaaaaaaaaalaaaaaaaoaaaaahdcaabaaaaaaaaaaaegaabaaaaaaaaaaa
kgakbaaaaaaaaaaadcaaaaapdccabaaaadaaaaaaegaabaaaaaaaaaaaaceaaaaa
aaaaaadpaaaaaadpaaaaaaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
uniform highp mat4 unity_World2Shadow[4];
uniform highp mat4 glstate_matrix_mvp;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
varying highp vec2 xlv_TEXCOORD2;
void main ()
{
  highp vec4 tmpvar_1;
  tmpvar_1.w = 1.0;
  tmpvar_1.xyz = _glesVertex.xyz;
  highp vec4 tmpvar_2;
  tmpvar_2 = (unity_World2Shadow[0] * tmpvar_1);
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = _glesNormal;
  xlv_TEXCOORD1 = tmpvar_1;
  xlv_TEXCOORD2 = (((tmpvar_2.xy / tmpvar_2.w) * 0.5) + 0.5);
}


#endif
#ifdef FRAGMENT
uniform mediump vec3 unity_LightColor0;
uniform mediump vec3 unity_LightColor1;
uniform highp mat4 unity_World2Shadow[4];
uniform sampler2D unity_SplashScreenShadowTex0;
uniform sampler2D unity_SplashScreenShadowTex1;
uniform highp vec3 unity_LightPosition0;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
varying highp vec2 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  lowp float shadowedIntensity_2;
  highp vec4 planeShadows_3;
  lowp vec4 shadowSample1_4;
  lowp vec4 shadowSample0_5;
  shadowSample0_5 = texture2D (unity_SplashScreenShadowTex0, xlv_TEXCOORD2);
  shadowSample1_4 = texture2D (unity_SplashScreenShadowTex1, xlv_TEXCOORD2);
  planeShadows_3 = vec4(0.0, 0.0, 0.0, 0.0);
  highp mat4 m_6;
  m_6 = unity_World2Shadow[1];
  highp vec4 v_7;
  v_7.x = m_6[0].x;
  v_7.y = m_6[1].x;
  v_7.z = m_6[2].x;
  v_7.w = m_6[3].x;
  highp float tmpvar_8;
  tmpvar_8 = dot (v_7, xlv_TEXCOORD1);
  if ((tmpvar_8 > 0.5)) {
    lowp vec4 weightedShadowSample_9;
    highp float tmpvar_10;
    tmpvar_10 = clamp ((1.0 - (tmpvar_8 * 0.25)), 0.0, 1.0);
    highp vec4 tmpvar_11;
    tmpvar_11 = ((shadowSample0_5 * tmpvar_10) + (shadowSample1_4 * (1.0 - tmpvar_10)));
    weightedShadowSample_9 = tmpvar_11;
    lowp vec4 tmpvar_12;
    tmpvar_12.yzw = vec3(0.0, 0.0, 0.0);
    tmpvar_12.x = weightedShadowSample_9.x;
    planeShadows_3 = tmpvar_12;
  };
  highp mat4 m_13;
  m_13 = unity_World2Shadow[1];
  highp vec4 v_14;
  v_14.x = m_13[0].y;
  v_14.y = m_13[1].y;
  v_14.z = m_13[2].y;
  v_14.w = m_13[3].y;
  highp float tmpvar_15;
  tmpvar_15 = dot (v_14, xlv_TEXCOORD1);
  if ((tmpvar_15 > 0.5)) {
    lowp vec4 weightedShadowSample_16;
    highp float tmpvar_17;
    tmpvar_17 = clamp ((1.0 - (tmpvar_15 * 0.25)), 0.0, 1.0);
    highp vec4 tmpvar_18;
    tmpvar_18 = ((shadowSample0_5 * tmpvar_17) + (shadowSample1_4 * (1.0 - tmpvar_17)));
    weightedShadowSample_16 = tmpvar_18;
    highp vec4 tmpvar_19;
    tmpvar_19.xzw = planeShadows_3.xzw;
    tmpvar_19.y = weightedShadowSample_16.y;
    planeShadows_3 = tmpvar_19;
  };
  highp mat4 m_20;
  m_20 = unity_World2Shadow[1];
  highp vec4 v_21;
  v_21.x = m_20[0].z;
  v_21.y = m_20[1].z;
  v_21.z = m_20[2].z;
  v_21.w = m_20[3].z;
  highp float tmpvar_22;
  tmpvar_22 = dot (v_21, xlv_TEXCOORD1);
  if ((tmpvar_22 > 0.5)) {
    lowp vec4 weightedShadowSample_23;
    highp float tmpvar_24;
    tmpvar_24 = clamp ((1.0 - (tmpvar_22 * 0.25)), 0.0, 1.0);
    highp vec4 tmpvar_25;
    tmpvar_25 = ((shadowSample0_5 * tmpvar_24) + (shadowSample1_4 * (1.0 - tmpvar_24)));
    weightedShadowSample_23 = tmpvar_25;
    highp vec4 tmpvar_26;
    tmpvar_26.xyw = planeShadows_3.xyw;
    tmpvar_26.z = weightedShadowSample_23.z;
    planeShadows_3 = tmpvar_26;
  };
  highp mat4 m_27;
  m_27 = unity_World2Shadow[1];
  highp vec4 v_28;
  v_28.x = m_27[0].w;
  v_28.y = m_27[1].w;
  v_28.z = m_27[2].w;
  v_28.w = m_27[3].w;
  highp float tmpvar_29;
  tmpvar_29 = dot (v_28, xlv_TEXCOORD1);
  if ((tmpvar_29 > 0.5)) {
    lowp vec4 weightedShadowSample_30;
    highp float tmpvar_31;
    tmpvar_31 = clamp ((1.0 - (tmpvar_29 * 0.25)), 0.0, 1.0);
    highp vec4 tmpvar_32;
    tmpvar_32 = ((shadowSample0_5 * tmpvar_31) + (shadowSample1_4 * (1.0 - tmpvar_31)));
    weightedShadowSample_30 = tmpvar_32;
    highp vec4 tmpvar_33;
    tmpvar_33.xyz = planeShadows_3.xyz;
    tmpvar_33.w = weightedShadowSample_30.w;
    planeShadows_3 = tmpvar_33;
  };
  highp float tmpvar_34;
  tmpvar_34 = (pow (clamp (
    dot (xlv_TEXCOORD0, normalize((unity_LightPosition0 - xlv_TEXCOORD1.xyz)))
  , 0.0, 1.0), 3.0) * (1.0 - max (
    max (planeShadows_3.x, planeShadows_3.y)
  , 
    max (planeShadows_3.z, planeShadows_3.w)
  )));
  shadowedIntensity_2 = tmpvar_34;
  mediump vec4 tmpvar_35;
  tmpvar_35.w = 1.0;
  tmpvar_35.xyz = mix (unity_LightColor1, unity_LightColor0, vec3(shadowedIntensity_2));
  tmpvar_1 = tmpvar_35;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Bind "vertex" Vertex
Bind "normal" Normal
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityShadows" 0
BindCB  "UnityPerDraw" 1
"vs_4_0_level_9_1
root12:aaacaaaa
eefiecedpkalbeghennpohpifhlcdmboeipgckpdabaaaaaanaaeaaaaaeaaaaaa
daaaaaaaleabaaaapiadaaaaeiaeaaaaebgpgodjhmabaaaahmabaaaaaaacpopp
dmabaaaaeaaaaaaaacaaceaaaaaadmaaaaaadmaaaaaaceaaabaadmaaaaaaaiaa
aeaaabaaaaaaaaaaabaaaaaaaeaaafaaaaaaaaaaaaaaaaaaaaacpoppfbaaaaaf
ajaaapkaaaaaaadpaaaaiadpaaaaaaaaaaaaaaaabpaaaaacafaaaaiaaaaaapja
bpaaaaacafaaabiaabaaapjaafaaaaadaaaaahiaaaaaffjaacaapekaaeaaaaae
aaaaahiaabaapekaaaaaaajaaaaaoeiaaeaaaaaeaaaaahiaadaapekaaaaakkja
aaaaoeiaacaaaaadaaaaahiaaaaaoeiaaeaapekaagaaaaacaaaaaeiaaaaakkia
afaaaaadaaaaadiaaaaakkiaaaaaoeiaaeaaaaaeacaaadoaaaaaoeiaajaaaaka
ajaaaakaafaaaaadaaaaapiaaaaaffjaagaaoekaaeaaaaaeaaaaapiaafaaoeka
aaaaaajaaaaaoeiaaeaaaaaeaaaaapiaahaaoekaaaaakkjaaaaaoeiaaeaaaaae
aaaaapiaaiaaoekaaaaappjaaaaaoeiaaeaaaaaeaaaaadmaaaaappiaaaaaoeka
aaaaoeiaabaaaaacaaaaammaaaaaoeiaabaaaaacaaaaahoaabaaoejaaeaaaaae
abaaapoaaaaacejaajaajfkaajaagkkappppaaaafdeieefcdmacaaaaeaaaabaa
ipaaaaaafjaaaaaeegiocaaaaaaaaaaaamaaaaaafjaaaaaeegiocaaaabaaaaaa
aeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaaghaaaaae
pccabaaaaaaaaaaaabaaaaaagfaaaaadhccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaagfaaaaaddccabaaaadaaaaaagiaaaaacabaaaaaadiaaaaaipcaabaaa
aaaaaaaafgbfbaaaaaaaaaaaegiocaaaabaaaaaaabaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaabaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaabaaaaaaacaaaaaakgbkbaaaaaaaaaaa
egaobaaaaaaaaaaadcaaaaakpccabaaaaaaaaaaaegiocaaaabaaaaaaadaaaaaa
pgbpbaaaaaaaaaaaegaobaaaaaaaaaaadgaaaaafhccabaaaabaaaaaaegbcbaaa
abaaaaaadgaaaaafhccabaaaacaaaaaaegbcbaaaaaaaaaaadgaaaaaficcabaaa
acaaaaaaabeaaaaaaaaaiadpdiaaaaaihcaabaaaaaaaaaaafgbfbaaaaaaaaaaa
egidcaaaaaaaaaaaajaaaaaadcaaaaakhcaabaaaaaaaaaaaegidcaaaaaaaaaaa
aiaaaaaaagbabaaaaaaaaaaaegacbaaaaaaaaaaadcaaaaakhcaabaaaaaaaaaaa
egidcaaaaaaaaaaaakaaaaaakgbkbaaaaaaaaaaaegacbaaaaaaaaaaaaaaaaaai
hcaabaaaaaaaaaaaegacbaaaaaaaaaaaegidcaaaaaaaaaaaalaaaaaaaoaaaaah
dcaabaaaaaaaaaaaegaabaaaaaaaaaaakgakbaaaaaaaaaaadcaaaaapdccabaaa
adaaaaaaegaabaaaaaaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaa
aceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaadoaaaaabejfdeheoeiaaaaaa
acaaaaaaaiaaaaaadiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaa
ebaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaafaepfdejfeejepeo
aaeoepfcenebemaaepfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaa
abaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
abaaaaaaahaiaaaaheaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaa
heaaaaaaacaaaaaaaaaaaaaaadaaaaaaadaaaaaaadamaaaafdfgfpfaepfdejfe
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
uniform 	vec3 unity_LightPosition0;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
out highp vec3 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
out highp vec2 vs_TEXCOORD2;
highp vec4 t0;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xyz = in_NORMAL0.xyz;
    vs_TEXCOORD1.xyz = in_POSITION0.xyz;
    vs_TEXCOORD1.w = 1.0;
    t0.xyz = in_POSITION0.yyy * unity_World2Shadow[0][1].xyw;
    t0.xyz = unity_World2Shadow[0][0].xyw * in_POSITION0.xxx + t0.xyz;
    t0.xyz = unity_World2Shadow[0][2].xyw * in_POSITION0.zzz + t0.xyz;
    t0.xyz = t0.xyz + unity_World2Shadow[0][3].xyw;
    t0.xy = t0.xy / t0.zz;
    vs_TEXCOORD2.xy = t0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
uniform 	vec3 unity_LightPosition0;
uniform lowp sampler2D unity_SplashScreenShadowTex0;
uniform lowp sampler2D unity_SplashScreenShadowTex1;
in highp vec3 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
in highp vec2 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp float t1;
lowp vec4 t10_1;
lowp vec4 t10_2;
highp vec4 t3;
mediump vec3 t16_4;
highp vec3 t5;
bool tb5;
highp float t10;
bool tb10;
highp float t15;
void main()
{
    t0.x = unity_World2Shadow[1][0].x;
    t0.y = unity_World2Shadow[1][1].x;
    t0.z = unity_World2Shadow[1][2].x;
    t0.w = unity_World2Shadow[1][3].x;
    t0.x = dot(t0, vs_TEXCOORD1);
    tb5 = 0.5<t0.x;
    t0.x = (-t0.x) * 0.25 + 1.0;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t10 = (-t0.x) + 1.0;
    t10_1 = texture(unity_SplashScreenShadowTex1, vs_TEXCOORD2.xy);
    t10 = t10 * t10_1.x;
    t10_2 = texture(unity_SplashScreenShadowTex0, vs_TEXCOORD2.xy);
    t0.x = t10_2.x * t0.x + t10;
    t0.x = tb5 ? t0.x : float(0.0);
    t3.x = unity_World2Shadow[1][0].y;
    t3.y = unity_World2Shadow[1][1].y;
    t3.z = unity_World2Shadow[1][2].y;
    t3.w = unity_World2Shadow[1][3].y;
    t5.x = dot(t3, vs_TEXCOORD1);
    tb10 = 0.5<t5.x;
    t5.x = (-t5.x) * 0.25 + 1.0;
    t5.x = clamp(t5.x, 0.0, 1.0);
    t15 = (-t5.x) + 1.0;
    t15 = t15 * t10_1.y;
    t5.x = t10_2.y * t5.x + t15;
    t5.x = tb10 ? t5.x : float(0.0);
    t0.x = max(t5.x, t0.x);
    t3.x = unity_World2Shadow[1][0].z;
    t3.y = unity_World2Shadow[1][1].z;
    t3.z = unity_World2Shadow[1][2].z;
    t3.w = unity_World2Shadow[1][3].z;
    t5.x = dot(t3, vs_TEXCOORD1);
    t10 = (-t5.x) * 0.25 + 1.0;
    t10 = clamp(t10, 0.0, 1.0);
    tb5 = 0.5<t5.x;
    t15 = (-t10) + 1.0;
    t15 = t15 * t10_1.z;
    t10 = t10_2.z * t10 + t15;
    t5.x = tb5 ? t10 : float(0.0);
    t3.x = unity_World2Shadow[1][0].w;
    t3.y = unity_World2Shadow[1][1].w;
    t3.z = unity_World2Shadow[1][2].w;
    t3.w = unity_World2Shadow[1][3].w;
    t10 = dot(t3, vs_TEXCOORD1);
    t15 = (-t10) * 0.25 + 1.0;
    t15 = clamp(t15, 0.0, 1.0);
    tb10 = 0.5<t10;
    t1 = (-t15) + 1.0;
    t1 = t1 * t10_1.w;
    t15 = t10_2.w * t15 + t1;
    t10 = tb10 ? t15 : float(0.0);
    t5.x = max(t10, t5.x);
    t0.x = max(t5.x, t0.x);
    t0.x = (-t0.x) + 1.0;
    t5.xyz = (-vs_TEXCOORD1.xyz) + unity_LightPosition0.xyzx.xyz;
    t1 = dot(t5.xyz, t5.xyz);
    t1 = inversesqrt(t1);
    t5.xyz = t5.xyz * vec3(t1);
    t5.x = dot(vs_TEXCOORD0.xyz, t5.xyz);
    t5.x = clamp(t5.x, 0.0, 1.0);
    t10 = t5.x * t5.x;
    t5.x = t10 * t5.x;
    t0.x = t0.x * t5.x;
    t16_4.xyz = unity_LightColor0.xyzx.xyz + (-unity_LightColor1.xyzx.xyz);
    t16_4.xyz = t0.xxx * t16_4.xyz + unity_LightColor1.xyzx.xyz;
    SV_Target0.xyz = t16_4.xyz;
    SV_Target0.w = 1.0;
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
uniform 	vec3 unity_LightPosition0;
in  vec4 in_POSITION0;
in  vec3 in_NORMAL0;
out vec3 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
out vec2 vs_TEXCOORD2;
vec4 t0;
void main()
{
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    gl_Position = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    vs_TEXCOORD0.xyz = in_NORMAL0.xyz;
    vs_TEXCOORD1.xyz = in_POSITION0.xyz;
    vs_TEXCOORD1.w = 1.0;
    t0.xyz = in_POSITION0.yyy * unity_World2Shadow[0][1].xyw;
    t0.xyz = unity_World2Shadow[0][0].xyw * in_POSITION0.xxx + t0.xyz;
    t0.xyz = unity_World2Shadow[0][2].xyw * in_POSITION0.zzz + t0.xyz;
    t0.xyz = t0.xyz + unity_World2Shadow[0][3].xyw;
    t0.xy = t0.xy / t0.zz;
    vs_TEXCOORD2.xy = t0.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
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
uniform 	vec3 unity_LightPosition0;
uniform  sampler2D unity_SplashScreenShadowTex0;
uniform  sampler2D unity_SplashScreenShadowTex1;
in  vec3 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
in  vec2 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
float t1;
lowp vec4 t10_1;
lowp vec4 t10_2;
vec4 t3;
vec3 t4;
bool tb4;
float t8;
bool tb8;
float t12;
void main()
{
    t0.x = unity_World2Shadow[1][0].x;
    t0.y = unity_World2Shadow[1][1].x;
    t0.z = unity_World2Shadow[1][2].x;
    t0.w = unity_World2Shadow[1][3].x;
    t0.x = dot(t0, vs_TEXCOORD1);
    tb4 = 0.5<t0.x;
    t0.x = (-t0.x) * 0.25 + 1.0;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t8 = (-t0.x) + 1.0;
    t10_1 = texture(unity_SplashScreenShadowTex1, vs_TEXCOORD2.xy);
    t8 = t8 * t10_1.x;
    t10_2 = texture(unity_SplashScreenShadowTex0, vs_TEXCOORD2.xy);
    t0.x = t10_2.x * t0.x + t8;
    t0.x = tb4 ? t0.x : float(0.0);
    t3.x = unity_World2Shadow[1][0].y;
    t3.y = unity_World2Shadow[1][1].y;
    t3.z = unity_World2Shadow[1][2].y;
    t3.w = unity_World2Shadow[1][3].y;
    t4.x = dot(t3, vs_TEXCOORD1);
    tb8 = 0.5<t4.x;
    t4.x = (-t4.x) * 0.25 + 1.0;
    t4.x = clamp(t4.x, 0.0, 1.0);
    t12 = (-t4.x) + 1.0;
    t12 = t12 * t10_1.y;
    t4.x = t10_2.y * t4.x + t12;
    t4.x = tb8 ? t4.x : float(0.0);
    t0.x = max(t4.x, t0.x);
    t3.x = unity_World2Shadow[1][0].z;
    t3.y = unity_World2Shadow[1][1].z;
    t3.z = unity_World2Shadow[1][2].z;
    t3.w = unity_World2Shadow[1][3].z;
    t4.x = dot(t3, vs_TEXCOORD1);
    t8 = (-t4.x) * 0.25 + 1.0;
    t8 = clamp(t8, 0.0, 1.0);
    tb4 = 0.5<t4.x;
    t12 = (-t8) + 1.0;
    t12 = t12 * t10_1.z;
    t8 = t10_2.z * t8 + t12;
    t4.x = tb4 ? t8 : float(0.0);
    t3.x = unity_World2Shadow[1][0].w;
    t3.y = unity_World2Shadow[1][1].w;
    t3.z = unity_World2Shadow[1][2].w;
    t3.w = unity_World2Shadow[1][3].w;
    t8 = dot(t3, vs_TEXCOORD1);
    t12 = (-t8) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    tb8 = 0.5<t8;
    t1 = (-t12) + 1.0;
    t1 = t1 * t10_1.w;
    t12 = t10_2.w * t12 + t1;
    t8 = tb8 ? t12 : float(0.0);
    t4.x = max(t8, t4.x);
    t0.x = max(t4.x, t0.x);
    t0.x = (-t0.x) + 1.0;
    t4.xyz = (-vs_TEXCOORD1.xyz) + unity_LightPosition0.xyzx.xyz;
    t1 = dot(t4.xyz, t4.xyz);
    t1 = inversesqrt(t1);
    t4.xyz = t4.xyz * vec3(t1);
    t4.x = dot(vs_TEXCOORD0.xyz, t4.xyz);
    t4.x = clamp(t4.x, 0.0, 1.0);
    t8 = t4.x * t4.x;
    t4.x = t8 * t4.x;
    t0.x = t0.x * t4.x;
    t4.xyz = unity_LightColor0.xyzx.xyz + (-unity_LightColor1.xyzx.xyz);
    SV_Target0.xyz = t0.xxx * t4.xyz + unity_LightColor1.xyzx.xyz;
    SV_Target0.w = 1.0;
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
Matrix 0 [unity_World2Shadow0]
Matrix 4 [unity_World2Shadow1]
Vector 8 [unity_LightColor0]
Vector 9 [unity_LightColor1]
Vector 10 [unity_LightPosition0]
SetTexture 0 [unity_SplashScreenShadowTex0] 2D 0
SetTexture 1 [unity_SplashScreenShadowTex1] 2D 1
"ps_2_0
def c11, 0.5, 0.25, 1, 0
dcl t0.xyz
dcl t1
dcl t2.xy
dcl_2d s0
dcl_2d s1
dp4 r0.w, c4, t1
add r0.x, -r0.w, c11.x
mad_sat r0.y, r0.w, -c11.y, c11.z
texld_pp r1, t2, s0
texld_pp r2, t2, s1
lrp r3.w, r0.y, r1.x, r2.x
cmp r0.x, r0.x, c11.w, r3.w
dp4 r0.y, c5, t1
add r0.z, -r0.y, c11.x
mad_sat r0.y, r0.y, -c11.y, c11.z
lrp r3.x, r0.y, r1.y, r2.y
cmp r0.y, r0.z, c11.w, r3.x
max r1.x, r0.x, r0.y
dp4 r0.x, c6, t1
mad_sat r0.y, r0.x, -c11.y, c11.z
add r0.x, -r0.x, c11.x
lrp r3.x, r0.y, r1.z, r2.z
cmp r0.x, r0.x, c11.w, r3.x
dp4 r0.y, c7, t1
mad_sat r0.z, r0.y, -c11.y, c11.z
add r0.y, -r0.y, c11.x
lrp r3.x, r0.z, r1.w, r2.w
cmp r0.y, r0.y, c11.w, r3.x
max r1.y, r0.x, r0.y
max r0.x, r1.x, r1.y
add r0.x, -r0.x, c11.z
add r1.xyz, -t1, c10
nrm r2.xyz, r1
dp3_sat r0.y, t0, r2
mul r0.z, r0.y, r0.y
mul r0.y, r0.z, r0.y
mul_pp r0.x, r0.x, r0.y
mov r1.xyz, c9
add_pp r0.yzw, -r1.wzyx, c8.wzyx
mad_pp r0.xyz, r0.x, r0.wzyx, c9
mov r0.w, c11.z
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
SetTexture 0 [unity_SplashScreenShadowTex0] 2D 0
SetTexture 1 [unity_SplashScreenShadowTex1] 2D 1
ConstBuffer "$Globals" 16
Vector 0 [unity_LightPosition0] 3
ConstBuffer "UnityLightingOld" 64
Vector 0 [unity_LightColor0] 3
Vector 16 [unity_LightColor1] 3
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
BindCB  "$Globals" 0
BindCB  "UnityLightingOld" 1
BindCB  "UnityShadows" 2
"ps_4_0
root12:acadacaa
eefiecedphkdfclgpgjaakelldbgpkhbfcgendmbabaaaaaaimaiaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaaheaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaaheaaaaaaacaaaaaaaaaaaaaaadaaaaaaadaaaaaaadadaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcjmahaaaaeaaaaaaaohabaaaafjaaaaaeegiocaaa
aaaaaaaaabaaaaaafjaaaaaeegiocaaaabaaaaaaacaaaaaafjaaaaaeegiocaaa
acaaaaaabaaaaaaafkaaaaadaagabaaaaaaaaaaafkaaaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagcbaaaaddcbabaaa
adaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacaeaaaaaadgaaaaagbcaabaaa
aaaaaaaaakiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaaaaaaaaaaakiacaaa
acaaaaaaanaaaaaadgaaaaagecaabaaaaaaaaaaaakiacaaaacaaaaaaaoaaaaaa
dgaaaaagicaabaaaaaaaaaaaakiacaaaacaaaaaaapaaaaaabbaaaaahbcaabaaa
aaaaaaaaegaobaaaaaaaaaaaegbobaaaacaaaaaadbaaaaahccaabaaaaaaaaaaa
abeaaaaaaaaaaadpakaabaaaaaaaaaaadccaaaakbcaabaaaaaaaaaaaakaabaia
ebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpaaaaaaaiecaabaaa
aaaaaaaaakaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadpefaaaaajpcaabaaa
abaaaaaaegbabaaaadaaaaaaeghobaaaabaaaaaaaagabaaaabaaaaaadiaaaaah
ecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaaefaaaaajpcaabaaa
acaaaaaaegbabaaaadaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaaj
bcaabaaaaaaaaaaaakaabaaaacaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaa
abaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaag
bcaabaaaadaaaaaabkiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaaadaaaaaa
bkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaadaaaaaabkiacaaaacaaaaaa
aoaaaaaadgaaaaagicaabaaaadaaaaaabkiacaaaacaaaaaaapaaaaaabbaaaaah
ccaabaaaaaaaaaaaegaobaaaadaaaaaaegbobaaaacaaaaaadbaaaaahecaabaaa
aaaaaaaaabeaaaaaaaaaaadpbkaabaaaaaaaaaaadccaaaakccaabaaaaaaaaaaa
bkaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpaaaaaaai
icaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadpdiaaaaah
icaabaaaaaaaaaaadkaabaaaaaaaaaaabkaabaaaabaaaaaadcaaaaajccaabaaa
aaaaaaaabkaabaaaacaaaaaabkaabaaaaaaaaaaadkaabaaaaaaaaaaaabaaaaah
ccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaadeaaaaahbcaabaaa
aaaaaaaabkaabaaaaaaaaaaaakaabaaaaaaaaaaadgaaaaagbcaabaaaadaaaaaa
ckiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaaadaaaaaackiacaaaacaaaaaa
anaaaaaadgaaaaagecaabaaaadaaaaaackiacaaaacaaaaaaaoaaaaaadgaaaaag
icaabaaaadaaaaaackiacaaaacaaaaaaapaaaaaabbaaaaahccaabaaaaaaaaaaa
egaobaaaadaaaaaaegbobaaaacaaaaaadccaaaakecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpdbaaaaahccaabaaa
aaaaaaaaabeaaaaaaaaaaadpbkaabaaaaaaaaaaaaaaaaaaiicaabaaaaaaaaaaa
ckaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadpdiaaaaahicaabaaaaaaaaaaa
dkaabaaaaaaaaaaackaabaaaabaaaaaadcaaaaajecaabaaaaaaaaaaackaabaaa
acaaaaaackaabaaaaaaaaaaadkaabaaaaaaaaaaaabaaaaahccaabaaaaaaaaaaa
ckaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaagbcaabaaaadaaaaaadkiacaaa
acaaaaaaamaaaaaadgaaaaagccaabaaaadaaaaaadkiacaaaacaaaaaaanaaaaaa
dgaaaaagecaabaaaadaaaaaadkiacaaaacaaaaaaaoaaaaaadgaaaaagicaabaaa
adaaaaaadkiacaaaacaaaaaaapaaaaaabbaaaaahecaabaaaaaaaaaaaegaobaaa
adaaaaaaegbobaaaacaaaaaadccaaaakicaabaaaaaaaaaaackaabaiaebaaaaaa
aaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpdbaaaaahecaabaaaaaaaaaaa
abeaaaaaaaaaaadpckaabaaaaaaaaaaaaaaaaaaibcaabaaaabaaaaaadkaabaia
ebaaaaaaaaaaaaaaabeaaaaaaaaaiadpdiaaaaahbcaabaaaabaaaaaaakaabaaa
abaaaaaadkaabaaaabaaaaaadcaaaaajicaabaaaaaaaaaaadkaabaaaacaaaaaa
dkaabaaaaaaaaaaaakaabaaaabaaaaaaabaaaaahecaabaaaaaaaaaaadkaabaaa
aaaaaaaackaabaaaaaaaaaaadeaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadeaaaaahbcaabaaaaaaaaaaabkaabaaaaaaaaaaaakaabaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaaakaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadpaaaaaaajocaabaaaaaaaaaaaagbjbaiaebaaaaaaacaaaaaaagijcaaa
aaaaaaaaaaaaaaaabaaaaaahbcaabaaaabaaaaaajgahbaaaaaaaaaaajgahbaaa
aaaaaaaaeeaaaaafbcaabaaaabaaaaaaakaabaaaabaaaaaadiaaaaahocaabaaa
aaaaaaaafgaobaaaaaaaaaaaagaabaaaabaaaaaabacaaaahccaabaaaaaaaaaaa
egbcbaaaabaaaaaajgahbaaaaaaaaaaadiaaaaahecaabaaaaaaaaaaabkaabaaa
aaaaaaaabkaabaaaaaaaaaaadiaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadiaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaabkaabaaa
aaaaaaaaaaaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaaaaaaaaaaagijcaia
ebaaaaaaabaaaaaaabaaaaaadcaaaaakhccabaaaaaaaaaaaagaabaaaaaaaaaaa
jgahbaaaaaaaaaaaegiccaaaabaaaaaaabaaaaaadgaaaaaficcabaaaaaaaaaaa
abeaaaaaaaaaiadpdoaaaaab"
}
SubProgram "gles " {
"!!GLES"
}
SubProgram "d3d11_9x " {
SetTexture 0 [unity_SplashScreenShadowTex0] 2D 0
SetTexture 1 [unity_SplashScreenShadowTex1] 2D 1
ConstBuffer "$Globals" 16
Vector 0 [unity_LightPosition0] 3
ConstBuffer "UnityLightingOld" 64
Vector 0 [unity_LightColor0] 3
Vector 16 [unity_LightColor1] 3
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
BindCB  "$Globals" 0
BindCB  "UnityLightingOld" 1
BindCB  "UnityShadows" 2
"ps_4_0_level_9_1
root12:acadacaa
eefiecedajfgdnbfaboampaldonogdklapiiohlnabaaaaaahiamaaaaaeaaaaaa
daaaaaaabiaeaaaalmalaaaaeeamaaaaebgpgodjoaadaaaaoaadaaaaaaacpppp
jaadaaaafaaaaaaaadaacmaaaaaafaaaaaaafaaaacaaceaaaaaafaaaaaaaaaaa
abababaaaaaaaaaaabaaaaaaaaaaaaaaabaaaaaaacaaabaaaaaaaaaaacaaamaa
aeaaadaaaaaaaaaaaaacppppfbaaaaafahaaapkaaaaaaadpaaaaiadoaaaaiadp
aaaaaaaabpaaaaacaaaaaaiaaaaaahlabpaaaaacaaaaaaiaabaaaplabpaaaaac
aaaaaaiaacaaadlabpaaaaacaaaaaajaaaaiapkabpaaaaacaaaaaajaabaiapka
abaaaaacaaaaabiaadaaaakaabaaaaacaaaaaciaaeaaaakaabaaaaacaaaaaeia
afaaaakaabaaaaacaaaaaiiaagaaaakaajaaaaadaaaaabiaaaaaoeiaabaaoela
acaaaaadaaaaaciaaaaaaaibahaaaakaaeaaaaaeaaaabbiaaaaaaaiaahaaffkb
ahaakkkaecaaaaadabaacpiaacaaoelaaaaioekaecaaaaadacaacpiaacaaoela
abaioekabcaaaaaeadaaaiiaaaaaaaiaabaaaaiaacaaaaiafiaaaaaeaaaaabia
aaaaffiaahaappkaadaappiaabaaaaacadaaabiaadaaffkaabaaaaacadaaacia
aeaaffkaabaaaaacadaaaeiaafaaffkaabaaaaacadaaaiiaagaaffkaajaaaaad
aaaaaciaadaaoeiaabaaoelaacaaaaadaaaaaeiaaaaaffibahaaaakaaeaaaaae
aaaabciaaaaaffiaahaaffkbahaakkkabcaaaaaeadaaabiaaaaaffiaabaaffia
acaaffiafiaaaaaeaaaaaciaaaaakkiaahaappkaadaaaaiaalaaaaadabaaabia
aaaaaaiaaaaaffiaabaaaaacaaaaabiaadaakkkaabaaaaacaaaaaciaaeaakkka
abaaaaacaaaaaeiaafaakkkaabaaaaacaaaaaiiaagaakkkaajaaaaadaaaaabia
aaaaoeiaabaaoelaaeaaaaaeaaaabciaaaaaaaiaahaaffkbahaakkkaacaaaaad
aaaaabiaaaaaaaibahaaaakabcaaaaaeadaaabiaaaaaffiaabaakkiaacaakkia
fiaaaaaeaaaaabiaaaaaaaiaahaappkaadaaaaiaabaaaaacadaaabiaadaappka
abaaaaacadaaaciaaeaappkaabaaaaacadaaaeiaafaappkaabaaaaacadaaaiia
agaappkaajaaaaadaaaaaciaadaaoeiaabaaoelaaeaaaaaeaaaabeiaaaaaffia
ahaaffkbahaakkkaacaaaaadaaaaaciaaaaaffibahaaaakabcaaaaaeadaaabia
aaaakkiaabaappiaacaappiafiaaaaaeaaaaaciaaaaaffiaahaappkaadaaaaia
alaaaaadabaaaciaaaaaaaiaaaaaffiaalaaaaadaaaaabiaabaaaaiaabaaffia
acaaaaadaaaaabiaaaaaaaibahaakkkaacaaaaadabaaahiaabaaoelbaaaaoeka
ceaaaaacacaaahiaabaaoeiaaiaaaaadaaaabciaaaaaoelaacaaoeiaafaaaaad
aaaaaeiaaaaaffiaaaaaffiaafaaaaadaaaaaciaaaaakkiaaaaaffiaafaaaaad
aaaacbiaaaaaaaiaaaaaffiaabaaaaacabaaahiaacaaoekaacaaaaadaaaacoia
abaablibabaablkaaeaaaaaeaaaachiaaaaaaaiaaaaabliaacaaoekaabaaaaac
aaaaaiiaahaakkkaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcjmahaaaa
eaaaaaaaohabaaaafjaaaaaeegiocaaaaaaaaaaaabaaaaaafjaaaaaeegiocaaa
abaaaaaaacaaaaaafjaaaaaeegiocaaaacaaaaaabaaaaaaafkaaaaadaagabaaa
aaaaaaaafkaaaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaa
fibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaadhcbabaaaabaaaaaagcbaaaad
pcbabaaaacaaaaaagcbaaaaddcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacaeaaaaaadgaaaaagbcaabaaaaaaaaaaaakiacaaaacaaaaaaamaaaaaa
dgaaaaagccaabaaaaaaaaaaaakiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaa
aaaaaaaaakiacaaaacaaaaaaaoaaaaaadgaaaaagicaabaaaaaaaaaaaakiacaaa
acaaaaaaapaaaaaabbaaaaahbcaabaaaaaaaaaaaegaobaaaaaaaaaaaegbobaaa
acaaaaaadbaaaaahccaabaaaaaaaaaaaabeaaaaaaaaaaadpakaabaaaaaaaaaaa
dccaaaakbcaabaaaaaaaaaaaakaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiado
abeaaaaaaaaaiadpaaaaaaaiecaabaaaaaaaaaaaakaabaiaebaaaaaaaaaaaaaa
abeaaaaaaaaaiadpefaaaaajpcaabaaaabaaaaaaegbabaaaadaaaaaaeghobaaa
abaaaaaaaagabaaaabaaaaaadiaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaa
akaabaaaabaaaaaaefaaaaajpcaabaaaacaaaaaaegbabaaaadaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaajbcaabaaaaaaaaaaaakaabaaaacaaaaaa
akaabaaaaaaaaaaackaabaaaaaaaaaaaabaaaaahbcaabaaaaaaaaaaaakaabaaa
aaaaaaaabkaabaaaaaaaaaaadgaaaaagbcaabaaaadaaaaaabkiacaaaacaaaaaa
amaaaaaadgaaaaagccaabaaaadaaaaaabkiacaaaacaaaaaaanaaaaaadgaaaaag
ecaabaaaadaaaaaabkiacaaaacaaaaaaaoaaaaaadgaaaaagicaabaaaadaaaaaa
bkiacaaaacaaaaaaapaaaaaabbaaaaahccaabaaaaaaaaaaaegaobaaaadaaaaaa
egbobaaaacaaaaaadbaaaaahecaabaaaaaaaaaaaabeaaaaaaaaaaadpbkaabaaa
aaaaaaaadccaaaakccaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaiadpaaaaaaaiicaabaaaaaaaaaaabkaabaiaebaaaaaa
aaaaaaaaabeaaaaaaaaaiadpdiaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaa
bkaabaaaabaaaaaadcaaaaajccaabaaaaaaaaaaabkaabaaaacaaaaaabkaabaaa
aaaaaaaadkaabaaaaaaaaaaaabaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaa
ckaabaaaaaaaaaaadeaaaaahbcaabaaaaaaaaaaabkaabaaaaaaaaaaaakaabaaa
aaaaaaaadgaaaaagbcaabaaaadaaaaaackiacaaaacaaaaaaamaaaaaadgaaaaag
ccaabaaaadaaaaaackiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaadaaaaaa
ckiacaaaacaaaaaaaoaaaaaadgaaaaagicaabaaaadaaaaaackiacaaaacaaaaaa
apaaaaaabbaaaaahccaabaaaaaaaaaaaegaobaaaadaaaaaaegbobaaaacaaaaaa
dccaaaakecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiado
abeaaaaaaaaaiadpdbaaaaahccaabaaaaaaaaaaaabeaaaaaaaaaaadpbkaabaaa
aaaaaaaaaaaaaaaiicaabaaaaaaaaaaackaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadpdiaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaackaabaaaabaaaaaa
dcaaaaajecaabaaaaaaaaaaackaabaaaacaaaaaackaabaaaaaaaaaaadkaabaaa
aaaaaaaaabaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaa
dgaaaaagbcaabaaaadaaaaaadkiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaa
adaaaaaadkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaadaaaaaadkiacaaa
acaaaaaaaoaaaaaadgaaaaagicaabaaaadaaaaaadkiacaaaacaaaaaaapaaaaaa
bbaaaaahecaabaaaaaaaaaaaegaobaaaadaaaaaaegbobaaaacaaaaaadccaaaak
icaabaaaaaaaaaaackaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaa
aaaaiadpdbaaaaahecaabaaaaaaaaaaaabeaaaaaaaaaaadpckaabaaaaaaaaaaa
aaaaaaaibcaabaaaabaaaaaadkaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadp
diaaaaahbcaabaaaabaaaaaaakaabaaaabaaaaaadkaabaaaabaaaaaadcaaaaaj
icaabaaaaaaaaaaadkaabaaaacaaaaaadkaabaaaaaaaaaaaakaabaaaabaaaaaa
abaaaaahecaabaaaaaaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaadeaaaaah
ccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadeaaaaahbcaabaaa
aaaaaaaabkaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaaaaaaaaaa
akaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadpaaaaaaajocaabaaaaaaaaaaa
agbjbaiaebaaaaaaacaaaaaaagijcaaaaaaaaaaaaaaaaaaabaaaaaahbcaabaaa
abaaaaaajgahbaaaaaaaaaaajgahbaaaaaaaaaaaeeaaaaafbcaabaaaabaaaaaa
akaabaaaabaaaaaadiaaaaahocaabaaaaaaaaaaafgaobaaaaaaaaaaaagaabaaa
abaaaaaabacaaaahccaabaaaaaaaaaaaegbcbaaaabaaaaaajgahbaaaaaaaaaaa
diaaaaahecaabaaaaaaaaaaabkaabaaaaaaaaaaabkaabaaaaaaaaaaadiaaaaah
ccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadiaaaaahbcaabaaa
aaaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaaaaaaaaakocaabaaaaaaaaaaa
agijcaaaabaaaaaaaaaaaaaaagijcaiaebaaaaaaabaaaaaaabaaaaaadcaaaaak
hccabaaaaaaaaaaaagaabaaaaaaaaaaajgahbaaaaaaaaaaaegiccaaaabaaaaaa
abaaaaaadgaaaaaficcabaaaaaaaaaaaabeaaaaaaaaaiadpdoaaaaabejfdeheo
iaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaaheaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaaheaaaaaaacaaaaaaaaaaaaaa
adaaaaaaadaaaaaaadadaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl"
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
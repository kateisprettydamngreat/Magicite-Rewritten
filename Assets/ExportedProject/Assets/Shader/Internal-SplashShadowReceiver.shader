//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/InternalSplashShadowReceiver" {
SubShader { 
 Pass {
  Cull Off
  GpuProgramID 50027
Program "vp" {
SubProgram "opengl " {
"!!GLSL#version 120

#ifdef VERTEX

varying vec3 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
varying vec4 xlv_COLOR;
void main ()
{
  vec4 tmpvar_1;
  tmpvar_1.w = 1.0;
  tmpvar_1.xyz = gl_Vertex.xyz;
  gl_Position = (gl_ModelViewProjectionMatrix * gl_Vertex);
  xlv_TEXCOORD0 = gl_Normal;
  xlv_TEXCOORD1 = tmpvar_1;
  xlv_COLOR = gl_Color;
}


#endif
#ifdef FRAGMENT
uniform vec3 unity_LightColor0;
uniform vec3 unity_LightColor1;
uniform mat4 unity_World2Shadow[4];
uniform sampler2D unity_SplashScreenShadowTex0;
uniform sampler2D unity_SplashScreenShadowTex1;
uniform sampler2D unity_SplashScreenShadowTex2;
uniform sampler2D unity_SplashScreenShadowTex3;
uniform sampler2D unity_SplashScreenShadowTex4;
uniform sampler2D unity_SplashScreenShadowTex5;
uniform sampler2D unity_SplashScreenShadowTex6;
uniform sampler2D unity_SplashScreenShadowTex7;
uniform sampler2D unity_SplashScreenShadowTex8;
uniform vec3 unity_LightPosition0;
varying vec3 xlv_TEXCOORD0;
varying vec4 xlv_TEXCOORD1;
varying vec4 xlv_COLOR;
void main ()
{
  vec4 tmpvar_1;
  tmpvar_1 = xlv_TEXCOORD1;
  float biasedDepth_3;
  int equationIndex_4;
  int equationMatrixIndex_5;
  vec4 weightedShadowSample_6;
  vec4 planeShadows3_7;
  vec4 planeShadows2_8;
  vec4 planeShadows1_9;
  vec4 shadowSample8_10;
  vec4 shadowSample7_11;
  vec4 shadowSample6_12;
  vec4 shadowSample5_13;
  vec4 shadowSample4_14;
  vec4 shadowSample3_15;
  vec4 shadowSample2_16;
  vec4 shadowSample1_17;
  vec4 shadowSample0_18;
  vec4 tmpvar_19;
  tmpvar_19 = (unity_World2Shadow[0] * xlv_TEXCOORD1);
  vec2 tmpvar_20;
  tmpvar_20 = (((tmpvar_19.xy / tmpvar_19.w) * 0.5) + 0.5);
  shadowSample0_18 = texture2D (unity_SplashScreenShadowTex0, tmpvar_20);
  shadowSample1_17 = texture2D (unity_SplashScreenShadowTex1, tmpvar_20);
  shadowSample2_16 = texture2D (unity_SplashScreenShadowTex2, tmpvar_20);
  shadowSample3_15 = texture2D (unity_SplashScreenShadowTex3, tmpvar_20);
  shadowSample4_14 = texture2D (unity_SplashScreenShadowTex4, tmpvar_20);
  shadowSample5_13 = texture2D (unity_SplashScreenShadowTex5, tmpvar_20);
  shadowSample6_12 = texture2D (unity_SplashScreenShadowTex6, tmpvar_20);
  shadowSample7_11 = texture2D (unity_SplashScreenShadowTex7, tmpvar_20);
  shadowSample8_10 = texture2D (unity_SplashScreenShadowTex8, tmpvar_20);
  planeShadows1_9 = vec4(0.0, 0.0, 0.0, 0.0);
  planeShadows2_8 = vec4(0.0, 0.0, 0.0, 0.0);
  planeShadows3_7 = vec4(0.0, 0.0, 0.0, 0.0);
  equationMatrixIndex_5 = 1;
  equationIndex_4 = 0;
  for (int planeIndex_2 = 0; planeIndex_2 < 12; planeIndex_2++) {
    equationIndex_4 = planeIndex_2;
    if ((planeIndex_2 >= 8)) {
      equationMatrixIndex_5 = 3;
      equationIndex_4 = (planeIndex_2 - 8);
    } else {
      if ((planeIndex_2 >= 4)) {
        equationMatrixIndex_5 = 2;
        equationIndex_4 = (equationIndex_4 - 4);
      };
    };
    mat4 m_21;
    m_21 = unity_World2Shadow[equationMatrixIndex_5];
    vec4 v_22;
    v_22.x = m_21[0][equationIndex_4];
    v_22.y = m_21[1][equationIndex_4];
    v_22.z = m_21[2][equationIndex_4];
    v_22.w = m_21[3][equationIndex_4];
    biasedDepth_3 = (dot (v_22, tmpvar_1) - 1.0);
    if ((biasedDepth_3 > 0.0)) {
      float tmpvar_23;
      tmpvar_23 = clamp ((biasedDepth_3 * 0.5), 0.0, 1.0);
      float tmpvar_24;
      tmpvar_24 = clamp (((biasedDepth_3 - 2.0) / 48.0), 0.0, 1.0);
      float tmpvar_25;
      tmpvar_25 = (biasedDepth_3 * 0.25);
      float tmpvar_26;
      tmpvar_26 = clamp ((1.0 - tmpvar_25), 0.0, 1.0);
      float tmpvar_27;
      tmpvar_27 = clamp ((tmpvar_25 - 1.0), 0.0, 1.0);
      float tmpvar_28;
      tmpvar_28 = (1.0 - (tmpvar_26 + tmpvar_27));
      if ((equationMatrixIndex_5 == 1)) {
        weightedShadowSample_6 = (((shadowSample0_18 * tmpvar_26) + (shadowSample1_17 * tmpvar_28)) + (shadowSample2_16 * tmpvar_27));
        planeShadows1_9[equationIndex_4] = (((
          weightedShadowSample_6[equationIndex_4]
         * tmpvar_23) - tmpvar_24) * (1.0 + tmpvar_24));
      } else {
        if ((equationMatrixIndex_5 == 2)) {
          weightedShadowSample_6 = (((shadowSample3_15 * tmpvar_26) + (shadowSample4_14 * tmpvar_28)) + (shadowSample5_13 * tmpvar_27));
          planeShadows2_8[equationIndex_4] = (((
            weightedShadowSample_6[equationIndex_4]
           * tmpvar_23) - tmpvar_24) * (1.0 + tmpvar_24));
        } else {
          weightedShadowSample_6 = (((shadowSample6_12 * tmpvar_26) + (shadowSample7_11 * tmpvar_28)) + (shadowSample8_10 * tmpvar_27));
          planeShadows3_7[equationIndex_4] = (((
            weightedShadowSample_6[equationIndex_4]
           * tmpvar_23) - tmpvar_24) * (1.0 + tmpvar_24));
        };
      };
    };
  };
  vec4 tmpvar_29;
  tmpvar_29.w = 1.0;
  tmpvar_29.xyz = mix (unity_LightColor1, unity_LightColor0, vec3((pow (
    clamp (dot (xlv_TEXCOORD0, normalize((unity_LightPosition0 - xlv_TEXCOORD1.xyz))), 0.0, 1.0)
  , 3.0) * (1.0 - 
    clamp (max (max (max (
      max (planeShadows1_9.x, planeShadows1_9.y)
    , 
      max (planeShadows1_9.z, planeShadows1_9.w)
    ), max (
      max (planeShadows2_8.x, planeShadows2_8.y)
    , 
      max (planeShadows2_8.z, planeShadows2_8.w)
    )), max (max (planeShadows3_7.x, planeShadows3_7.y), max (planeShadows3_7.z, planeShadows3_7.w))), 0.0, 1.0)
  ))));
  gl_FragData[0] = (tmpvar_29 * xlv_COLOR);
}


#endif
"
}
SubProgram "d3d9 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
Matrix 0 [glstate_matrix_mvp]
"vs_3_0
def c4, 1, 0, 0, 0
dcl_position v0
dcl_normal v1
dcl_color v2
dcl_position o0
dcl_texcoord o1.xyz
dcl_texcoord1 o2
dcl_color o3
dp4 o0.x, c0, v0
dp4 o0.y, c1, v0
dp4 o0.z, c2, v0
dp4 o0.w, c3, v0
mov o1.xyz, v1
mad o2, v0.xyzx, c4.xxxy, c4.yyyx
mov o3, v2

"
}
SubProgram "d3d11 " {
Bind "vertex" Vertex
Bind "color" Color
Bind "normal" Normal
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerDraw" 0
"vs_4_0
root12:aaabaaaa
eefiecedbmhgpaofmhlgmcpgnkkhdocjiablgpbkabaaaaaajeacaaaaadaaaaaa
cmaaaaaajmaaaaaaciabaaaaejfdeheogiaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaafaepfdejfeejepeoaaeoepfcenebemaaedepemepfcaaklklepfdeheo
ieaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaabaaaaaaadaaaaaaaaaaaaaa
apaaaaaaheaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaaheaaaaaa
abaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahnaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaadaaaaaaapaaaaaafdfgfpfaepfdejfeejepeoaafeeffiedepepfcee
aaedepemepfcaaklfdeieefcgeabaaaaeaaaabaafjaaaaaafjaaaaaeegiocaaa
aaaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaadhcbabaaaabaaaaaa
fpaaaaadpcbabaaaacaaaaaaghaaaaaepccabaaaaaaaaaaaabaaaaaagfaaaaad
hccabaaaabaaaaaagfaaaaadpccabaaaacaaaaaagfaaaaadpccabaaaadaaaaaa
giaaaaacabaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaa
aaaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaaaaaaaaaaaaaaaaa
agbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
aaaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpccabaaa
aaaaaaaaegiocaaaaaaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaa
dgaaaaafhccabaaaabaaaaaaegbcbaaaabaaaaaadgaaaaafhccabaaaacaaaaaa
egbcbaaaaaaaaaaadgaaaaaficcabaaaacaaaaaaabeaaaaaaaaaiadpdgaaaaaf
pccabaaaadaaaaaaegbobaaaacaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec4 _glesColor;
attribute vec3 _glesNormal;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
varying lowp vec4 xlv_COLOR;
void main ()
{
  highp vec4 tmpvar_1;
  tmpvar_1.w = 1.0;
  tmpvar_1.xyz = _glesVertex.xyz;
  gl_Position = (glstate_matrix_mvp * _glesVertex);
  xlv_TEXCOORD0 = _glesNormal;
  xlv_TEXCOORD1 = tmpvar_1;
  xlv_COLOR = _glesColor;
}


#endif
#ifdef FRAGMENT
uniform mediump vec3 unity_LightColor0;
uniform mediump vec3 unity_LightColor1;
uniform highp mat4 unity_World2Shadow[4];
uniform sampler2D unity_SplashScreenShadowTex0;
uniform sampler2D unity_SplashScreenShadowTex1;
uniform sampler2D unity_SplashScreenShadowTex2;
uniform sampler2D unity_SplashScreenShadowTex3;
uniform sampler2D unity_SplashScreenShadowTex4;
uniform sampler2D unity_SplashScreenShadowTex5;
uniform sampler2D unity_SplashScreenShadowTex6;
uniform sampler2D unity_SplashScreenShadowTex7;
uniform sampler2D unity_SplashScreenShadowTex8;
uniform highp vec3 unity_LightPosition0;
varying highp vec3 xlv_TEXCOORD0;
varying highp vec4 xlv_TEXCOORD1;
varying lowp vec4 xlv_COLOR;
void main ()
{
  lowp vec4 tmpvar_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = xlv_TEXCOORD1;
  lowp float shadowedIntensity_3;
  highp float biasedDepth_5;
  highp int equationIndex_6;
  highp int equationMatrixIndex_7;
  lowp vec4 weightedShadowSample_8;
  highp vec4 planeShadows3_9;
  highp vec4 planeShadows2_10;
  highp vec4 planeShadows1_11;
  lowp vec4 shadowSample8_12;
  lowp vec4 shadowSample7_13;
  lowp vec4 shadowSample6_14;
  lowp vec4 shadowSample5_15;
  lowp vec4 shadowSample4_16;
  lowp vec4 shadowSample3_17;
  lowp vec4 shadowSample2_18;
  lowp vec4 shadowSample1_19;
  lowp vec4 shadowSample0_20;
  highp vec4 tmpvar_21;
  tmpvar_21 = (unity_World2Shadow[0] * xlv_TEXCOORD1);
  highp vec2 tmpvar_22;
  tmpvar_22 = (((tmpvar_21.xy / tmpvar_21.w) * 0.5) + 0.5);
  shadowSample0_20 = texture2D (unity_SplashScreenShadowTex0, tmpvar_22);
  shadowSample1_19 = texture2D (unity_SplashScreenShadowTex1, tmpvar_22);
  shadowSample2_18 = texture2D (unity_SplashScreenShadowTex2, tmpvar_22);
  shadowSample3_17 = texture2D (unity_SplashScreenShadowTex3, tmpvar_22);
  shadowSample4_16 = texture2D (unity_SplashScreenShadowTex4, tmpvar_22);
  shadowSample5_15 = texture2D (unity_SplashScreenShadowTex5, tmpvar_22);
  shadowSample6_14 = texture2D (unity_SplashScreenShadowTex6, tmpvar_22);
  shadowSample7_13 = texture2D (unity_SplashScreenShadowTex7, tmpvar_22);
  shadowSample8_12 = texture2D (unity_SplashScreenShadowTex8, tmpvar_22);
  planeShadows1_11 = vec4(0.0, 0.0, 0.0, 0.0);
  planeShadows2_10 = vec4(0.0, 0.0, 0.0, 0.0);
  planeShadows3_9 = vec4(0.0, 0.0, 0.0, 0.0);
  equationMatrixIndex_7 = 1;
  equationIndex_6 = 0;
  for (highp int planeIndex_4 = 0; planeIndex_4 < 12; planeIndex_4++) {
    equationIndex_6 = planeIndex_4;
    if ((planeIndex_4 >= 8)) {
      equationMatrixIndex_7 = 3;
      equationIndex_6 = (planeIndex_4 - 8);
    } else {
      if ((planeIndex_4 >= 4)) {
        equationMatrixIndex_7 = 2;
        equationIndex_6 = (equationIndex_6 - 4);
      };
    };
    highp mat4 m_23;
    m_23 = unity_World2Shadow[equationMatrixIndex_7];
    highp vec4 v_24;
    v_24.x = m_23[0][equationIndex_6];
    v_24.y = m_23[1][equationIndex_6];
    v_24.z = m_23[2][equationIndex_6];
    v_24.w = m_23[3][equationIndex_6];
    biasedDepth_5 = (dot (v_24, tmpvar_2) - 1.0);
    if ((biasedDepth_5 > 0.0)) {
      highp float tmpvar_25;
      tmpvar_25 = clamp ((biasedDepth_5 * 0.5), 0.0, 1.0);
      highp float tmpvar_26;
      tmpvar_26 = clamp (((biasedDepth_5 - 2.0) / 48.0), 0.0, 1.0);
      highp float tmpvar_27;
      tmpvar_27 = (biasedDepth_5 * 0.25);
      highp float tmpvar_28;
      tmpvar_28 = clamp ((1.0 - tmpvar_27), 0.0, 1.0);
      highp float tmpvar_29;
      tmpvar_29 = clamp ((tmpvar_27 - 1.0), 0.0, 1.0);
      highp float tmpvar_30;
      tmpvar_30 = (1.0 - (tmpvar_28 + tmpvar_29));
      if ((equationMatrixIndex_7 == 1)) {
        weightedShadowSample_8 = (((shadowSample0_20 * tmpvar_28) + (shadowSample1_19 * tmpvar_30)) + (shadowSample2_18 * tmpvar_29));
        planeShadows1_11[equationIndex_6] = (((
          weightedShadowSample_8[equationIndex_6]
         * tmpvar_25) - tmpvar_26) * (1.0 + tmpvar_26));
      } else {
        if ((equationMatrixIndex_7 == 2)) {
          weightedShadowSample_8 = (((shadowSample3_17 * tmpvar_28) + (shadowSample4_16 * tmpvar_30)) + (shadowSample5_15 * tmpvar_29));
          planeShadows2_10[equationIndex_6] = (((
            weightedShadowSample_8[equationIndex_6]
           * tmpvar_25) - tmpvar_26) * (1.0 + tmpvar_26));
        } else {
          weightedShadowSample_8 = (((shadowSample6_14 * tmpvar_28) + (shadowSample7_13 * tmpvar_30)) + (shadowSample8_12 * tmpvar_29));
          planeShadows3_9[equationIndex_6] = (((
            weightedShadowSample_8[equationIndex_6]
           * tmpvar_25) - tmpvar_26) * (1.0 + tmpvar_26));
        };
      };
    };
  };
  highp float tmpvar_31;
  tmpvar_31 = (pow (clamp (
    dot (xlv_TEXCOORD0, normalize((unity_LightPosition0 - xlv_TEXCOORD1.xyz)))
  , 0.0, 1.0), 3.0) * (1.0 - clamp (
    max (max (max (max (planeShadows1_11.x, planeShadows1_11.y), max (planeShadows1_11.z, planeShadows1_11.w)), max (max (planeShadows2_10.x, planeShadows2_10.y), max (planeShadows2_10.z, planeShadows2_10.w))), max (max (planeShadows3_9.x, planeShadows3_9.y), max (planeShadows3_9.z, planeShadows3_9.w)))
  , 0.0, 1.0)));
  shadowedIntensity_3 = tmpvar_31;
  mediump vec4 tmpvar_32;
  tmpvar_32.w = 1.0;
  tmpvar_32.xyz = mix (unity_LightColor1, unity_LightColor0, vec3(shadowedIntensity_3));
  tmpvar_1 = (tmpvar_32 * xlv_COLOR);
  gl_FragData[0] = tmpvar_1;
}


#endif
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
uniform 	vec3 unity_LightPosition0;
in highp vec4 in_POSITION0;
in highp vec3 in_NORMAL0;
in lowp vec4 in_COLOR0;
out highp vec3 vs_TEXCOORD0;
out highp vec4 vs_TEXCOORD1;
out lowp vec4 vs_COLOR0;
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
    vs_COLOR0 = in_COLOR0;
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
uniform lowp sampler2D unity_SplashScreenShadowTex2;
uniform lowp sampler2D unity_SplashScreenShadowTex3;
uniform lowp sampler2D unity_SplashScreenShadowTex4;
uniform lowp sampler2D unity_SplashScreenShadowTex5;
uniform lowp sampler2D unity_SplashScreenShadowTex6;
uniform lowp sampler2D unity_SplashScreenShadowTex7;
uniform lowp sampler2D unity_SplashScreenShadowTex8;
in highp vec3 vs_TEXCOORD0;
in highp vec4 vs_TEXCOORD1;
in lowp vec4 vs_COLOR0;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
highp vec3 t2;
lowp vec4 t10_2;
lowp vec4 t10_3;
lowp vec4 t10_4;
lowp vec4 t10_5;
mediump vec3 t16_6;
highp vec3 t7;
highp float t8;
highp float t14;
highp float t15;
bool tb15;
highp float t16;
highp float t21;
bool tb21;
highp float t22;
void main()
{
    t0.x = unity_World2Shadow[1][0].x;
    t0.y = unity_World2Shadow[1][1].x;
    t0.z = unity_World2Shadow[1][2].x;
    t0.w = unity_World2Shadow[1][3].x;
    t0.x = dot(t0, vs_TEXCOORD1);
    t0.xyz = t0.xxx + vec3(-1.0, -3.0, -1.0);
    tb21 = 0.0<t0.z;
    t0.xy = t0.xy * vec2(0.5, 0.020833334);
    t0.xy = t0.xy;
    t0.xy = clamp(t0.xy, 0.0, 1.0);
    t1.x = t0.y + 1.0;
    t8 = t0.z * 0.25 + -1.0;
    t8 = clamp(t8, 0.0, 1.0);
    t14 = (-t0.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t15 = t8 + t14;
    t15 = (-t15) + 1.0;
    t2.xyz = vs_TEXCOORD1.yyy * unity_World2Shadow[0][1].xyw;
    t2.xyz = unity_World2Shadow[0][0].xyw * vs_TEXCOORD1.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[0][2].xyw * vs_TEXCOORD1.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[0][3].xyw * vs_TEXCOORD1.www + t2.xyz;
    t2.xy = t2.xy / t2.zz;
    t2.xy = t2.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
    t10_3 = texture(unity_SplashScreenShadowTex1, t2.xy);
    t15 = t15 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex0, t2.xy);
    t14 = t10_4.x * t14 + t15;
    t10_5 = texture(unity_SplashScreenShadowTex2, t2.xy);
    t14 = t10_5.x * t8 + t14;
    t0.x = t14 * t0.x + (-t0.y);
    t0.x = t1.x * t0.x;
    t0.x = tb21 ? t0.x : float(0.0);
    t1.x = unity_World2Shadow[1][0].y;
    t1.y = unity_World2Shadow[1][1].y;
    t1.z = unity_World2Shadow[1][2].y;
    t1.w = unity_World2Shadow[1][3].y;
    t7.x = dot(t1, vs_TEXCOORD1);
    t7.xyz = t7.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t7.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t8 = t7.z * 0.25 + -1.0;
    t8 = clamp(t8, 0.0, 1.0);
    t15 = t8 + t1.x;
    t15 = (-t15) + 1.0;
    t15 = t15 * t10_3.y;
    t1.x = t10_4.y * t1.x + t15;
    t1.x = t10_5.y * t8 + t1.x;
    t7.xy = t7.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t7.z;
    t7.xy = t7.xy;
    t7.xy = clamp(t7.xy, 0.0, 1.0);
    t7.x = t1.x * t7.x + (-t7.y);
    t14 = t7.y + 1.0;
    t7.x = t14 * t7.x;
    t7.x = tb21 ? t7.x : float(0.0);
    t0.x = max(t7.x, t0.x);
    t1.x = unity_World2Shadow[1][0].z;
    t1.y = unity_World2Shadow[1][1].z;
    t1.z = unity_World2Shadow[1][2].z;
    t1.w = unity_World2Shadow[1][3].z;
    t7.x = dot(t1, vs_TEXCOORD1);
    t7.xyz = t7.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t7.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t8 = t7.z * 0.25 + -1.0;
    t8 = clamp(t8, 0.0, 1.0);
    t15 = t8 + t1.x;
    t15 = (-t15) + 1.0;
    t15 = t15 * t10_3.z;
    t1.x = t10_4.z * t1.x + t15;
    t1.x = t10_5.z * t8 + t1.x;
    t7.xy = t7.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t7.z;
    t7.xy = t7.xy;
    t7.xy = clamp(t7.xy, 0.0, 1.0);
    t7.x = t1.x * t7.x + (-t7.y);
    t14 = t7.y + 1.0;
    t7.x = t14 * t7.x;
    t7.x = tb21 ? t7.x : float(0.0);
    t1.x = unity_World2Shadow[1][0].w;
    t1.y = unity_World2Shadow[1][1].w;
    t1.z = unity_World2Shadow[1][2].w;
    t1.w = unity_World2Shadow[1][3].w;
    t14 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t14) + vec3(-1.0, -3.0, -1.0);
    t14 = (-t1.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t21 = t1.z * 0.25 + -1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t21 + t14;
    t22 = (-t22) + 1.0;
    t22 = t22 * t10_3.w;
    t14 = t10_4.w * t14 + t22;
    t14 = t10_5.w * t21 + t14;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t14 = t14 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t14 = t14 * t1.x;
    t14 = tb21 ? t14 : float(0.0);
    t7.x = max(t14, t7.x);
    t0.x = max(t7.x, t0.x);
    t1.x = unity_World2Shadow[2][0].x;
    t1.y = unity_World2Shadow[2][1].x;
    t1.z = unity_World2Shadow[2][2].x;
    t1.w = unity_World2Shadow[2][3].x;
    t7.x = dot(t1, vs_TEXCOORD1);
    t7.xyz = t7.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t7.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t8 = t7.z * 0.25 + -1.0;
    t8 = clamp(t8, 0.0, 1.0);
    t15 = t8 + t1.x;
    t15 = (-t15) + 1.0;
    t10_3 = texture(unity_SplashScreenShadowTex4, t2.xy);
    t15 = t15 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex3, t2.xy);
    t1.x = t10_4.x * t1.x + t15;
    t10_5 = texture(unity_SplashScreenShadowTex5, t2.xy);
    t1.x = t10_5.x * t8 + t1.x;
    t7.xy = t7.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t7.z;
    t7.xy = t7.xy;
    t7.xy = clamp(t7.xy, 0.0, 1.0);
    t7.x = t1.x * t7.x + (-t7.y);
    t14 = t7.y + 1.0;
    t7.x = t14 * t7.x;
    t7.x = tb21 ? t7.x : float(0.0);
    t1.x = unity_World2Shadow[2][0].y;
    t1.y = unity_World2Shadow[2][1].y;
    t1.z = unity_World2Shadow[2][2].y;
    t1.w = unity_World2Shadow[2][3].y;
    t14 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t14) + vec3(-1.0, -3.0, -1.0);
    t14 = (-t1.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t21 = t1.z * 0.25 + -1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t21 + t14;
    t22 = (-t22) + 1.0;
    t22 = t22 * t10_3.y;
    t14 = t10_4.y * t14 + t22;
    t14 = t10_5.y * t21 + t14;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t14 = t14 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t14 = t14 * t1.x;
    t14 = tb21 ? t14 : float(0.0);
    t7.x = max(t14, t7.x);
    t1.x = unity_World2Shadow[2][0].z;
    t1.y = unity_World2Shadow[2][1].z;
    t1.z = unity_World2Shadow[2][2].z;
    t1.w = unity_World2Shadow[2][3].z;
    t14 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t14) + vec3(-1.0, -3.0, -1.0);
    t14 = (-t1.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t21 = t1.z * 0.25 + -1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t21 + t14;
    t22 = (-t22) + 1.0;
    t22 = t22 * t10_3.z;
    t14 = t10_4.z * t14 + t22;
    t14 = t10_5.z * t21 + t14;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t14 = t14 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t14 = t14 * t1.x;
    t14 = tb21 ? t14 : float(0.0);
    t1.x = unity_World2Shadow[2][0].w;
    t1.y = unity_World2Shadow[2][1].w;
    t1.z = unity_World2Shadow[2][2].w;
    t1.w = unity_World2Shadow[2][3].w;
    t21 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t21) + vec3(-1.0, -3.0, -1.0);
    t21 = (-t1.z) * 0.25 + 1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t1.z * 0.25 + -1.0;
    t22 = clamp(t22, 0.0, 1.0);
    t16 = t21 + t22;
    t16 = (-t16) + 1.0;
    t16 = t16 * t10_3.w;
    t21 = t10_4.w * t21 + t16;
    t21 = t10_5.w * t22 + t21;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb15 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t21 = t21 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t21 = t21 * t1.x;
    t21 = tb15 ? t21 : float(0.0);
    t14 = max(t21, t14);
    t7.x = max(t14, t7.x);
    t0.x = max(t7.x, t0.x);
    t1.x = unity_World2Shadow[3][0].x;
    t1.y = unity_World2Shadow[3][1].x;
    t1.z = unity_World2Shadow[3][2].x;
    t1.w = unity_World2Shadow[3][3].x;
    t7.x = dot(t1, vs_TEXCOORD1);
    t7.xyz = t7.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t7.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t8 = t7.z * 0.25 + -1.0;
    t8 = clamp(t8, 0.0, 1.0);
    t15 = t8 + t1.x;
    t15 = (-t15) + 1.0;
    t10_3 = texture(unity_SplashScreenShadowTex7, t2.xy);
    t15 = t15 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex6, t2.xy);
    t10_2 = texture(unity_SplashScreenShadowTex8, t2.xy);
    t1.x = t10_4.x * t1.x + t15;
    t1.x = t10_2.x * t8 + t1.x;
    t7.xy = t7.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t7.z;
    t7.xy = t7.xy;
    t7.xy = clamp(t7.xy, 0.0, 1.0);
    t7.x = t1.x * t7.x + (-t7.y);
    t14 = t7.y + 1.0;
    t7.x = t14 * t7.x;
    t7.x = tb21 ? t7.x : float(0.0);
    t1.x = unity_World2Shadow[3][0].y;
    t1.y = unity_World2Shadow[3][1].y;
    t1.z = unity_World2Shadow[3][2].y;
    t1.w = unity_World2Shadow[3][3].y;
    t14 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t14) + vec3(-1.0, -3.0, -1.0);
    t14 = (-t1.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t21 = t1.z * 0.25 + -1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t21 + t14;
    t22 = (-t22) + 1.0;
    t22 = t22 * t10_3.y;
    t14 = t10_4.y * t14 + t22;
    t14 = t10_2.y * t21 + t14;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t14 = t14 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t14 = t14 * t1.x;
    t14 = tb21 ? t14 : float(0.0);
    t7.x = max(t14, t7.x);
    t1.x = unity_World2Shadow[3][0].z;
    t1.y = unity_World2Shadow[3][1].z;
    t1.z = unity_World2Shadow[3][2].z;
    t1.w = unity_World2Shadow[3][3].z;
    t14 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t14) + vec3(-1.0, -3.0, -1.0);
    t14 = (-t1.z) * 0.25 + 1.0;
    t14 = clamp(t14, 0.0, 1.0);
    t21 = t1.z * 0.25 + -1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t21 + t14;
    t22 = (-t22) + 1.0;
    t22 = t22 * t10_3.z;
    t14 = t10_4.z * t14 + t22;
    t14 = t10_2.z * t21 + t14;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb21 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t14 = t14 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t14 = t14 * t1.x;
    t14 = tb21 ? t14 : float(0.0);
    t1.x = unity_World2Shadow[3][0].w;
    t1.y = unity_World2Shadow[3][1].w;
    t1.z = unity_World2Shadow[3][2].w;
    t1.w = unity_World2Shadow[3][3].w;
    t21 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t21) + vec3(-1.0, -3.0, -1.0);
    t21 = (-t1.z) * 0.25 + 1.0;
    t21 = clamp(t21, 0.0, 1.0);
    t22 = t1.z * 0.25 + -1.0;
    t22 = clamp(t22, 0.0, 1.0);
    t2.x = t21 + t22;
    t2.x = (-t2.x) + 1.0;
    t2.x = t2.x * t10_3.w;
    t21 = t10_4.w * t21 + t2.x;
    t21 = t10_2.w * t22 + t21;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb15 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t21 = t21 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t21 = t21 * t1.x;
    t21 = tb15 ? t21 : float(0.0);
    t14 = max(t21, t14);
    t7.x = max(t14, t7.x);
    t0.x = max(t7.x, t0.x);
    t0.x = clamp(t0.x, 0.0, 1.0);
    t0.x = (-t0.x) + 1.0;
    t7.xyz = (-vs_TEXCOORD1.xyz) + unity_LightPosition0.xyzx.xyz;
    t1.x = dot(t7.xyz, t7.xyz);
    t1.x = inversesqrt(t1.x);
    t7.xyz = t7.xyz * t1.xxx;
    t7.x = dot(vs_TEXCOORD0.xyz, t7.xyz);
    t7.x = clamp(t7.x, 0.0, 1.0);
    t14 = t7.x * t7.x;
    t7.x = t14 * t7.x;
    t0.x = t0.x * t7.x;
    t16_6.xyz = unity_LightColor0.xyzx.xyz + (-unity_LightColor1.xyzx.xyz);
    t16_6.xyz = t0.xxx * t16_6.xyz + unity_LightColor1.xyzx.xyz;
    SV_Target0.xyz = t16_6.xyz * vs_COLOR0.xyz;
    SV_Target0.w = vs_COLOR0.w;
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
in  vec4 in_COLOR0;
out vec3 vs_TEXCOORD0;
out vec4 vs_TEXCOORD1;
out vec4 vs_COLOR0;
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
    vs_COLOR0 = in_COLOR0;
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
uniform  sampler2D unity_SplashScreenShadowTex2;
uniform  sampler2D unity_SplashScreenShadowTex3;
uniform  sampler2D unity_SplashScreenShadowTex4;
uniform  sampler2D unity_SplashScreenShadowTex5;
uniform  sampler2D unity_SplashScreenShadowTex6;
uniform  sampler2D unity_SplashScreenShadowTex7;
uniform  sampler2D unity_SplashScreenShadowTex8;
in  vec3 vs_TEXCOORD0;
in  vec4 vs_TEXCOORD1;
in  vec4 vs_COLOR0;
out vec4 SV_Target0;
vec4 t0;
vec4 t1;
vec3 t2;
lowp vec4 t10_2;
lowp vec4 t10_3;
lowp vec4 t10_4;
lowp vec4 t10_5;
vec3 t6;
float t7;
float t12;
float t13;
bool tb13;
float t14;
float t18;
bool tb18;
float t19;
void main()
{
    t0.x = unity_World2Shadow[1][0].x;
    t0.y = unity_World2Shadow[1][1].x;
    t0.z = unity_World2Shadow[1][2].x;
    t0.w = unity_World2Shadow[1][3].x;
    t0.x = dot(t0, vs_TEXCOORD1);
    t0.xyz = t0.xxx + vec3(-1.0, -3.0, -1.0);
    tb18 = 0.0<t0.z;
    t0.xy = t0.xy * vec2(0.5, 0.020833334);
    t0.xy = t0.xy;
    t0.xy = clamp(t0.xy, 0.0, 1.0);
    t1.x = t0.y + 1.0;
    t7 = t0.z * 0.25 + -1.0;
    t7 = clamp(t7, 0.0, 1.0);
    t12 = (-t0.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t13 = t7 + t12;
    t13 = (-t13) + 1.0;
    t2.xyz = vs_TEXCOORD1.yyy * unity_World2Shadow[0][1].xyw;
    t2.xyz = unity_World2Shadow[0][0].xyw * vs_TEXCOORD1.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[0][2].xyw * vs_TEXCOORD1.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[0][3].xyw * vs_TEXCOORD1.www + t2.xyz;
    t2.xy = t2.xy / t2.zz;
    t2.xy = t2.xy * vec2(0.5, 0.5) + vec2(0.5, 0.5);
    t10_3 = texture(unity_SplashScreenShadowTex1, t2.xy);
    t13 = t13 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex0, t2.xy);
    t12 = t10_4.x * t12 + t13;
    t10_5 = texture(unity_SplashScreenShadowTex2, t2.xy);
    t12 = t10_5.x * t7 + t12;
    t0.x = t12 * t0.x + (-t0.y);
    t0.x = t1.x * t0.x;
    t0.x = tb18 ? t0.x : float(0.0);
    t1.x = unity_World2Shadow[1][0].y;
    t1.y = unity_World2Shadow[1][1].y;
    t1.z = unity_World2Shadow[1][2].y;
    t1.w = unity_World2Shadow[1][3].y;
    t6.x = dot(t1, vs_TEXCOORD1);
    t6.xyz = t6.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t6.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t7 = t6.z * 0.25 + -1.0;
    t7 = clamp(t7, 0.0, 1.0);
    t13 = t7 + t1.x;
    t13 = (-t13) + 1.0;
    t13 = t13 * t10_3.y;
    t1.x = t10_4.y * t1.x + t13;
    t1.x = t10_5.y * t7 + t1.x;
    t6.xy = t6.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t6.z;
    t6.xy = t6.xy;
    t6.xy = clamp(t6.xy, 0.0, 1.0);
    t6.x = t1.x * t6.x + (-t6.y);
    t12 = t6.y + 1.0;
    t6.x = t12 * t6.x;
    t6.x = tb18 ? t6.x : float(0.0);
    t0.x = max(t6.x, t0.x);
    t1.x = unity_World2Shadow[1][0].z;
    t1.y = unity_World2Shadow[1][1].z;
    t1.z = unity_World2Shadow[1][2].z;
    t1.w = unity_World2Shadow[1][3].z;
    t6.x = dot(t1, vs_TEXCOORD1);
    t6.xyz = t6.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t6.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t7 = t6.z * 0.25 + -1.0;
    t7 = clamp(t7, 0.0, 1.0);
    t13 = t7 + t1.x;
    t13 = (-t13) + 1.0;
    t13 = t13 * t10_3.z;
    t1.x = t10_4.z * t1.x + t13;
    t1.x = t10_5.z * t7 + t1.x;
    t6.xy = t6.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t6.z;
    t6.xy = t6.xy;
    t6.xy = clamp(t6.xy, 0.0, 1.0);
    t6.x = t1.x * t6.x + (-t6.y);
    t12 = t6.y + 1.0;
    t6.x = t12 * t6.x;
    t6.x = tb18 ? t6.x : float(0.0);
    t1.x = unity_World2Shadow[1][0].w;
    t1.y = unity_World2Shadow[1][1].w;
    t1.z = unity_World2Shadow[1][2].w;
    t1.w = unity_World2Shadow[1][3].w;
    t12 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t12) + vec3(-1.0, -3.0, -1.0);
    t12 = (-t1.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t18 = t1.z * 0.25 + -1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t18 + t12;
    t19 = (-t19) + 1.0;
    t19 = t19 * t10_3.w;
    t12 = t10_4.w * t12 + t19;
    t12 = t10_5.w * t18 + t12;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t12 = t12 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t12 = t12 * t1.x;
    t12 = tb18 ? t12 : float(0.0);
    t6.x = max(t12, t6.x);
    t0.x = max(t6.x, t0.x);
    t1.x = unity_World2Shadow[2][0].x;
    t1.y = unity_World2Shadow[2][1].x;
    t1.z = unity_World2Shadow[2][2].x;
    t1.w = unity_World2Shadow[2][3].x;
    t6.x = dot(t1, vs_TEXCOORD1);
    t6.xyz = t6.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t6.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t7 = t6.z * 0.25 + -1.0;
    t7 = clamp(t7, 0.0, 1.0);
    t13 = t7 + t1.x;
    t13 = (-t13) + 1.0;
    t10_3 = texture(unity_SplashScreenShadowTex4, t2.xy);
    t13 = t13 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex3, t2.xy);
    t1.x = t10_4.x * t1.x + t13;
    t10_5 = texture(unity_SplashScreenShadowTex5, t2.xy);
    t1.x = t10_5.x * t7 + t1.x;
    t6.xy = t6.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t6.z;
    t6.xy = t6.xy;
    t6.xy = clamp(t6.xy, 0.0, 1.0);
    t6.x = t1.x * t6.x + (-t6.y);
    t12 = t6.y + 1.0;
    t6.x = t12 * t6.x;
    t6.x = tb18 ? t6.x : float(0.0);
    t1.x = unity_World2Shadow[2][0].y;
    t1.y = unity_World2Shadow[2][1].y;
    t1.z = unity_World2Shadow[2][2].y;
    t1.w = unity_World2Shadow[2][3].y;
    t12 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t12) + vec3(-1.0, -3.0, -1.0);
    t12 = (-t1.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t18 = t1.z * 0.25 + -1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t18 + t12;
    t19 = (-t19) + 1.0;
    t19 = t19 * t10_3.y;
    t12 = t10_4.y * t12 + t19;
    t12 = t10_5.y * t18 + t12;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t12 = t12 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t12 = t12 * t1.x;
    t12 = tb18 ? t12 : float(0.0);
    t6.x = max(t12, t6.x);
    t1.x = unity_World2Shadow[2][0].z;
    t1.y = unity_World2Shadow[2][1].z;
    t1.z = unity_World2Shadow[2][2].z;
    t1.w = unity_World2Shadow[2][3].z;
    t12 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t12) + vec3(-1.0, -3.0, -1.0);
    t12 = (-t1.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t18 = t1.z * 0.25 + -1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t18 + t12;
    t19 = (-t19) + 1.0;
    t19 = t19 * t10_3.z;
    t12 = t10_4.z * t12 + t19;
    t12 = t10_5.z * t18 + t12;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t12 = t12 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t12 = t12 * t1.x;
    t12 = tb18 ? t12 : float(0.0);
    t1.x = unity_World2Shadow[2][0].w;
    t1.y = unity_World2Shadow[2][1].w;
    t1.z = unity_World2Shadow[2][2].w;
    t1.w = unity_World2Shadow[2][3].w;
    t18 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t18) + vec3(-1.0, -3.0, -1.0);
    t18 = (-t1.z) * 0.25 + 1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t1.z * 0.25 + -1.0;
    t19 = clamp(t19, 0.0, 1.0);
    t14 = t18 + t19;
    t14 = (-t14) + 1.0;
    t14 = t14 * t10_3.w;
    t18 = t10_4.w * t18 + t14;
    t18 = t10_5.w * t19 + t18;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb13 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t18 = t18 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t18 = t18 * t1.x;
    t18 = tb13 ? t18 : float(0.0);
    t12 = max(t18, t12);
    t6.x = max(t12, t6.x);
    t0.x = max(t6.x, t0.x);
    t1.x = unity_World2Shadow[3][0].x;
    t1.y = unity_World2Shadow[3][1].x;
    t1.z = unity_World2Shadow[3][2].x;
    t1.w = unity_World2Shadow[3][3].x;
    t6.x = dot(t1, vs_TEXCOORD1);
    t6.xyz = t6.xxx + vec3(-1.0, -3.0, -1.0);
    t1.x = (-t6.z) * 0.25 + 1.0;
    t1.x = clamp(t1.x, 0.0, 1.0);
    t7 = t6.z * 0.25 + -1.0;
    t7 = clamp(t7, 0.0, 1.0);
    t13 = t7 + t1.x;
    t13 = (-t13) + 1.0;
    t10_3 = texture(unity_SplashScreenShadowTex7, t2.xy);
    t13 = t13 * t10_3.x;
    t10_4 = texture(unity_SplashScreenShadowTex6, t2.xy);
    t10_2 = texture(unity_SplashScreenShadowTex8, t2.xy);
    t1.x = t10_4.x * t1.x + t13;
    t1.x = t10_2.x * t7 + t1.x;
    t6.xy = t6.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t6.z;
    t6.xy = t6.xy;
    t6.xy = clamp(t6.xy, 0.0, 1.0);
    t6.x = t1.x * t6.x + (-t6.y);
    t12 = t6.y + 1.0;
    t6.x = t12 * t6.x;
    t6.x = tb18 ? t6.x : float(0.0);
    t1.x = unity_World2Shadow[3][0].y;
    t1.y = unity_World2Shadow[3][1].y;
    t1.z = unity_World2Shadow[3][2].y;
    t1.w = unity_World2Shadow[3][3].y;
    t12 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t12) + vec3(-1.0, -3.0, -1.0);
    t12 = (-t1.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t18 = t1.z * 0.25 + -1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t18 + t12;
    t19 = (-t19) + 1.0;
    t19 = t19 * t10_3.y;
    t12 = t10_4.y * t12 + t19;
    t12 = t10_2.y * t18 + t12;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t12 = t12 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t12 = t12 * t1.x;
    t12 = tb18 ? t12 : float(0.0);
    t6.x = max(t12, t6.x);
    t1.x = unity_World2Shadow[3][0].z;
    t1.y = unity_World2Shadow[3][1].z;
    t1.z = unity_World2Shadow[3][2].z;
    t1.w = unity_World2Shadow[3][3].z;
    t12 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t12) + vec3(-1.0, -3.0, -1.0);
    t12 = (-t1.z) * 0.25 + 1.0;
    t12 = clamp(t12, 0.0, 1.0);
    t18 = t1.z * 0.25 + -1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t18 + t12;
    t19 = (-t19) + 1.0;
    t19 = t19 * t10_3.z;
    t12 = t10_4.z * t12 + t19;
    t12 = t10_2.z * t18 + t12;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb18 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t12 = t12 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t12 = t12 * t1.x;
    t12 = tb18 ? t12 : float(0.0);
    t1.x = unity_World2Shadow[3][0].w;
    t1.y = unity_World2Shadow[3][1].w;
    t1.z = unity_World2Shadow[3][2].w;
    t1.w = unity_World2Shadow[3][3].w;
    t18 = dot(t1, vs_TEXCOORD1);
    t1.xyz = vec3(t18) + vec3(-1.0, -3.0, -1.0);
    t18 = (-t1.z) * 0.25 + 1.0;
    t18 = clamp(t18, 0.0, 1.0);
    t19 = t1.z * 0.25 + -1.0;
    t19 = clamp(t19, 0.0, 1.0);
    t2.x = t18 + t19;
    t2.x = (-t2.x) + 1.0;
    t2.x = t2.x * t10_3.w;
    t18 = t10_4.w * t18 + t2.x;
    t18 = t10_2.w * t19 + t18;
    t1.xy = t1.xy * vec2(0.5, 0.020833334);
    tb13 = 0.0<t1.z;
    t1.xy = t1.xy;
    t1.xy = clamp(t1.xy, 0.0, 1.0);
    t18 = t18 * t1.x + (-t1.y);
    t1.x = t1.y + 1.0;
    t18 = t18 * t1.x;
    t18 = tb13 ? t18 : float(0.0);
    t12 = max(t18, t12);
    t6.x = max(t12, t6.x);
    t0.x = max(t6.x, t0.x);
    t0.x = clamp(t0.x, 0.0, 1.0);
    t0.x = (-t0.x) + 1.0;
    t6.xyz = (-vs_TEXCOORD1.xyz) + unity_LightPosition0.xyzx.xyz;
    t1.x = dot(t6.xyz, t6.xyz);
    t1.x = inversesqrt(t1.x);
    t6.xyz = t6.xyz * t1.xxx;
    t6.x = dot(vs_TEXCOORD0.xyz, t6.xyz);
    t6.x = clamp(t6.x, 0.0, 1.0);
    t12 = t6.x * t6.x;
    t6.x = t12 * t6.x;
    t0.x = t0.x * t6.x;
    t6.xyz = unity_LightColor0.xyzx.xyz + (-unity_LightColor1.xyzx.xyz);
    t0.xyz = t0.xxx * t6.xyz + unity_LightColor1.xyzx.xyz;
    t0.w = 1.0;
    SV_Target0 = t0 * vs_COLOR0;
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
Matrix 8 [unity_World2Shadow2]
Matrix 12 [unity_World2Shadow3]
Vector 16 [unity_LightColor0]
Vector 17 [unity_LightColor1]
Vector 18 [unity_LightPosition0]
SetTexture 0 [unity_SplashScreenShadowTex0] 2D 0
SetTexture 1 [unity_SplashScreenShadowTex1] 2D 1
SetTexture 2 [unity_SplashScreenShadowTex2] 2D 2
SetTexture 3 [unity_SplashScreenShadowTex3] 2D 3
SetTexture 4 [unity_SplashScreenShadowTex4] 2D 4
SetTexture 5 [unity_SplashScreenShadowTex5] 2D 5
SetTexture 6 [unity_SplashScreenShadowTex6] 2D 6
SetTexture 7 [unity_SplashScreenShadowTex7] 2D 7
SetTexture 8 [unity_SplashScreenShadowTex8] 2D 8
"ps_3_0
def c19, 0.5, -1, -3, 0.020833334
def c20, 0.25, 1, -1, 0
dcl_texcoord v0.xyz
dcl_texcoord1 v1
dcl_color_pp v2
dcl_2d s0
dcl_2d s1
dcl_2d s2
dcl_2d s3
dcl_2d s4
dcl_2d s5
dcl_2d s6
dcl_2d s7
dcl_2d s8
dp4 r0.x, c4, v1
add r0.xyz, r0.x, c19.yzyw
mad_sat r0.w, r0.z, -c20.x, c20.y
mad_sat r1.x, r0.z, c20.x, c20.z
add r1.y, r0.w, r1.x
add r1.y, -r1.y, -c19.y
dp4 r1.z, c3, v1
rcp r1.z, r1.z
dp4 r2.x, c0, v1
dp4 r2.y, c1, v1
mul r1.zw, r1.z, r2.xyxy
mad r1.zw, r1, c19.x, c19.x
texld_pp r2, r1.zwzw, s1
mul r1.y, r1.y, r2.x
texld_pp r3, r1.zwzw, s0
mad r0.w, r3.x, r0.w, r1.y
texld_pp r4, r1.zwzw, s2
mad r0.w, r4.x, r1.x, r0.w
mul r0.xy, r0, c19.xwzw
mov_sat r0.xy, r0
mad r0.x, r0.w, r0.x, -r0.y
add r0.y, r0.y, -c19.y
mul r0.x, r0.y, r0.x
cmp r0.x, -r0.z, c20.w, r0.x
dp4 r0.y, c5, v1
add r0.yzw, r0.y, c19.xyzy
mad_sat r1.x, r0.w, -c20.x, c20.y
mad_sat r1.y, r0.w, c20.x, c20.z
add r2.x, r1.y, r1.x
add r2.x, -r2.x, -c19.y
mul r2.x, r2.x, r2.y
mad r1.x, r3.y, r1.x, r2.x
mad r1.x, r4.y, r1.y, r1.x
mul r0.yz, r0, c19.xxww
mov_sat r0.yz, r0
mad r0.y, r1.x, r0.y, -r0.z
add r0.z, r0.z, -c19.y
mul r0.y, r0.z, r0.y
cmp r0.y, -r0.w, c20.w, r0.y
max r1.x, r0.x, r0.y
dp4 r0.x, c6, v1
add r0.xyz, r0.x, c19.yzyw
mad_sat r0.w, r0.z, -c20.x, c20.y
mad_sat r1.y, r0.z, c20.x, c20.z
add r2.x, r0.w, r1.y
add r2.x, -r2.x, -c19.y
mul r2.x, r2.x, r2.z
mad r0.w, r3.z, r0.w, r2.x
mad r0.w, r4.z, r1.y, r0.w
mul r0.xy, r0, c19.xwzw
mov_sat r0.xy, r0
mad r0.x, r0.w, r0.x, -r0.y
add r0.y, r0.y, -c19.y
mul r0.x, r0.y, r0.x
cmp r0.x, -r0.z, c20.w, r0.x
dp4 r0.y, c7, v1
add r0.yzw, r0.y, c19.xyzy
mad_sat r1.y, r0.w, -c20.x, c20.y
mad_sat r2.x, r0.w, c20.x, c20.z
add r2.y, r1.y, r2.x
add r2.y, -r2.y, -c19.y
mul r2.y, r2.y, r2.w
mad r1.y, r3.w, r1.y, r2.y
mad r1.y, r4.w, r2.x, r1.y
mul r0.yz, r0, c19.xxww
mov_sat r0.yz, r0
mad r0.y, r1.y, r0.y, -r0.z
add r0.z, r0.z, -c19.y
mul r0.y, r0.z, r0.y
cmp r0.y, -r0.w, c20.w, r0.y
max r1.y, r0.x, r0.y
max r0.x, r1.x, r1.y
dp4 r0.y, c8, v1
add r0.yzw, r0.y, c19.xyzy
mad_sat r1.x, r0.w, -c20.x, c20.y
mad_sat r1.y, r0.w, c20.x, c20.z
add r2.x, r1.y, r1.x
add r2.x, -r2.x, -c19.y
texld_pp r3, r1.zwzw, s4
mul r2.x, r2.x, r3.x
texld_pp r4, r1.zwzw, s3
mad r1.x, r4.x, r1.x, r2.x
texld_pp r2, r1.zwzw, s5
mad r1.x, r2.x, r1.y, r1.x
mul r0.yz, r0, c19.xxww
mov_sat r0.yz, r0
mad r0.y, r1.x, r0.y, -r0.z
add r0.z, r0.z, -c19.y
mul r0.y, r0.z, r0.y
cmp r0.y, -r0.w, c20.w, r0.y
dp4 r0.z, c9, v1
add r5.xyz, r0.z, c19.yzyw
mad_sat r0.z, r5.z, -c20.x, c20.y
mad_sat r0.w, r5.z, c20.x, c20.z
add r1.x, r0.w, r0.z
add r1.x, -r1.x, -c19.y
mul r1.x, r1.x, r3.y
mad r0.z, r4.y, r0.z, r1.x
mad r0.z, r2.y, r0.w, r0.z
mul r1.xy, r5, c19.xwzw
mov_sat r1.xy, r1
mad r0.z, r0.z, r1.x, -r1.y
add r0.w, r1.y, -c19.y
mul r0.z, r0.w, r0.z
cmp r0.z, -r5.z, c20.w, r0.z
max r1.x, r0.y, r0.z
dp4 r0.y, c10, v1
add r0.yzw, r0.y, c19.xyzy
mad_sat r1.y, r0.w, -c20.x, c20.y
mad_sat r2.x, r0.w, c20.x, c20.z
add r2.y, r1.y, r2.x
add r2.y, -r2.y, -c19.y
mul r2.y, r2.y, r3.z
mad r1.y, r4.z, r1.y, r2.y
mad r1.y, r2.z, r2.x, r1.y
mul r0.yz, r0, c19.xxww
mov_sat r0.yz, r0
mad r0.y, r1.y, r0.y, -r0.z
add r0.z, r0.z, -c19.y
mul r0.y, r0.z, r0.y
cmp r0.y, -r0.w, c20.w, r0.y
dp4 r0.z, c11, v1
add r2.xyz, r0.z, c19.yzyw
mad_sat r0.z, r2.z, -c20.x, c20.y
mad_sat r0.w, r2.z, c20.x, c20.z
add r1.y, r0.w, r0.z
add r1.y, -r1.y, -c19.y
mul r1.y, r1.y, r3.w
mad r0.z, r4.w, r0.z, r1.y
mad r0.z, r2.w, r0.w, r0.z
mul r2.xy, r2, c19.xwzw
mov_sat r2.xy, r2
mad r0.z, r0.z, r2.x, -r2.y
add r0.w, r2.y, -c19.y
mul r0.z, r0.w, r0.z
cmp r0.z, -r2.z, c20.w, r0.z
max r1.y, r0.y, r0.z
max r0.y, r1.x, r1.y
max r1.x, r0.x, r0.y
texld_pp r0, r1.zwzw, s7
dp4 r1.y, c12, v1
add r2.xyz, r1.y, c19.yzyw
mad_sat r1.y, r2.z, -c20.x, c20.y
mad_sat r2.w, r2.z, c20.x, c20.z
add r3.x, r1.y, r2.w
add r3.x, -r3.x, -c19.y
mul r0.x, r0.x, r3.x
texld_pp r3, r1.zwzw, s6
texld_pp r4, r1.zwzw, s8
mad r0.x, r3.x, r1.y, r0.x
mad r0.x, r4.x, r2.w, r0.x
mul r1.yz, r2.xxyw, c19.xxww
mov_sat r1.yz, r1
mad r0.x, r0.x, r1.y, -r1.z
add r1.y, r1.z, -c19.y
mul r0.x, r0.x, r1.y
cmp r0.x, -r2.z, c20.w, r0.x
dp4 r1.y, c13, v1
add r1.yzw, r1.y, c19.xyzy
mad_sat r2.x, r1.w, -c20.x, c20.y
mad_sat r2.y, r1.w, c20.x, c20.z
add r2.z, r2.y, r2.x
add r2.z, -r2.z, -c19.y
mul r0.y, r0.y, r2.z
mad r0.y, r3.y, r2.x, r0.y
mad r0.y, r4.y, r2.y, r0.y
mul r1.yz, r1, c19.xxww
mov_sat r1.yz, r1
mad r0.y, r0.y, r1.y, -r1.z
add r1.y, r1.z, -c19.y
mul r0.y, r0.y, r1.y
cmp r0.y, -r1.w, c20.w, r0.y
max r1.y, r0.x, r0.y
dp4 r0.x, c14, v1
add r2.xyz, r0.x, c19.yzyw
mad_sat r0.x, r2.z, -c20.x, c20.y
mad_sat r0.y, r2.z, c20.x, c20.z
add r1.z, r0.y, r0.x
add r1.z, -r1.z, -c19.y
mul r0.z, r0.z, r1.z
mad r0.x, r3.z, r0.x, r0.z
mad r0.x, r4.z, r0.y, r0.x
mul r0.yz, r2.xxyw, c19.xxww
mov_sat r0.yz, r0
mad r0.x, r0.x, r0.y, -r0.z
add r0.y, r0.z, -c19.y
mul r0.x, r0.y, r0.x
cmp r0.x, -r2.z, c20.w, r0.x
dp4 r0.y, c15, v1
add r2.xyz, r0.y, c19.yzyw
mad_sat r0.y, r2.z, -c20.x, c20.y
mad_sat r0.z, r2.z, c20.x, c20.z
add r1.z, r0.z, r0.y
add r1.z, -r1.z, -c19.y
mul r0.w, r0.w, r1.z
mad r0.y, r3.w, r0.y, r0.w
mad r0.y, r4.w, r0.z, r0.y
mul r0.zw, r2.xyxy, c19.xyxw
mov_sat r0.zw, r0
mad r0.y, r0.y, r0.z, -r0.w
add r0.z, r0.w, -c19.y
mul r0.y, r0.z, r0.y
cmp r0.y, -r2.z, c20.w, r0.y
max r1.z, r0.x, r0.y
max r0.x, r1.y, r1.z
max_sat r2.x, r1.x, r0.x
add r0.x, -r2.x, -c19.y
add r0.yzw, c18.xxyz, -v1.xxyz
nrm r1.xyz, r0.yzww
dp3_sat r0.y, v0, r1
mul r0.z, r0.y, r0.y
mul r0.y, r0.z, r0.y
mul_pp r0.x, r0.x, r0.y
mov r1.xyz, c17
add_pp r0.yzw, -r1.xxyz, c16.xxyz
mad_pp r0.xyz, r0.x, r0.yzww, c17
mov r0.w, -c19.y
mul_pp oC0, r0, v2

"
}
SubProgram "d3d11 " {
SetTexture 0 [unity_SplashScreenShadowTex0] 2D 0
SetTexture 1 [unity_SplashScreenShadowTex1] 2D 1
SetTexture 2 [unity_SplashScreenShadowTex2] 2D 2
SetTexture 3 [unity_SplashScreenShadowTex3] 2D 3
SetTexture 4 [unity_SplashScreenShadowTex4] 2D 4
SetTexture 5 [unity_SplashScreenShadowTex5] 2D 5
SetTexture 6 [unity_SplashScreenShadowTex6] 2D 6
SetTexture 7 [unity_SplashScreenShadowTex7] 2D 7
SetTexture 8 [unity_SplashScreenShadowTex8] 2D 8
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
root12:ajadajaa
eefiecedgaopngbnnmlkocbjjiioelbdhmgfjfemabaaaaaapmcdaaaaadaaaaaa
cmaaaaaaliaaaaaaomaaaaaaejfdeheoieaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaabaaaaaaadaaaaaaaaaaaaaaapaaaaaaheaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaaheaaaaaaabaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahnaaaaaaaaaaaaaaaaaaaaaaadaaaaaaadaaaaaaapapaaaafdfgfpfa
epfdejfeejepeoaafeeffiedepepfceeaaedepemepfcaaklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklklfdeieefcaicdaaaaeaaaaaaamcaiaaaafjaaaaae
egiocaaaaaaaaaaaabaaaaaafjaaaaaeegiocaaaabaaaaaaacaaaaaafjaaaaae
egiocaaaacaaaaaabiaaaaaafkaaaaadaagabaaaaaaaaaaafkaaaaadaagabaaa
abaaaaaafkaaaaadaagabaaaacaaaaaafkaaaaadaagabaaaadaaaaaafkaaaaad
aagabaaaaeaaaaaafkaaaaadaagabaaaafaaaaaafkaaaaadaagabaaaagaaaaaa
fkaaaaadaagabaaaahaaaaaafkaaaaadaagabaaaaiaaaaaafibiaaaeaahabaaa
aaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaafibiaaaeaahabaaa
acaaaaaaffffaaaafibiaaaeaahabaaaadaaaaaaffffaaaafibiaaaeaahabaaa
aeaaaaaaffffaaaafibiaaaeaahabaaaafaaaaaaffffaaaafibiaaaeaahabaaa
agaaaaaaffffaaaafibiaaaeaahabaaaahaaaaaaffffaaaafibiaaaeaahabaaa
aiaaaaaaffffaaaagcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaa
gcbaaaadpcbabaaaadaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacagaaaaaa
dgaaaaagbcaabaaaaaaaaaaaakiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaa
aaaaaaaaakiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaaaaaaaaaakiacaaa
acaaaaaaaoaaaaaadgaaaaagicaabaaaaaaaaaaaakiacaaaacaaaaaaapaaaaaa
bbaaaaahbcaabaaaaaaaaaaaegaobaaaaaaaaaaaegbobaaaacaaaaaaaaaaaaak
hcaabaaaaaaaaaaaagaabaaaaaaaaaaaaceaaaaaaaaaialpaaaaeamaaaaaialp
aaaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaaaaaaaaaackaabaaaaaaaaaaa
diaaaaakdcaabaaaaaaaaaaaegaabaaaaaaaaaaaaceaaaaaaaaaaadpklkkkkdm
aaaaaaaaaaaaaaaadgcaaaafdcaabaaaaaaaaaaaegaabaaaaaaaaaaaaaaaaaah
bcaabaaaabaaaaaabkaabaaaaaaaaaaaabeaaaaaaaaaiadpdccaaaajccaabaaa
abaaaaaackaabaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaialpdccaaaak
ecaabaaaaaaaaaaackaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaa
aaaaiadpaaaaaaahecaabaaaabaaaaaabkaabaaaabaaaaaackaabaaaaaaaaaaa
aaaaaaaiecaabaaaabaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadp
diaaaaaihcaabaaaacaaaaaafgbfbaaaacaaaaaaegidcaaaacaaaaaaajaaaaaa
dcaaaaakhcaabaaaacaaaaaaegidcaaaacaaaaaaaiaaaaaaagbabaaaacaaaaaa
egacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegidcaaaacaaaaaaakaaaaaa
kgbkbaaaacaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegidcaaa
acaaaaaaalaaaaaapgbpbaaaacaaaaaaegacbaaaacaaaaaaaoaaaaahdcaabaaa
acaaaaaaegaabaaaacaaaaaakgakbaaaacaaaaaadcaaaaapdcaabaaaacaaaaaa
egaabaaaacaaaaaaaceaaaaaaaaaaadpaaaaaadpaaaaaaaaaaaaaaaaaceaaaaa
aaaaaadpaaaaaadpaaaaaaaaaaaaaaaaefaaaaajpcaabaaaadaaaaaaegaabaaa
acaaaaaaeghobaaaabaaaaaaaagabaaaabaaaaaadiaaaaahecaabaaaabaaaaaa
ckaabaaaabaaaaaaakaabaaaadaaaaaaefaaaaajpcaabaaaaeaaaaaaegaabaaa
acaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaajecaabaaaaaaaaaaa
akaabaaaaeaaaaaackaabaaaaaaaaaaackaabaaaabaaaaaaefaaaaajpcaabaaa
afaaaaaaegaabaaaacaaaaaaeghobaaaacaaaaaaaagabaaaacaaaaaadcaaaaaj
ecaabaaaaaaaaaaaakaabaaaafaaaaaabkaabaaaabaaaaaackaabaaaaaaaaaaa
dcaaaaakbcaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaadiaaaaahbcaabaaaaaaaaaaaakaabaaaabaaaaaaakaabaaa
aaaaaaaaabaaaaahbcaabaaaaaaaaaaaakaabaaaaaaaaaaadkaabaaaaaaaaaaa
dgaaaaagbcaabaaaabaaaaaabkiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaa
abaaaaaabkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaabaaaaaabkiacaaa
acaaaaaaaoaaaaaadgaaaaagicaabaaaabaaaaaabkiacaaaacaaaaaaapaaaaaa
bbaaaaahccaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaak
ocaabaaaaaaaaaaafgafbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaialpaaaaeama
aaaaialpdccaaaakbcaabaaaabaaaaaadkaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaiadpdccaaaajccaabaaaabaaaaaadkaabaaaaaaaaaaa
abeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaahecaabaaaabaaaaaabkaabaaa
abaaaaaaakaabaaaabaaaaaaaaaaaaaiecaabaaaabaaaaaackaabaiaebaaaaaa
abaaaaaaabeaaaaaaaaaiadpdiaaaaahecaabaaaabaaaaaackaabaaaabaaaaaa
bkaabaaaadaaaaaadcaaaaajbcaabaaaabaaaaaabkaabaaaaeaaaaaaakaabaaa
abaaaaaackaabaaaabaaaaaadcaaaaajbcaabaaaabaaaaaabkaabaaaafaaaaaa
bkaabaaaabaaaaaaakaabaaaabaaaaaadiaaaaakgcaabaaaaaaaaaaafgagbaaa
aaaaaaaaaceaaaaaaaaaaaaaaaaaaadpklkkkkdmaaaaaaaadbaaaaahicaabaaa
aaaaaaaaabeaaaaaaaaaaaaadkaabaaaaaaaaaaadgcaaaafgcaabaaaaaaaaaaa
fgagbaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaaa
aaaaaaaackaabaiaebaaaaaaaaaaaaaaaaaaaaahecaabaaaaaaaaaaackaabaaa
aaaaaaaaabeaaaaaaaaaiadpdiaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaaabaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaadkaabaaa
aaaaaaaadeaaaaahbcaabaaaaaaaaaaabkaabaaaaaaaaaaaakaabaaaaaaaaaaa
dgaaaaagbcaabaaaabaaaaaackiacaaaacaaaaaaamaaaaaadgaaaaagccaabaaa
abaaaaaackiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaabaaaaaackiacaaa
acaaaaaaaoaaaaaadgaaaaagicaabaaaabaaaaaackiacaaaacaaaaaaapaaaaaa
bbaaaaahccaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaak
ocaabaaaaaaaaaaafgafbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaialpaaaaeama
aaaaialpdccaaaakbcaabaaaabaaaaaadkaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaiadpdccaaaajccaabaaaabaaaaaadkaabaaaaaaaaaaa
abeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaahecaabaaaabaaaaaabkaabaaa
abaaaaaaakaabaaaabaaaaaaaaaaaaaiecaabaaaabaaaaaackaabaiaebaaaaaa
abaaaaaaabeaaaaaaaaaiadpdiaaaaahecaabaaaabaaaaaackaabaaaabaaaaaa
ckaabaaaadaaaaaadcaaaaajbcaabaaaabaaaaaackaabaaaaeaaaaaaakaabaaa
abaaaaaackaabaaaabaaaaaadcaaaaajbcaabaaaabaaaaaackaabaaaafaaaaaa
bkaabaaaabaaaaaaakaabaaaabaaaaaadiaaaaakgcaabaaaaaaaaaaafgagbaaa
aaaaaaaaaceaaaaaaaaaaaaaaaaaaadpklkkkkdmaaaaaaaadbaaaaahicaabaaa
aaaaaaaaabeaaaaaaaaaaaaadkaabaaaaaaaaaaadgcaaaafgcaabaaaaaaaaaaa
fgagbaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaaa
aaaaaaaackaabaiaebaaaaaaaaaaaaaaaaaaaaahecaabaaaaaaaaaaackaabaaa
aaaaaaaaabeaaaaaaaaaiadpdiaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaaabaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaadkaabaaa
aaaaaaaadgaaaaagbcaabaaaabaaaaaadkiacaaaacaaaaaaamaaaaaadgaaaaag
ccaabaaaabaaaaaadkiacaaaacaaaaaaanaaaaaadgaaaaagecaabaaaabaaaaaa
dkiacaaaacaaaaaaaoaaaaaadgaaaaagicaabaaaabaaaaaadkiacaaaacaaaaaa
apaaaaaabbaaaaahecaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaa
aaaaaaakhcaabaaaabaaaaaakgakbaaaaaaaaaaaaceaaaaaaaaaialpaaaaeama
aaaaialpaaaaaaaadccaaaakecaabaaaaaaaaaaackaabaiaebaaaaaaabaaaaaa
abeaaaaaaaaaiadoabeaaaaaaaaaiadpdccaaaajicaabaaaaaaaaaaackaabaaa
abaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaahicaabaaaabaaaaaa
dkaabaaaaaaaaaaackaabaaaaaaaaaaaaaaaaaaiicaabaaaabaaaaaadkaabaia
ebaaaaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaahicaabaaaabaaaaaadkaabaaa
abaaaaaadkaabaaaadaaaaaadcaaaaajecaabaaaaaaaaaaadkaabaaaaeaaaaaa
ckaabaaaaaaaaaaadkaabaaaabaaaaaadcaaaaajecaabaaaaaaaaaaadkaabaaa
afaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaadiaaaaakdcaabaaaabaaaaaa
egaabaaaabaaaaaaaceaaaaaaaaaaadpklkkkkdmaaaaaaaaaaaaaaaadbaaaaah
icaabaaaaaaaaaaaabeaaaaaaaaaaaaackaabaaaabaaaaaadgcaaaafdcaabaaa
abaaaaaaegaabaaaabaaaaaadcaaaaakecaabaaaaaaaaaaackaabaaaaaaaaaaa
akaabaaaabaaaaaabkaabaiaebaaaaaaabaaaaaaaaaaaaahbcaabaaaabaaaaaa
bkaabaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaahecaabaaaaaaaaaaackaabaaa
aaaaaaaaakaabaaaabaaaaaaabaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaa
dkaabaaaaaaaaaaadeaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaa
aaaaaaaadeaaaaahbcaabaaaaaaaaaaabkaabaaaaaaaaaaaakaabaaaaaaaaaaa
dgaaaaagbcaabaaaabaaaaaaakiacaaaacaaaaaabaaaaaaadgaaaaagccaabaaa
abaaaaaaakiacaaaacaaaaaabbaaaaaadgaaaaagecaabaaaabaaaaaaakiacaaa
acaaaaaabcaaaaaadgaaaaagicaabaaaabaaaaaaakiacaaaacaaaaaabdaaaaaa
bbaaaaahccaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaak
ocaabaaaaaaaaaaafgafbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaialpaaaaeama
aaaaialpdccaaaakbcaabaaaabaaaaaadkaabaiaebaaaaaaaaaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaiadpdccaaaajccaabaaaabaaaaaadkaabaaaaaaaaaaa
abeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaahecaabaaaabaaaaaabkaabaaa
abaaaaaaakaabaaaabaaaaaaaaaaaaaiecaabaaaabaaaaaackaabaiaebaaaaaa
abaaaaaaabeaaaaaaaaaiadpefaaaaajpcaabaaaadaaaaaaegaabaaaacaaaaaa
eghobaaaaeaaaaaaaagabaaaaeaaaaaadiaaaaahecaabaaaabaaaaaackaabaaa
abaaaaaaakaabaaaadaaaaaaefaaaaajpcaabaaaaeaaaaaaegaabaaaacaaaaaa
eghobaaaadaaaaaaaagabaaaadaaaaaadcaaaaajbcaabaaaabaaaaaaakaabaaa
aeaaaaaaakaabaaaabaaaaaackaabaaaabaaaaaaefaaaaajpcaabaaaafaaaaaa
egaabaaaacaaaaaaeghobaaaafaaaaaaaagabaaaafaaaaaadcaaaaajbcaabaaa
abaaaaaaakaabaaaafaaaaaabkaabaaaabaaaaaaakaabaaaabaaaaaadiaaaaak
gcaabaaaaaaaaaaafgagbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaaadpklkkkkdm
aaaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaaaaaaaaaadkaabaaaaaaaaaaa
dgcaaaafgcaabaaaaaaaaaaafgagbaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaa
akaabaaaabaaaaaabkaabaaaaaaaaaaackaabaiaebaaaaaaaaaaaaaaaaaaaaah
ecaabaaaaaaaaaaackaabaaaaaaaaaaaabeaaaaaaaaaiadpdiaaaaahccaabaaa
aaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaaabaaaaahccaabaaaaaaaaaaa
bkaabaaaaaaaaaaadkaabaaaaaaaaaaadgaaaaagbcaabaaaabaaaaaabkiacaaa
acaaaaaabaaaaaaadgaaaaagccaabaaaabaaaaaabkiacaaaacaaaaaabbaaaaaa
dgaaaaagecaabaaaabaaaaaabkiacaaaacaaaaaabcaaaaaadgaaaaagicaabaaa
abaaaaaabkiacaaaacaaaaaabdaaaaaabbaaaaahecaabaaaaaaaaaaaegaobaaa
abaaaaaaegbobaaaacaaaaaaaaaaaaakhcaabaaaabaaaaaakgakbaaaaaaaaaaa
aceaaaaaaaaaialpaaaaeamaaaaaialpaaaaaaaadccaaaakecaabaaaaaaaaaaa
ckaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpdccaaaaj
icaabaaaaaaaaaaackaabaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaialp
aaaaaaahicaabaaaabaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaaaaaaaaai
icaabaaaabaaaaaadkaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaah
icaabaaaabaaaaaadkaabaaaabaaaaaabkaabaaaadaaaaaadcaaaaajecaabaaa
aaaaaaaabkaabaaaaeaaaaaackaabaaaaaaaaaaadkaabaaaabaaaaaadcaaaaaj
ecaabaaaaaaaaaaabkaabaaaafaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaa
diaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaaaceaaaaaaaaaaadpklkkkkdm
aaaaaaaaaaaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaaaaaaaaaackaabaaa
abaaaaaadgcaaaafdcaabaaaabaaaaaaegaabaaaabaaaaaadcaaaaakecaabaaa
aaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaiaebaaaaaaabaaaaaa
aaaaaaahbcaabaaaabaaaaaabkaabaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaah
ecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaaabaaaaahecaabaaa
aaaaaaaackaabaaaaaaaaaaadkaabaaaaaaaaaaadeaaaaahccaabaaaaaaaaaaa
ckaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaagbcaabaaaabaaaaaackiacaaa
acaaaaaabaaaaaaadgaaaaagccaabaaaabaaaaaackiacaaaacaaaaaabbaaaaaa
dgaaaaagecaabaaaabaaaaaackiacaaaacaaaaaabcaaaaaadgaaaaagicaabaaa
abaaaaaackiacaaaacaaaaaabdaaaaaabbaaaaahecaabaaaaaaaaaaaegaobaaa
abaaaaaaegbobaaaacaaaaaaaaaaaaakhcaabaaaabaaaaaakgakbaaaaaaaaaaa
aceaaaaaaaaaialpaaaaeamaaaaaialpaaaaaaaadccaaaakecaabaaaaaaaaaaa
ckaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpdccaaaaj
icaabaaaaaaaaaaackaabaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaialp
aaaaaaahicaabaaaabaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaaaaaaaaai
icaabaaaabaaaaaadkaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaah
icaabaaaabaaaaaadkaabaaaabaaaaaackaabaaaadaaaaaadcaaaaajecaabaaa
aaaaaaaackaabaaaaeaaaaaackaabaaaaaaaaaaadkaabaaaabaaaaaadcaaaaaj
ecaabaaaaaaaaaaackaabaaaafaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaa
diaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaaaceaaaaaaaaaaadpklkkkkdm
aaaaaaaaaaaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaaaaaaaaaackaabaaa
abaaaaaadgcaaaafdcaabaaaabaaaaaaegaabaaaabaaaaaadcaaaaakecaabaaa
aaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaiaebaaaaaaabaaaaaa
aaaaaaahbcaabaaaabaaaaaabkaabaaaabaaaaaaabeaaaaaaaaaiadpdiaaaaah
ecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaaabaaaaahecaabaaa
aaaaaaaackaabaaaaaaaaaaadkaabaaaaaaaaaaadgaaaaagbcaabaaaabaaaaaa
dkiacaaaacaaaaaabaaaaaaadgaaaaagccaabaaaabaaaaaadkiacaaaacaaaaaa
bbaaaaaadgaaaaagecaabaaaabaaaaaadkiacaaaacaaaaaabcaaaaaadgaaaaag
icaabaaaabaaaaaadkiacaaaacaaaaaabdaaaaaabbaaaaahicaabaaaaaaaaaaa
egaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaakhcaabaaaabaaaaaapgapbaaa
aaaaaaaaaceaaaaaaaaaialpaaaaeamaaaaaialpaaaaaaaadccaaaakicaabaaa
aaaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadp
dccaaaajicaabaaaabaaaaaackaabaaaabaaaaaaabeaaaaaaaaaiadoabeaaaaa
aaaaialpaaaaaaahecaabaaaacaaaaaadkaabaaaaaaaaaaadkaabaaaabaaaaaa
aaaaaaaiecaabaaaacaaaaaackaabaiaebaaaaaaacaaaaaaabeaaaaaaaaaiadp
diaaaaahecaabaaaacaaaaaackaabaaaacaaaaaadkaabaaaadaaaaaadcaaaaaj
icaabaaaaaaaaaaadkaabaaaaeaaaaaadkaabaaaaaaaaaaackaabaaaacaaaaaa
dcaaaaajicaabaaaaaaaaaaadkaabaaaafaaaaaadkaabaaaabaaaaaadkaabaaa
aaaaaaaadiaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaaaceaaaaaaaaaaadp
klkkkkdmaaaaaaaaaaaaaaaadbaaaaahecaabaaaabaaaaaaabeaaaaaaaaaaaaa
ckaabaaaabaaaaaadgcaaaafdcaabaaaabaaaaaaegaabaaaabaaaaaadcaaaaak
icaabaaaaaaaaaaadkaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaiaebaaaaaa
abaaaaaaaaaaaaahbcaabaaaabaaaaaabkaabaaaabaaaaaaabeaaaaaaaaaiadp
diaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaaakaabaaaabaaaaaaabaaaaah
icaabaaaaaaaaaaadkaabaaaaaaaaaaackaabaaaabaaaaaadeaaaaahecaabaaa
aaaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaadeaaaaahccaabaaaaaaaaaaa
ckaabaaaaaaaaaaabkaabaaaaaaaaaaadeaaaaahbcaabaaaaaaaaaaabkaabaaa
aaaaaaaaakaabaaaaaaaaaaadgaaaaagbcaabaaaabaaaaaaakiacaaaacaaaaaa
beaaaaaadgaaaaagccaabaaaabaaaaaaakiacaaaacaaaaaabfaaaaaadgaaaaag
ecaabaaaabaaaaaaakiacaaaacaaaaaabgaaaaaadgaaaaagicaabaaaabaaaaaa
akiacaaaacaaaaaabhaaaaaabbaaaaahccaabaaaaaaaaaaaegaobaaaabaaaaaa
egbobaaaacaaaaaaaaaaaaakocaabaaaaaaaaaaafgafbaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaialpaaaaeamaaaaaialpdccaaaakbcaabaaaabaaaaaadkaabaia
ebaaaaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaiadpdccaaaajccaabaaa
abaaaaaadkaabaaaaaaaaaaaabeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaah
ecaabaaaabaaaaaabkaabaaaabaaaaaaakaabaaaabaaaaaaaaaaaaaiecaabaaa
abaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiadpefaaaaajpcaabaaa
adaaaaaaegaabaaaacaaaaaaeghobaaaahaaaaaaaagabaaaahaaaaaadiaaaaah
ecaabaaaabaaaaaackaabaaaabaaaaaaakaabaaaadaaaaaaefaaaaajpcaabaaa
aeaaaaaaegaabaaaacaaaaaaeghobaaaagaaaaaaaagabaaaagaaaaaaefaaaaaj
pcaabaaaacaaaaaaegaabaaaacaaaaaaeghobaaaaiaaaaaaaagabaaaaiaaaaaa
dcaaaaajbcaabaaaabaaaaaaakaabaaaaeaaaaaaakaabaaaabaaaaaackaabaaa
abaaaaaadcaaaaajbcaabaaaabaaaaaaakaabaaaacaaaaaabkaabaaaabaaaaaa
akaabaaaabaaaaaadiaaaaakgcaabaaaaaaaaaaafgagbaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaadpklkkkkdmaaaaaaaadbaaaaahicaabaaaaaaaaaaaabeaaaaa
aaaaaaaadkaabaaaaaaaaaaadgcaaaafgcaabaaaaaaaaaaafgagbaaaaaaaaaaa
dcaaaaakccaabaaaaaaaaaaaakaabaaaabaaaaaabkaabaaaaaaaaaaackaabaia
ebaaaaaaaaaaaaaaaaaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaaabeaaaaa
aaaaiadpdiaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaa
abaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaadkaabaaaaaaaaaaadgaaaaag
bcaabaaaabaaaaaabkiacaaaacaaaaaabeaaaaaadgaaaaagccaabaaaabaaaaaa
bkiacaaaacaaaaaabfaaaaaadgaaaaagecaabaaaabaaaaaabkiacaaaacaaaaaa
bgaaaaaadgaaaaagicaabaaaabaaaaaabkiacaaaacaaaaaabhaaaaaabbaaaaah
ecaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaakhcaabaaa
abaaaaaakgakbaaaaaaaaaaaaceaaaaaaaaaialpaaaaeamaaaaaialpaaaaaaaa
dccaaaakecaabaaaaaaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiado
abeaaaaaaaaaiadpdccaaaajicaabaaaaaaaaaaackaabaaaabaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaialpaaaaaaahicaabaaaabaaaaaadkaabaaaaaaaaaaa
ckaabaaaaaaaaaaaaaaaaaaiicaabaaaabaaaaaadkaabaiaebaaaaaaabaaaaaa
abeaaaaaaaaaiadpdiaaaaahicaabaaaabaaaaaadkaabaaaabaaaaaabkaabaaa
adaaaaaadcaaaaajecaabaaaaaaaaaaabkaabaaaaeaaaaaackaabaaaaaaaaaaa
dkaabaaaabaaaaaadcaaaaajecaabaaaaaaaaaaabkaabaaaacaaaaaadkaabaaa
aaaaaaaackaabaaaaaaaaaaadiaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaa
aceaaaaaaaaaaadpklkkkkdmaaaaaaaaaaaaaaaadbaaaaahicaabaaaaaaaaaaa
abeaaaaaaaaaaaaackaabaaaabaaaaaadgcaaaafdcaabaaaabaaaaaaegaabaaa
abaaaaaadcaaaaakecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaa
bkaabaiaebaaaaaaabaaaaaaaaaaaaahbcaabaaaabaaaaaabkaabaaaabaaaaaa
abeaaaaaaaaaiadpdiaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaa
abaaaaaaabaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaadkaabaaaaaaaaaaa
deaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaag
bcaabaaaabaaaaaackiacaaaacaaaaaabeaaaaaadgaaaaagccaabaaaabaaaaaa
ckiacaaaacaaaaaabfaaaaaadgaaaaagecaabaaaabaaaaaackiacaaaacaaaaaa
bgaaaaaadgaaaaagicaabaaaabaaaaaackiacaaaacaaaaaabhaaaaaabbaaaaah
ecaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaakhcaabaaa
abaaaaaakgakbaaaaaaaaaaaaceaaaaaaaaaialpaaaaeamaaaaaialpaaaaaaaa
dccaaaakecaabaaaaaaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaaaaaaiado
abeaaaaaaaaaiadpdccaaaajicaabaaaaaaaaaaackaabaaaabaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaialpaaaaaaahicaabaaaabaaaaaadkaabaaaaaaaaaaa
ckaabaaaaaaaaaaaaaaaaaaiicaabaaaabaaaaaadkaabaiaebaaaaaaabaaaaaa
abeaaaaaaaaaiadpdiaaaaahicaabaaaabaaaaaadkaabaaaabaaaaaackaabaaa
adaaaaaadcaaaaajecaabaaaaaaaaaaackaabaaaaeaaaaaackaabaaaaaaaaaaa
dkaabaaaabaaaaaadcaaaaajecaabaaaaaaaaaaackaabaaaacaaaaaadkaabaaa
aaaaaaaackaabaaaaaaaaaaadiaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaa
aceaaaaaaaaaaadpklkkkkdmaaaaaaaaaaaaaaaadbaaaaahicaabaaaaaaaaaaa
abeaaaaaaaaaaaaackaabaaaabaaaaaadgcaaaafdcaabaaaabaaaaaaegaabaaa
abaaaaaadcaaaaakecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaaabaaaaaa
bkaabaiaebaaaaaaabaaaaaaaaaaaaahbcaabaaaabaaaaaabkaabaaaabaaaaaa
abeaaaaaaaaaiadpdiaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaaakaabaaa
abaaaaaaabaaaaahecaabaaaaaaaaaaackaabaaaaaaaaaaadkaabaaaaaaaaaaa
dgaaaaagbcaabaaaabaaaaaadkiacaaaacaaaaaabeaaaaaadgaaaaagccaabaaa
abaaaaaadkiacaaaacaaaaaabfaaaaaadgaaaaagecaabaaaabaaaaaadkiacaaa
acaaaaaabgaaaaaadgaaaaagicaabaaaabaaaaaadkiacaaaacaaaaaabhaaaaaa
bbaaaaahicaabaaaaaaaaaaaegaobaaaabaaaaaaegbobaaaacaaaaaaaaaaaaak
hcaabaaaabaaaaaapgapbaaaaaaaaaaaaceaaaaaaaaaialpaaaaeamaaaaaialp
aaaaaaaadccaaaakicaabaaaaaaaaaaackaabaiaebaaaaaaabaaaaaaabeaaaaa
aaaaiadoabeaaaaaaaaaiadpdccaaaajicaabaaaabaaaaaackaabaaaabaaaaaa
abeaaaaaaaaaiadoabeaaaaaaaaaialpaaaaaaahbcaabaaaacaaaaaadkaabaaa
aaaaaaaadkaabaaaabaaaaaaaaaaaaaibcaabaaaacaaaaaaakaabaiaebaaaaaa
acaaaaaaabeaaaaaaaaaiadpdiaaaaahbcaabaaaacaaaaaaakaabaaaacaaaaaa
dkaabaaaadaaaaaadcaaaaajicaabaaaaaaaaaaadkaabaaaaeaaaaaadkaabaaa
aaaaaaaaakaabaaaacaaaaaadcaaaaajicaabaaaaaaaaaaadkaabaaaacaaaaaa
dkaabaaaabaaaaaadkaabaaaaaaaaaaadiaaaaakdcaabaaaabaaaaaaegaabaaa
abaaaaaaaceaaaaaaaaaaadpklkkkkdmaaaaaaaaaaaaaaaadbaaaaahecaabaaa
abaaaaaaabeaaaaaaaaaaaaackaabaaaabaaaaaadgcaaaafdcaabaaaabaaaaaa
egaabaaaabaaaaaadcaaaaakicaabaaaaaaaaaaadkaabaaaaaaaaaaaakaabaaa
abaaaaaabkaabaiaebaaaaaaabaaaaaaaaaaaaahbcaabaaaabaaaaaabkaabaaa
abaaaaaaabeaaaaaaaaaiadpdiaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaa
akaabaaaabaaaaaaabaaaaahicaabaaaaaaaaaaadkaabaaaaaaaaaaackaabaaa
abaaaaaadeaaaaahecaabaaaaaaaaaaadkaabaaaaaaaaaaackaabaaaaaaaaaaa
deaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadecaaaah
bcaabaaaaaaaaaaabkaabaaaaaaaaaaaakaabaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaaakaabaiaebaaaaaaaaaaaaaaabeaaaaaaaaaiadpaaaaaaajocaabaaa
aaaaaaaaagbjbaiaebaaaaaaacaaaaaaagijcaaaaaaaaaaaaaaaaaaabaaaaaah
bcaabaaaabaaaaaajgahbaaaaaaaaaaajgahbaaaaaaaaaaaeeaaaaafbcaabaaa
abaaaaaaakaabaaaabaaaaaadiaaaaahocaabaaaaaaaaaaafgaobaaaaaaaaaaa
agaabaaaabaaaaaabacaaaahccaabaaaaaaaaaaaegbcbaaaabaaaaaajgahbaaa
aaaaaaaadiaaaaahecaabaaaaaaaaaaabkaabaaaaaaaaaaabkaabaaaaaaaaaaa
diaaaaahccaabaaaaaaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadiaaaaah
bcaabaaaaaaaaaaaakaabaaaaaaaaaaabkaabaaaaaaaaaaaaaaaaaakocaabaaa
aaaaaaaaagijcaaaabaaaaaaaaaaaaaaagijcaiaebaaaaaaabaaaaaaabaaaaaa
dcaaaaakhcaabaaaaaaaaaaaagaabaaaaaaaaaaajgahbaaaaaaaaaaaegiccaaa
abaaaaaaabaaaaaadgaaaaaficaabaaaaaaaaaaaabeaaaaaaaaaiadpdiaaaaah
pccabaaaaaaaaaaaegaobaaaaaaaaaaaegbobaaaadaaaaaadoaaaaab"
}
SubProgram "gles " {
"!!GLES"
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
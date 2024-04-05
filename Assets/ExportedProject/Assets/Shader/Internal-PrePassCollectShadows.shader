//////////////////////////////////////////
//
// NOTE: This is *not* a valid shader file
//
///////////////////////////////////////////
Shader "Hidden/Internal-PrePassCollectShadows" {
Properties {
 _ShadowMapTexture ("", any) = "" { }
}
SubShader { 
 Pass {
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 58189
Program "vp" {
SubProgram "gles " {
Keywords { "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 _LightSplitsNear;
uniform highp vec4 _LightSplitsFar;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7 = (_CameraToWorld * tmpvar_6);
  bvec4 tmpvar_8;
  tmpvar_8 = greaterThanEqual (tmpvar_5.zzzz, _LightSplitsNear);
  bvec4 tmpvar_9;
  tmpvar_9 = lessThan (tmpvar_5.zzzz, _LightSplitsFar);
  lowp vec4 tmpvar_10;
  tmpvar_10 = (vec4(tmpvar_8) * vec4(tmpvar_9));
  highp vec4 tmpvar_11;
  tmpvar_11.w = 1.0;
  tmpvar_11.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_7).xyz * tmpvar_10.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_7).xyz * tmpvar_10.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_7)
  .xyz * tmpvar_10.z)) + ((unity_World2Shadow[3] * tmpvar_7).xyz * tmpvar_10.w));
  highp vec4 tmpvar_12;
  tmpvar_12 = texture2D (_ShadowMapTexture, tmpvar_11.xy);
  mediump float tmpvar_13;
  if ((tmpvar_12.x < tmpvar_11.z)) {
    tmpvar_13 = 0.0;
  } else {
    tmpvar_13 = 1.0;
  };
  highp float tmpvar_14;
  tmpvar_14 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_13) + tmpvar_14);
  mediump vec4 tmpvar_15;
  tmpvar_15 = vec4(shadow_2);
  res_1 = tmpvar_15;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform vec4 _LightSplitsNear;
uniform vec4 _LightSplitsFar;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec3 tmpvar_3;
  tmpvar_3 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = tmpvar_3;
  vec4 tmpvar_5;
  tmpvar_5 = (_CameraToWorld * tmpvar_4);
  vec4 tmpvar_6;
  tmpvar_6 = (vec4(greaterThanEqual (tmpvar_3.zzzz, _LightSplitsNear)) * vec4(lessThan (tmpvar_3.zzzz, _LightSplitsFar)));
  vec4 tmpvar_7;
  tmpvar_7.w = 1.0;
  tmpvar_7.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_5).xyz * tmpvar_6.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_5).xyz * tmpvar_6.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_5)
  .xyz * tmpvar_6.z)) + ((unity_World2Shadow[3] * tmpvar_5).xyz * tmpvar_6.w));
  gl_FragData[0] = vec4((mix (_LightShadowData.x, 1.0, shadow2D (_ShadowMapTexture, tmpvar_7.xyz).x) + clamp ((
    (tmpvar_3.z * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_2_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov oPos.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 oT2.x, c4, r1
dp4 oT2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov oPos.x, r1.x
mov oT2.zw, -r0.xyxy
mov oT0.xy, v1
mov oT1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 _LightSplitsNear;
uniform highp vec4 _LightSplitsFar;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7 = (_CameraToWorld * tmpvar_6);
  bvec4 tmpvar_8;
  tmpvar_8 = greaterThanEqual (tmpvar_5.zzzz, _LightSplitsNear);
  bvec4 tmpvar_9;
  tmpvar_9 = lessThan (tmpvar_5.zzzz, _LightSplitsFar);
  lowp vec4 tmpvar_10;
  tmpvar_10 = (vec4(tmpvar_8) * vec4(tmpvar_9));
  highp vec4 tmpvar_11;
  tmpvar_11.w = 1.0;
  tmpvar_11.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_7).xyz * tmpvar_10.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_7).xyz * tmpvar_10.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_7)
  .xyz * tmpvar_10.z)) + ((unity_World2Shadow[3] * tmpvar_7).xyz * tmpvar_10.w));
  lowp float tmpvar_12;
  tmpvar_12 = shadow2DEXT (_ShadowMapTexture, tmpvar_11.xyz);
  mediump float tmpvar_13;
  tmpvar_13 = tmpvar_12;
  highp float tmpvar_14;
  tmpvar_14 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_13) + tmpvar_14);
  mediump vec4 tmpvar_15;
  tmpvar_15 = vec4(shadow_2);
  res_1 = tmpvar_15;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedgjoaienahkbmhffbdkoaooigcmijlaccabaaaaaafmafaaaaaeaaaaaa
daaaaaaanmabaaaagaaeaaaaneaeaaaaebgpgodjkeabaaaakeabaaaaaaacpopp
fiabaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaakaaaeaaacaaaaaaaaaaacaaaaaaaeaaagaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafakaaapkaaaaaiadpaaaaialpaaaaaaaaaaaaaaaa
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjabpaaaaacafaaacia
acaaapjaafaaaaadaaaaapiaaaaaffjaahaaoekaaeaaaaaeaaaaapiaagaaoeka
aaaaaajaaaaaoeiaaeaaaaaeaaaaapiaaiaaoekaaaaakkjaaaaaoeiaaeaaaaae
aaaaapiaajaaoekaaaaappjaaaaaoeiaafaaaaadabaaabiaaaaaffiaabaaaaka
afaaaaadabaaahiaabaaaaiaadaaoekaaeaaaaaeabaaahiaacaaoekaaaaaaaia
abaaoeiaacaaaaadabaaaiiaabaakkiaaeaakkkaacaaaaadabaaahiaabaaoeia
aeaaoekbacaaaaadabaaahiaabaaoeiaafaaoekaafaaaaadacaaahoaabaaoeia
akaanakaacaaaaadabaaabiaabaappiaafaakkkaabaaaaacacaaaioaabaaaaib
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
abaaaaacaaaaadoaabaaoejaabaaaaacabaaahoaacaaoejappppaaaafdeieefc
hmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaae
egiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafpaaaaad
pcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaa
gfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaagiaaaaacacaaaaaadgaaaaaf
dccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaafhccabaaaabaaaaaaegbcbaaa
acaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaai
bcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaaaaaaaaaaafaaaaaadiaaaaai
hcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaaamaaaaaaaaaaaaajocaabaaa
aaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaaabaaaaaaamaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaaabaaaaaaanaaaaaadiaaaaak
hccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaialp
aaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaab
ejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
gcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaahahaaaafaepfdejfeejepeo
aafeeffiedepepfceeaaeoepfcenebemaaklklklepfdeheoiaaaaaaaaeaaaaaa
aiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadamaaaagiaaaaaa
abaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaagiaaaaaaacaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaa
apaaaaaafeeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
lowp vec4 t10_1;
bvec4 tb1;
highp vec4 t2;
bvec4 tb2;
highp vec3 t3;
mediump float t16_4;
highp vec3 t5;
lowp float t10_5;
highp float t10;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t5.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t5.x = float(1.0) / t5.x;
    t10 = (-t5.x) + t0.x;
    t5.x = unity_OrthoParams.w * t10 + t5.x;
    t1.xy = vs_TEXCOORD2.xy;
    t10 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t10 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t5.xxx + t1.xyz;
    t1.xyz = t5.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    tb1 = greaterThanEqual(t0.zzzz, _LightSplitsNear);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    tb2 = lessThan(t0.zzzz, _LightSplitsFar);
    t2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb2));
    t10_1 = t1 * t2;
    t2 = t0.yyyy * _CameraToWorld[1];
    t2 = _CameraToWorld[0] * t0.xxxx + t2;
    t2 = _CameraToWorld[2] * t0.zzzz + t2;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2 = t2 + _CameraToWorld[3];
    t5.xyz = t2.yyy * unity_World2Shadow[1][1].xyz;
    t5.xyz = unity_World2Shadow[1][0].xyz * t2.xxx + t5.xyz;
    t5.xyz = unity_World2Shadow[1][2].xyz * t2.zzz + t5.xyz;
    t5.xyz = unity_World2Shadow[1][3].xyz * t2.www + t5.xyz;
    t5.xyz = t10_1.yyy * t5.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t2.www + t3.xyz;
    t5.xyz = t3.xyz * t10_1.xxx + t5.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t2.www + t3.xyz;
    t5.xyz = t3.xyz * t10_1.zzz + t5.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[3][1].xyz;
    t3.xyz = unity_World2Shadow[3][0].xyz * t2.xxx + t3.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t2.zzz + t3.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t2.www + t2.xyz;
    t5.xyz = t2.xyz * t10_1.www + t5.xyz;
    vec3 txVec0 = vec3(t5.xy,t5.z);
    t10_5 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t16_4 = (-_LightShadowData.x) + 1.0;
    t16_4 = t10_5 * t16_4 + _LightShadowData.x;
    t0 = t0.xxxx + vec4(t16_4);
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
bvec4 tb1;
vec4 t2;
bvec4 tb2;
vec3 t3;
vec3 t4;
lowp float t10_4;
float t8;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t4.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t4.x = float(1.0) / t4.x;
    t8 = (-t4.x) + t10_0.x;
    t4.x = unity_OrthoParams.w * t8 + t4.x;
    t1.xy = vs_TEXCOORD2.xy;
    t8 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t8 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t4.xxx + t1.xyz;
    t1.xyz = t4.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    tb1 = greaterThanEqual(t0.zzzz, _LightSplitsNear);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    tb2 = lessThan(t0.zzzz, _LightSplitsFar);
    t2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb2));
    t1 = t1 * t2;
    t2 = t0.yyyy * _CameraToWorld[1];
    t2 = _CameraToWorld[0] * t0.xxxx + t2;
    t2 = _CameraToWorld[2] * t0.zzzz + t2;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2 = t2 + _CameraToWorld[3];
    t4.xyz = t2.yyy * unity_World2Shadow[1][1].xyz;
    t4.xyz = unity_World2Shadow[1][0].xyz * t2.xxx + t4.xyz;
    t4.xyz = unity_World2Shadow[1][2].xyz * t2.zzz + t4.xyz;
    t4.xyz = unity_World2Shadow[1][3].xyz * t2.www + t4.xyz;
    t4.xyz = t1.yyy * t4.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t2.www + t3.xyz;
    t4.xyz = t3.xyz * t1.xxx + t4.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t2.www + t3.xyz;
    t4.xyz = t3.xyz * t1.zzz + t4.xyz;
    t1.xyz = t2.yyy * unity_World2Shadow[3][1].xyz;
    t1.xyz = unity_World2Shadow[3][0].xyz * t2.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[3][2].xyz * t2.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[3][3].xyz * t2.www + t1.xyz;
    t4.xyz = t1.xyz * t1.www + t4.xyz;
    vec3 txVec0 = vec3(t4.xy,t4.z);
    t10_4 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t8 = (-_LightShadowData.x) + 1.0;
    t4.x = t10_4 * t8 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t4.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 unity_ShadowSplitSpheres[4];
uniform highp vec4 unity_ShadowSplitSqRadii;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  lowp vec4 weights_7;
  highp vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[0].xyz);
  highp vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[1].xyz);
  highp vec3 tmpvar_10;
  tmpvar_10 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[2].xyz);
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[3].xyz);
  highp vec4 tmpvar_12;
  tmpvar_12.x = dot (tmpvar_8, tmpvar_8);
  tmpvar_12.y = dot (tmpvar_9, tmpvar_9);
  tmpvar_12.z = dot (tmpvar_10, tmpvar_10);
  tmpvar_12.w = dot (tmpvar_11, tmpvar_11);
  bvec4 tmpvar_13;
  tmpvar_13 = lessThan (tmpvar_12, unity_ShadowSplitSqRadii);
  lowp vec4 tmpvar_14;
  tmpvar_14 = vec4(tmpvar_13);
  weights_7.x = tmpvar_14.x;
  weights_7.yzw = clamp ((tmpvar_14.yzw - tmpvar_14.xyz), 0.0, 1.0);
  highp vec4 tmpvar_15;
  tmpvar_15.w = 1.0;
  tmpvar_15.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_6).xyz * tmpvar_14.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_6).xyz * weights_7.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_6)
  .xyz * weights_7.z)) + ((unity_World2Shadow[3] * tmpvar_6).xyz * weights_7.w));
  highp vec4 tmpvar_16;
  tmpvar_16 = texture2D (_ShadowMapTexture, tmpvar_15.xy);
  mediump float tmpvar_17;
  if ((tmpvar_16.x < tmpvar_15.z)) {
    tmpvar_17 = 0.0;
  } else {
    tmpvar_17 = 1.0;
  };
  highp float tmpvar_18;
  highp vec3 tmpvar_19;
  tmpvar_19 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_20;
  highp float tmpvar_21;
  tmpvar_21 = clamp (((
    sqrt(dot (tmpvar_19, tmpvar_19))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_20 = tmpvar_21;
  tmpvar_18 = tmpvar_20;
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_17) + tmpvar_18);
  mediump vec4 tmpvar_22;
  tmpvar_22 = vec4(shadow_2);
  res_1 = tmpvar_22;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform vec4 unity_ShadowSplitSpheres[4];
uniform vec4 unity_ShadowSplitSqRadii;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform vec4 unity_ShadowFadeCenterAndType;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec4 tmpvar_3;
  tmpvar_3.w = 1.0;
  tmpvar_3.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4 = (_CameraToWorld * tmpvar_3);
  vec4 weights_5;
  vec3 tmpvar_6;
  tmpvar_6 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[0].xyz);
  vec3 tmpvar_7;
  tmpvar_7 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[1].xyz);
  vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[2].xyz);
  vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[3].xyz);
  vec4 tmpvar_10;
  tmpvar_10.x = dot (tmpvar_6, tmpvar_6);
  tmpvar_10.y = dot (tmpvar_7, tmpvar_7);
  tmpvar_10.z = dot (tmpvar_8, tmpvar_8);
  tmpvar_10.w = dot (tmpvar_9, tmpvar_9);
  vec4 tmpvar_11;
  tmpvar_11 = vec4(lessThan (tmpvar_10, unity_ShadowSplitSqRadii));
  weights_5.x = tmpvar_11.x;
  weights_5.yzw = clamp ((tmpvar_11.yzw - tmpvar_11.xyz), 0.0, 1.0);
  vec4 tmpvar_12;
  tmpvar_12.w = 1.0;
  tmpvar_12.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_4).xyz * tmpvar_11.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_4).xyz * weights_5.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_4)
  .xyz * weights_5.z)) + ((unity_World2Shadow[3] * tmpvar_4).xyz * weights_5.w));
  vec3 tmpvar_13;
  tmpvar_13 = (tmpvar_4.xyz - unity_ShadowFadeCenterAndType.xyz);
  gl_FragData[0] = vec4((mix (_LightShadowData.x, 1.0, shadow2D (_ShadowMapTexture, tmpvar_12.xyz).x) + clamp ((
    (sqrt(dot (tmpvar_13, tmpvar_13)) * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_2_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov oPos.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 oT2.x, c4, r1
dp4 oT2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov oPos.x, r1.x
mov oT2.zw, -r0.xyxy
mov oT0.xy, v1
mov oT1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 unity_ShadowSplitSpheres[4];
uniform highp vec4 unity_ShadowSplitSqRadii;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  lowp vec4 weights_7;
  highp vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[0].xyz);
  highp vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[1].xyz);
  highp vec3 tmpvar_10;
  tmpvar_10 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[2].xyz);
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[3].xyz);
  highp vec4 tmpvar_12;
  tmpvar_12.x = dot (tmpvar_8, tmpvar_8);
  tmpvar_12.y = dot (tmpvar_9, tmpvar_9);
  tmpvar_12.z = dot (tmpvar_10, tmpvar_10);
  tmpvar_12.w = dot (tmpvar_11, tmpvar_11);
  bvec4 tmpvar_13;
  tmpvar_13 = lessThan (tmpvar_12, unity_ShadowSplitSqRadii);
  lowp vec4 tmpvar_14;
  tmpvar_14 = vec4(tmpvar_13);
  weights_7.x = tmpvar_14.x;
  weights_7.yzw = clamp ((tmpvar_14.yzw - tmpvar_14.xyz), 0.0, 1.0);
  highp vec4 tmpvar_15;
  tmpvar_15.w = 1.0;
  tmpvar_15.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_6).xyz * tmpvar_14.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_6).xyz * weights_7.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_6)
  .xyz * weights_7.z)) + ((unity_World2Shadow[3] * tmpvar_6).xyz * weights_7.w));
  lowp float tmpvar_16;
  tmpvar_16 = shadow2DEXT (_ShadowMapTexture, tmpvar_15.xyz);
  mediump float tmpvar_17;
  tmpvar_17 = tmpvar_16;
  highp float tmpvar_18;
  highp vec3 tmpvar_19;
  tmpvar_19 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_20;
  highp float tmpvar_21;
  tmpvar_21 = clamp (((
    sqrt(dot (tmpvar_19, tmpvar_19))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_20 = tmpvar_21;
  tmpvar_18 = tmpvar_20;
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_17) + tmpvar_18);
  mediump vec4 tmpvar_22;
  tmpvar_22 = vec4(shadow_2);
  res_1 = tmpvar_22;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedgjoaienahkbmhffbdkoaooigcmijlaccabaaaaaafmafaaaaaeaaaaaa
daaaaaaanmabaaaagaaeaaaaneaeaaaaebgpgodjkeabaaaakeabaaaaaaacpopp
fiabaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaakaaaeaaacaaaaaaaaaaacaaaaaaaeaaagaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafakaaapkaaaaaiadpaaaaialpaaaaaaaaaaaaaaaa
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjabpaaaaacafaaacia
acaaapjaafaaaaadaaaaapiaaaaaffjaahaaoekaaeaaaaaeaaaaapiaagaaoeka
aaaaaajaaaaaoeiaaeaaaaaeaaaaapiaaiaaoekaaaaakkjaaaaaoeiaaeaaaaae
aaaaapiaajaaoekaaaaappjaaaaaoeiaafaaaaadabaaabiaaaaaffiaabaaaaka
afaaaaadabaaahiaabaaaaiaadaaoekaaeaaaaaeabaaahiaacaaoekaaaaaaaia
abaaoeiaacaaaaadabaaaiiaabaakkiaaeaakkkaacaaaaadabaaahiaabaaoeia
aeaaoekbacaaaaadabaaahiaabaaoeiaafaaoekaafaaaaadacaaahoaabaaoeia
akaanakaacaaaaadabaaabiaabaappiaafaakkkaabaaaaacacaaaioaabaaaaib
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
abaaaaacaaaaadoaabaaoejaabaaaaacabaaahoaacaaoejappppaaaafdeieefc
hmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaae
egiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafpaaaaad
pcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaa
gfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaagiaaaaacacaaaaaadgaaaaaf
dccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaafhccabaaaabaaaaaaegbcbaaa
acaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaai
bcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaaaaaaaaaaafaaaaaadiaaaaai
hcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaaamaaaaaaaaaaaaajocaabaaa
aaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaaabaaaaaaamaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaaabaaaaaaanaaaaaadiaaaaak
hccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaialp
aaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaab
ejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
gcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaahahaaaafaepfdejfeejepeo
aafeeffiedepepfceeaaeoepfcenebemaaklklklepfdeheoiaaaaaaaaeaaaaaa
aiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadamaaaagiaaaaaa
abaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaagiaaaaaaacaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaa
apaaaaaafeeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
bvec4 tb1;
highp vec3 t2;
lowp vec3 t10_3;
mediump float t16_4;
highp vec3 t5;
lowp float t10_5;
highp vec3 t6;
highp float t10;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t5.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t5.x = float(1.0) / t5.x;
    t10 = (-t5.x) + t0.x;
    t5.x = unity_OrthoParams.w * t10 + t5.x;
    t1.xy = vs_TEXCOORD2.xy;
    t10 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t10 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t5.xxx + t1.xyz;
    t1.xyz = t5.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.xyz + (-unity_ShadowSplitSpheres[0].xyz);
    t1.x = dot(t1.xyz, t1.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[1].xyz);
    t1.y = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[2].xyz);
    t1.z = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[3].xyz);
    t1.w = dot(t2.xyz, t2.xyz);
    tb1 = lessThan(t1, unity_ShadowSplitSqRadii);
    t10_3.x = (tb1.x) ? float(-1.0) : float(-0.0);
    t10_3.y = (tb1.y) ? float(-1.0) : float(-0.0);
    t10_3.z = (tb1.z) ? float(-1.0) : float(-0.0);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    t10_3.xyz = vec3(t10_3.x + t1.y, t10_3.y + t1.z, t10_3.z + t1.w);
    t10_3.xyz = max(t10_3.xyz, vec3(0.0, 0.0, 0.0));
    t6.xyz = t0.yyy * unity_World2Shadow[1][1].xyz;
    t6.xyz = unity_World2Shadow[1][0].xyz * t0.xxx + t6.xyz;
    t6.xyz = unity_World2Shadow[1][2].xyz * t0.zzz + t6.xyz;
    t6.xyz = unity_World2Shadow[1][3].xyz * t0.www + t6.xyz;
    t6.xyz = t10_3.xxx * t6.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t2.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[0][3].xyz * t0.www + t2.xyz;
    t1.xyz = t2.xyz * t1.xxx + t6.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[2][1].xyz;
    t2.xyz = unity_World2Shadow[2][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[2][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[2][3].xyz * t0.www + t2.xyz;
    t1.xyz = t2.xyz * t10_3.yyy + t1.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[3][1].xyz;
    t2.xyz = unity_World2Shadow[3][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t0.www + t2.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t5.xyz = t2.xyz * t10_3.zzz + t1.xyz;
    vec3 txVec0 = vec3(t5.xy,t5.z);
    t10_5 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t16_4 = (-_LightShadowData.x) + 1.0;
    t16_4 = t10_5 * t16_4 + _LightShadowData.x;
    t0 = t0.xxxx + vec4(t16_4);
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
bvec4 tb1;
vec3 t2;
vec3 t3;
vec3 t4;
lowp float t10_4;
vec3 t5;
float t8;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t4.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t4.x = float(1.0) / t4.x;
    t8 = (-t4.x) + t10_0.x;
    t4.x = unity_OrthoParams.w * t8 + t4.x;
    t1.xy = vs_TEXCOORD2.xy;
    t8 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t8 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t4.xxx + t1.xyz;
    t1.xyz = t4.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.xyz + (-unity_ShadowSplitSpheres[0].xyz);
    t1.x = dot(t1.xyz, t1.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[1].xyz);
    t1.y = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[2].xyz);
    t1.z = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[3].xyz);
    t1.w = dot(t2.xyz, t2.xyz);
    tb1 = lessThan(t1, unity_ShadowSplitSqRadii);
    t2.x = (tb1.x) ? float(-1.0) : float(-0.0);
    t2.y = (tb1.y) ? float(-1.0) : float(-0.0);
    t2.z = (tb1.z) ? float(-1.0) : float(-0.0);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    t5.xyz = t2.xyz + t1.yzw;
    t5.xyz = max(t5.xyz, vec3(0.0, 0.0, 0.0));
    t2.xyz = t0.yyy * unity_World2Shadow[1][1].xyz;
    t2.xyz = unity_World2Shadow[1][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[1][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[1][3].xyz * t0.www + t2.xyz;
    t2.xyz = t5.xxx * t2.xyz;
    t3.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t0.www + t3.xyz;
    t2.xyz = t3.xyz * t1.xxx + t2.xyz;
    t3.xyz = t0.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t0.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t0.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t0.www + t3.xyz;
    t1.xyz = t3.xyz * t5.yyy + t2.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[3][1].xyz;
    t2.xyz = unity_World2Shadow[3][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t0.www + t2.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t4.xyz = t2.xyz * t5.zzz + t1.xyz;
    vec3 txVec0 = vec3(t4.xy,t4.z);
    t10_4 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t8 = (-_LightShadowData.x) + 1.0;
    t4.x = t10_4 * t8 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t4.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_6)).xyz;
  highp vec4 tmpvar_8;
  tmpvar_8 = texture2D (_ShadowMapTexture, tmpvar_7.xy);
  mediump float tmpvar_9;
  if ((tmpvar_8.x < tmpvar_7.z)) {
    tmpvar_9 = 0.0;
  } else {
    tmpvar_9 = 1.0;
  };
  highp float tmpvar_10;
  tmpvar_10 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_9) + tmpvar_10);
  mediump vec4 tmpvar_11;
  tmpvar_11 = vec4(shadow_2);
  res_1 = tmpvar_11;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec3 tmpvar_3;
  tmpvar_3 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = tmpvar_3;
  vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_4)).xyz;
  gl_FragData[0] = vec4((mix (_LightShadowData.x, 1.0, shadow2D (_ShadowMapTexture, tmpvar_5.xyz).x) + clamp ((
    (tmpvar_3.z * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_2_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov oPos.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 oT2.x, c4, r1
dp4 oT2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov oPos.x, r1.x
mov oT2.zw, -r0.xyxy
mov oT0.xy, v1
mov oT1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_6)).xyz;
  lowp float tmpvar_8;
  tmpvar_8 = shadow2DEXT (_ShadowMapTexture, tmpvar_7.xyz);
  mediump float tmpvar_9;
  tmpvar_9 = tmpvar_8;
  highp float tmpvar_10;
  tmpvar_10 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_9) + tmpvar_10);
  mediump vec4 tmpvar_11;
  tmpvar_11 = vec4(shadow_2);
  res_1 = tmpvar_11;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedgjoaienahkbmhffbdkoaooigcmijlaccabaaaaaafmafaaaaaeaaaaaa
daaaaaaanmabaaaagaaeaaaaneaeaaaaebgpgodjkeabaaaakeabaaaaaaacpopp
fiabaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaakaaaeaaacaaaaaaaaaaacaaaaaaaeaaagaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafakaaapkaaaaaiadpaaaaialpaaaaaaaaaaaaaaaa
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjabpaaaaacafaaacia
acaaapjaafaaaaadaaaaapiaaaaaffjaahaaoekaaeaaaaaeaaaaapiaagaaoeka
aaaaaajaaaaaoeiaaeaaaaaeaaaaapiaaiaaoekaaaaakkjaaaaaoeiaaeaaaaae
aaaaapiaajaaoekaaaaappjaaaaaoeiaafaaaaadabaaabiaaaaaffiaabaaaaka
afaaaaadabaaahiaabaaaaiaadaaoekaaeaaaaaeabaaahiaacaaoekaaaaaaaia
abaaoeiaacaaaaadabaaaiiaabaakkiaaeaakkkaacaaaaadabaaahiaabaaoeia
aeaaoekbacaaaaadabaaahiaabaaoeiaafaaoekaafaaaaadacaaahoaabaaoeia
akaanakaacaaaaadabaaabiaabaappiaafaakkkaabaaaaacacaaaioaabaaaaib
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
abaaaaacaaaaadoaabaaoejaabaaaaacabaaahoaacaaoejappppaaaafdeieefc
hmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaae
egiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafpaaaaad
pcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaa
gfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaagiaaaaacacaaaaaadgaaaaaf
dccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaafhccabaaaabaaaaaaegbcbaaa
acaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaai
bcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaaaaaaaaaaafaaaaaadiaaaaai
hcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaaamaaaaaaaaaaaaajocaabaaa
aaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaaabaaaaaaamaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaaabaaaaaaanaaaaaadiaaaaak
hccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaialp
aaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaab
ejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
gcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaahahaaaafaepfdejfeejepeo
aafeeffiedepepfceeaaeoepfcenebemaaklklklepfdeheoiaaaaaaaaeaaaaaa
aiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadamaaaagiaaaaaa
abaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaagiaaaaaaacaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaa
apaaaaaafeeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
mediump float t16_2;
highp vec3 t3;
lowp float t10_3;
highp float t6;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t3.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t3.x = float(1.0) / t3.x;
    t6 = (-t3.x) + t0.x;
    t3.x = unity_OrthoParams.w * t6 + t3.x;
    t1.xy = vs_TEXCOORD2.xy;
    t6 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t6 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t3.xxx + t1.xyz;
    t1.xyz = t3.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t1 = _CameraToWorld[2] * t0.zzzz + t1;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t1 = t1 + _CameraToWorld[3];
    t3.xyz = t1.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t1.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t1.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t1.www + t3.xyz;
    vec3 txVec0 = vec3(t3.xy,t3.z);
    t10_3 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t16_2 = (-_LightShadowData.x) + 1.0;
    t16_2 = t10_3 * t16_2 + _LightShadowData.x;
    t0 = t0.xxxx + vec4(t16_2);
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
vec3 t2;
lowp float t10_2;
float t4;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t2.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t2.x = float(1.0) / t2.x;
    t4 = (-t2.x) + t10_0.x;
    t2.x = unity_OrthoParams.w * t4 + t2.x;
    t1.xy = vs_TEXCOORD2.xy;
    t4 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t4 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t2.xxx + t1.xyz;
    t1.xyz = t2.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t1 = _CameraToWorld[2] * t0.zzzz + t1;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t1 = t1 + _CameraToWorld[3];
    t2.xyz = t1.yyy * unity_World2Shadow[0][1].xyz;
    t2.xyz = unity_World2Shadow[0][0].xyz * t1.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[0][2].xyz * t1.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[0][3].xyz * t1.www + t2.xyz;
    vec3 txVec1 = vec3(t2.xy,t2.z);
    t10_2 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    t4 = (-_LightShadowData.x) + 1.0;
    t2.x = t10_2 * t4 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t2.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * tmpvar_6).xyz;
  highp vec4 tmpvar_8;
  tmpvar_8 = texture2D (_ShadowMapTexture, tmpvar_7.xy);
  mediump float tmpvar_9;
  if ((tmpvar_8.x < tmpvar_7.z)) {
    tmpvar_9 = 0.0;
  } else {
    tmpvar_9 = 1.0;
  };
  highp float tmpvar_10;
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_12;
  highp float tmpvar_13;
  tmpvar_13 = clamp (((
    sqrt(dot (tmpvar_11, tmpvar_11))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_12 = tmpvar_13;
  tmpvar_10 = tmpvar_12;
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_9) + tmpvar_10);
  mediump vec4 tmpvar_14;
  tmpvar_14 = vec4(shadow_2);
  res_1 = tmpvar_14;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform vec4 unity_ShadowFadeCenterAndType;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec4 tmpvar_3;
  tmpvar_3.w = 1.0;
  tmpvar_3.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4 = (_CameraToWorld * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = (unity_World2Shadow[0] * tmpvar_4).xyz;
  vec3 tmpvar_6;
  tmpvar_6 = (tmpvar_4.xyz - unity_ShadowFadeCenterAndType.xyz);
  gl_FragData[0] = vec4((mix (_LightShadowData.x, 1.0, shadow2D (_ShadowMapTexture, tmpvar_5.xyz).x) + clamp ((
    (sqrt(dot (tmpvar_6, tmpvar_6)) * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_2_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dp4 oPos.z, c2, v0
dp4 oPos.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov oPos.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 oT2.x, c4, r1
dp4 oT2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov oPos.x, r1.x
mov oT2.zw, -r0.xyxy
mov oT0.xy, v1
mov oT1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 res_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * tmpvar_6).xyz;
  lowp float tmpvar_8;
  tmpvar_8 = shadow2DEXT (_ShadowMapTexture, tmpvar_7.xyz);
  mediump float tmpvar_9;
  tmpvar_9 = tmpvar_8;
  highp float tmpvar_10;
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_12;
  highp float tmpvar_13;
  tmpvar_13 = clamp (((
    sqrt(dot (tmpvar_11, tmpvar_11))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_12 = tmpvar_13;
  tmpvar_10 = tmpvar_12;
  shadow_2 = (mix (_LightShadowData.x, 1.0, tmpvar_9) + tmpvar_10);
  mediump vec4 tmpvar_14;
  tmpvar_14 = vec4(shadow_2);
  res_1 = tmpvar_14;
  gl_FragData[0] = res_1;
}


#endif
"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0_level_9_1
root12:aaadaaaa
eefiecedgjoaienahkbmhffbdkoaooigcmijlaccabaaaaaafmafaaaaaeaaaaaa
daaaaaaanmabaaaagaaeaaaaneaeaaaaebgpgodjkeabaaaakeabaaaaaaacpopp
fiabaaaaemaaaaaaadaaceaaaaaaeiaaaaaaeiaaaaaaceaaabaaeiaaaaaaafaa
abaaabaaaaaaaaaaabaaakaaaeaaacaaaaaaaaaaacaaaaaaaeaaagaaaaaaaaaa
aaaaaaaaaaacpoppfbaaaaafakaaapkaaaaaiadpaaaaialpaaaaaaaaaaaaaaaa
bpaaaaacafaaaaiaaaaaapjabpaaaaacafaaabiaabaaapjabpaaaaacafaaacia
acaaapjaafaaaaadaaaaapiaaaaaffjaahaaoekaaeaaaaaeaaaaapiaagaaoeka
aaaaaajaaaaaoeiaaeaaaaaeaaaaapiaaiaaoekaaaaakkjaaaaaoeiaaeaaaaae
aaaaapiaajaaoekaaaaappjaaaaaoeiaafaaaaadabaaabiaaaaaffiaabaaaaka
afaaaaadabaaahiaabaaaaiaadaaoekaaeaaaaaeabaaahiaacaaoekaaaaaaaia
abaaoeiaacaaaaadabaaaiiaabaakkiaaeaakkkaacaaaaadabaaahiaabaaoeia
aeaaoekbacaaaaadabaaahiaabaaoeiaafaaoekaafaaaaadacaaahoaabaaoeia
akaanakaacaaaaadabaaabiaabaappiaafaakkkaabaaaaacacaaaioaabaaaaib
aeaaaaaeaaaaadmaaaaappiaaaaaoekaaaaaoeiaabaaaaacaaaaammaaaaaoeia
abaaaaacaaaaadoaabaaoejaabaaaaacabaaahoaacaaoejappppaaaafdeieefc
hmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaaaaaaaaaaagaaaaaafjaaaaae
egiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafpaaaaad
pcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaafpaaaaadhcbabaaaacaaaaaa
gfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaaabaaaaaagfaaaaadpccabaaa
acaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaagiaaaaacacaaaaaadgaaaaaf
dccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaafhccabaaaabaaaaaaegbcbaaa
acaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaaaaaaaaaaegiocaaaacaaaaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaaaaaaaaaagbabaaa
aaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaa
acaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaaegaobaaaaaaaaaaadiaaaaai
bcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaaaaaaaaaaafaaaaaadiaaaaai
hcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaaaaaaaaaaaaaaaaaibcaabaaa
aaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaaamaaaaaaaaaaaaajocaabaaa
aaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaaabaaaaaaamaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaaabaaaaaaanaaaaaadiaaaaak
hccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaialp
aaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaiaebaaaaaaaaaaaaaadoaaaaab
ejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaaadaaaaaaabaaaaaaadadaaaa
gcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaaahahaaaafaepfdejfeejepeo
aafeeffiedepepfceeaaeoepfcenebemaaklklklepfdeheoiaaaaaaaaeaaaaaa
aiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadamaaaagiaaaaaa
abaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaagiaaaaaaacaaaaaaaaaaaaaa
adaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaa
apaaaaaafeeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
mediump float t16_2;
highp float t3;
lowp float t10_3;
highp float t6;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t3 = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t3 = float(1.0) / t3;
    t6 = (-t3) + t0.x;
    t3 = unity_OrthoParams.w * t6 + t3;
    t1.xy = vs_TEXCOORD2.xy;
    t6 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t6 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * vec3(t3) + t1.xyz;
    t1.xyz = vec3(t3) * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t1.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[0][3].xyz * t0.www + t1.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    vec3 txVec0 = vec3(t1.xy,t1.z);
    t10_3 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    t16_2 = (-_LightShadowData.x) + 1.0;
    t16_2 = t10_3 * t16_2 + _LightShadowData.x;
    t0 = t0.xxxx + vec4(t16_2);
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
float t2;
lowp float t10_2;
float t4;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t2 = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t2 = float(1.0) / t2;
    t4 = (-t2) + t10_0.x;
    t2 = unity_OrthoParams.w * t4 + t2;
    t1.xy = vs_TEXCOORD2.xy;
    t4 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t4 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * vec3(t2) + t1.xyz;
    t1.xyz = vec3(t2) * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t1.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[0][3].xyz * t0.www + t1.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    vec3 txVec1 = vec3(t1.xy,t1.z);
    t10_2 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    t4 = (-_LightShadowData.x) + 1.0;
    t2 = t10_2 * t4 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + vec4(t2);
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "gles " {
Keywords { "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" }
Matrix 15 [_CameraToWorld]
Matrix 0 [unity_World2Shadow0]
Matrix 4 [unity_World2Shadow1]
Matrix 8 [unity_World2Shadow2]
Matrix 12 [unity_World2Shadow3] 3
Vector 23 [_LightShadowData]
Vector 22 [_LightSplitsFar]
Vector 21 [_LightSplitsNear]
Vector 19 [_ZBufferParams]
Vector 20 [unity_OrthoParams]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_2_0
def c24, 1, 0, 0, 0
dcl t0.xy
dcl t1.xyz
dcl t2
dcl_2d s0
dcl_2d s1
texld r0, t0, s0
mov r1.xy, t2
mad r1.w, c19.x, r0.x, c19.y
rcp r1.w, r1.w
lrp r2.w, c20.w, r0.x, r1.w
lrp r1.z, r0.x, t2.w, t2.z
mad r0.xyz, t1, -r2.w, r1
mul r1.xyz, r2.w, t1
mad r0.xyz, c20.w, r0, r1
add r1, r0.z, -c22
cmp r1, r1, c24.y, c24.x
add r2, r0.z, -c21
cmp r1, r2, r1, c24.y
mad_sat r2.x, r0.z, c23.z, c23.w
mov r0.w, c24.x
dp4 r3.x, c15, r0
dp4 r3.y, c16, r0
dp4 r3.z, c17, r0
dp4 r3.w, c18, r0
dp4 r0.x, c4, r3
dp4 r0.y, c5, r3
dp4 r0.z, c6, r3
mul r0.xyz, r1.y, r0
dp4 r4.x, c0, r3
dp4 r4.y, c1, r3
dp4 r4.z, c2, r3
mad r0.xyz, r4, r1.x, r0
dp4 r4.x, c8, r3
dp4 r4.y, c9, r3
dp4 r4.z, c10, r3
mad r0.xyz, r4, r1.z, r0
dp4 r1.x, c12, r3
dp4 r1.y, c13, r3
dp4 r1.z, c14, r3
mad r0.xyz, r1, r1.w, r0
mov r0.w, c24.x
texldp_pp r0, r0, s1
mov r1.x, c24.x
lrp_pp r2.y, r0.x, r1.x, c23.x
add_pp r0, r2.x, r2.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 96 [_LightSplitsNear]
Vector 112 [_LightSplitsFar]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0
root12:acadacaa
eefiecednelhbhdgbkdnmmblaploigjpdocbggegabaaaaaaaeaiaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcbeahaaaaeaaaaaaamfabaaaafjaaaaaeegiocaaa
aaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabjaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacaeaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaal
ccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaaaaaaaaaabkiacaaa
aaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadp
aaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaadkiacaaa
aaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaafdcaabaaa
abaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaackbabaiaebaaaaaa
acaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaaakaabaaaaaaaaaaa
ckaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaaaaaaaaaaagbjbaia
ebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaadiaaaaahhcaabaaa
abaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
pgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaaabaaaaaabnaaaaai
pcaabaaaabaaaaaakgakbaaaaaaaaaaaegiocaaaabaaaaaaagaaaaaaabaaaaak
pcaabaaaabaaaaaaegaobaaaabaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadp
aaaaiadpdbaaaaaipcaabaaaacaaaaaakgakbaaaaaaaaaaaegiocaaaabaaaaaa
ahaaaaaaabaaaaakpcaabaaaacaaaaaaegaobaaaacaaaaaaaceaaaaaaaaaiadp
aaaaiadpaaaaiadpaaaaiadpdiaaaaahpcaabaaaabaaaaaaegaobaaaabaaaaaa
egaobaaaacaaaaaadiaaaaaipcaabaaaacaaaaaafgafbaaaaaaaaaaaegiocaaa
acaaaaaaabaaaaaadcaaaaakpcaabaaaacaaaaaaegiocaaaacaaaaaaaaaaaaaa
agaabaaaaaaaaaaaegaobaaaacaaaaaadcaaaaakpcaabaaaacaaaaaaegiocaaa
acaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaacaaaaaadccaaaalbcaabaaa
aaaaaaaackaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaa
biaaaaaaaaaaaaaipcaabaaaacaaaaaaegaobaaaacaaaaaaegiocaaaacaaaaaa
adaaaaaadiaaaaaiocaabaaaaaaaaaaafgafbaaaacaaaaaaagijcaaaabaaaaaa
anaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaaamaaaaaaagaabaaa
acaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaa
aoaaaaaakgakbaaaacaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaa
agijcaaaabaaaaaaapaaaaaapgapbaaaacaaaaaafgaobaaaaaaaaaaadiaaaaah
ocaabaaaaaaaaaaafgafbaaaabaaaaaafgaobaaaaaaaaaaadiaaaaaihcaabaaa
adaaaaaafgafbaaaacaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaa
adaaaaaaegiccaaaabaaaaaaaiaaaaaaagaabaaaacaaaaaaegacbaaaadaaaaaa
dcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaakaaaaaakgakbaaaacaaaaaa
egacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaalaaaaaa
pgapbaaaacaaaaaaegacbaaaadaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaa
adaaaaaaagaabaaaabaaaaaafgaobaaaaaaaaaaadiaaaaaihcaabaaaadaaaaaa
fgafbaaaacaaaaaaegiccaaaabaaaaaabbaaaaaadcaaaaakhcaabaaaadaaaaaa
egiccaaaabaaaaaabaaaaaaaagaabaaaacaaaaaaegacbaaaadaaaaaadcaaaaak
hcaabaaaadaaaaaaegiccaaaabaaaaaabcaaaaaakgakbaaaacaaaaaaegacbaaa
adaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaabdaaaaaapgapbaaa
acaaaaaaegacbaaaadaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaaadaaaaaa
kgakbaaaabaaaaaafgaobaaaaaaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaa
acaaaaaaegiccaaaabaaaaaabfaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaa
abaaaaaabeaaaaaaagaabaaaacaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaa
abaaaaaaegiccaaaabaaaaaabgaaaaaakgakbaaaacaaaaaaegacbaaaabaaaaaa
dcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaabhaaaaaapgapbaaaacaaaaaa
egacbaaaabaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaapgapbaaa
abaaaaaafgaobaaaaaaaaaaaehaaaaalccaabaaaaaaaaaaajgafbaaaaaaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaaaaaaaajecaabaaa
aaaaaaaaakiacaiaebaaaaaaabaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaak
ccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaaabaaaaaa
biaaaaaaaaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaa
doaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 15 [_ShadowMapTexture] 2D 15
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 96 [_LightSplitsNear]
Vector 112 [_LightSplitsFar]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0_level_9_1
root12:baadbaaa
eefiecedjdfdmgaeomejmjnefcebbdpmafhbajiiabaaaaaanialaaaaafaaaaaa
deaaaaaapaadaaaaamalaaaabmalaaaakealaaaaebgpgodjleadaaaaleadaaaa
aaacppppgeadaaaafaaaaaaaadaacmaaaaaafaaaaaaafaaaacaaceaaaaaafaaa
apapaaaaaaaaabaaaaaaahaaacaaaaaaaaaaaaaaabaaagaabdaaacaaaaaaaaaa
acaaaaaaaeaabfaaaaaaaaaaaaacppppfbaaaaafbjaaapkaaaaaaaaaaaaaiadp
aaaaaaaaaaaaaaaabpaaaaacaaaaaaiaaaaaahlabpaaaaacaaaaaaiaabaaahla
bpaaaaacaaaaaaiaacaaaplabpaaaaacaaaaaajaaaaiapkabpaaaaacaaaaaaja
abaiapkaecaaaaadaaaaapiaaaaaoelaabaioekaabaaaaacabaaadiaacaaoela
aeaaaaaeabaaaiiaaaaaaakaaaaaaaiaaaaaffkaagaaaaacabaaaiiaabaappia
bcaaaaaeacaaaiiaabaappkaaaaaaaiaabaappiabcaaaaaeabaaaeiaaaaaaaia
acaapplaacaakklaaeaaaaaeaaaaahiaabaaoelaacaappibabaaoeiaafaaaaad
abaaahiaacaappiaabaaoelaaeaaaaaeaaaaahiaabaappkaaaaaoeiaabaaoeia
acaaaaadabaaapiaaaaakkiaadaaoekbfiaaaaaeabaaapiaabaaoeiabjaaaaka
bjaaffkaacaaaaadacaaapiaaaaakkiaacaaoekbfiaaaaaeabaaapiaacaaoeia
abaaoeiabjaaaakaafaaaaadacaaapiaaaaaffiabgaaoekaaeaaaaaeacaaapia
bfaaoekaaaaaaaiaacaaoeiaaeaaaaaeacaaapiabhaaoekaaaaakkiaacaaoeia
aeaaaaaeaaaabbiaaaaakkiabeaakkkabeaappkaacaaaaadacaaapiaacaaoeia
biaaoekaafaaaaadaaaaaoiaacaaffiaajaablkaaeaaaaaeaaaaaoiaaiaablka
acaaaaiaaaaaoeiaaeaaaaaeaaaaaoiaakaablkaacaakkiaaaaaoeiaaeaaaaae
aaaaaoiaalaablkaacaappiaaaaaoeiaafaaaaadaaaaaoiaabaaffiaaaaaoeia
afaaaaadadaaahiaacaaffiaafaaoekaaeaaaaaeadaaahiaaeaaoekaacaaaaia
adaaoeiaaeaaaaaeadaaahiaagaaoekaacaakkiaadaaoeiaaeaaaaaeadaaahia
ahaaoekaacaappiaadaaoeiaaeaaaaaeaaaaaoiaadaabliaabaaaaiaaaaaoeia
afaaaaadadaaahiaacaaffiaanaaoekaaeaaaaaeadaaahiaamaaoekaacaaaaia
adaaoeiaaeaaaaaeadaaahiaaoaaoekaacaakkiaadaaoeiaaeaaaaaeadaaahia
apaaoekaacaappiaadaaoeiaaeaaaaaeaaaaaoiaadaabliaabaakkiaaaaaoeia
afaaaaadabaaahiaacaaffiabbaaoekaaeaaaaaeabaaahiabaaaoekaacaaaaia
abaaoeiaaeaaaaaeabaaahiabcaaoekaacaakkiaabaaoeiaaeaaaaaeabaaahia
bdaaoekaacaappiaabaaoeiaaeaaaaaeabaaahiaabaaoeiaabaappiaaaaablia
ecaaaaadabaacpiaabaaoeiaaaaioekaabaaaaacaaaaaciabjaaffkabcaaaaae
acaacbiaabaaaaiaaaaaffiabeaaaakaacaaaaadaaaacpiaaaaaaaiaacaaaaia
abaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcbeahaaaaeaaaaaaamfabaaaa
fjaaaaaeegiocaaaaaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabjaaaaaa
fjaaaaaeegiocaaaacaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaad
aagabaaaapaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaa
apaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaa
gcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacaeaaaaaa
efaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaa
aaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaa
aaaaaaaabkiacaaaaaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaa
aaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaa
aaaaaaaadkiacaaaaaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaa
dgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaa
ckbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaa
akaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaa
aaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaa
diaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaak
hcaabaaaaaaaaaaapgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaa
abaaaaaabnaaaaaipcaabaaaabaaaaaakgakbaaaaaaaaaaaegiocaaaabaaaaaa
agaaaaaaabaaaaakpcaabaaaabaaaaaaegaobaaaabaaaaaaaceaaaaaaaaaiadp
aaaaiadpaaaaiadpaaaaiadpdbaaaaaipcaabaaaacaaaaaakgakbaaaaaaaaaaa
egiocaaaabaaaaaaahaaaaaaabaaaaakpcaabaaaacaaaaaaegaobaaaacaaaaaa
aceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpdiaaaaahpcaabaaaabaaaaaa
egaobaaaabaaaaaaegaobaaaacaaaaaadiaaaaaipcaabaaaacaaaaaafgafbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaacaaaaaaegiocaaa
acaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaacaaaaaadcaaaaakpcaabaaa
acaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaacaaaaaa
dccaaaalbcaabaaaaaaaaaaackaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaa
dkiacaaaabaaaaaabiaaaaaaaaaaaaaipcaabaaaacaaaaaaegaobaaaacaaaaaa
egiocaaaacaaaaaaadaaaaaadiaaaaaiocaabaaaaaaaaaaafgafbaaaacaaaaaa
agijcaaaabaaaaaaanaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaa
amaaaaaaagaabaaaacaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaa
agijcaaaabaaaaaaaoaaaaaakgakbaaaacaaaaaafgaobaaaaaaaaaaadcaaaaak
ocaabaaaaaaaaaaaagijcaaaabaaaaaaapaaaaaapgapbaaaacaaaaaafgaobaaa
aaaaaaaadiaaaaahocaabaaaaaaaaaaafgafbaaaabaaaaaafgaobaaaaaaaaaaa
diaaaaaihcaabaaaadaaaaaafgafbaaaacaaaaaaegiccaaaabaaaaaaajaaaaaa
dcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaaiaaaaaaagaabaaaacaaaaaa
egacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaakaaaaaa
kgakbaaaacaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaa
abaaaaaaalaaaaaapgapbaaaacaaaaaaegacbaaaadaaaaaadcaaaaajocaabaaa
aaaaaaaaagajbaaaadaaaaaaagaabaaaabaaaaaafgaobaaaaaaaaaaadiaaaaai
hcaabaaaadaaaaaafgafbaaaacaaaaaaegiccaaaabaaaaaabbaaaaaadcaaaaak
hcaabaaaadaaaaaaegiccaaaabaaaaaabaaaaaaaagaabaaaacaaaaaaegacbaaa
adaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaabcaaaaaakgakbaaa
acaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaa
bdaaaaaapgapbaaaacaaaaaaegacbaaaadaaaaaadcaaaaajocaabaaaaaaaaaaa
agajbaaaadaaaaaakgakbaaaabaaaaaafgaobaaaaaaaaaaadiaaaaaihcaabaaa
abaaaaaafgafbaaaacaaaaaaegiccaaaabaaaaaabfaaaaaadcaaaaakhcaabaaa
abaaaaaaegiccaaaabaaaaaabeaaaaaaagaabaaaacaaaaaaegacbaaaabaaaaaa
dcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaabgaaaaaakgakbaaaacaaaaaa
egacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaabhaaaaaa
pgapbaaaacaaaaaaegacbaaaabaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaa
abaaaaaapgapbaaaabaaaaaafgaobaaaaaaaaaaaehaaaaalccaabaaaaaaaaaaa
jgafbaaaaaaaaaaaaghabaaaapaaaaaaaagabaaaapaaaaaadkaabaaaaaaaaaaa
aaaaaaajecaabaaaaaaaaaaaakiacaiaebaaaaaaabaaaaaabiaaaaaaabeaaaaa
aaaaiadpdcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaa
akiacaaaabaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaa
fgafbaaaaaaaaaaadoaaaaabfdegejdaaiaaaaaaiaaaaaaaaaaaaaaaejfdeheo
iaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaa
adadaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahahaaaagiaaaaaa
acaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaahbaaaaaaaaaaaaaaabaaaaaa
adaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdejfeejepeo
aaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Matrix 19 [_CameraToWorld]
Matrix 0 [unity_World2Shadow0]
Matrix 4 [unity_World2Shadow1]
Matrix 8 [unity_World2Shadow2]
Matrix 12 [unity_World2Shadow3] 3
Vector 26 [_LightShadowData]
Vector 23 [_ZBufferParams]
Vector 24 [unity_OrthoParams]
Vector 27 [unity_ShadowFadeCenterAndType]
Vector 15 [unity_ShadowSplitSpheres0]
Vector 16 [unity_ShadowSplitSpheres1]
Vector 17 [unity_ShadowSplitSpheres2]
Vector 18 [unity_ShadowSplitSpheres3]
Vector 25 [unity_ShadowSplitSqRadii]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_2_0
def c28, 1, 0, -0, -1
dcl t0.xy
dcl t1.xyz
dcl t2
dcl_2d s0
dcl_2d s1
texld r0, t0, s0
mov r1.xy, t2
mad r1.w, c23.x, r0.x, c23.y
rcp r1.w, r1.w
lrp r2.w, c24.w, r0.x, r1.w
lrp r1.z, r0.x, t2.w, t2.z
mad r0.xyz, t1, -r2.w, r1
mul r1.xyz, r2.w, t1
mad r0.xyz, c24.w, r0, r1
mov r0.w, c28.x
dp4 r1.x, c19, r0
dp4 r1.y, c20, r0
dp4 r1.z, c21, r0
dp4 r1.w, c22, r0
add r0.xyz, r1, -c15
dp3 r0.x, r0, r0
add r2.xyz, r1, -c16
dp3 r0.y, r2, r2
add r2.xyz, r1, -c17
dp3 r0.z, r2, r2
add r2.xyz, r1, -c18
dp3 r0.w, r2, r2
add r0, r0, -c25
cmp r2.xyz, r0, c28.z, c28.w
cmp r0, r0, c28.y, c28.x
add_pp r3.xy, r2, r0.yzxw
add_pp r3.z, r2.z, r0.w
max_pp r0.yzw, r3.wzyx, c28.y
dp4 r2.x, c4, r1
dp4 r2.y, c5, r1
dp4 r2.z, c6, r1
mul r2.xyz, r0.w, r2
dp4 r3.x, c0, r1
dp4 r3.y, c1, r1
dp4 r3.z, c2, r1
mad r2.xyz, r3, r0.x, r2
dp4 r3.x, c8, r1
dp4 r3.y, c9, r1
dp4 r3.z, c10, r1
mad r2.xyz, r3, r0.z, r2
dp4 r3.x, c12, r1
dp4 r3.y, c13, r1
dp4 r3.z, c14, r1
add r1.xyz, r1, -c27
dp3 r2.w, r1, r1
rsq r2.w, r2.w
rcp r2.w, r2.w
mad_sat_pp r2.w, r2.w, c26.z, c26.w
mad r0.xyz, r3, r0.y, r2
mov r0.w, c28.x
texldp_pp r0, r0, s1
mov r1.x, c28.x
lrp_pp r2.x, r0.x, r1.x, c26.x
add_pp r0, r2.w, r2.x
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 0 [unity_ShadowSplitSpheres0]
Vector 16 [unity_ShadowSplitSpheres1]
Vector 32 [unity_ShadowSplitSpheres2]
Vector 48 [unity_ShadowSplitSpheres3]
Vector 64 [unity_ShadowSplitSqRadii]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0
root12:acadacaa
eefiecedaiepmkhjgjdiajgoehgdnioakcbnbfncabaaaaaaheajaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcieaiaaaaeaaaaaaacbacaaaafjaaaaaeegiocaaa
aaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabkaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacaeaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaal
ccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaaaaaaaaaabkiacaaa
aaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadp
aaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaadkiacaaa
aaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaafdcaabaaa
abaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaackbabaiaebaaaaaa
acaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaaakaabaaaaaaaaaaa
ckaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaaaaaaaaaaagbjbaia
ebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaadiaaaaahhcaabaaa
abaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
pgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaaaaaaaaajhcaabaaaabaaaaaaegacbaaaaaaaaaaa
egiccaiaebaaaaaaabaaaaaaaaaaaaaabaaaaaahbcaabaaaabaaaaaaegacbaaa
abaaaaaaegacbaaaabaaaaaaaaaaaaajhcaabaaaacaaaaaaegacbaaaaaaaaaaa
egiccaiaebaaaaaaabaaaaaaabaaaaaabaaaaaahccaabaaaabaaaaaaegacbaaa
acaaaaaaegacbaaaacaaaaaaaaaaaaajhcaabaaaacaaaaaaegacbaaaaaaaaaaa
egiccaiaebaaaaaaabaaaaaaacaaaaaabaaaaaahecaabaaaabaaaaaaegacbaaa
acaaaaaaegacbaaaacaaaaaaaaaaaaajhcaabaaaacaaaaaaegacbaaaaaaaaaaa
egiccaiaebaaaaaaabaaaaaaadaaaaaabaaaaaahicaabaaaabaaaaaaegacbaaa
acaaaaaaegacbaaaacaaaaaadbaaaaaipcaabaaaabaaaaaaegaobaaaabaaaaaa
egiocaaaabaaaaaaaeaaaaaadhaaaaaphcaabaaaacaaaaaaegacbaaaabaaaaaa
aceaaaaaaaaaialpaaaaialpaaaaialpaaaaaaaaaceaaaaaaaaaaaiaaaaaaaia
aaaaaaiaaaaaaaaaabaaaaakpcaabaaaabaaaaaaegaobaaaabaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaiadpaaaaiadpaaaaaaahocaabaaaabaaaaaaagajbaaa
acaaaaaafgaobaaaabaaaaaadeaaaaakocaabaaaabaaaaaafgaobaaaabaaaaaa
aceaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaadiaaaaaihcaabaaaacaaaaaa
fgafbaaaaaaaaaaaegiccaaaabaaaaaaanaaaaaadcaaaaakhcaabaaaacaaaaaa
egiccaaaabaaaaaaamaaaaaaagaabaaaaaaaaaaaegacbaaaacaaaaaadcaaaaak
hcaabaaaacaaaaaaegiccaaaabaaaaaaaoaaaaaakgakbaaaaaaaaaaaegacbaaa
acaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaaapaaaaaapgapbaaa
aaaaaaaaegacbaaaacaaaaaadiaaaaahhcaabaaaacaaaaaafgafbaaaabaaaaaa
egacbaaaacaaaaaadiaaaaaihcaabaaaadaaaaaafgafbaaaaaaaaaaaegiccaaa
abaaaaaaajaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaaiaaaaaa
agaabaaaaaaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaa
abaaaaaaakaaaaaakgakbaaaaaaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaa
adaaaaaaegiccaaaabaaaaaaalaaaaaapgapbaaaaaaaaaaaegacbaaaadaaaaaa
dcaaaaajhcaabaaaacaaaaaaegacbaaaadaaaaaaagaabaaaabaaaaaaegacbaaa
acaaaaaadiaaaaaihcaabaaaadaaaaaafgafbaaaaaaaaaaaegiccaaaabaaaaaa
bbaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaabaaaaaaaagaabaaa
aaaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaa
bcaaaaaakgakbaaaaaaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaa
egiccaaaabaaaaaabdaaaaaapgapbaaaaaaaaaaaegacbaaaadaaaaaadcaaaaaj
hcaabaaaabaaaaaaegacbaaaadaaaaaakgakbaaaabaaaaaaegacbaaaacaaaaaa
diaaaaaihcaabaaaacaaaaaafgafbaaaaaaaaaaaegiccaaaabaaaaaabfaaaaaa
dcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaabeaaaaaaagaabaaaaaaaaaaa
egacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaabgaaaaaa
kgakbaaaaaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaa
abaaaaaabhaaaaaapgapbaaaaaaaaaaaegacbaaaacaaaaaaaaaaaaajhcaabaaa
aaaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaabaaaaaabjaaaaaabaaaaaah
bcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaelaaaaafbcaabaaa
aaaaaaaaakaabaaaaaaaaaaadccaaaalbcaabaaaaaaaaaaaakaabaaaaaaaaaaa
ckiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaabiaaaaaadcaaaaajocaabaaa
aaaaaaaaagajbaaaacaaaaaapgapbaaaabaaaaaaagajbaaaabaaaaaaehaaaaal
ccaabaaaaaaaaaaajgafbaaaaaaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaaaaaaaaajecaabaaaaaaaaaaaakiacaiaebaaaaaaabaaaaaa
biaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaa
ckaabaaaaaaaaaaaakiacaaaabaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaa
agaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 15 [_ShadowMapTexture] 2D 15
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 0 [unity_ShadowSplitSpheres0]
Vector 16 [unity_ShadowSplitSpheres1]
Vector 32 [unity_ShadowSplitSpheres2]
Vector 48 [unity_ShadowSplitSpheres3]
Vector 64 [unity_ShadowSplitSqRadii]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0_level_9_1
root12:baadbaaa
eefiecedggjepelpmnbilgpaenepehjnegmnngniabaaaaaacmaoaaaaafaaaaaa
deaaaaaaneaeaaaagaanaaaahaanaaaapianaaaaebgpgodjjiaeaaaajiaeaaaa
aaacppppdmaeaaaafmaaaaaaaeaacmaaaaaafmaaaaaafmaaacaaceaaaaaafmaa
apapaaaaaaaaabaaaaaaahaaacaaaaaaaaaaaaaaabaaaaaaafaaacaaaaaaaaaa
abaaaiaabcaaahaaaaaaaaaaacaaaaaaaeaabjaaaaaaaaaaaaacppppfbaaaaaf
bnaaapkaaaaaaaaaaaaaiadpaaaaaaiaaaaaialpbpaaaaacaaaaaaiaaaaaahla
bpaaaaacaaaaaaiaabaaahlabpaaaaacaaaaaaiaacaaaplabpaaaaacaaaaaaja
aaaiapkabpaaaaacaaaaaajaabaiapkaecaaaaadaaaaapiaaaaaoelaabaioeka
abaaaaacabaaadiaacaaoelaaeaaaaaeabaaaiiaaaaaaakaaaaaaaiaaaaaffka
agaaaaacabaaaiiaabaappiabcaaaaaeacaaaiiaabaappkaaaaaaaiaabaappia
bcaaaaaeabaaaeiaaaaaaaiaacaapplaacaakklaaeaaaaaeaaaaahiaabaaoela
acaappibabaaoeiaafaaaaadabaaahiaacaappiaabaaoelaaeaaaaaeaaaaahia
abaappkaaaaaoeiaabaaoeiaafaaaaadabaaapiaaaaaffiabkaaoekaaeaaaaae
abaaapiabjaaoekaaaaaaaiaabaaoeiaaeaaaaaeaaaaapiablaaoekaaaaakkia
abaaoeiaacaaaaadaaaaapiaaaaaoeiabmaaoekaacaaaaadabaaahiaaaaaoeia
acaaoekbaiaaaaadabaaabiaabaaoeiaabaaoeiaacaaaaadacaaahiaaaaaoeia
adaaoekbaiaaaaadabaaaciaacaaoeiaacaaoeiaacaaaaadacaaahiaaaaaoeia
aeaaoekbaiaaaaadabaaaeiaacaaoeiaacaaoeiaacaaaaadacaaahiaaaaaoeia
afaaoekbaiaaaaadabaaaiiaacaaoeiaacaaoeiaacaaaaadabaaapiaabaaoeia
agaaoekbfiaaaaaeacaaahiaabaaoeiabnaakkkabnaappkafiaaaaaeabaaapia
abaaoeiabnaaaakabnaaffkaacaaaaadadaacdiaacaaoeiaabaamjiaacaaaaad
adaaceiaacaakkiaabaappiaalaaaaadabaacoiaadaabliabnaaaakaafaaaaad
acaaahiaaaaaffiaamaaoekaaeaaaaaeacaaahiaalaaoekaaaaaaaiaacaaoeia
aeaaaaaeacaaahiaanaaoekaaaaakkiaacaaoeiaaeaaaaaeacaaahiaaoaaoeka
aaaappiaacaaoeiaafaaaaadacaaahiaabaappiaacaaoeiaafaaaaadadaaahia
aaaaffiaaiaaoekaaeaaaaaeadaaahiaahaaoekaaaaaaaiaadaaoeiaaeaaaaae
adaaahiaajaaoekaaaaakkiaadaaoeiaaeaaaaaeadaaahiaakaaoekaaaaappia
adaaoeiaaeaaaaaeacaaahiaadaaoeiaabaaaaiaacaaoeiaafaaaaadadaaahia
aaaaffiabaaaoekaaeaaaaaeadaaahiaapaaoekaaaaaaaiaadaaoeiaaeaaaaae
adaaahiabbaaoekaaaaakkiaadaaoeiaaeaaaaaeadaaahiabcaaoekaaaaappia
adaaoeiaaeaaaaaeacaaahiaadaaoeiaabaakkiaacaaoeiaafaaaaadadaaahia
aaaaffiabeaaoekaaeaaaaaeadaaahiabdaaoekaaaaaaaiaadaaoeiaaeaaaaae
adaaahiabfaaoekaaaaakkiaadaaoeiaaeaaaaaeadaaahiabgaaoekaaaaappia
adaaoeiaacaaaaadaaaaahiaaaaaoeiabiaaoekbaiaaaaadacaaaiiaaaaaoeia
aaaaoeiaahaaaaacacaaaiiaacaappiaagaaaaacacaaaiiaacaappiaaeaaaaae
acaadiiaacaappiabhaakkkabhaappkaaeaaaaaeaaaaahiaadaaoeiaabaaffia
acaaoeiaecaaaaadaaaacpiaaaaaoeiaaaaioekaabaaaaacaaaaaciabnaaffka
bcaaaaaeabaacbiaaaaaaaiaaaaaffiabhaaaakaacaaaaadaaaacpiaacaappia
abaaaaiaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcieaiaaaaeaaaaaaa
cbacaaaafjaaaaaeegiocaaaaaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaa
bkaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaa
fkaiaaadaagabaaaapaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaae
aahabaaaapaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaa
abaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaac
aeaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaa
aagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaa
akaabaaaaaaaaaaabkiacaaaaaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaa
aceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaai
ecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaak
ccaabaaaaaaaaaaadkiacaaaaaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaa
aaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaa
aaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaa
abaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaak
ncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaa
abaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaa
dcaaaaakhcaabaaaaaaaaaaapgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaa
egacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaa
acaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaa
agaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipcaabaaa
aaaaaaaaegaobaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaaaaaaaaajhcaabaaa
abaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaabaaaaaaaaaaaaaabaaaaaah
bcaabaaaabaaaaaaegacbaaaabaaaaaaegacbaaaabaaaaaaaaaaaaajhcaabaaa
acaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaabaaaaaaabaaaaaabaaaaaah
ccaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaaaaaaaaajhcaabaaa
acaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaabaaaaaaacaaaaaabaaaaaah
ecaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaaaaaaaaajhcaabaaa
acaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaabaaaaaaadaaaaaabaaaaaah
icaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaadbaaaaaipcaabaaa
abaaaaaaegaobaaaabaaaaaaegiocaaaabaaaaaaaeaaaaaadhaaaaaphcaabaaa
acaaaaaaegacbaaaabaaaaaaaceaaaaaaaaaialpaaaaialpaaaaialpaaaaaaaa
aceaaaaaaaaaaaiaaaaaaaiaaaaaaaiaaaaaaaaaabaaaaakpcaabaaaabaaaaaa
egaobaaaabaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpaaaaaaah
ocaabaaaabaaaaaaagajbaaaacaaaaaafgaobaaaabaaaaaadeaaaaakocaabaaa
abaaaaaafgaobaaaabaaaaaaaceaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
diaaaaaihcaabaaaacaaaaaafgafbaaaaaaaaaaaegiccaaaabaaaaaaanaaaaaa
dcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaaamaaaaaaagaabaaaaaaaaaaa
egacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaaaoaaaaaa
kgakbaaaaaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaa
abaaaaaaapaaaaaapgapbaaaaaaaaaaaegacbaaaacaaaaaadiaaaaahhcaabaaa
acaaaaaafgafbaaaabaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaaadaaaaaa
fgafbaaaaaaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaadaaaaaa
egiccaaaabaaaaaaaiaaaaaaagaabaaaaaaaaaaaegacbaaaadaaaaaadcaaaaak
hcaabaaaadaaaaaaegiccaaaabaaaaaaakaaaaaakgakbaaaaaaaaaaaegacbaaa
adaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaaalaaaaaapgapbaaa
aaaaaaaaegacbaaaadaaaaaadcaaaaajhcaabaaaacaaaaaaegacbaaaadaaaaaa
agaabaaaabaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaaadaaaaaafgafbaaa
aaaaaaaaegiccaaaabaaaaaabbaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaa
abaaaaaabaaaaaaaagaabaaaaaaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaa
adaaaaaaegiccaaaabaaaaaabcaaaaaakgakbaaaaaaaaaaaegacbaaaadaaaaaa
dcaaaaakhcaabaaaadaaaaaaegiccaaaabaaaaaabdaaaaaapgapbaaaaaaaaaaa
egacbaaaadaaaaaadcaaaaajhcaabaaaabaaaaaaegacbaaaadaaaaaakgakbaaa
abaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaaaaaaaaaa
egiccaaaabaaaaaabfaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaabaaaaaa
beaaaaaaagaabaaaaaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaa
egiccaaaabaaaaaabgaaaaaakgakbaaaaaaaaaaaegacbaaaacaaaaaadcaaaaak
hcaabaaaacaaaaaaegiccaaaabaaaaaabhaaaaaapgapbaaaaaaaaaaaegacbaaa
acaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaa
abaaaaaabjaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaa
aaaaaaaaelaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaadccaaaalbcaabaaa
aaaaaaaaakaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaa
biaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaaacaaaaaapgapbaaaabaaaaaa
agajbaaaabaaaaaaehaaaaalccaabaaaaaaaaaaajgafbaaaaaaaaaaaaghabaaa
apaaaaaaaagabaaaapaaaaaadkaabaaaaaaaaaaaaaaaaaajecaabaaaaaaaaaaa
akiacaiaebaaaaaaabaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaa
aaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaaabaaaaaabiaaaaaa
aaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab
fdegejdaaiaaaaaaiaaaaaaaaaaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaa
giaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaa
aaaaaaaaadaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaa
acaaaaaaapapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaa
feeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Matrix 0 [_CameraToWorld]
Matrix 4 [unity_World2Shadow0] 3
Vector 9 [_LightShadowData]
Vector 7 [_ZBufferParams]
Vector 8 [unity_OrthoParams]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_2_0
def c10, 1, 0, 0, 0
dcl t0.xy
dcl t1.xyz
dcl t2
dcl_2d s0
dcl_2d s1
texld r0, t0, s0
mov r1.w, c10.x
mov r2.xy, t2
mad r2.w, c7.x, r0.x, c7.y
rcp r2.w, r2.w
lrp r3.w, c8.w, r0.x, r2.w
lrp r2.z, r0.x, t2.w, t2.z
mad r0.xyz, t1, -r3.w, r2
mul r2.xyz, r3.w, t1
mad r0.xyz, c8.w, r0, r2
mad_sat r2.x, r0.z, c9.z, c9.w
mov r0.w, c10.x
dp4 r3.x, c0, r0
dp4 r3.y, c1, r0
dp4 r3.z, c2, r0
dp4 r3.w, c3, r0
dp4 r1.x, c4, r3
dp4 r1.y, c5, r3
dp4 r1.z, c6, r3
texldp_pp r0, r1, s1
mov r1.x, c9.x
add_pp r0.y, -r1.x, c10.x
mad_pp r0.x, r0.x, r0.y, c9.x
add_pp r0, r2.x, r0.x
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0
root12:acadacaa
eefiecedmbbnfjolbhjbbmhmliodhhklhfehpiceabaaaaaaaiafaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcbiaeaaaaeaaaaaaaagabaaaafjaaaaaeegiocaaa
aaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabjaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacacaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaal
ccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaaaaaaaaaabkiacaaa
aaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadp
aaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaadkiacaaa
aaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaafdcaabaaa
abaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaackbabaiaebaaaaaa
acaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaaakaabaaaaaaaaaaa
ckaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaaaaaaaaaaagbjbaia
ebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaadiaaaaahhcaabaaa
abaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
pgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaadccaaaalbcaabaaaaaaaaaaackaabaaaaaaaaaaa
ckiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaabiaaaaaaaaaaaaaipcaabaaa
abaaaaaaegaobaaaabaaaaaaegiocaaaacaaaaaaadaaaaaadiaaaaaiocaabaaa
aaaaaaaafgafbaaaabaaaaaaagijcaaaabaaaaaaajaaaaaadcaaaaakocaabaaa
aaaaaaaaagijcaaaabaaaaaaaiaaaaaaagaabaaaabaaaaaafgaobaaaaaaaaaaa
dcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaaakaaaaaakgakbaaaabaaaaaa
fgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaaalaaaaaa
pgapbaaaabaaaaaafgaobaaaaaaaaaaaehaaaaalccaabaaaaaaaaaaajgafbaaa
aaaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaaaaaaaaj
ecaabaaaaaaaaaaaakiacaiaebaaaaaaabaaaaaabiaaaaaaabeaaaaaaaaaiadp
dcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaa
abaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 15 [_ShadowMapTexture] 2D 15
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0_level_9_1
root12:baadbaaa
eefiecediplmgoiiomggnejabejpeanihmioocapabaaaaaaiaahaaaaafaaaaaa
deaaaaaajeacaaaaleagaaaameagaaaaemahaaaaebgpgodjfiacaaaafiacaaaa
aaacpppppmabaaaafmaaaaaaaeaacmaaaaaafmaaaaaafmaaacaaceaaaaaafmaa
apapaaaaaaaaabaaaaaaahaaacaaaaaaaaaaaaaaabaaaiaaaeaaacaaaaaaaaaa
abaabiaaabaaagaaaaaaaaaaacaaaaaaaeaaahaaaaaaaaaaaaacppppfbaaaaaf
alaaapkaaaaaiadpaaaaaaaaaaaaaaaaaaaaaaaabpaaaaacaaaaaaiaaaaaahla
bpaaaaacaaaaaaiaabaaahlabpaaaaacaaaaaaiaacaaaplabpaaaaacaaaaaaja
aaaiapkabpaaaaacaaaaaajaabaiapkaecaaaaadaaaaapiaaaaaoelaabaioeka
abaaaaacabaaadiaacaaoelaaeaaaaaeabaaaiiaaaaaaakaaaaaaaiaaaaaffka
agaaaaacabaaaiiaabaappiabcaaaaaeacaaaiiaabaappkaaaaaaaiaabaappia
bcaaaaaeabaaaeiaaaaaaaiaacaapplaacaakklaaeaaaaaeaaaaahiaabaaoela
acaappibabaaoeiaafaaaaadabaaahiaacaappiaabaaoelaaeaaaaaeaaaaahia
abaappkaaaaaoeiaabaaoeiaafaaaaadabaaapiaaaaaffiaaiaaoekaaeaaaaae
abaaapiaahaaoekaaaaaaaiaabaaoeiaaeaaaaaeabaaapiaajaaoekaaaaakkia
abaaoeiaaeaaaaaeaaaabbiaaaaakkiaagaakkkaagaappkaacaaaaadabaaapia
abaaoeiaakaaoekaafaaaaadaaaaaoiaabaaffiaadaablkaaeaaaaaeaaaaaoia
acaablkaabaaaaiaaaaaoeiaaeaaaaaeaaaaaoiaaeaablkaabaakkiaaaaaoeia
aeaaaaaeabaaahiaafaaoekaabaappiaaaaabliaecaaaaadabaacpiaabaaoeia
aaaioekaabaaaaacacaaabiaagaaaakaacaaaaadaaaacciaacaaaaibalaaaaka
aeaaaaaeaaaacciaabaaaaiaaaaaffiaagaaaakaacaaaaadaaaacpiaaaaaaaia
aaaaffiaabaaaaacaaaicpiaaaaaoeiappppaaaafdeieefcbiaeaaaaeaaaaaaa
agabaaaafjaaaaaeegiocaaaaaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaa
bjaaaaaafjaaaaaeegiocaaaacaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaa
fkaiaaadaagabaaaapaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaae
aahabaaaapaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaa
abaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaac
acaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaa
aagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaa
akaabaaaaaaaaaaabkiacaaaaaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaa
aceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaai
ecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaak
ccaabaaaaaaaaaaadkiacaaaaaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaa
aaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaa
aaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaa
abaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaak
ncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaa
abaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaa
dcaaaaakhcaabaaaaaaaaaaapgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaa
egacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaa
acaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaa
agaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaa
acaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaadccaaaalbcaabaaa
aaaaaaaackaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaa
biaaaaaaaaaaaaaipcaabaaaabaaaaaaegaobaaaabaaaaaaegiocaaaacaaaaaa
adaaaaaadiaaaaaiocaabaaaaaaaaaaafgafbaaaabaaaaaaagijcaaaabaaaaaa
ajaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaaaiaaaaaaagaabaaa
abaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaabaaaaaa
akaaaaaakgakbaaaabaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaa
agijcaaaabaaaaaaalaaaaaapgapbaaaabaaaaaafgaobaaaaaaaaaaaehaaaaal
ccaabaaaaaaaaaaajgafbaaaaaaaaaaaaghabaaaapaaaaaaaagabaaaapaaaaaa
dkaabaaaaaaaaaaaaaaaaaajecaabaaaaaaaaaaaakiacaiaebaaaaaaabaaaaaa
biaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaa
ckaabaaaaaaaaaaaakiacaaaabaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaa
agaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaabfdegejdaaiaaaaaaiaaaaaaa
aaaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaa
ahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapapaaaahbaaaaaa
aaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfp
faepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaaaiaaaaaacaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfegbhcghgfheaaklkl
"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Matrix 0 [_CameraToWorld]
Matrix 4 [unity_World2Shadow0] 3
Vector 9 [_LightShadowData]
Vector 7 [_ZBufferParams]
Vector 8 [unity_OrthoParams]
Vector 10 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_2_0
def c11, 1, 0, 0, 0
dcl t0.xy
dcl t1.xyz
dcl t2
dcl_2d s0
dcl_2d s1
texld r0, t0, s0
mov r1.w, c11.x
mov r2.xy, t2
mad r2.w, c7.x, r0.x, c7.y
rcp r2.w, r2.w
lrp r3.w, c8.w, r0.x, r2.w
lrp r2.z, r0.x, t2.w, t2.z
mad r0.xyz, t1, -r3.w, r2
mul r2.xyz, r3.w, t1
mad r0.xyz, c8.w, r0, r2
mov r0.w, c11.x
dp4 r2.w, c3, r0
dp4 r2.x, c0, r0
dp4 r2.y, c1, r0
dp4 r2.z, c2, r0
dp4 r1.x, c4, r2
dp4 r1.y, c5, r2
dp4 r1.z, c6, r2
add r0.xyz, r2, -c10
dp3 r0.x, r0, r0
rsq r0.x, r0.x
rcp r0.x, r0.x
mad_sat_pp r0.x, r0.x, c9.z, c9.w
texldp_pp r1, r1, s1
mov r2.x, c9.x
add_pp r0.y, -r2.x, c11.x
mad_pp r0.y, r1.x, r0.y, c9.x
add_pp r0, r0.x, r0.y
mov_pp oC0, r0

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0
root12:acadacaa
eefiecedomhhkjonmllbogpljejejmlpelpleobnabaaaaaafmafaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcgmaeaaaaeaaaaaaablabaaaafjaaaaaeegiocaaa
aaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabkaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaadaagabaaaabaaaaaa
fibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaabaaaaaaffffaaaa
gcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaagcbaaaadpcbabaaa
acaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacacaaaaaaefaaaaajpcaabaaa
aaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaadcaaaaal
ccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaaaaaaaaaabkiacaaa
aaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaaaaaaiadpaaaaiadp
aaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaabkaabaia
ebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaadkiacaaa
aaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaafdcaabaaa
abaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaackbabaiaebaaaaaa
acaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaaakaabaaaaaaaaaaa
ckaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaaaaaaaaaaagbjbaia
ebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaadiaaaaahhcaabaaa
abaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaakhcaabaaaaaaaaaaa
pgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaaabaaaaaadiaaaaai
pcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaak
pcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaa
abaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaacaaaaaakgakbaaa
aaaaaaaaegaobaaaabaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaa
egiocaaaacaaaaaaadaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaa
aiaaaaaaagaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaa
egiccaaaabaaaaaaakaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaapgapbaaaaaaaaaaaegacbaaa
abaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaa
abaaaaaabjaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaaegacbaaa
aaaaaaaaelaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaadccaaaalbcaabaaa
aaaaaaaaakaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaadkiacaaaabaaaaaa
biaaaaaaehaaaaalccaabaaaaaaaaaaaegaabaaaabaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaackaabaaaabaaaaaaaaaaaaajecaabaaaaaaaaaaaakiacaia
ebaaaaaaabaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaa
bkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaaabaaaaaabiaaaaaaaaaaaaah
pccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES"
}
SubProgram "d3d11_9x " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 15 [_ShadowMapTexture] 2D 15
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "UnityPerCamera" 0
BindCB  "UnityShadows" 1
BindCB  "UnityPerCamera2" 2
"ps_4_0_level_9_1
root12:baadbaaa
eefiecedoabedpdlepjckcbfegodbioolllneiamabaaaaaaamaiaaaaafaaaaaa
deaaaaaammacaaaaeaahaaaafaahaaaaniahaaaaebgpgodjjaacaaaajaacaaaa
aaacppppdeacaaaafmaaaaaaaeaacmaaaaaafmaaaaaafmaaacaaceaaaaaafmaa
apapaaaaaaaaabaaaaaaahaaacaaaaaaaaaaaaaaabaaaiaaaeaaacaaaaaaaaaa
abaabiaaacaaagaaaaaaaaaaacaaaaaaaeaaaiaaaaaaaaaaaaacppppfbaaaaaf
amaaapkaaaaaiadpaaaaaaaaaaaaaaaaaaaaaaaabpaaaaacaaaaaaiaaaaaahla
bpaaaaacaaaaaaiaabaaahlabpaaaaacaaaaaaiaacaaaplabpaaaaacaaaaaaja
aaaiapkabpaaaaacaaaaaajaabaiapkaecaaaaadaaaaapiaaaaaoelaabaioeka
abaaaaacabaaadiaacaaoelaaeaaaaaeabaaaiiaaaaaaakaaaaaaaiaaaaaffka
agaaaaacabaaaiiaabaappiabcaaaaaeacaaaiiaabaappkaaaaaaaiaabaappia
bcaaaaaeabaaaeiaaaaaaaiaacaapplaacaakklaaeaaaaaeaaaaahiaabaaoela
acaappibabaaoeiaafaaaaadabaaahiaacaappiaabaaoelaaeaaaaaeaaaaahia
abaappkaaaaaoeiaabaaoeiaafaaaaadabaaapiaaaaaffiaajaaoekaaeaaaaae
abaaapiaaiaaoekaaaaaaaiaabaaoeiaaeaaaaaeaaaaapiaakaaoekaaaaakkia
abaaoeiaacaaaaadaaaaapiaaaaaoeiaalaaoekaafaaaaadabaaahiaaaaaffia
adaaoekaaeaaaaaeabaaahiaacaaoekaaaaaaaiaabaaoeiaaeaaaaaeabaaahia
aeaaoekaaaaakkiaabaaoeiaaeaaaaaeabaaahiaafaaoekaaaaappiaabaaoeia
acaaaaadaaaaahiaaaaaoeiaahaaoekbaiaaaaadabaaaiiaaaaaoeiaaaaaoeia
ahaaaaacabaaaiiaabaappiaagaaaaacabaaaiiaabaappiaaeaaaaaeabaadiia
abaappiaagaakkkaagaappkaecaaaaadaaaacpiaabaaoeiaaaaioekaabaaaaac
abaaabiaagaaaakaacaaaaadaaaacciaabaaaaibamaaaakaaeaaaaaeaaaacbia
aaaaaaiaaaaaffiaagaaaakaacaaaaadaaaacpiaabaappiaaaaaaaiaabaaaaac
aaaicpiaaaaaoeiappppaaaafdeieefcgmaeaaaaeaaaaaaablabaaaafjaaaaae
egiocaaaaaaaaaaaajaaaaaafjaaaaaeegiocaaaabaaaaaabkaaaaaafjaaaaae
egiocaaaacaaaaaaaeaaaaaafkaaaaadaagabaaaaaaaaaaafkaiaaadaagabaaa
apaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaafibiaaaeaahabaaaapaaaaaa
ffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaadhcbabaaaabaaaaaagcbaaaad
pcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaagiaaaaacacaaaaaaefaaaaaj
pcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaaaaaaaaaaaagabaaaaaaaaaaa
dcaaaaalccaabaaaaaaaaaaaakiacaaaaaaaaaaaahaaaaaaakaabaaaaaaaaaaa
bkiacaaaaaaaaaaaahaaaaaaaoaaaaakccaabaaaaaaaaaaaaceaaaaaaaaaiadp
aaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaaaaaaaaaiecaabaaaaaaaaaaa
bkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaadcaaaaakccaabaaaaaaaaaaa
dkiacaaaaaaaaaaaaiaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadgaaaaaf
dcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaaiecaabaaaaaaaaaaackbabaia
ebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaajecaabaaaabaaaaaaakaabaaa
aaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaadcaaaaakncaabaaaaaaaaaaa
agbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaaagajbaaaabaaaaaadiaaaaah
hcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaaabaaaaaadcaaaaakhcaabaaa
aaaaaaaapgipcaaaaaaaaaaaaiaaaaaaigadbaaaaaaaaaaaegacbaaaabaaaaaa
diaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaaegiocaaaacaaaaaaabaaaaaa
dcaaaaakpcaabaaaabaaaaaaegiocaaaacaaaaaaaaaaaaaaagaabaaaaaaaaaaa
egaobaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaacaaaaaa
kgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaa
aaaaaaaaegiocaaaacaaaaaaadaaaaaadiaaaaaihcaabaaaabaaaaaafgafbaaa
aaaaaaaaegiccaaaabaaaaaaajaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaa
abaaaaaaaiaaaaaaagaabaaaaaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaa
abaaaaaaegiccaaaabaaaaaaakaaaaaakgakbaaaaaaaaaaaegacbaaaabaaaaaa
dcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaalaaaaaapgapbaaaaaaaaaaa
egacbaaaabaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaia
ebaaaaaaabaaaaaabjaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaaelaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaadccaaaal
bcaabaaaaaaaaaaaakaabaaaaaaaaaaackiacaaaabaaaaaabiaaaaaadkiacaaa
abaaaaaabiaaaaaaehaaaaalccaabaaaaaaaaaaaegaabaaaabaaaaaaaghabaaa
apaaaaaaaagabaaaapaaaaaackaabaaaabaaaaaaaaaaaaajecaabaaaaaaaaaaa
akiacaiaebaaaaaaabaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaa
aaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaaabaaaaaabiaaaaaa
aaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab
fdegejdaaiaaaaaaiaaaaaaaaaaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaa
giaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaa
aaaaaaaaadaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaa
acaaaaaaapapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaa
feeffiedepepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaa
abaaaaaaaiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaa
fdfgfpfegbhcghgfheaaklkl"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GL3x"
}
}
 }
}
SubShader { 
 Tags { "ShadowmapFilter"="PCF_5x5" }
 Pass {
  Tags { "ShadowmapFilter"="PCF_5x5" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 97017
Program "vp" {
SubProgram "gles " {
Keywords { "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 _LightSplitsNear;
uniform highp vec4 _LightSplitsFar;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7 = (_CameraToWorld * tmpvar_6);
  bvec4 tmpvar_8;
  tmpvar_8 = greaterThanEqual (tmpvar_5.zzzz, _LightSplitsNear);
  bvec4 tmpvar_9;
  tmpvar_9 = lessThan (tmpvar_5.zzzz, _LightSplitsFar);
  lowp vec4 tmpvar_10;
  tmpvar_10 = (vec4(tmpvar_8) * vec4(tmpvar_9));
  highp vec4 tmpvar_11;
  tmpvar_11.w = 1.0;
  tmpvar_11.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_7).xyz * tmpvar_10.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_7).xyz * tmpvar_10.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_7)
  .xyz * tmpvar_10.z)) + ((unity_World2Shadow[3] * tmpvar_7).xyz * tmpvar_10.w));
  mediump float shadow_12;
  shadow_12 = 0.0;
  highp vec2 tmpvar_13;
  tmpvar_13 = _ShadowMapTexture_TexelSize.xy;
  highp vec3 tmpvar_14;
  tmpvar_14.xy = (tmpvar_11.xy - _ShadowMapTexture_TexelSize.xy);
  tmpvar_14.z = tmpvar_11.z;
  highp vec4 tmpvar_15;
  tmpvar_15 = texture2D (_ShadowMapTexture, tmpvar_14.xy);
  mediump float tmpvar_16;
  if ((tmpvar_15.x < tmpvar_11.z)) {
    tmpvar_16 = 0.0;
  } else {
    tmpvar_16 = 1.0;
  };
  shadow_12 = tmpvar_16;
  highp vec2 tmpvar_17;
  tmpvar_17.x = 0.0;
  tmpvar_17.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_18;
  tmpvar_18.xy = (tmpvar_11.xy + tmpvar_17);
  tmpvar_18.z = tmpvar_11.z;
  highp vec4 tmpvar_19;
  tmpvar_19 = texture2D (_ShadowMapTexture, tmpvar_18.xy);
  highp float tmpvar_20;
  if ((tmpvar_19.x < tmpvar_11.z)) {
    tmpvar_20 = 0.0;
  } else {
    tmpvar_20 = 1.0;
  };
  shadow_12 = (tmpvar_16 + tmpvar_20);
  highp vec2 tmpvar_21;
  tmpvar_21.x = tmpvar_13.x;
  tmpvar_21.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_11.xy + tmpvar_21);
  tmpvar_22.z = tmpvar_11.z;
  highp vec4 tmpvar_23;
  tmpvar_23 = texture2D (_ShadowMapTexture, tmpvar_22.xy);
  highp float tmpvar_24;
  if ((tmpvar_23.x < tmpvar_11.z)) {
    tmpvar_24 = 0.0;
  } else {
    tmpvar_24 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_24);
  highp vec2 tmpvar_25;
  tmpvar_25.y = 0.0;
  tmpvar_25.x = -(_ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_26;
  tmpvar_26.xy = (tmpvar_11.xy + tmpvar_25);
  tmpvar_26.z = tmpvar_11.z;
  highp vec4 tmpvar_27;
  tmpvar_27 = texture2D (_ShadowMapTexture, tmpvar_26.xy);
  highp float tmpvar_28;
  if ((tmpvar_27.x < tmpvar_11.z)) {
    tmpvar_28 = 0.0;
  } else {
    tmpvar_28 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_28);
  highp vec4 tmpvar_29;
  tmpvar_29 = texture2D (_ShadowMapTexture, tmpvar_11.xy);
  highp float tmpvar_30;
  if ((tmpvar_29.x < tmpvar_11.z)) {
    tmpvar_30 = 0.0;
  } else {
    tmpvar_30 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_30);
  highp vec2 tmpvar_31;
  tmpvar_31.y = 0.0;
  tmpvar_31.x = tmpvar_13.x;
  highp vec3 tmpvar_32;
  tmpvar_32.xy = (tmpvar_11.xy + tmpvar_31);
  tmpvar_32.z = tmpvar_11.z;
  highp vec4 tmpvar_33;
  tmpvar_33 = texture2D (_ShadowMapTexture, tmpvar_32.xy);
  highp float tmpvar_34;
  if ((tmpvar_33.x < tmpvar_11.z)) {
    tmpvar_34 = 0.0;
  } else {
    tmpvar_34 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_34);
  highp vec2 tmpvar_35;
  tmpvar_35.x = -(_ShadowMapTexture_TexelSize.x);
  tmpvar_35.y = tmpvar_13.y;
  highp vec3 tmpvar_36;
  tmpvar_36.xy = (tmpvar_11.xy + tmpvar_35);
  tmpvar_36.z = tmpvar_11.z;
  highp vec4 tmpvar_37;
  tmpvar_37 = texture2D (_ShadowMapTexture, tmpvar_36.xy);
  highp float tmpvar_38;
  if ((tmpvar_37.x < tmpvar_11.z)) {
    tmpvar_38 = 0.0;
  } else {
    tmpvar_38 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_38);
  highp vec2 tmpvar_39;
  tmpvar_39.x = 0.0;
  tmpvar_39.y = tmpvar_13.y;
  highp vec3 tmpvar_40;
  tmpvar_40.xy = (tmpvar_11.xy + tmpvar_39);
  tmpvar_40.z = tmpvar_11.z;
  highp vec4 tmpvar_41;
  tmpvar_41 = texture2D (_ShadowMapTexture, tmpvar_40.xy);
  highp float tmpvar_42;
  if ((tmpvar_41.x < tmpvar_11.z)) {
    tmpvar_42 = 0.0;
  } else {
    tmpvar_42 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_42);
  highp vec3 tmpvar_43;
  tmpvar_43.xy = (tmpvar_11.xy + _ShadowMapTexture_TexelSize.xy);
  tmpvar_43.z = tmpvar_11.z;
  highp vec4 tmpvar_44;
  tmpvar_44 = texture2D (_ShadowMapTexture, tmpvar_43.xy);
  highp float tmpvar_45;
  if ((tmpvar_44.x < tmpvar_11.z)) {
    tmpvar_45 = 0.0;
  } else {
    tmpvar_45 = 1.0;
  };
  shadow_12 = (shadow_12 + tmpvar_45);
  shadow_12 = (shadow_12 / 9.0);
  mediump float tmpvar_46;
  tmpvar_46 = mix (_LightShadowData.x, 1.0, shadow_12);
  shadow_12 = tmpvar_46;
  highp float tmpvar_47;
  tmpvar_47 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (tmpvar_46 + tmpvar_47);
  mediump vec4 tmpvar_48;
  tmpvar_48 = vec4(shadow_2);
  tmpvar_1 = tmpvar_48;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform vec4 _LightSplitsNear;
uniform vec4 _LightSplitsFar;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
uniform vec4 _ShadowMapTexture_TexelSize;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec3 tmpvar_3;
  tmpvar_3 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = tmpvar_3;
  vec4 tmpvar_5;
  tmpvar_5 = (_CameraToWorld * tmpvar_4);
  vec4 tmpvar_6;
  tmpvar_6 = (vec4(greaterThanEqual (tmpvar_3.zzzz, _LightSplitsNear)) * vec4(lessThan (tmpvar_3.zzzz, _LightSplitsFar)));
  vec4 tmpvar_7;
  tmpvar_7.w = 1.0;
  tmpvar_7.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_5).xyz * tmpvar_6.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_5).xyz * tmpvar_6.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_5)
  .xyz * tmpvar_6.z)) + ((unity_World2Shadow[3] * tmpvar_5).xyz * tmpvar_6.w));
  vec3 accum_8;
  float sum_9;
  float shadow_10;
  vec3 v_11;
  vec3 u_12;
  vec2 tmpvar_13;
  tmpvar_13 = ((tmpvar_7.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  vec2 tmpvar_14;
  tmpvar_14 = ((floor(tmpvar_13) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  vec2 tmpvar_15;
  tmpvar_15 = fract(tmpvar_13);
  vec3 tmpvar_16;
  tmpvar_16.y = 7.0;
  tmpvar_16.x = (4.0 - (3.0 * tmpvar_15.x));
  tmpvar_16.z = (1.0 + (3.0 * tmpvar_15.x));
  vec3 tmpvar_17;
  tmpvar_17.x = (((3.0 - 
    (2.0 * tmpvar_15.x)
  ) / tmpvar_16.x) - 2.0);
  tmpvar_17.y = ((3.0 + tmpvar_15.x) / 7.0);
  tmpvar_17.z = ((tmpvar_15.x / tmpvar_16.z) + 2.0);
  u_12 = (tmpvar_17 * _ShadowMapTexture_TexelSize.x);
  vec3 tmpvar_18;
  tmpvar_18.y = 7.0;
  tmpvar_18.x = (4.0 - (3.0 * tmpvar_15.y));
  tmpvar_18.z = (1.0 + (3.0 * tmpvar_15.y));
  vec3 tmpvar_19;
  tmpvar_19.x = (((3.0 - 
    (2.0 * tmpvar_15.y)
  ) / tmpvar_18.x) - 2.0);
  tmpvar_19.y = ((3.0 + tmpvar_15.y) / 7.0);
  tmpvar_19.z = ((tmpvar_15.y / tmpvar_18.z) + 2.0);
  v_11 = (tmpvar_19 * _ShadowMapTexture_TexelSize.y);
  vec3 tmpvar_20;
  tmpvar_20 = (tmpvar_16 * tmpvar_18.x);
  vec2 tmpvar_21;
  tmpvar_21.x = u_12.x;
  tmpvar_21.y = v_11.x;
  float depth_22;
  depth_22 = tmpvar_7.z;
  vec3 uv_23;
  vec3 tmpvar_24;
  tmpvar_24.xy = (tmpvar_14 + tmpvar_21);
  tmpvar_24.z = depth_22;
  uv_23.xy = tmpvar_24.xy;
  uv_23.z = depth_22;
  sum_9 = (tmpvar_20.x * shadow2D (_ShadowMapTexture, uv_23).x);
  vec2 tmpvar_25;
  tmpvar_25.x = u_12.y;
  tmpvar_25.y = v_11.x;
  float depth_26;
  depth_26 = tmpvar_7.z;
  vec3 uv_27;
  vec3 tmpvar_28;
  tmpvar_28.xy = (tmpvar_14 + tmpvar_25);
  tmpvar_28.z = depth_26;
  uv_27.xy = tmpvar_28.xy;
  uv_27.z = depth_26;
  sum_9 = (sum_9 + (tmpvar_20.y * shadow2D (_ShadowMapTexture, uv_27).x));
  vec2 tmpvar_29;
  tmpvar_29.x = u_12.z;
  tmpvar_29.y = v_11.x;
  float depth_30;
  depth_30 = tmpvar_7.z;
  vec3 uv_31;
  vec3 tmpvar_32;
  tmpvar_32.xy = (tmpvar_14 + tmpvar_29);
  tmpvar_32.z = depth_30;
  uv_31.xy = tmpvar_32.xy;
  uv_31.z = depth_30;
  sum_9 = (sum_9 + (tmpvar_20.z * shadow2D (_ShadowMapTexture, uv_31).x));
  accum_8 = (tmpvar_16 * 7.0);
  vec2 tmpvar_33;
  tmpvar_33.x = u_12.x;
  tmpvar_33.y = v_11.y;
  float depth_34;
  depth_34 = tmpvar_7.z;
  vec3 uv_35;
  vec3 tmpvar_36;
  tmpvar_36.xy = (tmpvar_14 + tmpvar_33);
  tmpvar_36.z = depth_34;
  uv_35.xy = tmpvar_36.xy;
  uv_35.z = depth_34;
  sum_9 = (sum_9 + (accum_8.x * shadow2D (_ShadowMapTexture, uv_35).x));
  vec2 tmpvar_37;
  tmpvar_37.x = u_12.y;
  tmpvar_37.y = v_11.y;
  float depth_38;
  depth_38 = tmpvar_7.z;
  vec3 uv_39;
  vec3 tmpvar_40;
  tmpvar_40.xy = (tmpvar_14 + tmpvar_37);
  tmpvar_40.z = depth_38;
  uv_39.xy = tmpvar_40.xy;
  uv_39.z = depth_38;
  sum_9 = (sum_9 + (accum_8.y * shadow2D (_ShadowMapTexture, uv_39).x));
  vec2 tmpvar_41;
  tmpvar_41.x = u_12.z;
  tmpvar_41.y = v_11.y;
  float depth_42;
  depth_42 = tmpvar_7.z;
  vec3 uv_43;
  vec3 tmpvar_44;
  tmpvar_44.xy = (tmpvar_14 + tmpvar_41);
  tmpvar_44.z = depth_42;
  uv_43.xy = tmpvar_44.xy;
  uv_43.z = depth_42;
  sum_9 = (sum_9 + (accum_8.z * shadow2D (_ShadowMapTexture, uv_43).x));
  accum_8 = (tmpvar_16 * tmpvar_18.z);
  vec2 tmpvar_45;
  tmpvar_45.x = u_12.x;
  tmpvar_45.y = v_11.z;
  float depth_46;
  depth_46 = tmpvar_7.z;
  vec3 uv_47;
  vec3 tmpvar_48;
  tmpvar_48.xy = (tmpvar_14 + tmpvar_45);
  tmpvar_48.z = depth_46;
  uv_47.xy = tmpvar_48.xy;
  uv_47.z = depth_46;
  sum_9 = (sum_9 + (accum_8.x * shadow2D (_ShadowMapTexture, uv_47).x));
  vec2 tmpvar_49;
  tmpvar_49.x = u_12.y;
  tmpvar_49.y = v_11.z;
  float depth_50;
  depth_50 = tmpvar_7.z;
  vec3 uv_51;
  vec3 tmpvar_52;
  tmpvar_52.xy = (tmpvar_14 + tmpvar_49);
  tmpvar_52.z = depth_50;
  uv_51.xy = tmpvar_52.xy;
  uv_51.z = depth_50;
  sum_9 = (sum_9 + (accum_8.y * shadow2D (_ShadowMapTexture, uv_51).x));
  vec2 tmpvar_53;
  tmpvar_53.x = u_12.z;
  tmpvar_53.y = v_11.z;
  float depth_54;
  depth_54 = tmpvar_7.z;
  vec3 uv_55;
  vec3 tmpvar_56;
  tmpvar_56.xy = (tmpvar_14 + tmpvar_53);
  tmpvar_56.z = depth_54;
  uv_55.xy = tmpvar_56.xy;
  uv_55.z = depth_54;
  sum_9 = (sum_9 + (accum_8.z * shadow2D (_ShadowMapTexture, uv_55).x));
  shadow_10 = (sum_9 / 144.0);
  float tmpvar_57;
  tmpvar_57 = mix (_LightShadowData.x, 1.0, shadow_10);
  shadow_10 = tmpvar_57;
  gl_FragData[0] = vec4((tmpvar_57 + clamp ((
    (tmpvar_3.z * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_3_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dcl_texcoord o0.xy
dcl_texcoord1 o1.xyz
dcl_texcoord2 o2
dcl_position o3
dp4 o3.z, c2, v0
dp4 o3.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov o3.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 o2.x, c4, r1
dp4 o2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov o3.x, r1.x
mov o2.zw, -r0.xyxy
mov o0.xy, v1
mov o1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 _LightSplitsNear;
uniform highp vec4 _LightSplitsFar;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7 = (_CameraToWorld * tmpvar_6);
  bvec4 tmpvar_8;
  tmpvar_8 = greaterThanEqual (tmpvar_5.zzzz, _LightSplitsNear);
  bvec4 tmpvar_9;
  tmpvar_9 = lessThan (tmpvar_5.zzzz, _LightSplitsFar);
  lowp vec4 tmpvar_10;
  tmpvar_10 = (vec4(tmpvar_8) * vec4(tmpvar_9));
  highp vec4 tmpvar_11;
  tmpvar_11.w = 1.0;
  tmpvar_11.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_7).xyz * tmpvar_10.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_7).xyz * tmpvar_10.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_7)
  .xyz * tmpvar_10.z)) + ((unity_World2Shadow[3] * tmpvar_7).xyz * tmpvar_10.w));
  mediump vec3 accum_12;
  mediump float sum_13;
  mediump float shadow_14;
  highp vec3 v_15;
  highp vec3 u_16;
  highp vec2 tmpvar_17;
  tmpvar_17 = ((tmpvar_11.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  highp vec2 tmpvar_18;
  tmpvar_18 = ((floor(tmpvar_17) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  highp vec2 tmpvar_19;
  tmpvar_19 = fract(tmpvar_17);
  highp vec3 tmpvar_20;
  tmpvar_20.y = 7.0;
  tmpvar_20.x = (4.0 - (3.0 * tmpvar_19.x));
  tmpvar_20.z = (1.0 + (3.0 * tmpvar_19.x));
  highp vec3 tmpvar_21;
  tmpvar_21.x = (((3.0 - 
    (2.0 * tmpvar_19.x)
  ) / tmpvar_20.x) - 2.0);
  tmpvar_21.y = ((3.0 + tmpvar_19.x) / 7.0);
  tmpvar_21.z = ((tmpvar_19.x / tmpvar_20.z) + 2.0);
  u_16 = (tmpvar_21 * _ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_22;
  tmpvar_22.y = 7.0;
  tmpvar_22.x = (4.0 - (3.0 * tmpvar_19.y));
  tmpvar_22.z = (1.0 + (3.0 * tmpvar_19.y));
  highp vec3 tmpvar_23;
  tmpvar_23.x = (((3.0 - 
    (2.0 * tmpvar_19.y)
  ) / tmpvar_22.x) - 2.0);
  tmpvar_23.y = ((3.0 + tmpvar_19.y) / 7.0);
  tmpvar_23.z = ((tmpvar_19.y / tmpvar_22.z) + 2.0);
  v_15 = (tmpvar_23 * _ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_24;
  tmpvar_24 = (tmpvar_20 * tmpvar_22.x);
  accum_12 = tmpvar_24;
  highp vec2 tmpvar_25;
  tmpvar_25.x = u_16.x;
  tmpvar_25.y = v_15.x;
  highp float depth_26;
  depth_26 = tmpvar_11.z;
  highp vec3 uv_27;
  highp vec3 tmpvar_28;
  tmpvar_28.xy = (tmpvar_18 + tmpvar_25);
  tmpvar_28.z = depth_26;
  uv_27.xy = tmpvar_28.xy;
  uv_27.z = depth_26;
  lowp float tmpvar_29;
  tmpvar_29 = shadow2DEXT (_ShadowMapTexture, uv_27);
  sum_13 = (accum_12.x * tmpvar_29);
  highp vec2 tmpvar_30;
  tmpvar_30.x = u_16.y;
  tmpvar_30.y = v_15.x;
  highp float depth_31;
  depth_31 = tmpvar_11.z;
  highp vec3 uv_32;
  highp vec3 tmpvar_33;
  tmpvar_33.xy = (tmpvar_18 + tmpvar_30);
  tmpvar_33.z = depth_31;
  uv_32.xy = tmpvar_33.xy;
  uv_32.z = depth_31;
  lowp float tmpvar_34;
  tmpvar_34 = shadow2DEXT (_ShadowMapTexture, uv_32);
  sum_13 = (sum_13 + (accum_12.y * tmpvar_34));
  highp vec2 tmpvar_35;
  tmpvar_35.x = u_16.z;
  tmpvar_35.y = v_15.x;
  highp float depth_36;
  depth_36 = tmpvar_11.z;
  highp vec3 uv_37;
  highp vec3 tmpvar_38;
  tmpvar_38.xy = (tmpvar_18 + tmpvar_35);
  tmpvar_38.z = depth_36;
  uv_37.xy = tmpvar_38.xy;
  uv_37.z = depth_36;
  lowp float tmpvar_39;
  tmpvar_39 = shadow2DEXT (_ShadowMapTexture, uv_37);
  sum_13 = (sum_13 + (accum_12.z * tmpvar_39));
  accum_12 = (tmpvar_20 * 7.0);
  highp vec2 tmpvar_40;
  tmpvar_40.x = u_16.x;
  tmpvar_40.y = v_15.y;
  highp float depth_41;
  depth_41 = tmpvar_11.z;
  highp vec3 uv_42;
  highp vec3 tmpvar_43;
  tmpvar_43.xy = (tmpvar_18 + tmpvar_40);
  tmpvar_43.z = depth_41;
  uv_42.xy = tmpvar_43.xy;
  uv_42.z = depth_41;
  lowp float tmpvar_44;
  tmpvar_44 = shadow2DEXT (_ShadowMapTexture, uv_42);
  sum_13 = (sum_13 + (accum_12.x * tmpvar_44));
  highp vec2 tmpvar_45;
  tmpvar_45.x = u_16.y;
  tmpvar_45.y = v_15.y;
  highp float depth_46;
  depth_46 = tmpvar_11.z;
  highp vec3 uv_47;
  highp vec3 tmpvar_48;
  tmpvar_48.xy = (tmpvar_18 + tmpvar_45);
  tmpvar_48.z = depth_46;
  uv_47.xy = tmpvar_48.xy;
  uv_47.z = depth_46;
  lowp float tmpvar_49;
  tmpvar_49 = shadow2DEXT (_ShadowMapTexture, uv_47);
  sum_13 = (sum_13 + (accum_12.y * tmpvar_49));
  highp vec2 tmpvar_50;
  tmpvar_50.x = u_16.z;
  tmpvar_50.y = v_15.y;
  highp float depth_51;
  depth_51 = tmpvar_11.z;
  highp vec3 uv_52;
  highp vec3 tmpvar_53;
  tmpvar_53.xy = (tmpvar_18 + tmpvar_50);
  tmpvar_53.z = depth_51;
  uv_52.xy = tmpvar_53.xy;
  uv_52.z = depth_51;
  lowp float tmpvar_54;
  tmpvar_54 = shadow2DEXT (_ShadowMapTexture, uv_52);
  sum_13 = (sum_13 + (accum_12.z * tmpvar_54));
  accum_12 = (tmpvar_20 * tmpvar_22.z);
  highp vec2 tmpvar_55;
  tmpvar_55.x = u_16.x;
  tmpvar_55.y = v_15.z;
  highp float depth_56;
  depth_56 = tmpvar_11.z;
  highp vec3 uv_57;
  highp vec3 tmpvar_58;
  tmpvar_58.xy = (tmpvar_18 + tmpvar_55);
  tmpvar_58.z = depth_56;
  uv_57.xy = tmpvar_58.xy;
  uv_57.z = depth_56;
  lowp float tmpvar_59;
  tmpvar_59 = shadow2DEXT (_ShadowMapTexture, uv_57);
  sum_13 = (sum_13 + (accum_12.x * tmpvar_59));
  highp vec2 tmpvar_60;
  tmpvar_60.x = u_16.y;
  tmpvar_60.y = v_15.z;
  highp float depth_61;
  depth_61 = tmpvar_11.z;
  highp vec3 uv_62;
  highp vec3 tmpvar_63;
  tmpvar_63.xy = (tmpvar_18 + tmpvar_60);
  tmpvar_63.z = depth_61;
  uv_62.xy = tmpvar_63.xy;
  uv_62.z = depth_61;
  lowp float tmpvar_64;
  tmpvar_64 = shadow2DEXT (_ShadowMapTexture, uv_62);
  sum_13 = (sum_13 + (accum_12.y * tmpvar_64));
  highp vec2 tmpvar_65;
  tmpvar_65.x = u_16.z;
  tmpvar_65.y = v_15.z;
  highp float depth_66;
  depth_66 = tmpvar_11.z;
  highp vec3 uv_67;
  highp vec3 tmpvar_68;
  tmpvar_68.xy = (tmpvar_18 + tmpvar_65);
  tmpvar_68.z = depth_66;
  uv_67.xy = tmpvar_68.xy;
  uv_67.z = depth_66;
  lowp float tmpvar_69;
  tmpvar_69 = shadow2DEXT (_ShadowMapTexture, uv_67);
  sum_13 = (sum_13 + (accum_12.z * tmpvar_69));
  shadow_14 = (sum_13 / 144.0);
  mediump float tmpvar_70;
  tmpvar_70 = mix (_LightShadowData.x, 1.0, shadow_14);
  shadow_14 = tmpvar_70;
  highp float tmpvar_71;
  tmpvar_71 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (tmpvar_70 + tmpvar_71);
  mediump vec4 tmpvar_72;
  tmpvar_72 = vec4(shadow_2);
  tmpvar_1 = tmpvar_72;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
lowp vec4 t10_1;
bvec4 tb1;
highp vec4 t2;
lowp float t10_2;
bvec4 tb2;
highp vec4 t3;
highp vec4 t4;
highp vec3 t5;
highp vec4 t6;
highp vec3 t7;
highp vec3 t8;
lowp float t10_8;
highp float t16;
mediump float t16_16;
lowp float t10_16;
highp vec2 t18;
lowp float t10_18;
lowp float t10_24;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t8.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    tb1 = greaterThanEqual(t0.zzzz, _LightSplitsNear);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    tb2 = lessThan(t0.zzzz, _LightSplitsFar);
    t2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb2));
    t10_1 = t1 * t2;
    t2 = t0.yyyy * _CameraToWorld[1];
    t2 = _CameraToWorld[0] * t0.xxxx + t2;
    t2 = _CameraToWorld[2] * t0.zzzz + t2;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2 = t2 + _CameraToWorld[3];
    t8.xyz = t2.yyy * unity_World2Shadow[1][1].xyz;
    t8.xyz = unity_World2Shadow[1][0].xyz * t2.xxx + t8.xyz;
    t8.xyz = unity_World2Shadow[1][2].xyz * t2.zzz + t8.xyz;
    t8.xyz = unity_World2Shadow[1][3].xyz * t2.www + t8.xyz;
    t8.xyz = t10_1.yyy * t8.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t2.www + t3.xyz;
    t8.xyz = t3.xyz * t10_1.xxx + t8.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t2.www + t3.xyz;
    t8.xyz = t3.xyz * t10_1.zzz + t8.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[3][1].xyz;
    t3.xyz = unity_World2Shadow[3][0].xyz * t2.xxx + t3.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t2.zzz + t3.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t2.www + t2.xyz;
    t8.xyz = t2.xyz * t10_1.www + t8.xyz;
    t8.xy = t8.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t2.xy = floor(t8.xy);
    t8.xy = fract(t8.xy);
    t2.xy = t2.xy + vec2(-0.5, -0.5);
    t18.xy = (-t8.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t3.xy = (-t8.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t18.xy = t18.xy / t3.xy;
    t1.xy = t18.xy + vec2(-2.0, -2.0);
    t4.z = t1.y;
    t18.xy = t8.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t3.xz = t8.xy / t18.xy;
    t4.xw = t3.xz + vec2(2.0, 2.0);
    t1.w = t4.x;
    t3.xz = t8.xy + vec2(3.0, 3.0);
    t8.x = t8.x * 3.0;
    t5.xz = t8.xx * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t4.xy = t3.xz * _ShadowMapTexture_TexelSize.xy;
    t6.xz = _ShadowMapTexture_TexelSize.yy;
    t6.y = 0.142857149;
    t6.xyz = vec3(t4.z * t6.x, t4.y * t6.y, t4.w * t6.z);
    t1.z = t4.x;
    t4.w = t6.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t4.xyz = t1.zxw * t7.yxz;
    t1 = t2.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.ywxw;
    t8.xy = t2.xy * _ShadowMapTexture_TexelSize.xy + t4.zw;
    vec3 txVec1 = vec3(t8.xy,t8.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    vec3 txVec2 = vec3(t1.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec2, 0.0);
    vec3 txVec3 = vec3(t1.zw,t8.z);
    t10_18 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec3, 0.0);
    t5.y = 7.0;
    t3.xyz = t3.yyy * t5.xyz;
    t7.xyz = t18.yyy * t5.xyz;
    t5.xy = t5.xz * vec2(7.0, 7.0);
    t18.x = t10_18 * t3.y;
    t16 = t3.x * t10_16 + t18.x;
    t8.x = t3.z * t10_8 + t16;
    t6.w = t4.y;
    t1 = t2.xyxy * _ShadowMapTexture_TexelSize.xyxy + t6.wywz;
    t4.yw = t6.yz;
    vec3 txVec4 = vec3(t1.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec4, 0.0);
    vec3 txVec5 = vec3(t1.zw,t8.z);
    t10_18 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec5, 0.0);
    t8.x = t5.x * t10_16 + t8.x;
    t1 = t2.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xyzy;
    t3 = t2.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xwzw;
    vec3 txVec6 = vec3(t1.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec6, 0.0);
    vec3 txVec7 = vec3(t1.zw,t8.z);
    t10_2 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec7, 0.0);
    t8.x = t10_16 * 49.0 + t8.x;
    t8.x = t5.y * t10_2 + t8.x;
    t8.x = t7.x * t10_18 + t8.x;
    vec3 txVec8 = vec3(t3.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec8, 0.0);
    vec3 txVec9 = vec3(t3.zw,t8.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec9, 0.0);
    t8.x = t7.y * t10_16 + t8.x;
    t8.x = t7.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16_16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16_16 + _LightShadowData.x;
    t0 = t0.xxxx + t8.xxxx;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
lowp float t10_1;
bvec4 tb1;
vec4 t2;
bvec4 tb2;
vec4 t3;
vec4 t4;
vec3 t5;
vec4 t6;
vec3 t7;
vec3 t8;
lowp float t10_8;
float t16;
lowp float t10_16;
vec2 t17;
lowp float t10_17;
lowp float t10_24;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t8.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t10_0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    tb1 = greaterThanEqual(t0.zzzz, _LightSplitsNear);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    tb2 = lessThan(t0.zzzz, _LightSplitsFar);
    t2 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb2));
    t1 = t1 * t2;
    t2 = t0.yyyy * _CameraToWorld[1];
    t2 = _CameraToWorld[0] * t0.xxxx + t2;
    t2 = _CameraToWorld[2] * t0.zzzz + t2;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2 = t2 + _CameraToWorld[3];
    t8.xyz = t2.yyy * unity_World2Shadow[1][1].xyz;
    t8.xyz = unity_World2Shadow[1][0].xyz * t2.xxx + t8.xyz;
    t8.xyz = unity_World2Shadow[1][2].xyz * t2.zzz + t8.xyz;
    t8.xyz = unity_World2Shadow[1][3].xyz * t2.www + t8.xyz;
    t8.xyz = t1.yyy * t8.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t2.www + t3.xyz;
    t8.xyz = t3.xyz * t1.xxx + t8.xyz;
    t3.xyz = t2.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t2.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t2.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t2.www + t3.xyz;
    t8.xyz = t3.xyz * t1.zzz + t8.xyz;
    t1.xyz = t2.yyy * unity_World2Shadow[3][1].xyz;
    t1.xyz = unity_World2Shadow[3][0].xyz * t2.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[3][2].xyz * t2.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[3][3].xyz * t2.www + t1.xyz;
    t8.xyz = t1.xyz * t1.www + t8.xyz;
    t8.xy = t8.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t1.xy = floor(t8.xy);
    t8.xy = fract(t8.xy);
    t1.xy = t1.xy + vec2(-0.5, -0.5);
    t17.xy = (-t8.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t2.xy = (-t8.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t17.xy = t17.xy / t2.xy;
    t3.xy = t17.xy + vec2(-2.0, -2.0);
    t4.z = t3.y;
    t17.xy = t8.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t2.xz = t8.xy / t17.xy;
    t4.xw = t2.xz + vec2(2.0, 2.0);
    t3.w = t4.x;
    t2.xz = t8.xy + vec2(3.0, 3.0);
    t8.x = t8.x * 3.0;
    t5.xz = t8.xx * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t4.xy = t2.xz * _ShadowMapTexture_TexelSize.xy;
    t6.xz = _ShadowMapTexture_TexelSize.yy;
    t6.y = 0.142857149;
    t6.xyz = t4.zyw * t6.xyz;
    t3.z = t4.x;
    t4.w = t6.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t4.xyz = t3.zxw * t7.yxz;
    t3 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.ywxw;
    t8.xy = t1.xy * _ShadowMapTexture_TexelSize.xy + t4.zw;
    vec3 txVec2 = vec3(t8.xy,t8.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec2, 0.0);
    vec3 txVec3 = vec3(t3.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec3, 0.0);
    vec3 txVec4 = vec3(t3.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec4, 0.0);
    t5.y = 7.0;
    t2.xyz = t2.yyy * t5.xyz;
    t3.xyz = t17.yyy * t5.xyz;
    t5.xy = t5.xz * vec2(7.0, 7.0);
    t17.x = t10_17 * t2.y;
    t16 = t2.x * t10_16 + t17.x;
    t8.x = t2.z * t10_8 + t16;
    t6.w = t4.y;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t6.wywz;
    t4.yw = t6.yz;
    vec3 txVec5 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec5, 0.0);
    vec3 txVec6 = vec3(t2.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec6, 0.0);
    t8.x = t5.x * t10_16 + t8.x;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xyzy;
    t4 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xwzw;
    vec3 txVec7 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec7, 0.0);
    vec3 txVec8 = vec3(t2.zw,t8.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec8, 0.0);
    t8.x = t10_16 * 49.0 + t8.x;
    t8.x = t5.y * t10_1 + t8.x;
    t8.x = t3.x * t10_17 + t8.x;
    vec3 txVec9 = vec3(t4.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec9, 0.0);
    vec3 txVec10 = vec3(t4.zw,t8.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec10, 0.0);
    t8.x = t3.y * t10_16 + t8.x;
    t8.x = t3.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t8.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 unity_ShadowSplitSpheres[4];
uniform highp vec4 unity_ShadowSplitSqRadii;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  lowp vec4 weights_7;
  highp vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[0].xyz);
  highp vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[1].xyz);
  highp vec3 tmpvar_10;
  tmpvar_10 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[2].xyz);
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[3].xyz);
  highp vec4 tmpvar_12;
  tmpvar_12.x = dot (tmpvar_8, tmpvar_8);
  tmpvar_12.y = dot (tmpvar_9, tmpvar_9);
  tmpvar_12.z = dot (tmpvar_10, tmpvar_10);
  tmpvar_12.w = dot (tmpvar_11, tmpvar_11);
  bvec4 tmpvar_13;
  tmpvar_13 = lessThan (tmpvar_12, unity_ShadowSplitSqRadii);
  lowp vec4 tmpvar_14;
  tmpvar_14 = vec4(tmpvar_13);
  weights_7.x = tmpvar_14.x;
  weights_7.yzw = clamp ((tmpvar_14.yzw - tmpvar_14.xyz), 0.0, 1.0);
  highp vec4 tmpvar_15;
  tmpvar_15.w = 1.0;
  tmpvar_15.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_6).xyz * tmpvar_14.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_6).xyz * weights_7.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_6)
  .xyz * weights_7.z)) + ((unity_World2Shadow[3] * tmpvar_6).xyz * weights_7.w));
  mediump float shadow_16;
  shadow_16 = 0.0;
  highp vec2 tmpvar_17;
  tmpvar_17 = _ShadowMapTexture_TexelSize.xy;
  highp vec3 tmpvar_18;
  tmpvar_18.xy = (tmpvar_15.xy - _ShadowMapTexture_TexelSize.xy);
  tmpvar_18.z = tmpvar_15.z;
  highp vec4 tmpvar_19;
  tmpvar_19 = texture2D (_ShadowMapTexture, tmpvar_18.xy);
  mediump float tmpvar_20;
  if ((tmpvar_19.x < tmpvar_15.z)) {
    tmpvar_20 = 0.0;
  } else {
    tmpvar_20 = 1.0;
  };
  shadow_16 = tmpvar_20;
  highp vec2 tmpvar_21;
  tmpvar_21.x = 0.0;
  tmpvar_21.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_15.xy + tmpvar_21);
  tmpvar_22.z = tmpvar_15.z;
  highp vec4 tmpvar_23;
  tmpvar_23 = texture2D (_ShadowMapTexture, tmpvar_22.xy);
  highp float tmpvar_24;
  if ((tmpvar_23.x < tmpvar_15.z)) {
    tmpvar_24 = 0.0;
  } else {
    tmpvar_24 = 1.0;
  };
  shadow_16 = (tmpvar_20 + tmpvar_24);
  highp vec2 tmpvar_25;
  tmpvar_25.x = tmpvar_17.x;
  tmpvar_25.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_26;
  tmpvar_26.xy = (tmpvar_15.xy + tmpvar_25);
  tmpvar_26.z = tmpvar_15.z;
  highp vec4 tmpvar_27;
  tmpvar_27 = texture2D (_ShadowMapTexture, tmpvar_26.xy);
  highp float tmpvar_28;
  if ((tmpvar_27.x < tmpvar_15.z)) {
    tmpvar_28 = 0.0;
  } else {
    tmpvar_28 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_28);
  highp vec2 tmpvar_29;
  tmpvar_29.y = 0.0;
  tmpvar_29.x = -(_ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_30;
  tmpvar_30.xy = (tmpvar_15.xy + tmpvar_29);
  tmpvar_30.z = tmpvar_15.z;
  highp vec4 tmpvar_31;
  tmpvar_31 = texture2D (_ShadowMapTexture, tmpvar_30.xy);
  highp float tmpvar_32;
  if ((tmpvar_31.x < tmpvar_15.z)) {
    tmpvar_32 = 0.0;
  } else {
    tmpvar_32 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_32);
  highp vec4 tmpvar_33;
  tmpvar_33 = texture2D (_ShadowMapTexture, tmpvar_15.xy);
  highp float tmpvar_34;
  if ((tmpvar_33.x < tmpvar_15.z)) {
    tmpvar_34 = 0.0;
  } else {
    tmpvar_34 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_34);
  highp vec2 tmpvar_35;
  tmpvar_35.y = 0.0;
  tmpvar_35.x = tmpvar_17.x;
  highp vec3 tmpvar_36;
  tmpvar_36.xy = (tmpvar_15.xy + tmpvar_35);
  tmpvar_36.z = tmpvar_15.z;
  highp vec4 tmpvar_37;
  tmpvar_37 = texture2D (_ShadowMapTexture, tmpvar_36.xy);
  highp float tmpvar_38;
  if ((tmpvar_37.x < tmpvar_15.z)) {
    tmpvar_38 = 0.0;
  } else {
    tmpvar_38 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_38);
  highp vec2 tmpvar_39;
  tmpvar_39.x = -(_ShadowMapTexture_TexelSize.x);
  tmpvar_39.y = tmpvar_17.y;
  highp vec3 tmpvar_40;
  tmpvar_40.xy = (tmpvar_15.xy + tmpvar_39);
  tmpvar_40.z = tmpvar_15.z;
  highp vec4 tmpvar_41;
  tmpvar_41 = texture2D (_ShadowMapTexture, tmpvar_40.xy);
  highp float tmpvar_42;
  if ((tmpvar_41.x < tmpvar_15.z)) {
    tmpvar_42 = 0.0;
  } else {
    tmpvar_42 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_42);
  highp vec2 tmpvar_43;
  tmpvar_43.x = 0.0;
  tmpvar_43.y = tmpvar_17.y;
  highp vec3 tmpvar_44;
  tmpvar_44.xy = (tmpvar_15.xy + tmpvar_43);
  tmpvar_44.z = tmpvar_15.z;
  highp vec4 tmpvar_45;
  tmpvar_45 = texture2D (_ShadowMapTexture, tmpvar_44.xy);
  highp float tmpvar_46;
  if ((tmpvar_45.x < tmpvar_15.z)) {
    tmpvar_46 = 0.0;
  } else {
    tmpvar_46 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_46);
  highp vec3 tmpvar_47;
  tmpvar_47.xy = (tmpvar_15.xy + _ShadowMapTexture_TexelSize.xy);
  tmpvar_47.z = tmpvar_15.z;
  highp vec4 tmpvar_48;
  tmpvar_48 = texture2D (_ShadowMapTexture, tmpvar_47.xy);
  highp float tmpvar_49;
  if ((tmpvar_48.x < tmpvar_15.z)) {
    tmpvar_49 = 0.0;
  } else {
    tmpvar_49 = 1.0;
  };
  shadow_16 = (shadow_16 + tmpvar_49);
  shadow_16 = (shadow_16 / 9.0);
  mediump float tmpvar_50;
  tmpvar_50 = mix (_LightShadowData.x, 1.0, shadow_16);
  shadow_16 = tmpvar_50;
  highp float tmpvar_51;
  highp vec3 tmpvar_52;
  tmpvar_52 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_53;
  highp float tmpvar_54;
  tmpvar_54 = clamp (((
    sqrt(dot (tmpvar_52, tmpvar_52))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_53 = tmpvar_54;
  tmpvar_51 = tmpvar_53;
  shadow_2 = (tmpvar_50 + tmpvar_51);
  mediump vec4 tmpvar_55;
  tmpvar_55 = vec4(shadow_2);
  tmpvar_1 = tmpvar_55;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform vec4 unity_ShadowSplitSpheres[4];
uniform vec4 unity_ShadowSplitSqRadii;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform vec4 unity_ShadowFadeCenterAndType;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
uniform vec4 _ShadowMapTexture_TexelSize;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec4 tmpvar_3;
  tmpvar_3.w = 1.0;
  tmpvar_3.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4 = (_CameraToWorld * tmpvar_3);
  vec4 weights_5;
  vec3 tmpvar_6;
  tmpvar_6 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[0].xyz);
  vec3 tmpvar_7;
  tmpvar_7 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[1].xyz);
  vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[2].xyz);
  vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_4.xyz - unity_ShadowSplitSpheres[3].xyz);
  vec4 tmpvar_10;
  tmpvar_10.x = dot (tmpvar_6, tmpvar_6);
  tmpvar_10.y = dot (tmpvar_7, tmpvar_7);
  tmpvar_10.z = dot (tmpvar_8, tmpvar_8);
  tmpvar_10.w = dot (tmpvar_9, tmpvar_9);
  vec4 tmpvar_11;
  tmpvar_11 = vec4(lessThan (tmpvar_10, unity_ShadowSplitSqRadii));
  weights_5.x = tmpvar_11.x;
  weights_5.yzw = clamp ((tmpvar_11.yzw - tmpvar_11.xyz), 0.0, 1.0);
  vec4 tmpvar_12;
  tmpvar_12.w = 1.0;
  tmpvar_12.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_4).xyz * tmpvar_11.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_4).xyz * weights_5.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_4)
  .xyz * weights_5.z)) + ((unity_World2Shadow[3] * tmpvar_4).xyz * weights_5.w));
  vec3 accum_13;
  float sum_14;
  float shadow_15;
  vec3 v_16;
  vec3 u_17;
  vec2 tmpvar_18;
  tmpvar_18 = ((tmpvar_12.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  vec2 tmpvar_19;
  tmpvar_19 = ((floor(tmpvar_18) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  vec2 tmpvar_20;
  tmpvar_20 = fract(tmpvar_18);
  vec3 tmpvar_21;
  tmpvar_21.y = 7.0;
  tmpvar_21.x = (4.0 - (3.0 * tmpvar_20.x));
  tmpvar_21.z = (1.0 + (3.0 * tmpvar_20.x));
  vec3 tmpvar_22;
  tmpvar_22.x = (((3.0 - 
    (2.0 * tmpvar_20.x)
  ) / tmpvar_21.x) - 2.0);
  tmpvar_22.y = ((3.0 + tmpvar_20.x) / 7.0);
  tmpvar_22.z = ((tmpvar_20.x / tmpvar_21.z) + 2.0);
  u_17 = (tmpvar_22 * _ShadowMapTexture_TexelSize.x);
  vec3 tmpvar_23;
  tmpvar_23.y = 7.0;
  tmpvar_23.x = (4.0 - (3.0 * tmpvar_20.y));
  tmpvar_23.z = (1.0 + (3.0 * tmpvar_20.y));
  vec3 tmpvar_24;
  tmpvar_24.x = (((3.0 - 
    (2.0 * tmpvar_20.y)
  ) / tmpvar_23.x) - 2.0);
  tmpvar_24.y = ((3.0 + tmpvar_20.y) / 7.0);
  tmpvar_24.z = ((tmpvar_20.y / tmpvar_23.z) + 2.0);
  v_16 = (tmpvar_24 * _ShadowMapTexture_TexelSize.y);
  vec3 tmpvar_25;
  tmpvar_25 = (tmpvar_21 * tmpvar_23.x);
  vec2 tmpvar_26;
  tmpvar_26.x = u_17.x;
  tmpvar_26.y = v_16.x;
  float depth_27;
  depth_27 = tmpvar_12.z;
  vec3 uv_28;
  vec3 tmpvar_29;
  tmpvar_29.xy = (tmpvar_19 + tmpvar_26);
  tmpvar_29.z = depth_27;
  uv_28.xy = tmpvar_29.xy;
  uv_28.z = depth_27;
  sum_14 = (tmpvar_25.x * shadow2D (_ShadowMapTexture, uv_28).x);
  vec2 tmpvar_30;
  tmpvar_30.x = u_17.y;
  tmpvar_30.y = v_16.x;
  float depth_31;
  depth_31 = tmpvar_12.z;
  vec3 uv_32;
  vec3 tmpvar_33;
  tmpvar_33.xy = (tmpvar_19 + tmpvar_30);
  tmpvar_33.z = depth_31;
  uv_32.xy = tmpvar_33.xy;
  uv_32.z = depth_31;
  sum_14 = (sum_14 + (tmpvar_25.y * shadow2D (_ShadowMapTexture, uv_32).x));
  vec2 tmpvar_34;
  tmpvar_34.x = u_17.z;
  tmpvar_34.y = v_16.x;
  float depth_35;
  depth_35 = tmpvar_12.z;
  vec3 uv_36;
  vec3 tmpvar_37;
  tmpvar_37.xy = (tmpvar_19 + tmpvar_34);
  tmpvar_37.z = depth_35;
  uv_36.xy = tmpvar_37.xy;
  uv_36.z = depth_35;
  sum_14 = (sum_14 + (tmpvar_25.z * shadow2D (_ShadowMapTexture, uv_36).x));
  accum_13 = (tmpvar_21 * 7.0);
  vec2 tmpvar_38;
  tmpvar_38.x = u_17.x;
  tmpvar_38.y = v_16.y;
  float depth_39;
  depth_39 = tmpvar_12.z;
  vec3 uv_40;
  vec3 tmpvar_41;
  tmpvar_41.xy = (tmpvar_19 + tmpvar_38);
  tmpvar_41.z = depth_39;
  uv_40.xy = tmpvar_41.xy;
  uv_40.z = depth_39;
  sum_14 = (sum_14 + (accum_13.x * shadow2D (_ShadowMapTexture, uv_40).x));
  vec2 tmpvar_42;
  tmpvar_42.x = u_17.y;
  tmpvar_42.y = v_16.y;
  float depth_43;
  depth_43 = tmpvar_12.z;
  vec3 uv_44;
  vec3 tmpvar_45;
  tmpvar_45.xy = (tmpvar_19 + tmpvar_42);
  tmpvar_45.z = depth_43;
  uv_44.xy = tmpvar_45.xy;
  uv_44.z = depth_43;
  sum_14 = (sum_14 + (accum_13.y * shadow2D (_ShadowMapTexture, uv_44).x));
  vec2 tmpvar_46;
  tmpvar_46.x = u_17.z;
  tmpvar_46.y = v_16.y;
  float depth_47;
  depth_47 = tmpvar_12.z;
  vec3 uv_48;
  vec3 tmpvar_49;
  tmpvar_49.xy = (tmpvar_19 + tmpvar_46);
  tmpvar_49.z = depth_47;
  uv_48.xy = tmpvar_49.xy;
  uv_48.z = depth_47;
  sum_14 = (sum_14 + (accum_13.z * shadow2D (_ShadowMapTexture, uv_48).x));
  accum_13 = (tmpvar_21 * tmpvar_23.z);
  vec2 tmpvar_50;
  tmpvar_50.x = u_17.x;
  tmpvar_50.y = v_16.z;
  float depth_51;
  depth_51 = tmpvar_12.z;
  vec3 uv_52;
  vec3 tmpvar_53;
  tmpvar_53.xy = (tmpvar_19 + tmpvar_50);
  tmpvar_53.z = depth_51;
  uv_52.xy = tmpvar_53.xy;
  uv_52.z = depth_51;
  sum_14 = (sum_14 + (accum_13.x * shadow2D (_ShadowMapTexture, uv_52).x));
  vec2 tmpvar_54;
  tmpvar_54.x = u_17.y;
  tmpvar_54.y = v_16.z;
  float depth_55;
  depth_55 = tmpvar_12.z;
  vec3 uv_56;
  vec3 tmpvar_57;
  tmpvar_57.xy = (tmpvar_19 + tmpvar_54);
  tmpvar_57.z = depth_55;
  uv_56.xy = tmpvar_57.xy;
  uv_56.z = depth_55;
  sum_14 = (sum_14 + (accum_13.y * shadow2D (_ShadowMapTexture, uv_56).x));
  vec2 tmpvar_58;
  tmpvar_58.x = u_17.z;
  tmpvar_58.y = v_16.z;
  float depth_59;
  depth_59 = tmpvar_12.z;
  vec3 uv_60;
  vec3 tmpvar_61;
  tmpvar_61.xy = (tmpvar_19 + tmpvar_58);
  tmpvar_61.z = depth_59;
  uv_60.xy = tmpvar_61.xy;
  uv_60.z = depth_59;
  sum_14 = (sum_14 + (accum_13.z * shadow2D (_ShadowMapTexture, uv_60).x));
  shadow_15 = (sum_14 / 144.0);
  float tmpvar_62;
  tmpvar_62 = mix (_LightShadowData.x, 1.0, shadow_15);
  shadow_15 = tmpvar_62;
  vec3 tmpvar_63;
  tmpvar_63 = (tmpvar_4.xyz - unity_ShadowFadeCenterAndType.xyz);
  gl_FragData[0] = vec4((tmpvar_62 + clamp ((
    (sqrt(dot (tmpvar_63, tmpvar_63)) * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_3_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dcl_texcoord o0.xy
dcl_texcoord1 o1.xyz
dcl_texcoord2 o2
dcl_position o3
dp4 o3.z, c2, v0
dp4 o3.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov o3.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 o2.x, c4, r1
dp4 o2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov o3.x, r1.x
mov o2.zw, -r0.xyxy
mov o0.xy, v1
mov o1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp vec4 unity_ShadowSplitSpheres[4];
uniform highp vec4 unity_ShadowSplitSqRadii;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  lowp vec4 weights_7;
  highp vec3 tmpvar_8;
  tmpvar_8 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[0].xyz);
  highp vec3 tmpvar_9;
  tmpvar_9 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[1].xyz);
  highp vec3 tmpvar_10;
  tmpvar_10 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[2].xyz);
  highp vec3 tmpvar_11;
  tmpvar_11 = (tmpvar_6.xyz - unity_ShadowSplitSpheres[3].xyz);
  highp vec4 tmpvar_12;
  tmpvar_12.x = dot (tmpvar_8, tmpvar_8);
  tmpvar_12.y = dot (tmpvar_9, tmpvar_9);
  tmpvar_12.z = dot (tmpvar_10, tmpvar_10);
  tmpvar_12.w = dot (tmpvar_11, tmpvar_11);
  bvec4 tmpvar_13;
  tmpvar_13 = lessThan (tmpvar_12, unity_ShadowSplitSqRadii);
  lowp vec4 tmpvar_14;
  tmpvar_14 = vec4(tmpvar_13);
  weights_7.x = tmpvar_14.x;
  weights_7.yzw = clamp ((tmpvar_14.yzw - tmpvar_14.xyz), 0.0, 1.0);
  highp vec4 tmpvar_15;
  tmpvar_15.w = 1.0;
  tmpvar_15.xyz = (((
    ((unity_World2Shadow[0] * tmpvar_6).xyz * tmpvar_14.x)
   + 
    ((unity_World2Shadow[1] * tmpvar_6).xyz * weights_7.y)
  ) + (
    (unity_World2Shadow[2] * tmpvar_6)
  .xyz * weights_7.z)) + ((unity_World2Shadow[3] * tmpvar_6).xyz * weights_7.w));
  mediump vec3 accum_16;
  mediump float sum_17;
  mediump float shadow_18;
  highp vec3 v_19;
  highp vec3 u_20;
  highp vec2 tmpvar_21;
  tmpvar_21 = ((tmpvar_15.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  highp vec2 tmpvar_22;
  tmpvar_22 = ((floor(tmpvar_21) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  highp vec2 tmpvar_23;
  tmpvar_23 = fract(tmpvar_21);
  highp vec3 tmpvar_24;
  tmpvar_24.y = 7.0;
  tmpvar_24.x = (4.0 - (3.0 * tmpvar_23.x));
  tmpvar_24.z = (1.0 + (3.0 * tmpvar_23.x));
  highp vec3 tmpvar_25;
  tmpvar_25.x = (((3.0 - 
    (2.0 * tmpvar_23.x)
  ) / tmpvar_24.x) - 2.0);
  tmpvar_25.y = ((3.0 + tmpvar_23.x) / 7.0);
  tmpvar_25.z = ((tmpvar_23.x / tmpvar_24.z) + 2.0);
  u_20 = (tmpvar_25 * _ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_26;
  tmpvar_26.y = 7.0;
  tmpvar_26.x = (4.0 - (3.0 * tmpvar_23.y));
  tmpvar_26.z = (1.0 + (3.0 * tmpvar_23.y));
  highp vec3 tmpvar_27;
  tmpvar_27.x = (((3.0 - 
    (2.0 * tmpvar_23.y)
  ) / tmpvar_26.x) - 2.0);
  tmpvar_27.y = ((3.0 + tmpvar_23.y) / 7.0);
  tmpvar_27.z = ((tmpvar_23.y / tmpvar_26.z) + 2.0);
  v_19 = (tmpvar_27 * _ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_28;
  tmpvar_28 = (tmpvar_24 * tmpvar_26.x);
  accum_16 = tmpvar_28;
  highp vec2 tmpvar_29;
  tmpvar_29.x = u_20.x;
  tmpvar_29.y = v_19.x;
  highp float depth_30;
  depth_30 = tmpvar_15.z;
  highp vec3 uv_31;
  highp vec3 tmpvar_32;
  tmpvar_32.xy = (tmpvar_22 + tmpvar_29);
  tmpvar_32.z = depth_30;
  uv_31.xy = tmpvar_32.xy;
  uv_31.z = depth_30;
  lowp float tmpvar_33;
  tmpvar_33 = shadow2DEXT (_ShadowMapTexture, uv_31);
  sum_17 = (accum_16.x * tmpvar_33);
  highp vec2 tmpvar_34;
  tmpvar_34.x = u_20.y;
  tmpvar_34.y = v_19.x;
  highp float depth_35;
  depth_35 = tmpvar_15.z;
  highp vec3 uv_36;
  highp vec3 tmpvar_37;
  tmpvar_37.xy = (tmpvar_22 + tmpvar_34);
  tmpvar_37.z = depth_35;
  uv_36.xy = tmpvar_37.xy;
  uv_36.z = depth_35;
  lowp float tmpvar_38;
  tmpvar_38 = shadow2DEXT (_ShadowMapTexture, uv_36);
  sum_17 = (sum_17 + (accum_16.y * tmpvar_38));
  highp vec2 tmpvar_39;
  tmpvar_39.x = u_20.z;
  tmpvar_39.y = v_19.x;
  highp float depth_40;
  depth_40 = tmpvar_15.z;
  highp vec3 uv_41;
  highp vec3 tmpvar_42;
  tmpvar_42.xy = (tmpvar_22 + tmpvar_39);
  tmpvar_42.z = depth_40;
  uv_41.xy = tmpvar_42.xy;
  uv_41.z = depth_40;
  lowp float tmpvar_43;
  tmpvar_43 = shadow2DEXT (_ShadowMapTexture, uv_41);
  sum_17 = (sum_17 + (accum_16.z * tmpvar_43));
  accum_16 = (tmpvar_24 * 7.0);
  highp vec2 tmpvar_44;
  tmpvar_44.x = u_20.x;
  tmpvar_44.y = v_19.y;
  highp float depth_45;
  depth_45 = tmpvar_15.z;
  highp vec3 uv_46;
  highp vec3 tmpvar_47;
  tmpvar_47.xy = (tmpvar_22 + tmpvar_44);
  tmpvar_47.z = depth_45;
  uv_46.xy = tmpvar_47.xy;
  uv_46.z = depth_45;
  lowp float tmpvar_48;
  tmpvar_48 = shadow2DEXT (_ShadowMapTexture, uv_46);
  sum_17 = (sum_17 + (accum_16.x * tmpvar_48));
  highp vec2 tmpvar_49;
  tmpvar_49.x = u_20.y;
  tmpvar_49.y = v_19.y;
  highp float depth_50;
  depth_50 = tmpvar_15.z;
  highp vec3 uv_51;
  highp vec3 tmpvar_52;
  tmpvar_52.xy = (tmpvar_22 + tmpvar_49);
  tmpvar_52.z = depth_50;
  uv_51.xy = tmpvar_52.xy;
  uv_51.z = depth_50;
  lowp float tmpvar_53;
  tmpvar_53 = shadow2DEXT (_ShadowMapTexture, uv_51);
  sum_17 = (sum_17 + (accum_16.y * tmpvar_53));
  highp vec2 tmpvar_54;
  tmpvar_54.x = u_20.z;
  tmpvar_54.y = v_19.y;
  highp float depth_55;
  depth_55 = tmpvar_15.z;
  highp vec3 uv_56;
  highp vec3 tmpvar_57;
  tmpvar_57.xy = (tmpvar_22 + tmpvar_54);
  tmpvar_57.z = depth_55;
  uv_56.xy = tmpvar_57.xy;
  uv_56.z = depth_55;
  lowp float tmpvar_58;
  tmpvar_58 = shadow2DEXT (_ShadowMapTexture, uv_56);
  sum_17 = (sum_17 + (accum_16.z * tmpvar_58));
  accum_16 = (tmpvar_24 * tmpvar_26.z);
  highp vec2 tmpvar_59;
  tmpvar_59.x = u_20.x;
  tmpvar_59.y = v_19.z;
  highp float depth_60;
  depth_60 = tmpvar_15.z;
  highp vec3 uv_61;
  highp vec3 tmpvar_62;
  tmpvar_62.xy = (tmpvar_22 + tmpvar_59);
  tmpvar_62.z = depth_60;
  uv_61.xy = tmpvar_62.xy;
  uv_61.z = depth_60;
  lowp float tmpvar_63;
  tmpvar_63 = shadow2DEXT (_ShadowMapTexture, uv_61);
  sum_17 = (sum_17 + (accum_16.x * tmpvar_63));
  highp vec2 tmpvar_64;
  tmpvar_64.x = u_20.y;
  tmpvar_64.y = v_19.z;
  highp float depth_65;
  depth_65 = tmpvar_15.z;
  highp vec3 uv_66;
  highp vec3 tmpvar_67;
  tmpvar_67.xy = (tmpvar_22 + tmpvar_64);
  tmpvar_67.z = depth_65;
  uv_66.xy = tmpvar_67.xy;
  uv_66.z = depth_65;
  lowp float tmpvar_68;
  tmpvar_68 = shadow2DEXT (_ShadowMapTexture, uv_66);
  sum_17 = (sum_17 + (accum_16.y * tmpvar_68));
  highp vec2 tmpvar_69;
  tmpvar_69.x = u_20.z;
  tmpvar_69.y = v_19.z;
  highp float depth_70;
  depth_70 = tmpvar_15.z;
  highp vec3 uv_71;
  highp vec3 tmpvar_72;
  tmpvar_72.xy = (tmpvar_22 + tmpvar_69);
  tmpvar_72.z = depth_70;
  uv_71.xy = tmpvar_72.xy;
  uv_71.z = depth_70;
  lowp float tmpvar_73;
  tmpvar_73 = shadow2DEXT (_ShadowMapTexture, uv_71);
  sum_17 = (sum_17 + (accum_16.z * tmpvar_73));
  shadow_18 = (sum_17 / 144.0);
  mediump float tmpvar_74;
  tmpvar_74 = mix (_LightShadowData.x, 1.0, shadow_18);
  shadow_18 = tmpvar_74;
  highp float tmpvar_75;
  highp vec3 tmpvar_76;
  tmpvar_76 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_77;
  highp float tmpvar_78;
  tmpvar_78 = clamp (((
    sqrt(dot (tmpvar_76, tmpvar_76))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_77 = tmpvar_78;
  tmpvar_75 = tmpvar_77;
  shadow_2 = (tmpvar_74 + tmpvar_75);
  mediump vec4 tmpvar_79;
  tmpvar_79 = vec4(shadow_2);
  tmpvar_1 = tmpvar_79;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
lowp float t10_1;
bvec4 tb1;
highp vec4 t2;
highp vec4 t3;
lowp vec3 t10_3;
highp vec4 t4;
highp vec3 t5;
highp vec4 t6;
highp vec3 t7;
highp vec3 t8;
lowp float t10_8;
highp vec3 t9;
highp float t16;
mediump float t16_16;
lowp float t10_16;
highp vec2 t17;
lowp float t10_17;
lowp float t10_24;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t8.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.xyz + (-unity_ShadowSplitSpheres[0].xyz);
    t1.x = dot(t1.xyz, t1.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[1].xyz);
    t1.y = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[2].xyz);
    t1.z = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[3].xyz);
    t1.w = dot(t2.xyz, t2.xyz);
    tb1 = lessThan(t1, unity_ShadowSplitSqRadii);
    t10_3.x = (tb1.x) ? float(-1.0) : float(-0.0);
    t10_3.y = (tb1.y) ? float(-1.0) : float(-0.0);
    t10_3.z = (tb1.z) ? float(-1.0) : float(-0.0);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    t10_3.xyz = vec3(t10_3.x + t1.y, t10_3.y + t1.z, t10_3.z + t1.w);
    t10_3.xyz = max(t10_3.xyz, vec3(0.0, 0.0, 0.0));
    t9.xyz = t0.yyy * unity_World2Shadow[1][1].xyz;
    t9.xyz = unity_World2Shadow[1][0].xyz * t0.xxx + t9.xyz;
    t9.xyz = unity_World2Shadow[1][2].xyz * t0.zzz + t9.xyz;
    t9.xyz = unity_World2Shadow[1][3].xyz * t0.www + t9.xyz;
    t9.xyz = t10_3.xxx * t9.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t2.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[0][3].xyz * t0.www + t2.xyz;
    t1.xyz = t2.xyz * t1.xxx + t9.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[2][1].xyz;
    t2.xyz = unity_World2Shadow[2][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[2][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[2][3].xyz * t0.www + t2.xyz;
    t1.xyz = t2.xyz * t10_3.yyy + t1.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[3][1].xyz;
    t2.xyz = unity_World2Shadow[3][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t0.www + t2.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t8.xyz = t2.xyz * t10_3.zzz + t1.xyz;
    t8.xy = t8.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t1.xy = floor(t8.xy);
    t8.xy = fract(t8.xy);
    t1.xy = t1.xy + vec2(-0.5, -0.5);
    t17.xy = (-t8.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t2.xy = (-t8.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t17.xy = t17.xy / t2.xy;
    t3.xy = t17.xy + vec2(-2.0, -2.0);
    t4.z = t3.y;
    t17.xy = t8.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t2.xz = t8.xy / t17.xy;
    t4.xw = t2.xz + vec2(2.0, 2.0);
    t3.w = t4.x;
    t2.xz = t8.xy + vec2(3.0, 3.0);
    t8.x = t8.x * 3.0;
    t5.xz = t8.xx * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t4.xy = t2.xz * _ShadowMapTexture_TexelSize.xy;
    t6.xz = _ShadowMapTexture_TexelSize.yy;
    t6.y = 0.142857149;
    t6.xyz = vec3(t4.z * t6.x, t4.y * t6.y, t4.w * t6.z);
    t3.z = t4.x;
    t4.w = t6.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t4.xyz = t3.zxw * t7.yxz;
    t3 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.ywxw;
    t8.xy = t1.xy * _ShadowMapTexture_TexelSize.xy + t4.zw;
    vec3 txVec0 = vec3(t8.xy,t8.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec0, 0.0);
    vec3 txVec1 = vec3(t3.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    vec3 txVec2 = vec3(t3.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec2, 0.0);
    t5.y = 7.0;
    t2.xyz = t2.yyy * t5.xyz;
    t7.xyz = t17.yyy * t5.xyz;
    t5.xy = t5.xz * vec2(7.0, 7.0);
    t17.x = t10_17 * t2.y;
    t16 = t2.x * t10_16 + t17.x;
    t8.x = t2.z * t10_8 + t16;
    t6.w = t4.y;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t6.wywz;
    t4.yw = t6.yz;
    vec3 txVec3 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec3, 0.0);
    vec3 txVec4 = vec3(t2.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec4, 0.0);
    t8.x = t5.x * t10_16 + t8.x;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xyzy;
    t3 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xwzw;
    vec3 txVec5 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec5, 0.0);
    vec3 txVec6 = vec3(t2.zw,t8.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec6, 0.0);
    t8.x = t10_16 * 49.0 + t8.x;
    t8.x = t5.y * t10_1 + t8.x;
    t8.x = t7.x * t10_17 + t8.x;
    vec3 txVec7 = vec3(t3.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec7, 0.0);
    vec3 txVec8 = vec3(t3.zw,t8.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec8, 0.0);
    t8.x = t7.y * t10_16 + t8.x;
    t8.x = t7.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16_16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16_16 + _LightShadowData.x;
    t0 = t0.xxxx + t8.xxxx;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
lowp float t10_1;
bvec4 tb1;
vec4 t2;
vec4 t3;
vec4 t4;
vec3 t5;
vec4 t6;
vec3 t7;
vec3 t8;
lowp float t10_8;
vec3 t9;
float t16;
lowp float t10_16;
vec2 t17;
lowp float t10_17;
lowp float t10_24;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t8.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t10_0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.xyz + (-unity_ShadowSplitSpheres[0].xyz);
    t1.x = dot(t1.xyz, t1.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[1].xyz);
    t1.y = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[2].xyz);
    t1.z = dot(t2.xyz, t2.xyz);
    t2.xyz = t0.xyz + (-unity_ShadowSplitSpheres[3].xyz);
    t1.w = dot(t2.xyz, t2.xyz);
    tb1 = lessThan(t1, unity_ShadowSplitSqRadii);
    t2.x = (tb1.x) ? float(-1.0) : float(-0.0);
    t2.y = (tb1.y) ? float(-1.0) : float(-0.0);
    t2.z = (tb1.z) ? float(-1.0) : float(-0.0);
    t1 = mix(vec4(0.0, 0.0, 0.0, 0.0), vec4(1.0, 1.0, 1.0, 1.0), vec4(tb1));
    t9.xyz = t2.xyz + t1.yzw;
    t9.xyz = max(t9.xyz, vec3(0.0, 0.0, 0.0));
    t2.xyz = t0.yyy * unity_World2Shadow[1][1].xyz;
    t2.xyz = unity_World2Shadow[1][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[1][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[1][3].xyz * t0.www + t2.xyz;
    t2.xyz = t9.xxx * t2.xyz;
    t3.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t3.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[0][3].xyz * t0.www + t3.xyz;
    t2.xyz = t3.xyz * t1.xxx + t2.xyz;
    t3.xyz = t0.yyy * unity_World2Shadow[2][1].xyz;
    t3.xyz = unity_World2Shadow[2][0].xyz * t0.xxx + t3.xyz;
    t3.xyz = unity_World2Shadow[2][2].xyz * t0.zzz + t3.xyz;
    t3.xyz = unity_World2Shadow[2][3].xyz * t0.www + t3.xyz;
    t1.xyz = t3.xyz * t9.yyy + t2.xyz;
    t2.xyz = t0.yyy * unity_World2Shadow[3][1].xyz;
    t2.xyz = unity_World2Shadow[3][0].xyz * t0.xxx + t2.xyz;
    t2.xyz = unity_World2Shadow[3][2].xyz * t0.zzz + t2.xyz;
    t2.xyz = unity_World2Shadow[3][3].xyz * t0.www + t2.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t8.xyz = t2.xyz * t9.zzz + t1.xyz;
    t8.xy = t8.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t1.xy = floor(t8.xy);
    t8.xy = fract(t8.xy);
    t1.xy = t1.xy + vec2(-0.5, -0.5);
    t17.xy = (-t8.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t2.xy = (-t8.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t17.xy = t17.xy / t2.xy;
    t3.xy = t17.xy + vec2(-2.0, -2.0);
    t4.z = t3.y;
    t17.xy = t8.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t2.xz = t8.xy / t17.xy;
    t4.xw = t2.xz + vec2(2.0, 2.0);
    t3.w = t4.x;
    t2.xz = t8.xy + vec2(3.0, 3.0);
    t8.x = t8.x * 3.0;
    t5.xz = t8.xx * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t4.xy = t2.xz * _ShadowMapTexture_TexelSize.xy;
    t6.xz = _ShadowMapTexture_TexelSize.yy;
    t6.y = 0.142857149;
    t6.xyz = t4.zyw * t6.xyz;
    t3.z = t4.x;
    t4.w = t6.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t4.xyz = t3.zxw * t7.yxz;
    t3 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.ywxw;
    t8.xy = t1.xy * _ShadowMapTexture_TexelSize.xy + t4.zw;
    vec3 txVec1 = vec3(t8.xy,t8.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    vec3 txVec2 = vec3(t3.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec2, 0.0);
    vec3 txVec3 = vec3(t3.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec3, 0.0);
    t5.y = 7.0;
    t2.xyz = t2.yyy * t5.xyz;
    t3.xyz = t17.yyy * t5.xyz;
    t5.xy = t5.xz * vec2(7.0, 7.0);
    t17.x = t10_17 * t2.y;
    t16 = t2.x * t10_16 + t17.x;
    t8.x = t2.z * t10_8 + t16;
    t6.w = t4.y;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t6.wywz;
    t4.yw = t6.yz;
    vec3 txVec4 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec4, 0.0);
    vec3 txVec5 = vec3(t2.zw,t8.z);
    t10_17 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec5, 0.0);
    t8.x = t5.x * t10_16 + t8.x;
    t2 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xyzy;
    t4 = t1.xyxy * _ShadowMapTexture_TexelSize.xyxy + t4.xwzw;
    vec3 txVec6 = vec3(t2.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec6, 0.0);
    vec3 txVec7 = vec3(t2.zw,t8.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec7, 0.0);
    t8.x = t10_16 * 49.0 + t8.x;
    t8.x = t5.y * t10_1 + t8.x;
    t8.x = t3.x * t10_17 + t8.x;
    vec3 txVec8 = vec3(t4.xy,t8.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec8, 0.0);
    vec3 txVec9 = vec3(t4.zw,t8.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec9, 0.0);
    t8.x = t3.y * t10_16 + t8.x;
    t8.x = t3.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t8.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_6)).xyz;
  mediump float shadow_8;
  shadow_8 = 0.0;
  highp vec2 tmpvar_9;
  tmpvar_9 = _ShadowMapTexture_TexelSize.xy;
  highp vec3 tmpvar_10;
  tmpvar_10.xy = (tmpvar_7.xy - _ShadowMapTexture_TexelSize.xy);
  tmpvar_10.z = tmpvar_7.z;
  highp vec4 tmpvar_11;
  tmpvar_11 = texture2D (_ShadowMapTexture, tmpvar_10.xy);
  mediump float tmpvar_12;
  if ((tmpvar_11.x < tmpvar_7.z)) {
    tmpvar_12 = 0.0;
  } else {
    tmpvar_12 = 1.0;
  };
  shadow_8 = tmpvar_12;
  highp vec2 tmpvar_13;
  tmpvar_13.x = 0.0;
  tmpvar_13.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_14;
  tmpvar_14.xy = (tmpvar_7.xy + tmpvar_13);
  tmpvar_14.z = tmpvar_7.z;
  highp vec4 tmpvar_15;
  tmpvar_15 = texture2D (_ShadowMapTexture, tmpvar_14.xy);
  highp float tmpvar_16;
  if ((tmpvar_15.x < tmpvar_7.z)) {
    tmpvar_16 = 0.0;
  } else {
    tmpvar_16 = 1.0;
  };
  shadow_8 = (tmpvar_12 + tmpvar_16);
  highp vec2 tmpvar_17;
  tmpvar_17.x = tmpvar_9.x;
  tmpvar_17.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_18;
  tmpvar_18.xy = (tmpvar_7.xy + tmpvar_17);
  tmpvar_18.z = tmpvar_7.z;
  highp vec4 tmpvar_19;
  tmpvar_19 = texture2D (_ShadowMapTexture, tmpvar_18.xy);
  highp float tmpvar_20;
  if ((tmpvar_19.x < tmpvar_7.z)) {
    tmpvar_20 = 0.0;
  } else {
    tmpvar_20 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_20);
  highp vec2 tmpvar_21;
  tmpvar_21.y = 0.0;
  tmpvar_21.x = -(_ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_7.xy + tmpvar_21);
  tmpvar_22.z = tmpvar_7.z;
  highp vec4 tmpvar_23;
  tmpvar_23 = texture2D (_ShadowMapTexture, tmpvar_22.xy);
  highp float tmpvar_24;
  if ((tmpvar_23.x < tmpvar_7.z)) {
    tmpvar_24 = 0.0;
  } else {
    tmpvar_24 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_24);
  highp vec4 tmpvar_25;
  tmpvar_25 = texture2D (_ShadowMapTexture, tmpvar_7.xy);
  highp float tmpvar_26;
  if ((tmpvar_25.x < tmpvar_7.z)) {
    tmpvar_26 = 0.0;
  } else {
    tmpvar_26 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_26);
  highp vec2 tmpvar_27;
  tmpvar_27.y = 0.0;
  tmpvar_27.x = tmpvar_9.x;
  highp vec3 tmpvar_28;
  tmpvar_28.xy = (tmpvar_7.xy + tmpvar_27);
  tmpvar_28.z = tmpvar_7.z;
  highp vec4 tmpvar_29;
  tmpvar_29 = texture2D (_ShadowMapTexture, tmpvar_28.xy);
  highp float tmpvar_30;
  if ((tmpvar_29.x < tmpvar_7.z)) {
    tmpvar_30 = 0.0;
  } else {
    tmpvar_30 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_30);
  highp vec2 tmpvar_31;
  tmpvar_31.x = -(_ShadowMapTexture_TexelSize.x);
  tmpvar_31.y = tmpvar_9.y;
  highp vec3 tmpvar_32;
  tmpvar_32.xy = (tmpvar_7.xy + tmpvar_31);
  tmpvar_32.z = tmpvar_7.z;
  highp vec4 tmpvar_33;
  tmpvar_33 = texture2D (_ShadowMapTexture, tmpvar_32.xy);
  highp float tmpvar_34;
  if ((tmpvar_33.x < tmpvar_7.z)) {
    tmpvar_34 = 0.0;
  } else {
    tmpvar_34 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_34);
  highp vec2 tmpvar_35;
  tmpvar_35.x = 0.0;
  tmpvar_35.y = tmpvar_9.y;
  highp vec3 tmpvar_36;
  tmpvar_36.xy = (tmpvar_7.xy + tmpvar_35);
  tmpvar_36.z = tmpvar_7.z;
  highp vec4 tmpvar_37;
  tmpvar_37 = texture2D (_ShadowMapTexture, tmpvar_36.xy);
  highp float tmpvar_38;
  if ((tmpvar_37.x < tmpvar_7.z)) {
    tmpvar_38 = 0.0;
  } else {
    tmpvar_38 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_38);
  highp vec3 tmpvar_39;
  tmpvar_39.xy = (tmpvar_7.xy + _ShadowMapTexture_TexelSize.xy);
  tmpvar_39.z = tmpvar_7.z;
  highp vec4 tmpvar_40;
  tmpvar_40 = texture2D (_ShadowMapTexture, tmpvar_39.xy);
  highp float tmpvar_41;
  if ((tmpvar_40.x < tmpvar_7.z)) {
    tmpvar_41 = 0.0;
  } else {
    tmpvar_41 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_41);
  shadow_8 = (shadow_8 / 9.0);
  mediump float tmpvar_42;
  tmpvar_42 = mix (_LightShadowData.x, 1.0, shadow_8);
  shadow_8 = tmpvar_42;
  highp float tmpvar_43;
  tmpvar_43 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (tmpvar_42 + tmpvar_43);
  mediump vec4 tmpvar_44;
  tmpvar_44 = vec4(shadow_2);
  tmpvar_1 = tmpvar_44;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
uniform vec4 _ShadowMapTexture_TexelSize;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec3 tmpvar_3;
  tmpvar_3 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4.w = 1.0;
  tmpvar_4.xyz = tmpvar_3;
  vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_4)).xyz;
  vec3 accum_6;
  float sum_7;
  float shadow_8;
  vec3 v_9;
  vec3 u_10;
  vec2 tmpvar_11;
  tmpvar_11 = ((tmpvar_5.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  vec2 tmpvar_12;
  tmpvar_12 = ((floor(tmpvar_11) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  vec2 tmpvar_13;
  tmpvar_13 = fract(tmpvar_11);
  vec3 tmpvar_14;
  tmpvar_14.y = 7.0;
  tmpvar_14.x = (4.0 - (3.0 * tmpvar_13.x));
  tmpvar_14.z = (1.0 + (3.0 * tmpvar_13.x));
  vec3 tmpvar_15;
  tmpvar_15.x = (((3.0 - 
    (2.0 * tmpvar_13.x)
  ) / tmpvar_14.x) - 2.0);
  tmpvar_15.y = ((3.0 + tmpvar_13.x) / 7.0);
  tmpvar_15.z = ((tmpvar_13.x / tmpvar_14.z) + 2.0);
  u_10 = (tmpvar_15 * _ShadowMapTexture_TexelSize.x);
  vec3 tmpvar_16;
  tmpvar_16.y = 7.0;
  tmpvar_16.x = (4.0 - (3.0 * tmpvar_13.y));
  tmpvar_16.z = (1.0 + (3.0 * tmpvar_13.y));
  vec3 tmpvar_17;
  tmpvar_17.x = (((3.0 - 
    (2.0 * tmpvar_13.y)
  ) / tmpvar_16.x) - 2.0);
  tmpvar_17.y = ((3.0 + tmpvar_13.y) / 7.0);
  tmpvar_17.z = ((tmpvar_13.y / tmpvar_16.z) + 2.0);
  v_9 = (tmpvar_17 * _ShadowMapTexture_TexelSize.y);
  vec3 tmpvar_18;
  tmpvar_18 = (tmpvar_14 * tmpvar_16.x);
  vec2 tmpvar_19;
  tmpvar_19.x = u_10.x;
  tmpvar_19.y = v_9.x;
  float depth_20;
  depth_20 = tmpvar_5.z;
  vec3 uv_21;
  vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_12 + tmpvar_19);
  tmpvar_22.z = depth_20;
  uv_21.xy = tmpvar_22.xy;
  uv_21.z = depth_20;
  sum_7 = (tmpvar_18.x * shadow2D (_ShadowMapTexture, uv_21).x);
  vec2 tmpvar_23;
  tmpvar_23.x = u_10.y;
  tmpvar_23.y = v_9.x;
  float depth_24;
  depth_24 = tmpvar_5.z;
  vec3 uv_25;
  vec3 tmpvar_26;
  tmpvar_26.xy = (tmpvar_12 + tmpvar_23);
  tmpvar_26.z = depth_24;
  uv_25.xy = tmpvar_26.xy;
  uv_25.z = depth_24;
  sum_7 = (sum_7 + (tmpvar_18.y * shadow2D (_ShadowMapTexture, uv_25).x));
  vec2 tmpvar_27;
  tmpvar_27.x = u_10.z;
  tmpvar_27.y = v_9.x;
  float depth_28;
  depth_28 = tmpvar_5.z;
  vec3 uv_29;
  vec3 tmpvar_30;
  tmpvar_30.xy = (tmpvar_12 + tmpvar_27);
  tmpvar_30.z = depth_28;
  uv_29.xy = tmpvar_30.xy;
  uv_29.z = depth_28;
  sum_7 = (sum_7 + (tmpvar_18.z * shadow2D (_ShadowMapTexture, uv_29).x));
  accum_6 = (tmpvar_14 * 7.0);
  vec2 tmpvar_31;
  tmpvar_31.x = u_10.x;
  tmpvar_31.y = v_9.y;
  float depth_32;
  depth_32 = tmpvar_5.z;
  vec3 uv_33;
  vec3 tmpvar_34;
  tmpvar_34.xy = (tmpvar_12 + tmpvar_31);
  tmpvar_34.z = depth_32;
  uv_33.xy = tmpvar_34.xy;
  uv_33.z = depth_32;
  sum_7 = (sum_7 + (accum_6.x * shadow2D (_ShadowMapTexture, uv_33).x));
  vec2 tmpvar_35;
  tmpvar_35.x = u_10.y;
  tmpvar_35.y = v_9.y;
  float depth_36;
  depth_36 = tmpvar_5.z;
  vec3 uv_37;
  vec3 tmpvar_38;
  tmpvar_38.xy = (tmpvar_12 + tmpvar_35);
  tmpvar_38.z = depth_36;
  uv_37.xy = tmpvar_38.xy;
  uv_37.z = depth_36;
  sum_7 = (sum_7 + (accum_6.y * shadow2D (_ShadowMapTexture, uv_37).x));
  vec2 tmpvar_39;
  tmpvar_39.x = u_10.z;
  tmpvar_39.y = v_9.y;
  float depth_40;
  depth_40 = tmpvar_5.z;
  vec3 uv_41;
  vec3 tmpvar_42;
  tmpvar_42.xy = (tmpvar_12 + tmpvar_39);
  tmpvar_42.z = depth_40;
  uv_41.xy = tmpvar_42.xy;
  uv_41.z = depth_40;
  sum_7 = (sum_7 + (accum_6.z * shadow2D (_ShadowMapTexture, uv_41).x));
  accum_6 = (tmpvar_14 * tmpvar_16.z);
  vec2 tmpvar_43;
  tmpvar_43.x = u_10.x;
  tmpvar_43.y = v_9.z;
  float depth_44;
  depth_44 = tmpvar_5.z;
  vec3 uv_45;
  vec3 tmpvar_46;
  tmpvar_46.xy = (tmpvar_12 + tmpvar_43);
  tmpvar_46.z = depth_44;
  uv_45.xy = tmpvar_46.xy;
  uv_45.z = depth_44;
  sum_7 = (sum_7 + (accum_6.x * shadow2D (_ShadowMapTexture, uv_45).x));
  vec2 tmpvar_47;
  tmpvar_47.x = u_10.y;
  tmpvar_47.y = v_9.z;
  float depth_48;
  depth_48 = tmpvar_5.z;
  vec3 uv_49;
  vec3 tmpvar_50;
  tmpvar_50.xy = (tmpvar_12 + tmpvar_47);
  tmpvar_50.z = depth_48;
  uv_49.xy = tmpvar_50.xy;
  uv_49.z = depth_48;
  sum_7 = (sum_7 + (accum_6.y * shadow2D (_ShadowMapTexture, uv_49).x));
  vec2 tmpvar_51;
  tmpvar_51.x = u_10.z;
  tmpvar_51.y = v_9.z;
  float depth_52;
  depth_52 = tmpvar_5.z;
  vec3 uv_53;
  vec3 tmpvar_54;
  tmpvar_54.xy = (tmpvar_12 + tmpvar_51);
  tmpvar_54.z = depth_52;
  uv_53.xy = tmpvar_54.xy;
  uv_53.z = depth_52;
  sum_7 = (sum_7 + (accum_6.z * shadow2D (_ShadowMapTexture, uv_53).x));
  shadow_8 = (sum_7 / 144.0);
  float tmpvar_55;
  tmpvar_55 = mix (_LightShadowData.x, 1.0, shadow_8);
  shadow_8 = tmpvar_55;
  gl_FragData[0] = vec4((tmpvar_55 + clamp ((
    (tmpvar_3.z * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_3_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dcl_texcoord o0.xy
dcl_texcoord1 o1.xyz
dcl_texcoord2 o2
dcl_position o3
dp4 o3.z, c2, v0
dp4 o3.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov o3.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 o2.x, c4, r1
dp4 o2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov o3.x, r1.x
mov o2.zw, -r0.xyxy
mov o0.xy, v1
mov o1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec3 tmpvar_5;
  tmpvar_5 = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6.w = 1.0;
  tmpvar_6.xyz = tmpvar_5;
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * (_CameraToWorld * tmpvar_6)).xyz;
  mediump vec3 accum_8;
  mediump float sum_9;
  mediump float shadow_10;
  highp vec3 v_11;
  highp vec3 u_12;
  highp vec2 tmpvar_13;
  tmpvar_13 = ((tmpvar_7.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  highp vec2 tmpvar_14;
  tmpvar_14 = ((floor(tmpvar_13) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  highp vec2 tmpvar_15;
  tmpvar_15 = fract(tmpvar_13);
  highp vec3 tmpvar_16;
  tmpvar_16.y = 7.0;
  tmpvar_16.x = (4.0 - (3.0 * tmpvar_15.x));
  tmpvar_16.z = (1.0 + (3.0 * tmpvar_15.x));
  highp vec3 tmpvar_17;
  tmpvar_17.x = (((3.0 - 
    (2.0 * tmpvar_15.x)
  ) / tmpvar_16.x) - 2.0);
  tmpvar_17.y = ((3.0 + tmpvar_15.x) / 7.0);
  tmpvar_17.z = ((tmpvar_15.x / tmpvar_16.z) + 2.0);
  u_12 = (tmpvar_17 * _ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_18;
  tmpvar_18.y = 7.0;
  tmpvar_18.x = (4.0 - (3.0 * tmpvar_15.y));
  tmpvar_18.z = (1.0 + (3.0 * tmpvar_15.y));
  highp vec3 tmpvar_19;
  tmpvar_19.x = (((3.0 - 
    (2.0 * tmpvar_15.y)
  ) / tmpvar_18.x) - 2.0);
  tmpvar_19.y = ((3.0 + tmpvar_15.y) / 7.0);
  tmpvar_19.z = ((tmpvar_15.y / tmpvar_18.z) + 2.0);
  v_11 = (tmpvar_19 * _ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_20;
  tmpvar_20 = (tmpvar_16 * tmpvar_18.x);
  accum_8 = tmpvar_20;
  highp vec2 tmpvar_21;
  tmpvar_21.x = u_12.x;
  tmpvar_21.y = v_11.x;
  highp float depth_22;
  depth_22 = tmpvar_7.z;
  highp vec3 uv_23;
  highp vec3 tmpvar_24;
  tmpvar_24.xy = (tmpvar_14 + tmpvar_21);
  tmpvar_24.z = depth_22;
  uv_23.xy = tmpvar_24.xy;
  uv_23.z = depth_22;
  lowp float tmpvar_25;
  tmpvar_25 = shadow2DEXT (_ShadowMapTexture, uv_23);
  sum_9 = (accum_8.x * tmpvar_25);
  highp vec2 tmpvar_26;
  tmpvar_26.x = u_12.y;
  tmpvar_26.y = v_11.x;
  highp float depth_27;
  depth_27 = tmpvar_7.z;
  highp vec3 uv_28;
  highp vec3 tmpvar_29;
  tmpvar_29.xy = (tmpvar_14 + tmpvar_26);
  tmpvar_29.z = depth_27;
  uv_28.xy = tmpvar_29.xy;
  uv_28.z = depth_27;
  lowp float tmpvar_30;
  tmpvar_30 = shadow2DEXT (_ShadowMapTexture, uv_28);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_30));
  highp vec2 tmpvar_31;
  tmpvar_31.x = u_12.z;
  tmpvar_31.y = v_11.x;
  highp float depth_32;
  depth_32 = tmpvar_7.z;
  highp vec3 uv_33;
  highp vec3 tmpvar_34;
  tmpvar_34.xy = (tmpvar_14 + tmpvar_31);
  tmpvar_34.z = depth_32;
  uv_33.xy = tmpvar_34.xy;
  uv_33.z = depth_32;
  lowp float tmpvar_35;
  tmpvar_35 = shadow2DEXT (_ShadowMapTexture, uv_33);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_35));
  accum_8 = (tmpvar_16 * 7.0);
  highp vec2 tmpvar_36;
  tmpvar_36.x = u_12.x;
  tmpvar_36.y = v_11.y;
  highp float depth_37;
  depth_37 = tmpvar_7.z;
  highp vec3 uv_38;
  highp vec3 tmpvar_39;
  tmpvar_39.xy = (tmpvar_14 + tmpvar_36);
  tmpvar_39.z = depth_37;
  uv_38.xy = tmpvar_39.xy;
  uv_38.z = depth_37;
  lowp float tmpvar_40;
  tmpvar_40 = shadow2DEXT (_ShadowMapTexture, uv_38);
  sum_9 = (sum_9 + (accum_8.x * tmpvar_40));
  highp vec2 tmpvar_41;
  tmpvar_41.x = u_12.y;
  tmpvar_41.y = v_11.y;
  highp float depth_42;
  depth_42 = tmpvar_7.z;
  highp vec3 uv_43;
  highp vec3 tmpvar_44;
  tmpvar_44.xy = (tmpvar_14 + tmpvar_41);
  tmpvar_44.z = depth_42;
  uv_43.xy = tmpvar_44.xy;
  uv_43.z = depth_42;
  lowp float tmpvar_45;
  tmpvar_45 = shadow2DEXT (_ShadowMapTexture, uv_43);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_45));
  highp vec2 tmpvar_46;
  tmpvar_46.x = u_12.z;
  tmpvar_46.y = v_11.y;
  highp float depth_47;
  depth_47 = tmpvar_7.z;
  highp vec3 uv_48;
  highp vec3 tmpvar_49;
  tmpvar_49.xy = (tmpvar_14 + tmpvar_46);
  tmpvar_49.z = depth_47;
  uv_48.xy = tmpvar_49.xy;
  uv_48.z = depth_47;
  lowp float tmpvar_50;
  tmpvar_50 = shadow2DEXT (_ShadowMapTexture, uv_48);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_50));
  accum_8 = (tmpvar_16 * tmpvar_18.z);
  highp vec2 tmpvar_51;
  tmpvar_51.x = u_12.x;
  tmpvar_51.y = v_11.z;
  highp float depth_52;
  depth_52 = tmpvar_7.z;
  highp vec3 uv_53;
  highp vec3 tmpvar_54;
  tmpvar_54.xy = (tmpvar_14 + tmpvar_51);
  tmpvar_54.z = depth_52;
  uv_53.xy = tmpvar_54.xy;
  uv_53.z = depth_52;
  lowp float tmpvar_55;
  tmpvar_55 = shadow2DEXT (_ShadowMapTexture, uv_53);
  sum_9 = (sum_9 + (accum_8.x * tmpvar_55));
  highp vec2 tmpvar_56;
  tmpvar_56.x = u_12.y;
  tmpvar_56.y = v_11.z;
  highp float depth_57;
  depth_57 = tmpvar_7.z;
  highp vec3 uv_58;
  highp vec3 tmpvar_59;
  tmpvar_59.xy = (tmpvar_14 + tmpvar_56);
  tmpvar_59.z = depth_57;
  uv_58.xy = tmpvar_59.xy;
  uv_58.z = depth_57;
  lowp float tmpvar_60;
  tmpvar_60 = shadow2DEXT (_ShadowMapTexture, uv_58);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_60));
  highp vec2 tmpvar_61;
  tmpvar_61.x = u_12.z;
  tmpvar_61.y = v_11.z;
  highp float depth_62;
  depth_62 = tmpvar_7.z;
  highp vec3 uv_63;
  highp vec3 tmpvar_64;
  tmpvar_64.xy = (tmpvar_14 + tmpvar_61);
  tmpvar_64.z = depth_62;
  uv_63.xy = tmpvar_64.xy;
  uv_63.z = depth_62;
  lowp float tmpvar_65;
  tmpvar_65 = shadow2DEXT (_ShadowMapTexture, uv_63);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_65));
  shadow_10 = (sum_9 / 144.0);
  mediump float tmpvar_66;
  tmpvar_66 = mix (_LightShadowData.x, 1.0, shadow_10);
  shadow_10 = tmpvar_66;
  highp float tmpvar_67;
  tmpvar_67 = clamp (((tmpvar_5.z * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  shadow_2 = (tmpvar_66 + tmpvar_67);
  mediump vec4 tmpvar_68;
  tmpvar_68 = vec4(shadow_2);
  tmpvar_1 = tmpvar_68;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
lowp float t10_1;
highp vec3 t2;
lowp float t10_2;
highp vec4 t3;
highp vec4 t4;
highp vec4 t5;
highp vec3 t6;
highp vec3 t7;
lowp float t10_7;
lowp float t10_8;
highp vec2 t9;
lowp float t10_9;
highp float t14;
mediump float t16_14;
lowp float t10_14;
lowp float t10_15;
highp vec2 t16;
lowp float t10_21;
highp float t22;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t7.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t7.x = float(1.0) / t7.x;
    t14 = (-t7.x) + t0.x;
    t7.x = unity_OrthoParams.w * t14 + t7.x;
    t1.xy = vs_TEXCOORD2.xy;
    t14 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t14 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t7.xxx + t1.xyz;
    t1.xyz = t7.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t1 = _CameraToWorld[2] * t0.zzzz + t1;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t1 = t1 + _CameraToWorld[3];
    t7.xyz = t1.yyy * unity_World2Shadow[0][1].xyz;
    t7.xyz = unity_World2Shadow[0][0].xyz * t1.xxx + t7.xyz;
    t7.xyz = unity_World2Shadow[0][2].xyz * t1.zzz + t7.xyz;
    t7.xyz = unity_World2Shadow[0][3].xyz * t1.www + t7.xyz;
    t1.xz = _ShadowMapTexture_TexelSize.yy;
    t1.y = 0.142857149;
    t7.xy = t7.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t2.xy = fract(t7.xy);
    t7.xy = floor(t7.xy);
    t7.xy = t7.xy + vec2(-0.5, -0.5);
    t16.xy = (-t2.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t3.xy = (-t2.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t16.xy = t16.xy / t3.xy;
    t4.xy = t16.xy + vec2(-2.0, -2.0);
    t5.z = t4.y;
    t16.xy = t2.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t3.xz = t2.xy / t16.xy;
    t5.xw = t3.xz + vec2(2.0, 2.0);
    t4.w = t5.x;
    t9.xy = t2.xy + vec2(3.0, 3.0);
    t22 = t2.x * 3.0;
    t6.xz = vec2(t22) * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t5.xy = t9.xy * _ShadowMapTexture_TexelSize.xy;
    t1.xyz = vec3(t1.x * t5.z, t1.y * t5.y, t1.z * t5.w);
    t4.z = t5.x;
    t5.w = t1.x;
    t2.xz = _ShadowMapTexture_TexelSize.xx;
    t2.y = 0.142857149;
    t5.xyz = t2.yxz * t4.zxw;
    t4 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.ywxw;
    t2.xy = t7.xy * _ShadowMapTexture_TexelSize.xy + t5.zw;
    vec3 txVec10 = vec3(t2.xy,t7.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec10, 0.0);
    vec3 txVec11 = vec3(t4.xy,t7.z);
    t10_2 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec11, 0.0);
    vec3 txVec12 = vec3(t4.zw,t7.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec12, 0.0);
    t6.y = 7.0;
    t3.xyz = t3.yyy * t6.xyz;
    t4.xyz = t16.yyy * t6.xyz;
    t16.xy = t6.xz * vec2(7.0, 7.0);
    t9.x = t10_9 * t3.y;
    t2.x = t3.x * t10_2 + t9.x;
    t1.x = t3.z * t10_1 + t2.x;
    t1.w = t5.y;
    t3 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t1.wywz;
    t5.yw = t1.yz;
    vec3 txVec13 = vec3(t3.xy,t7.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec13, 0.0);
    vec3 txVec14 = vec3(t3.zw,t7.z);
    t10_15 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec14, 0.0);
    t1.x = t16.x * t10_8 + t1.x;
    t3 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xyzy;
    t5 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xwzw;
    vec3 txVec15 = vec3(t3.xy,t7.z);
    t10_7 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec15, 0.0);
    vec3 txVec16 = vec3(t3.zw,t7.z);
    t10_14 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec16, 0.0);
    t7.x = t10_7 * 49.0 + t1.x;
    t7.x = t16.y * t10_14 + t7.x;
    t7.x = t4.x * t10_15 + t7.x;
    vec3 txVec17 = vec3(t5.xy,t7.z);
    t10_14 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec17, 0.0);
    vec3 txVec18 = vec3(t5.zw,t7.z);
    t10_21 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec18, 0.0);
    t7.x = t4.y * t10_14 + t7.x;
    t7.x = t4.z * t10_21 + t7.x;
    t7.x = t7.x * 0.0069444445;
    t16_14 = (-_LightShadowData.x) + 1.0;
    t7.x = t7.x * t16_14 + _LightShadowData.x;
    t0 = t0.xxxx + t7.xxxx;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
lowp float t10_1;
vec3 t2;
lowp float t10_2;
vec4 t3;
vec4 t4;
vec4 t5;
vec3 t6;
vec3 t7;
lowp float t10_7;
lowp float t10_8;
vec2 t9;
lowp float t10_9;
float t14;
lowp float t10_14;
lowp float t10_15;
vec2 t16;
lowp float t10_21;
float t22;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t7.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t7.x = float(1.0) / t7.x;
    t14 = (-t7.x) + t10_0.x;
    t7.x = unity_OrthoParams.w * t14 + t7.x;
    t1.xy = vs_TEXCOORD2.xy;
    t14 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t14 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t7.xxx + t1.xyz;
    t1.xyz = t7.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t1 = _CameraToWorld[2] * t0.zzzz + t1;
    t0.x = t0.z * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t1 = t1 + _CameraToWorld[3];
    t7.xyz = t1.yyy * unity_World2Shadow[0][1].xyz;
    t7.xyz = unity_World2Shadow[0][0].xyz * t1.xxx + t7.xyz;
    t7.xyz = unity_World2Shadow[0][2].xyz * t1.zzz + t7.xyz;
    t7.xyz = unity_World2Shadow[0][3].xyz * t1.www + t7.xyz;
    t1.xz = _ShadowMapTexture_TexelSize.yy;
    t1.y = 0.142857149;
    t7.xy = t7.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t2.xy = fract(t7.xy);
    t7.xy = floor(t7.xy);
    t7.xy = t7.xy + vec2(-0.5, -0.5);
    t16.xy = (-t2.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t3.xy = (-t2.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t16.xy = t16.xy / t3.xy;
    t4.xy = t16.xy + vec2(-2.0, -2.0);
    t5.z = t4.y;
    t16.xy = t2.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t3.xz = t2.xy / t16.xy;
    t5.xw = t3.xz + vec2(2.0, 2.0);
    t4.w = t5.x;
    t9.xy = t2.xy + vec2(3.0, 3.0);
    t22 = t2.x * 3.0;
    t6.xz = vec2(t22) * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t5.xy = t9.xy * _ShadowMapTexture_TexelSize.xy;
    t1.xyz = t1.xyz * t5.zyw;
    t4.z = t5.x;
    t5.w = t1.x;
    t2.xz = _ShadowMapTexture_TexelSize.xx;
    t2.y = 0.142857149;
    t5.xyz = t2.yxz * t4.zxw;
    t4 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.ywxw;
    t2.xy = t7.xy * _ShadowMapTexture_TexelSize.xy + t5.zw;
    vec3 txVec11 = vec3(t2.xy,t7.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec11, 0.0);
    vec3 txVec12 = vec3(t4.xy,t7.z);
    t10_2 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec12, 0.0);
    vec3 txVec13 = vec3(t4.zw,t7.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec13, 0.0);
    t6.y = 7.0;
    t3.xyz = t3.yyy * t6.xyz;
    t4.xyz = t16.yyy * t6.xyz;
    t16.xy = t6.xz * vec2(7.0, 7.0);
    t9.x = t10_9 * t3.y;
    t2.x = t3.x * t10_2 + t9.x;
    t1.x = t3.z * t10_1 + t2.x;
    t1.w = t5.y;
    t3 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t1.wywz;
    t5.yw = t1.yz;
    vec3 txVec14 = vec3(t3.xy,t7.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec14, 0.0);
    vec3 txVec15 = vec3(t3.zw,t7.z);
    t10_15 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec15, 0.0);
    t1.x = t16.x * t10_8 + t1.x;
    t3 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xyzy;
    t5 = t7.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xwzw;
    vec3 txVec16 = vec3(t3.xy,t7.z);
    t10_7 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec16, 0.0);
    vec3 txVec17 = vec3(t3.zw,t7.z);
    t10_14 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec17, 0.0);
    t7.x = t10_7 * 49.0 + t1.x;
    t7.x = t16.y * t10_14 + t7.x;
    t7.x = t4.x * t10_15 + t7.x;
    vec3 txVec18 = vec3(t5.xy,t7.z);
    t10_14 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec18, 0.0);
    vec3 txVec19 = vec3(t5.zw,t7.z);
    t10_21 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec19, 0.0);
    t7.x = t4.y * t10_14 + t7.x;
    t7.x = t4.z * t10_21 + t7.x;
    t7.x = t7.x * 0.0069444445;
    t14 = (-_LightShadowData.x) + 1.0;
    t7.x = t7.x * t14 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t7.xxxx;
    return;
}

#endif
"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES
#version 100

#ifdef VERTEX
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform highp sampler2D _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * tmpvar_6).xyz;
  mediump float shadow_8;
  shadow_8 = 0.0;
  highp vec2 tmpvar_9;
  tmpvar_9 = _ShadowMapTexture_TexelSize.xy;
  highp vec3 tmpvar_10;
  tmpvar_10.xy = (tmpvar_7.xy - _ShadowMapTexture_TexelSize.xy);
  tmpvar_10.z = tmpvar_7.z;
  highp vec4 tmpvar_11;
  tmpvar_11 = texture2D (_ShadowMapTexture, tmpvar_10.xy);
  mediump float tmpvar_12;
  if ((tmpvar_11.x < tmpvar_7.z)) {
    tmpvar_12 = 0.0;
  } else {
    tmpvar_12 = 1.0;
  };
  shadow_8 = tmpvar_12;
  highp vec2 tmpvar_13;
  tmpvar_13.x = 0.0;
  tmpvar_13.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_14;
  tmpvar_14.xy = (tmpvar_7.xy + tmpvar_13);
  tmpvar_14.z = tmpvar_7.z;
  highp vec4 tmpvar_15;
  tmpvar_15 = texture2D (_ShadowMapTexture, tmpvar_14.xy);
  highp float tmpvar_16;
  if ((tmpvar_15.x < tmpvar_7.z)) {
    tmpvar_16 = 0.0;
  } else {
    tmpvar_16 = 1.0;
  };
  shadow_8 = (tmpvar_12 + tmpvar_16);
  highp vec2 tmpvar_17;
  tmpvar_17.x = tmpvar_9.x;
  tmpvar_17.y = -(_ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_18;
  tmpvar_18.xy = (tmpvar_7.xy + tmpvar_17);
  tmpvar_18.z = tmpvar_7.z;
  highp vec4 tmpvar_19;
  tmpvar_19 = texture2D (_ShadowMapTexture, tmpvar_18.xy);
  highp float tmpvar_20;
  if ((tmpvar_19.x < tmpvar_7.z)) {
    tmpvar_20 = 0.0;
  } else {
    tmpvar_20 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_20);
  highp vec2 tmpvar_21;
  tmpvar_21.y = 0.0;
  tmpvar_21.x = -(_ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_7.xy + tmpvar_21);
  tmpvar_22.z = tmpvar_7.z;
  highp vec4 tmpvar_23;
  tmpvar_23 = texture2D (_ShadowMapTexture, tmpvar_22.xy);
  highp float tmpvar_24;
  if ((tmpvar_23.x < tmpvar_7.z)) {
    tmpvar_24 = 0.0;
  } else {
    tmpvar_24 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_24);
  highp vec4 tmpvar_25;
  tmpvar_25 = texture2D (_ShadowMapTexture, tmpvar_7.xy);
  highp float tmpvar_26;
  if ((tmpvar_25.x < tmpvar_7.z)) {
    tmpvar_26 = 0.0;
  } else {
    tmpvar_26 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_26);
  highp vec2 tmpvar_27;
  tmpvar_27.y = 0.0;
  tmpvar_27.x = tmpvar_9.x;
  highp vec3 tmpvar_28;
  tmpvar_28.xy = (tmpvar_7.xy + tmpvar_27);
  tmpvar_28.z = tmpvar_7.z;
  highp vec4 tmpvar_29;
  tmpvar_29 = texture2D (_ShadowMapTexture, tmpvar_28.xy);
  highp float tmpvar_30;
  if ((tmpvar_29.x < tmpvar_7.z)) {
    tmpvar_30 = 0.0;
  } else {
    tmpvar_30 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_30);
  highp vec2 tmpvar_31;
  tmpvar_31.x = -(_ShadowMapTexture_TexelSize.x);
  tmpvar_31.y = tmpvar_9.y;
  highp vec3 tmpvar_32;
  tmpvar_32.xy = (tmpvar_7.xy + tmpvar_31);
  tmpvar_32.z = tmpvar_7.z;
  highp vec4 tmpvar_33;
  tmpvar_33 = texture2D (_ShadowMapTexture, tmpvar_32.xy);
  highp float tmpvar_34;
  if ((tmpvar_33.x < tmpvar_7.z)) {
    tmpvar_34 = 0.0;
  } else {
    tmpvar_34 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_34);
  highp vec2 tmpvar_35;
  tmpvar_35.x = 0.0;
  tmpvar_35.y = tmpvar_9.y;
  highp vec3 tmpvar_36;
  tmpvar_36.xy = (tmpvar_7.xy + tmpvar_35);
  tmpvar_36.z = tmpvar_7.z;
  highp vec4 tmpvar_37;
  tmpvar_37 = texture2D (_ShadowMapTexture, tmpvar_36.xy);
  highp float tmpvar_38;
  if ((tmpvar_37.x < tmpvar_7.z)) {
    tmpvar_38 = 0.0;
  } else {
    tmpvar_38 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_38);
  highp vec3 tmpvar_39;
  tmpvar_39.xy = (tmpvar_7.xy + _ShadowMapTexture_TexelSize.xy);
  tmpvar_39.z = tmpvar_7.z;
  highp vec4 tmpvar_40;
  tmpvar_40 = texture2D (_ShadowMapTexture, tmpvar_39.xy);
  highp float tmpvar_41;
  if ((tmpvar_40.x < tmpvar_7.z)) {
    tmpvar_41 = 0.0;
  } else {
    tmpvar_41 = 1.0;
  };
  shadow_8 = (shadow_8 + tmpvar_41);
  shadow_8 = (shadow_8 / 9.0);
  mediump float tmpvar_42;
  tmpvar_42 = mix (_LightShadowData.x, 1.0, shadow_8);
  shadow_8 = tmpvar_42;
  highp float tmpvar_43;
  highp vec3 tmpvar_44;
  tmpvar_44 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_45;
  highp float tmpvar_46;
  tmpvar_46 = clamp (((
    sqrt(dot (tmpvar_44, tmpvar_44))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_45 = tmpvar_46;
  tmpvar_43 = tmpvar_45;
  shadow_2 = (tmpvar_42 + tmpvar_43);
  mediump vec4 tmpvar_47;
  tmpvar_47 = vec4(shadow_2);
  tmpvar_1 = tmpvar_47;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL#version 120

#ifdef VERTEX
uniform vec4 _ProjectionParams;
uniform mat4 unity_CameraInvProjection;

varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec4 clipPos_1;
  vec4 tmpvar_2;
  tmpvar_2 = (gl_ModelViewProjectionMatrix * gl_Vertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = gl_MultiTexCoord0.xy;
  xlv_TEXCOORD1 = gl_Normal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
uniform vec4 _ZBufferParams;
uniform vec4 unity_OrthoParams;
uniform mat4 unity_World2Shadow[4];
uniform vec4 _LightShadowData;
uniform vec4 unity_ShadowFadeCenterAndType;
uniform sampler2D _CameraDepthTexture;
uniform mat4 _CameraToWorld;
uniform sampler2DShadow _ShadowMapTexture;
uniform vec4 _ShadowMapTexture_TexelSize;
varying vec2 xlv_TEXCOORD0;
varying vec3 xlv_TEXCOORD1;
varying vec4 xlv_TEXCOORD2;
void main ()
{
  vec3 vposOrtho_1;
  vec4 tmpvar_2;
  tmpvar_2 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_1.xy = xlv_TEXCOORD2.xy;
  vposOrtho_1.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_2.x);
  vec4 tmpvar_3;
  tmpvar_3.w = 1.0;
  tmpvar_3.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_2.x) + _ZBufferParams.y)))
  , tmpvar_2.x, unity_OrthoParams.w)), vposOrtho_1, unity_OrthoParams.www);
  vec4 tmpvar_4;
  tmpvar_4 = (_CameraToWorld * tmpvar_3);
  vec4 tmpvar_5;
  tmpvar_5.w = 0.0;
  tmpvar_5.xyz = (unity_World2Shadow[0] * tmpvar_4).xyz;
  vec3 accum_6;
  float sum_7;
  float shadow_8;
  vec3 v_9;
  vec3 u_10;
  vec2 tmpvar_11;
  tmpvar_11 = ((tmpvar_5.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  vec2 tmpvar_12;
  tmpvar_12 = ((floor(tmpvar_11) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  vec2 tmpvar_13;
  tmpvar_13 = fract(tmpvar_11);
  vec3 tmpvar_14;
  tmpvar_14.y = 7.0;
  tmpvar_14.x = (4.0 - (3.0 * tmpvar_13.x));
  tmpvar_14.z = (1.0 + (3.0 * tmpvar_13.x));
  vec3 tmpvar_15;
  tmpvar_15.x = (((3.0 - 
    (2.0 * tmpvar_13.x)
  ) / tmpvar_14.x) - 2.0);
  tmpvar_15.y = ((3.0 + tmpvar_13.x) / 7.0);
  tmpvar_15.z = ((tmpvar_13.x / tmpvar_14.z) + 2.0);
  u_10 = (tmpvar_15 * _ShadowMapTexture_TexelSize.x);
  vec3 tmpvar_16;
  tmpvar_16.y = 7.0;
  tmpvar_16.x = (4.0 - (3.0 * tmpvar_13.y));
  tmpvar_16.z = (1.0 + (3.0 * tmpvar_13.y));
  vec3 tmpvar_17;
  tmpvar_17.x = (((3.0 - 
    (2.0 * tmpvar_13.y)
  ) / tmpvar_16.x) - 2.0);
  tmpvar_17.y = ((3.0 + tmpvar_13.y) / 7.0);
  tmpvar_17.z = ((tmpvar_13.y / tmpvar_16.z) + 2.0);
  v_9 = (tmpvar_17 * _ShadowMapTexture_TexelSize.y);
  vec3 tmpvar_18;
  tmpvar_18 = (tmpvar_14 * tmpvar_16.x);
  vec2 tmpvar_19;
  tmpvar_19.x = u_10.x;
  tmpvar_19.y = v_9.x;
  float depth_20;
  depth_20 = tmpvar_5.z;
  vec3 uv_21;
  vec3 tmpvar_22;
  tmpvar_22.xy = (tmpvar_12 + tmpvar_19);
  tmpvar_22.z = depth_20;
  uv_21.xy = tmpvar_22.xy;
  uv_21.z = depth_20;
  sum_7 = (tmpvar_18.x * shadow2D (_ShadowMapTexture, uv_21).x);
  vec2 tmpvar_23;
  tmpvar_23.x = u_10.y;
  tmpvar_23.y = v_9.x;
  float depth_24;
  depth_24 = tmpvar_5.z;
  vec3 uv_25;
  vec3 tmpvar_26;
  tmpvar_26.xy = (tmpvar_12 + tmpvar_23);
  tmpvar_26.z = depth_24;
  uv_25.xy = tmpvar_26.xy;
  uv_25.z = depth_24;
  sum_7 = (sum_7 + (tmpvar_18.y * shadow2D (_ShadowMapTexture, uv_25).x));
  vec2 tmpvar_27;
  tmpvar_27.x = u_10.z;
  tmpvar_27.y = v_9.x;
  float depth_28;
  depth_28 = tmpvar_5.z;
  vec3 uv_29;
  vec3 tmpvar_30;
  tmpvar_30.xy = (tmpvar_12 + tmpvar_27);
  tmpvar_30.z = depth_28;
  uv_29.xy = tmpvar_30.xy;
  uv_29.z = depth_28;
  sum_7 = (sum_7 + (tmpvar_18.z * shadow2D (_ShadowMapTexture, uv_29).x));
  accum_6 = (tmpvar_14 * 7.0);
  vec2 tmpvar_31;
  tmpvar_31.x = u_10.x;
  tmpvar_31.y = v_9.y;
  float depth_32;
  depth_32 = tmpvar_5.z;
  vec3 uv_33;
  vec3 tmpvar_34;
  tmpvar_34.xy = (tmpvar_12 + tmpvar_31);
  tmpvar_34.z = depth_32;
  uv_33.xy = tmpvar_34.xy;
  uv_33.z = depth_32;
  sum_7 = (sum_7 + (accum_6.x * shadow2D (_ShadowMapTexture, uv_33).x));
  vec2 tmpvar_35;
  tmpvar_35.x = u_10.y;
  tmpvar_35.y = v_9.y;
  float depth_36;
  depth_36 = tmpvar_5.z;
  vec3 uv_37;
  vec3 tmpvar_38;
  tmpvar_38.xy = (tmpvar_12 + tmpvar_35);
  tmpvar_38.z = depth_36;
  uv_37.xy = tmpvar_38.xy;
  uv_37.z = depth_36;
  sum_7 = (sum_7 + (accum_6.y * shadow2D (_ShadowMapTexture, uv_37).x));
  vec2 tmpvar_39;
  tmpvar_39.x = u_10.z;
  tmpvar_39.y = v_9.y;
  float depth_40;
  depth_40 = tmpvar_5.z;
  vec3 uv_41;
  vec3 tmpvar_42;
  tmpvar_42.xy = (tmpvar_12 + tmpvar_39);
  tmpvar_42.z = depth_40;
  uv_41.xy = tmpvar_42.xy;
  uv_41.z = depth_40;
  sum_7 = (sum_7 + (accum_6.z * shadow2D (_ShadowMapTexture, uv_41).x));
  accum_6 = (tmpvar_14 * tmpvar_16.z);
  vec2 tmpvar_43;
  tmpvar_43.x = u_10.x;
  tmpvar_43.y = v_9.z;
  float depth_44;
  depth_44 = tmpvar_5.z;
  vec3 uv_45;
  vec3 tmpvar_46;
  tmpvar_46.xy = (tmpvar_12 + tmpvar_43);
  tmpvar_46.z = depth_44;
  uv_45.xy = tmpvar_46.xy;
  uv_45.z = depth_44;
  sum_7 = (sum_7 + (accum_6.x * shadow2D (_ShadowMapTexture, uv_45).x));
  vec2 tmpvar_47;
  tmpvar_47.x = u_10.y;
  tmpvar_47.y = v_9.z;
  float depth_48;
  depth_48 = tmpvar_5.z;
  vec3 uv_49;
  vec3 tmpvar_50;
  tmpvar_50.xy = (tmpvar_12 + tmpvar_47);
  tmpvar_50.z = depth_48;
  uv_49.xy = tmpvar_50.xy;
  uv_49.z = depth_48;
  sum_7 = (sum_7 + (accum_6.y * shadow2D (_ShadowMapTexture, uv_49).x));
  vec2 tmpvar_51;
  tmpvar_51.x = u_10.z;
  tmpvar_51.y = v_9.z;
  float depth_52;
  depth_52 = tmpvar_5.z;
  vec3 uv_53;
  vec3 tmpvar_54;
  tmpvar_54.xy = (tmpvar_12 + tmpvar_51);
  tmpvar_54.z = depth_52;
  uv_53.xy = tmpvar_54.xy;
  uv_53.z = depth_52;
  sum_7 = (sum_7 + (accum_6.z * shadow2D (_ShadowMapTexture, uv_53).x));
  shadow_8 = (sum_7 / 144.0);
  float tmpvar_55;
  tmpvar_55 = mix (_LightShadowData.x, 1.0, shadow_8);
  shadow_8 = tmpvar_55;
  vec3 tmpvar_56;
  tmpvar_56 = (tmpvar_4.xyz - unity_ShadowFadeCenterAndType.xyz);
  gl_FragData[0] = vec4((tmpvar_55 + clamp ((
    (sqrt(dot (tmpvar_56, tmpvar_56)) * _LightShadowData.z)
   + _LightShadowData.w), 0.0, 1.0)));
}


#endif
"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
Matrix 0 [glstate_matrix_mvp]
Matrix 4 [unity_CameraInvProjection] 3
Vector 7 [_ProjectionParams]
"vs_3_0
def c8, -1, 1, 0, 0
dcl_position v0
dcl_texcoord v1
dcl_normal v2
dcl_texcoord o0.xy
dcl_texcoord1 o1.xyz
dcl_texcoord2 o2
dcl_position o3
dp4 o3.z, c2, v0
dp4 o3.w, c3, v0
dp4 r0.x, c1, v0
mul r1.y, r0.x, c7.x
mov o3.y, r0.x
mov r1.zw, c8.xyxy
dp4 r1.x, c0, v0
dp4 o2.x, c4, r1
dp4 o2.y, c5, r1
dp4 r0.x, c6, r1
dp4 r0.y, c6, r1.xyww
mov o3.x, r1.x
mov o2.zw, -r0.xyxy
mov o0.xy, v1
mov o1.xyz, v2

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Bind "vertex" Vertex
Bind "normal" Normal
Bind "texcoord" TexCoord0
ConstBuffer "UnityPerCamera" 144
Vector 80 [_ProjectionParams]
ConstBuffer "UnityPerCameraRare" 224
Matrix 160 [unity_CameraInvProjection]
ConstBuffer "UnityPerDraw" 352
Matrix 0 [glstate_matrix_mvp]
BindCB  "UnityPerCamera" 0
BindCB  "UnityPerCameraRare" 1
BindCB  "UnityPerDraw" 2
"vs_4_0
root12:aaadaaaa
eefiecedolkgnmnedeonlnjlkmdbfamgojnlnoklabaaaaaakmadaaaaadaaaaaa
cmaaaaaakaaaaaaaciabaaaaejfdeheogmaaaaaaadaaaaaaaiaaaaaafaaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapapaaaafjaaaaaaaaaaaaaaaaaaaaaa
adaaaaaaabaaaaaaadadaaaagcaaaaaaaaaaaaaaaaaaaaaaadaaaaaaacaaaaaa
ahahaaaafaepfdejfeejepeoaafeeffiedepepfceeaaeoepfcenebemaaklklkl
epfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaaaaaaaaaaaaaaaaaaadaaaaaa
aaaaaaaaadamaaaagiaaaaaaabaaaaaaaaaaaaaaadaaaaaaabaaaaaaahaiaaaa
giaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaaapaaaaaahbaaaaaaaaaaaaaa
abaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffiedepepfceeaafdfgfpfaepfdej
feejepeoaaklklklfdeieefchmacaaaaeaaaabaajpaaaaaafjaaaaaeegiocaaa
aaaaaaaaagaaaaaafjaaaaaeegiocaaaabaaaaaaaoaaaaaafjaaaaaeegiocaaa
acaaaaaaaeaaaaaafpaaaaadpcbabaaaaaaaaaaafpaaaaaddcbabaaaabaaaaaa
fpaaaaadhcbabaaaacaaaaaagfaaaaaddccabaaaaaaaaaaagfaaaaadhccabaaa
abaaaaaagfaaaaadpccabaaaacaaaaaaghaaaaaepccabaaaadaaaaaaabaaaaaa
giaaaaacacaaaaaadgaaaaafdccabaaaaaaaaaaaegbabaaaabaaaaaadgaaaaaf
hccabaaaabaaaaaaegbcbaaaacaaaaaadiaaaaaipcaabaaaaaaaaaaafgbfbaaa
aaaaaaaaegiocaaaacaaaaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaaegiocaaa
acaaaaaaaaaaaaaaagbabaaaaaaaaaaaegaobaaaaaaaaaaadcaaaaakpcaabaaa
aaaaaaaaegiocaaaacaaaaaaacaaaaaakgbkbaaaaaaaaaaaegaobaaaaaaaaaaa
dcaaaaakpcaabaaaaaaaaaaaegiocaaaacaaaaaaadaaaaaapgbpbaaaaaaaaaaa
egaobaaaaaaaaaaadiaaaaaibcaabaaaabaaaaaabkaabaaaaaaaaaaaakiacaaa
aaaaaaaaafaaaaaadiaaaaaihcaabaaaabaaaaaaagaabaaaabaaaaaaegiccaaa
abaaaaaaalaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaabaaaaaaakaaaaaa
agaabaaaaaaaaaaaegacbaaaabaaaaaadgaaaaafpccabaaaadaaaaaaegaobaaa
aaaaaaaaaaaaaaaibcaabaaaaaaaaaaackaabaaaabaaaaaackiacaaaabaaaaaa
amaaaaaaaaaaaaajocaabaaaaaaaaaaaagajbaaaabaaaaaaagijcaiaebaaaaaa
abaaaaaaamaaaaaaaaaaaaaipcaabaaaaaaaaaaaegaobaaaaaaaaaaacgijcaaa
abaaaaaaanaaaaaadiaaaaakhccabaaaacaaaaaajgahbaaaaaaaaaaaaceaaaaa
aaaaiadpaaaaiadpaaaaialpaaaaaaaadgaaaaagiccabaaaacaaaaaaakaabaia
ebaaaaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES
#version 100

#ifdef VERTEX
#extension GL_EXT_shadow_samplers : enable
attribute vec4 _glesVertex;
attribute vec3 _glesNormal;
attribute vec4 _glesMultiTexCoord0;
uniform highp vec4 _ProjectionParams;
uniform highp mat4 unity_CameraInvProjection;
uniform highp mat4 glstate_matrix_mvp;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  highp vec4 clipPos_1;
  highp vec4 tmpvar_2;
  tmpvar_2 = (glstate_matrix_mvp * _glesVertex);
  clipPos_1.xzw = tmpvar_2.xzw;
  clipPos_1.y = (tmpvar_2.y * _ProjectionParams.x);
  highp vec4 tmpvar_3;
  tmpvar_3.zw = vec2(-1.0, 1.0);
  tmpvar_3.xy = clipPos_1.xy;
  highp vec4 tmpvar_4;
  tmpvar_4 = (unity_CameraInvProjection * tmpvar_3);
  highp vec4 tmpvar_5;
  tmpvar_5.zw = vec2(1.0, 1.0);
  tmpvar_5.xy = clipPos_1.xy;
  highp vec4 tmpvar_6;
  tmpvar_6.xy = tmpvar_4.xy;
  tmpvar_6.z = -(tmpvar_4.z);
  tmpvar_6.w = -((unity_CameraInvProjection * tmpvar_5).z);
  xlv_TEXCOORD0 = _glesMultiTexCoord0.xy;
  xlv_TEXCOORD1 = _glesNormal;
  xlv_TEXCOORD2 = tmpvar_6;
  gl_Position = tmpvar_2;
}


#endif
#ifdef FRAGMENT
#extension GL_EXT_shadow_samplers : enable
uniform highp vec4 _ZBufferParams;
uniform highp vec4 unity_OrthoParams;
uniform highp mat4 unity_World2Shadow[4];
uniform mediump vec4 _LightShadowData;
uniform highp vec4 unity_ShadowFadeCenterAndType;
uniform highp sampler2D _CameraDepthTexture;
uniform highp mat4 _CameraToWorld;
uniform lowp sampler2DShadow _ShadowMapTexture;
uniform highp vec4 _ShadowMapTexture_TexelSize;
varying highp vec2 xlv_TEXCOORD0;
varying highp vec3 xlv_TEXCOORD1;
varying highp vec4 xlv_TEXCOORD2;
void main ()
{
  lowp vec4 tmpvar_1;
  mediump float shadow_2;
  highp vec3 vposOrtho_3;
  highp vec4 tmpvar_4;
  tmpvar_4 = texture2D (_CameraDepthTexture, xlv_TEXCOORD0);
  vposOrtho_3.xy = xlv_TEXCOORD2.xy;
  vposOrtho_3.z = mix (xlv_TEXCOORD2.z, xlv_TEXCOORD2.w, tmpvar_4.x);
  highp vec4 tmpvar_5;
  tmpvar_5.w = 1.0;
  tmpvar_5.xyz = mix ((xlv_TEXCOORD1 * mix (
    (1.0/(((_ZBufferParams.x * tmpvar_4.x) + _ZBufferParams.y)))
  , tmpvar_4.x, unity_OrthoParams.w)), vposOrtho_3, unity_OrthoParams.www);
  highp vec4 tmpvar_6;
  tmpvar_6 = (_CameraToWorld * tmpvar_5);
  highp vec4 tmpvar_7;
  tmpvar_7.w = 0.0;
  tmpvar_7.xyz = (unity_World2Shadow[0] * tmpvar_6).xyz;
  mediump vec3 accum_8;
  mediump float sum_9;
  mediump float shadow_10;
  highp vec3 v_11;
  highp vec3 u_12;
  highp vec2 tmpvar_13;
  tmpvar_13 = ((tmpvar_7.xy * _ShadowMapTexture_TexelSize.zw) + vec2(0.5, 0.5));
  highp vec2 tmpvar_14;
  tmpvar_14 = ((floor(tmpvar_13) - vec2(0.5, 0.5)) * _ShadowMapTexture_TexelSize.xy);
  highp vec2 tmpvar_15;
  tmpvar_15 = fract(tmpvar_13);
  highp vec3 tmpvar_16;
  tmpvar_16.y = 7.0;
  tmpvar_16.x = (4.0 - (3.0 * tmpvar_15.x));
  tmpvar_16.z = (1.0 + (3.0 * tmpvar_15.x));
  highp vec3 tmpvar_17;
  tmpvar_17.x = (((3.0 - 
    (2.0 * tmpvar_15.x)
  ) / tmpvar_16.x) - 2.0);
  tmpvar_17.y = ((3.0 + tmpvar_15.x) / 7.0);
  tmpvar_17.z = ((tmpvar_15.x / tmpvar_16.z) + 2.0);
  u_12 = (tmpvar_17 * _ShadowMapTexture_TexelSize.x);
  highp vec3 tmpvar_18;
  tmpvar_18.y = 7.0;
  tmpvar_18.x = (4.0 - (3.0 * tmpvar_15.y));
  tmpvar_18.z = (1.0 + (3.0 * tmpvar_15.y));
  highp vec3 tmpvar_19;
  tmpvar_19.x = (((3.0 - 
    (2.0 * tmpvar_15.y)
  ) / tmpvar_18.x) - 2.0);
  tmpvar_19.y = ((3.0 + tmpvar_15.y) / 7.0);
  tmpvar_19.z = ((tmpvar_15.y / tmpvar_18.z) + 2.0);
  v_11 = (tmpvar_19 * _ShadowMapTexture_TexelSize.y);
  highp vec3 tmpvar_20;
  tmpvar_20 = (tmpvar_16 * tmpvar_18.x);
  accum_8 = tmpvar_20;
  highp vec2 tmpvar_21;
  tmpvar_21.x = u_12.x;
  tmpvar_21.y = v_11.x;
  highp float depth_22;
  depth_22 = tmpvar_7.z;
  highp vec3 uv_23;
  highp vec3 tmpvar_24;
  tmpvar_24.xy = (tmpvar_14 + tmpvar_21);
  tmpvar_24.z = depth_22;
  uv_23.xy = tmpvar_24.xy;
  uv_23.z = depth_22;
  lowp float tmpvar_25;
  tmpvar_25 = shadow2DEXT (_ShadowMapTexture, uv_23);
  sum_9 = (accum_8.x * tmpvar_25);
  highp vec2 tmpvar_26;
  tmpvar_26.x = u_12.y;
  tmpvar_26.y = v_11.x;
  highp float depth_27;
  depth_27 = tmpvar_7.z;
  highp vec3 uv_28;
  highp vec3 tmpvar_29;
  tmpvar_29.xy = (tmpvar_14 + tmpvar_26);
  tmpvar_29.z = depth_27;
  uv_28.xy = tmpvar_29.xy;
  uv_28.z = depth_27;
  lowp float tmpvar_30;
  tmpvar_30 = shadow2DEXT (_ShadowMapTexture, uv_28);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_30));
  highp vec2 tmpvar_31;
  tmpvar_31.x = u_12.z;
  tmpvar_31.y = v_11.x;
  highp float depth_32;
  depth_32 = tmpvar_7.z;
  highp vec3 uv_33;
  highp vec3 tmpvar_34;
  tmpvar_34.xy = (tmpvar_14 + tmpvar_31);
  tmpvar_34.z = depth_32;
  uv_33.xy = tmpvar_34.xy;
  uv_33.z = depth_32;
  lowp float tmpvar_35;
  tmpvar_35 = shadow2DEXT (_ShadowMapTexture, uv_33);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_35));
  accum_8 = (tmpvar_16 * 7.0);
  highp vec2 tmpvar_36;
  tmpvar_36.x = u_12.x;
  tmpvar_36.y = v_11.y;
  highp float depth_37;
  depth_37 = tmpvar_7.z;
  highp vec3 uv_38;
  highp vec3 tmpvar_39;
  tmpvar_39.xy = (tmpvar_14 + tmpvar_36);
  tmpvar_39.z = depth_37;
  uv_38.xy = tmpvar_39.xy;
  uv_38.z = depth_37;
  lowp float tmpvar_40;
  tmpvar_40 = shadow2DEXT (_ShadowMapTexture, uv_38);
  sum_9 = (sum_9 + (accum_8.x * tmpvar_40));
  highp vec2 tmpvar_41;
  tmpvar_41.x = u_12.y;
  tmpvar_41.y = v_11.y;
  highp float depth_42;
  depth_42 = tmpvar_7.z;
  highp vec3 uv_43;
  highp vec3 tmpvar_44;
  tmpvar_44.xy = (tmpvar_14 + tmpvar_41);
  tmpvar_44.z = depth_42;
  uv_43.xy = tmpvar_44.xy;
  uv_43.z = depth_42;
  lowp float tmpvar_45;
  tmpvar_45 = shadow2DEXT (_ShadowMapTexture, uv_43);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_45));
  highp vec2 tmpvar_46;
  tmpvar_46.x = u_12.z;
  tmpvar_46.y = v_11.y;
  highp float depth_47;
  depth_47 = tmpvar_7.z;
  highp vec3 uv_48;
  highp vec3 tmpvar_49;
  tmpvar_49.xy = (tmpvar_14 + tmpvar_46);
  tmpvar_49.z = depth_47;
  uv_48.xy = tmpvar_49.xy;
  uv_48.z = depth_47;
  lowp float tmpvar_50;
  tmpvar_50 = shadow2DEXT (_ShadowMapTexture, uv_48);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_50));
  accum_8 = (tmpvar_16 * tmpvar_18.z);
  highp vec2 tmpvar_51;
  tmpvar_51.x = u_12.x;
  tmpvar_51.y = v_11.z;
  highp float depth_52;
  depth_52 = tmpvar_7.z;
  highp vec3 uv_53;
  highp vec3 tmpvar_54;
  tmpvar_54.xy = (tmpvar_14 + tmpvar_51);
  tmpvar_54.z = depth_52;
  uv_53.xy = tmpvar_54.xy;
  uv_53.z = depth_52;
  lowp float tmpvar_55;
  tmpvar_55 = shadow2DEXT (_ShadowMapTexture, uv_53);
  sum_9 = (sum_9 + (accum_8.x * tmpvar_55));
  highp vec2 tmpvar_56;
  tmpvar_56.x = u_12.y;
  tmpvar_56.y = v_11.z;
  highp float depth_57;
  depth_57 = tmpvar_7.z;
  highp vec3 uv_58;
  highp vec3 tmpvar_59;
  tmpvar_59.xy = (tmpvar_14 + tmpvar_56);
  tmpvar_59.z = depth_57;
  uv_58.xy = tmpvar_59.xy;
  uv_58.z = depth_57;
  lowp float tmpvar_60;
  tmpvar_60 = shadow2DEXT (_ShadowMapTexture, uv_58);
  sum_9 = (sum_9 + (accum_8.y * tmpvar_60));
  highp vec2 tmpvar_61;
  tmpvar_61.x = u_12.z;
  tmpvar_61.y = v_11.z;
  highp float depth_62;
  depth_62 = tmpvar_7.z;
  highp vec3 uv_63;
  highp vec3 tmpvar_64;
  tmpvar_64.xy = (tmpvar_14 + tmpvar_61);
  tmpvar_64.z = depth_62;
  uv_63.xy = tmpvar_64.xy;
  uv_63.z = depth_62;
  lowp float tmpvar_65;
  tmpvar_65 = shadow2DEXT (_ShadowMapTexture, uv_63);
  sum_9 = (sum_9 + (accum_8.z * tmpvar_65));
  shadow_10 = (sum_9 / 144.0);
  mediump float tmpvar_66;
  tmpvar_66 = mix (_LightShadowData.x, 1.0, shadow_10);
  shadow_10 = tmpvar_66;
  highp float tmpvar_67;
  highp vec3 tmpvar_68;
  tmpvar_68 = (tmpvar_6.xyz - unity_ShadowFadeCenterAndType.xyz);
  mediump float tmpvar_69;
  highp float tmpvar_70;
  tmpvar_70 = clamp (((
    sqrt(dot (tmpvar_68, tmpvar_68))
   * _LightShadowData.z) + _LightShadowData.w), 0.0, 1.0);
  tmpvar_69 = tmpvar_70;
  tmpvar_67 = tmpvar_69;
  shadow_2 = (tmpvar_66 + tmpvar_67);
  mediump vec4 tmpvar_71;
  tmpvar_71 = vec4(shadow_2);
  tmpvar_1 = tmpvar_71;
  gl_FragData[0] = tmpvar_1;
}


#endif
"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in highp vec4 in_POSITION0;
in highp vec2 in_TEXCOORD0;
in highp vec3 in_NORMAL0;
out highp vec2 vs_TEXCOORD0;
out highp vec3 vs_TEXCOORD1;
out highp vec4 vs_TEXCOORD2;
highp vec4 t0;
highp vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = vec3(t0.y * float(1.0), t0.z * float(1.0), t0.w * float(-1.0));
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform highp sampler2D _CameraDepthTexture;
uniform lowp sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform lowp sampler2D _ShadowMapTexture;
in highp vec2 vs_TEXCOORD0;
in highp vec3 vs_TEXCOORD1;
in highp vec4 vs_TEXCOORD2;
layout(location = 0) out lowp vec4 SV_Target0;
highp vec4 t0;
highp vec4 t1;
lowp float t10_1;
highp vec4 t2;
highp vec4 t3;
highp vec4 t4;
highp vec4 t5;
highp vec3 t6;
highp vec3 t7;
highp vec2 t8;
lowp float t10_8;
highp vec3 t9;
lowp float t10_9;
highp float t16;
mediump float t16_16;
lowp float t10_16;
highp vec2 t19;
highp float t24;
lowp float t10_24;
void main()
{
    t0.x = texture(_CameraDepthTexture, vs_TEXCOORD0.xy).x;
    t8.x = _ZBufferParams.x * t0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t1.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[0][3].xyz * t0.www + t1.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2.xz = _ShadowMapTexture_TexelSize.yy;
    t2.y = 0.142857149;
    t8.xy = t1.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t1.xy = fract(t8.xy);
    t8.xy = floor(t8.xy);
    t8.xy = t8.xy + vec2(-0.5, -0.5);
    t3.xy = (-t1.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t19.xy = (-t1.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t3.xy = t3.xy / t19.xy;
    t4.xy = t3.xy + vec2(-2.0, -2.0);
    t5.z = t4.y;
    t3.xy = t1.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t3.xz = t1.xy / t3.xy;
    t5.xw = t3.xz + vec2(2.0, 2.0);
    t4.w = t5.x;
    t9.xz = t1.xy + vec2(3.0, 3.0);
    t24 = t1.x * 3.0;
    t6.xz = vec2(t24) * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t5.xy = t9.xz * _ShadowMapTexture_TexelSize.xy;
    t2.xyz = vec3(t2.x * t5.z, t2.y * t5.y, t2.z * t5.w);
    t4.z = t5.x;
    t5.w = t2.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t5.xyz = t4.zxw * t7.yxz;
    t4 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.ywxw;
    t1.xy = t8.xy * _ShadowMapTexture_TexelSize.xy + t5.zw;
    vec3 txVec1 = vec3(t1.xy,t1.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec1, 0.0);
    vec3 txVec2 = vec3(t4.xy,t1.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec2, 0.0);
    vec3 txVec3 = vec3(t4.zw,t1.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec3, 0.0);
    t6.y = 7.0;
    t3.xzw = t19.yyy * t6.xyz;
    t4.xyz = t3.yyy * t6.xyz;
    t6.xy = t6.xz * vec2(7.0, 7.0);
    t9.x = t10_9 * t3.z;
    t1.x = t3.x * t10_1 + t9.x;
    t24 = t3.w * t10_24 + t1.x;
    t2.w = t5.y;
    t3 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t2.wywz;
    t5.yw = t2.yz;
    vec3 txVec4 = vec3(t3.xy,t1.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec4, 0.0);
    vec3 txVec5 = vec3(t3.zw,t1.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec5, 0.0);
    t24 = t6.x * t10_1 + t24;
    t2 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xyzy;
    t3 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xwzw;
    vec3 txVec6 = vec3(t2.xy,t1.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec6, 0.0);
    vec3 txVec7 = vec3(t2.zw,t1.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec7, 0.0);
    t8.x = t10_8 * 49.0 + t24;
    t8.x = t6.y * t10_16 + t8.x;
    t8.x = t4.x * t10_9 + t8.x;
    vec3 txVec8 = vec3(t3.xy,t1.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec8, 0.0);
    vec3 txVec9 = vec3(t3.zw,t1.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec9, 0.0);
    t8.x = t4.y * t10_16 + t8.x;
    t8.x = t4.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16_16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16_16 + _LightShadowData.x;
    t0 = t0.xxxx + t8.xxxx;
    SV_Target0 = t0;
    return;
}

#endif
"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
in  vec4 in_POSITION0;
in  vec2 in_TEXCOORD0;
in  vec3 in_NORMAL0;
out vec2 vs_TEXCOORD0;
out vec3 vs_TEXCOORD1;
out vec4 vs_TEXCOORD2;
vec4 t0;
vec3 t1;
void main()
{
    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
    vs_TEXCOORD1.xyz = in_NORMAL0.xyz;
    t0 = in_POSITION0.yyyy * glstate_matrix_mvp[1];
    t0 = glstate_matrix_mvp[0] * in_POSITION0.xxxx + t0;
    t0 = glstate_matrix_mvp[2] * in_POSITION0.zzzz + t0;
    t0 = glstate_matrix_mvp[3] * in_POSITION0.wwww + t0;
    t1.x = t0.y * _ProjectionParams.x;
    t1.xyz = t1.xxx * unity_CameraInvProjection[1].xyz;
    t1.xyz = unity_CameraInvProjection[0].xyz * t0.xxx + t1.xyz;
    gl_Position = t0;
    t0.x = t1.z + unity_CameraInvProjection[2].z;
    t0.yzw = t1.xyz + (-unity_CameraInvProjection[2].xyz);
    t0 = t0 + unity_CameraInvProjection[3].zxyz;
    vs_TEXCOORD2.xyz = t0.yzw * vec3(1.0, 1.0, -1.0);
    vs_TEXCOORD2.w = (-t0.x);
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
uniform 	vec4 unity_ShadowCascadeScales;
uniform 	mat4 _CameraToWorld;
uniform 	vec4 _ShadowMapTexture_TexelSize;
uniform  sampler2D _CameraDepthTexture;
uniform  sampler2DShadow hlslcc_zcmp_ShadowMapTexture;
uniform  sampler2D _ShadowMapTexture;
in  vec2 vs_TEXCOORD0;
in  vec3 vs_TEXCOORD1;
in  vec4 vs_TEXCOORD2;
out vec4 SV_Target0;
vec4 t0;
lowp vec4 t10_0;
vec4 t1;
lowp float t10_1;
vec4 t2;
vec4 t3;
vec4 t4;
vec4 t5;
vec3 t6;
vec3 t7;
vec2 t8;
lowp float t10_8;
vec3 t9;
lowp float t10_9;
float t16;
lowp float t10_16;
vec2 t19;
float t24;
lowp float t10_24;
void main()
{
    t10_0 = texture(_CameraDepthTexture, vs_TEXCOORD0.xy);
    t8.x = _ZBufferParams.x * t10_0.x + _ZBufferParams.y;
    t8.x = float(1.0) / t8.x;
    t16 = (-t8.x) + t10_0.x;
    t8.x = unity_OrthoParams.w * t16 + t8.x;
    t1.xy = vs_TEXCOORD2.xy;
    t16 = (-vs_TEXCOORD2.z) + vs_TEXCOORD2.w;
    t1.z = t10_0.x * t16 + vs_TEXCOORD2.z;
    t0.xzw = (-vs_TEXCOORD1.xyz) * t8.xxx + t1.xyz;
    t1.xyz = t8.xxx * vs_TEXCOORD1.xyz;
    t0.xyz = unity_OrthoParams.www * t0.xzw + t1.xyz;
    t1 = t0.yyyy * _CameraToWorld[1];
    t1 = _CameraToWorld[0] * t0.xxxx + t1;
    t0 = _CameraToWorld[2] * t0.zzzz + t1;
    t0 = t0 + _CameraToWorld[3];
    t1.xyz = t0.yyy * unity_World2Shadow[0][1].xyz;
    t1.xyz = unity_World2Shadow[0][0].xyz * t0.xxx + t1.xyz;
    t1.xyz = unity_World2Shadow[0][2].xyz * t0.zzz + t1.xyz;
    t1.xyz = unity_World2Shadow[0][3].xyz * t0.www + t1.xyz;
    t0.xyz = t0.xyz + (-unity_ShadowFadeCenterAndType.xyz);
    t0.x = dot(t0.xyz, t0.xyz);
    t0.x = sqrt(t0.x);
    t0.x = t0.x * _LightShadowData.z + _LightShadowData.w;
    t0.x = clamp(t0.x, 0.0, 1.0);
    t2.xz = _ShadowMapTexture_TexelSize.yy;
    t2.y = 0.142857149;
    t8.xy = t1.xy * _ShadowMapTexture_TexelSize.zw + vec2(0.5, 0.5);
    t1.xy = fract(t8.xy);
    t8.xy = floor(t8.xy);
    t8.xy = t8.xy + vec2(-0.5, -0.5);
    t3.xy = (-t1.xy) * vec2(2.0, 2.0) + vec2(3.0, 3.0);
    t19.xy = (-t1.xy) * vec2(3.0, 3.0) + vec2(4.0, 4.0);
    t3.xy = t3.xy / t19.xy;
    t4.xy = t3.xy + vec2(-2.0, -2.0);
    t5.z = t4.y;
    t3.xy = t1.xy * vec2(3.0, 3.0) + vec2(1.0, 1.0);
    t3.xz = t1.xy / t3.xy;
    t5.xw = t3.xz + vec2(2.0, 2.0);
    t4.w = t5.x;
    t9.xz = t1.xy + vec2(3.0, 3.0);
    t24 = t1.x * 3.0;
    t6.xz = vec2(t24) * vec2(-1.0, 1.0) + vec2(4.0, 1.0);
    t5.xy = t9.xz * _ShadowMapTexture_TexelSize.xy;
    t2.xyz = t2.xyz * t5.zyw;
    t4.z = t5.x;
    t5.w = t2.x;
    t7.xz = _ShadowMapTexture_TexelSize.xx;
    t7.y = 0.142857149;
    t5.xyz = t4.zxw * t7.yxz;
    t4 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.ywxw;
    t1.xy = t8.xy * _ShadowMapTexture_TexelSize.xy + t5.zw;
    vec3 txVec9 = vec3(t1.xy,t1.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec9, 0.0);
    vec3 txVec10 = vec3(t4.xy,t1.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec10, 0.0);
    vec3 txVec11 = vec3(t4.zw,t1.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec11, 0.0);
    t6.y = 7.0;
    t3.xzw = t19.yyy * t6.xyz;
    t4.xyz = t3.yyy * t6.xyz;
    t6.xy = t6.xz * vec2(7.0, 7.0);
    t9.x = t10_9 * t3.z;
    t1.x = t3.x * t10_1 + t9.x;
    t24 = t3.w * t10_24 + t1.x;
    t2.w = t5.y;
    t3 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t2.wywz;
    t5.yw = t2.yz;
    vec3 txVec12 = vec3(t3.xy,t1.z);
    t10_1 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec12, 0.0);
    vec3 txVec13 = vec3(t3.zw,t1.z);
    t10_9 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec13, 0.0);
    t24 = t6.x * t10_1 + t24;
    t2 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xyzy;
    t3 = t8.xyxy * _ShadowMapTexture_TexelSize.xyxy + t5.xwzw;
    vec3 txVec14 = vec3(t2.xy,t1.z);
    t10_8 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec14, 0.0);
    vec3 txVec15 = vec3(t2.zw,t1.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec15, 0.0);
    t8.x = t10_8 * 49.0 + t24;
    t8.x = t6.y * t10_16 + t8.x;
    t8.x = t4.x * t10_9 + t8.x;
    vec3 txVec16 = vec3(t3.xy,t1.z);
    t10_16 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec16, 0.0);
    vec3 txVec17 = vec3(t3.zw,t1.z);
    t10_24 = textureLod(hlslcc_zcmp_ShadowMapTexture, txVec17, 0.0);
    t8.x = t4.y * t10_16 + t8.x;
    t8.x = t4.z * t10_24 + t8.x;
    t8.x = t8.x * 0.0069444445;
    t16 = (-_LightShadowData.x) + 1.0;
    t8.x = t8.x * t16 + _LightShadowData.x;
    SV_Target0 = t0.xxxx + t8.xxxx;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "gles " {
Keywords { "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" }
Matrix 15 [_CameraToWorld]
Matrix 0 [unity_World2Shadow0]
Matrix 4 [unity_World2Shadow1]
Matrix 8 [unity_World2Shadow2]
Matrix 12 [unity_World2Shadow3] 3
Vector 23 [_LightShadowData]
Vector 22 [_LightSplitsFar]
Vector 21 [_LightSplitsNear]
Vector 24 [_ShadowMapTexture_TexelSize]
Vector 19 [_ZBufferParams]
Vector 20 [unity_OrthoParams]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_3_0
def c25, 1, 0, 0.5, -0.5
def c26, 3, 4, 1, 2
def c27, 1, 0, 0.142857149, -1
def c28, 4, 7, 1, 49
def c29, 0.0069444445, 0, 0, 0
dcl_texcoord v0.xy
dcl_texcoord1 v1.xyz
dcl_texcoord2 v2
dcl_2d s0
dcl_2d s1
mov r0.xy, v2
texld r1, v0, s0
mad r0.w, c19.x, r1.x, c19.y
rcp r0.w, r0.w
lrp r2.x, c20.w, r1.x, r0.w
lrp r0.z, r1.x, v2.w, v2.z
mad r0.xyz, v1, -r2.x, r0
mul r1.xyz, r2.x, v1
mad r0.xyz, c20.w, r0, r1
add r1, r0.z, -c22
cmp r1, r1, c25.y, c25.x
add r2, r0.z, -c21
cmp r1, r2, r1, c25.y
mov r0.w, c25.x
dp4 r2.x, c15, r0
dp4 r2.y, c16, r0
dp4 r2.z, c17, r0
dp4 r2.w, c18, r0
mad_sat r0.x, r0.z, c23.z, c23.w
dp4 r3.x, c4, r2
dp4 r3.y, c5, r2
dp4 r3.z, c6, r2
mul r0.yzw, r1.y, r3.xxyz
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
mad r0.yzw, r3.xxyz, r1.x, r0
dp4 r3.x, c8, r2
dp4 r3.y, c9, r2
dp4 r3.z, c10, r2
mad r0.yzw, r3.xxyz, r1.z, r0
dp4 r1.x, c12, r2
dp4 r1.y, c13, r2
dp4 r1.z, c14, r2
mad r0.yzw, r1.xxyz, r1.w, r0
mad r1.zw, r0.w, c25.xyxy, c25.xyyx
mov r2, c24
mad r0.yz, r0, r2.xzww, c25.z
frc r2.zw, r0.xyyz
add r0.yz, r0, -r2.xzww
add r0.yz, r0, c25.w
mad r3.xy, r2.zwzw, c26.x, c26.z
rcp r0.w, r3.x
mad r4.w, r2.z, r0.w, c26.w
add r3.xz, r2.zyww, c26.x
mul r4.yz, r3.xzxw, c24.xyxw
mad r3.xz, r2.zyww, -c26.w, c26.x
mad r5.xy, r2.zwzw, -c26.x, c26.y
rcp r0.w, r5.x
mad r4.x, r3.x, r0.w, -c26.w
mad r5.xzw, r2.x, c27.xyyx, c27.yyzy
mul r6.xyz, r4.zxww, r5.zxww
rcp r0.w, r3.y
mad r4.z, r2.w, r0.w, c26.w
mul r0.w, r2.z, c26.x
mov r7.xyw, c27
mad r5.xzw, r0.w, r7.wyyx, c28.xyyz
rcp r0.w, r5.y
mul_pp r7.xyz, r5.y, r5.xzww
mad r4.x, r3.z, r0.w, -c26.w
mad r2.xyz, r2.yxyw, c27.xyxw, c27.yzyw
mul r2.xyz, r2, r4
mov r6.w, r2.x
mad r1.xy, r0.yzzw, c24, r6.ywzw
texldp r4, r1, s1
mad r1.xy, r0.yzzw, c24, r6.xwzw
mad r8.xy, r0.yzzw, c24, r6.zwzw
texldp r9, r1, s1
mov r8.zw, r1
mul r0.w, r7.y, r9.x
mad_pp r0.w, r7.x, r4.x, r0.w
texldp r1, r8, s1
mad_pp r0.w, r7.z, r1.x, r0.w
mul_pp r1.xy, r5.xwzw, c28.y
mul_pp r3.xyz, r3.y, r5.xzww
mov r2.w, r6.y
mad r8.xy, r0.yzzw, c24, r2.wyzw
mad r4.xy, r0.yzzw, c24, r2.wzzw
mov r6.yw, r2.xyzz
texldp r2, r8, s1
mad_pp r0.w, r1.x, r2.x, r0.w
mad r8.xy, r0.yzzw, c24, r6
texldp r2, r8, s1
mad_pp r0.w, r2.x, c28.w, r0.w
mad r8.xy, r0.yzzw, c24, r6.zyzw
texldp r2, r8, s1
mov r4.zw, r8
mad_pp r0.w, r1.y, r2.x, r0.w
texldp r1, r4, s1
mad_pp r0.w, r3.x, r1.x, r0.w
mad r4.xy, r0.yzzw, c24, r6.xwzw
mad r1.xy, r0.yzzw, c24, r6.zwzw
texldp r2, r4, s1
mov r1.zw, r4
texldp r1, r1, s1
mad_pp r0.y, r3.y, r2.x, r0.w
mad_pp r0.y, r3.z, r1.x, r0.y
mul_pp r0.y, r0.y, c29.x
mov r1.x, c25.x
lrp_pp r2.x, r0.y, r1.x, c23.x
add_pp oC0, r0.x, r2.x

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "$Globals" 128
Vector 112 [_ShadowMapTexture_TexelSize]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 96 [_LightSplitsNear]
Vector 112 [_LightSplitsFar]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityShadows" 2
BindCB  "UnityPerCamera2" 3
"ps_4_0
root12:acaeacaa
eefiecedekcbfgdjggmocjjfgccgongoekcadpmnabaaaaaahiapaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefciiaoaaaaeaaaaaaakcadaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafjaaaaaeegiocaaaabaaaaaaajaaaaaafjaaaaaeegiocaaa
acaaaaaabjaaaaaafjaaaaaeegiocaaaadaaaaaaaeaaaaaafkaaaaadaagabaaa
aaaaaaaafkaiaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaa
fibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaad
hcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacaiaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaabaaaaaa
ahaaaaaaakaabaaaaaaaaaaabkiacaaaabaaaaaaahaaaaaaaoaaaaakccaabaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaa
aaaaaaaiecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakccaabaaaaaaaaaaadkiacaaaabaaaaaaaiaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaai
ecaabaaaaaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaaj
ecaabaaaabaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaa
dcaaaaakncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaa
agajbaaaabaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaa
abaaaaaadcaaaaakhcaabaaaaaaaaaaapgipcaaaabaaaaaaaiaaaaaaigadbaaa
aaaaaaaaegacbaaaabaaaaaabnaaaaaipcaabaaaabaaaaaakgakbaaaaaaaaaaa
egiocaaaacaaaaaaagaaaaaaabaaaaakpcaabaaaabaaaaaaegaobaaaabaaaaaa
aceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpdbaaaaaipcaabaaaacaaaaaa
kgakbaaaaaaaaaaaegiocaaaacaaaaaaahaaaaaaabaaaaakpcaabaaaacaaaaaa
egaobaaaacaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpdiaaaaah
pcaabaaaabaaaaaaegaobaaaabaaaaaaegaobaaaacaaaaaadiaaaaaipcaabaaa
acaaaaaafgafbaaaaaaaaaaaegiocaaaadaaaaaaabaaaaaadcaaaaakpcaabaaa
acaaaaaaegiocaaaadaaaaaaaaaaaaaaagaabaaaaaaaaaaaegaobaaaacaaaaaa
dcaaaaakpcaabaaaacaaaaaaegiocaaaadaaaaaaacaaaaaakgakbaaaaaaaaaaa
egaobaaaacaaaaaadccaaaalbcaabaaaaaaaaaaackaabaaaaaaaaaaackiacaaa
acaaaaaabiaaaaaadkiacaaaacaaaaaabiaaaaaaaaaaaaaipcaabaaaacaaaaaa
egaobaaaacaaaaaaegiocaaaadaaaaaaadaaaaaadiaaaaaiocaabaaaaaaaaaaa
fgafbaaaacaaaaaaagijcaaaacaaaaaaanaaaaaadcaaaaakocaabaaaaaaaaaaa
agijcaaaacaaaaaaamaaaaaaagaabaaaacaaaaaafgaobaaaaaaaaaaadcaaaaak
ocaabaaaaaaaaaaaagijcaaaacaaaaaaaoaaaaaakgakbaaaacaaaaaafgaobaaa
aaaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaacaaaaaaapaaaaaapgapbaaa
acaaaaaafgaobaaaaaaaaaaadiaaaaahocaabaaaaaaaaaaafgafbaaaabaaaaaa
fgaobaaaaaaaaaaadiaaaaaihcaabaaaadaaaaaafgafbaaaacaaaaaaegiccaaa
acaaaaaaajaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaaaiaaaaaa
agaabaaaacaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaa
acaaaaaaakaaaaaakgakbaaaacaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaa
adaaaaaaegiccaaaacaaaaaaalaaaaaapgapbaaaacaaaaaaegacbaaaadaaaaaa
dcaaaaajocaabaaaaaaaaaaaagajbaaaadaaaaaaagaabaaaabaaaaaafgaobaaa
aaaaaaaadiaaaaaihcaabaaaadaaaaaafgafbaaaacaaaaaaegiccaaaacaaaaaa
bbaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaabaaaaaaaagaabaaa
acaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaa
bcaaaaaakgakbaaaacaaaaaaegacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaa
egiccaaaacaaaaaabdaaaaaapgapbaaaacaaaaaaegacbaaaadaaaaaadcaaaaaj
ocaabaaaaaaaaaaaagajbaaaadaaaaaakgakbaaaabaaaaaafgaobaaaaaaaaaaa
diaaaaaihcaabaaaabaaaaaafgafbaaaacaaaaaaegiccaaaacaaaaaabfaaaaaa
dcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaabeaaaaaaagaabaaaacaaaaaa
egacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaabgaaaaaa
kgakbaaaacaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaa
acaaaaaabhaaaaaapgapbaaaacaaaaaaegacbaaaabaaaaaadcaaaaajocaabaaa
aaaaaaaaagajbaaaabaaaaaapgapbaaaabaaaaaafgaobaaaaaaaaaaadcaaaaan
gcaabaaaaaaaaaaafgagbaaaaaaaaaaakgilcaaaaaaaaaaaahaaaaaaaceaaaaa
aaaaaaaaaaaaaadpaaaaaadpaaaaaaaaebaaaaafdcaabaaaabaaaaaajgafbaaa
aaaaaaaabkaaaaafgcaabaaaaaaaaaaafgagbaaaaaaaaaaaaaaaaaakdcaabaaa
abaaaaaaegaabaaaabaaaaaaaceaaaaaaaaaaalpaaaaaalpaaaaaaaaaaaaaaaa
dcaaaabamcaabaaaabaaaaaafgajbaiaebaaaaaaaaaaaaaaaceaaaaaaaaaaaaa
aaaaaaaaaaaaaaeaaaaaaaeaaceaaaaaaaaaaaaaaaaaaaaaaaaaeaeaaaaaeaea
dcaaaabadcaabaaaacaaaaaajgafbaiaebaaaaaaaaaaaaaaaceaaaaaaaaaeaea
aaaaeaeaaaaaaaaaaaaaaaaaaceaaaaaaaaaiaeaaaaaiaeaaaaaaaaaaaaaaaaa
aoaaaaahmcaabaaaabaaaaaakgaobaaaabaaaaaaagaebaaaacaaaaaaaaaaaaak
dcaabaaaadaaaaaaogakbaaaabaaaaaaaceaaaaaaaaaaamaaaaaaamaaaaaaaaa
aaaaaaaadgaaaaafecaabaaaaeaaaaaabkaabaaaadaaaaaadcaaaaapmcaabaaa
abaaaaaafgajbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaaaaaaaaaeaeaaaaaeaea
aceaaaaaaaaaaaaaaaaaaaaaaaaaiadpaaaaiadpaoaaaaahfcaabaaaacaaaaaa
fgagbaaaaaaaaaaakgalbaaaabaaaaaaaaaaaaakjcaabaaaaeaaaaaaagaibaaa
acaaaaaaaceaaaaaaaaaaaeaaaaaaaaaaaaaaaaaaaaaaaeadgaaaaaficaabaaa
adaaaaaaakaabaaaaeaaaaaaaaaaaaakfcaabaaaacaaaaaafgagbaaaaaaaaaaa
aceaaaaaaaaaeaeaaaaaaaaaaaaaeaeaaaaaaaaadiaaaaahccaabaaaaaaaaaaa
bkaabaaaaaaaaaaaabeaaaaaaaaaeaeadcaaaaapfcaabaaaafaaaaaafgafbaaa
aaaaaaaaaceaaaaaaaaaialpaaaaaaaaaaaaiadpaaaaaaaaaceaaaaaaaaaiaea
aaaaaaaaaaaaiadpaaaaaaaadiaaaaaidcaabaaaaeaaaaaaigaabaaaacaaaaaa
egiacaaaaaaaaaaaahaaaaaadgaaaaagfcaabaaaagaaaaaafgifcaaaaaaaaaaa
ahaaaaaadgaaaaafccaabaaaagaaaaaaabeaaaaacfejbcdodiaaaaahhcaabaaa
agaaaaaaggalbaaaaeaaaaaaegacbaaaagaaaaaadgaaaaafecaabaaaadaaaaaa
akaabaaaaeaaaaaadgaaaaaficaabaaaaeaaaaaaakaabaaaagaaaaaadgaaaaag
fcaabaaaahaaaaaaagiacaaaaaaaaaaaahaaaaaadgaaaaafccaabaaaahaaaaaa
abeaaaaacfejbcdodiaaaaahhcaabaaaaeaaaaaacgalbaaaadaaaaaabgagbaaa
ahaaaaaadcaaaaakpcaabaaaadaaaaaaegaebaaaabaaaaaaegiecaaaaaaaaaaa
ahaaaaaangambaaaaeaaaaaadcaaaaakgcaabaaaaaaaaaaaagabbaaaabaaaaaa
agibcaaaaaaaaaaaahaaaaaakgalbaaaaeaaaaaaehaaaaalccaabaaaaaaaaaaa
jgafbaaaaaaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaa
ehaaaaalecaabaaaaaaaaaaaegaabaaaadaaaaaaaghabaaaabaaaaaaaagabaaa
abaaaaaadkaabaaaaaaaaaaaehaaaaalecaabaaaabaaaaaaogakbaaaadaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadgaaaaafccaabaaa
afaaaaaaabeaaaaaaaaaoaeadiaaaaahhcaabaaaacaaaaaafgafbaaaacaaaaaa
egacbaaaafaaaaaadiaaaaahhcaabaaaadaaaaaapgapbaaaabaaaaaaegacbaaa
afaaaaaadiaaaaakdcaabaaaafaaaaaaigaabaaaafaaaaaaaceaaaaaaaaaoaea
aaaaoaeaaaaaaaaaaaaaaaaadiaaaaahecaabaaaabaaaaaackaabaaaabaaaaaa
bkaabaaaacaaaaaadcaaaaajecaabaaaaaaaaaaaakaabaaaacaaaaaackaabaaa
aaaaaaaackaabaaaabaaaaaadcaaaaajccaabaaaaaaaaaaackaabaaaacaaaaaa
bkaabaaaaaaaaaaackaabaaaaaaaaaaadgaaaaaficaabaaaagaaaaaabkaabaaa
aeaaaaaadcaaaaakpcaabaaaacaaaaaaegaebaaaabaaaaaaegiecaaaaaaaaaaa
ahaaaaaahgalbaaaagaaaaaadgaaaaafkcaabaaaaeaaaaaafgajbaaaagaaaaaa
ehaaaaalecaabaaaaaaaaaaaegaabaaaacaaaaaaaghabaaaabaaaaaaaagabaaa
abaaaaaadkaabaaaaaaaaaaaehaaaaalecaabaaaabaaaaaaogakbaaaacaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadcaaaaajccaabaaa
aaaaaaaaakaabaaaafaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaak
pcaabaaaacaaaaaaegaebaaaabaaaaaaegiecaaaaaaaaaaaahaaaaaaegagbaaa
aeaaaaaadcaaaaakpcaabaaaaeaaaaaaegaebaaaabaaaaaaegiecaaaaaaaaaaa
ahaaaaaamgaobaaaaeaaaaaaehaaaaalecaabaaaaaaaaaaaegaabaaaacaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaalbcaabaaa
abaaaaaaogakbaaaacaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaa
aaaaaaaadcaaaaajccaabaaaaaaaaaaackaabaaaaaaaaaaaabeaaaaaaaaaeeec
bkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaabkaabaaaafaaaaaaakaabaaa
abaaaaaabkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaaakaabaaaadaaaaaa
ckaabaaaabaaaaaabkaabaaaaaaaaaaaehaaaaalecaabaaaaaaaaaaaegaabaaa
aeaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaal
icaabaaaaaaaaaaaogakbaaaaeaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaabkaabaaaadaaaaaackaabaaa
aaaaaaaabkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaackaabaaaadaaaaaa
dkaabaaaaaaaaaaabkaabaaaaaaaaaaadiaaaaahccaabaaaaaaaaaaabkaabaaa
aaaaaaaaabeaaaaadjiooddlaaaaaaajecaabaaaaaaaaaaaakiacaiaebaaaaaa
acaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaabkaabaaa
aaaaaaaackaabaaaaaaaaaaaakiacaaaacaaaaaabiaaaaaaaaaaaaahpccabaaa
aaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
Matrix 19 [_CameraToWorld]
Matrix 0 [unity_World2Shadow0]
Matrix 4 [unity_World2Shadow1]
Matrix 8 [unity_World2Shadow2]
Matrix 12 [unity_World2Shadow3] 3
Vector 26 [_LightShadowData]
Vector 28 [_ShadowMapTexture_TexelSize]
Vector 23 [_ZBufferParams]
Vector 24 [unity_OrthoParams]
Vector 27 [unity_ShadowFadeCenterAndType]
Vector 15 [unity_ShadowSplitSpheres0]
Vector 16 [unity_ShadowSplitSpheres1]
Vector 17 [unity_ShadowSplitSpheres2]
Vector 18 [unity_ShadowSplitSpheres3]
Vector 25 [unity_ShadowSplitSqRadii]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_3_0
def c29, 0.5, -0.5, 3, 4
def c30, 4, 7, 1, 49
def c31, 3, 1, 2, -2
def c32, 1, 0, 0.142857149, 7
def c33, 0.0069444445, 0, 0, 0
def c34, 1, 0, -0, -1
dcl_texcoord v0.xy
dcl_texcoord1 v1.xyz
dcl_texcoord2 v2
dcl_2d s0
dcl_2d s1
mov r0.xy, v2
texld r1, v0, s0
mad r0.w, c23.x, r1.x, c23.y
rcp r0.w, r0.w
lrp r2.x, c24.w, r1.x, r0.w
lrp r0.z, r1.x, v2.w, v2.z
mad r0.xyz, v1, -r2.x, r0
mul r1.xyz, r2.x, v1
mad r0.xyz, c24.w, r0, r1
mov r0.w, c34.x
dp4 r1.x, c19, r0
dp4 r1.y, c20, r0
dp4 r1.z, c21, r0
dp4 r1.w, c22, r0
add r0.xyz, r1, -c15
dp3 r0.x, r0, r0
add r2.xyz, r1, -c16
dp3 r0.y, r2, r2
add r2.xyz, r1, -c17
dp3 r0.z, r2, r2
add r2.xyz, r1, -c18
dp3 r0.w, r2, r2
add r0, r0, -c25
cmp r2.xyz, r0, c34.z, c34.w
cmp r0, r0, c34.y, c34.x
add_pp r0.yzw, r2.xxyz, r0
max_pp r2.xyz, r0.yzww, c34.y
dp4 r3.x, c4, r1
dp4 r3.y, c5, r1
dp4 r3.z, c6, r1
mul r0.yzw, r2.x, r3.xxyz
dp4 r3.x, c0, r1
dp4 r3.y, c1, r1
dp4 r3.z, c2, r1
mad r0.xyz, r3, r0.x, r0.yzww
dp4 r3.x, c8, r1
dp4 r3.y, c9, r1
dp4 r3.z, c10, r1
mad r0.xyz, r3, r2.y, r0
dp4 r3.x, c12, r1
dp4 r3.y, c13, r1
dp4 r3.z, c14, r1
add r1.xyz, r1, -c27
dp3 r0.w, r1, r1
rsq r0.w, r0.w
rcp r0.w, r0.w
mad_sat_pp r0.w, r0.w, c26.z, c26.w
mad r0.xyz, r3, r2.z, r0
mad r1.zw, r0.z, c34.xyxy, c34.xyyx
mov r2, c28
mad r0.xy, r0, r2.zwzw, c29.x
frc r2.zw, r0.xyxy
add r0.xy, r0, -r2.zwzw
add r0.xy, r0, c29.y
mad r3.xy, r2.zwzw, c31.x, c31.y
rcp r0.z, r3.x
mad r4.w, r2.z, r0.z, c31.z
add r3.xz, r2.zyww, c29.z
mul r4.yz, r3.xzxw, c28.xyxw
mad r3.xz, r2.zyww, -c31.z, c31.x
mad r5.xy, r2.zwzw, -c29.z, c29.w
rcp r0.z, r5.x
mad r4.x, r3.x, r0.z, c31.w
mad r5.xzw, r2.x, c32.xyyx, c32.yyzy
mul r6.xyz, r4.zxww, r5.zxww
rcp r0.z, r3.y
mad r4.z, r2.w, r0.z, c31.z
mul r0.z, r2.z, c29.z
mov r7.xyw, c34
mad r5.xzw, r0.z, r7.wyyx, c30.xyyz
rcp r0.z, r5.y
mul_pp r7.yzw, r5.y, r5.xxzw
mad r4.x, r3.z, r0.z, c31.w
mad r2.xyz, r2.yxyw, c32.xyxw, c32.yzyw
mul r2.xyz, r2, r4
mov r6.w, r2.x
mad r1.xy, r0, c28, r6.ywzw
texldp r4, r1, s1
mad r1.xy, r0, c28, r6.xwzw
mad r8.xy, r0, c28, r6.zwzw
texldp r9, r1, s1
mov r8.zw, r1
mul r0.z, r7.z, r9.x
mad_pp r0.z, r7.y, r4.x, r0.z
texldp r1, r8, s1
mad_pp r0.z, r7.w, r1.x, r0.z
mul_pp r1.xy, r5.xwzw, c32.w
mul_pp r3.xyz, r3.y, r5.xzww
mov r2.w, r6.y
mad r8.xy, r0, c28, r2.wyzw
mad r4.xy, r0, c28, r2.wzzw
mov r6.yw, r2.xyzz
texldp r2, r8, s1
mad_pp r0.z, r1.x, r2.x, r0.z
mad r8.xy, r0, c28, r6
texldp r2, r8, s1
mad_pp r0.z, r2.x, c30.w, r0.z
mad r8.xy, r0, c28, r6.zyzw
texldp r2, r8, s1
mov r4.zw, r8
mad_pp r0.z, r1.y, r2.x, r0.z
texldp r1, r4, s1
mad_pp r0.z, r3.x, r1.x, r0.z
mad r4.xy, r0, c28, r6.xwzw
mad r1.xy, r0, c28, r6.zwzw
texldp r2, r4, s1
mov r1.zw, r4
texldp r1, r1, s1
mad_pp r0.x, r3.y, r2.x, r0.z
mad_pp r0.x, r3.z, r1.x, r0.x
mul_pp r0.x, r0.x, c33.x
lrp_pp r1.x, r0.x, r7.x, c26.x
add_pp oC0, r0.w, r1.x

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "$Globals" 128
Vector 112 [_ShadowMapTexture_TexelSize]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 0 [unity_ShadowSplitSpheres0]
Vector 16 [unity_ShadowSplitSpheres1]
Vector 32 [unity_ShadowSplitSpheres2]
Vector 48 [unity_ShadowSplitSpheres3]
Vector 64 [unity_ShadowSplitSqRadii]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityShadows" 2
BindCB  "UnityPerCamera2" 3
"ps_4_0
root12:acaeacaa
eefiecedgfmkcaibfahbhneonfbjgegchgjoeinaabaaaaaaoibaaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcpiapaaaaeaaaaaaapoadaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafjaaaaaeegiocaaaabaaaaaaajaaaaaafjaaaaaeegiocaaa
acaaaaaabkaaaaaafjaaaaaeegiocaaaadaaaaaaaeaaaaaafkaaaaadaagabaaa
aaaaaaaafkaiaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaa
fibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaad
hcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacaiaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaabaaaaaa
ahaaaaaaakaabaaaaaaaaaaabkiacaaaabaaaaaaahaaaaaaaoaaaaakccaabaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaa
aaaaaaaiecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakccaabaaaaaaaaaaadkiacaaaabaaaaaaaiaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaai
ecaabaaaaaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaaj
ecaabaaaabaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaa
dcaaaaakncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaa
agajbaaaabaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaa
abaaaaaadcaaaaakhcaabaaaaaaaaaaapgipcaaaabaaaaaaaiaaaaaaigadbaaa
aaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiocaaaadaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaadaaaaaa
aaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaadaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaaegiocaaaadaaaaaaadaaaaaaaaaaaaaj
hcaabaaaabaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaaaaaaaaa
baaaaaahbcaabaaaabaaaaaaegacbaaaabaaaaaaegacbaaaabaaaaaaaaaaaaaj
hcaabaaaacaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaabaaaaaa
baaaaaahccaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaaaaaaaaaj
hcaabaaaacaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaacaaaaaa
baaaaaahecaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaaaaaaaaaj
hcaabaaaacaaaaaaegacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaaadaaaaaa
baaaaaahicaabaaaabaaaaaaegacbaaaacaaaaaaegacbaaaacaaaaaadbaaaaai
pcaabaaaabaaaaaaegaobaaaabaaaaaaegiocaaaacaaaaaaaeaaaaaadhaaaaap
hcaabaaaacaaaaaaegacbaaaabaaaaaaaceaaaaaaaaaialpaaaaialpaaaaialp
aaaaaaaaaceaaaaaaaaaaaiaaaaaaaiaaaaaaaiaaaaaaaaaabaaaaakpcaabaaa
abaaaaaaegaobaaaabaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadp
aaaaaaahocaabaaaabaaaaaaagajbaaaacaaaaaafgaobaaaabaaaaaadeaaaaak
ocaabaaaabaaaaaafgaobaaaabaaaaaaaceaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
aaaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaa
anaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaacaaaaaaamaaaaaaagaabaaa
aaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaaacaaaaaa
aoaaaaaakgakbaaaaaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaaacaaaaaa
egiccaaaacaaaaaaapaaaaaapgapbaaaaaaaaaaaegacbaaaacaaaaaadiaaaaah
hcaabaaaacaaaaaafgafbaaaabaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaa
adaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaajaaaaaadcaaaaakhcaabaaa
adaaaaaaegiccaaaacaaaaaaaiaaaaaaagaabaaaaaaaaaaaegacbaaaadaaaaaa
dcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaaakaaaaaakgakbaaaaaaaaaaa
egacbaaaadaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaaalaaaaaa
pgapbaaaaaaaaaaaegacbaaaadaaaaaadcaaaaajhcaabaaaacaaaaaaegacbaaa
adaaaaaaagaabaaaabaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaaadaaaaaa
fgafbaaaaaaaaaaaegiccaaaacaaaaaabbaaaaaadcaaaaakhcaabaaaadaaaaaa
egiccaaaacaaaaaabaaaaaaaagaabaaaaaaaaaaaegacbaaaadaaaaaadcaaaaak
hcaabaaaadaaaaaaegiccaaaacaaaaaabcaaaaaakgakbaaaaaaaaaaaegacbaaa
adaaaaaadcaaaaakhcaabaaaadaaaaaaegiccaaaacaaaaaabdaaaaaapgapbaaa
aaaaaaaaegacbaaaadaaaaaadcaaaaajhcaabaaaabaaaaaaegacbaaaadaaaaaa
kgakbaaaabaaaaaaegacbaaaacaaaaaadiaaaaaihcaabaaaacaaaaaafgafbaaa
aaaaaaaaegiccaaaacaaaaaabfaaaaaadcaaaaakhcaabaaaacaaaaaaegiccaaa
acaaaaaabeaaaaaaagaabaaaaaaaaaaaegacbaaaacaaaaaadcaaaaakhcaabaaa
acaaaaaaegiccaaaacaaaaaabgaaaaaakgakbaaaaaaaaaaaegacbaaaacaaaaaa
dcaaaaakhcaabaaaacaaaaaaegiccaaaacaaaaaabhaaaaaapgapbaaaaaaaaaaa
egacbaaaacaaaaaaaaaaaaajhcaabaaaaaaaaaaaegacbaaaaaaaaaaaegiccaia
ebaaaaaaacaaaaaabjaaaaaabaaaaaahbcaabaaaaaaaaaaaegacbaaaaaaaaaaa
egacbaaaaaaaaaaaelaaaaafbcaabaaaaaaaaaaaakaabaaaaaaaaaaadccaaaal
bcaabaaaaaaaaaaaakaabaaaaaaaaaaackiacaaaacaaaaaabiaaaaaadkiacaaa
acaaaaaabiaaaaaadcaaaaajocaabaaaaaaaaaaaagajbaaaacaaaaaapgapbaaa
abaaaaaaagajbaaaabaaaaaadcaaaaangcaabaaaaaaaaaaafgagbaaaaaaaaaaa
kgilcaaaaaaaaaaaahaaaaaaaceaaaaaaaaaaaaaaaaaaadpaaaaaadpaaaaaaaa
ebaaaaafdcaabaaaabaaaaaajgafbaaaaaaaaaaabkaaaaafgcaabaaaaaaaaaaa
fgagbaaaaaaaaaaaaaaaaaakdcaabaaaabaaaaaaegaabaaaabaaaaaaaceaaaaa
aaaaaalpaaaaaalpaaaaaaaaaaaaaaaadcaaaabamcaabaaaabaaaaaafgajbaia
ebaaaaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaaaaaaaaaaaeaaaaaaaeaaceaaaaa
aaaaaaaaaaaaaaaaaaaaeaeaaaaaeaeadcaaaabadcaabaaaacaaaaaajgafbaia
ebaaaaaaaaaaaaaaaceaaaaaaaaaeaeaaaaaeaeaaaaaaaaaaaaaaaaaaceaaaaa
aaaaiaeaaaaaiaeaaaaaaaaaaaaaaaaaaoaaaaahmcaabaaaabaaaaaakgaobaaa
abaaaaaaagaebaaaacaaaaaaaaaaaaakdcaabaaaadaaaaaaogakbaaaabaaaaaa
aceaaaaaaaaaaamaaaaaaamaaaaaaaaaaaaaaaaadgaaaaafecaabaaaaeaaaaaa
bkaabaaaadaaaaaadcaaaaapmcaabaaaabaaaaaafgajbaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaeaeaaaaaeaeaaceaaaaaaaaaaaaaaaaaaaaaaaaaiadp
aaaaiadpaoaaaaahfcaabaaaacaaaaaafgagbaaaaaaaaaaakgalbaaaabaaaaaa
aaaaaaakjcaabaaaaeaaaaaaagaibaaaacaaaaaaaceaaaaaaaaaaaeaaaaaaaaa
aaaaaaaaaaaaaaeadgaaaaaficaabaaaadaaaaaaakaabaaaaeaaaaaaaaaaaaak
fcaabaaaacaaaaaafgagbaaaaaaaaaaaaceaaaaaaaaaeaeaaaaaaaaaaaaaeaea
aaaaaaaadiaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaaabeaaaaaaaaaeaea
dcaaaaapfcaabaaaafaaaaaafgafbaaaaaaaaaaaaceaaaaaaaaaialpaaaaaaaa
aaaaiadpaaaaaaaaaceaaaaaaaaaiaeaaaaaaaaaaaaaiadpaaaaaaaadiaaaaai
dcaabaaaaeaaaaaaigaabaaaacaaaaaaegiacaaaaaaaaaaaahaaaaaadgaaaaag
fcaabaaaagaaaaaafgifcaaaaaaaaaaaahaaaaaadgaaaaafccaabaaaagaaaaaa
abeaaaaacfejbcdodiaaaaahhcaabaaaagaaaaaaggalbaaaaeaaaaaaegacbaaa
agaaaaaadgaaaaafecaabaaaadaaaaaaakaabaaaaeaaaaaadgaaaaaficaabaaa
aeaaaaaaakaabaaaagaaaaaadgaaaaagfcaabaaaahaaaaaaagiacaaaaaaaaaaa
ahaaaaaadgaaaaafccaabaaaahaaaaaaabeaaaaacfejbcdodiaaaaahhcaabaaa
aeaaaaaacgalbaaaadaaaaaabgagbaaaahaaaaaadcaaaaakpcaabaaaadaaaaaa
egaebaaaabaaaaaaegiecaaaaaaaaaaaahaaaaaangambaaaaeaaaaaadcaaaaak
gcaabaaaaaaaaaaaagabbaaaabaaaaaaagibcaaaaaaaaaaaahaaaaaakgalbaaa
aeaaaaaaehaaaaalccaabaaaaaaaaaaajgafbaaaaaaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaalecaabaaaaaaaaaaaegaabaaa
adaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaal
ecaabaaaabaaaaaaogakbaaaadaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaadgaaaaafccaabaaaafaaaaaaabeaaaaaaaaaoaeadiaaaaah
hcaabaaaacaaaaaafgafbaaaacaaaaaaegacbaaaafaaaaaadiaaaaahhcaabaaa
adaaaaaapgapbaaaabaaaaaaegacbaaaafaaaaaadiaaaaakdcaabaaaafaaaaaa
igaabaaaafaaaaaaaceaaaaaaaaaoaeaaaaaoaeaaaaaaaaaaaaaaaaadiaaaaah
ecaabaaaabaaaaaackaabaaaabaaaaaabkaabaaaacaaaaaadcaaaaajecaabaaa
aaaaaaaaakaabaaaacaaaaaackaabaaaaaaaaaaackaabaaaabaaaaaadcaaaaaj
ccaabaaaaaaaaaaackaabaaaacaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaa
dgaaaaaficaabaaaagaaaaaabkaabaaaaeaaaaaadcaaaaakpcaabaaaacaaaaaa
egaebaaaabaaaaaaegiecaaaaaaaaaaaahaaaaaahgalbaaaagaaaaaadgaaaaaf
kcaabaaaaeaaaaaafgajbaaaagaaaaaaehaaaaalecaabaaaaaaaaaaaegaabaaa
acaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaal
ecaabaaaabaaaaaaogakbaaaacaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaaakaabaaaafaaaaaackaabaaa
aaaaaaaabkaabaaaaaaaaaaadcaaaaakpcaabaaaacaaaaaaegaebaaaabaaaaaa
egiecaaaaaaaaaaaahaaaaaaegagbaaaaeaaaaaadcaaaaakpcaabaaaaeaaaaaa
egaebaaaabaaaaaaegiecaaaaaaaaaaaahaaaaaamgaobaaaaeaaaaaaehaaaaal
ecaabaaaaaaaaaaaegaabaaaacaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaaehaaaaalbcaabaaaabaaaaaaogakbaaaacaaaaaaaghabaaa
abaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaa
ckaabaaaaaaaaaaaabeaaaaaaaaaeeecbkaabaaaaaaaaaaadcaaaaajccaabaaa
aaaaaaaabkaabaaaafaaaaaaakaabaaaabaaaaaabkaabaaaaaaaaaaadcaaaaaj
ccaabaaaaaaaaaaaakaabaaaadaaaaaackaabaaaabaaaaaabkaabaaaaaaaaaaa
ehaaaaalecaabaaaaaaaaaaaegaabaaaaeaaaaaaaghabaaaabaaaaaaaagabaaa
abaaaaaadkaabaaaaaaaaaaaehaaaaalicaabaaaaaaaaaaaogakbaaaaeaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadcaaaaajccaabaaa
aaaaaaaabkaabaaaadaaaaaackaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaaj
ccaabaaaaaaaaaaackaabaaaadaaaaaadkaabaaaaaaaaaaabkaabaaaaaaaaaaa
diaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaaabeaaaaadjiooddlaaaaaaaj
ecaabaaaaaaaaaaaakiacaiaebaaaaaaacaaaaaabiaaaaaaabeaaaaaaaaaiadp
dcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaa
acaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaa
aaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Matrix 0 [_CameraToWorld]
Matrix 4 [unity_World2Shadow0] 3
Vector 9 [_LightShadowData]
Vector 10 [_ShadowMapTexture_TexelSize]
Vector 7 [_ZBufferParams]
Vector 8 [unity_OrthoParams]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_3_0
def c11, 1, 0.5, -0.5, 3
def c12, 3, 4, 2, -2
def c13, 1, 0, 0.142857149, -1
def c14, 4, 7, 1, 49
def c15, 0.0069444445, 0, 0, 0
dcl_texcoord v0.xy
dcl_texcoord1 v1.xyz
dcl_texcoord2 v2
dcl_2d s0
dcl_2d s1
mov r0, c10
mad r1.xyz, r0.yxyw, c13.xyxw, c13.yzyw
mov r2.xy, v2
texld r3, v0, s0
mad r0.y, c7.x, r3.x, c7.y
rcp r0.y, r0.y
lrp r1.w, c8.w, r3.x, r0.y
lrp r2.z, r3.x, v2.w, v2.z
mad r2.xyz, v1, -r1.w, r2
mul r3.xyz, r1.w, v1
mad r2.xyz, c8.w, r2, r3
mov r2.w, c11.x
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
dp4 r3.w, c3, r2
mad_sat r0.y, r2.z, c9.z, c9.w
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r3.z, c6, r3
mad r0.zw, r2.xyxy, r0, c11.y
frc r2.xy, r0.zwzw
add r0.zw, r0, -r2.xyxy
add r0.zw, r0, c11.z
mad r2.zw, r2.xyxy, c11.w, c11.x
rcp r1.w, r2.w
mad r4.z, r2.y, r1.w, c12.z
add r5.xy, r2, c11.w
mul r5.yz, r5.xxyw, c10.xxyw
mov r4.y, r5.z
mad r6.xy, r2, -c12.z, c12.x
mad r6.zw, r2.xyxy, -c12.x, c12.y
rcp r1.w, r6.w
mad r4.x, r6.y, r1.w, c12.w
mul r1.xyz, r1, r4
mov r4.w, r1.x
rcp r1.x, r2.z
mad r5.w, r2.x, r1.x, c12.z
mul r1.x, r2.x, c11.w
mov r7.xyw, c13
mad r2.xyz, r1.x, r7.wyxw, c14
rcp r1.x, r6.z
mul_pp r6.yzw, r6.w, r2.xxyz
mad r5.x, r6.x, r1.x, c12.w
mad r7.xyz, r0.x, c13.xyxw, c13.yzyw
mul r4.xyz, r5.yxww, r7.yxzw
mad r3.xy, r0.zwzw, c10, r4.ywzw
mov r3.w, c11.x
texldp r5, r3, s1
mad r3.xy, r0.zwzw, c10, r4.xwzw
mad r7.xy, r0.zwzw, c10, r4.zwzw
texldp r8, r3, s1
mov r7.zw, r3
mul r0.x, r6.z, r8.x
mad_pp r0.x, r6.y, r5.x, r0.x
texldp r3, r7, s1
mad_pp r0.x, r6.w, r3.x, r0.x
mov r1.w, r4.y
mad r7.xy, r0.zwzw, c10, r1.wyzw
mad r3.xy, r0.zwzw, c10, r1.wzzw
mov r4.yw, r1.xyzz
texldp r1, r7, s1
mul_pp r1.yz, r2.xxzw, c14.y
mul_pp r2.xyz, r2.w, r2
mad_pp r0.x, r1.y, r1.x, r0.x
mad r7.xy, r0.zwzw, c10, r4
texldp r5, r7, s1
mad_pp r0.x, r5.x, c14.w, r0.x
mad r7.xy, r0.zwzw, c10, r4.zyzw
texldp r5, r7, s1
mov r3.zw, r7
mad_pp r0.x, r1.z, r5.x, r0.x
texldp r1, r3, s1
mad_pp r0.x, r2.x, r1.x, r0.x
mad r3.xy, r0.zwzw, c10, r4.xwzw
mad r1.xy, r0.zwzw, c10, r4.zwzw
texldp r4, r3, s1
mov r1.zw, r3
texldp r1, r1, s1
mad_pp r0.x, r2.y, r4.x, r0.x
mad_pp r0.x, r2.z, r1.x, r0.x
mul_pp r0.x, r0.x, c15.x
mov r1.x, c11.x
lrp_pp r2.x, r0.x, r1.x, c9.x
add_pp oC0, r0.y, r2.x

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "$Globals" 128
Vector 112 [_ShadowMapTexture_TexelSize]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityShadows" 2
BindCB  "UnityPerCamera2" 3
"ps_4_0
root12:acaeacaa
eefiecedhohginghhcgncgdnjmeoefdbealepkkjabaaaaaahmamaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcimalaaaaeaaaaaaaodacaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafjaaaaaeegiocaaaabaaaaaaajaaaaaafjaaaaaeegiocaaa
acaaaaaabjaaaaaafjaaaaaeegiocaaaadaaaaaaaeaaaaaafkaaaaadaagabaaa
aaaaaaaafkaiaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaa
fibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaad
hcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacahaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaabaaaaaa
ahaaaaaaakaabaaaaaaaaaaabkiacaaaabaaaaaaahaaaaaaaoaaaaakccaabaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaa
aaaaaaaiecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakccaabaaaaaaaaaaadkiacaaaabaaaaaaaiaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaai
ecaabaaaaaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaaj
ecaabaaaabaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaa
dcaaaaakncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaa
agajbaaaabaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaa
abaaaaaadcaaaaakhcaabaaaaaaaaaaapgipcaaaabaaaaaaaiaaaaaaigadbaaa
aaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiocaaaadaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaadaaaaaa
aaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaabaaaaaa
egiocaaaadaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaadccaaaal
bcaabaaaaaaaaaaackaabaaaaaaaaaaackiacaaaacaaaaaabiaaaaaadkiacaaa
acaaaaaabiaaaaaaaaaaaaaipcaabaaaabaaaaaaegaobaaaabaaaaaaegiocaaa
adaaaaaaadaaaaaadiaaaaaiocaabaaaaaaaaaaafgafbaaaabaaaaaaagijcaaa
acaaaaaaajaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaaacaaaaaaaiaaaaaa
agaabaaaabaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaaaaaaaaaaagijcaaa
acaaaaaaakaaaaaakgakbaaaabaaaaaafgaobaaaaaaaaaaadcaaaaakocaabaaa
aaaaaaaaagijcaaaacaaaaaaalaaaaaapgapbaaaabaaaaaafgaobaaaaaaaaaaa
dgaaaaagfcaabaaaabaaaaaafgifcaaaaaaaaaaaahaaaaaadgaaaaafccaabaaa
abaaaaaaabeaaaaacfejbcdodcaaaaangcaabaaaaaaaaaaafgagbaaaaaaaaaaa
kgilcaaaaaaaaaaaahaaaaaaaceaaaaaaaaaaaaaaaaaaadpaaaaaadpaaaaaaaa
bkaaaaafdcaabaaaacaaaaaajgafbaaaaaaaaaaaebaaaaafgcaabaaaaaaaaaaa
fgagbaaaaaaaaaaaaaaaaaakgcaabaaaaaaaaaaafgagbaaaaaaaaaaaaceaaaaa
aaaaaaaaaaaaaalpaaaaaalpaaaaaaaadcaaaabamcaabaaaacaaaaaaagaebaia
ebaaaaaaacaaaaaaaceaaaaaaaaaaaaaaaaaaaaaaaaaaaeaaaaaaaeaaceaaaaa
aaaaaaaaaaaaaaaaaaaaeaeaaaaaeaeadcaaaabadcaabaaaadaaaaaaegaabaia
ebaaaaaaacaaaaaaaceaaaaaaaaaeaeaaaaaeaeaaaaaaaaaaaaaaaaaaceaaaaa
aaaaiaeaaaaaiaeaaaaaaaaaaaaaaaaaaoaaaaahmcaabaaaacaaaaaakgaobaaa
acaaaaaaagaebaaaadaaaaaaaaaaaaakdcaabaaaaeaaaaaaogakbaaaacaaaaaa
aceaaaaaaaaaaamaaaaaaamaaaaaaaaaaaaaaaaadgaaaaafecaabaaaafaaaaaa
bkaabaaaaeaaaaaadcaaaaapmcaabaaaacaaaaaaagaebaaaacaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaeaeaaaaaeaeaaceaaaaaaaaaaaaaaaaaaaaaaaaaiadp
aaaaiadpaoaaaaahfcaabaaaadaaaaaaagabbaaaacaaaaaakgalbaaaacaaaaaa
aaaaaaakjcaabaaaafaaaaaaagaibaaaadaaaaaaaceaaaaaaaaaaaeaaaaaaaaa
aaaaaaaaaaaaaaeadgaaaaaficaabaaaaeaaaaaaakaabaaaafaaaaaaaaaaaaak
gcaabaaaacaaaaaaagabbaaaacaaaaaaaceaaaaaaaaaaaaaaaaaeaeaaaaaeaea
aaaaaaaadiaaaaahicaabaaaabaaaaaaakaabaaaacaaaaaaabeaaaaaaaaaeaea
dcaaaaapfcaabaaaagaaaaaapgapbaaaabaaaaaaaceaaaaaaaaaialpaaaaaaaa
aaaaiadpaaaaaaaaaceaaaaaaaaaiaeaaaaaaaaaaaaaiadpaaaaaaaadiaaaaai
dcaabaaaafaaaaaajgafbaaaacaaaaaaegiacaaaaaaaaaaaahaaaaaadiaaaaah
hcaabaaaabaaaaaaegacbaaaabaaaaaaggalbaaaafaaaaaadgaaaaafecaabaaa
aeaaaaaaakaabaaaafaaaaaadgaaaaaficaabaaaafaaaaaaakaabaaaabaaaaaa
dgaaaaagfcaabaaaacaaaaaaagiacaaaaaaaaaaaahaaaaaadgaaaaafccaabaaa
acaaaaaaabeaaaaacfejbcdodiaaaaahhcaabaaaafaaaaaabgagbaaaacaaaaaa
cgalbaaaaeaaaaaadcaaaaakpcaabaaaaeaaaaaajgajbaaaaaaaaaaaegiecaaa
aaaaaaaaahaaaaaangambaaaafaaaaaadcaaaaakdcaabaaaacaaaaaajgafbaaa
aaaaaaaaegiacaaaaaaaaaaaahaaaaaaogakbaaaafaaaaaaehaaaaalbcaabaaa
abaaaaaaegaabaaaacaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaa
aaaaaaaaehaaaaalbcaabaaaacaaaaaaegaabaaaaeaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaalccaabaaaacaaaaaaogakbaaa
aeaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadgaaaaaf
ccaabaaaagaaaaaaabeaaaaaaaaaoaeadiaaaaahhcaabaaaadaaaaaafgafbaaa
adaaaaaaegacbaaaagaaaaaadiaaaaahhcaabaaaaeaaaaaapgapbaaaacaaaaaa
egacbaaaagaaaaaadiaaaaakmcaabaaaacaaaaaaagaibaaaagaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaoaeaaaaaoaeadiaaaaahccaabaaaacaaaaaabkaabaaa
acaaaaaabkaabaaaadaaaaaadcaaaaajbcaabaaaacaaaaaaakaabaaaadaaaaaa
akaabaaaacaaaaaabkaabaaaacaaaaaadcaaaaajbcaabaaaabaaaaaackaabaaa
adaaaaaaakaabaaaabaaaaaaakaabaaaacaaaaaadgaaaaaficaabaaaabaaaaaa
bkaabaaaafaaaaaadcaaaaakpcaabaaaadaaaaaajgajbaaaaaaaaaaaegiecaaa
aaaaaaaaahaaaaaahgalbaaaabaaaaaadgaaaaafkcaabaaaafaaaaaafgajbaaa
abaaaaaaehaaaaalccaabaaaabaaaaaaegaabaaaadaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaalecaabaaaabaaaaaaogakbaaa
adaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaadcaaaaaj
bcaabaaaabaaaaaackaabaaaacaaaaaabkaabaaaabaaaaaaakaabaaaabaaaaaa
dcaaaaakpcaabaaaadaaaaaajgajbaaaaaaaaaaaegiecaaaaaaaaaaaahaaaaaa
egagbaaaafaaaaaadcaaaaakpcaabaaaafaaaaaajgajbaaaaaaaaaaaegiecaaa
aaaaaaaaahaaaaaamgaobaaaafaaaaaaehaaaaalccaabaaaaaaaaaaaegaabaaa
adaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaaehaaaaal
ecaabaaaaaaaaaaaogakbaaaadaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaa
dkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaabkaabaaaaaaaaaaaabeaaaaa
aaaaeeecakaabaaaabaaaaaadcaaaaajccaabaaaaaaaaaaadkaabaaaacaaaaaa
ckaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaaakaabaaa
aeaaaaaackaabaaaabaaaaaabkaabaaaaaaaaaaaehaaaaalecaabaaaaaaaaaaa
egaabaaaafaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaadkaabaaaaaaaaaaa
ehaaaaalicaabaaaaaaaaaaaogakbaaaafaaaaaaaghabaaaabaaaaaaaagabaaa
abaaaaaadkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaabkaabaaaaeaaaaaa
ckaabaaaaaaaaaaabkaabaaaaaaaaaaadcaaaaajccaabaaaaaaaaaaackaabaaa
aeaaaaaadkaabaaaaaaaaaaabkaabaaaaaaaaaaadiaaaaahccaabaaaaaaaaaaa
bkaabaaaaaaaaaaaabeaaaaadjiooddlaaaaaaajecaabaaaaaaaaaaaakiacaia
ebaaaaaaacaaaaaabiaaaaaaabeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaa
bkaabaaaaaaaaaaackaabaaaaaaaaaaaakiacaaaacaaaaaabiaaaaaaaaaaaaah
pccabaaaaaaaaaaaagaabaaaaaaaaaaafgafbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GL3x"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_SINGLE_CASCADE" "SHADOWS_NONATIVE" }
"!!GLES"
}
SubProgram "opengl " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLSL"
}
SubProgram "d3d9 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
Matrix 0 [_CameraToWorld]
Matrix 4 [unity_World2Shadow0] 3
Vector 9 [_LightShadowData]
Vector 11 [_ShadowMapTexture_TexelSize]
Vector 7 [_ZBufferParams]
Vector 8 [unity_OrthoParams]
Vector 10 [unity_ShadowFadeCenterAndType]
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
"ps_3_0
def c12, 1, 0.5, -0.5, 3
def c13, 3, 4, 2, -2
def c14, 1, 0, 0.142857149, -1
def c15, 4, 7, 1, 49
def c16, 0.0069444445, 0, 0, 0
dcl_texcoord v0.xy
dcl_texcoord1 v1.xyz
dcl_texcoord2 v2
dcl_2d s0
dcl_2d s1
mov r0, c11
mad r1.xyz, r0.yxyw, c14.xyxw, c14.yzyw
mov r2.xy, v2
texld r3, v0, s0
mad r0.y, c7.x, r3.x, c7.y
rcp r0.y, r0.y
lrp r1.w, c8.w, r3.x, r0.y
lrp r2.z, r3.x, v2.w, v2.z
mad r2.xyz, v1, -r1.w, r2
mul r3.xyz, r1.w, v1
mad r2.xyz, c8.w, r2, r3
mov r2.w, c12.x
dp4 r3.w, c3, r2
dp4 r3.x, c0, r2
dp4 r3.y, c1, r2
dp4 r3.z, c2, r2
dp4 r2.x, c4, r3
dp4 r2.y, c5, r3
dp4 r4.z, c6, r3
add r3.xyz, r3, -c10
dp3 r0.y, r3, r3
rsq r0.y, r0.y
rcp r0.y, r0.y
mad_sat_pp r0.y, r0.y, c9.z, c9.w
mad r0.zw, r2.xyxy, r0, c12.y
frc r2.xy, r0.zwzw
add r0.zw, r0, -r2.xyxy
add r0.zw, r0, c12.z
mad r2.zw, r2.xyxy, c12.w, c12.x
rcp r1.w, r2.w
mad r3.z, r2.y, r1.w, c13.z
add r5.xy, r2, c12.w
mul r5.yz, r5.xxyw, c11.xxyw
mov r3.y, r5.z
mad r6.xy, r2, -c13.z, c13.x
mad r6.zw, r2.xyxy, -c13.x, c13.y
rcp r1.w, r6.w
mad r3.x, r6.y, r1.w, c13.w
mul r1.xyz, r1, r3
mov r3.w, r1.x
rcp r1.x, r2.z
mad r5.w, r2.x, r1.x, c13.z
mul r1.x, r2.x, c12.w
mov r7.xyw, c14
mad r2.xyz, r1.x, r7.wyxw, c15
rcp r1.x, r6.z
mul_pp r6.yzw, r6.w, r2.xxyz
mad r5.x, r6.x, r1.x, c13.w
mad r7.xyz, r0.x, c14.xyxw, c14.yzyw
mul r3.xyz, r5.yxww, r7.yxzw
mad r4.xy, r0.zwzw, c11, r3.ywzw
mov r4.w, c12.x
texldp r5, r4, s1
mad r4.xy, r0.zwzw, c11, r3.xwzw
mad r7.xy, r0.zwzw, c11, r3.zwzw
texldp r8, r4, s1
mov r7.zw, r4
mul r0.x, r6.z, r8.x
mad_pp r0.x, r6.y, r5.x, r0.x
texldp r4, r7, s1
mad_pp r0.x, r6.w, r4.x, r0.x
mov r1.w, r3.y
mad r7.xy, r0.zwzw, c11, r1.wyzw
mad r4.xy, r0.zwzw, c11, r1.wzzw
mov r3.yw, r1.xyzz
texldp r1, r7, s1
mul_pp r1.yz, r2.xxzw, c15.y
mul_pp r2.xyz, r2.w, r2
mad_pp r0.x, r1.y, r1.x, r0.x
mad r7.xy, r0.zwzw, c11, r3
texldp r5, r7, s1
mad_pp r0.x, r5.x, c15.w, r0.x
mad r7.xy, r0.zwzw, c11, r3.zyzw
texldp r5, r7, s1
mov r4.zw, r7
mad_pp r0.x, r1.z, r5.x, r0.x
texldp r1, r4, s1
mad_pp r0.x, r2.x, r1.x, r0.x
mad r4.xy, r0.zwzw, c11, r3.xwzw
mad r1.xy, r0.zwzw, c11, r3.zwzw
texldp r3, r4, s1
mov r1.zw, r4
texldp r1, r1, s1
mad_pp r0.x, r2.y, r3.x, r0.x
mad_pp r0.x, r2.z, r1.x, r0.x
mul_pp r0.x, r0.x, c16.x
mov r1.x, c12.x
lrp_pp r2.x, r0.x, r1.x, c9.x
add_pp oC0, r0.y, r2.x

"
}
SubProgram "d3d11 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
SetTexture 0 [_CameraDepthTexture] 2D 0
SetTexture 1 [_ShadowMapTexture] 2D 1
ConstBuffer "$Globals" 128
Vector 112 [_ShadowMapTexture_TexelSize]
ConstBuffer "UnityPerCamera" 144
Vector 112 [_ZBufferParams]
Vector 128 [unity_OrthoParams]
ConstBuffer "UnityShadows" 416
Matrix 128 [unity_World2Shadow0]
Matrix 192 [unity_World2Shadow1]
Matrix 256 [unity_World2Shadow2]
Matrix 320 [unity_World2Shadow3]
Vector 384 [_LightShadowData]
Vector 400 [unity_ShadowFadeCenterAndType]
ConstBuffer "UnityPerCamera2" 64
Matrix 0 [_CameraToWorld]
BindCB  "$Globals" 0
BindCB  "UnityPerCamera" 1
BindCB  "UnityShadows" 2
BindCB  "UnityPerCamera2" 3
"ps_4_0
root12:acaeacaa
eefiecedkmkgphjihgeikhcadgfjcncbgjmbdangabaaaaaanaamaaaaadaaaaaa
cmaaaaaaleaaaaaaoiaaaaaaejfdeheoiaaaaaaaaeaaaaaaaiaaaaaagiaaaaaa
aaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaadadaaaagiaaaaaaabaaaaaaaaaaaaaa
adaaaaaaabaaaaaaahahaaaagiaaaaaaacaaaaaaaaaaaaaaadaaaaaaacaaaaaa
apapaaaahbaaaaaaaaaaaaaaabaaaaaaadaaaaaaadaaaaaaapaaaaaafeeffied
epepfceeaafdfgfpfaepfdejfeejepeoaaklklklepfdeheocmaaaaaaabaaaaaa
aiaaaaaacaaaaaaaaaaaaaaaaaaaaaaaadaaaaaaaaaaaaaaapaaaaaafdfgfpfe
gbhcghgfheaaklklfdeieefcoaalaaaaeaaaaaaapiacaaaafjaaaaaeegiocaaa
aaaaaaaaaiaaaaaafjaaaaaeegiocaaaabaaaaaaajaaaaaafjaaaaaeegiocaaa
acaaaaaabkaaaaaafjaaaaaeegiocaaaadaaaaaaaeaaaaaafkaaaaadaagabaaa
aaaaaaaafkaiaaadaagabaaaabaaaaaafibiaaaeaahabaaaaaaaaaaaffffaaaa
fibiaaaeaahabaaaabaaaaaaffffaaaagcbaaaaddcbabaaaaaaaaaaagcbaaaad
hcbabaaaabaaaaaagcbaaaadpcbabaaaacaaaaaagfaaaaadpccabaaaaaaaaaaa
giaaaaacaiaaaaaaefaaaaajpcaabaaaaaaaaaaaegbabaaaaaaaaaaaeghobaaa
aaaaaaaaaagabaaaaaaaaaaadcaaaaalccaabaaaaaaaaaaaakiacaaaabaaaaaa
ahaaaaaaakaabaaaaaaaaaaabkiacaaaabaaaaaaahaaaaaaaoaaaaakccaabaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaiadpaaaaiadpbkaabaaaaaaaaaaa
aaaaaaaiecaabaaaaaaaaaaabkaabaiaebaaaaaaaaaaaaaaakaabaaaaaaaaaaa
dcaaaaakccaabaaaaaaaaaaadkiacaaaabaaaaaaaiaaaaaackaabaaaaaaaaaaa
bkaabaaaaaaaaaaadgaaaaafdcaabaaaabaaaaaaegbabaaaacaaaaaaaaaaaaai
ecaabaaaaaaaaaaackbabaiaebaaaaaaacaaaaaadkbabaaaacaaaaaadcaaaaaj
ecaabaaaabaaaaaaakaabaaaaaaaaaaackaabaaaaaaaaaaackbabaaaacaaaaaa
dcaaaaakncaabaaaaaaaaaaaagbjbaiaebaaaaaaabaaaaaafgafbaaaaaaaaaaa
agajbaaaabaaaaaadiaaaaahhcaabaaaabaaaaaafgafbaaaaaaaaaaaegbcbaaa
abaaaaaadcaaaaakhcaabaaaaaaaaaaapgipcaaaabaaaaaaaiaaaaaaigadbaaa
aaaaaaaaegacbaaaabaaaaaadiaaaaaipcaabaaaabaaaaaafgafbaaaaaaaaaaa
egiocaaaadaaaaaaabaaaaaadcaaaaakpcaabaaaabaaaaaaegiocaaaadaaaaaa
aaaaaaaaagaabaaaaaaaaaaaegaobaaaabaaaaaadcaaaaakpcaabaaaaaaaaaaa
egiocaaaadaaaaaaacaaaaaakgakbaaaaaaaaaaaegaobaaaabaaaaaaaaaaaaai
pcaabaaaaaaaaaaaegaobaaaaaaaaaaaegiocaaaadaaaaaaadaaaaaadiaaaaai
hcaabaaaabaaaaaafgafbaaaaaaaaaaaegiccaaaacaaaaaaajaaaaaadcaaaaak
hcaabaaaabaaaaaaegiccaaaacaaaaaaaiaaaaaaagaabaaaaaaaaaaaegacbaaa
abaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaaakaaaaaakgakbaaa
aaaaaaaaegacbaaaabaaaaaadcaaaaakhcaabaaaabaaaaaaegiccaaaacaaaaaa
alaaaaaapgapbaaaaaaaaaaaegacbaaaabaaaaaaaaaaaaajhcaabaaaaaaaaaaa
egacbaaaaaaaaaaaegiccaiaebaaaaaaacaaaaaabjaaaaaabaaaaaahbcaabaaa
aaaaaaaaegacbaaaaaaaaaaaegacbaaaaaaaaaaaelaaaaafbcaabaaaaaaaaaaa
akaabaaaaaaaaaaadccaaaalbcaabaaaaaaaaaaaakaabaaaaaaaaaaackiacaaa
acaaaaaabiaaaaaadkiacaaaacaaaaaabiaaaaaadgaaaaagfcaabaaaacaaaaaa
fgifcaaaaaaaaaaaahaaaaaadgaaaaafccaabaaaacaaaaaaabeaaaaacfejbcdo
dcaaaaangcaabaaaaaaaaaaaagabbaaaabaaaaaakgilcaaaaaaaaaaaahaaaaaa
aceaaaaaaaaaaaaaaaaaaadpaaaaaadpaaaaaaaabkaaaaafdcaabaaaabaaaaaa
jgafbaaaaaaaaaaaebaaaaafgcaabaaaaaaaaaaafgagbaaaaaaaaaaaaaaaaaak
gcaabaaaaaaaaaaafgagbaaaaaaaaaaaaceaaaaaaaaaaaaaaaaaaalpaaaaaalp
aaaaaaaadcaaaabadcaabaaaadaaaaaaegaabaiaebaaaaaaabaaaaaaaceaaaaa
aaaaaaeaaaaaaaeaaaaaaaaaaaaaaaaaaceaaaaaaaaaeaeaaaaaeaeaaaaaaaaa
aaaaaaaadcaaaabamcaabaaaadaaaaaaagaebaiaebaaaaaaabaaaaaaaceaaaaa
aaaaaaaaaaaaaaaaaaaaeaeaaaaaeaeaaceaaaaaaaaaaaaaaaaaaaaaaaaaiaea
aaaaiaeaaoaaaaahdcaabaaaadaaaaaaegaabaaaadaaaaaaogakbaaaadaaaaaa
aaaaaaakdcaabaaaaeaaaaaaegaabaaaadaaaaaaaceaaaaaaaaaaamaaaaaaama
aaaaaaaaaaaaaaaadgaaaaafecaabaaaafaaaaaabkaabaaaaeaaaaaadcaaaaap
dcaabaaaadaaaaaaegaabaaaabaaaaaaaceaaaaaaaaaeaeaaaaaeaeaaaaaaaaa
aaaaaaaaaceaaaaaaaaaiadpaaaaiadpaaaaaaaaaaaaaaaaaoaaaaahfcaabaaa
adaaaaaaagabbaaaabaaaaaaagabbaaaadaaaaaaaaaaaaakjcaabaaaafaaaaaa
agaibaaaadaaaaaaaceaaaaaaaaaaaeaaaaaaaaaaaaaaaaaaaaaaaeadgaaaaaf
icaabaaaaeaaaaaaakaabaaaafaaaaaaaaaaaaakkcaabaaaabaaaaaaagaebaaa
abaaaaaaaceaaaaaaaaaaaaaaaaaeaeaaaaaaaaaaaaaeaeadiaaaaahicaabaaa
aaaaaaaaakaabaaaabaaaaaaabeaaaaaaaaaeaeadcaaaaapfcaabaaaagaaaaaa
pgapbaaaaaaaaaaaaceaaaaaaaaaialpaaaaaaaaaaaaiadpaaaaaaaaaceaaaaa
aaaaiaeaaaaaaaaaaaaaiadpaaaaaaaadiaaaaaidcaabaaaafaaaaaangafbaaa
abaaaaaaegiacaaaaaaaaaaaahaaaaaadiaaaaahhcaabaaaacaaaaaaegacbaaa
acaaaaaaggalbaaaafaaaaaadgaaaaafecaabaaaaeaaaaaaakaabaaaafaaaaaa
dgaaaaaficaabaaaafaaaaaaakaabaaaacaaaaaadgaaaaagfcaabaaaahaaaaaa
agiacaaaaaaaaaaaahaaaaaadgaaaaafccaabaaaahaaaaaaabeaaaaacfejbcdo
diaaaaahhcaabaaaafaaaaaacgalbaaaaeaaaaaabgagbaaaahaaaaaadcaaaaak
pcaabaaaaeaaaaaajgajbaaaaaaaaaaaegiecaaaaaaaaaaaahaaaaaangambaaa
afaaaaaadcaaaaakdcaabaaaabaaaaaajgafbaaaaaaaaaaaegiacaaaaaaaaaaa
ahaaaaaaogakbaaaafaaaaaaehaaaaalicaabaaaaaaaaaaaegaabaaaabaaaaaa
aghabaaaabaaaaaaaagabaaaabaaaaaackaabaaaabaaaaaaehaaaaalbcaabaaa
abaaaaaaegaabaaaaeaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaackaabaaa
abaaaaaaehaaaaalccaabaaaabaaaaaaogakbaaaaeaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaackaabaaaabaaaaaadgaaaaafccaabaaaagaaaaaaabeaaaaa
aaaaoaeadiaaaaahncaabaaaadaaaaaapgapbaaaadaaaaaaagajbaaaagaaaaaa
diaaaaahhcaabaaaaeaaaaaafgafbaaaadaaaaaaegacbaaaagaaaaaadiaaaaak
dcaabaaaagaaaaaaigaabaaaagaaaaaaaceaaaaaaaaaoaeaaaaaoaeaaaaaaaaa
aaaaaaaadiaaaaahccaabaaaabaaaaaabkaabaaaabaaaaaackaabaaaadaaaaaa
dcaaaaajbcaabaaaabaaaaaaakaabaaaadaaaaaaakaabaaaabaaaaaabkaabaaa
abaaaaaadcaaaaajicaabaaaaaaaaaaadkaabaaaadaaaaaadkaabaaaaaaaaaaa
akaabaaaabaaaaaadgaaaaaficaabaaaacaaaaaabkaabaaaafaaaaaadcaaaaak
pcaabaaaadaaaaaajgajbaaaaaaaaaaaegiecaaaaaaaaaaaahaaaaaahgalbaaa
acaaaaaadgaaaaafkcaabaaaafaaaaaafgajbaaaacaaaaaaehaaaaalbcaabaaa
abaaaaaaegaabaaaadaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaackaabaaa
abaaaaaaehaaaaalccaabaaaabaaaaaaogakbaaaadaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaackaabaaaabaaaaaadcaaaaajicaabaaaaaaaaaaaakaabaaa
agaaaaaaakaabaaaabaaaaaadkaabaaaaaaaaaaadcaaaaakpcaabaaaacaaaaaa
jgajbaaaaaaaaaaaegiecaaaaaaaaaaaahaaaaaaegagbaaaafaaaaaadcaaaaak
pcaabaaaadaaaaaajgajbaaaaaaaaaaaegiecaaaaaaaaaaaahaaaaaamgaobaaa
afaaaaaaehaaaaalccaabaaaaaaaaaaaegaabaaaacaaaaaaaghabaaaabaaaaaa
aagabaaaabaaaaaackaabaaaabaaaaaaehaaaaalecaabaaaaaaaaaaaogakbaaa
acaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaackaabaaaabaaaaaadcaaaaaj
ccaabaaaaaaaaaaabkaabaaaaaaaaaaaabeaaaaaaaaaeeecdkaabaaaaaaaaaaa
dcaaaaajccaabaaaaaaaaaaabkaabaaaagaaaaaackaabaaaaaaaaaaabkaabaaa
aaaaaaaadcaaaaajccaabaaaaaaaaaaaakaabaaaaeaaaaaabkaabaaaabaaaaaa
bkaabaaaaaaaaaaaehaaaaalecaabaaaaaaaaaaaegaabaaaadaaaaaaaghabaaa
abaaaaaaaagabaaaabaaaaaackaabaaaabaaaaaaehaaaaalicaabaaaaaaaaaaa
ogakbaaaadaaaaaaaghabaaaabaaaaaaaagabaaaabaaaaaackaabaaaabaaaaaa
dcaaaaajccaabaaaaaaaaaaabkaabaaaaeaaaaaackaabaaaaaaaaaaabkaabaaa
aaaaaaaadcaaaaajccaabaaaaaaaaaaackaabaaaaeaaaaaadkaabaaaaaaaaaaa
bkaabaaaaaaaaaaadiaaaaahccaabaaaaaaaaaaabkaabaaaaaaaaaaaabeaaaaa
djiooddlaaaaaaajecaabaaaaaaaaaaaakiacaiaebaaaaaaacaaaaaabiaaaaaa
abeaaaaaaaaaiadpdcaaaaakccaabaaaaaaaaaaabkaabaaaaaaaaaaackaabaaa
aaaaaaaaakiacaaaacaaaaaabiaaaaaaaaaaaaahpccabaaaaaaaaaaaagaabaaa
aaaaaaaafgafbaaaaaaaaaaadoaaaaab"
}
SubProgram "gles " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES"
}
SubProgram "gles3 " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GLES3"
}
SubProgram "glcore " {
Keywords { "SHADOWS_SPLIT_SPHERES" "SHADOWS_NATIVE" "SHADOWS_SINGLE_CASCADE" }
"!!GL3x"
}
}
 }
}
Fallback Off
}
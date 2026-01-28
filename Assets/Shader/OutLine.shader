Shader "Shader/OutLine"
{
    Properties
    {
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend("Src Blend", int) = 0
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend("Dst Blend", int) = 0
        _MainTex("Texture", 2D) = "white" {}
        [Toggle] _MaskEnabled("Color Toggle", int) = 0
        _Color("Color", color) = (1, 1, 1, 1)
        
        // 描边厚度，范围 0.0 到 10.0
        _OutlineThickness("Outline Thickness", float) = 1.0
        
        // 描边颜色，默认红色
        _OutlineColor("Outline Color", color) = (1, 0, 0, 1) // 默认红色
        
        // 描边颜色透明度，范围 0.0 到 1.0
        _OutlineColorAlpha("Outline Color Alpha", float) = 1.0 
        
        // 采样偏移，范围 0.0 到 10.0
        _SampleOffset("Sample Offset", float) = 1.0 
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" }
        Blend [_SrcBlend] [_DstBlend]

        Cull off
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature _ _MASKENABLED_ON

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            fixed4 _Color;
            float _OutlineThickness;
            fixed4 _OutlineColor;
            float _OutlineColorAlpha;
            float _SampleOffset;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float outlineThickness = _OutlineThickness / 100.0;
                float sampleOffset = _SampleOffset / 100.0;
                fixed4 currentColor = tex2D(_MainTex, i.uv);
                fixed4 colorUp = tex2D(_MainTex, i.uv + float2(0, outlineThickness + sampleOffset));
                fixed4 colorDown = tex2D(_MainTex, i.uv - float2(0, outlineThickness + sampleOffset));
                fixed4 colorLeft = tex2D(_MainTex, i.uv - float2(outlineThickness + sampleOffset, 0));
                fixed4 colorRight = tex2D(_MainTex, i.uv + float2(outlineThickness + sampleOffset, 0));

                bool isOutline = (colorUp.a < 0.5 || colorDown.a < 0.5 || colorLeft.a < 0.5 || colorRight.a < 0.5 ||
                                  colorUp.rgb == float3(0.0, 0.0, 0.0) || colorDown.rgb == float3(0.0, 0.0, 0.0) ||
                                  colorLeft.rgb == float3(0.0, 0.0, 0.0) || colorRight.rgb == float3(0.0, 0.0, 0.0));

                bool isShadowPattern = (currentColor.rgb == float3(16.0 / 255.0, 8.0 / 255.0, 8.0 / 255.0) || currentColor.r < 0.01);

                if (isOutline && !isShadowPattern)
                {
                    return fixed4(_OutlineColor.rgb, _OutlineColorAlpha);
                }
                else
                {
                    return currentColor;
                }
            }
            ENDCG
        }
    }
}

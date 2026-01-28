Shader "Shader/GrayScale"
{
    Properties
    {
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend("Src Blend", int) = 5
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend("Dst Blend", int) = 10
        _MainTex ("Texture", 2D) = "white" {}
        [Toggle] _MaskEnabled("Color Toggle", int) = 0
        [Toggle] _GrayScaleEnabled("GrayScale Toggle", int) = 0
        _Color("Color", color) = (1, 1, 1, 1)
    }
    SubShader
    {
        Tags { "Queue" = "Transparent" }
        Blend [_SrcBlend] [_DstBlend]

        Cull Off
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature _MASKENABLED_ON
            #pragma shader_feature _GRAYSCALEENABLED_ON

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

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                fixed4 c = tex2D(_MainTex, i.uv);
                
                #if _MASKENABLED_ON
                c = saturate(c + _Color);
                #endif

                #if _GRAYSCALEENABLED_ON
                float gray = dot(c.rgb, float3(0.299, 0.587, 0.114));
                c = fixed4(gray, gray, gray, c.a);
                #endif

                return c;
            }
            ENDCG
        }
    }
}

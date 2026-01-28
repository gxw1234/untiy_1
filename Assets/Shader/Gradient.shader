Shader "Shader/Gradient"
{
    Properties
    {
        _MainTex ("Base (RGB)", 2D) = "white" {}
        _ColorTop ("Top Color", Color) = (1, 0, 0, 1)
        _ColorBottom ("Bottom Color", Color) = (0, 0, 1, 1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : POSITION;
                float2 texcoord : TEXCOORD0;
                float4 color : COLOR0;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float4 _ColorTop;
            float4 _ColorBottom;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex);
                o.color = lerp(_ColorBottom, _ColorTop, v.texcoord.y);
                return o;
            }

            half4 frag (v2f i) : COLOR
            {
                half4 texColor = tex2D(_MainTex, i.texcoord);
                return texColor * i.color;
            }
            ENDCG
        }
    }
}

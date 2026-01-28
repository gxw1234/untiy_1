Shader "Shader/BlackWhiteOverlay"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}  // 主纹理
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }
        LOD 200

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex;  // 纹理采样器
            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 pos : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // 采样纹理颜色
                fixed4 color = tex2D(_MainTex, i.uv);

                // 容差范围，用来处理接近白色的部分
                float tolerance = 0.05;

                // 如果颜色接近白色，则使该像素透明
                if (length(color.rgb - float3(1.0, 1.0, 1.0)) < tolerance)
                {
                    color.a = 0.0;  // 白色及其覆盖的区域设置为透明
                }

                return color;
            }
            ENDCG
        }
    }
    FallBack "Transparent/Cutout/VertexLit"
}

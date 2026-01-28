Shader "Shader/Light"
{
    Properties
    {
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend("Src Blend", int) = 5
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend("Dst Blend", int) = 10
        _MainTex ("Light Texture", 2D) = "white" {}
        _Color ("Light Color", Color) = (1,1,1,1)
        _Intensity ("Intensity", Range(0, 1)) = 1
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"="Transparent" }
        LOD 200

        Pass
        {
            Blend [_SrcBlend] [_DstBlend]
            ZWrite Off
            ZTest Off
            Lighting Off
            Fog { Mode Off }

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata_t
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
            float4 _Color;
            float _Intensity;

            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float time = _Time.y;
                float alpha = 0.975 + 0.05 * sin(time * 9.0);
                float brightness = 0.975 + 0.025 * sin(time * 9.0);
                fixed4 texColor = tex2D(_MainTex, i.uv);
                texColor *= _Color;
                texColor.rgb *= brightness;
                texColor.a *= alpha;
                return texColor;
            }
            ENDCG
        }
    }
    FallBack "Transparent/VertexLit"
}

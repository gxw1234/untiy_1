Shader "Shader/AmbientLightMaterial"  
{  
    Properties  
    {  
        _MainTex ("Base Texture", 2D) = "white" {}  
        _OverlayTex ("Overlay Texture", 2D) = "black" {}  
    }  
    SubShader  
    {  
        Tags { "RenderType"="Opaque" }  
        LOD 100  
  
        Pass  
        {  
            CGPROGRAM  
            #pragma vertex vert  
            #pragma fragment frag  
  
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
            sampler2D _OverlayTex;  
            float4 _OverlayTex_ST;  
  
            v2f vert (appdata v)  
            {  
                v2f o;  
                o.vertex = UnityObjectToClipPos(v.vertex);  
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);  
                return o;  
            }  
  
            fixed4 frag (v2f i) : SV_Target  
            {  
                // 采样基础纹理  
                fixed4 baseColor = tex2D(_MainTex, i.uv);  
  
                // 采样覆盖纹理  
                fixed4 overlayColor = tex2D(_OverlayTex, TRANSFORM_TEX(i.uv, _OverlayTex));  
  
                // 如果覆盖纹理的alpha值不为0，则使用覆盖纹理的颜色替换基础纹理的颜色  
                if (overlayColor.a > 0)  
                {  
                    baseColor = overlayColor;  
                }  
  
                return baseColor;  
            }  
            ENDCG  
        }  
    }  
    FallBack "Diffuse"  
}
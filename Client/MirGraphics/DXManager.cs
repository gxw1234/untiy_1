using Shared.Unity.Imaging;
using Client.MirControls;
using Client.MirScenes;
using System.Collections.Generic;
using Texture2D = UnityEngine.Texture2D;
using RenderTexture = UnityEngine.RenderTexture;
using ColorUnity = UnityEngine.Color;
using Rect = UnityEngine.Rect;
using Graphics = UnityEngine.Graphics;
using Material = UnityEngine.Material;
using Shader = UnityEngine.Shader;
using Object = UnityEngine.Object;
using Vector2 = Shared.Unity.Vector2;
using Vector3 = Shared.Unity.Vector3;
using Color = Shared.Unity.Color;
using Shared.Unity;
using UnityEngine;


namespace Client.MirGraphics
{
    class DXManager
    {
        public static UnityEngine.Rendering.CommandBuffer _CommandBuffer;//命令
        public static UnityEngine.Material lineMaterial;//画线材质

        public static List<MImage> TextureList = new List<MImage>();
        public static List<MirControl> ControlList = new List<MirControl>();

        public static RenderTexture CurrentSurface;
        public static RenderTexture MainSurface;

        public static bool DeviceLost;
        public static float Opacity = 1F;
        public static bool Blending;
        public static float BlendingRate;
        public static UnityEngine.Color BlendingColor;
        public static BlendMode BlendingMode;

        public static Texture2D RadarTexture;
        public static List<Texture2D> Lights = new List<Texture2D>();
        public static Texture2D PoisonDotBackground;

        public static Dictionary<string, Texture2D> LightTextures = new Dictionary<string, Texture2D>();
        public static Texture2D FloorTexture, LightTexture;
        public static RenderTexture FloorSurface, LightSurface;

        public static bool GrayScale;

        private static RenderTexture lastBaseTexture = null;
        private static RenderTexture lastOverlayTexture = null;
        private static RenderTexture lastResultTexture = null;
        public static Material nowAtlasMaterial,defAtlasMaterial, atlasMaterial, grayscaleMaterial, lightMaterial, outLineMaterial;

        public static Point[] LightSizes =
        {
            new Point(125,95),
            new Point(205,156),
            new Point(285,217),
            new Point(365,277),
            new Point(445,338),
            new Point(525,399),
            new Point(605,460),
            new Point(685,521),
            new Point(765,581),
            new Point(845,642),
            new Point(925,703)
        };

        public static UnityEngine.Rendering.CommandBuffer clearBuffer;

        public static void Create()
        {
            #region 材质初始化
            lineMaterial = new UnityEngine.Material(Shader.Find("Unlit/Color"));
            nowAtlasMaterial = new Material(Shader.Find("Sprites/Default"));
            nowAtlasMaterial.SetColor("_Color", UnityEngine.Color.white);
            defAtlasMaterial = new Material(Shader.Find("Sprites/Default"));
            defAtlasMaterial.SetColor("_Color", UnityEngine.Color.white);
            atlasMaterial = new Material(Shader.Find("Shader/Effect"));
            atlasMaterial.SetColor("_Color", UnityEngine.Color.white);
            grayscaleMaterial = new Material(Shader.Find("Shader/GrayScale"));
            grayscaleMaterial.SetColor("_Color", UnityEngine.Color.white);
            lightMaterial = new Material(Shader.Find("Shader/Light"));
            outLineMaterial = new Material(Shader.Find("Shader/OutLine"));
            #endregion

            // 绘制命令
            _CommandBuffer = new UnityEngine.Rendering.CommandBuffer();
            _CommandBuffer.name = "Batch Draw Mesh Textures";

            if (RadarTexture == null)
            {
                RadarTexture = new Texture2D(2, 2,UnityEngine.TextureFormat.ARGB32,false);
            }

            if (PoisonDotBackground == null)
            {
                PoisonDotBackground = new Texture2D(5, 5,UnityEngine.TextureFormat.ARGB32,false);
            }

            CreateLights();
            clearBuffer = new UnityEngine.Rendering.CommandBuffer() { name = "Clear Buffer" };
        }












        #region 绘制光源纹理  OK
        private static void CreateLights()
        {
            foreach (Texture2D light in Lights)
            {
                Object.Destroy(light);
            }
            Lights.Clear();

            for (int i = 1; i < LightSizes.Length; i++)
            {
                int width = LightSizes[i].X;
                int height = LightSizes[i].Y;

                Texture2D lightTexture = new Texture2D(width, height, TextureFormat.ARGB32, false);
                float centerX = width / 2f;
                float centerY = height / 2f;
                float radiusX = width / 2f;
                float radiusY = 0.4f*width;

                UnityEngine.Color[] blendColours = 
                    {
                        Color.UnityFromArgb(255, 255, 255, 255),
                        Color.UnityFromArgb(255, 210, 210, 210),
                        Color.UnityFromArgb(255, 160, 160, 160),
                        Color.UnityFromArgb(255, 70, 70, 70),
                         Color.UnityFromArgb(255, 40, 40, 40),
                        Color.UnityFromArgb(0, 0, 0, 0)
                    };

                float[] radiusPositions = { 0f, .20f, .40f, .60f, .80f, 1.0f };

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        float normX = (x - centerX) / radiusX;
                        float normY = (y - centerY) / radiusY;

                        if ((normX * normX + normY * normY) <= 1)
                        {
                            float distance = Mathf.Sqrt(normX * normX + normY * normY);
                            float alpha = Mathf.Max(0, 1 - distance);
                            UnityEngine.Color colorToSet = ColorUnity.Lerp(blendColours[0], blendColours[blendColours.Length - 1], distance);
                            colorToSet.a = alpha;
                            lightTexture.SetPixel(x, y, colorToSet);
                        }
                        else
                        {
                            lightTexture.SetPixel(x, y, new UnityEngine.Color(0, 0, 0, 0));
                        }
                    }
                }
                lightTexture.Apply();
                Lights.Add(lightTexture);
            }
        }
        #endregion














        public static void Clear(Color _Color)
        {
            // ColorUnity tmpColor = _Color.ToUnity();
            // clearBuffer.Clear();
            // clearBuffer.ClearRenderTarget(true, true, tmpColor);
            // Graphics.ExecuteCommandBuffer(clearBuffer);

            UnityEngine.GL.Clear(true, true, _Color.ToUnity());
        }

        public static void SetSurface(RenderTexture surface)
        {
            if (CurrentSurface == surface)
                return;

            CurrentSurface = surface;
        }
        public static void SetGrayscale(bool value)
        {
            GrayScale = value;

            if (value == true)
            {
                grayscaleMaterial.EnableKeyword("_GRAYSCALEENABLED_ON");
                nowAtlasMaterial = grayscaleMaterial;
            }
            else
            {
                nowAtlasMaterial = defAtlasMaterial;
            }
        }

        #region 绘制标签边框
        public static void LineDraw(Vector2[] vertices, Color _Color)
        {
            if (vertices == null || vertices.Length < 2) return;

            _CommandBuffer.Clear();
            lineMaterial.SetColor("_Color", _Color.ToUnity());//设置颜色

            UnityEngine.Vector3[] meshVertices = new UnityEngine.Vector3[vertices.Length];
            for (int i = 0; i < vertices.Length; i++)
            {
                meshVertices[i] = new UnityEngine.Vector3(vertices[i].X, vertices[i].Y, 0);
            }

            UnityEngine.Mesh lineMesh = new UnityEngine.Mesh();
            lineMesh.vertices = meshVertices;

            // 设置线条的拓扑结构为线段
            int[] indices = new int[vertices.Length];
            for (int i = 0; i < vertices.Length; i++)
            {
                indices[i] = i;
            }
            lineMesh.SetIndices(indices, UnityEngine.MeshTopology.LineStrip, 0);

            // 在 CommandBuffer 中绘制网格
            _CommandBuffer.DrawMesh(lineMesh, UnityEngine.Matrix4x4.identity, lineMaterial);
            Graphics.ExecuteCommandBuffer(_CommandBuffer);
        }
        #endregion



        public static void DrawOpaque(Texture2D texture, Rectangle? sourceRect, Vector3 position, Color color, float opacity)
        {
            color.A = (byte)(opacity * 255);
            Draw(texture, sourceRect, position, color);
        }

        #region Graphics绘图方法
        public static void Draw(Texture2D texture, Rectangle? sourceRect, Vector3 position, Color color)
        {
            if (texture == null) return;

            int textureWidth = texture.width;
            int textureHeight = texture.height;
            int drawWidth = sourceRect?.Width ?? textureWidth;
            int drawHeight = sourceRect?.Height ?? textureHeight;

            Rect _position = new Rect(position.X, position.Y, drawWidth, drawHeight);
            Rect _sourceRect = new Rect(0, 0, 1f, 1f);
            if (sourceRect.HasValue)
            {

                _sourceRect.x = (float)sourceRect.Value.X / textureWidth;
                _sourceRect.y = (float)(textureHeight - sourceRect.Value.Y - drawHeight) / textureHeight;
                _sourceRect.width = (float)drawWidth / textureWidth;
                _sourceRect.height = (float)drawHeight / textureHeight;
            }

            ColorUnity tmpColor = color.ToUnity();
            texture.wrapMode = UnityEngine.TextureWrapMode.Clamp;
            texture.filterMode = UnityEngine.FilterMode.Bilinear;

            Graphics.DrawTexture(_position, texture, _sourceRect, 0, 0, 0, 0, tmpColor, nowAtlasMaterial);

            CMain.DPSCounter++;
        }
        #endregion

        #region 动态改变透明度
        public static void SetOpacity(float opacity)
        {
            if (Opacity == opacity) return;

            if (nowAtlasMaterial == lightMaterial || nowAtlasMaterial == grayscaleMaterial || nowAtlasMaterial == atlasMaterial)
            {
                ColorUnity tmpColor = nowAtlasMaterial.GetColor("_Color");
                tmpColor.a = opacity;
                nowAtlasMaterial.SetColor("_Color", tmpColor);
            }
            else
            {
                nowAtlasMaterial = defAtlasMaterial;
                nowAtlasMaterial.SetColor("_Color", new ColorUnity(1, 1, 1, opacity));
            }
            Opacity = opacity;
        }
        #endregion

        #region 通用混合模式
        public static void SetBlend(bool value, float rate = 1F, BlendMode mode = BlendMode.NORMAL)
        {
            if (value == Blending && BlendingRate == rate && BlendingMode == mode) return;

            Blending = value;
            BlendingRate = rate;
            BlendingMode = mode;

            if (Blending)
            {
                atlasMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                atlasMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.One);
                atlasMaterial.SetColor("_Color", new ColorUnity(BlendingRate, BlendingRate, BlendingRate, BlendingRate));
                nowAtlasMaterial = atlasMaterial;
            }
            else
                nowAtlasMaterial = defAtlasMaterial;
        }
        #endregion

        #region 黑夜光照模式专用混合
        public static void SetLightsBlend(bool value, float rate, BlendMode mode,Color materialColor)
        {
            if (value == Blending && BlendingRate == rate && BlendingMode == mode) return;

            Blending = value;
            BlendingRate = rate;
            BlendingMode = mode;
            BlendingColor = new UnityEngine.Color(materialColor.R/255f, materialColor.G/255f, materialColor.B/255f, materialColor.A/255f* rate);

            if (Blending)
            {
                lightMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                lightMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                //lightMaterial.SetColor("_Color", new ColorUnity(BlendingColor.r, BlendingColor.g, BlendingColor.b, BlendingColor.a));
                nowAtlasMaterial = lightMaterial;
            }
            else
            {
                nowAtlasMaterial = defAtlasMaterial;
            }
        }
        #endregion

        public static void SetRenderState(UnityEngine.Rendering.BlendMode c1, UnityEngine.Rendering.BlendMode c2)
        {
            nowAtlasMaterial.SetInt("_SrcBlend", (int)c1);
            nowAtlasMaterial.SetInt("_DstBlend", (int)c2);
        }

        #region 目标高亮描边专用混合
        public static void SetHightLightBlend(bool value, float rate = 1F, BlendMode mode = BlendMode.NORMAL)
        {
            if (value == Blending && BlendingRate == rate && BlendingMode == mode) return;

            Blending = value;
            BlendingRate = rate;
            BlendingMode = mode;

            if (Blending)
            {
                outLineMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                outLineMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.One);
                outLineMaterial.SetColor("_Color", new ColorUnity(BlendingRate, BlendingRate, BlendingRate, BlendingRate));
                nowAtlasMaterial = outLineMaterial;
            }
            else
                nowAtlasMaterial = defAtlasMaterial;
        }
        #endregion







        public static void Clean()
        {
            for (int i = TextureList.Count - 1; i >= 0; i--)
            {
                MImage m = TextureList[i];

                if (m == null)
                {
                    TextureList.RemoveAt(i);
                    continue;
                }

                if (CMain.Time <= m.CleanTime) continue;

                m.DisposeTexture();
            }

            for (int i = ControlList.Count - 1; i >= 0; i--)
            {
                MirControl c = ControlList[i];

                if (c == null)
                {
                    ControlList.RemoveAt(i);
                    continue;
                }

                if (CMain.Time <= c.CleanTime) continue;

                c.DisposeTexture();
            }
        }


        private static void CleanUp()
        {
            if (CurrentSurface != null)
            {
                CurrentSurface = null;
            }

            if (PoisonDotBackground != null)
            {
                PoisonDotBackground = null;
            }

            if (RadarTexture != null)
            {
                Object.Destroy(RadarTexture);
                RadarTexture = null;
            }

            if (FloorTexture != null)
            {
                Object.Destroy(FloorTexture);

                DXManager.FloorTexture = null;
                GameScene.Scene.MapControl.FloorValid = false;

                if (DXManager.FloorSurface != null)
                {
                    Object.Destroy(DXManager.FloorSurface);
                }

                DXManager.FloorSurface = null;
            }

            if (LightTexture != null)
            {
                Object.Destroy(LightTexture);

                DXManager.LightTexture = null;

                if (DXManager.LightSurface != null)
                {
                    Object.Destroy(DXManager.LightSurface);
                }

                DXManager.LightSurface = null;
            }

            if (Lights != null)
            {
                for (int i = 0; i < Lights.Count; i++)
                {
                    Object.Destroy(Lights[i]);
                }
                Lights.Clear();
            }

            for (int i = TextureList.Count - 1; i >= 0; i--)
            {
                MImage m = TextureList[i];

                if (m == null) continue;

                m.DisposeTexture();
            }
            TextureList.Clear();


            for (int i = ControlList.Count - 1; i >= 0; i--)
            {
                MirControl c = ControlList[i];

                if (c == null) continue;

                c.DisposeTexture();
            }
            ControlList.Clear();
        }

        // public static void Dispose()
        // {
        //     CleanUp();

        //     Device?.Direct3D?.Dispose();
        //     Device?.Dispose();

        //     NormalPixelShader?.Dispose();
        //     GrayScalePixelShader?.Dispose();
        //     MagicPixelShader?.Dispose();
        // }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton9 : GButton
    {
        public Controller button;
        public GImage Img105nj;
        public GImage Img114m0;
        public GTextField ChatEdit137;
        public const string URL = "ui://use7blkkqgn27c";

        public static DA2ESimpleButton9 CreateInstance()
        {
            return (DA2ESimpleButton9)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton9");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img105nj = (GImage)GetChild("Img105nj");
            Img114m0 = (GImage)GetChild("Img114m0");
            ChatEdit137 = (GTextField)GetChild("ChatEdit137");
        }
    }
}
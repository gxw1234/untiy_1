/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton10 : GButton
    {
        public Controller button;
        public GImage Img106ks;
        public GImage Img11756;
        public GTextField ChatEdit139;
        public const string URL = "ui://use7blkkqgn27d";

        public static DA2ESimpleButton10 CreateInstance()
        {
            return (DA2ESimpleButton10)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img106ks = (GImage)GetChild("Img106ks");
            Img11756 = (GImage)GetChild("Img11756");
            ChatEdit139 = (GTextField)GetChild("ChatEdit139");
        }
    }
}
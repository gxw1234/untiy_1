/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnBuy : GButton
    {
        public Controller button;
        public GImage Img4086ce;
        public GImage Img409m0u;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zw6";

        public static BtnBuy CreateInstance()
        {
            return (BtnBuy)UIPackage.CreateObject("UIRes", "BtnBuy");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4086ce = (GImage)GetChild("Img4086ce");
            Img409m0u = (GImage)GetChild("Img409m0u");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnAutoFight : GButton
    {
        public Controller button;
        public GImage Img46341v;
        public GImage Img464jq2;
        public const string URL = "ui://jk0io98jv9b11h";

        public static BtnAutoFight CreateInstance()
        {
            return (BtnAutoFight)UIPackage.CreateObject("UIRes", "BtnAutoFight");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img46341v = (GImage)GetChild("Img46341v");
            Img464jq2 = (GImage)GetChild("Img464jq2");
        }
    }
}
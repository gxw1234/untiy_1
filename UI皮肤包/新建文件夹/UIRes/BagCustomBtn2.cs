/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagCustomBtn2 : GButton
    {
        public Controller button;
        public GImage Img108us;
        public GImage Img110ly;
        public GTextField ChatEdit2;
        public const string URL = "ui://jk0io98jv9b15g";

        public static BagCustomBtn2 CreateInstance()
        {
            return (BagCustomBtn2)UIPackage.CreateObject("UIRes", "BagCustomBtn2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img108us = (GImage)GetChild("Img108us");
            Img110ly = (GImage)GetChild("Img110ly");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
        }
    }
}
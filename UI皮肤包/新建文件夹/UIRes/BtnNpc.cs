/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnNpc : GButton
    {
        public Controller button;
        public GImage BottNpcImg;
        public GTextField title;
        public const string URL = "ui://jk0io98jv9b11k";

        public static BtnNpc CreateInstance()
        {
            return (BtnNpc)UIPackage.CreateObject("UIRes", "BtnNpc");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            BottNpcImg = (GImage)GetChild("BottNpcImg");
            title = (GTextField)GetChild("title");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CheckBoxBan : GButton
    {
        public Controller button;
        public GImage Img1767sv;
        public GImage Img17742p;
        public const string URL = "ui://jk0io98jkn5z180";

        public static CheckBoxBan CreateInstance()
        {
            return (CheckBoxBan)UIPackage.CreateObject("UIRes", "CheckBoxBan");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1767sv = (GImage)GetChild("Img1767sv");
            Img17742p = (GImage)GetChild("Img17742p");
        }
    }
}
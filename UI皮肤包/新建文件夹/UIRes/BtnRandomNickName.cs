/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnRandomNickName : GButton
    {
        public Controller button;
        public GImage Img3615a;
        public GImage Img37awy;
        public const string URL = "ui://jk0io98jys021";

        public static BtnRandomNickName CreateInstance()
        {
            return (BtnRandomNickName)UIPackage.CreateObject("UIRes", "BtnRandomNickName");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3615a = (GImage)GetChild("Img3615a");
            Img37awy = (GImage)GetChild("Img37awy");
        }
    }
}
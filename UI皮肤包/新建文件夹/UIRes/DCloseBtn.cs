/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DCloseBtn : GButton
    {
        public Controller button;
        public GImage Img055i;
        public GImage Img1i31;
        public const string URL = "ui://jk0io98jkn5ztv";

        public static DCloseBtn CreateInstance()
        {
            return (DCloseBtn)UIPackage.CreateObject("UIRes", "DCloseBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img055i = (GImage)GetChild("Img055i");
            Img1i31 = (GImage)GetChild("Img1i31");
        }
    }
}
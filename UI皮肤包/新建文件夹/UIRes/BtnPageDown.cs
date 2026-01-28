/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPageDown : GButton
    {
        public Controller button;
        public GImage Img40ca;
        public GImage Img54le;
        public const string URL = "ui://jk0io98jy8637";

        public static BtnPageDown CreateInstance()
        {
            return (BtnPageDown)UIPackage.CreateObject("UIRes", "BtnPageDown");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img40ca = (GImage)GetChild("Img40ca");
            Img54le = (GImage)GetChild("Img54le");
        }
    }
}
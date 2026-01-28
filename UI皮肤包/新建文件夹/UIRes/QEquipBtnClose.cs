/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class QEquipBtnClose : GButton
    {
        public Controller button;
        public GImage Img0wvn;
        public GImage Img1o8b;
        public const string URL = "ui://jk0io98jv9b1fv";

        public static QEquipBtnClose CreateInstance()
        {
            return (QEquipBtnClose)UIPackage.CreateObject("UIRes", "QEquipBtnClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0wvn = (GImage)GetChild("Img0wvn");
            Img1o8b = (GImage)GetChild("Img1o8b");
        }
    }
}
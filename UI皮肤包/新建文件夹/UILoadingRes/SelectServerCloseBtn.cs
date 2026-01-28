/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class SelectServerCloseBtn : GButton
    {
        public Controller button;
        public GImage Img02lx;
        public GImage Img1smm;
        public const string URL = "ui://us2ut3jfr7r81s";

        public static SelectServerCloseBtn CreateInstance()
        {
            return (SelectServerCloseBtn)UIPackage.CreateObject("UILoadingRes", "SelectServerCloseBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img02lx = (GImage)GetChild("Img02lx");
            Img1smm = (GImage)GetChild("Img1smm");
        }
    }
}
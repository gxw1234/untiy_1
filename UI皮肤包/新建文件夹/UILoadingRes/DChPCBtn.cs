/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DChPCBtn : GButton
    {
        public Controller button;
        public GImage Img26525c;
        public GImage Img266se3;
        public GTextField title;
        public const string URL = "ui://us2ut3jfr7r825";

        public static DChPCBtn CreateInstance()
        {
            return (DChPCBtn)UIPackage.CreateObject("UILoadingRes", "DChPCBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img26525c = (GImage)GetChild("Img26525c");
            Img266se3 = (GImage)GetChild("Img266se3");
            title = (GTextField)GetChild("title");
        }
    }
}
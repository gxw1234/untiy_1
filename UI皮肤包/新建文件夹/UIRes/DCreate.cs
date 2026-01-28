/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DCreate : GButton
    {
        public Controller button;
        public GImage Img14odc;
        public GImage Img15j20;
        public const string URL = "ui://jk0io98j7ynym";

        public static DCreate CreateInstance()
        {
            return (DCreate)UIPackage.CreateObject("UIRes", "DCreate");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img14odc = (GImage)GetChild("Img14odc");
            Img15j20 = (GImage)GetChild("Img15j20");
        }
    }
}
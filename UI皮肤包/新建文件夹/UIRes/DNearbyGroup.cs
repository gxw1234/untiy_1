/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DNearbyGroup : GButton
    {
        public Controller button;
        public GImage Img2951f6;
        public GImage Img294p3l;
        public const string URL = "ui://jk0io98jkn5ztu";

        public static DNearbyGroup CreateInstance()
        {
            return (DNearbyGroup)UIPackage.CreateObject("UIRes", "DNearbyGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2951f6 = (GImage)GetChild("Img2951f6");
            Img294p3l = (GImage)GetChild("Img294p3l");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMyGroup : GButton
    {
        public Controller button;
        public GImage Img293iq8;
        public GImage Img292tmg;
        public const string URL = "ui://jk0io98jkn5zts";

        public static DMyGroup CreateInstance()
        {
            return (DMyGroup)UIPackage.CreateObject("UIRes", "DMyGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img293iq8 = (GImage)GetChild("Img293iq8");
            Img292tmg = (GImage)GetChild("Img292tmg");
        }
    }
}
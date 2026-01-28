/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBack : GButton
    {
        public Controller button;
        public GImage Img181l8;
        public GImage Img19ti1;
        public const string URL = "ui://jk0io98j63uu0";

        public static DBack CreateInstance()
        {
            return (DBack)UIPackage.CreateObject("UIRes", "DBack");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img181l8 = (GImage)GetChild("Img181l8");
            Img19ti1 = (GImage)GetChild("Img19ti1");
        }
    }
}
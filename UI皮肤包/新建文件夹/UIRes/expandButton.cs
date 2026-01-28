/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class expandButton : GButton
    {
        public Controller button;
        public GImage Img18148d;
        public GImage Img182i4i;
        public const string URL = "ui://jk0io98jd8bbt";

        public static expandButton CreateInstance()
        {
            return (expandButton)UIPackage.CreateObject("UIRes", "expandButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img18148d = (GImage)GetChild("Img18148d");
            Img182i4i = (GImage)GetChild("Img182i4i");
        }
    }
}
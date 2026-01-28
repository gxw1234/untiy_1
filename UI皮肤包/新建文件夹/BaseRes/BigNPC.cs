/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BigNPC : GButton
    {
        public Controller button;
        public GImage Img176u7l;
        public GImage Img177d67;
        public const string URL = "ui://use7blkkqgn276";

        public static BigNPC CreateInstance()
        {
            return (BigNPC)UIPackage.CreateObject("BaseRes", "BigNPC");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176u7l = (GImage)GetChild("Img176u7l");
            Img177d67 = (GImage)GetChild("Img177d67");
        }
    }
}
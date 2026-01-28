/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DDelete : GButton
    {
        public Controller button;
        public GImage Img322yb;
        public GImage Img33i17;
        public const string URL = "ui://jk0io98j201jx";

        public static DDelete CreateInstance()
        {
            return (DDelete)UIPackage.CreateObject("UIRes", "DDelete");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img322yb = (GImage)GetChild("Img322yb");
            Img33i17 = (GImage)GetChild("Img33i17");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class LeftTurnBtn1 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://use7blkky2clgvn2x6";

        public static LeftTurnBtn1 CreateInstance()
        {
            return (LeftTurnBtn1)UIPackage.CreateObject("BaseRes", "LeftTurnBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ConfirmBtn1 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://use7blkky2clgvn2x4";

        public static ConfirmBtn1 CreateInstance()
        {
            return (ConfirmBtn1)UIPackage.CreateObject("BaseRes", "ConfirmBtn1");
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
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBGroup : GButton
    {
        public Controller button;
        public GImage Img305nbl;
        public GImage Img304hk5;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21kl";

        public static DRBGroup CreateInstance()
        {
            return (DRBGroup)UIPackage.CreateObject("UIRes", "DRBGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305nbl = (GImage)GetChild("Img305nbl");
            Img304hk5 = (GImage)GetChild("Img304hk5");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
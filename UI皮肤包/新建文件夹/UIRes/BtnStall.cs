/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnStall : GButton
    {
        public Controller button;
        public GImage Img366fwn;
        public GImage Img367n67;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21gg";

        public static BtnStall CreateInstance()
        {
            return (BtnStall)UIPackage.CreateObject("UIRes", "BtnStall");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img366fwn = (GImage)GetChild("Img366fwn");
            Img367n67 = (GImage)GetChild("Img367n67");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
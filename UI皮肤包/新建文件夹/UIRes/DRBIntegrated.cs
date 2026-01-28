/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBIntegrated : GButton
    {
        public Controller button;
        public GImage Img305832;
        public GImage Img3048y0;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21kg";

        public static DRBIntegrated CreateInstance()
        {
            return (DRBIntegrated)UIPackage.CreateObject("UIRes", "DRBIntegrated");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305832 = (GImage)GetChild("Img305832");
            Img3048y0 = (GImage)GetChild("Img3048y0");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
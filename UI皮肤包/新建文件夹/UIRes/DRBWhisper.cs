/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBWhisper : GButton
    {
        public Controller button;
        public GImage Img305uhx;
        public GImage Img3041va;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21kj";

        public static DRBWhisper CreateInstance()
        {
            return (DRBWhisper)UIPackage.CreateObject("UIRes", "DRBWhisper");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305uhx = (GImage)GetChild("Img305uhx");
            Img3041va = (GImage)GetChild("Img3041va");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
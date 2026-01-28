/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnAllAree : GButton
    {
        public Controller button;
        public GImage Img191w6l;
        public GImage Img192tc6;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17z";

        public static BtnAllAree CreateInstance()
        {
            return (BtnAllAree)UIPackage.CreateObject("UIRes", "BtnAllAree");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191w6l = (GImage)GetChild("Img191w6l");
            Img192tc6 = (GImage)GetChild("Img192tc6");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
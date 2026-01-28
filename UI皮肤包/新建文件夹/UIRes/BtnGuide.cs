/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnGuide : GButton
    {
        public Controller button;
        public GImage Img18464s;
        public GImage Img1833y5;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jehx10";

        public static BtnGuide CreateInstance()
        {
            return (BtnGuide)UIPackage.CreateObject("UIRes", "BtnGuide");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img18464s = (GImage)GetChild("Img18464s");
            Img1833y5 = (GImage)GetChild("Img1833y5");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
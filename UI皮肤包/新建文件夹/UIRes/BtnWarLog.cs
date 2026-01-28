/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnWarLog : GButton
    {
        public Controller button;
        public GImage Img1912it;
        public GImage Img19276b;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z187";

        public static BtnWarLog CreateInstance()
        {
            return (BtnWarLog)UIPackage.CreateObject("UIRes", "BtnWarLog");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1912it = (GImage)GetChild("Img1912it");
            Img19276b = (GImage)GetChild("Img19276b");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDelePlay : GButton
    {
        public Controller button;
        public GImage Img191w5x;
        public GImage Img192g51;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17o";

        public static BtnDelePlay CreateInstance()
        {
            return (BtnDelePlay)UIPackage.CreateObject("UIRes", "BtnDelePlay");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191w5x = (GImage)GetChild("Img191w5x");
            Img192g51 = (GImage)GetChild("Img192g51");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
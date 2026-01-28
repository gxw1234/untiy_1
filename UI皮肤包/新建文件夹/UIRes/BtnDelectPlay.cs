/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDelectPlay : GButton
    {
        public Controller button;
        public GImage Img191p30;
        public GImage Img192c1k;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17q";

        public static BtnDelectPlay CreateInstance()
        {
            return (BtnDelectPlay)UIPackage.CreateObject("UIRes", "BtnDelectPlay");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191p30 = (GImage)GetChild("Img191p30");
            Img192c1k = (GImage)GetChild("Img192c1k");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
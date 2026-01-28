/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnAllRefuse : GButton
    {
        public Controller button;
        public GImage Img191n35;
        public GImage Img192f02;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z182";

        public static BtnAllRefuse CreateInstance()
        {
            return (BtnAllRefuse)UIPackage.CreateObject("UIRes", "BtnAllRefuse");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img191n35 = (GImage)GetChild("Img191n35");
            Img192f02 = (GImage)GetChild("Img192f02");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
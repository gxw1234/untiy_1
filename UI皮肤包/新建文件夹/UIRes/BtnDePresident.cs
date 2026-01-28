/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDePresident : GButton
    {
        public Controller button;
        public GImage Img176d02;
        public GImage Img177uu4;
        public const string URL = "ui://jk0io98jkn5z173";

        public static BtnDePresident CreateInstance()
        {
            return (BtnDePresident)UIPackage.CreateObject("UIRes", "BtnDePresident");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176d02 = (GImage)GetChild("Img176d02");
            Img177uu4 = (GImage)GetChild("Img177uu4");
        }
    }
}
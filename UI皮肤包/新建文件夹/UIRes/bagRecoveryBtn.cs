/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class bagRecoveryBtn : GButton
    {
        public Controller button;
        public GImage Img79720i;
        public GImage Img7983ra;
        public const string URL = "ui://jk0io98jv9b150";

        public static bagRecoveryBtn CreateInstance()
        {
            return (bagRecoveryBtn)UIPackage.CreateObject("UIRes", "bagRecoveryBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img79720i = (GImage)GetChild("Img79720i");
            Img7983ra = (GImage)GetChild("Img7983ra");
        }
    }
}
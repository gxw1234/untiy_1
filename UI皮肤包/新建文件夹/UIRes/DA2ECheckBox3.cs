/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox3 : GButton
    {
        public Controller button;
        public GImage Img41508p;
        public GImage Img41681w;
        public const string URL = "ui://jk0io98jkn5zwc";

        public static DA2ECheckBox3 CreateInstance()
        {
            return (DA2ECheckBox3)UIPackage.CreateObject("UIRes", "DA2ECheckBox3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img41508p = (GImage)GetChild("Img41508p");
            Img41681w = (GImage)GetChild("Img41681w");
        }
    }
}
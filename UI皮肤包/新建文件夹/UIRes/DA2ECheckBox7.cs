/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox7 : GButton
    {
        public Controller button;
        public GImage Img415kr4;
        public GImage Img416ql3;
        public const string URL = "ui://jk0io98jkn5zwh";

        public static DA2ECheckBox7 CreateInstance()
        {
            return (DA2ECheckBox7)UIPackage.CreateObject("UIRes", "DA2ECheckBox7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415kr4 = (GImage)GetChild("Img415kr4");
            Img416ql3 = (GImage)GetChild("Img416ql3");
        }
    }
}
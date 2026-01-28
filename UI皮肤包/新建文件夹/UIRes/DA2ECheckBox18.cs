/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox18 : GButton
    {
        public Controller button;
        public GImage Img415p5c;
        public GImage Img4168lg;
        public const string URL = "ui://jk0io98jkn5zww";

        public static DA2ECheckBox18 CreateInstance()
        {
            return (DA2ECheckBox18)UIPackage.CreateObject("UIRes", "DA2ECheckBox18");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415p5c = (GImage)GetChild("Img415p5c");
            Img4168lg = (GImage)GetChild("Img4168lg");
        }
    }
}
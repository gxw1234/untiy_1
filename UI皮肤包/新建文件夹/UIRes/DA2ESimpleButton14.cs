/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton14 : GButton
    {
        public Controller button;
        public GImage Img77wm5;
        public GImage Img78l7s;
        public const string URL = "ui://jk0io98jk02tn1um";

        public static DA2ESimpleButton14 CreateInstance()
        {
            return (DA2ESimpleButton14)UIPackage.CreateObject("UIRes", "DA2ESimpleButton14");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img77wm5 = (GImage)GetChild("Img77wm5");
            Img78l7s = (GImage)GetChild("Img78l7s");
        }
    }
}
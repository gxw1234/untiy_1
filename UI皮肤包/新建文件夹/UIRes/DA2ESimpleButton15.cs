/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton15 : GButton
    {
        public Controller button;
        public GImage Img758j4;
        public GImage Img76y05;
        public const string URL = "ui://jk0io98jk02tn1un";

        public static DA2ESimpleButton15 CreateInstance()
        {
            return (DA2ESimpleButton15)UIPackage.CreateObject("UIRes", "DA2ESimpleButton15");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img758j4 = (GImage)GetChild("Img758j4");
            Img76y05 = (GImage)GetChild("Img76y05");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton11 : GButton
    {
        public Controller button;
        public GImage Img265x4h;
        public GImage Img266jdl;
        public GTextField ChatEdit43;
        public const string URL = "ui://jk0io98jkn5zu9";

        public static DA2ESimpleButton11 CreateInstance()
        {
            return (DA2ESimpleButton11)UIPackage.CreateObject("UIRes", "DA2ESimpleButton11");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265x4h = (GImage)GetChild("Img265x4h");
            Img266jdl = (GImage)GetChild("Img266jdl");
            ChatEdit43 = (GTextField)GetChild("ChatEdit43");
        }
    }
}
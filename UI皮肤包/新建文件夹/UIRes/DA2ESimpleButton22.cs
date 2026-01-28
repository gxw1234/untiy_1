/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton22 : GButton
    {
        public Controller button;
        public GImage Img265g6y;
        public GImage Img266100;
        public GTextField ChatEdit60;
        public const string URL = "ui://jk0io98jkn5ztg";

        public static DA2ESimpleButton22 CreateInstance()
        {
            return (DA2ESimpleButton22)UIPackage.CreateObject("UIRes", "DA2ESimpleButton22");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265g6y = (GImage)GetChild("Img265g6y");
            Img266100 = (GImage)GetChild("Img266100");
            ChatEdit60 = (GTextField)GetChild("ChatEdit60");
        }
    }
}
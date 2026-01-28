/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton17 : GButton
    {
        public Controller button;
        public GImage Img265s33;
        public GImage Img266y5w;
        public GTextField ChatEdit44;
        public const string URL = "ui://jk0io98jkn5zua";

        public static DA2ESimpleButton17 CreateInstance()
        {
            return (DA2ESimpleButton17)UIPackage.CreateObject("UIRes", "DA2ESimpleButton17");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265s33 = (GImage)GetChild("Img265s33");
            Img266y5w = (GImage)GetChild("Img266y5w");
            ChatEdit44 = (GTextField)GetChild("ChatEdit44");
        }
    }
}
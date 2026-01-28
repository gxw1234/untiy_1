/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton5 : GButton
    {
        public Controller button;
        public GImage n1;
        public GImage n0;
        public const string URL = "ui://jk0io98js46aa";

        public static DA2ETabButton5 CreateInstance()
        {
            return (DA2ETabButton5)UIPackage.CreateObject("UIRes", "DA2ETabButton5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n1 = (GImage)GetChild("n1");
            n0 = (GImage)GetChild("n0");
        }
    }
}
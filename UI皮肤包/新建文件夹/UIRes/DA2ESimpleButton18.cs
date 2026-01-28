/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton18 : GButton
    {
        public Controller button;
        public GImage Img265nc0;
        public GImage Img266446;
        public GTextField ChatEdit45;
        public const string URL = "ui://jk0io98jkn5ztx";

        public static DA2ESimpleButton18 CreateInstance()
        {
            return (DA2ESimpleButton18)UIPackage.CreateObject("UIRes", "DA2ESimpleButton18");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265nc0 = (GImage)GetChild("Img265nc0");
            Img266446 = (GImage)GetChild("Img266446");
            ChatEdit45 = (GTextField)GetChild("ChatEdit45");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton19 : GButton
    {
        public Controller button;
        public GImage Img2650be;
        public GImage Img26658o;
        public GTextField ChatEdit48;
        public const string URL = "ui://jk0io98jkn5zty";

        public static DA2ESimpleButton19 CreateInstance()
        {
            return (DA2ESimpleButton19)UIPackage.CreateObject("UIRes", "DA2ESimpleButton19");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2650be = (GImage)GetChild("Img2650be");
            Img26658o = (GImage)GetChild("Img26658o");
            ChatEdit48 = (GTextField)GetChild("ChatEdit48");
        }
    }
}
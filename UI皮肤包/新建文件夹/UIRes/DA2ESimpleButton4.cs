/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton4 : GButton
    {
        public Controller button;
        public GImage Img2654ht;
        public GImage Img266045;
        public GTextField ChatEdit55;
        public const string URL = "ui://jk0io98jkn5ztj";

        public static DA2ESimpleButton4 CreateInstance()
        {
            return (DA2ESimpleButton4)UIPackage.CreateObject("UIRes", "DA2ESimpleButton4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2654ht = (GImage)GetChild("Img2654ht");
            Img266045 = (GImage)GetChild("Img266045");
            ChatEdit55 = (GTextField)GetChild("ChatEdit55");
        }
    }
}
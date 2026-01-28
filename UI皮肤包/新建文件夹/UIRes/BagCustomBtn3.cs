/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagCustomBtn3 : GButton
    {
        public Controller button;
        public GImage Img101se;
        public GImage Img111o6;
        public GTextField ChatEdit4;
        public const string URL = "ui://jk0io98jv9b15h";

        public static BagCustomBtn3 CreateInstance()
        {
            return (BagCustomBtn3)UIPackage.CreateObject("UIRes", "BagCustomBtn3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img101se = (GImage)GetChild("Img101se");
            Img111o6 = (GImage)GetChild("Img111o6");
            ChatEdit4 = (GTextField)GetChild("ChatEdit4");
        }
    }
}
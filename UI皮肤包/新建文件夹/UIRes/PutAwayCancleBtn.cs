/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayCancleBtn : GButton
    {
        public Controller button;
        public GImage Img26530o;
        public GImage Img2662b2;
        public GTextField ChatEdit41;
        public const string URL = "ui://jk0io98jkn5z12e";

        public static PutAwayCancleBtn CreateInstance()
        {
            return (PutAwayCancleBtn)UIPackage.CreateObject("UIRes", "PutAwayCancleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img26530o = (GImage)GetChild("Img26530o");
            Img2662b2 = (GImage)GetChild("Img2662b2");
            ChatEdit41 = (GTextField)GetChild("ChatEdit41");
        }
    }
}
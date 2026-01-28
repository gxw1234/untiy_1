/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayBuyBtn : GButton
    {
        public Controller button;
        public GImage Img265ky3;
        public GImage Img26645k;
        public GTextField ChatEdit42;
        public const string URL = "ui://jk0io98jkn5z12f";

        public static PutAwayBuyBtn CreateInstance()
        {
            return (PutAwayBuyBtn)UIPackage.CreateObject("UIRes", "PutAwayBuyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265ky3 = (GImage)GetChild("Img265ky3");
            Img26645k = (GImage)GetChild("Img26645k");
            ChatEdit42 = (GTextField)GetChild("ChatEdit42");
        }
    }
}
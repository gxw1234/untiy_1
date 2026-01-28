/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CompeteAddPriceEditBtn : GButton
    {
        public Controller button;
        public GImage Img625yn5;
        public GImage Img625e02;
        public const string URL = "ui://jk0io98jkn5z135";

        public static CompeteAddPriceEditBtn CreateInstance()
        {
            return (CompeteAddPriceEditBtn)UIPackage.CreateObject("UIRes", "CompeteAddPriceEditBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img625yn5 = (GImage)GetChild("Img625yn5");
            Img625e02 = (GImage)GetChild("Img625e02");
        }
    }
}
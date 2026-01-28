/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagDownBtn : GButton
    {
        public Controller button;
        public GImage Img24t31;
        public GImage Img260b4;
        public const string URL = "ui://jk0io98jj3e21oe";

        public static BagDownBtn CreateInstance()
        {
            return (BagDownBtn)UIPackage.CreateObject("UIRes", "BagDownBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img24t31 = (GImage)GetChild("Img24t31");
            Img260b4 = (GImage)GetChild("Img260b4");
        }
    }
}
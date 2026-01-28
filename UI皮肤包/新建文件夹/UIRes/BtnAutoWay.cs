/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnAutoWay : GButton
    {
        public Controller button;
        public GImage Img463730;
        public GImage Img464764;
        public const string URL = "ui://jk0io98jv9b11j";

        public static BtnAutoWay CreateInstance()
        {
            return (BtnAutoWay)UIPackage.CreateObject("UIRes", "BtnAutoWay");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img463730 = (GImage)GetChild("Img463730");
            Img464764 = (GImage)GetChild("Img464764");
        }
    }
}
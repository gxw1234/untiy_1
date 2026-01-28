/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BtnPageUp : GButton
    {
        public Controller button;
        public GImage Img6g50;
        public GImage Img71y4;
        public const string URL = "ui://use7blkkqgn26o";

        public static BtnPageUp CreateInstance()
        {
            return (BtnPageUp)UIPackage.CreateObject("BaseRes", "BtnPageUp");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img6g50 = (GImage)GetChild("Img6g50");
            Img71y4 = (GImage)GetChild("Img71y4");
        }
    }
}
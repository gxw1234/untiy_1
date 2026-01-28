/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPageUp : GButton
    {
        public Controller button;
        public GImage Img6xd6;
        public GImage Img7y5t;
        public const string URL = "ui://jk0io98jkn5zs7";

        public static BtnPageUp CreateInstance()
        {
            return (BtnPageUp)UIPackage.CreateObject("UIRes", "BtnPageUp");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img6xd6 = (GImage)GetChild("Img6xd6");
            Img7y5t = (GImage)GetChild("Img7y5t");
        }
    }
}
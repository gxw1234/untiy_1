/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagUpBtn : GButton
    {
        public Controller button;
        public GImage Img213g8;
        public GImage Img2342x;
        public const string URL = "ui://jk0io98jj3e21of";

        public static BagUpBtn CreateInstance()
        {
            return (BagUpBtn)UIPackage.CreateObject("UIRes", "BagUpBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img213g8 = (GImage)GetChild("Img213g8");
            Img2342x = (GImage)GetChild("Img2342x");
        }
    }
}
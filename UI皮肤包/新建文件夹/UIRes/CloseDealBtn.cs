/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CloseDealBtn : GButton
    {
        public Controller button;
        public GImage Img076s;
        public GImage Img167h;
        public const string URL = "ui://jk0io98jkn5z18q";

        public static CloseDealBtn CreateInstance()
        {
            return (CloseDealBtn)UIPackage.CreateObject("UIRes", "CloseDealBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img076s = (GImage)GetChild("Img076s");
            Img167h = (GImage)GetChild("Img167h");
        }
    }
}
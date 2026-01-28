/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class NewNpcDCloseBtn : GButton
    {
        public Controller button;
        public GImage Img0e44;
        public GImage Img1ufh;
        public const string URL = "ui://use7blkkqgn26w";

        public static NewNpcDCloseBtn CreateInstance()
        {
            return (NewNpcDCloseBtn)UIPackage.CreateObject("BaseRes", "NewNpcDCloseBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0e44 = (GImage)GetChild("Img0e44");
            Img1ufh = (GImage)GetChild("Img1ufh");
        }
    }
}
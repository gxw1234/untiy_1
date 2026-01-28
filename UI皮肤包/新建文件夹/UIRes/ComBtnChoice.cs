/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComBtnChoice : GButton
    {
        public Controller button;
        public GImage Img415s2d;
        public GImage Img41668w;
        public const string URL = "ui://jk0io98jheq7gvn2vb";

        public static ComBtnChoice CreateInstance()
        {
            return (ComBtnChoice)UIPackage.CreateObject("UIRes", "ComBtnChoice");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415s2d = (GImage)GetChild("Img415s2d");
            Img41668w = (GImage)GetChild("Img41668w");
        }
    }
}
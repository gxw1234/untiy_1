/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ExpBtn : GButton
    {
        public Controller button;
        public GImage Img10b62;
        public GImage Img110us;
        public GTextField ChatEdit10;
        public const string URL = "ui://use7blkkqgn270";

        public static ExpBtn CreateInstance()
        {
            return (ExpBtn)UIPackage.CreateObject("BaseRes", "ExpBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10b62 = (GImage)GetChild("Img10b62");
            Img110us = (GImage)GetChild("Img110us");
            ChatEdit10 = (GTextField)GetChild("ChatEdit10");
        }
    }
}
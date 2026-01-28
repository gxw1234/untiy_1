/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnBoxClose : GButton
    {
        public Controller button;
        public GImage Img0l53;
        public GImage Img1nhw;
        public const string URL = "ui://jk0io98jt786b";

        public static DBtnBoxClose CreateInstance()
        {
            return (DBtnBoxClose)UIPackage.CreateObject("UIRes", "DBtnBoxClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img0l53 = (GImage)GetChild("Img0l53");
            Img1nhw = (GImage)GetChild("Img1nhw");
        }
    }
}
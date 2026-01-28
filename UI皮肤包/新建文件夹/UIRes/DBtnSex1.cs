/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSex1 : GButton
    {
        public Controller button;
        public GImage Img30171;
        public GImage Img316jd;
        public const string URL = "ui://jk0io98j8st6k";

        public static DBtnSex1 CreateInstance()
        {
            return (DBtnSex1)UIPackage.CreateObject("UIRes", "DBtnSex1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img30171 = (GImage)GetChild("Img30171");
            Img316jd = (GImage)GetChild("Img316jd");
        }
    }
}
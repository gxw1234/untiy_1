/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnJob2 : GButton
    {
        public Controller button;
        public GImage Img165uk;
        public GImage Img17i6k;
        public const string URL = "ui://jk0io98jsv16g";

        public static DBtnJob2 CreateInstance()
        {
            return (DBtnJob2)UIPackage.CreateObject("UIRes", "DBtnJob2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img165uk = (GImage)GetChild("Img165uk");
            Img17i6k = (GImage)GetChild("Img17i6k");
        }
    }
}
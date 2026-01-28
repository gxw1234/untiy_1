/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnJob1 : GButton
    {
        public Controller button;
        public GImage Img20j1c;
        public GImage Img21r2l;
        public const string URL = "ui://jk0io98jd0ai4";

        public static DBtnJob1 CreateInstance()
        {
            return (DBtnJob1)UIPackage.CreateObject("UIRes", "DBtnJob1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img20j1c = (GImage)GetChild("Img20j1c");
            Img21r2l = (GImage)GetChild("Img21r2l");
        }
    }
}
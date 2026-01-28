/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSel2 : GButton
    {
        public Controller button;
        public GImage Img43485;
        public GImage Img44j6c;
        public const string URL = "ui://jk0io98j58fxg";

        public static DBtnSel2 CreateInstance()
        {
            return (DBtnSel2)UIPackage.CreateObject("UIRes", "DBtnSel2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img43485 = (GImage)GetChild("Img43485");
            Img44j6c = (GImage)GetChild("Img44j6c");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSel1 : GButton
    {
        public Controller button;
        public GImage Img430o6;
        public GImage Img44o1h;
        public const string URL = "ui://jk0io98j8403o";

        public static DBtnSel1 CreateInstance()
        {
            return (DBtnSel1)UIPackage.CreateObject("UIRes", "DBtnSel1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img430o6 = (GImage)GetChild("Img430o6");
            Img44o1h = (GImage)GetChild("Img44o1h");
        }
    }
}
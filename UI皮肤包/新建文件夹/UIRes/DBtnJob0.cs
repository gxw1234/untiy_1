/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnJob0 : GButton
    {
        public Controller button;
        public GImage Img45wlq;
        public GImage Img46vl0;
        public const string URL = "ui://jk0io98js6571";

        public static DBtnJob0 CreateInstance()
        {
            return (DBtnJob0)UIPackage.CreateObject("UIRes", "DBtnJob0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img45wlq = (GImage)GetChild("Img45wlq");
            Img46vl0 = (GImage)GetChild("Img46vl0");
        }
    }
}
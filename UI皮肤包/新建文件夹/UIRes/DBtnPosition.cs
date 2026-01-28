/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnPosition : GButton
    {
        public Controller button;
        public GImage Img313eq7;
        public GImage Img314w75;
        public const string URL = "ui://jk0io98jj3e21kp";

        public static DBtnPosition CreateInstance()
        {
            return (DBtnPosition)UIPackage.CreateObject("UIRes", "DBtnPosition");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img313eq7 = (GImage)GetChild("Img313eq7");
            Img314w75 = (GImage)GetChild("Img314w75");
        }
    }
}
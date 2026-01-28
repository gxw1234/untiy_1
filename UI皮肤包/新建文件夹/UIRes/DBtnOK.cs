/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnOK : GButton
    {
        public Controller button;
        public GImage Img396bl1;
        public GImage Img397y47;
        public const string URL = "ui://jk0io98jkn5z18z";

        public static DBtnOK CreateInstance()
        {
            return (DBtnOK)UIPackage.CreateObject("UIRes", "DBtnOK");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img396bl1 = (GImage)GetChild("Img396bl1");
            Img397y47 = (GImage)GetChild("Img397y47");
        }
    }
}
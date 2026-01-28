/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnPlusAbil : GButton
    {
        public Controller button;
        public GImage Img140rrh;
        public GImage Img141h4q;
        public const string URL = "ui://jk0io98jj3e21o7";

        public static DBtnPlusAbil CreateInstance()
        {
            return (DBtnPlusAbil)UIPackage.CreateObject("UIRes", "DBtnPlusAbil");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img140rrh = (GImage)GetChild("Img140rrh");
            Img141h4q = (GImage)GetChild("Img141h4q");
        }
    }
}
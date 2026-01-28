/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnGold : GButton
    {
        public Controller button;
        public GImage Img12961o;
        public GImage Img130a32;
        public const string URL = "ui://jk0io98jv9b169";

        public static DBtnGold CreateInstance()
        {
            return (DBtnGold)UIPackage.CreateObject("UIRes", "DBtnGold");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img12961o = (GImage)GetChild("Img12961o");
            Img130a32 = (GImage)GetChild("Img130a32");
        }
    }
}
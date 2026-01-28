/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnfdragree : GButton
    {
        public Controller button;
        public GImage Img286202;
        public GImage Img287wpa;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z15m";

        public static DBtnfdragree CreateInstance()
        {
            return (DBtnfdragree)UIPackage.CreateObject("UIRes", "DBtnfdragree");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286202 = (GImage)GetChild("Img286202");
            Img287wpa = (GImage)GetChild("Img287wpa");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
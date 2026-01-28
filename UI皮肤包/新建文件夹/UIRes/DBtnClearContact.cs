/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnClearContact : GButton
    {
        public Controller button;
        public GImage Img265dh5;
        public GImage Img266o5v;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z153";

        public static DBtnClearContact CreateInstance()
        {
            return (DBtnClearContact)UIPackage.CreateObject("UIRes", "DBtnClearContact");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265dh5 = (GImage)GetChild("Img265dh5");
            Img266o5v = (GImage)GetChild("Img266o5v");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
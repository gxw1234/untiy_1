/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAllDeletRead : GButton
    {
        public Controller button;
        public GImage Img837304;
        public GImage Img8385y5;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zym";

        public static DBtnAllDeletRead CreateInstance()
        {
            return (DBtnAllDeletRead)UIPackage.CreateObject("UIRes", "DBtnAllDeletRead");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img837304 = (GImage)GetChild("Img837304");
            Img8385y5 = (GImage)GetChild("Img8385y5");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
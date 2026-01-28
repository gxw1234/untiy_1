/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnfdrrefuse : GButton
    {
        public Controller button;
        public GImage Img286cgf;
        public GImage Img287rk5;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z15n";

        public static DBtnfdrrefuse CreateInstance()
        {
            return (DBtnfdrrefuse)UIPackage.CreateObject("UIRes", "DBtnfdrrefuse");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286cgf = (GImage)GetChild("Img286cgf");
            Img287rk5 = (GImage)GetChild("Img287rk5");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
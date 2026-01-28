/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFDBlackDelete : GButton
    {
        public Controller button;
        public GImage Img286ij8;
        public GImage Img287ucg;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z15p";

        public static DBtnFDBlackDelete CreateInstance()
        {
            return (DBtnFDBlackDelete)UIPackage.CreateObject("UIRes", "DBtnFDBlackDelete");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img286ij8 = (GImage)GetChild("Img286ij8");
            Img287ucg = (GImage)GetChild("Img287ucg");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
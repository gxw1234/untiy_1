/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFDBlackRecovery : GButton
    {
        public Controller button;
        public GImage Img2860x7;
        public GImage Img287kv1;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z15o";

        public static DBtnFDBlackRecovery CreateInstance()
        {
            return (DBtnFDBlackRecovery)UIPackage.CreateObject("UIRes", "DBtnFDBlackRecovery");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2860x7 = (GImage)GetChild("Img2860x7");
            Img287kv1 = (GImage)GetChild("Img287kv1");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
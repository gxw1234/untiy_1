/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnAllExtract : GButton
    {
        public Controller button;
        public GImage Img8377r3;
        public GImage Img838jo7;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zyn";

        public static DBtnAllExtract CreateInstance()
        {
            return (DBtnAllExtract)UIPackage.CreateObject("UIRes", "DBtnAllExtract");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8377r3 = (GImage)GetChild("Img8377r3");
            Img838jo7 = (GImage)GetChild("Img838jo7");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
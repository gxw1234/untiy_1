/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDBlackItem : GButton
    {
        public Controller button;
        public GImage Img2734v7;
        public GImage Img3032d1;
        public DBtnFDBlackRecovery DBtnFDBlackRecovery;
        public DBtnFDBlackDelete DBtnFDBlackDelete;
        public GTextField ChatEdit13;
        public GTextField ChatEdit14;
        public GTextField ChatEdit15;
        public const string URL = "ui://jk0io98jkn5z15q";

        public static DFDBlackItem CreateInstance()
        {
            return (DFDBlackItem)UIPackage.CreateObject("UIRes", "DFDBlackItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2734v7 = (GImage)GetChild("Img2734v7");
            Img3032d1 = (GImage)GetChild("Img3032d1");
            DBtnFDBlackRecovery = (DBtnFDBlackRecovery)GetChild("DBtnFDBlackRecovery");
            DBtnFDBlackDelete = (DBtnFDBlackDelete)GetChild("DBtnFDBlackDelete");
            ChatEdit13 = (GTextField)GetChild("ChatEdit13");
            ChatEdit14 = (GTextField)GetChild("ChatEdit14");
            ChatEdit15 = (GTextField)GetChild("ChatEdit15");
        }
    }
}
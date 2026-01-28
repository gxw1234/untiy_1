/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class btnPayItem : GButton
    {
        public Controller button;
        public GImage Foucs;
        public GTextField GaTapeText;
        public const string URL = "ui://jk0io98jkdgun1qc";

        public static btnPayItem CreateInstance()
        {
            return (btnPayItem)UIPackage.CreateObject("UIRes", "btnPayItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Foucs = (GImage)GetChild("Foucs");
            GaTapeText = (GTextField)GetChild("GaTapeText");
        }
    }
}
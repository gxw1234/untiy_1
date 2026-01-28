/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox8 : GButton
    {
        public Controller button;
        public GImage Img4157ps;
        public GImage Img416uke;
        public const string URL = "ui://jk0io98jkn5zwg";

        public static DA2ECheckBox8 CreateInstance()
        {
            return (DA2ECheckBox8)UIPackage.CreateObject("UIRes", "DA2ECheckBox8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4157ps = (GImage)GetChild("Img4157ps");
            Img416uke = (GImage)GetChild("Img416uke");
        }
    }
}
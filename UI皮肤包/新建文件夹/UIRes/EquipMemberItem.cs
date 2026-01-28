/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class EquipMemberItem : GButton
    {
        public Controller expanded;
        public Controller leaf;
        public Controller button;
        public GImage Img601bni;
        public GImage Img60200d;
        public DA2ECheckBox1 DA2ECheckBox1;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5z13j";

        public static EquipMemberItem CreateInstance()
        {
            return (EquipMemberItem)UIPackage.CreateObject("UIRes", "EquipMemberItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            expanded = GetController("expanded");
            leaf = GetController("leaf");
            button = GetController("button");
            Img601bni = (GImage)GetChild("Img601bni");
            Img60200d = (GImage)GetChild("Img60200d");
            DA2ECheckBox1 = (DA2ECheckBox1)GetChild("DA2ECheckBox1");
            title = (GTextField)GetChild("title");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ERadioButtonPro1 : GButton
    {
        public Controller expanded;
        public Controller leaf;
        public Controller button;
        public GImage Img626c2w;
        public DA2ECheckBox2 DA2ECheckBox2;
        public GImage DA2EIMAGE19;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5z13i";

        public static DA2ERadioButtonPro1 CreateInstance()
        {
            return (DA2ERadioButtonPro1)UIPackage.CreateObject("UIRes", "DA2ERadioButtonPro1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            expanded = GetController("expanded");
            leaf = GetController("leaf");
            button = GetController("button");
            Img626c2w = (GImage)GetChild("Img626c2w");
            DA2ECheckBox2 = (DA2ECheckBox2)GetChild("DA2ECheckBox2");
            DA2EIMAGE19 = (GImage)GetChild("DA2EIMAGE19");
            title = (GTextField)GetChild("title");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage6 : GComponent
    {
        public GImage DA2EIMAGE1;
        public DA2ECheckBox1 DA2ECheckBox1;
        public GTextField ChatEdit44;
        public role role;
        public const string URL = "ui://jk0io98jj3e21er";

        public static DA2EPage6 CreateInstance()
        {
            return (DA2EPage6)UIPackage.CreateObject("UIRes", "DA2EPage6");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DA2ECheckBox1 = (DA2ECheckBox1)GetChild("DA2ECheckBox1");
            ChatEdit44 = (GTextField)GetChild("ChatEdit44");
            role = (role)GetChild("role");
        }
    }
}
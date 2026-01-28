/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LogItem1 : GComponent
    {
        public DA2EWindow16 DA2EWindow16;
        public GTextField EditText;
        public DA2ECheckBox32 DA2ECheckBox32;
        public DA2ECheckBox33 DA2ECheckBox33;
        public const string URL = "ui://jk0io98jkn5zyy";

        public static LogItem1 CreateInstance()
        {
            return (LogItem1)UIPackage.CreateObject("UIRes", "LogItem1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow16 = (DA2EWindow16)GetChild("DA2EWindow16");
            EditText = (GTextField)GetChild("EditText");
            DA2ECheckBox32 = (DA2ECheckBox32)GetChild("DA2ECheckBox32");
            DA2ECheckBox33 = (DA2ECheckBox33)GetChild("DA2ECheckBox33");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LogItem : GComponent
    {
        public GTextField EditLogTxt;
        public DA2ESimpleButton7 DA2ESimpleButton7;
        public DA2ECheckBox30 DA2ECheckBox30;
        public DA2ECheckBox31 DA2ECheckBox31;
        public const string URL = "ui://jk0io98jkn5zyx";

        public static LogItem CreateInstance()
        {
            return (LogItem)UIPackage.CreateObject("UIRes", "LogItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            EditLogTxt = (GTextField)GetChild("EditLogTxt");
            DA2ESimpleButton7 = (DA2ESimpleButton7)GetChild("DA2ESimpleButton7");
            DA2ECheckBox30 = (DA2ECheckBox30)GetChild("DA2ECheckBox30");
            DA2ECheckBox31 = (DA2ECheckBox31)GetChild("DA2ECheckBox31");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LogItem2 : GComponent
    {
        public DA2EWindow16 DA2EWindow16;
        public GTextField title;
        public DA2ECheckBox33 SelectBtn;
        public const string URL = "ui://jk0io98jmh4sgvn2wp";

        public static LogItem2 CreateInstance()
        {
            return (LogItem2)UIPackage.CreateObject("UIRes", "LogItem2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow16 = (DA2EWindow16)GetChild("DA2EWindow16");
            title = (GTextField)GetChild("title");
            SelectBtn = (DA2ECheckBox33)GetChild("SelectBtn");
        }
    }
}
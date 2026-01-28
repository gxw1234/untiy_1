/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskTxt : GComponent
    {
        public GRichTextField Txt;
        public const string URL = "ui://jk0io98jv9b19k";

        public static TaskTxt CreateInstance()
        {
            return (TaskTxt)UIPackage.CreateObject("UIRes", "TaskTxt");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Txt = (GRichTextField)GetChild("Txt");
        }
    }
}
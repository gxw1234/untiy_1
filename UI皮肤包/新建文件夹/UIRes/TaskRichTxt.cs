/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskRichTxt : GComponent
    {
        public GRichTextField title;
        public const string URL = "ui://jk0io98jkwfl4";

        public static TaskRichTxt CreateInstance()
        {
            return (TaskRichTxt)UIPackage.CreateObject("UIRes", "TaskRichTxt");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            title = (GRichTextField)GetChild("title");
        }
    }
}
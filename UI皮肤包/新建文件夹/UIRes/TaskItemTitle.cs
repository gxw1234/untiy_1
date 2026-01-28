/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskItemTitle : GComponent
    {
        public GRichTextField title;
        public const string URL = "ui://jk0io98jv9b19h";

        public static TaskItemTitle CreateInstance()
        {
            return (TaskItemTitle)UIPackage.CreateObject("UIRes", "TaskItemTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            title = (GRichTextField)GetChild("title");
        }
    }
}
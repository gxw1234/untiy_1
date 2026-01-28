/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskPlayImg : GComponent
    {
        public GLoader load;
        public GRichTextField title;
        public const string URL = "ui://jk0io98jv9b19i";

        public static TaskPlayImg CreateInstance()
        {
            return (TaskPlayImg)UIPackage.CreateObject("UIRes", "TaskPlayImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
            title = (GRichTextField)GetChild("title");
        }
    }
}
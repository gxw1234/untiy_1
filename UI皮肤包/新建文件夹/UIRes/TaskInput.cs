/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskInput : GComponent
    {
        public GTextInput InputItem;
        public const string URL = "ui://jk0io98jv9b19c";

        public static TaskInput CreateInstance()
        {
            return (TaskInput)UIPackage.CreateObject("UIRes", "TaskInput");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            InputItem = (GTextInput)GetChild("InputItem");
        }
    }
}
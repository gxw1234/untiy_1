/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskItemBox : GComponent
    {
        public GLoader bg;
        public GLoader item;
        public GTextField itemCount;
        public const string URL = "ui://jk0io98jv9b19d";

        public static TaskItemBox CreateInstance()
        {
            return (TaskItemBox)UIPackage.CreateObject("UIRes", "TaskItemBox");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GLoader)GetChild("bg");
            item = (GLoader)GetChild("item");
            itemCount = (GTextField)GetChild("itemCount");
        }
    }
}
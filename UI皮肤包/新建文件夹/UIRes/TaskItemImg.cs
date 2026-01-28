/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskItemImg : GComponent
    {
        public GLoader img;
        public const string URL = "ui://jk0io98jv9b19f";

        public static TaskItemImg CreateInstance()
        {
            return (TaskItemImg)UIPackage.CreateObject("UIRes", "TaskItemImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            img = (GLoader)GetChild("img");
        }
    }
}
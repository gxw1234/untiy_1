/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskPlayImgEx : GComponent
    {
        public GLoader load;
        public const string URL = "ui://jk0io98jv9b19j";

        public static TaskPlayImgEx CreateInstance()
        {
            return (TaskPlayImgEx)UIPackage.CreateObject("UIRes", "TaskPlayImgEx");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class JinDuTiao_ScheduleCopntUI : GComponent
    {
        public GImage bg;
        public GProgressBar ScheduleProg;
        public GTextField ScheduleEdit;
        public const string URL = "ui://up3anxyrr7r84";

        public static JinDuTiao_ScheduleCopntUI CreateInstance()
        {
            return (JinDuTiao_ScheduleCopntUI)UIPackage.CreateObject("UILoading", "进度条_ScheduleCopntUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            ScheduleProg = (GProgressBar)GetChild("ScheduleProg");
            ScheduleEdit = (GTextField)GetChild("ScheduleEdit");
        }
    }
}
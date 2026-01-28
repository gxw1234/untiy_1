/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskImg : GComponent
    {
        public GLoader load;
        public GRichTextField title0;
        public GRichTextField title1;
        public GRichTextField title2;
        public GRichTextField title3;
        public const string URL = "ui://jk0io98jv9b199";

        public static TaskImg CreateInstance()
        {
            return (TaskImg)UIPackage.CreateObject("UIRes", "TaskImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
            title0 = (GRichTextField)GetChild("title0");
            title1 = (GRichTextField)GetChild("title1");
            title2 = (GRichTextField)GetChild("title2");
            title3 = (GRichTextField)GetChild("title3");
        }
    }
}
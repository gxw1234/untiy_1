/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class taskitem : GComponent
    {
        public GRichTextField taskmsg;
        public GLoader bg;
        public GLoader title;
        public const string URL = "ui://jk0io98jv9b19l";

        public static taskitem CreateInstance()
        {
            return (taskitem)UIPackage.CreateObject("UIRes", "taskitem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            taskmsg = (GRichTextField)GetChild("taskmsg");
            bg = (GLoader)GetChild("bg");
            title = (GLoader)GetChild("title");
        }
    }
}
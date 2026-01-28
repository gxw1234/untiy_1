/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskImgNum : GComponent
    {
        public GLoader Item;
        public const string URL = "ui://jk0io98jv9b19b";

        public static TaskImgNum CreateInstance()
        {
            return (TaskImgNum)UIPackage.CreateObject("UIRes", "TaskImgNum");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
        }
    }
}
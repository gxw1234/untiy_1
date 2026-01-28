/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TaskItemCell : GButton
    {
        public Controller button;
        public GImage Img1861t4;
        public GTextField EditItemInfo;
        public GTextField EditCostInfo;
        public GTextField EditLastingInfo;
        public const string URL = "ui://jk0io98jv9b19e";

        public static TaskItemCell CreateInstance()
        {
            return (TaskItemCell)UIPackage.CreateObject("UIRes", "TaskItemCell");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1861t4 = (GImage)GetChild("Img1861t4");
            EditItemInfo = (GTextField)GetChild("EditItemInfo");
            EditCostInfo = (GTextField)GetChild("EditCostInfo");
            EditLastingInfo = (GTextField)GetChild("EditLastingInfo");
        }
    }
}
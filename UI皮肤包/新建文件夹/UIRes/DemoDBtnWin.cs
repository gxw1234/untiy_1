/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DemoDBtnWin : GComponent
    {
        public DemoRoleInfo DemoRoleInfo;
        public DemoReturnBox DemoReturnBox;
        public const string URL = "ui://jk0io98jgcp1n1q1";

        public static DemoDBtnWin CreateInstance()
        {
            return (DemoDBtnWin)UIPackage.CreateObject("UIRes", "DemoDBtnWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DemoRoleInfo = (DemoRoleInfo)GetChild("DemoRoleInfo");
            DemoReturnBox = (DemoReturnBox)GetChild("DemoReturnBox");
        }
    }
}
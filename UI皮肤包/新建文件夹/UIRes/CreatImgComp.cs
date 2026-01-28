/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CreatImgComp : GComponent
    {
        public GList SCreatImgGrids;
        public GTextField n1;
        public LastStepBtn LastStepBtn;
        public ConsignsellRoleBtn ConsignsellRoleBtn;
        public AgainCreatBtn AgainCreatBtn;
        public const string URL = "ui://jk0io98jj3e21c9";

        public static CreatImgComp CreateInstance()
        {
            return (CreatImgComp)UIPackage.CreateObject("UIRes", "CreatImgComp");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            SCreatImgGrids = (GList)GetChild("SCreatImgGrids");
            n1 = (GTextField)GetChild("n1");
            LastStepBtn = (LastStepBtn)GetChild("LastStepBtn");
            ConsignsellRoleBtn = (ConsignsellRoleBtn)GetChild("ConsignsellRoleBtn");
            AgainCreatBtn = (AgainCreatBtn)GetChild("AgainCreatBtn");
        }
    }
}
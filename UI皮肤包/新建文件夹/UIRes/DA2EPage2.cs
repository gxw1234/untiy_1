/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage2 : GComponent
    {
        public GList DA2EGrid1;
        public BottLTeamCreTeamBtn BottLTeamCreTeamBtn;
        public BottLTeamAreaTeamBtn BottLTeamAreaTeamBtn;
        public CommonBtn inviteBtn;
        public CommonBtn nearBtn;
        public const string URL = "ui://jk0io98jtd9gf";

        public static DA2EPage2 CreateInstance()
        {
            return (DA2EPage2)UIPackage.CreateObject("UIRes", "DA2EPage2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EGrid1 = (GList)GetChild("DA2EGrid1");
            BottLTeamCreTeamBtn = (BottLTeamCreTeamBtn)GetChild("BottLTeamCreTeamBtn");
            BottLTeamAreaTeamBtn = (BottLTeamAreaTeamBtn)GetChild("BottLTeamAreaTeamBtn");
            inviteBtn = (CommonBtn)GetChild("inviteBtn");
            nearBtn = (CommonBtn)GetChild("nearBtn");
        }
    }
}
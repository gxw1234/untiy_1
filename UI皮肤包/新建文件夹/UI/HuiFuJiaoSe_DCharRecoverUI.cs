/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class HuiFuJiaoSe_DCharRecoverUI : GComponent
    {
        public GImage DCharRecover;
        public GButton DCharRecoverClose;
        public GList DRecoverItemList;
        public GButton DBtnRecover;
        public const string URL = "ui://jyvofh5ele08f";

        public static HuiFuJiaoSe_DCharRecoverUI CreateInstance()
        {
            return (HuiFuJiaoSe_DCharRecoverUI)UIPackage.CreateObject("UI", "恢复角色_DCharRecoverUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DCharRecover = (GImage)GetChild("DCharRecover");
            DCharRecoverClose = (GButton)GetChild("DCharRecoverClose");
            DRecoverItemList = (GList)GetChild("DRecoverItemList");
            DBtnRecover = (GButton)GetChild("DBtnRecover");
        }
    }
}
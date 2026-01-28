/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ChuangJianJiaoSe_DCharSelectUI : GComponent
    {
        public GImage DCharSelect;
        public GComponent DJobList;
        public GComponent DSexList;
        public GButton DCharSelectClose;
        public GButton BtnSubmit;
        public GTextInput DEditNickName;
        public GButton BtnRandomNickName;
        public const string URL = "ui://jyvofh5e6k1wk";

        public static ChuangJianJiaoSe_DCharSelectUI CreateInstance()
        {
            return (ChuangJianJiaoSe_DCharSelectUI)UIPackage.CreateObject("UI", "创建角色_DCharSelectUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DCharSelect = (GImage)GetChild("DCharSelect");
            DJobList = (GComponent)GetChild("DJobList");
            DSexList = (GComponent)GetChild("DSexList");
            DCharSelectClose = (GButton)GetChild("DCharSelectClose");
            BtnSubmit = (GButton)GetChild("BtnSubmit");
            DEditNickName = (GTextInput)GetChild("DEditNickName");
            BtnRandomNickName = (GButton)GetChild("BtnRandomNickName");
        }
    }
}
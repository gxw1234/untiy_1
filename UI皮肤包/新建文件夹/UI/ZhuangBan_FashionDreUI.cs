/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZhuangBan_FashionDreUI : GComponent
    {
        public GImage FashionDreUI;
        public GComponent frame;
        public GImage DA2EIMAGE1;
        public GList DA2EGrid1;
        public GList DServerRightList;
        public GComponent role;
        public GButton FashionDreCloseBtn;
        public GRichTextField MemoFaShowInfo;
        public GRichTextField IntroduceText;
        public const string URL = "ui://jyvofh5ekn5z19h";

        public static ZhuangBan_FashionDreUI CreateInstance()
        {
            return (ZhuangBan_FashionDreUI)UIPackage.CreateObject("UI", "装扮_FashionDreUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            FashionDreUI = (GImage)GetChild("FashionDreUI");
            frame = (GComponent)GetChild("frame");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DA2EGrid1 = (GList)GetChild("DA2EGrid1");
            DServerRightList = (GList)GetChild("DServerRightList");
            role = (GComponent)GetChild("role");
            FashionDreCloseBtn = (GButton)GetChild("FashionDreCloseBtn");
            MemoFaShowInfo = (GRichTextField)GetChild("MemoFaShowInfo");
            IntroduceText = (GRichTextField)GetChild("IntroduceText");
        }
    }
}
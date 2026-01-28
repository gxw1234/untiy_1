/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZuDui_DWindow2UI : GComponent
    {
        public GImage DWindow2;
        public GTextField ChatEdit8;
        public GButton DA2ESimpleButton18;
        public GButton DA2ESimpleButton19;
        public GButton DA2ESimpleButton20;
        public GButton DA2ESimpleButton21;
        public GButton DCloseBtn;
        public const string URL = "ui://jyvofh5e10awvn2rx";

        public static ZuDui_DWindow2UI CreateInstance()
        {
            return (ZuDui_DWindow2UI)UIPackage.CreateObject("UI", "组队_DWindow2UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DWindow2 = (GImage)GetChild("DWindow2");
            ChatEdit8 = (GTextField)GetChild("ChatEdit8");
            DA2ESimpleButton18 = (GButton)GetChild("DA2ESimpleButton18");
            DA2ESimpleButton19 = (GButton)GetChild("DA2ESimpleButton19");
            DA2ESimpleButton20 = (GButton)GetChild("DA2ESimpleButton20");
            DA2ESimpleButton21 = (GButton)GetChild("DA2ESimpleButton21");
            DCloseBtn = (GButton)GetChild("DCloseBtn");
        }
    }
}
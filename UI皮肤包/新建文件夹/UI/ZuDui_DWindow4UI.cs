/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZuDui_DWindow4UI : GComponent
    {
        public GImage DWindow4;
        public GTextField DPlayName;
        public GButton DA2ESimpleButton7;
        public GButton DA2ESimpleButton8;
        public GButton DA2ESimpleButton9;
        public GButton DA2ESimpleButton10;
        public GButton DA2ESimpleButton11;
        public GButton DA2ESimpleButton17;
        public GButton DCloseBtn;
        public const string URL = "ui://jyvofh5e10awvn2rz";

        public static ZuDui_DWindow4UI CreateInstance()
        {
            return (ZuDui_DWindow4UI)UIPackage.CreateObject("UI", "组队_DWindow4UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DWindow4 = (GImage)GetChild("DWindow4");
            DPlayName = (GTextField)GetChild("DPlayName");
            DA2ESimpleButton7 = (GButton)GetChild("DA2ESimpleButton7");
            DA2ESimpleButton8 = (GButton)GetChild("DA2ESimpleButton8");
            DA2ESimpleButton9 = (GButton)GetChild("DA2ESimpleButton9");
            DA2ESimpleButton10 = (GButton)GetChild("DA2ESimpleButton10");
            DA2ESimpleButton11 = (GButton)GetChild("DA2ESimpleButton11");
            DA2ESimpleButton17 = (GButton)GetChild("DA2ESimpleButton17");
            DCloseBtn = (GButton)GetChild("DCloseBtn");
        }
    }
}
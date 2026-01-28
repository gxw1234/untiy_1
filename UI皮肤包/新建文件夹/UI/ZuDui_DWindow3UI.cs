/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ZuDui_DWindow3UI : GComponent
    {
        public GImage DWindow3;
        public GButton DA2ESimpleButton2;
        public GTextField DPlayName;
        public GButton DA2ESimpleButton3;
        public GButton DCloseBtn;
        public const string URL = "ui://jyvofh5e10awvn2ry";

        public static ZuDui_DWindow3UI CreateInstance()
        {
            return (ZuDui_DWindow3UI)UIPackage.CreateObject("UI", "组队_DWindow3UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DWindow3 = (GImage)GetChild("DWindow3");
            DA2ESimpleButton2 = (GButton)GetChild("DA2ESimpleButton2");
            DPlayName = (GTextField)GetChild("DPlayName");
            DA2ESimpleButton3 = (GButton)GetChild("DA2ESimpleButton3");
            DCloseBtn = (GButton)GetChild("DCloseBtn");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBottom : GComponent
    {
        public DBottomLeftPanel DBottomLeftPanel;
        public DBottomRightPanel DBottomRightPanel;
        public DBottomBelts DBottomBelts;
        public DBottomMemo DBottomMemo;
        public DMidleComp DMidleComp;
        public const string URL = "ui://jk0io98jj3e21or";

        public static DBottom CreateInstance()
        {
            return (DBottom)UIPackage.CreateObject("UIRes", "DBottom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBottomLeftPanel = (DBottomLeftPanel)GetChild("DBottomLeftPanel");
            DBottomRightPanel = (DBottomRightPanel)GetChild("DBottomRightPanel");
            DBottomBelts = (DBottomBelts)GetChild("DBottomBelts");
            DBottomMemo = (DBottomMemo)GetChild("DBottomMemo");
            DMidleComp = (DMidleComp)GetChild("DMidleComp");
        }
    }
}
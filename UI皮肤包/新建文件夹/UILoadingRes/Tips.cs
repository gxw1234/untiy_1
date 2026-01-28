/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class Tips : GComponent
    {
        public GImage TipsBG;
        public GRichTextField ItemName;
        public GRichTextField TipsMsg;
        public ContainerItem ContainerItem;
        public ContainerTips ContainerTips;
        public GRichTextField msg;
        public GTextField currentEquip;
        public DressBtn DressBtn;
        public SplitBtn SplitBtn;
        public UseBtn UseBtn1;
        public UseBtn UseBtn2;
        public const string URL = "ui://us2ut3jfr7r83l";

        public static Tips CreateInstance()
        {
            return (Tips)UIPackage.CreateObject("UILoadingRes", "Tips");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            TipsBG = (GImage)GetChild("TipsBG");
            ItemName = (GRichTextField)GetChild("ItemName");
            TipsMsg = (GRichTextField)GetChild("TipsMsg");
            ContainerItem = (ContainerItem)GetChild("ContainerItem");
            ContainerTips = (ContainerTips)GetChild("ContainerTips");
            msg = (GRichTextField)GetChild("msg");
            currentEquip = (GTextField)GetChild("currentEquip");
            DressBtn = (DressBtn)GetChild("DressBtn");
            SplitBtn = (SplitBtn)GetChild("SplitBtn");
            UseBtn1 = (UseBtn)GetChild("UseBtn1");
            UseBtn2 = (UseBtn)GetChild("UseBtn2");
        }
    }
}
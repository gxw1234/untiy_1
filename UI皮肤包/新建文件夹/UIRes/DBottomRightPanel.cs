/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBottomRightPanel : GComponent
    {
        public GImage DBottomRightPanel;
        public DA2EControl1 DA2EControl1;
        public DBtnShop DBtnShop;
        public DBtnState DBtnState;
        public DBtnBag DBtnBag;
        public DBtnMagic DBtnMagic;
        public DA2ESimpleButton4 DA2ESimpleButton4;
        public DA2ESimpleButton1 DA2ESimpleButton1;
        public DA2ESimpleButton2 DA2ESimpleButton2;
        public DA2ESimpleButton3 DA2ESimpleButton3;
        public DBtnChangeJob DBtnChangeJob;
        public DExpBar DExpBar;
        public DWetBar DWetBar;
        public GTextField timerHour;
        public DAngerBar DAngerBar;
        public GRichTextField DLevel;
        public GRichTextField AttatckMode;
        public const string URL = "ui://jk0io98jj3e21nv";

        public static DBottomRightPanel CreateInstance()
        {
            return (DBottomRightPanel)UIPackage.CreateObject("UIRes", "DBottomRightPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBottomRightPanel = (GImage)GetChild("DBottomRightPanel");
            DA2EControl1 = (DA2EControl1)GetChild("DA2EControl1");
            DBtnShop = (DBtnShop)GetChild("DBtnShop");
            DBtnState = (DBtnState)GetChild("DBtnState");
            DBtnBag = (DBtnBag)GetChild("DBtnBag");
            DBtnMagic = (DBtnMagic)GetChild("DBtnMagic");
            DA2ESimpleButton4 = (DA2ESimpleButton4)GetChild("DA2ESimpleButton4");
            DA2ESimpleButton1 = (DA2ESimpleButton1)GetChild("DA2ESimpleButton1");
            DA2ESimpleButton2 = (DA2ESimpleButton2)GetChild("DA2ESimpleButton2");
            DA2ESimpleButton3 = (DA2ESimpleButton3)GetChild("DA2ESimpleButton3");
            DBtnChangeJob = (DBtnChangeJob)GetChild("DBtnChangeJob");
            DExpBar = (DExpBar)GetChild("DExpBar");
            DWetBar = (DWetBar)GetChild("DWetBar");
            timerHour = (GTextField)GetChild("timerHour");
            DAngerBar = (DAngerBar)GetChild("DAngerBar");
            DLevel = (GRichTextField)GetChild("DLevel");
            AttatckMode = (GRichTextField)GetChild("AttatckMode");
        }
    }
}
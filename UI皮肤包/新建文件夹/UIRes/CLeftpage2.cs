/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CLeftpage2 : GComponent
    {
        public Controller Radbtn;
        public GTextField n0;
        public GTextField n1;
        public GTextField n2;
        public RadBtnMoney1 RadBtnMoney1;
        public RadBtnMoney2 RadBtnMoney2;
        public DealRolePage1 DealRolePage1;
        public DealRolePage2 DealRolePage2;
        public CreatImgComp CreatImgComp;
        public const string URL = "ui://jk0io98jj3e21c1";

        public static CLeftpage2 CreateInstance()
        {
            return (CLeftpage2)UIPackage.CreateObject("UIRes", "CLeftpage2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Radbtn = GetController("Radbtn");
            n0 = (GTextField)GetChild("n0");
            n1 = (GTextField)GetChild("n1");
            n2 = (GTextField)GetChild("n2");
            RadBtnMoney1 = (RadBtnMoney1)GetChild("RadBtnMoney1");
            RadBtnMoney2 = (RadBtnMoney2)GetChild("RadBtnMoney2");
            DealRolePage1 = (DealRolePage1)GetChild("DealRolePage1");
            DealRolePage2 = (DealRolePage2)GetChild("DealRolePage2");
            CreatImgComp = (CreatImgComp)GetChild("CreatImgComp");
        }
    }
}
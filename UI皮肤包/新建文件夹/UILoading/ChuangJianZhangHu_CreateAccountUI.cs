/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class ChuangJianZhangHu_CreateAccountUI : GComponent
    {
        public GImage CreateAccountUI;
        public GRichTextField FGUIBaseCom14;
        public GTextInput FGUIBaseCom1;
        public GTextInput FGUIBaseCom2;
        public GTextInput FGUIBaseCom3;
        public GTextInput FGUIBaseCom4;
        public GTextInput FGUIBaseCom5;
        public GTextInput FGUIBaseCom6;
        public GTextInput FGUIBaseCom7;
        public GTextInput FGUIBaseCom8;
        public GButton DBtnOK;
        public GButton DBtnFaill;
        public const string URL = "ui://up3anxyrr7r828";

        public static ChuangJianZhangHu_CreateAccountUI CreateInstance()
        {
            return (ChuangJianZhangHu_CreateAccountUI)UIPackage.CreateObject("UILoading", "创建账户_CreateAccountUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CreateAccountUI = (GImage)GetChild("CreateAccountUI");
            FGUIBaseCom14 = (GRichTextField)GetChild("FGUIBaseCom14");
            FGUIBaseCom1 = (GTextInput)GetChild("FGUIBaseCom1");
            FGUIBaseCom2 = (GTextInput)GetChild("FGUIBaseCom2");
            FGUIBaseCom3 = (GTextInput)GetChild("FGUIBaseCom3");
            FGUIBaseCom4 = (GTextInput)GetChild("FGUIBaseCom4");
            FGUIBaseCom5 = (GTextInput)GetChild("FGUIBaseCom5");
            FGUIBaseCom6 = (GTextInput)GetChild("FGUIBaseCom6");
            FGUIBaseCom7 = (GTextInput)GetChild("FGUIBaseCom7");
            FGUIBaseCom8 = (GTextInput)GetChild("FGUIBaseCom8");
            DBtnOK = (GButton)GetChild("DBtnOK");
            DBtnFaill = (GButton)GetChild("DBtnFaill");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class NormalWin : GComponent
    {
        public GImage DA2EIMAGE1;
        public GTextField ChatEdit3;
        public GTextField ChatEdit4;
        public GTextField ChatEdit5;
        public GTextField ChatEdit36;
        public GList DA2EGrid5;
        public BtnAllAree BtnAllAree;
        public GTextField ChatEdit1;
        public GTextField ChatEdit2;
        public CheckBoxBan CheckBoxBan;
        public CheckBoxOpen CheckBoxOpen;
        public BtnAllRefuse BtnAllRefuse;
        public BtnApplyCon BtnApplyCon;
        public const string URL = "ui://jk0io98jkn5z184";

        public static NormalWin CreateInstance()
        {
            return (NormalWin)UIPackage.CreateObject("UIRes", "NormalWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            ChatEdit3 = (GTextField)GetChild("ChatEdit3");
            ChatEdit4 = (GTextField)GetChild("ChatEdit4");
            ChatEdit5 = (GTextField)GetChild("ChatEdit5");
            ChatEdit36 = (GTextField)GetChild("ChatEdit36");
            DA2EGrid5 = (GList)GetChild("DA2EGrid5");
            BtnAllAree = (BtnAllAree)GetChild("BtnAllAree");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
            CheckBoxBan = (CheckBoxBan)GetChild("CheckBoxBan");
            CheckBoxOpen = (CheckBoxOpen)GetChild("CheckBoxOpen");
            BtnAllRefuse = (BtnAllRefuse)GetChild("BtnAllRefuse");
            BtnApplyCon = (BtnApplyCon)GetChild("BtnApplyCon");
        }
    }
}
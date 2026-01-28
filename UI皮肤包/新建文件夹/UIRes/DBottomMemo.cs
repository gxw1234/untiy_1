/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBottomMemo : GComponent
    {
        public GImage bg;
        public GList DChatWindow;
        public DA2ECheckBox1 DA2ECheckBox1;
        public DA2ECheckBox2 DA2ECheckBox2;
        public DA2ECheckBox3 DA2ECheckBox3;
        public DA2ECheckBox4 DA2ECheckBox4;
        public DA2ECheckBox5 DA2ECheckBox5;
        public DA2ESimpleButton14 DA2ESimpleButton14;
        public DBtnMission DBtnMission;
        public DBtnStalling DBtnStalling;
        public GTextInput ChatEdit1;
        public const string URL = "ui://jk0io98jj3e21ok";

        public static DBottomMemo CreateInstance()
        {
            return (DBottomMemo)UIPackage.CreateObject("UIRes", "DBottomMemo");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            DChatWindow = (GList)GetChild("DChatWindow");
            DA2ECheckBox1 = (DA2ECheckBox1)GetChild("DA2ECheckBox1");
            DA2ECheckBox2 = (DA2ECheckBox2)GetChild("DA2ECheckBox2");
            DA2ECheckBox3 = (DA2ECheckBox3)GetChild("DA2ECheckBox3");
            DA2ECheckBox4 = (DA2ECheckBox4)GetChild("DA2ECheckBox4");
            DA2ECheckBox5 = (DA2ECheckBox5)GetChild("DA2ECheckBox5");
            DA2ESimpleButton14 = (DA2ESimpleButton14)GetChild("DA2ESimpleButton14");
            DBtnMission = (DBtnMission)GetChild("DBtnMission");
            DBtnStalling = (DBtnStalling)GetChild("DBtnStalling");
            ChatEdit1 = (GTextInput)GetChild("ChatEdit1");
        }
    }
}
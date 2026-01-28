/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow1 : GComponent
    {
        public GImage DA2EWindow1;
        public GTextField DUserName;
        public BtnBuy BtnBuy;
        public BtnPresent BtnPresent;
        public DA2EWindow2 DA2EWindow2;
        public BtnYinSi BtnYinSi;
        public GRichTextField appVerText;
        public const string URL = "ui://jk0io98jkn5zwa";

        public static DA2EWindow1 CreateInstance()
        {
            return (DA2EWindow1)UIPackage.CreateObject("UIRes", "DA2EWindow1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow1 = (GImage)GetChild("DA2EWindow1");
            DUserName = (GTextField)GetChild("DUserName");
            BtnBuy = (BtnBuy)GetChild("BtnBuy");
            BtnPresent = (BtnPresent)GetChild("BtnPresent");
            DA2EWindow2 = (DA2EWindow2)GetChild("DA2EWindow2");
            BtnYinSi = (BtnYinSi)GetChild("BtnYinSi");
            appVerText = (GRichTextField)GetChild("appVerText");
        }
    }
}
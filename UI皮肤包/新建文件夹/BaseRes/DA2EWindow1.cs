/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2EWindow1 : GComponent
    {
        public GImage DA2EWindow1;
        public GImage PageBackground;
        public GTextField EditItemList;
        public GList GridList;
        public GTextField EditCost;
        public GTextField EditLasting;
        public BtnClose1 BtnClose1;
        public GTextField EditPage;
        public BtnPageUp BtnPageUp;
        public BtnPageDown BtnPageDown;
        public BtnOk1 BtnOk1;
        public const string URL = "ui://use7blkkqgn28k";

        public static DA2EWindow1 CreateInstance()
        {
            return (DA2EWindow1)UIPackage.CreateObject("BaseRes", "DA2EWindow1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow1 = (GImage)GetChild("DA2EWindow1");
            PageBackground = (GImage)GetChild("PageBackground");
            EditItemList = (GTextField)GetChild("EditItemList");
            GridList = (GList)GetChild("GridList");
            EditCost = (GTextField)GetChild("EditCost");
            EditLasting = (GTextField)GetChild("EditLasting");
            BtnClose1 = (BtnClose1)GetChild("BtnClose1");
            EditPage = (GTextField)GetChild("EditPage");
            BtnPageUp = (BtnPageUp)GetChild("BtnPageUp");
            BtnPageDown = (BtnPageDown)GetChild("BtnPageDown");
            BtnOk1 = (BtnOk1)GetChild("BtnOk1");
        }
    }
}
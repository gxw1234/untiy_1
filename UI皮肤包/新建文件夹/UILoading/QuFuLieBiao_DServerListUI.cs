/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoading
{
    public partial class QuFuLieBiao_DServerListUI : GComponent
    {
        public GImage DServerListUI;
        public GButton DA2ESimpleButton1;
        public GList DServerLeftList;
        public GList DServerRightList;
        public GButton DA2ESimpleButton4;
        public GButton SelectServerCloseBtn;
        public const string URL = "ui://up3anxyrr7r82c";

        public static QuFuLieBiao_DServerListUI CreateInstance()
        {
            return (QuFuLieBiao_DServerListUI)UIPackage.CreateObject("UILoading", "区服列表_DServerListUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DServerListUI = (GImage)GetChild("DServerListUI");
            DA2ESimpleButton1 = (GButton)GetChild("DA2ESimpleButton1");
            DServerLeftList = (GList)GetChild("DServerLeftList");
            DServerRightList = (GList)GetChild("DServerRightList");
            DA2ESimpleButton4 = (GButton)GetChild("DA2ESimpleButton4");
            SelectServerCloseBtn = (GButton)GetChild("SelectServerCloseBtn");
        }
    }
}
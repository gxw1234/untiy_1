/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class StoreWindowSelect : GComponent
    {
        public GImage StoreUI;
        public PageDown RightTurnBtn;
        public PageUp LeftTurnBtn;
        public GTextField PageNum;
        public BtnClose1 BtnClose2;
        public GList GridList;
        public const string URL = "ui://use7blkky2cla9";

        public static StoreWindowSelect CreateInstance()
        {
            return (StoreWindowSelect)UIPackage.CreateObject("BaseRes", "StoreWindowSelect");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            StoreUI = (GImage)GetChild("StoreUI");
            RightTurnBtn = (PageDown)GetChild("RightTurnBtn");
            LeftTurnBtn = (PageUp)GetChild("LeftTurnBtn");
            PageNum = (GTextField)GetChild("PageNum");
            BtnClose2 = (BtnClose1)GetChild("BtnClose2");
            GridList = (GList)GetChild("GridList");
        }
    }
}
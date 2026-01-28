/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class StoreWindow : GComponent
    {
        public GImage StoreUI;
        public ConfirmBtn1 ConfirmBtn;
        public LeftTurnBtn1 LeftTurnBtn;
        public RightTurnBtn1 RightTurnBtn;
        public GTextField PageNum;
        public BtnClose1 BtnClose1;
        public GList GridList;
        public const string URL = "ui://use7blkky2cla8";

        public static StoreWindow CreateInstance()
        {
            return (StoreWindow)UIPackage.CreateObject("BaseRes", "StoreWindow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            StoreUI = (GImage)GetChild("StoreUI");
            ConfirmBtn = (ConfirmBtn1)GetChild("ConfirmBtn");
            LeftTurnBtn = (LeftTurnBtn1)GetChild("LeftTurnBtn");
            RightTurnBtn = (RightTurnBtn1)GetChild("RightTurnBtn");
            PageNum = (GTextField)GetChild("PageNum");
            BtnClose1 = (BtnClose1)GetChild("BtnClose1");
            GridList = (GList)GetChild("GridList");
        }
    }
}
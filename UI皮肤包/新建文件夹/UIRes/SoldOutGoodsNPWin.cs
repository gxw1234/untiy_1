/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SoldOutGoodsNPWin : GComponent
    {
        public GImage SoldOutGoodsNPWin;
        public GTextField SoldOutGNowPriEdits;
        public GLoader DA2ELoader69;
        public const string URL = "ui://jk0io98jkn5z12q";

        public static SoldOutGoodsNPWin CreateInstance()
        {
            return (SoldOutGoodsNPWin)UIPackage.CreateObject("UIRes", "SoldOutGoodsNPWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            SoldOutGoodsNPWin = (GImage)GetChild("SoldOutGoodsNPWin");
            SoldOutGNowPriEdits = (GTextField)GetChild("SoldOutGNowPriEdits");
            DA2ELoader69 = (GLoader)GetChild("DA2ELoader69");
        }
    }
}
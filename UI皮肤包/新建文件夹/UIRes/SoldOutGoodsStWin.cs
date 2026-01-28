/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SoldOutGoodsStWin : GComponent
    {
        public GImage SoldOutGoodsStWin;
        public GTextField SoldOutGStartPriEdits;
        public GLoader DA2ELoader67;
        public const string URL = "ui://jk0io98jkn5z12k";

        public static SoldOutGoodsStWin CreateInstance()
        {
            return (SoldOutGoodsStWin)UIPackage.CreateObject("UIRes", "SoldOutGoodsStWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            SoldOutGoodsStWin = (GImage)GetChild("SoldOutGoodsStWin");
            SoldOutGStartPriEdits = (GTextField)GetChild("SoldOutGStartPriEdits");
            DA2ELoader67 = (GLoader)GetChild("DA2ELoader67");
        }
    }
}
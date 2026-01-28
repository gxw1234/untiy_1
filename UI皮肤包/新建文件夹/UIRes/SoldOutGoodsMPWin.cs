/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SoldOutGoodsMPWin : GComponent
    {
        public GImage SoldOutGoodsMPWin;
        public GTextField SoldOutGMousePriEdits;
        public GLoader DA2ELoader68;
        public const string URL = "ui://jk0io98jkn5z12l";

        public static SoldOutGoodsMPWin CreateInstance()
        {
            return (SoldOutGoodsMPWin)UIPackage.CreateObject("UIRes", "SoldOutGoodsMPWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            SoldOutGoodsMPWin = (GImage)GetChild("SoldOutGoodsMPWin");
            SoldOutGMousePriEdits = (GTextField)GetChild("SoldOutGMousePriEdits");
            DA2ELoader68 = (GLoader)GetChild("DA2ELoader68");
        }
    }
}
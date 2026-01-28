/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class YuanBaoBdWin : GComponent
    {
        public GTextField DGoldName;
        public GTextField DGold;
        public const string URL = "ui://jk0io98jmi8zgvn2x9";

        public static YuanBaoBdWin CreateInstance()
        {
            return (YuanBaoBdWin)UIPackage.CreateObject("UIRes", "YuanBaoBdWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DGoldName = (GTextField)GetChild("DGoldName");
            DGold = (GTextField)GetChild("DGold");
        }
    }
}
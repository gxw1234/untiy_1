/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ProgressBarWin : GComponent
    {
        public GImage bg;
        public DProgressBar DProgressBar;
        public GTextField SellCTxt;
        public const string URL = "ui://jk0io98jj3e21fv";

        public static ProgressBarWin CreateInstance()
        {
            return (ProgressBarWin)UIPackage.CreateObject("UIRes", "ProgressBarWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            DProgressBar = (DProgressBar)GetChild("DProgressBar");
            SellCTxt = (GTextField)GetChild("SellCTxt");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DLoginBg : GComponent
    {
        public GImage DLoginBg;
        public DWinOpendAn DWinOpendAn;
        public const string URL = "ui://us2ut3jfr7r82b";

        public static DLoginBg CreateInstance()
        {
            return (DLoginBg)UIPackage.CreateObject("UILoadingRes", "DLoginBg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DLoginBg = (GImage)GetChild("DLoginBg");
            DWinOpendAn = (DWinOpendAn)GetChild("DWinOpendAn");
        }
    }
}
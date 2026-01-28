/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DWinOpendAn : GComponent
    {
        public GLoader DOpenAni;
        public Transition select;
        public const string URL = "ui://us2ut3jfr7r81p";

        public static DWinOpendAn CreateInstance()
        {
            return (DWinOpendAn)UIPackage.CreateObject("UILoadingRes", "DWinOpendAn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DOpenAni = (GLoader)GetChild("DOpenAni");
            select = GetTransition("select");
        }
    }
}
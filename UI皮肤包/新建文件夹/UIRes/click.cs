/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class click : GComponent
    {
        public GLoader clickAni;
        public Transition clickTrs;
        public const string URL = "ui://jk0io98jv9b1g9";

        public static click CreateInstance()
        {
            return (click)UIPackage.CreateObject("UIRes", "click");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            clickAni = (GLoader)GetChild("clickAni");
            clickTrs = GetTransition("clickTrs");
        }
    }
}
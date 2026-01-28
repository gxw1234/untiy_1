/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class clickBig : GComponent
    {
        public GLoader clickBigAni;
        public Transition clickTrs;
        public const string URL = "ui://jk0io98jv9b1ga";

        public static clickBig CreateInstance()
        {
            return (clickBig)UIPackage.CreateObject("UIRes", "clickBig");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            clickBigAni = (GLoader)GetChild("clickBigAni");
            clickTrs = GetTransition("clickTrs");
        }
    }
}
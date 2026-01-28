/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class BreakLineUI : GComponent
    {
        public GLoader BreakLineLoad;
        public Transition select;
        public const string URL = "ui://use7blkkr7r83w";

        public static BreakLineUI CreateInstance()
        {
            return (BreakLineUI)UIPackage.CreateObject("BaseRes", "BreakLineUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BreakLineLoad = (GLoader)GetChild("BreakLineLoad");
            select = GetTransition("select");
        }
    }
}
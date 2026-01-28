/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottGroupWin : GComponent
    {
        public BottomGroupBtn BottomGroupBtn;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11n";

        public static BottGroupWin CreateInstance()
        {
            return (BottGroupWin)UIPackage.CreateObject("UIRes", "BottGroupWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottomGroupBtn = (BottomGroupBtn)GetChild("BottomGroupBtn");
            select = GetTransition("select");
        }
    }
}
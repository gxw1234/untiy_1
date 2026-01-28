/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottMailWin : GComponent
    {
        public BottomEMailBtn BottomEMailBtn;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11l";

        public static BottMailWin CreateInstance()
        {
            return (BottMailWin)UIPackage.CreateObject("UIRes", "BottMailWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottomEMailBtn = (BottomEMailBtn)GetChild("BottomEMailBtn");
            select = GetTransition("select");
        }
    }
}
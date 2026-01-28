/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RightUIProWin : GComponent
    {
        public RightUiPromoteBtn RightUiPromoteBtn;
        public Transition select;
        public const string URL = "ui://jk0io98jk02tn1uy";

        public static RightUIProWin CreateInstance()
        {
            return (RightUIProWin)UIPackage.CreateObject("UIRes", "RightUIProWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RightUiPromoteBtn = (RightUiPromoteBtn)GetChild("RightUiPromoteBtn");
            select = GetTransition("select");
        }
    }
}
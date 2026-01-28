/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class HpWin1 : GComponent
    {
        public GLoader DHPBall;
        public Transition select;
        public const string URL = "ui://jk0io98jldxan27y";

        public static HpWin1 CreateInstance()
        {
            return (HpWin1)UIPackage.CreateObject("UIRes", "HpWin1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DHPBall = (GLoader)GetChild("DHPBall");
            select = GetTransition("select");
        }
    }
}
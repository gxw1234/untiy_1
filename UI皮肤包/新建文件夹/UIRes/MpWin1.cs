/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MpWin1 : GComponent
    {
        public GLoader DMPBall;
        public Transition select;
        public const string URL = "ui://jk0io98jldxan27x";

        public static MpWin1 CreateInstance()
        {
            return (MpWin1)UIPackage.CreateObject("UIRes", "MpWin1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DMPBall = (GLoader)GetChild("DMPBall");
            select = GetTransition("select");
        }
    }
}
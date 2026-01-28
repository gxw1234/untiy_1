/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class HPAni : GComponent
    {
        public GLoader DHPBall;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11b";

        public static HPAni CreateInstance()
        {
            return (HPAni)UIPackage.CreateObject("UIRes", "HPAni");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DHPBall = (GLoader)GetChild("DHPBall");
            select = GetTransition("select");
        }
    }
}
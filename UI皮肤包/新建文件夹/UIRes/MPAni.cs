/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MPAni : GComponent
    {
        public GLoader DMPBall;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11a";

        public static MPAni CreateInstance()
        {
            return (MPAni)UIPackage.CreateObject("UIRes", "MPAni");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DMPBall = (GLoader)GetChild("DMPBall");
            select = GetTransition("select");
        }
    }
}
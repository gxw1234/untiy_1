/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AutoFight : GComponent
    {
        public GLoader AutoFightAni;
        public BtnAutoFight BtnAutoFight;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b11g";

        public static AutoFight CreateInstance()
        {
            return (AutoFight)UIPackage.CreateObject("UIRes", "AutoFight");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            AutoFightAni = (GLoader)GetChild("AutoFightAni");
            BtnAutoFight = (BtnAutoFight)GetChild("BtnAutoFight");
            select = GetTransition("select");
        }
    }
}
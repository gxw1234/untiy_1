/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AutoWay : GComponent
    {
        public GLoader AutoWayAni;
        public BtnAutoWay BtnAutoWay;
        public Transition Select;
        public const string URL = "ui://jk0io98jv9b11i";

        public static AutoWay CreateInstance()
        {
            return (AutoWay)UIPackage.CreateObject("UIRes", "AutoWay");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            AutoWayAni = (GLoader)GetChild("AutoWayAni");
            BtnAutoWay = (BtnAutoWay)GetChild("BtnAutoWay");
            Select = GetTransition("Select");
        }
    }
}
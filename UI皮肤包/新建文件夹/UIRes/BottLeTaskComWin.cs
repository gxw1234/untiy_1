/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLeTaskComWin : GComponent
    {
        public GLoader BottLeTaskFinishAni;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b196";

        public static BottLeTaskComWin CreateInstance()
        {
            return (BottLeTaskComWin)UIPackage.CreateObject("UIRes", "BottLeTaskComWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottLeTaskFinishAni = (GLoader)GetChild("BottLeTaskFinishAni");
            select = GetTransition("select");
        }
    }
}
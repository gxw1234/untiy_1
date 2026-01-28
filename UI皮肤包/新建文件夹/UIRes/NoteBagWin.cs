/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class NoteBagWin : GComponent
    {
        public GImage TipsBG;
        public GTextField ChatEdit19;
        public NoteBagBtn NoteBagBtn;
        public const string URL = "ui://jk0io98jk02tn1uv";

        public static NoteBagWin CreateInstance()
        {
            return (NoteBagWin)UIPackage.CreateObject("UIRes", "NoteBagWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            TipsBG = (GImage)GetChild("TipsBG");
            ChatEdit19 = (GTextField)GetChild("ChatEdit19");
            NoteBagBtn = (NoteBagBtn)GetChild("NoteBagBtn");
        }
    }
}
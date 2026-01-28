/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DropUI : GComponent
    {
        public GLoader BottomDropLoad1;
        public GLoader BottomDropLoad2;
        public GTextField BottomDropEdits;
        public const string URL = "ui://jk0io98jk02tn1v3";

        public static DropUI CreateInstance()
        {
            return (DropUI)UIPackage.CreateObject("UIRes", "DropUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BottomDropLoad1 = (GLoader)GetChild("BottomDropLoad1");
            BottomDropLoad2 = (GLoader)GetChild("BottomDropLoad2");
            BottomDropEdits = (GTextField)GetChild("BottomDropEdits");
        }
    }
}
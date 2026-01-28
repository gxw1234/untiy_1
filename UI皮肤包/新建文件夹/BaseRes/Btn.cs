/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class Btn : GComponent
    {
        public GLoader load;
        public const string URL = "ui://use7blkkqgn28e";

        public static Btn CreateInstance()
        {
            return (Btn)UIPackage.CreateObject("BaseRes", "Btn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
        }
    }
}
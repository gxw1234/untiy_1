/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMap : GComponent
    {
        public GLoader item;
        public const string URL = "ui://jk0io98jruoyn2r0";

        public static DMap CreateInstance()
        {
            return (DMap)UIPackage.CreateObject("UIRes", "DMap");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            item = (GLoader)GetChild("item");
        }
    }
}
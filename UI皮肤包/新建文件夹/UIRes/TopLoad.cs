/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TopLoad : GComponent
    {
        public GLoader Item;
        public const string URL = "ui://jk0io98jj3e21ju";

        public static TopLoad CreateInstance()
        {
            return (TopLoad)UIPackage.CreateObject("UIRes", "TopLoad");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Item = (GLoader)GetChild("Item");
        }
    }
}
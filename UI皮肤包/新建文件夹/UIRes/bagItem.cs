/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class bagItem : GComponent
    {
        public GLoader KEff21;
        public GLoader KEff11;
        public GLoader Kicon;
        public GTextField Ktitle;
        public GLoader KEff22;
        public GLoader KEff12;
        public GLoader KEff23;
        public GLoader KEff13;
        public GLoader KbagsLod;
        public GLoader KbagsLods;
        public const string URL = "ui://jk0io98jv9b1g8";

        public static bagItem CreateInstance()
        {
            return (bagItem)UIPackage.CreateObject("UIRes", "bagItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            KEff21 = (GLoader)GetChild("KEff21");
            KEff11 = (GLoader)GetChild("KEff11");
            Kicon = (GLoader)GetChild("Kicon");
            Ktitle = (GTextField)GetChild("Ktitle");
            KEff22 = (GLoader)GetChild("KEff22");
            KEff12 = (GLoader)GetChild("KEff12");
            KEff23 = (GLoader)GetChild("KEff23");
            KEff13 = (GLoader)GetChild("KEff13");
            KbagsLod = (GLoader)GetChild("KbagsLod");
            KbagsLods = (GLoader)GetChild("KbagsLods");
        }
    }
}
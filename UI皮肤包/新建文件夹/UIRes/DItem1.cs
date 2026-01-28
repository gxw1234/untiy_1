/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DItem1 : GComponent
    {
        public GImage ImgBuyS;
        public GLoader Eff21;
        public GLoader Eff11;
        public GLoader LoadStallItem;
        public GLoader Eff22;
        public GLoader Eff12;
        public GLoader Eff23;
        public GLoader Eff13;
        public GTextField itemCount;
        public GTextField StarLevel;
        public const string URL = "ui://jk0io98jj3e21gl";

        public static DItem1 CreateInstance()
        {
            return (DItem1)UIPackage.CreateObject("UIRes", "DItem1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ImgBuyS = (GImage)GetChild("ImgBuyS");
            Eff21 = (GLoader)GetChild("Eff21");
            Eff11 = (GLoader)GetChild("Eff11");
            LoadStallItem = (GLoader)GetChild("LoadStallItem");
            Eff22 = (GLoader)GetChild("Eff22");
            Eff12 = (GLoader)GetChild("Eff12");
            Eff23 = (GLoader)GetChild("Eff23");
            Eff13 = (GLoader)GetChild("Eff13");
            itemCount = (GTextField)GetChild("itemCount");
            StarLevel = (GTextField)GetChild("StarLevel");
        }
    }
}
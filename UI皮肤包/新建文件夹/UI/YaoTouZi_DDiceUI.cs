/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class YaoTouZi_DDiceUI : GComponent
    {
        public GImage DDice;
        public GLoader shaiziLoad0;
        public GLoader shaiziLoad1;
        public GLoader shaiziLoad2;
        public GLoader shaiziLoad3;
        public GLoader shaiziLoad4;
        public GLoader shaiziLoad5;
        public GLoader shaiziLoad6;
        public GLoader shaiziLoad7;
        public GLoader shaiziLoad8;
        public GLoader shaiziLoad9;
        public const string URL = "ui://jyvofh5ej3e21pa";

        public static YaoTouZi_DDiceUI CreateInstance()
        {
            return (YaoTouZi_DDiceUI)UIPackage.CreateObject("UI", "摇骰子_DDiceUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DDice = (GImage)GetChild("DDice");
            shaiziLoad0 = (GLoader)GetChild("shaiziLoad0");
            shaiziLoad1 = (GLoader)GetChild("shaiziLoad1");
            shaiziLoad2 = (GLoader)GetChild("shaiziLoad2");
            shaiziLoad3 = (GLoader)GetChild("shaiziLoad3");
            shaiziLoad4 = (GLoader)GetChild("shaiziLoad4");
            shaiziLoad5 = (GLoader)GetChild("shaiziLoad5");
            shaiziLoad6 = (GLoader)GetChild("shaiziLoad6");
            shaiziLoad7 = (GLoader)GetChild("shaiziLoad7");
            shaiziLoad8 = (GLoader)GetChild("shaiziLoad8");
            shaiziLoad9 = (GLoader)GetChild("shaiziLoad9");
        }
    }
}
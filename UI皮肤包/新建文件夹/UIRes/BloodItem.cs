/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BloodItem : GComponent
    {
        public GLoader itembg;
        public GLoader itemicon;
        public const string URL = "ui://jk0io98jp27sgvn2x0";

        public static BloodItem CreateInstance()
        {
            return (BloodItem)UIPackage.CreateObject("UIRes", "BloodItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            itembg = (GLoader)GetChild("itembg");
            itemicon = (GLoader)GetChild("itemicon");
        }
    }
}
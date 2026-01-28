/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class txtComLeft : GComponent
    {
        public GLoader n12;
        public GLoader n0;
        public GTextField sNameTxt;
        public const string URL = "ui://use7blkkr7r83y";

        public static txtComLeft CreateInstance()
        {
            return (txtComLeft)UIPackage.CreateObject("BaseRes", "txtComLeft");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n12 = (GLoader)GetChild("n12");
            n0 = (GLoader)GetChild("n0");
            sNameTxt = (GTextField)GetChild("sNameTxt");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class txtComRight : GComponent
    {
        public GLoader n0;
        public GTextField sNameTxt;
        public GLoader n12;
        public const string URL = "ui://use7blkkr7r83z";

        public static txtComRight CreateInstance()
        {
            return (txtComRight)UIPackage.CreateObject("BaseRes", "txtComRight");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GLoader)GetChild("n0");
            sNameTxt = (GTextField)GetChild("sNameTxt");
            n12 = (GLoader)GetChild("n12");
        }
    }
}
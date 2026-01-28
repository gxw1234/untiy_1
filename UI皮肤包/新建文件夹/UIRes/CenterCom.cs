/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CenterCom : GComponent
    {
        public GImage clentermsgbg;
        public GTextField centermsg;
        public const string URL = "ui://jk0io98jv9b1fz";

        public static CenterCom CreateInstance()
        {
            return (CenterCom)UIPackage.CreateObject("UIRes", "CenterCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            clentermsgbg = (GImage)GetChild("clentermsgbg");
            centermsg = (GTextField)GetChild("centermsg");
        }
    }
}
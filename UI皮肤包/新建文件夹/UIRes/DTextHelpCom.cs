/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DTextHelpCom : GComponent
    {
        public GTextField textTips;
        public const string URL = "ui://jk0io98js2h3gvn2x8";

        public static DTextHelpCom CreateInstance()
        {
            return (DTextHelpCom)UIPackage.CreateObject("UIRes", "DTextHelpCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            textTips = (GTextField)GetChild("textTips");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FormId
{
    public partial class FormIDListCom : GComponent
    {
        public GTextField n0;
        public const string URL = "ui://vf3w6hiq6v5dj";

        public static FormIDListCom CreateInstance()
        {
            return (FormIDListCom)UIPackage.CreateObject("FormId", "FormIDListCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GTextField)GetChild("n0");
        }
    }
}
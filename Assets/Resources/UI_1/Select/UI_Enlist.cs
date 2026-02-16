/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Select
{
    public partial class UI_Enlist : GComponent
    {
        public GList m_Region;
        public GList m_Neighborhood;
        public const string URL = "ui://2q0aw32tldap1";

        public static UI_Enlist CreateInstance()
        {
            return (UI_Enlist)UIPackage.CreateObject("Select", "Enlist");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Region = (GList)GetChildAt(1);
            m_Neighborhood = (GList)GetChildAt(2);
        }
    }
}
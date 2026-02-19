/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace home
{
    public partial class UI_Component1 : GComponent
    {
        public GList m_item_list;
        public GButton m_close;
        public const string URL = "ui://14vi3e7uhppd0";

        public static UI_Component1 CreateInstance()
        {
            return (UI_Component1)UIPackage.CreateObject("home", "Component1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item_list = (GList)GetChildAt(1);
            m_close = (GButton)GetChildAt(2);
        }
    }
}
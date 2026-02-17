/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_logint_ui : GComponent
    {
        public GButton m_Registration;
        public GButton m_Change_password;
        public GButton m_Electoral_district;
        public const string URL = "ui://6zme3ysjmj8e1";

        public static UI_logint_ui CreateInstance()
        {
            return (UI_logint_ui)UIPackage.CreateObject("Login", "logint_ui");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Registration = (GButton)GetChildAt(7);
            m_Change_password = (GButton)GetChildAt(8);
            m_Electoral_district = (GButton)GetChildAt(9);
        }
    }
}
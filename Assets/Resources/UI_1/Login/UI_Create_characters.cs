/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_Create_characters : GComponent
    {
        public GButton m_zs;
        public GTextInput m_name;
        public GButton m_fs;
        public GButton m_ds;
        public GButton m_Man;
        public GButton m_Woman;
        public GButton m_Completed;
        public GButton m_Shut_down;
        public const string URL = "ui://6zme3ysjkk2em";

        public static UI_Create_characters CreateInstance()
        {
            return (UI_Create_characters)UIPackage.CreateObject("Login", "Create_characters");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_zs = (GButton)GetChildAt(1);
            m_name = (GTextInput)GetChildAt(2);
            m_fs = (GButton)GetChildAt(3);
            m_ds = (GButton)GetChildAt(4);
            m_Man = (GButton)GetChildAt(5);
            m_Woman = (GButton)GetChildAt(6);
            m_Completed = (GButton)GetChildAt(7);
            m_Shut_down = (GButton)GetChildAt(8);
        }
    }
}
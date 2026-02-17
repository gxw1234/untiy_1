/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_Register_account : GComponent
    {
        public GButton m_Register_Button;
        public GButton m_return_Button;
        public GTextInput m_Account;
        public GTextInput m_Password;
        public GTextInput m_Password_1;
        public const string URL = "ui://6zme3ysjc3jcr";

        public static UI_Register_account CreateInstance()
        {
            return (UI_Register_account)UIPackage.CreateObject("Login", "Register_account");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Register_Button = (GButton)GetChildAt(1);
            m_return_Button = (GButton)GetChildAt(2);
            m_Account = (GTextInput)GetChildAt(3);
            m_Password = (GTextInput)GetChildAt(4);
            m_Password_1 = (GTextInput)GetChildAt(5);
        }
    }
}
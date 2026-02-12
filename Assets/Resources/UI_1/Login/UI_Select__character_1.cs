/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_Select__character_1 : GComponent
    {
        public GButton m_start_Game;
        public GTextInput m_name_1;
        public GTextInput m_Level_1;
        public GTextInput m_Occupation_1;
        public GTextInput m_Gender_1;
        public const string URL = "ui://6zme3ysjudord";

        public static UI_Select__character_1 CreateInstance()
        {
            return (UI_Select__character_1)UIPackage.CreateObject("Login", "Select _character_1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_start_Game = (GButton)GetChildAt(1);
            m_name_1 = (GTextInput)GetChildAt(2);
            m_Level_1 = (GTextInput)GetChildAt(3);
            m_Occupation_1 = (GTextInput)GetChildAt(4);
            m_Gender_1 = (GTextInput)GetChildAt(11);
        }
    }
}
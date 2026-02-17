/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Common
{
    public partial class UI_Button_Transparency : GComponent
    {
        public GButton m_ok;
        public GTextField m_test;
        public const string URL = "ui://6r0lfmdkc3jci";

        public static UI_Button_Transparency CreateInstance()
        {
            return (UI_Button_Transparency)UIPackage.CreateObject("Common", "Button_Transparency");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_ok = (GButton)GetChildAt(1);
            m_test = (GTextField)GetChildAt(2);
        }
    }
}
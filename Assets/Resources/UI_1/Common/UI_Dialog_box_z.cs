/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Common
{
    public partial class UI_Dialog_box_z : GComponent
    {
        public GButton m_yes;
        public GButton m_no;
        public const string URL = "ui://6r0lfmdkkk2ef";

        public static UI_Dialog_box_z CreateInstance()
        {
            return (UI_Dialog_box_z)UIPackage.CreateObject("Common", "Dialog_box_z");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_yes = (GButton)GetChildAt(1);
            m_no = (GButton)GetChildAt(2);
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Select
{
    public partial class UI_Prefecture : GComponent
    {
        public GButton m_Electoral_district;
        public GButton m_Enter_the_game;
        public const string URL = "ui://2q0aw32tjgjya";

        public static UI_Prefecture CreateInstance()
        {
            return (UI_Prefecture)UIPackage.CreateObject("Select", "Prefecture");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Electoral_district = (GButton)GetChildAt(0);
            m_Enter_the_game = (GButton)GetChildAt(1);
        }
    }
}
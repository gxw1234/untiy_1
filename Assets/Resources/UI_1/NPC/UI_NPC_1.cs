/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace NPC
{
    public partial class UI_NPC_1 : GComponent
    {
        public GButton m_Shut_down;
        public GRichTextField m_dialog_text;
        public const string URL = "ui://elt9oh38o4rw1";

        public static UI_NPC_1 CreateInstance()
        {
            return (UI_NPC_1)UIPackage.CreateObject("NPC", "NPC_1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Shut_down = (GButton)GetChildAt(1);
            m_dialog_text = (GRichTextField)GetChildAt(2);
        }
    }
}
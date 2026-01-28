/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class NPCMode : GComponent
    {
        public GGraph bg;
        public SignOutBtn SignOutBtn;
        public SwitchBtn SwitchBtn;
        public Panel Panel;
        public SelAllBtn SelAllBtn;
        public GTextField Left;
        public GTextInput LeftInput;
        public GTextField Top;
        public GTextInput TopInput;
        public const string URL = "ui://use7blkkqgn292";

        public static NPCMode CreateInstance()
        {
            return (NPCMode)UIPackage.CreateObject("BaseRes", "NPCMode");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            SignOutBtn = (SignOutBtn)GetChild("SignOutBtn");
            SwitchBtn = (SwitchBtn)GetChild("SwitchBtn");
            Panel = (Panel)GetChild("Panel");
            SelAllBtn = (SelAllBtn)GetChild("SelAllBtn");
            Left = (GTextField)GetChild("Left");
            LeftInput = (GTextInput)GetChild("LeftInput");
            Top = (GTextField)GetChild("Top");
            TopInput = (GTextInput)GetChild("TopInput");
        }
    }
}
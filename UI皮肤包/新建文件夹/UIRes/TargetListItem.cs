/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TargetListItem : GButton
    {
        public Controller button;
        public GImage select;
        public GImage bg;
        public GLoader targetIcon;
        public GTextField targetName;
        public TargetHP targetHP;
        public const string URL = "ui://jk0io98js33613";

        public static TargetListItem CreateInstance()
        {
            return (TargetListItem)UIPackage.CreateObject("UIRes", "TargetListItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            select = (GImage)GetChild("select");
            bg = (GImage)GetChild("bg");
            targetIcon = (GLoader)GetChild("targetIcon");
            targetName = (GTextField)GetChild("targetName");
            targetHP = (TargetHP)GetChild("targetHP");
        }
    }
}
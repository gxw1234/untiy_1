/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DSkillItem : GComponent
    {
        public GImage DSkillItemBg;
        public GLoader DSkillIconLoader;
        public GTextField ChatEdit41;
        public GImage DA2EIMAGE23;
        public GTextField ChatEdit42;
        public GImage DA2EIMAGE24;
        public GTextField ChatEdit43;
        public GTextField DSkillKey;
        public const string URL = "ui://jk0io98jj3e21f5";

        public static DSkillItem CreateInstance()
        {
            return (DSkillItem)UIPackage.CreateObject("UIRes", "DSkillItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DSkillItemBg = (GImage)GetChild("DSkillItemBg");
            DSkillIconLoader = (GLoader)GetChild("DSkillIconLoader");
            ChatEdit41 = (GTextField)GetChild("ChatEdit41");
            DA2EIMAGE23 = (GImage)GetChild("DA2EIMAGE23");
            ChatEdit42 = (GTextField)GetChild("ChatEdit42");
            DA2EIMAGE24 = (GImage)GetChild("DA2EIMAGE24");
            ChatEdit43 = (GTextField)GetChild("ChatEdit43");
            DSkillKey = (GTextField)GetChild("DSkillKey");
        }
    }
}
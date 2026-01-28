/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LeadWin : GComponent
    {
        public GImage DA2EIMAGE6;
        public GTextField ChatEdit38;
        public GTextField ChatEdit39;
        public GTextField ChatEdit40;
        public GTextField ChatEdit41;
        public GTextField ChatEdit42;
        public GList DA2EGrid4;
        public BtnOneKeyApply BtnOneKeyApply;
        public const string URL = "ui://jk0io98jkn5z17y";

        public static LeadWin CreateInstance()
        {
            return (LeadWin)UIPackage.CreateObject("UIRes", "LeadWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EIMAGE6 = (GImage)GetChild("DA2EIMAGE6");
            ChatEdit38 = (GTextField)GetChild("ChatEdit38");
            ChatEdit39 = (GTextField)GetChild("ChatEdit39");
            ChatEdit40 = (GTextField)GetChild("ChatEdit40");
            ChatEdit41 = (GTextField)GetChild("ChatEdit41");
            ChatEdit42 = (GTextField)GetChild("ChatEdit42");
            DA2EGrid4 = (GList)GetChild("DA2EGrid4");
            BtnOneKeyApply = (BtnOneKeyApply)GetChild("BtnOneKeyApply");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDBlackTitle : GComponent
    {
        public GImage DFDBlackTitle;
        public GTextField ChatEdit5;
        public GTextField ChatEdit7;
        public GTextField ChatEdit8;
        public GTextField ChatEdit9;
        public const string URL = "ui://jk0io98jkn5z155";

        public static DFDBlackTitle CreateInstance()
        {
            return (DFDBlackTitle)UIPackage.CreateObject("UIRes", "DFDBlackTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DFDBlackTitle = (GImage)GetChild("DFDBlackTitle");
            ChatEdit5 = (GTextField)GetChild("ChatEdit5");
            ChatEdit7 = (GTextField)GetChild("ChatEdit7");
            ChatEdit8 = (GTextField)GetChild("ChatEdit8");
            ChatEdit9 = (GTextField)GetChild("ChatEdit9");
        }
    }
}
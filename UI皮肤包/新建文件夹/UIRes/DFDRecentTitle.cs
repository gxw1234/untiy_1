/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDRecentTitle : GComponent
    {
        public GImage DFDRecentTitle;
        public GTextField ChatEdit1;
        public GTextField ChatEdit2;
        public GTextField ChatEdit3;
        public GTextField ChatEdit4;
        public const string URL = "ui://jk0io98jkn5z152";

        public static DFDRecentTitle CreateInstance()
        {
            return (DFDRecentTitle)UIPackage.CreateObject("UIRes", "DFDRecentTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DFDRecentTitle = (GImage)GetChild("DFDRecentTitle");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
            ChatEdit3 = (GTextField)GetChild("ChatEdit3");
            ChatEdit4 = (GTextField)GetChild("ChatEdit4");
        }
    }
}
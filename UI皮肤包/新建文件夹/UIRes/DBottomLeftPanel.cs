/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBottomLeftPanel : GComponent
    {
        public GImage DBottomLeftPanel;
        public GTextField ChatEdit2;
        public GTextField ChatEdit3;
        public GTextField ChatEdit4;
        public GImage DHPBall;
        public GImage DMPBall;
        public const string URL = "ui://jk0io98jj3e21nf";

        public static DBottomLeftPanel CreateInstance()
        {
            return (DBottomLeftPanel)UIPackage.CreateObject("UIRes", "DBottomLeftPanel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBottomLeftPanel = (GImage)GetChild("DBottomLeftPanel");
            ChatEdit2 = (GTextField)GetChild("ChatEdit2");
            ChatEdit3 = (GTextField)GetChild("ChatEdit3");
            ChatEdit4 = (GTextField)GetChild("ChatEdit4");
            DHPBall = (GImage)GetChild("DHPBall");
            DMPBall = (GImage)GetChild("DMPBall");
        }
    }
}
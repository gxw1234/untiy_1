/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiaoYi_DDealRemoteDlgUI : GComponent
    {
        public GImage DDealRemoteDlg;
        public GTextField DWhoName;
        public GTextField DWhoGold;
        public GList DDealRemoteGrid;
        public GButton DA2EButton1;
        public const string URL = "ui://jyvofh5ekn5z18u";

        public static JiaoYi_DDealRemoteDlgUI CreateInstance()
        {
            return (JiaoYi_DDealRemoteDlgUI)UIPackage.CreateObject("UI", "交易_DDealRemoteDlgUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DDealRemoteDlg = (GImage)GetChild("DDealRemoteDlg");
            DWhoName = (GTextField)GetChild("DWhoName");
            DWhoGold = (GTextField)GetChild("DWhoGold");
            DDealRemoteGrid = (GList)GetChild("DDealRemoteGrid");
            DA2EButton1 = (GButton)GetChild("DA2EButton1");
        }
    }
}
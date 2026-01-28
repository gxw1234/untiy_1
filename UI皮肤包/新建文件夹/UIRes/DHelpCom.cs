/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DHelpCom : GComponent
    {
        public GImage n2;
        public DTextHelpCom DTextHelpCom;
        public DBtnStateColse DBtnClose;
        public const string URL = "ui://jk0io98js2h3vn2so";

        public static DHelpCom CreateInstance()
        {
            return (DHelpCom)UIPackage.CreateObject("UIRes", "DHelpCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n2 = (GImage)GetChild("n2");
            DTextHelpCom = (DTextHelpCom)GetChild("DTextHelpCom");
            DBtnClose = (DBtnStateColse)GetChild("DBtnClose");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnSwitchServer : GButton
    {
        public Controller button;
        public GImage Img44027u;
        public GImage Img377lve;
        public const string URL = "ui://us2ut3jfr7r81x";

        public static DBtnSwitchServer CreateInstance()
        {
            return (DBtnSwitchServer)UIPackage.CreateObject("UILoadingRes", "DBtnSwitchServer");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img44027u = (GImage)GetChild("Img44027u");
            Img377lve = (GImage)GetChild("Img377lve");
        }
    }
}
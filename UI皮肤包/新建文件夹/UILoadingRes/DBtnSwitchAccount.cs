/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnSwitchAccount : GButton
    {
        public Controller button;
        public GImage Img3782gg;
        public GImage Img379nxi;
        public const string URL = "ui://us2ut3jfr7r81t";

        public static DBtnSwitchAccount CreateInstance()
        {
            return (DBtnSwitchAccount)UIPackage.CreateObject("UILoadingRes", "DBtnSwitchAccount");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3782gg = (GImage)GetChild("Img3782gg");
            Img379nxi = (GImage)GetChild("Img379nxi");
        }
    }
}
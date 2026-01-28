/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DBtnChangPasswd : GButton
    {
        public Controller button;
        public GImage Img369aj7;
        public GImage Img37084t;
        public const string URL = "ui://us2ut3jfr7r822";

        public static DBtnChangPasswd CreateInstance()
        {
            return (DBtnChangPasswd)UIPackage.CreateObject("UILoadingRes", "DBtnChangPasswd");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img369aj7 = (GImage)GetChild("Img369aj7");
            Img37084t = (GImage)GetChild("Img37084t");
        }
    }
}
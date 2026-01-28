/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSend : GButton
    {
        public Controller button;
        public GImage Img3154u3;
        public GImage Img316b72;
        public const string URL = "ui://jk0io98jj3e21ke";

        public static DBtnSend CreateInstance()
        {
            return (DBtnSend)UIPackage.CreateObject("UIRes", "DBtnSend");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3154u3 = (GImage)GetChild("Img3154u3");
            Img316b72 = (GImage)GetChild("Img316b72");
        }
    }
}
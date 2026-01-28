/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnExchange : GButton
    {
        public Controller button;
        public GImage Img3033m;
        public GImage Img3275p;
        public const string URL = "ui://jk0io98jj3e21nx";

        public static DBtnExchange CreateInstance()
        {
            return (DBtnExchange)UIPackage.CreateObject("UIRes", "DBtnExchange");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3033m = (GImage)GetChild("Img3033m");
            Img3275p = (GImage)GetChild("Img3275p");
        }
    }
}
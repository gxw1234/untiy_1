/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnMagic : GButton
    {
        public Controller button;
        public GImage Img10a5g;
        public const string URL = "ui://jk0io98jj3e21nk";

        public static DBtnMagic CreateInstance()
        {
            return (DBtnMagic)UIPackage.CreateObject("UIRes", "DBtnMagic");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10a5g = (GImage)GetChild("Img10a5g");
        }
    }
}
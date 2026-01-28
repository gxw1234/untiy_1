/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnQueryBagItems : GButton
    {
        public Controller button;
        public GImage Img10j87;
        public GImage Img110il;
        public GTextField ChatEdit3;
        public const string URL = "ui://jk0io98jv9b14z";

        public static DBtnQueryBagItems CreateInstance()
        {
            return (DBtnQueryBagItems)UIPackage.CreateObject("UIRes", "DBtnQueryBagItems");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10j87 = (GImage)GetChild("Img10j87");
            Img110il = (GImage)GetChild("Img110il");
            ChatEdit3 = (GTextField)GetChild("ChatEdit3");
        }
    }
}
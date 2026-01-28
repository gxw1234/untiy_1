/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnShop : GButton
    {
        public Controller button;
        public GImage Img830ns;
        public GImage Img848wp;
        public const string URL = "ui://jk0io98jk02tn1ug";

        public static DBtnShop CreateInstance()
        {
            return (DBtnShop)UIPackage.CreateObject("UIRes", "DBtnShop");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img830ns = (GImage)GetChild("Img830ns");
            Img848wp = (GImage)GetChild("Img848wp");
        }
    }
}
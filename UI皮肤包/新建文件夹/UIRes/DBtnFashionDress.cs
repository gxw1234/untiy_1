/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnFashionDress : GButton
    {
        public Controller button;
        public GImage Img785ccu;
        public GImage Img7863no;
        public const string URL = "ui://jk0io98jk02tn1uo";

        public static DBtnFashionDress CreateInstance()
        {
            return (DBtnFashionDress)UIPackage.CreateObject("UIRes", "DBtnFashionDress");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img785ccu = (GImage)GetChild("Img785ccu");
            Img7863no = (GImage)GetChild("Img7863no");
        }
    }
}
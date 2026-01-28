/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SearchButton2 : GButton
    {
        public Controller button;
        public GImage n0;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9og1f";

        public static SearchButton2 CreateInstance()
        {
            return (SearchButton2)UIPackage.CreateObject("UIRes", "SearchButton2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            title = (GTextField)GetChild("title");
        }
    }
}
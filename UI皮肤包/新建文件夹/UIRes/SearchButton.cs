/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SearchButton : GButton
    {
        public Controller button;
        public GImage n0;
        public GTextField title;
        public const string URL = "ui://jk0io98jm9ogf";

        public static SearchButton CreateInstance()
        {
            return (SearchButton)UIPackage.CreateObject("UIRes", "SearchButton");
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
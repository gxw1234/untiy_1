/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DChatToptem : GComponent
    {
        public GGraph background;
        public GGraph ChatWindowBG1;
        public GRichTextField ChatWindowText1;
        public const string URL = "ui://jk0io98jj3e21kq";

        public static DChatToptem CreateInstance()
        {
            return (DChatToptem)UIPackage.CreateObject("UIRes", "DChatToptem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            background = (GGraph)GetChild("background");
            ChatWindowBG1 = (GGraph)GetChild("ChatWindowBG1");
            ChatWindowText1 = (GRichTextField)GetChild("ChatWindowText1");
        }
    }
}
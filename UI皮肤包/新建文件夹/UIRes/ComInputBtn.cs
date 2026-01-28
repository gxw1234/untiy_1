/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComInputBtn : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GRichTextField n2;
        public GRichTextField n3;
        public const string URL = "ui://jk0io98js336b";

        public static ComInputBtn CreateInstance()
        {
            return (ComInputBtn)UIPackage.CreateObject("UIRes", "ComInputBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GRichTextField)GetChild("n2");
            n3 = (GRichTextField)GetChild("n3");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkill2Item : GButton
    {
        public Controller button;
        public GImage Img415g3b;
        public GImage Img416okf;
        public GTextField title;
        public const string URL = "ui://jk0io98jj4kye";

        public static ComSkill2Item CreateInstance()
        {
            return (ComSkill2Item)UIPackage.CreateObject("UIRes", "ComSkill2Item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415g3b = (GImage)GetChild("Img415g3b");
            Img416okf = (GImage)GetChild("Img416okf");
            title = (GTextField)GetChild("title");
        }
    }
}
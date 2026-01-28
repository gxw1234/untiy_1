/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSkillItem4 : GButton
    {
        public Controller button;
        public GImage Img415g3b;
        public GImage Img416okf;
        public GTextField title;
        public const string URL = "ui://jk0io98js336gvn2wh";

        public static ComSkillItem4 CreateInstance()
        {
            return (ComSkillItem4)UIPackage.CreateObject("UIRes", "ComSkillItem4");
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
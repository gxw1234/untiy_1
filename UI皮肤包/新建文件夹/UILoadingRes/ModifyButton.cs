/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class ModifyButton : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://us2ut3jfps2x10";

        public static ModifyButton CreateInstance()
        {
            return (ModifyButton)UIPackage.CreateObject("UILoadingRes", "ModifyButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
        }
    }
}
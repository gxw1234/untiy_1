/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RoleRidBtn7 : GButton
    {
        public Controller button;
        public GImage n5;
        public GImage n6;
        public GTextField title;
        public const string URL = "ui://jk0io98jj3e21cy";

        public static RoleRidBtn7 CreateInstance()
        {
            return (RoleRidBtn7)UIPackage.CreateObject("UIRes", "RoleRidBtn7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n5 = (GImage)GetChild("n5");
            n6 = (GImage)GetChild("n6");
            title = (GTextField)GetChild("title");
        }
    }
}
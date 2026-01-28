/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Hero1 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GImage n2;
        public GImage n3;
        public const string URL = "ui://jk0io98jpnb5gvn30d";

        public static Hero1 CreateInstance()
        {
            return (Hero1)UIPackage.CreateObject("UIRes", "Hero1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n2 = (GImage)GetChild("n2");
            n3 = (GImage)GetChild("n3");
        }
    }
}
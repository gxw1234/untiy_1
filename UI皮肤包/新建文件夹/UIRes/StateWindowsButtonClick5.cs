/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class StateWindowsButtonClick5 : GButton
    {
        public Controller button;
        public GImage n0;
        public GImage n1;
        public GTextField title;
        public const string URL = "ui://jk0io98jrxzwgvn2uv";

        public static StateWindowsButtonClick5 CreateInstance()
        {
            return (StateWindowsButtonClick5)UIPackage.CreateObject("UIRes", "StateWindowsButtonClick5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            title = (GTextField)GetChild("title");
        }
    }
}
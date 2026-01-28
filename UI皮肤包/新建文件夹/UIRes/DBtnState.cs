/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnState : GButton
    {
        public Controller button;
        public GImage Img79402;
        public GImage Img80w30;
        public const string URL = "ui://jk0io98jmyy9gvn2xu";

        public static DBtnState CreateInstance()
        {
            return (DBtnState)UIPackage.CreateObject("UIRes", "DBtnState");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img79402 = (GImage)GetChild("Img79402");
            Img80w30 = (GImage)GetChild("Img80w30");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CheckBoxOpen : GButton
    {
        public Controller button;
        public GImage Img176102;
        public GImage Img177rw8;
        public const string URL = "ui://jk0io98jkn5z181";

        public static CheckBoxOpen CreateInstance()
        {
            return (CheckBoxOpen)UIPackage.CreateObject("UIRes", "CheckBoxOpen");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176102 = (GImage)GetChild("Img176102");
            Img177rw8 = (GImage)GetChild("Img177rw8");
        }
    }
}
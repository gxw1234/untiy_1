/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class btn3 : GButton
    {
        public Controller button;
        public GImage Img795052;
        public GImage Img796c52;
        public const string URL = "ui://jk0io98jv9b14x";

        public static btn3 CreateInstance()
        {
            return (btn3)UIPackage.CreateObject("UIRes", "btn3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img795052 = (GImage)GetChild("Img795052");
            Img796c52 = (GImage)GetChild("Img796c52");
        }
    }
}
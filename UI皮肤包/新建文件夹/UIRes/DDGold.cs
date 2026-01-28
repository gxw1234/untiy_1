/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DDGold : GButton
    {
        public Controller button;
        public GImage Img9ph3;
        public GImage Img9bie;
        public const string URL = "ui://jk0io98jkn5z18r";

        public static DDGold CreateInstance()
        {
            return (DDGold)UIPackage.CreateObject("UIRes", "DDGold");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img9ph3 = (GImage)GetChild("Img9ph3");
            Img9bie = (GImage)GetChild("Img9bie");
        }
    }
}
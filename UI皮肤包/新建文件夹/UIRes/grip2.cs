/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class grip2 : GButton
    {
        public Controller button;
        public GImage Img422356;
        public GImage Img422e30;
        public const string URL = "ui://jk0io98jkn5zxf";

        public static grip2 CreateInstance()
        {
            return (grip2)UIPackage.CreateObject("UIRes", "grip2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img422356 = (GImage)GetChild("Img422356");
            Img422e30 = (GImage)GetChild("Img422e30");
        }
    }
}
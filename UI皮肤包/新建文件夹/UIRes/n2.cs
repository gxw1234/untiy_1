/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class n2 : GComboBox
    {
        public Controller button;
        public GImage Img618w23;
        public GImage Img61824n;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5z11h";

        public static n2 CreateInstance()
        {
            return (n2)UIPackage.CreateObject("UIRes", "n2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img618w23 = (GImage)GetChild("Img618w23");
            Img61824n = (GImage)GetChild("Img61824n");
            title = (GTextField)GetChild("title");
        }
    }
}
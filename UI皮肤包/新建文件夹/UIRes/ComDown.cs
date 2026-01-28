/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComDown : GComboBox
    {
        public Controller button;
        public GImage Img423e3v;
        public GImage Img424x2o;
        public GTextField title;
        public const string URL = "ui://jk0io98jfoo92";

        public static ComDown CreateInstance()
        {
            return (ComDown)UIPackage.CreateObject("UIRes", "ComDown");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img423e3v = (GImage)GetChild("Img423e3v");
            Img424x2o = (GImage)GetChild("Img424x2o");
            title = (GTextField)GetChild("title");
        }
    }
}
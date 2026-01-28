/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class n1 : GComboBox
    {
        public Controller button;
        public GImage Img423e3v;
        public GImage Img424x2o;
        public GTextField title;
        public const string URL = "ui://jk0io98jkn5zxb";

        public static n1 CreateInstance()
        {
            return (n1)UIPackage.CreateObject("UIRes", "n1");
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
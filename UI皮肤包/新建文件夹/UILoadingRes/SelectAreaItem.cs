/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class SelectAreaItem : GButton
    {
        public Controller button;
        public GImage Img3905lu;
        public GImage Img391842;
        public GTextField EditText;
        public const string URL = "ui://us2ut3jfr7r82f";

        public static SelectAreaItem CreateInstance()
        {
            return (SelectAreaItem)UIPackage.CreateObject("UILoadingRes", "SelectAreaItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img3905lu = (GImage)GetChild("Img3905lu");
            Img391842 = (GImage)GetChild("Img391842");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class SelectGroupItem : GButton
    {
        public Controller button;
        public GImage Img392823;
        public GImage Img39337k;
        public GImage Flag;
        public GImage StateImg1;
        public GImage StateImg2;
        public GImage StateImg3;
        public GTextField EditText;
        public const string URL = "ui://us2ut3jfr7r82g";

        public static SelectGroupItem CreateInstance()
        {
            return (SelectGroupItem)UIPackage.CreateObject("UILoadingRes", "SelectGroupItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img392823 = (GImage)GetChild("Img392823");
            Img39337k = (GImage)GetChild("Img39337k");
            Flag = (GImage)GetChild("Flag");
            StateImg1 = (GImage)GetChild("StateImg1");
            StateImg2 = (GImage)GetChild("StateImg2");
            StateImg3 = (GImage)GetChild("StateImg3");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
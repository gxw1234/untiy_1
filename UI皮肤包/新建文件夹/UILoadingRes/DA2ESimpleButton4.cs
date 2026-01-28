/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DA2ESimpleButton4 : GButton
    {
        public Controller button;
        public GImage Img392pl6;
        public GImage Img3933x1;
        public GImage DA2EIMAGE1;
        public GImage Flag;
        public GImage StateImg1;
        public GImage StateImg2;
        public GImage StateImg3;
        public GTextField EditText;
        public const string URL = "ui://us2ut3jfr7r81r";

        public static DA2ESimpleButton4 CreateInstance()
        {
            return (DA2ESimpleButton4)UIPackage.CreateObject("UILoadingRes", "DA2ESimpleButton4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img392pl6 = (GImage)GetChild("Img392pl6");
            Img3933x1 = (GImage)GetChild("Img3933x1");
            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            Flag = (GImage)GetChild("Flag");
            StateImg1 = (GImage)GetChild("StateImg1");
            StateImg2 = (GImage)GetChild("StateImg2");
            StateImg3 = (GImage)GetChild("StateImg3");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
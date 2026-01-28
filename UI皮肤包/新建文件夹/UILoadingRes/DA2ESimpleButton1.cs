/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DA2ESimpleButton1 : GButton
    {
        public Controller button;
        public GImage Img392gvu;
        public GImage Img39336o;
        public GImage DBtnServerIcon;
        public GImage Flag;
        public GImage StateImg1;
        public GImage StateImg2;
        public GImage StateImg3;
        public GTextField EditText;
        public const string URL = "ui://us2ut3jfr7r81q";

        public static DA2ESimpleButton1 CreateInstance()
        {
            return (DA2ESimpleButton1)UIPackage.CreateObject("UILoadingRes", "DA2ESimpleButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img392gvu = (GImage)GetChild("Img392gvu");
            Img39336o = (GImage)GetChild("Img39336o");
            DBtnServerIcon = (GImage)GetChild("DBtnServerIcon");
            Flag = (GImage)GetChild("Flag");
            StateImg1 = (GImage)GetChild("StateImg1");
            StateImg2 = (GImage)GetChild("StateImg2");
            StateImg3 = (GImage)GetChild("StateImg3");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
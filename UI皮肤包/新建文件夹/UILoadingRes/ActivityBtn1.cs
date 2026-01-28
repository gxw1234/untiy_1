/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class ActivityBtn1 : GButton
    {
        public Controller button;
        public GImage Img498p8s;
        public GImage Img49710r;
        public GLoader ActivityLoad;
        public GLoader UpdateLoad;
        public GTextField EditText;
        public const string URL = "ui://us2ut3jfk2h33w";

        public static ActivityBtn1 CreateInstance()
        {
            return (ActivityBtn1)UIPackage.CreateObject("UILoadingRes", "ActivityBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img498p8s = (GImage)GetChild("Img498p8s");
            Img49710r = (GImage)GetChild("Img49710r");
            ActivityLoad = (GLoader)GetChild("ActivityLoad");
            UpdateLoad = (GLoader)GetChild("UpdateLoad");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
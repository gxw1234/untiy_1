/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class AllExtractBtn : GButton
    {
        public Controller button;
        public GImage Img837887;
        public GImage Img838gs2;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zyp";

        public static AllExtractBtn CreateInstance()
        {
            return (AllExtractBtn)UIPackage.CreateObject("UIRes", "AllExtractBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img837887 = (GImage)GetChild("Img837887");
            Img838gs2 = (GImage)GetChild("Img838gs2");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
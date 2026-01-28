/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnMainTask : GButton
    {
        public Controller button;
        public GImage Img184ux2;
        public GImage Img1836i8;
        public GTextField EditText;
        public const string URL = "ui://jk0io98j6hm33";

        public static BtnMainTask CreateInstance()
        {
            return (BtnMainTask)UIPackage.CreateObject("UIRes", "BtnMainTask");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img184ux2 = (GImage)GetChild("Img184ux2");
            Img1836i8 = (GImage)GetChild("Img1836i8");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnBranch : GButton
    {
        public Controller button;
        public GImage Img184e28;
        public GImage Img183lhl;
        public GTextField EditText;
        public const string URL = "ui://jk0io98j7yw4l";

        public static BtnBranch CreateInstance()
        {
            return (BtnBranch)UIPackage.CreateObject("UIRes", "BtnBranch");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img184e28 = (GImage)GetChild("Img184e28");
            Img183lhl = (GImage)GetChild("Img183lhl");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
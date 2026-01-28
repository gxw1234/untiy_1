/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnItemCancle : GButton
    {
        public Controller button;
        public GImage Img366qk6;
        public GImage Img367cva;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21gd";

        public static BtnItemCancle CreateInstance()
        {
            return (BtnItemCancle)UIPackage.CreateObject("UIRes", "BtnItemCancle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img366qk6 = (GImage)GetChild("Img366qk6");
            Img367cva = (GImage)GetChild("Img367cva");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
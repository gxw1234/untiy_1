/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnStallCancle : GButton
    {
        public Controller button;
        public GImage Img366215;
        public GImage Img367bso;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21gh";

        public static BtnStallCancle CreateInstance()
        {
            return (BtnStallCancle)UIPackage.CreateObject("UIRes", "BtnStallCancle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img366215 = (GImage)GetChild("Img366215");
            Img367bso = (GImage)GetChild("Img367bso");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
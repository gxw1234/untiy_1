/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnPresent : GButton
    {
        public Controller button;
        public GImage Img40803o;
        public GImage Img409n1w;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zw7";

        public static BtnPresent CreateInstance()
        {
            return (BtnPresent)UIPackage.CreateObject("UIRes", "BtnPresent");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img40803o = (GImage)GetChild("Img40803o");
            Img409n1w = (GImage)GetChild("Img409n1w");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EButton1 : GButton
    {
        public Controller button;
        public GImage Img9654;
        public GImage Img9858;
        public GLoader icon;
        public const string URL = "ui://jk0io98jv9b14y";

        public static DA2EButton1 CreateInstance()
        {
            return (DA2EButton1)UIPackage.CreateObject("UIRes", "DA2EButton1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img9654 = (GImage)GetChild("Img9654");
            Img9858 = (GImage)GetChild("Img9858");
            icon = (GLoader)GetChild("icon");
        }
    }
}
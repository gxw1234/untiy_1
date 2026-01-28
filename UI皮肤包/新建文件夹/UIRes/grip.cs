/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class grip : GButton
    {
        public Controller button;
        public GImage Img419p57;
        public GImage Img419fqo;
        public const string URL = "ui://jk0io98jkn5zw8";

        public static grip CreateInstance()
        {
            return (grip)UIPackage.CreateObject("UIRes", "grip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img419p57 = (GImage)GetChild("Img419p57");
            Img419fqo = (GImage)GetChild("Img419fqo");
        }
    }
}
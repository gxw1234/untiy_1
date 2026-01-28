/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CheckBAllow : GButton
    {
        public Controller button;
        public GImage Img176w2s;
        public GImage Img177n44;
        public const string URL = "ui://jk0io98jkn5z17s";

        public static CheckBAllow CreateInstance()
        {
            return (CheckBAllow)UIPackage.CreateObject("UIRes", "CheckBAllow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176w2s = (GImage)GetChild("Img176w2s");
            Img177n44 = (GImage)GetChild("Img177n44");
        }
    }
}
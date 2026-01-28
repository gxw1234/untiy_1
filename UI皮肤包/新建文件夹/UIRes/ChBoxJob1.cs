/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ChBoxJob1 : GButton
    {
        public Controller button;
        public GImage Img176rid;
        public GImage Img177n5k;
        public const string URL = "ui://jk0io98jkn5z16x";

        public static ChBoxJob1 CreateInstance()
        {
            return (ChBoxJob1)UIPackage.CreateObject("UIRes", "ChBoxJob1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img176rid = (GImage)GetChild("Img176rid");
            Img177n5k = (GImage)GetChild("Img177n5k");
        }
    }
}
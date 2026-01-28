/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class grip1 : GButton
    {
        public Controller button;
        public GImage Img42260j;
        public GImage Img422834;
        public const string URL = "ui://jk0io98jkn5zxd";

        public static grip1 CreateInstance()
        {
            return (grip1)UIPackage.CreateObject("UIRes", "grip1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img42260j = (GImage)GetChild("Img42260j");
            Img422834 = (GImage)GetChild("Img422834");
        }
    }
}
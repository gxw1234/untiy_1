/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnStorageUIClose : GButton
    {
        public Controller button;
        public GImage Img05iu;
        public GImage Img14e8;
        public const string URL = "ui://jk0io98jkn5zzg";

        public static BtnStorageUIClose CreateInstance()
        {
            return (BtnStorageUIClose)UIPackage.CreateObject("UIRes", "BtnStorageUIClose");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img05iu = (GImage)GetChild("Img05iu");
            Img14e8 = (GImage)GetChild("Img14e8");
        }
    }
}
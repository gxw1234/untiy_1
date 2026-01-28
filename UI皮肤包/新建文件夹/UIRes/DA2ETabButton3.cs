/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton3 : GButton
    {
        public Controller button;
        public GImage Img428oj8;
        public GImage Img427cip;
        public const string URL = "ui://jk0io98jkn5zxr";

        public static DA2ETabButton3 CreateInstance()
        {
            return (DA2ETabButton3)UIPackage.CreateObject("UIRes", "DA2ETabButton3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img428oj8 = (GImage)GetChild("Img428oj8");
            Img427cip = (GImage)GetChild("Img427cip");
        }
    }
}
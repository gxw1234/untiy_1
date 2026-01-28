/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox16 : GButton
    {
        public Controller button;
        public GImage Img4152hi;
        public GImage Img416uxx;
        public const string URL = "ui://jk0io98jkn5zwo";

        public static DA2ECheckBox16 CreateInstance()
        {
            return (DA2ECheckBox16)UIPackage.CreateObject("UIRes", "DA2ECheckBox16");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4152hi = (GImage)GetChild("Img4152hi");
            Img416uxx = (GImage)GetChild("Img416uxx");
        }
    }
}
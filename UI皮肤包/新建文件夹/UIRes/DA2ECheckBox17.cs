/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ECheckBox17 : GButton
    {
        public Controller button;
        public GImage Img415k13;
        public GImage Img4160bq;
        public const string URL = "ui://jk0io98jkn5zwu";

        public static DA2ECheckBox17 CreateInstance()
        {
            return (DA2ECheckBox17)UIPackage.CreateObject("UIRes", "DA2ECheckBox17");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img415k13 = (GImage)GetChild("Img415k13");
            Img4160bq = (GImage)GetChild("Img4160bq");
        }
    }
}
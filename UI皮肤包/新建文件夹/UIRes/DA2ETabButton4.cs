/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ETabButton4 : GButton
    {
        public Controller button;
        public GImage Img842id7;
        public GImage Img8412ji;
        public const string URL = "ui://jk0io98jkn5zxt";

        public static DA2ETabButton4 CreateInstance()
        {
            return (DA2ETabButton4)UIPackage.CreateObject("UIRes", "DA2ETabButton4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img842id7 = (GImage)GetChild("Img842id7");
            Img8412ji = (GImage)GetChild("Img8412ji");
        }
    }
}
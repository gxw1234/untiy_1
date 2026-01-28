/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2ESimpleButton3 : GButton
    {
        public Controller button;
        public GImage Img10800;
        public GImage Img11r7y;
        public GTextField ChatEdit16;
        public const string URL = "ui://use7blkkqgn275";

        public static DA2ESimpleButton3 CreateInstance()
        {
            return (DA2ESimpleButton3)UIPackage.CreateObject("BaseRes", "DA2ESimpleButton3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10800 = (GImage)GetChild("Img10800");
            Img11r7y = (GImage)GetChild("Img11r7y");
            ChatEdit16 = (GTextField)GetChild("ChatEdit16");
        }
    }
}
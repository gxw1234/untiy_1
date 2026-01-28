/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DA2EWindow2 : GComponent
    {
        public GImage DA2EWindow2;
        public BtnOk2 BtnOk2;
        public BtnColose2 BtnColose2;
        public GTextField Title;
        public GameItemCell1 GameItemCell1;
        public const string URL = "ui://use7blkkqgn28l";

        public static DA2EWindow2 CreateInstance()
        {
            return (DA2EWindow2)UIPackage.CreateObject("BaseRes", "DA2EWindow2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow2 = (GImage)GetChild("DA2EWindow2");
            BtnOk2 = (BtnOk2)GetChild("BtnOk2");
            BtnColose2 = (BtnColose2)GetChild("BtnColose2");
            Title = (GTextField)GetChild("Title");
            GameItemCell1 = (GameItemCell1)GetChild("GameItemCell1");
        }
    }
}
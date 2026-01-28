/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRecoverItem : GButton
    {
        public Controller button;
        public GImage Img350u70;
        public GTextField titleEdit;
        public GImage DA2EIMAGE26;
        public GImage DA2EIMAGE27;
        public GLoader TitleLoader;
        public const string URL = "ui://jk0io98jka2i0";

        public static DRecoverItem CreateInstance()
        {
            return (DRecoverItem)UIPackage.CreateObject("UIRes", "DRecoverItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img350u70 = (GImage)GetChild("Img350u70");
            titleEdit = (GTextField)GetChild("titleEdit");
            DA2EIMAGE26 = (GImage)GetChild("DA2EIMAGE26");
            DA2EIMAGE27 = (GImage)GetChild("DA2EIMAGE27");
            TitleLoader = (GLoader)GetChild("TitleLoader");
        }
    }
}
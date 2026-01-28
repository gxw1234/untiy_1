/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class DNpcDlg : GComponent
    {
        public GImage DA2EIMAGE1;
        public GRichTextField DTips;
        public Btn Btn;
        public GLoader PlayImgEx;
        public DBtnCommonHitUIClose DBtnCommonHitUIClose;
        public const string URL = "ui://use7blkkqgn28m";

        public static DNpcDlg CreateInstance()
        {
            return (DNpcDlg)UIPackage.CreateObject("BaseRes", "DNpcDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EIMAGE1 = (GImage)GetChild("DA2EIMAGE1");
            DTips = (GRichTextField)GetChild("DTips");
            Btn = (Btn)GetChild("Btn");
            PlayImgEx = (GLoader)GetChild("PlayImgEx");
            DBtnCommonHitUIClose = (DBtnCommonHitUIClose)GetChild("DBtnCommonHitUIClose");
        }
    }
}
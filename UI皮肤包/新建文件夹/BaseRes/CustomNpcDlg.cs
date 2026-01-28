/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class CustomNpcDlg : GComponent
    {
        public GLoader bg;
        public frame frame;
        public closeButton closeButton;
        public ImgMulRoot ImgMulRoot;
        public GTextField MirNpcWindow1;
        public const string URL = "ui://use7blkkqgn28j";

        public static CustomNpcDlg CreateInstance()
        {
            return (CustomNpcDlg)UIPackage.CreateObject("BaseRes", "CustomNpcDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GLoader)GetChild("bg");
            frame = (frame)GetChild("frame");
            closeButton = (closeButton)GetChild("closeButton");
            ImgMulRoot = (ImgMulRoot)GetChild("ImgMulRoot");
            MirNpcWindow1 = (GTextField)GetChild("MirNpcWindow1");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class XinYouXiDianWin : GComponent
    {
        public DA2EControl8 DA2EControl8;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16p";

        public static XinYouXiDianWin CreateInstance()
        {
            return (XinYouXiDianWin)UIPackage.CreateObject("UIRes", "XinYouXiDianWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl8 = (DA2EControl8)GetChild("DA2EControl8");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
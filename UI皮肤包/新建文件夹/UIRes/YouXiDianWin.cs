/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class YouXiDianWin : GComponent
    {
        public DA2EControl4 DA2EControl4;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16h";

        public static YouXiDianWin CreateInstance()
        {
            return (YouXiDianWin)UIPackage.CreateObject("UIRes", "YouXiDianWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl4 = (DA2EControl4)GetChild("DA2EControl4");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class JinPiaoWin : GComponent
    {
        public DA2EControl3 DA2EControl3;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16f";

        public static JinPiaoWin CreateInstance()
        {
            return (JinPiaoWin)UIPackage.CreateObject("UIRes", "JinPiaoWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl3 = (DA2EControl3)GetChild("DA2EControl3");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
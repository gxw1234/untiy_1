/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class JinGangShiWin : GComponent
    {
        public DA2EControl6 DA2EControl6;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16l";

        public static JinGangShiWin CreateInstance()
        {
            return (JinGangShiWin)UIPackage.CreateObject("UIRes", "JinGangShiWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl6 = (DA2EControl6)GetChild("DA2EControl6");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
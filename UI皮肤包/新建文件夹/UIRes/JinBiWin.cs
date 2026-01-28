/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class JinBiWin : GComponent
    {
        public DA2EControl1 DA2EControl1;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16b";

        public static JinBiWin CreateInstance()
        {
            return (JinBiWin)UIPackage.CreateObject("UIRes", "JinBiWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl1 = (DA2EControl1)GetChild("DA2EControl1");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
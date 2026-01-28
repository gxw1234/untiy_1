/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class LingFuWin : GComponent
    {
        public DA2EControl7 DA2EControl7;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16n";

        public static LingFuWin CreateInstance()
        {
            return (LingFuWin)UIPackage.CreateObject("UIRes", "LingFuWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl7 = (DA2EControl7)GetChild("DA2EControl7");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
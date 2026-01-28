/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShengWangWin : GComponent
    {
        public DA2EControl9 DA2EControl9;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16r";

        public static ShengWangWin CreateInstance()
        {
            return (ShengWangWin)UIPackage.CreateObject("UIRes", "ShengWangWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl9 = (DA2EControl9)GetChild("DA2EControl9");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
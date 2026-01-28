/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class YuanBaoWin : GComponent
    {
        public DA2EControl2 DA2EControl2;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16d";

        public static YuanBaoWin CreateInstance()
        {
            return (YuanBaoWin)UIPackage.CreateObject("UIRes", "YuanBaoWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl2 = (DA2EControl2)GetChild("DA2EControl2");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
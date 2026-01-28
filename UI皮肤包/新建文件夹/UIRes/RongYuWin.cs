/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RongYuWin : GComponent
    {
        public DA2EControl5 DA2EControl5;
        public GTextField DGLod;
        public const string URL = "ui://jk0io98jv9b16j";

        public static RongYuWin CreateInstance()
        {
            return (RongYuWin)UIPackage.CreateObject("UIRes", "RongYuWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EControl5 = (DA2EControl5)GetChild("DA2EControl5");
            DGLod = (GTextField)GetChild("DGLod");
        }
    }
}
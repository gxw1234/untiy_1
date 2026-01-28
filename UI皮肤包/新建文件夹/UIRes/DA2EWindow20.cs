/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EWindow20 : GComponent
    {
        public GImage DA2EWindow20;
        public GTextField GameVclEdit1;
        public GLoader DA2ELoader70;
        public const string URL = "ui://jk0io98jkn5z12v";

        public static DA2EWindow20 CreateInstance()
        {
            return (DA2EWindow20)UIPackage.CreateObject("UIRes", "DA2EWindow20");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow20 = (GImage)GetChild("DA2EWindow20");
            GameVclEdit1 = (GTextField)GetChild("GameVclEdit1");
            DA2ELoader70 = (GLoader)GetChild("DA2ELoader70");
        }
    }
}
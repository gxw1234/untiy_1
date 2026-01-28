/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class txtComHides : GComponent
    {
        public GLoader DA2ELoader3;
        public txtComLeftAnis txtComLeftAnis;
        public Transition select;
        public const string URL = "ui://use7blkkr7r84a";

        public static txtComHides CreateInstance()
        {
            return (txtComHides)UIPackage.CreateObject("BaseRes", "txtComHides");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader3 = (GLoader)GetChild("DA2ELoader3");
            txtComLeftAnis = (txtComLeftAnis)GetChild("txtComLeftAnis");
            select = GetTransition("select");
        }
    }
}
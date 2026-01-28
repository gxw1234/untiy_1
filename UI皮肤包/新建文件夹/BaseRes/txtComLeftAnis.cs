/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class txtComLeftAnis : GComponent
    {
        public GLoader DA2ELoader4;
        public GTextField ChatEdit1;
        public const string URL = "ui://use7blkkr7r849";

        public static txtComLeftAnis CreateInstance()
        {
            return (txtComLeftAnis)UIPackage.CreateObject("BaseRes", "txtComLeftAnis");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader4 = (GLoader)GetChild("DA2ELoader4");
            ChatEdit1 = (GTextField)GetChild("ChatEdit1");
        }
    }
}
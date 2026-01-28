/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComDownBox2 : GComponent
    {
        public GImage DA2EWindow14;
        public n1 n1;
        public const string URL = "ui://jk0io98jj4ky5";

        public static ComDownBox2 CreateInstance()
        {
            return (ComDownBox2)UIPackage.CreateObject("UIRes", "ComDownBox2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow14 = (GImage)GetChild("DA2EWindow14");
            n1 = (n1)GetChild("n1");
        }
    }
}
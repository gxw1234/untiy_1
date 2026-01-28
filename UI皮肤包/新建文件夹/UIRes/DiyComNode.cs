/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DiyComNode : GComponent
    {
        public DiyCom n4;
        public const string URL = "ui://jk0io98jmhay2";

        public static DiyComNode CreateInstance()
        {
            return (DiyComNode)UIPackage.CreateObject("UIRes", "DiyComNode");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n4 = (DiyCom)GetChild("n4");
        }
    }
}
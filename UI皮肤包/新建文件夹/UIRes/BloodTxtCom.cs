/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BloodTxtCom : GComponent
    {
        public GGraph n3;
        public const string URL = "ui://jk0io98jv9b1gb";

        public static BloodTxtCom CreateInstance()
        {
            return (BloodTxtCom)UIPackage.CreateObject("UIRes", "BloodTxtCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n3 = (GGraph)GetChild("n3");
        }
    }
}
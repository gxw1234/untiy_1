/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class NameTxtCom : GComponent
    {
        public GTextField HeadEdit;
        public GGraph n3;
        public const string URL = "ui://jk0io98jv9b1gc";

        public static NameTxtCom CreateInstance()
        {
            return (NameTxtCom)UIPackage.CreateObject("UIRes", "NameTxtCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            HeadEdit = (GTextField)GetChild("HeadEdit");
            n3 = (GGraph)GetChild("n3");
        }
    }
}
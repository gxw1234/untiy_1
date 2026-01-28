/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class FaHzCom : GComponent
    {
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z19g";

        public static FaHzCom CreateInstance()
        {
            return (FaHzCom)UIPackage.CreateObject("UIRes", "FaHzCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            EditText = (GTextField)GetChild("EditText");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2ESimpleButton7 : GButton
    {
        public Controller button;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zxw";

        public static DA2ESimpleButton7 CreateInstance()
        {
            return (DA2ESimpleButton7)UIPackage.CreateObject("UIRes", "DA2ESimpleButton7");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
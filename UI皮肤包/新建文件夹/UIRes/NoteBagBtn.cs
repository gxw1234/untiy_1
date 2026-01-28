/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class NoteBagBtn : GButton
    {
        public Controller button;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jk02tn1uu";

        public static NoteBagBtn CreateInstance()
        {
            return (NoteBagBtn)UIPackage.CreateObject("UIRes", "NoteBagBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
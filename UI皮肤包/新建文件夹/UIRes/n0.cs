/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class n0 : GButton
    {
        public Controller button;
        public const string URL = "ui://jk0io98jiioeh";

        public static n0 CreateInstance()
        {
            return (n0)UIPackage.CreateObject("UIRes", "n0");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
        }
    }
}
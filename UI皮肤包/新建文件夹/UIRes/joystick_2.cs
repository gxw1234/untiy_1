/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class joystick_2 : GButton
    {
        public GImage thumb2;
        public const string URL = "ui://jk0io98jgcp1n1ph";

        public static joystick_2 CreateInstance()
        {
            return (joystick_2)UIPackage.CreateObject("UIRes", "joystick_2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            thumb2 = (GImage)GetChild("thumb2");
        }
    }
}
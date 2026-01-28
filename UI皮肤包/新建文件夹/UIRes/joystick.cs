/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class joystick : GButton
    {
        public Controller c1;
        public GImage thumb1;
        public GImage thumb2;
        public const string URL = "ui://jk0io98jv9b1fl";

        public static joystick CreateInstance()
        {
            return (joystick)UIPackage.CreateObject("UIRes", "joystick");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            c1 = GetController("c1");
            thumb1 = (GImage)GetChild("thumb1");
            thumb2 = (GImage)GetChild("thumb2");
        }
    }
}
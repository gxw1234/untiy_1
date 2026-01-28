/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DoubleDJoystick : GComponent
    {
        public GImage joystick_center_2;
        public GImage direct_2;
        public joystick_2 joystick_2;
        public GGraph joystick_touch_2;
        public GImage joystick_center_1;
        public GImage direct_1;
        public joystick_1 joystick_1;
        public GGraph joystick_touch_1;
        public const string URL = "ui://jk0io98jgcp1n1pi";

        public static DoubleDJoystick CreateInstance()
        {
            return (DoubleDJoystick)UIPackage.CreateObject("UIRes", "DoubleDJoystick");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            joystick_center_2 = (GImage)GetChild("joystick_center_2");
            direct_2 = (GImage)GetChild("direct_2");
            joystick_2 = (joystick_2)GetChild("joystick_2");
            joystick_touch_2 = (GGraph)GetChild("joystick_touch_2");
            joystick_center_1 = (GImage)GetChild("joystick_center_1");
            direct_1 = (GImage)GetChild("direct_1");
            joystick_1 = (joystick_1)GetChild("joystick_1");
            joystick_touch_1 = (GGraph)GetChild("joystick_touch_1");
        }
    }
}
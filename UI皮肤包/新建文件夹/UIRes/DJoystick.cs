/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DJoystick : GComponent
    {
        public GImage joystick_center_1;
        public GImage direct_1;
        public joystick joystick_1;
        public GGraph joystick_touch_1;
        public const string URL = "ui://jk0io98jv9b1g3";

        public static DJoystick CreateInstance()
        {
            return (DJoystick)UIPackage.CreateObject("UIRes", "DJoystick");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            joystick_center_1 = (GImage)GetChild("joystick_center_1");
            direct_1 = (GImage)GetChild("direct_1");
            joystick_1 = (joystick)GetChild("joystick_1");
            joystick_touch_1 = (GGraph)GetChild("joystick_touch_1");
        }
    }
}
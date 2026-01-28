/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Page4 : GComponent
    {
        public GImage bg;
        public GTextInput Input;
        public const string URL = "ui://jk0io98jm9og1p";

        public static Page4 CreateInstance()
        {
            return (Page4)UIPackage.CreateObject("UIRes", "Page4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
            Input = (GTextInput)GetChild("Input");
        }
    }
}
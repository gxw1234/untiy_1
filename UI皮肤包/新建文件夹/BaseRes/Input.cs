/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class Input : GComponent
    {
        public GGraph bg;
        public GTextInput InputItem;
        public GGraph Stroke;
        public const string URL = "ui://use7blkkqgn28v";

        public static Input CreateInstance()
        {
            return (Input)UIPackage.CreateObject("BaseRes", "Input");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            InputItem = (GTextInput)GetChild("InputItem");
            Stroke = (GGraph)GetChild("Stroke");
        }
    }
}
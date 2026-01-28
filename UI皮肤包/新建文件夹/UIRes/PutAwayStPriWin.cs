/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayStPriWin : GComponent
    {
        public GImage PutAwayStPriWin;
        public GTextInput PutAwayStartVclEdits;
        public GLoader DA2ELoader65;
        public const string URL = "ui://jk0io98jkn5z12c";

        public static PutAwayStPriWin CreateInstance()
        {
            return (PutAwayStPriWin)UIPackage.CreateObject("UIRes", "PutAwayStPriWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PutAwayStPriWin = (GImage)GetChild("PutAwayStPriWin");
            PutAwayStartVclEdits = (GTextInput)GetChild("PutAwayStartVclEdits");
            DA2ELoader65 = (GLoader)GetChild("DA2ELoader65");
        }
    }
}
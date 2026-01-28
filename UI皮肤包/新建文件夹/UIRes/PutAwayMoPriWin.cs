/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class PutAwayMoPriWin : GComponent
    {
        public GImage PutAwayMoPriWin;
        public GTextInput PutAwayMPVclEdits;
        public GLoader DA2ELoader66;
        public const string URL = "ui://jk0io98jkn5z12d";

        public static PutAwayMoPriWin CreateInstance()
        {
            return (PutAwayMoPriWin)UIPackage.CreateObject("UIRes", "PutAwayMoPriWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PutAwayMoPriWin = (GImage)GetChild("PutAwayMoPriWin");
            PutAwayMPVclEdits = (GTextInput)GetChild("PutAwayMPVclEdits");
            DA2ELoader66 = (GLoader)GetChild("DA2ELoader66");
        }
    }
}
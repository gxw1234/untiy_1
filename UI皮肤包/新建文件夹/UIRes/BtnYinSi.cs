/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnYinSi : GButton
    {
        public Controller button;
        public GImage Img4086ce;
        public GImage Img409m0u;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jsm7ec";

        public static BtnYinSi CreateInstance()
        {
            return (BtnYinSi)UIPackage.CreateObject("UIRes", "BtnYinSi");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img4086ce = (GImage)GetChild("Img4086ce");
            Img409m0u = (GImage)GetChild("Img409m0u");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
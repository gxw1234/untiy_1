/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class TextEditor : GComponent
    {
        public Detail Detail;
        public ConfirmBtn ConfirmBtn;
        public CancelBtn CancelBtn;
        public const string URL = "ui://use7blkkqgn299";

        public static TextEditor CreateInstance()
        {
            return (TextEditor)UIPackage.CreateObject("BaseRes", "TextEditor");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Detail = (Detail)GetChild("Detail");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
        }
    }
}
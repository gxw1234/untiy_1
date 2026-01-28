/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MailDeleteBtn : GButton
    {
        public Controller button;
        public GImage Img837xen;
        public GImage Img838nj0;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5zyo";

        public static MailDeleteBtn CreateInstance()
        {
            return (MailDeleteBtn)UIPackage.CreateObject("UIRes", "MailDeleteBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img837xen = (GImage)GetChild("Img837xen");
            Img838nj0 = (GImage)GetChild("Img838nj0");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
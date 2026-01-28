/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class MailWinStay2 : GComponent
    {
        public GImage MailWinStay2;
        public const string URL = "ui://jk0io98jkn5zy2";

        public static MailWinStay2 CreateInstance()
        {
            return (MailWinStay2)UIPackage.CreateObject("UIRes", "MailWinStay2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            MailWinStay2 = (GImage)GetChild("MailWinStay2");
        }
    }
}
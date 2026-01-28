/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnDisGuild : GButton
    {
        public Controller button;
        public GImage Img1914qs;
        public GImage Img192f27;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17j";

        public static BtnDisGuild CreateInstance()
        {
            return (BtnDisGuild)UIPackage.CreateObject("UIRes", "BtnDisGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1914qs = (GImage)GetChild("Img1914qs");
            Img192f27 = (GImage)GetChild("Img192f27");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
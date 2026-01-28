/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BtnCompileGuild : GButton
    {
        public Controller button;
        public GImage Img19176p;
        public GImage Img192feg;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jkn5z17k";

        public static BtnCompileGuild CreateInstance()
        {
            return (BtnCompileGuild)UIPackage.CreateObject("UIRes", "BtnCompileGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img19176p = (GImage)GetChild("Img19176p");
            Img192feg = (GImage)GetChild("Img192feg");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
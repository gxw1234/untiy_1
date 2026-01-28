/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnChat : GButton
    {
        public Controller button;
        public GImage Img265256;
        public GImage Img266y5g;
        public GTextField ChatEdit40;
        public const string URL = "ui://jk0io98jkn5z158";

        public static DBtnChat CreateInstance()
        {
            return (DBtnChat)UIPackage.CreateObject("UIRes", "DBtnChat");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265256 = (GImage)GetChild("Img265256");
            Img266y5g = (GImage)GetChild("Img266y5g");
            ChatEdit40 = (GTextField)GetChild("ChatEdit40");
        }
    }
}
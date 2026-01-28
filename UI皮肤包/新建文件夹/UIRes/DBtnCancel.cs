/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnCancel : GButton
    {
        public Controller button;
        public GImage Img1976ja;
        public GImage Img198n50;
        public const string URL = "ui://jk0io98jj3e21l5";

        public static DBtnCancel CreateInstance()
        {
            return (DBtnCancel)UIPackage.CreateObject("UIRes", "DBtnCancel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img1976ja = (GImage)GetChild("Img1976ja");
            Img198n50 = (GImage)GetChild("Img198n50");
        }
    }
}
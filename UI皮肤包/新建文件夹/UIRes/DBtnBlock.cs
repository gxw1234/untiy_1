/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnBlock : GButton
    {
        public Controller button;
        public GImage Img2652d1;
        public GImage Img266n08;
        public GTextField ChatEdit44;
        public const string URL = "ui://jk0io98jkn5z15c";

        public static DBtnBlock CreateInstance()
        {
            return (DBtnBlock)UIPackage.CreateObject("UIRes", "DBtnBlock");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2652d1 = (GImage)GetChild("Img2652d1");
            Img266n08 = (GImage)GetChild("Img266n08");
            ChatEdit44 = (GTextField)GetChild("ChatEdit44");
        }
    }
}
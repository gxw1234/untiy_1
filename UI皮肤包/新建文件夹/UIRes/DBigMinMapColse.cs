/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBigMinMapColse : GButton
    {
        public Controller button;
        public GImage Img07wm;
        public GImage Img1cg5;
        public const string URL = "ui://jk0io98jruoyn2qz";

        public static DBigMinMapColse CreateInstance()
        {
            return (DBigMinMapColse)UIPackage.CreateObject("UIRes", "DBigMinMapColse");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img07wm = (GImage)GetChild("Img07wm");
            Img1cg5 = (GImage)GetChild("Img1cg5");
        }
    }
}
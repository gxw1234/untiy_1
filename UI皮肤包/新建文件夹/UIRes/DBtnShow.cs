/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnShow : GButton
    {
        public Controller button;
        public GImage Img8900n;
        public GImage Img90eyc;
        public GImage DBtnShowRHot;
        public const string URL = "ui://jk0io98jk02tn1ut";

        public static DBtnShow CreateInstance()
        {
            return (DBtnShow)UIPackage.CreateObject("UIRes", "DBtnShow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img8900n = (GImage)GetChild("Img8900n");
            Img90eyc = (GImage)GetChild("Img90eyc");
            DBtnShowRHot = (GImage)GetChild("DBtnShowRHot");
        }
    }
}
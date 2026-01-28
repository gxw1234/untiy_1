/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnMinMap : GButton
    {
        public Controller button;
        public GImage Img5707q0;
        public GImage Img572dtc;
        public GImage DBtnMinMapRHot;
        public const string URL = "ui://jk0io98jruoyn2r1";

        public static DBtnMinMap CreateInstance()
        {
            return (DBtnMinMap)UIPackage.CreateObject("UIRes", "DBtnMinMap");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img5707q0 = (GImage)GetChild("Img5707q0");
            Img572dtc = (GImage)GetChild("Img572dtc");
            DBtnMinMapRHot = (GImage)GetChild("DBtnMinMapRHot");
        }
    }
}
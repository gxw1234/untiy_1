/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ChuShou_StallwindUI : GComponent
    {
        public GImage Stallwind;
        public GComponent frame;
        public GTextField EditItems;
        public GTextField EditName;
        public GTextField EditPrice;
        public GButton BtnStall;
        public GButton BtnStallCancle;
        public GList DBagGrid;
        public GButton BtnColose1;
        public const string URL = "ui://jyvofh5ej3e21gn";

        public static ChuShou_StallwindUI CreateInstance()
        {
            return (ChuShou_StallwindUI)UIPackage.CreateObject("UI", "出售_StallwindUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Stallwind = (GImage)GetChild("Stallwind");
            frame = (GComponent)GetChild("frame");
            EditItems = (GTextField)GetChild("EditItems");
            EditName = (GTextField)GetChild("EditName");
            EditPrice = (GTextField)GetChild("EditPrice");
            BtnStall = (GButton)GetChild("BtnStall");
            BtnStallCancle = (GButton)GetChild("BtnStallCancle");
            DBagGrid = (GList)GetChild("DBagGrid");
            BtnColose1 = (GButton)GetChild("BtnColose1");
        }
    }
}
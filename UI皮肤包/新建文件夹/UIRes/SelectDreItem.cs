/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class SelectDreItem : GButton
    {
        public Controller button;
        public GImage Img604082;
        public GImage Img63942c;
        public FaHzCom FaHzCom;
        public GImage SelectLoader;
        public GLoader icon;
        public GImage SelectImg2;
        public const string URL = "ui://jk0io98jkn5z19j";

        public static SelectDreItem CreateInstance()
        {
            return (SelectDreItem)UIPackage.CreateObject("UIRes", "SelectDreItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img604082 = (GImage)GetChild("Img604082");
            Img63942c = (GImage)GetChild("Img63942c");
            FaHzCom = (FaHzCom)GetChild("FaHzCom");
            SelectLoader = (GImage)GetChild("SelectLoader");
            icon = (GLoader)GetChild("icon");
            SelectImg2 = (GImage)GetChild("SelectImg2");
        }
    }
}
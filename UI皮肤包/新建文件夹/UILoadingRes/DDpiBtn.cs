/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class DDpiBtn : GButton
    {
        public Controller button;
        public GImage Img265nnw;
        public GImage Img266547;
        public GTextField title;
        public const string URL = "ui://us2ut3jfr7r826";

        public static DDpiBtn CreateInstance()
        {
            return (DDpiBtn)UIPackage.CreateObject("UILoadingRes", "DDpiBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img265nnw = (GImage)GetChild("Img265nnw");
            Img266547 = (GImage)GetChild("Img266547");
            title = (GTextField)GetChild("title");
        }
    }
}
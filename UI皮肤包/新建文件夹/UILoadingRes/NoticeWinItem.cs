/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class NoticeWinItem : GComponent
    {
        public GRichTextField ItemShowInfo;
        public const string URL = "ui://us2ut3jfvmwk5w";

        public static NoticeWinItem CreateInstance()
        {
            return (NoticeWinItem)UIPackage.CreateObject("UILoadingRes", "NoticeWinItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ItemShowInfo = (GRichTextField)GetChild("ItemShowInfo");
        }
    }
}
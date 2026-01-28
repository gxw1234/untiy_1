/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BigBlood : GComponent
    {
        public GLoader bgLoader;
        public GLoader iconLoader;
        public GRichTextField levelText;
        public GRichTextField nameText;
        public GRichTextField belongText;
        public GRichTextField bloodText;
        public GList dropItem;
        public const string URL = "ui://jk0io98jp27sgvn2wz";

        public static BigBlood CreateInstance()
        {
            return (BigBlood)UIPackage.CreateObject("UIRes", "BigBlood");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bgLoader = (GLoader)GetChild("bgLoader");
            iconLoader = (GLoader)GetChild("iconLoader");
            levelText = (GRichTextField)GetChild("levelText");
            nameText = (GRichTextField)GetChild("nameText");
            belongText = (GRichTextField)GetChild("belongText");
            bloodText = (GRichTextField)GetChild("bloodText");
            dropItem = (GList)GetChild("dropItem");
        }
    }
}
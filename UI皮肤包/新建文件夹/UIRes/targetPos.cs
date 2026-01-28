/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class targetPos : GComponent
    {
        public GImage n0;
        public GRichTextField text;
        public ComInfo ComInfo;
        public const string URL = "ui://jk0io98js336gvn2w6";

        public static targetPos CreateInstance()
        {
            return (targetPos)UIPackage.CreateObject("UIRes", "targetPos");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            text = (GRichTextField)GetChild("text");
            ComInfo = (ComInfo)GetChild("ComInfo");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CommentLine : GProgressBar
    {
        public GImage n0;
        public GImage bar;
        public const string URL = "ui://jk0io98jj3e21pd";

        public static CommentLine CreateInstance()
        {
            return (CommentLine)UIPackage.CreateObject("UIRes", "CommentLine");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            bar = (GImage)GetChild("bar");
        }
    }
}
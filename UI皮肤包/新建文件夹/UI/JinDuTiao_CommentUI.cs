/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JinDuTiao_CommentUI : GComponent
    {
        public GProgressBar CommentLine;
        public GTextField LineText;
        public const string URL = "ui://jyvofh5ej3e21pe";

        public static JinDuTiao_CommentUI CreateInstance()
        {
            return (JinDuTiao_CommentUI)UIPackage.CreateObject("UI", "进度条_CommentUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CommentLine = (GProgressBar)GetChild("CommentLine");
            LineText = (GTextField)GetChild("LineText");
        }
    }
}
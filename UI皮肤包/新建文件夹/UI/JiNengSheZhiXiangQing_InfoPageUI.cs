/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class JiNengSheZhiXiangQing_InfoPageUI : GComponent
    {
        public GImage InfoPage;
        public GComponent frame;
        public GList DA2EGrid1;
        public GButton DA2ESimpleButton8;
        public GTextField EditText;
        public GTextField EditText2;
        public const string URL = "ui://jyvofh5emh4svn2sn";

        public static JiNengSheZhiXiangQing_InfoPageUI CreateInstance()
        {
            return (JiNengSheZhiXiangQing_InfoPageUI)UIPackage.CreateObject("UI", "技能设置详情_InfoPageUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            InfoPage = (GImage)GetChild("InfoPage");
            frame = (GComponent)GetChild("frame");
            DA2EGrid1 = (GList)GetChild("DA2EGrid1");
            DA2ESimpleButton8 = (GButton)GetChild("DA2ESimpleButton8");
            EditText = (GTextField)GetChild("EditText");
            EditText2 = (GTextField)GetChild("EditText2");
        }
    }
}
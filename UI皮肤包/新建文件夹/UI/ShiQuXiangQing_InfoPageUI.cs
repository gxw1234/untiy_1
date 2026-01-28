/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShiQuXiangQing_InfoPageUI : GComponent
    {
        public GImage InfoPage;
        public GComponent frame;
        public GList DA2EGrid1;
        public GButton DA2ESimpleButton8;
        public GTextField EditText;
        public GTextField EditText_2;
        public GTextField EditText_3;
        public GGraph searchBG;
        public GTextInput searchText;
        public const string URL = "ui://jyvofh5ekn5zyw";

        public static ShiQuXiangQing_InfoPageUI CreateInstance()
        {
            return (ShiQuXiangQing_InfoPageUI)UIPackage.CreateObject("UI", "拾取详情_InfoPageUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            InfoPage = (GImage)GetChild("InfoPage");
            frame = (GComponent)GetChild("frame");
            DA2EGrid1 = (GList)GetChild("DA2EGrid1");
            DA2ESimpleButton8 = (GButton)GetChild("DA2ESimpleButton8");
            EditText = (GTextField)GetChild("EditText");
            EditText_2 = (GTextField)GetChild("EditText");
            EditText_3 = (GTextField)GetChild("EditText");
            searchBG = (GGraph)GetChild("searchBG");
            searchText = (GTextInput)GetChild("searchText");
        }
    }
}
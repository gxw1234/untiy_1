/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShenQingTiaoJian_DA2EWindow3UI : GComponent
    {
        public GImage DA2EWindow3;
        public GTextField ChatEdit15;
        public GButton BtnConCancle;
        public GTextField EditText;
        public GImage DA2EIMAGE4;
        public GButton BtnSave;
        public GTextField EditText_2;
        public GTextInput EditLevels;
        public GTextField ChatEdit57;
        public GTextField ChatEdit58;
        public GTextField ChatEdit59;
        public GButton ChBoxJob1;
        public GButton ChBoxJob2;
        public GButton ChBoxJob3;
        public const string URL = "ui://jyvofh5ekn5z18a";

        public static ShenQingTiaoJian_DA2EWindow3UI CreateInstance()
        {
            return (ShenQingTiaoJian_DA2EWindow3UI)UIPackage.CreateObject("UI", "申请条件_DA2EWindow3UI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2EWindow3 = (GImage)GetChild("DA2EWindow3");
            ChatEdit15 = (GTextField)GetChild("ChatEdit15");
            BtnConCancle = (GButton)GetChild("BtnConCancle");
            EditText = (GTextField)GetChild("EditText");
            DA2EIMAGE4 = (GImage)GetChild("DA2EIMAGE4");
            BtnSave = (GButton)GetChild("BtnSave");
            EditText_2 = (GTextField)GetChild("EditText");
            EditLevels = (GTextInput)GetChild("EditLevels");
            ChatEdit57 = (GTextField)GetChild("ChatEdit57");
            ChatEdit58 = (GTextField)GetChild("ChatEdit58");
            ChatEdit59 = (GTextField)GetChild("ChatEdit59");
            ChBoxJob1 = (GButton)GetChild("ChBoxJob1");
            ChBoxJob2 = (GButton)GetChild("ChBoxJob2");
            ChBoxJob3 = (GButton)GetChild("ChBoxJob3");
        }
    }
}
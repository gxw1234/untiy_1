/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class ShenFenYanZheng_CheckCodewinUI : GComponent
    {
        public GImage n0;
        public GImage n1;
        public GImage n5;
        public GButton CodeCloseBtn;
        public GTextField n2;
        public GTextField n3;
        public GTextField n4;
        public GButton GetCodeBtn;
        public GButton CodeSureBtn;
        public GTextInput PhoneNumber;
        public GTextInput CodeNumber;
        public const string URL = "ui://jyvofh5e11icn1pf";

        public static ShenFenYanZheng_CheckCodewinUI CreateInstance()
        {
            return (ShenFenYanZheng_CheckCodewinUI)UIPackage.CreateObject("UI", "身份验证_CheckCodewinUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
            n5 = (GImage)GetChild("n5");
            CodeCloseBtn = (GButton)GetChild("CodeCloseBtn");
            n2 = (GTextField)GetChild("n2");
            n3 = (GTextField)GetChild("n3");
            n4 = (GTextField)GetChild("n4");
            GetCodeBtn = (GButton)GetChild("GetCodeBtn");
            CodeSureBtn = (GButton)GetChild("CodeSureBtn");
            PhoneNumber = (GTextInput)GetChild("PhoneNumber");
            CodeNumber = (GTextInput)GetChild("CodeNumber");
        }
    }
}
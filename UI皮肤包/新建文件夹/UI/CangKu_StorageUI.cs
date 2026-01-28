/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class CangKu_StorageUI : GComponent
    {
        public GImage StorageUI;
        public GComponent frame;
        public GComponent DA2EWindow1;
        public GButton BtnStorageUIClose;
        public GList StorageGrid;
        public GButton BtnPageUp;
        public GButton BtnPageDown;
        public GTextField DText3;
        public GTextField DText;
        public GTextField DText2;
        public const string URL = "ui://jyvofh5ekn5z148";

        public static CangKu_StorageUI CreateInstance()
        {
            return (CangKu_StorageUI)UIPackage.CreateObject("UI", "仓库_StorageUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            StorageUI = (GImage)GetChild("StorageUI");
            frame = (GComponent)GetChild("frame");
            DA2EWindow1 = (GComponent)GetChild("DA2EWindow1");
            BtnStorageUIClose = (GButton)GetChild("BtnStorageUIClose");
            StorageGrid = (GList)GetChild("StorageGrid");
            BtnPageUp = (GButton)GetChild("BtnPageUp");
            BtnPageDown = (GButton)GetChild("BtnPageDown");
            DText3 = (GTextField)GetChild("DText3");
            DText = (GTextField)GetChild("DText");
            DText2 = (GTextField)GetChild("DText2");
        }
    }
}
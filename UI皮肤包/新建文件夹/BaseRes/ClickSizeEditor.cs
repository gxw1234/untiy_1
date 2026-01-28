/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ClickSizeEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput Input3;
        public GGraph ImgBg;
        public GTextField ImgTxt;
        public GTextInput Input4;
        public GGraph ImgBg5;
        public GTextField ImgTxt5;
        public GTextInput Input5;
        public GGraph ImgBg6;
        public GTextField ImgTxt6;
        public GTextInput Input6;
        public GGraph ImgBg7;
        public GTextField ImgTxt7;
        public GTextInput Input7;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput Input8;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput FLinkInput;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public const string URL = "ui://use7blkkqgn28g";

        public static ClickSizeEditor CreateInstance()
        {
            return (ClickSizeEditor)UIPackage.CreateObject("BaseRes", "ClickSizeEditor");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            Title = (GTextField)GetChild("Title");
            WilBg = (GGraph)GetChild("WilBg");
            WilTxt = (GTextField)GetChild("WilTxt");
            Input3 = (GTextInput)GetChild("Input3");
            ImgBg = (GGraph)GetChild("ImgBg");
            ImgTxt = (GTextField)GetChild("ImgTxt");
            Input4 = (GTextInput)GetChild("Input4");
            ImgBg5 = (GGraph)GetChild("ImgBg5");
            ImgTxt5 = (GTextField)GetChild("ImgTxt5");
            Input5 = (GTextInput)GetChild("Input5");
            ImgBg6 = (GGraph)GetChild("ImgBg6");
            ImgTxt6 = (GTextField)GetChild("ImgTxt6");
            Input6 = (GTextInput)GetChild("Input6");
            ImgBg7 = (GGraph)GetChild("ImgBg7");
            ImgTxt7 = (GTextField)GetChild("ImgTxt7");
            Input7 = (GTextInput)GetChild("Input7");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            Input8 = (GTextInput)GetChild("Input8");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            FLinkInput = (GTextInput)GetChild("FLinkInput");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
        }
    }
}
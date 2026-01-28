/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ItemBoxEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput Input1;
        public GGraph ImgBg;
        public GTextField ImgTxt;
        public GTextInput Input2;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput Input8;
        public GGraph FLinkBg9;
        public GTextField FLinkTxt9;
        public GTextInput Input9;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public GGraph ImgBg5;
        public GTextField ImgTxt5;
        public GTextInput Input3;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput Input6;
        public GTextField HintTxt7;
        public GTextInput Input7;
        public GGraph ScaleBg;
        public GTextInput FScaleY;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextField ScaleYTxt;
        public GTextField ScaleTxt;
        public GTextField FormIDTxt;
        public const string URL = "ui://use7blkkqgn28y";

        public static ItemBoxEditor CreateInstance()
        {
            return (ItemBoxEditor)UIPackage.CreateObject("BaseRes", "ItemBoxEditor");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            Title = (GTextField)GetChild("Title");
            WilBg = (GGraph)GetChild("WilBg");
            WilTxt = (GTextField)GetChild("WilTxt");
            Input1 = (GTextInput)GetChild("Input1");
            ImgBg = (GGraph)GetChild("ImgBg");
            ImgTxt = (GTextField)GetChild("ImgTxt");
            Input2 = (GTextInput)GetChild("Input2");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            Input8 = (GTextInput)GetChild("Input8");
            FLinkBg9 = (GGraph)GetChild("FLinkBg9");
            FLinkTxt9 = (GTextField)GetChild("FLinkTxt9");
            Input9 = (GTextInput)GetChild("Input9");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            ImgBg5 = (GGraph)GetChild("ImgBg5");
            ImgTxt5 = (GTextField)GetChild("ImgTxt5");
            Input3 = (GTextInput)GetChild("Input3");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            Input6 = (GTextInput)GetChild("Input6");
            HintTxt7 = (GTextField)GetChild("HintTxt7");
            Input7 = (GTextInput)GetChild("Input7");
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FScaleY = (GTextInput)GetChild("FScaleY");
            FormID = (GTextInput)GetChild("FormID");
            FScaleX = (GTextInput)GetChild("FScaleX");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
        }
    }
}
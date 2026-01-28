/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class InputEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput Input1;
        public GGraph ImgBg;
        public GTextField ImgTxt;
        public GTextInput Input4;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput Input11;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput Input12;
        public GGraph FLinkBg13;
        public GTextField FLinkTxt13;
        public GTextInput Input13;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public GGraph FLinkBg16;
        public GTextField FLinkTxt16;
        public GTextInput Input16;
        public GGraph SortBg;
        public GTextField SortTxt;
        public GTextInput Input6;
        public GGraph TitleBg;
        public GTextField TitleTxt;
        public GTextInput Input7;
        public GTextField ImgTxt5;
        public GTextInput Input5;
        public GTextField TitleTxt8;
        public GTextInput Input8;
        public GTextInput Input9;
        public GTextField TitleTxt9;
        public GTextInput Input10;
        public GTextField TitleTxt10;
        public GTextField FLinkTxt14;
        public GTextInput Input14;
        public GTextInput Input15;
        public GTextField FLinkTxt15;
        public GGraph ScaleBg;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextInput FScaleY;
        public GTextField ScaleYTxt;
        public GTextField ScaleTxt;
        public GTextField FormIDTxt;
        public const string URL = "ui://use7blkkqgn28w";

        public static InputEditor CreateInstance()
        {
            return (InputEditor)UIPackage.CreateObject("BaseRes", "InputEditor");
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
            Input4 = (GTextInput)GetChild("Input4");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            Input11 = (GTextInput)GetChild("Input11");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            Input12 = (GTextInput)GetChild("Input12");
            FLinkBg13 = (GGraph)GetChild("FLinkBg13");
            FLinkTxt13 = (GTextField)GetChild("FLinkTxt13");
            Input13 = (GTextInput)GetChild("Input13");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            FLinkBg16 = (GGraph)GetChild("FLinkBg16");
            FLinkTxt16 = (GTextField)GetChild("FLinkTxt16");
            Input16 = (GTextInput)GetChild("Input16");
            SortBg = (GGraph)GetChild("SortBg");
            SortTxt = (GTextField)GetChild("SortTxt");
            Input6 = (GTextInput)GetChild("Input6");
            TitleBg = (GGraph)GetChild("TitleBg");
            TitleTxt = (GTextField)GetChild("TitleTxt");
            Input7 = (GTextInput)GetChild("Input7");
            ImgTxt5 = (GTextField)GetChild("ImgTxt5");
            Input5 = (GTextInput)GetChild("Input5");
            TitleTxt8 = (GTextField)GetChild("TitleTxt8");
            Input8 = (GTextInput)GetChild("Input8");
            Input9 = (GTextInput)GetChild("Input9");
            TitleTxt9 = (GTextField)GetChild("TitleTxt9");
            Input10 = (GTextInput)GetChild("Input10");
            TitleTxt10 = (GTextField)GetChild("TitleTxt10");
            FLinkTxt14 = (GTextField)GetChild("FLinkTxt14");
            Input14 = (GTextInput)GetChild("Input14");
            Input15 = (GTextInput)GetChild("Input15");
            FLinkTxt15 = (GTextField)GetChild("FLinkTxt15");
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FormID = (GTextInput)GetChild("FormID");
            FScaleX = (GTextInput)GetChild("FScaleX");
            FScaleY = (GTextInput)GetChild("FScaleY");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
        }
    }
}
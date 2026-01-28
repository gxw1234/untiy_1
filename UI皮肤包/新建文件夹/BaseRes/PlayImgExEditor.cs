/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class PlayImgExEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput WilInput;
        public GGraph Img0Bg;
        public GTextField Img0Txt;
        public GTextInput Input3;
        public GGraph PlayBg1;
        public GTextField PlayTxt1;
        public GTextInput Input11;
        public GGraph SortBg;
        public GTextField SortTxt;
        public GTextInput SortInput;
        public GGraph Img1Bg;
        public GTextField Img1Txt;
        public GTextInput Input5;
        public GGraph Img2Bg;
        public GTextField Img2Txt;
        public GTextInput Input6;
        public GTextField Img22Txt;
        public GTextInput Input7;
        public GGraph offsetBg;
        public GTextField offsetTxt;
        public GTextInput Input13;
        public GGraph TitleBg;
        public GTextField TitleTxt;
        public GTextInput TitleInput;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput HintInput;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput FLinkInput;
        public GTextField WilTxt2;
        public GTextInput Input2;
        public GTextField Img0Txt1;
        public GTextInput Input4;
        public GGraph PlayBg;
        public GTextField PlayTxt;
        public GTextInput Input10;
        public GGraph ScaleBg;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextInput FScaleY;
        public GTextField ScaleYTxt;
        public GTextField ScaleTxt;
        public GTextField FormIDTxt;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public const string URL = "ui://use7blkkqgn297";

        public static PlayImgExEditor CreateInstance()
        {
            return (PlayImgExEditor)UIPackage.CreateObject("BaseRes", "PlayImgExEditor");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            Title = (GTextField)GetChild("Title");
            WilBg = (GGraph)GetChild("WilBg");
            WilTxt = (GTextField)GetChild("WilTxt");
            WilInput = (GTextInput)GetChild("WilInput");
            Img0Bg = (GGraph)GetChild("Img0Bg");
            Img0Txt = (GTextField)GetChild("Img0Txt");
            Input3 = (GTextInput)GetChild("Input3");
            PlayBg1 = (GGraph)GetChild("PlayBg1");
            PlayTxt1 = (GTextField)GetChild("PlayTxt1");
            Input11 = (GTextInput)GetChild("Input11");
            SortBg = (GGraph)GetChild("SortBg");
            SortTxt = (GTextField)GetChild("SortTxt");
            SortInput = (GTextInput)GetChild("SortInput");
            Img1Bg = (GGraph)GetChild("Img1Bg");
            Img1Txt = (GTextField)GetChild("Img1Txt");
            Input5 = (GTextInput)GetChild("Input5");
            Img2Bg = (GGraph)GetChild("Img2Bg");
            Img2Txt = (GTextField)GetChild("Img2Txt");
            Input6 = (GTextInput)GetChild("Input6");
            Img22Txt = (GTextField)GetChild("Img22Txt");
            Input7 = (GTextInput)GetChild("Input7");
            offsetBg = (GGraph)GetChild("offsetBg");
            offsetTxt = (GTextField)GetChild("offsetTxt");
            Input13 = (GTextInput)GetChild("Input13");
            TitleBg = (GGraph)GetChild("TitleBg");
            TitleTxt = (GTextField)GetChild("TitleTxt");
            TitleInput = (GTextInput)GetChild("TitleInput");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            HintInput = (GTextInput)GetChild("HintInput");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            FLinkInput = (GTextInput)GetChild("FLinkInput");
            WilTxt2 = (GTextField)GetChild("WilTxt2");
            Input2 = (GTextInput)GetChild("Input2");
            Img0Txt1 = (GTextField)GetChild("Img0Txt1");
            Input4 = (GTextInput)GetChild("Input4");
            PlayBg = (GGraph)GetChild("PlayBg");
            PlayTxt = (GTextField)GetChild("PlayTxt");
            Input10 = (GTextInput)GetChild("Input10");
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FormID = (GTextInput)GetChild("FormID");
            FScaleX = (GTextInput)GetChild("FScaleX");
            FScaleY = (GTextInput)GetChild("FScaleY");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
        }
    }
}
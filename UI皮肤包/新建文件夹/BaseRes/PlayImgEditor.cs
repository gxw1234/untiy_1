/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class PlayImgEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput WilInput;
        public GGraph Img0Bg;
        public GTextField Img0Txt;
        public GTextInput Input2;
        public GGraph PlayBg;
        public GTextField PlayTxt;
        public GTextInput Input8;
        public GGraph SortBg;
        public GTextField SortTxt;
        public GTextInput SortInput;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public GGraph Img1Bg;
        public GTextField Img1Txt;
        public GTextInput Input3;
        public GGraph Img2Bg;
        public GTextField Img2Txt;
        public GTextInput Input4;
        public GTextField Img22Txt;
        public GTextInput Input7;
        public GGraph offsetBg;
        public GTextField offsetTxt;
        public GTextInput Input10;
        public GGraph TitleBg;
        public GTextField TitleTxt;
        public GTextInput TitleInput;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput HintInput;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput FLinkInput;
        public GGraph ScaleBg;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextInput FScaleY;
        public GTextField ScaleTxt;
        public GTextField ScaleYTxt;
        public GTextField FormIDTxt;
        public const string URL = "ui://use7blkkqgn295";

        public static PlayImgEditor CreateInstance()
        {
            return (PlayImgEditor)UIPackage.CreateObject("BaseRes", "PlayImgEditor");
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
            Input2 = (GTextInput)GetChild("Input2");
            PlayBg = (GGraph)GetChild("PlayBg");
            PlayTxt = (GTextField)GetChild("PlayTxt");
            Input8 = (GTextInput)GetChild("Input8");
            SortBg = (GGraph)GetChild("SortBg");
            SortTxt = (GTextField)GetChild("SortTxt");
            SortInput = (GTextInput)GetChild("SortInput");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            Img1Bg = (GGraph)GetChild("Img1Bg");
            Img1Txt = (GTextField)GetChild("Img1Txt");
            Input3 = (GTextInput)GetChild("Input3");
            Img2Bg = (GGraph)GetChild("Img2Bg");
            Img2Txt = (GTextField)GetChild("Img2Txt");
            Input4 = (GTextInput)GetChild("Input4");
            Img22Txt = (GTextField)GetChild("Img22Txt");
            Input7 = (GTextInput)GetChild("Input7");
            offsetBg = (GGraph)GetChild("offsetBg");
            offsetTxt = (GTextField)GetChild("offsetTxt");
            Input10 = (GTextInput)GetChild("Input10");
            TitleBg = (GGraph)GetChild("TitleBg");
            TitleTxt = (GTextField)GetChild("TitleTxt");
            TitleInput = (GTextInput)GetChild("TitleInput");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            HintInput = (GTextInput)GetChild("HintInput");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            FLinkInput = (GTextInput)GetChild("FLinkInput");
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FormID = (GTextInput)GetChild("FormID");
            FScaleX = (GTextInput)GetChild("FScaleX");
            FScaleY = (GTextInput)GetChild("FScaleY");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
        }
    }
}
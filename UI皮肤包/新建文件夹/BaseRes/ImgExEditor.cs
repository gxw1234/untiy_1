/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ImgExEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput WilInput;
        public GGraph Img0Bg;
        public GTextField Img0Txt;
        public GTextInput Img0Input;
        public GGraph SortBg;
        public GTextField SortTxt;
        public GTextInput SortInput;
        public GGraph TitleBg;
        public GTextField TitleTxt;
        public GTextInput TitleInput;
        public GGraph HintBg;
        public GTextField HintTxt;
        public GTextInput HintInput;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput FLinkInput;
        public GGraph Img1Bg;
        public GTextField Img1Txt;
        public GTextInput Img1Input;
        public GGraph Img2Bg;
        public GTextField Img2Txt;
        public GTextInput Img2Input;
        public GGraph ScaleBg;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextInput FScaleY;
        public GTextField ScaleYTxt;
        public GTextField ScaleTxt;
        public GTextField FormIDTxt;
        public const string URL = "ui://use7blkkqgn28t";

        public static ImgExEditor CreateInstance()
        {
            return (ImgExEditor)UIPackage.CreateObject("BaseRes", "ImgExEditor");
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
            Img0Input = (GTextInput)GetChild("Img0Input");
            SortBg = (GGraph)GetChild("SortBg");
            SortTxt = (GTextField)GetChild("SortTxt");
            SortInput = (GTextInput)GetChild("SortInput");
            TitleBg = (GGraph)GetChild("TitleBg");
            TitleTxt = (GTextField)GetChild("TitleTxt");
            TitleInput = (GTextInput)GetChild("TitleInput");
            HintBg = (GGraph)GetChild("HintBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            HintInput = (GTextInput)GetChild("HintInput");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            FLinkInput = (GTextInput)GetChild("FLinkInput");
            Img1Bg = (GGraph)GetChild("Img1Bg");
            Img1Txt = (GTextField)GetChild("Img1Txt");
            Img1Input = (GTextInput)GetChild("Img1Input");
            Img2Bg = (GGraph)GetChild("Img2Bg");
            Img2Txt = (GTextField)GetChild("Img2Txt");
            Img2Input = (GTextInput)GetChild("Img2Input");
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
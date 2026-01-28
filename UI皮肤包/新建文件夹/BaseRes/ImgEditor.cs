/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ImgEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput WilInput;
        public GGraph ImgBg;
        public GTextField ImgTxt;
        public GTextInput ImgInput;
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
        public GGraph ScaleBg;
        public GTextField FormIDTxt;
        public GTextInput FormID;
        public GTextField ScaleTxt;
        public GTextInput FScaleX;
        public GTextField ScaleYTxt;
        public GTextInput FScaleY;
        public const string URL = "ui://use7blkkqgn28r";

        public static ImgEditor CreateInstance()
        {
            return (ImgEditor)UIPackage.CreateObject("BaseRes", "ImgEditor");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            Title = (GTextField)GetChild("Title");
            WilBg = (GGraph)GetChild("WilBg");
            WilTxt = (GTextField)GetChild("WilTxt");
            WilInput = (GTextInput)GetChild("WilInput");
            ImgBg = (GGraph)GetChild("ImgBg");
            ImgTxt = (GTextField)GetChild("ImgTxt");
            ImgInput = (GTextInput)GetChild("ImgInput");
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
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
            FormID = (GTextInput)GetChild("FormID");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            FScaleX = (GTextInput)GetChild("FScaleX");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            FScaleY = (GTextInput)GetChild("FScaleY");
        }
    }
}
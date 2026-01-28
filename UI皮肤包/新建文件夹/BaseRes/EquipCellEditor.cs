/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class EquipCellEditor : GComponent
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
        public GGraph HintBg8;
        public GTextField HintTxt;
        public GTextInput Input8;
        public GGraph HintBg9;
        public GTextField HintTxt9;
        public GTextInput Input9;
        public GTextField HintTxt10;
        public GTextInput Input10;
        public GGraph HintBg11;
        public GTextField HintTxt11;
        public GTextInput Input11;
        public GTextField HintTxt12;
        public GTextInput Input12;
        public GGraph FLinkBg13;
        public GTextField FLinkTxt13;
        public GTextInput Input13;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput Input14;
        public GGraph ScaleBg;
        public GTextField FormIDTxt;
        public GTextInput FormID;
        public GTextField ScaleTxt;
        public GTextInput FScaleX;
        public GTextField ScaleYTxt;
        public GTextInput FScaleY;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public const string URL = "ui://use7blkklfwa9x";

        public static EquipCellEditor CreateInstance()
        {
            return (EquipCellEditor)UIPackage.CreateObject("BaseRes", "EquipCellEditor");
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
            HintBg8 = (GGraph)GetChild("HintBg8");
            HintTxt = (GTextField)GetChild("HintTxt");
            Input8 = (GTextInput)GetChild("Input8");
            HintBg9 = (GGraph)GetChild("HintBg9");
            HintTxt9 = (GTextField)GetChild("HintTxt9");
            Input9 = (GTextInput)GetChild("Input9");
            HintTxt10 = (GTextField)GetChild("HintTxt10");
            Input10 = (GTextInput)GetChild("Input10");
            HintBg11 = (GGraph)GetChild("HintBg11");
            HintTxt11 = (GTextField)GetChild("HintTxt11");
            Input11 = (GTextInput)GetChild("Input11");
            HintTxt12 = (GTextField)GetChild("HintTxt12");
            Input12 = (GTextInput)GetChild("Input12");
            FLinkBg13 = (GGraph)GetChild("FLinkBg13");
            FLinkTxt13 = (GTextField)GetChild("FLinkTxt13");
            Input13 = (GTextInput)GetChild("Input13");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            Input14 = (GTextInput)GetChild("Input14");
            ScaleBg = (GGraph)GetChild("ScaleBg");
            FormIDTxt = (GTextField)GetChild("FormIDTxt");
            FormID = (GTextInput)GetChild("FormID");
            ScaleTxt = (GTextField)GetChild("ScaleTxt");
            FScaleX = (GTextInput)GetChild("FScaleX");
            ScaleYTxt = (GTextField)GetChild("ScaleYTxt");
            FScaleY = (GTextInput)GetChild("FScaleY");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
        }
    }
}
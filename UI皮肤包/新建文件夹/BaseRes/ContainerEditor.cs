/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ContainerEditor : GComponent
    {
        public GGraph bg;
        public GTextField Title;
        public GGraph WilBg;
        public GTextField WilTxt;
        public GTextInput Input1;
        public GGraph ImgBg;
        public GTextField ImgTxt;
        public GTextInput Input2;
        public GGraph HintBg;
        public CancelBtn CancelBtn;
        public ConfirmBtn ConfirmBtn;
        public GGraph SortBg;
        public GTextField ImgTxt4;
        public GTextInput Input4;
        public GGraph TitleBg;
        public GTextField HintTxt;
        public GTextInput Input6;
        public GTextField ImgTxt2;
        public GTextInput Input3;
        public GTextField FLinkTxt;
        public GTextInput Input7;
        public GGraph FLinkBg8;
        public GTextInput Input8;
        public GTextField FLinkTxt8;
        public GTextField ImgTxt5;
        public GTextInput Input5;
        public const string URL = "ui://use7blkkqgn28i";

        public static ContainerEditor CreateInstance()
        {
            return (ContainerEditor)UIPackage.CreateObject("BaseRes", "ContainerEditor");
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
            HintBg = (GGraph)GetChild("HintBg");
            CancelBtn = (CancelBtn)GetChild("CancelBtn");
            ConfirmBtn = (ConfirmBtn)GetChild("ConfirmBtn");
            SortBg = (GGraph)GetChild("SortBg");
            ImgTxt4 = (GTextField)GetChild("ImgTxt4");
            Input4 = (GTextInput)GetChild("Input4");
            TitleBg = (GGraph)GetChild("TitleBg");
            HintTxt = (GTextField)GetChild("HintTxt");
            Input6 = (GTextInput)GetChild("Input6");
            ImgTxt2 = (GTextField)GetChild("ImgTxt2");
            Input3 = (GTextInput)GetChild("Input3");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            Input7 = (GTextInput)GetChild("Input7");
            FLinkBg8 = (GGraph)GetChild("FLinkBg8");
            Input8 = (GTextInput)GetChild("Input8");
            FLinkTxt8 = (GTextField)GetChild("FLinkTxt8");
            ImgTxt5 = (GTextField)GetChild("ImgTxt5");
            Input5 = (GTextInput)GetChild("Input5");
        }
    }
}
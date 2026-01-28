/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class Detail : GComponent
    {
        public GGraph bg;
        public GGraph InputBg;
        public GTextInput ContentInput;
        public GTextField Title;
        public GGraph FontBg;
        public GTextField fontsize;
        public GTextInput FontSizeInput;
        public GGraph ColorBg;
        public GTextField colorTxt;
        public GTextInput ColorInput;
        public GGraph TipsBg;
        public GTextField TipsTxt;
        public GTextInput TipsInput;
        public GGraph FLinkBg;
        public GTextField FLinkTxt;
        public GTextInput FLinlInput;
        public GGraph ScaleBg;
        public GTextInput FormID;
        public GTextInput FScaleX;
        public GTextInput FScaleY;
        public GTextField ScaleYTxt;
        public GTextField ScaleTxt;
        public GTextField FormIDTxt;
        public const string URL = "ui://use7blkkqgn289";

        public static Detail CreateInstance()
        {
            return (Detail)UIPackage.CreateObject("BaseRes", "Detail");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GGraph)GetChild("bg");
            InputBg = (GGraph)GetChild("InputBg");
            ContentInput = (GTextInput)GetChild("ContentInput");
            Title = (GTextField)GetChild("Title");
            FontBg = (GGraph)GetChild("FontBg");
            fontsize = (GTextField)GetChild("fontsize");
            FontSizeInput = (GTextInput)GetChild("FontSizeInput");
            ColorBg = (GGraph)GetChild("ColorBg");
            colorTxt = (GTextField)GetChild("colorTxt");
            ColorInput = (GTextInput)GetChild("ColorInput");
            TipsBg = (GGraph)GetChild("TipsBg");
            TipsTxt = (GTextField)GetChild("TipsTxt");
            TipsInput = (GTextInput)GetChild("TipsInput");
            FLinkBg = (GGraph)GetChild("FLinkBg");
            FLinkTxt = (GTextField)GetChild("FLinkTxt");
            FLinlInput = (GTextInput)GetChild("FLinlInput");
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
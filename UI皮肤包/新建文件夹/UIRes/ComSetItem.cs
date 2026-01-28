/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComSetItem : GComponent
    {
        public ComBtnChoice ComBtnChoice;
        public ComSlide ComSlide;
        public ComDownBox ComDownBox;
        public GTextField ChatEdit25;
        public GTextField ChatEdit26;
        public GTextField ChatEdit27;
        public GImage bg1;
        public GImage bg2;
        public GTextInput GameVclEdit1;
        public GTextInput GameVclEdit2;
        public const string URL = "ui://jk0io98jheq7gvn2va";

        public static ComSetItem CreateInstance()
        {
            return (ComSetItem)UIPackage.CreateObject("UIRes", "ComSetItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ComBtnChoice = (ComBtnChoice)GetChild("ComBtnChoice");
            ComSlide = (ComSlide)GetChild("ComSlide");
            ComDownBox = (ComDownBox)GetChild("ComDownBox");
            ChatEdit25 = (GTextField)GetChild("ChatEdit25");
            ChatEdit26 = (GTextField)GetChild("ChatEdit26");
            ChatEdit27 = (GTextField)GetChild("ChatEdit27");
            bg1 = (GImage)GetChild("bg1");
            bg2 = (GImage)GetChild("bg2");
            GameVclEdit1 = (GTextInput)GetChild("GameVclEdit1");
            GameVclEdit2 = (GTextInput)GetChild("GameVclEdit2");
        }
    }
}
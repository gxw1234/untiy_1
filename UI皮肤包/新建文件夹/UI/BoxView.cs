/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class BoxView : GComponent
    {
        public GImage box_bg;
        public GComponent frame;
        public GComponent ItemBox0;
        public GComponent ItemBox1;
        public GComponent ItemBox2;
        public GComponent ItemBox3;
        public GComponent ItemBox4;
        public GComponent ItemBox5;
        public GComponent ItemBox6;
        public GComponent ItemBox7;
        public GComponent ItemBox8;
        public GButton CloseButton;
        public GButton DGetBoxItemFlash;
        public GComponent DItemBox;
        public const string URL = "ui://jyvofh5ehdg7vn2sl";

        public static BoxView CreateInstance()
        {
            return (BoxView)UIPackage.CreateObject("UI", "BoxView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            box_bg = (GImage)GetChild("box_bg");
            frame = (GComponent)GetChild("frame");
            ItemBox0 = (GComponent)GetChild("ItemBox0");
            ItemBox1 = (GComponent)GetChild("ItemBox1");
            ItemBox2 = (GComponent)GetChild("ItemBox2");
            ItemBox3 = (GComponent)GetChild("ItemBox3");
            ItemBox4 = (GComponent)GetChild("ItemBox4");
            ItemBox5 = (GComponent)GetChild("ItemBox5");
            ItemBox6 = (GComponent)GetChild("ItemBox6");
            ItemBox7 = (GComponent)GetChild("ItemBox7");
            ItemBox8 = (GComponent)GetChild("ItemBox8");
            CloseButton = (GButton)GetChild("CloseButton");
            DGetBoxItemFlash = (GButton)GetChild("DGetBoxItemFlash");
            DItemBox = (GComponent)GetChild("DItemBox");
        }
    }
}
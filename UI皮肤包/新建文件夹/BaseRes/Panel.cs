/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class Panel : GComponent
    {
        public GGraph BG;
        public GTextInput InputContent;
        public GGraph bg2;
        public DelBtn DelBtn;
        public ExpBtn ExpBtn;
        public LoadBtn LoadBtn;
        public ClearBtn ClearBtn;
        public GGraph bg3;
        public DA2ESimpleButton1 DA2ESimpleButton1;
        public DA2ESimpleButton2 DA2ESimpleButton2;
        public DA2ESimpleButton3 DA2ESimpleButton3;
        public GGraph bg4;
        public BigNPC BigNPC;
        public GTextField ChatEdit17;
        public DA2ESimpleButton4 DA2ESimpleButton4;
        public DA2ESimpleButton5 DA2ESimpleButton5;
        public DA2ESimpleButton6 DA2ESimpleButton6;
        public DA2ESimpleButton7 DA2ESimpleButton7;
        public DA2ESimpleButton8 DA2ESimpleButton8;
        public DA2ESimpleButton9 DA2ESimpleButton9;
        public DA2ESimpleButton10 DA2ESimpleButton10;
        public DA2ESimpleButton11 DA2ESimpleButton11;
        public FileID FileID;
        public ImgID ImgID;
        public CanMove CanMove;
        public ShowPos ShowPos;
        public MX MX;
        public MY MY;
        public ShowCloseButton ShowCloseButton;
        public CloseX CloseX;
        public CloseY CloseY;
        public CurMerchant CurMerchant;
        public Stretch Stretch;
        public CloseScale CloseScale;
        public GTextField ChatEdit18;
        public IsContainer IsContainer;
        public GGraph ContainerBg;
        public GTextInput ContainerInput;
        public const string URL = "ui://use7blkkqgn27r";

        public static Panel CreateInstance()
        {
            return (Panel)UIPackage.CreateObject("BaseRes", "Panel");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BG = (GGraph)GetChild("BG");
            InputContent = (GTextInput)GetChild("InputContent");
            bg2 = (GGraph)GetChild("bg2");
            DelBtn = (DelBtn)GetChild("DelBtn");
            ExpBtn = (ExpBtn)GetChild("ExpBtn");
            LoadBtn = (LoadBtn)GetChild("LoadBtn");
            ClearBtn = (ClearBtn)GetChild("ClearBtn");
            bg3 = (GGraph)GetChild("bg3");
            DA2ESimpleButton1 = (DA2ESimpleButton1)GetChild("DA2ESimpleButton1");
            DA2ESimpleButton2 = (DA2ESimpleButton2)GetChild("DA2ESimpleButton2");
            DA2ESimpleButton3 = (DA2ESimpleButton3)GetChild("DA2ESimpleButton3");
            bg4 = (GGraph)GetChild("bg4");
            BigNPC = (BigNPC)GetChild("BigNPC");
            ChatEdit17 = (GTextField)GetChild("ChatEdit17");
            DA2ESimpleButton4 = (DA2ESimpleButton4)GetChild("DA2ESimpleButton4");
            DA2ESimpleButton5 = (DA2ESimpleButton5)GetChild("DA2ESimpleButton5");
            DA2ESimpleButton6 = (DA2ESimpleButton6)GetChild("DA2ESimpleButton6");
            DA2ESimpleButton7 = (DA2ESimpleButton7)GetChild("DA2ESimpleButton7");
            DA2ESimpleButton8 = (DA2ESimpleButton8)GetChild("DA2ESimpleButton8");
            DA2ESimpleButton9 = (DA2ESimpleButton9)GetChild("DA2ESimpleButton9");
            DA2ESimpleButton10 = (DA2ESimpleButton10)GetChild("DA2ESimpleButton10");
            DA2ESimpleButton11 = (DA2ESimpleButton11)GetChild("DA2ESimpleButton11");
            FileID = (FileID)GetChild("FileID");
            ImgID = (ImgID)GetChild("ImgID");
            CanMove = (CanMove)GetChild("CanMove");
            ShowPos = (ShowPos)GetChild("ShowPos");
            MX = (MX)GetChild("MX");
            MY = (MY)GetChild("MY");
            ShowCloseButton = (ShowCloseButton)GetChild("ShowCloseButton");
            CloseX = (CloseX)GetChild("CloseX");
            CloseY = (CloseY)GetChild("CloseY");
            CurMerchant = (CurMerchant)GetChild("CurMerchant");
            Stretch = (Stretch)GetChild("Stretch");
            CloseScale = (CloseScale)GetChild("CloseScale");
            ChatEdit18 = (GTextField)GetChild("ChatEdit18");
            IsContainer = (IsContainer)GetChild("IsContainer");
            ContainerBg = (GGraph)GetChild("ContainerBg");
            ContainerInput = (GTextInput)GetChild("ContainerInput");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class EMailStyBtn : GButton
    {
        public Controller button;
        public GImage Img836jl3;
        public GImage Img835a33;
        public GTextField SysEdit1;
        public GTextField ReadEdit2;
        public GTextField WhereEdit1;
        public GLoader LoaderRSty1;
        public GLoader LoaderRSty2;
        public const string URL = "ui://jk0io98jkn5zyv";

        public static EMailStyBtn CreateInstance()
        {
            return (EMailStyBtn)UIPackage.CreateObject("UIRes", "EMailStyBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img836jl3 = (GImage)GetChild("Img836jl3");
            Img835a33 = (GImage)GetChild("Img835a33");
            SysEdit1 = (GTextField)GetChild("SysEdit1");
            ReadEdit2 = (GTextField)GetChild("ReadEdit2");
            WhereEdit1 = (GTextField)GetChild("WhereEdit1");
            LoaderRSty1 = (GLoader)GetChild("LoaderRSty1");
            LoaderRSty2 = (GLoader)GetChild("LoaderRSty2");
        }
    }
}
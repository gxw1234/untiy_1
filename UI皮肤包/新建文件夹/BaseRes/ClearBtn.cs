/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class ClearBtn : GButton
    {
        public Controller button;
        public GImage Img10oq1;
        public GImage Img118jl;
        public GTextField ChatEdit12;
        public const string URL = "ui://use7blkkqgn272";

        public static ClearBtn CreateInstance()
        {
            return (ClearBtn)UIPackage.CreateObject("BaseRes", "ClearBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img10oq1 = (GImage)GetChild("Img10oq1");
            Img118jl = (GImage)GetChild("Img118jl");
            ChatEdit12 = (GTextField)GetChild("ChatEdit12");
        }
    }
}
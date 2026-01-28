/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class GoodShelfItems : GComponent
    {
        public GTextField GStext1;
        public GTextField GStext2;
        public GTextField GStext3;
        public GTextField GStext4;
        public TakeJYBBtn TakeJYBBtn;
        public OutOfGBtn OutOfGBtn;
        public const string URL = "ui://jk0io98jj3e21cf";

        public static GoodShelfItems CreateInstance()
        {
            return (GoodShelfItems)UIPackage.CreateObject("UIRes", "GoodShelfItems");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            GStext1 = (GTextField)GetChild("GStext1");
            GStext2 = (GTextField)GetChild("GStext2");
            GStext3 = (GTextField)GetChild("GStext3");
            GStext4 = (GTextField)GetChild("GStext4");
            TakeJYBBtn = (TakeJYBBtn)GetChild("TakeJYBBtn");
            OutOfGBtn = (OutOfGBtn)GetChild("OutOfGBtn");
        }
    }
}
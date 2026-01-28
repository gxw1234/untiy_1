/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class NewNpcDlg : GComponent
    {
        public GImage NewNpcDlg;
        public GTextField NewNpcDlgt1;
        public GTextField NewNpcDlgt2;
        public GGraph NewNpcDlgGr;
        public NewNpcDCloseBtn NewNpcDCloseBtn;
        public GRichTextField NewNpcDlgt3;
        public const string URL = "ui://use7blkkqgn293";

        public static NewNpcDlg CreateInstance()
        {
            return (NewNpcDlg)UIPackage.CreateObject("BaseRes", "NewNpcDlg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            NewNpcDlg = (GImage)GetChild("NewNpcDlg");
            NewNpcDlgt1 = (GTextField)GetChild("NewNpcDlgt1");
            NewNpcDlgt2 = (GTextField)GetChild("NewNpcDlgt2");
            NewNpcDlgGr = (GGraph)GetChild("NewNpcDlgGr");
            NewNpcDCloseBtn = (NewNpcDCloseBtn)GetChild("NewNpcDCloseBtn");
            NewNpcDlgt3 = (GRichTextField)GetChild("NewNpcDlgt3");
        }
    }
}
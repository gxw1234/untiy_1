/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BottLeftTaskItem2 : GButton
    {
        public Controller button;
        public GImage Img843b5x;
        public GImage Img844420;
        public GLoader BottLTaskLoAn;
        public GRichTextField ChatEdit2;
        public GRichTextField ChatEdit4;
        public GRichTextField ChatEdit6;
        public GList taskName;
        public GList taskValue;
        public GList taskValue2;
        public Transition select;
        public const string URL = "ui://jk0io98js336gvn2w4";

        public static BottLeftTaskItem2 CreateInstance()
        {
            return (BottLeftTaskItem2)UIPackage.CreateObject("UIRes", "BottLeftTaskItem2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img843b5x = (GImage)GetChild("Img843b5x");
            Img844420 = (GImage)GetChild("Img844420");
            BottLTaskLoAn = (GLoader)GetChild("BottLTaskLoAn");
            ChatEdit2 = (GRichTextField)GetChild("ChatEdit2");
            ChatEdit4 = (GRichTextField)GetChild("ChatEdit4");
            ChatEdit6 = (GRichTextField)GetChild("ChatEdit6");
            taskName = (GList)GetChild("taskName");
            taskValue = (GList)GetChild("taskValue");
            taskValue2 = (GList)GetChild("taskValue2");
            select = GetTransition("select");
        }
    }
}
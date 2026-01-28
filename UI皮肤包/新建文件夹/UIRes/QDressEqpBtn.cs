/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class QDressEqpBtn : GButton
    {
        public Controller button;
        public GImage Img5740n7;
        public GImage Img5750vq;
        public GTextField EditBtn;
        public const string URL = "ui://jk0io98jv9b1fx";

        public static QDressEqpBtn CreateInstance()
        {
            return (QDressEqpBtn)UIPackage.CreateObject("UIRes", "QDressEqpBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img5740n7 = (GImage)GetChild("Img5740n7");
            Img5750vq = (GImage)GetChild("Img5750vq");
            EditBtn = (GTextField)GetChild("EditBtn");
        }
    }
}
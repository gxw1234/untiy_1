/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RigPetItemBtn1 : GButton
    {
        public Controller button;
        public GImage Img497216;
        public GImage Img49840s;
        public GTextField title;
        public const string URL = "ui://jk0io98jih0mn1v9";

        public static RigPetItemBtn1 CreateInstance()
        {
            return (RigPetItemBtn1)UIPackage.CreateObject("UIRes", "RigPetItemBtn1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img497216 = (GImage)GetChild("Img497216");
            Img49840s = (GImage)GetChild("Img49840s");
            title = (GTextField)GetChild("title");
        }
    }
}
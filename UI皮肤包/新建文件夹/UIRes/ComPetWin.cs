/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComPetWin : GComponent
    {
        public GLoader PetLoadImg;
        public GLoader diyEff0;
        public GLoader diyEff1;
        public GLoader diyEff2;
        public GLoader diyEff3;
        public const string URL = "ui://jk0io98jih0mn1ve";

        public static ComPetWin CreateInstance()
        {
            return (ComPetWin)UIPackage.CreateObject("UIRes", "ComPetWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            PetLoadImg = (GLoader)GetChild("PetLoadImg");
            diyEff0 = (GLoader)GetChild("diyEff0");
            diyEff1 = (GLoader)GetChild("diyEff1");
            diyEff2 = (GLoader)GetChild("diyEff2");
            diyEff3 = (GLoader)GetChild("diyEff3");
        }
    }
}
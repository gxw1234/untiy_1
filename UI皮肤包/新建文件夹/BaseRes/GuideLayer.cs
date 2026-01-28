/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class GuideLayer : GComponent
    {
        public GGraph n0;
        public GGraph window;
        public txtComLeft txtComLeft;
        public txtComRight txtComRight;
        public c0 c0;
        public c1 c1;
        public c2 c2;
        public c3 c3;
        public c4 c4;
        public c5 c5;
        public c6 c6;
        public c7 c7;
        public c8 c8;
        public txtComHides txtComHides;
        public const string URL = "ui://use7blkkr7r84b";

        public static GuideLayer CreateInstance()
        {
            return (GuideLayer)UIPackage.CreateObject("BaseRes", "GuideLayer");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GGraph)GetChild("n0");
            window = (GGraph)GetChild("window");
            txtComLeft = (txtComLeft)GetChild("txtComLeft");
            txtComRight = (txtComRight)GetChild("txtComRight");
            c0 = (c0)GetChild("c0");
            c1 = (c1)GetChild("c1");
            c2 = (c2)GetChild("c2");
            c3 = (c3)GetChild("c3");
            c4 = (c4)GetChild("c4");
            c5 = (c5)GetChild("c5");
            c6 = (c6)GetChild("c6");
            c7 = (c7)GetChild("c7");
            c8 = (c8)GetChild("c8");
            txtComHides = (txtComHides)GetChild("txtComHides");
        }
    }
}
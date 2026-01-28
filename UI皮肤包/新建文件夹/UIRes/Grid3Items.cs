/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Grid3Items : GComponent
    {
        public GTextField n0;
        public GTextField n1;
        public GTextField n2;
        public GTextField n3;
        public caozuo1 n4;
        public const string URL = "ui://jk0io98jj3e21ck";

        public static Grid3Items CreateInstance()
        {
            return (Grid3Items)UIPackage.CreateObject("UIRes", "Grid3Items");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GTextField)GetChild("n0");
            n1 = (GTextField)GetChild("n1");
            n2 = (GTextField)GetChild("n2");
            n3 = (GTextField)GetChild("n3");
            n4 = (caozuo1)GetChild("n4");
        }
    }
}
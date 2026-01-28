/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class CusBtn : GComponent
    {
        public GLoader bgLoad;
        public GTextField name;
        public const string URL = "ui://use7blkkr7r80";

        public static CusBtn CreateInstance()
        {
            return (CusBtn)UIPackage.CreateObject("BaseRes", "CusBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bgLoad = (GLoader)GetChild("bgLoad");
            name = (GTextField)GetChild("name");
        }
    }
}
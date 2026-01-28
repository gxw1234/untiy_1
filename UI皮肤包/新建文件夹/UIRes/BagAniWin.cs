/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class BagAniWin : GComponent
    {
        public GLoader BagAniLoad;
        public Transition select;
        public const string URL = "ui://jk0io98jv9b15k";

        public static BagAniWin CreateInstance()
        {
            return (BagAniWin)UIPackage.CreateObject("UIRes", "BagAniWin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            BagAniLoad = (GLoader)GetChild("BagAniLoad");
            select = GetTransition("select");
        }
    }
}
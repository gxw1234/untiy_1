/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class GameItemCell1 : GComponent
    {
        public GLoader load;
        public const string URL = "ui://use7blkkqgn26t";

        public static GameItemCell1 CreateInstance()
        {
            return (GameItemCell1)UIPackage.CreateObject("BaseRes", "GameItemCell1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            load = (GLoader)GetChild("load");
        }
    }
}
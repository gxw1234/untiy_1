/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class GameItemGrid : GComponent
    {
        public GList NpcitemGrids;
        public const string URL = "ui://use7blkkqgn28o";

        public static GameItemGrid CreateInstance()
        {
            return (GameItemGrid)UIPackage.CreateObject("BaseRes", "GameItemGrid");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            NpcitemGrids = (GList)GetChild("NpcitemGrids");
        }
    }
}
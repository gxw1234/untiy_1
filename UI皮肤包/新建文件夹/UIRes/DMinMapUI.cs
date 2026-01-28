/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMinMapUI : GComponent
    {
        public SmallExet n2;
        public Exit n1;
        public GImage DMinMapBG;
        public GGraph MiniMapGraph1;
        public GLoader MinisMapBg;
        public DMap DMap;
        public DBtnMinMap DBtnMinMap;
        public GTextField DMinMapName;
        public GTextField DMinMapInfo;
        public GTextField PosX;
        public GTextField PosY;
        public const string URL = "ui://jk0io98jruoyn2r3";

        public static DMinMapUI CreateInstance()
        {
            return (DMinMapUI)UIPackage.CreateObject("UIRes", "DMinMapUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n2 = (SmallExet)GetChild("n2");
            n1 = (Exit)GetChild("n1");
            DMinMapBG = (GImage)GetChild("DMinMapBG");
            MiniMapGraph1 = (GGraph)GetChild("MiniMapGraph1");
            MinisMapBg = (GLoader)GetChild("MinisMapBg");
            DMap = (DMap)GetChild("DMap");
            DBtnMinMap = (DBtnMinMap)GetChild("DBtnMinMap");
            DMinMapName = (GTextField)GetChild("DMinMapName");
            DMinMapInfo = (GTextField)GetChild("DMinMapInfo");
            PosX = (GTextField)GetChild("PosX");
            PosY = (GTextField)GetChild("PosY");
        }
    }
}
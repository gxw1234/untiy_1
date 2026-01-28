/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UI
{
    public partial class DiTu_DBigMapWindowUI : GComponent
    {
        public GImage DBigMapWindowUI;
        public GComponent frame;
        public GComponent DBigMinMapCom;
        public GImage DA2EIMAGE3;
        public GImage DMinMapBG2;
        public GImage DMinMapBG1;
        public GTextField DMapName;
        public GButton DA2ESimpleButton2;
        public GButton DA2ESimpleButton1;
        public GLoader DItemLoader1;
        public GLoader DItemLoader2;
        public GButton DBigMinMapColse;
        public GImage MapFontImg;
        public const string URL = "ui://jyvofh5ekn5zn4";

        public static DiTu_DBigMapWindowUI CreateInstance()
        {
            return (DiTu_DBigMapWindowUI)UIPackage.CreateObject("UI", "地图_DBigMapWindowUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBigMapWindowUI = (GImage)GetChild("DBigMapWindowUI");
            frame = (GComponent)GetChild("frame");
            DBigMinMapCom = (GComponent)GetChild("DBigMinMapCom");
            DA2EIMAGE3 = (GImage)GetChild("DA2EIMAGE3");
            DMinMapBG2 = (GImage)GetChild("DMinMapBG2");
            DMinMapBG1 = (GImage)GetChild("DMinMapBG1");
            DMapName = (GTextField)GetChild("DMapName");
            DA2ESimpleButton2 = (GButton)GetChild("DA2ESimpleButton2");
            DA2ESimpleButton1 = (GButton)GetChild("DA2ESimpleButton1");
            DItemLoader1 = (GLoader)GetChild("DItemLoader1");
            DItemLoader2 = (GLoader)GetChild("DItemLoader2");
            DBigMinMapColse = (GButton)GetChild("DBigMinMapColse");
            MapFontImg = (GImage)GetChild("MapFontImg");
        }
    }
}
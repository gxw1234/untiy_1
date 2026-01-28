/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnRankList : GButton
    {
        public Controller button;
        public GImage Img46011o;
        public GImage Img4613gk;
        public const string URL = "ui://jk0io98jj3e21o3";

        public static DBtnRankList CreateInstance()
        {
            return (DBtnRankList)UIPackage.CreateObject("UIRes", "DBtnRankList");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img46011o = (GImage)GetChild("Img46011o");
            Img4613gk = (GImage)GetChild("Img4613gk");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RankLookRoleBtn : GButton
    {
        public Controller button;
        public GImage Img864apm;
        public GImage Img865257;
        public const string URL = "ui://jk0io98jkn5zzr";

        public static RankLookRoleBtn CreateInstance()
        {
            return (RankLookRoleBtn)UIPackage.CreateObject("UIRes", "RankLookRoleBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img864apm = (GImage)GetChild("Img864apm");
            Img865257 = (GImage)GetChild("Img865257");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMonsterBlood : GComponent
    {
        public GImage DMonsterBlood;
        public GLoader DMonsterHeadIcon;
        public DMonBlood DMonBlood;
        public DMonName DMonName;
        public Button6 DDeselectBtn;
        public const string URL = "ui://jk0io98jv9b16s";

        public static DMonsterBlood CreateInstance()
        {
            return (DMonsterBlood)UIPackage.CreateObject("UIRes", "DMonsterBlood");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DMonsterBlood = (GImage)GetChild("DMonsterBlood");
            DMonsterHeadIcon = (GLoader)GetChild("DMonsterHeadIcon");
            DMonBlood = (DMonBlood)GetChild("DMonBlood");
            DMonName = (DMonName)GetChild("DMonName");
            DDeselectBtn = (Button6)GetChild("DDeselectBtn");
        }
    }
}
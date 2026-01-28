/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnEmoticon : GButton
    {
        public Controller button;
        public GImage Img310cim;
        public GImage Img311631;
        public const string URL = "ui://jk0io98jj3e21kn";

        public static DBtnEmoticon CreateInstance()
        {
            return (DBtnEmoticon)UIPackage.CreateObject("UIRes", "DBtnEmoticon");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img310cim = (GImage)GetChild("Img310cim");
            Img311631 = (GImage)GetChild("Img311631");
        }
    }
}
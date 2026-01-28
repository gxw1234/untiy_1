/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DEmoticon : GComponent
    {
        public GImage DEmoticon;
        public GList DEmoticonGrid;
        public const string URL = "ui://jk0io98jj3e21kx";

        public static DEmoticon CreateInstance()
        {
            return (DEmoticon)UIPackage.CreateObject("UIRes", "DEmoticon");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DEmoticon = (GImage)GetChild("DEmoticon");
            DEmoticonGrid = (GList)GetChild("DEmoticonGrid");
        }
    }
}
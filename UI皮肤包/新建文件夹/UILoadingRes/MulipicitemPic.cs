/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class MulipicitemPic : GComponent
    {
        public GLoader img;
        public const string URL = "ui://us2ut3jfs5ye61";

        public static MulipicitemPic CreateInstance()
        {
            return (MulipicitemPic)UIPackage.CreateObject("UILoadingRes", "MulipicitemPic");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            img = (GLoader)GetChild("img");
        }
    }
}
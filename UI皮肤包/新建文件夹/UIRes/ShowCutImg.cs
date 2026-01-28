/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ShowCutImg : GComponent
    {
        public GLoader CutImgLoader;
        public const string URL = "ui://jk0io98jj3e21fx";

        public static ShowCutImg CreateInstance()
        {
            return (ShowCutImg)UIPackage.CreateObject("UIRes", "ShowCutImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CutImgLoader = (GLoader)GetChild("CutImgLoader");
        }
    }
}
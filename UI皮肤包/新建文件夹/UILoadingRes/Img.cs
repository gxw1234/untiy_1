/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UILoadingRes
{
    public partial class Img : GComponent
    {
        public GLoader ImgLoader;
        public const string URL = "ui://us2ut3jfr7r83e";

        public static Img CreateInstance()
        {
            return (Img)UIPackage.CreateObject("UILoadingRes", "Img");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            ImgLoader = (GLoader)GetChild("ImgLoader");
        }
    }
}
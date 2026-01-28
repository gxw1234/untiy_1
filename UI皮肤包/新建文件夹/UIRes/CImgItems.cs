/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class CImgItems : GComponent
    {
        public GLoader Placeholder;
        public const string URL = "ui://jk0io98jj3e21ca";

        public static CImgItems CreateInstance()
        {
            return (CImgItems)UIPackage.CreateObject("UIRes", "CImgItems");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            Placeholder = (GLoader)GetChild("Placeholder");
        }
    }
}
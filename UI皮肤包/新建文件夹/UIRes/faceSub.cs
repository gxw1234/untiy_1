/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class faceSub : GComponent
    {
        public GLoader icon;
        public const string URL = "ui://jk0io98jj3e21ky";

        public static faceSub CreateInstance()
        {
            return (faceSub)UIPackage.CreateObject("UIRes", "faceSub");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            icon = (GLoader)GetChild("icon");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DMissionImg : GComponent
    {
        public GLoader img;
        public const string URL = "ui://jk0io98jo7m0d";

        public static DMissionImg CreateInstance()
        {
            return (DMissionImg)UIPackage.CreateObject("UIRes", "DMissionImg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            img = (GLoader)GetChild("img");
        }
    }
}
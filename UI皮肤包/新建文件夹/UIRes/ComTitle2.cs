/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class ComTitle2 : GComponent
    {
        public GImage n0;
        public GImage n1;
        public const string URL = "ui://jk0io98jheq7gvn2v8";

        public static ComTitle2 CreateInstance()
        {
            return (ComTitle2)UIPackage.CreateObject("UIRes", "ComTitle2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            n0 = (GImage)GetChild("n0");
            n1 = (GImage)GetChild("n1");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DNearbyPeople : GButton
    {
        public Controller button;
        public GImage Img291ca2;
        public GImage Img290st0;
        public const string URL = "ui://jk0io98jkn5ztt";

        public static DNearbyPeople CreateInstance()
        {
            return (DNearbyPeople)UIPackage.CreateObject("UIRes", "DNearbyPeople");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img291ca2 = (GImage)GetChild("Img291ca2");
            Img290st0 = (GImage)GetChild("Img290st0");
        }
    }
}
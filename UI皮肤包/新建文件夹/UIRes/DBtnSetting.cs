/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnSetting : GButton
    {
        public Controller button;
        public GImage Img867eg;
        public GImage Img8573g;
        public const string URL = "ui://jk0io98jk02tn1uf";

        public static DBtnSetting CreateInstance()
        {
            return (DBtnSetting)UIPackage.CreateObject("UIRes", "DBtnSetting");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img867eg = (GImage)GetChild("Img867eg");
            Img8573g = (GImage)GetChild("Img8573g");
        }
    }
}
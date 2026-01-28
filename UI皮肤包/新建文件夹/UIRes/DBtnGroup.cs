/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnGroup : GButton
    {
        public Controller button;
        public GImage Img936o3;
        public GImage Img94c7w;
        public const string URL = "ui://jk0io98jk02tn1uk";

        public static DBtnGroup CreateInstance()
        {
            return (DBtnGroup)UIPackage.CreateObject("UIRes", "DBtnGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img936o3 = (GImage)GetChild("Img936o3");
            Img94c7w = (GImage)GetChild("Img94c7w");
        }
    }
}
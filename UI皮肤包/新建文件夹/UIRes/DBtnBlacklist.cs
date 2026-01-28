/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnBlacklist : GButton
    {
        public Controller button;
        public GImage Img269545;
        public GImage Img2686ob;
        public const string URL = "ui://jk0io98jkn5z15h";

        public static DBtnBlacklist CreateInstance()
        {
            return (DBtnBlacklist)UIPackage.CreateObject("UIRes", "DBtnBlacklist");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img269545 = (GImage)GetChild("Img269545");
            Img2686ob = (GImage)GetChild("Img2686ob");
        }
    }
}
/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnGuild : GButton
    {
        public Controller button;
        public GImage Img755b7;
        public GImage Img76a53;
        public const string URL = "ui://jk0io98jk02tn1ui";

        public static DBtnGuild CreateInstance()
        {
            return (DBtnGuild)UIPackage.CreateObject("UIRes", "DBtnGuild");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img755b7 = (GImage)GetChild("Img755b7");
            Img76a53 = (GImage)GetChild("Img76a53");
        }
    }
}
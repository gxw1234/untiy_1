/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class NomalItem : GButton
    {
        public Controller button;
        public GImage Img2541g7;
        public GImage Img3010fl;
        public GTextField GuildName;
        public GTextField HomeName;
        public GTextField Player;
        public DA2ESimpleButton1 DA2ESimpleButton1;
        public DA2ESimpleButton2 DA2ESimpleButton2;
        public const string URL = "ui://jk0io98jkn5z18h";

        public static NomalItem CreateInstance()
        {
            return (NomalItem)UIPackage.CreateObject("UIRes", "NomalItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img2541g7 = (GImage)GetChild("Img2541g7");
            Img3010fl = (GImage)GetChild("Img3010fl");
            GuildName = (GTextField)GetChild("GuildName");
            HomeName = (GTextField)GetChild("HomeName");
            Player = (GTextField)GetChild("Player");
            DA2ESimpleButton1 = (DA2ESimpleButton1)GetChild("DA2ESimpleButton1");
            DA2ESimpleButton2 = (DA2ESimpleButton2)GetChild("DA2ESimpleButton2");
        }
    }
}
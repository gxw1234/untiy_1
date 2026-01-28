/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class grip4 : GButton
    {
        public Controller button;
        public GImage Img422v35;
        public GImage Img422635;
        public const string URL = "ui://jk0io98jkn5zxh";

        public static grip4 CreateInstance()
        {
            return (grip4)UIPackage.CreateObject("UIRes", "grip4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img422v35 = (GImage)GetChild("Img422v35");
            Img422635 = (GImage)GetChild("Img422635");
        }
    }
}
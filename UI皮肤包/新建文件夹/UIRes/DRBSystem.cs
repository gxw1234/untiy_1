/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DRBSystem : GButton
    {
        public Controller button;
        public GImage Img305j6k;
        public GImage Img3044jo;
        public GTextField EditText;
        public const string URL = "ui://jk0io98jj3e21kh";

        public static DRBSystem CreateInstance()
        {
            return (DRBSystem)UIPackage.CreateObject("UIRes", "DRBSystem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            button = GetController("button");
            Img305j6k = (GImage)GetChild("Img305j6k");
            Img3044jo = (GImage)GetChild("Img3044jo");
            EditText = (GTextField)GetChild("EditText");
        }
    }
}
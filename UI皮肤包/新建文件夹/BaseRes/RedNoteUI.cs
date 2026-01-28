/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace BaseRes
{
    public partial class RedNoteUI : GComponent
    {
        public GLoader RedLoader;
        public const string URL = "ui://use7blkkr7r84c";

        public static RedNoteUI CreateInstance()
        {
            return (RedNoteUI)UIPackage.CreateObject("BaseRes", "RedNoteUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            RedLoader = (GLoader)GetChild("RedLoader");
        }
    }
}
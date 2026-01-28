/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Role2 : GComponent
    {
        public GLoader role;
        public GLoader roleEffect;
        public GLoader effect;
        public const string URL = "ui://jk0io98jw6774";

        public static Role2 CreateInstance()
        {
            return (Role2)UIPackage.CreateObject("UIRes", "Role2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            role = (GLoader)GetChild("role");
            roleEffect = (GLoader)GetChild("roleEffect");
            effect = (GLoader)GetChild("effect");
        }
    }
}
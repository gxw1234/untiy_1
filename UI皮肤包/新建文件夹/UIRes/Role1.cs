/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class Role1 : GComponent
    {
        public GLoader role;
        public GLoader roleEffect;
        public GLoader effect;
        public const string URL = "ui://jk0io98j7w435";

        public static Role1 CreateInstance()
        {
            return (Role1)UIPackage.CreateObject("UIRes", "Role1");
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
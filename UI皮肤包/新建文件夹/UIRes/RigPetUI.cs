/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RigPetUI : GComponent
    {
        public GLoader DA2ELoader1;
        public GList RigPetList;
        public const string URL = "ui://jk0io98jih0mn1vd";

        public static RigPetUI CreateInstance()
        {
            return (RigPetUI)UIPackage.CreateObject("UIRes", "RigPetUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader1 = (GLoader)GetChild("DA2ELoader1");
            RigPetList = (GList)GetChild("RigPetList");
        }
    }
}
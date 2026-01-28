/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class RigPromoteUI : GComponent
    {
        public GLoader DA2ELoader1;
        public GList RigPromoteList;
        public const string URL = "ui://jk0io98jk02tn1uw";

        public static RigPromoteUI CreateInstance()
        {
            return (RigPromoteUI)UIPackage.CreateObject("UIRes", "RigPromoteUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DA2ELoader1 = (GLoader)GetChild("DA2ELoader1");
            RigPromoteList = (GList)GetChild("RigPromoteList");
        }
    }
}
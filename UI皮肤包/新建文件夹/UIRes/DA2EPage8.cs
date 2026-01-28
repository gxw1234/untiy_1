/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DA2EPage8 : GComponent
    {
        public GList DWHousetemList;
        public const string URL = "ui://jk0io98jj3e21f8";

        public static DA2EPage8 CreateInstance()
        {
            return (DA2EPage8)UIPackage.CreateObject("UIRes", "DA2EPage8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DWHousetemList = (GList)GetChild("DWHousetemList");
        }
    }
}
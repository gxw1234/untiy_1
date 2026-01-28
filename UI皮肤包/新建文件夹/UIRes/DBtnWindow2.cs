/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBtnWindow2 : GComponent
    {
        public DBtnSetting DBtnSetting;
        public const string URL = "ui://jk0io98jpqnp0";

        public static DBtnWindow2 CreateInstance()
        {
            return (DBtnWindow2)UIPackage.CreateObject("UIRes", "DBtnWindow2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBtnSetting = (DBtnSetting)GetChild("DBtnSetting");
        }
    }
}
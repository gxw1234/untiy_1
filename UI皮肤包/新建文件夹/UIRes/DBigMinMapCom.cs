/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBigMinMapCom : GComponent
    {
        public GLoader DBigMinMapLoader;
        public const string URL = "ui://jk0io98jruoyn2qw";

        public static DBigMinMapCom CreateInstance()
        {
            return (DBigMinMapCom)UIPackage.CreateObject("UIRes", "DBigMinMapCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBigMinMapLoader = (GLoader)GetChild("DBigMinMapLoader");
        }
    }
}
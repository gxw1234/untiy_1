/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBagUI : GComponent
    {
        public GImage DBagUI;
        public GList DBagGrid;
        public const string URL = "ui://jk0io98jj3e21kt";

        public static DBagUI CreateInstance()
        {
            return (DBagUI)UIPackage.CreateObject("UIRes", "DBagUI");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBagUI = (GImage)GetChild("DBagUI");
            DBagGrid = (GList)GetChild("DBagGrid");
        }
    }
}
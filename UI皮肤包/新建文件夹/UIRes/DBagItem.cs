/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DBagItem : GComponent
    {
        public GImage DBagItem;
        public GLoader DItemIconLoader;
        public GLoader DIconLoader;
        public const string URL = "ui://jk0io98jj3e21ks";

        public static DBagItem CreateInstance()
        {
            return (DBagItem)UIPackage.CreateObject("UIRes", "DBagItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DBagItem = (GImage)GetChild("DBagItem");
            DItemIconLoader = (GLoader)GetChild("DItemIconLoader");
            DIconLoader = (GLoader)GetChild("DIconLoader");
        }
    }
}
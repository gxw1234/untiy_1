/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DSexList : GComponent
    {
        public Controller CRadios;
        public DBtnSex0 DBtnSex0;
        public DBtnSex1 DBtnSex1;
        public const string URL = "ui://jk0io98jj43ts";

        public static DSexList CreateInstance()
        {
            return (DSexList)UIPackage.CreateObject("UIRes", "DSexList");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DBtnSex0 = (DBtnSex0)GetChild("DBtnSex0");
            DBtnSex1 = (DBtnSex1)GetChild("DBtnSex1");
        }
    }
}
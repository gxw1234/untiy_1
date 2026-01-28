/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DJobList : GComponent
    {
        public Controller CRadios;
        public DBtnJob0 DBtnJob0;
        public DBtnJob1 DBtnJob1;
        public DBtnJob2 DBtnJob2;
        public const string URL = "ui://jk0io98jwk1u1";

        public static DJobList CreateInstance()
        {
            return (DJobList)UIPackage.CreateObject("UIRes", "DJobList");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            CRadios = GetController("CRadios");
            DBtnJob0 = (DBtnJob0)GetChild("DBtnJob0");
            DBtnJob1 = (DBtnJob1)GetChild("DBtnJob1");
            DBtnJob2 = (DBtnJob2)GetChild("DBtnJob2");
        }
    }
}
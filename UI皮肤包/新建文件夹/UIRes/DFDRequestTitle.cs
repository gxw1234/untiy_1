/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class DFDRequestTitle : GComponent
    {
        public GImage DFDRequestTitle;
        public GTextField DFDRequestName;
        public GTextField DFDRequestGuild;
        public GTextField DFDRequestLevel;
        public GTextField DFDRequestState;
        public const string URL = "ui://jk0io98jkn5z14v";

        public static DFDRequestTitle CreateInstance()
        {
            return (DFDRequestTitle)UIPackage.CreateObject("UIRes", "DFDRequestTitle");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            DFDRequestTitle = (GImage)GetChild("DFDRequestTitle");
            DFDRequestName = (GTextField)GetChild("DFDRequestName");
            DFDRequestGuild = (GTextField)GetChild("DFDRequestGuild");
            DFDRequestLevel = (GTextField)GetChild("DFDRequestLevel");
            DFDRequestState = (GTextField)GetChild("DFDRequestState");
        }
    }
}
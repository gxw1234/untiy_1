/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace UIRes
{
    public partial class TargetCom : GComponent
    {
        public Controller c1;
        public GImage bg;
        public GTextField tips;
        public DActorBtn HumBtn;
        public DActorBtn MonBtn;
        public GList ActorList;
        public const string URL = "ui://jk0io98js336y";

        public static TargetCom CreateInstance()
        {
            return (TargetCom)UIPackage.CreateObject("UIRes", "TargetCom");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            c1 = GetController("c1");
            bg = (GImage)GetChild("bg");
            tips = (GTextField)GetChild("tips");
            HumBtn = (DActorBtn)GetChild("HumBtn");
            MonBtn = (DActorBtn)GetChild("MonBtn");
            ActorList = (GList)GetChild("ActorList");
        }
    }
}
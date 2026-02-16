using System;
using System.Collections.Generic;
using Client.MirControls;
using Client.MirNetwork;
using Client.MirSounds;
using C = ClientPackets;
using S = ServerPackets;

namespace Client.MirScenes
{
    public sealed class FguiBridgeScene : MirScene
    {
        public override void Process()
        {
        }

        public override void ProcessPacket(Packet p)
        {
            switch (p.Index)
            {
                case (short)ServerPacketIds.Connected:
                    Network.Connected = true;
                    SendVersion();
                    break;

                case (short)ServerPacketIds.ClientVersion:
                    ClientVersion((S.ClientVersion)p);
                    break;

                case (short)ServerPacketIds.Login:
                    Login((S.Login)p);
                    break;

                case (short)ServerPacketIds.LoginBanned:
                    LoginBanned((S.LoginBanned)p);
                    break;

                case (short)ServerPacketIds.LoginSuccess:
                    LoginSuccess((S.LoginSuccess)p);
                    break;

                case (short)ServerPacketIds.StartGame:
                    StartGame((S.StartGame)p);
                    break;

                case (short)ServerPacketIds.StartGameBanned:
                    StartGameBanned((S.StartGameBanned)p);
                    break;

                case (short)ServerPacketIds.StartGameDelay:
                    StartGameDelay((S.StartGameDelay)p);
                    break;

                default:
                    base.ProcessPacket(p);
                    break;
            }
        }

        private static void SendVersion()
        {
            try
            {
                var p = new C.ClientVersion { VersionHash = System.Text.Encoding.ASCII.GetBytes("测试") };
                Network.Enqueue(p);
            }
            catch
            {
            }
        }

        private static void ClientVersion(S.ClientVersion p)
        {
            if (p.Result == 0)
            {
                Network.Disconnect();
                return;
            }
        }

        private static void Login(S.Login p)
        {
            switch (p.Result)
            {
                case 0:
                    FguiBootstrap.ShowToast("登录暂时关闭");
                    break;
                case 1:
                    FguiBootstrap.ShowToast("账号不合法");
                    break;
                case 2:
                    FguiBootstrap.ShowToast("密码不合法");
                    break;
                case 3:
                    FguiBootstrap.ShowToast("请输入账号");
                    break;
                case 4:
                    FguiBootstrap.ShowToast("账号或密码错误");
                    break;
                case 5:
                    FguiBootstrap.ShowToast("需要先修改密码");
                    break;
            }
        }

        private static void LoginBanned(S.LoginBanned p)
        {
            FguiBootstrap.ShowToast("账号已封禁");
        }

        private static void LoginSuccess(S.LoginSuccess p)
        {
            UnityEngine.Debug.Log($"[FguiBridgeScene] LoginSuccess received, Characters count: {p.Characters?.Count ?? 0}");
            SoundManager.PlaySound(SoundList.LoginEffect);
            // 登录成功后直接显示选角界面（因为已经在登录前选择了服务器）
            FguiBootstrap.ShowCharacterSelect(p.Characters);
        }

        private static void StartGameDelay(S.StartGameDelay p)
        {
            FguiBootstrap.ShowToast("进入游戏冷却中");
        }

        private static void StartGameBanned(S.StartGameBanned p)
        {
            FguiBootstrap.ShowToast("账号已封禁");
        }

        private static void StartGame(S.StartGame p)
        {
            if (p.Result != 4)
            {
                FguiBootstrap.ShowToast("进入游戏失败");
                return;
            }

            if (p.Resolution < Settings.Resolution || Settings.Resolution == 0)
                Settings.Resolution = p.Resolution;

            switch (Settings.Resolution)
            {
                default:
                case 1024:
                    Settings.Resolution = 1024;
                    CMain.SetResolution(1024, 768);
                    break;
                case 1280:
                    CMain.SetResolution(1280, 800);
                    break;
                case 1366:
                    CMain.SetResolution(1366, 768);
                    break;
                case 1920:
                    CMain.SetResolution(1920, 1080);
                    break;
            }

            CMain.DisableLegacyMirSceneDraw = false;
            ActiveScene = new GameScene();
            FguiBootstrap.ClearAllUI();

            // 初始化 FairyGUI 游戏内 UI
            var fguiGameUI = UnityEngine.GameObject.Find("FguiGameUI");
            if (fguiGameUI == null)
            {
                fguiGameUI = new UnityEngine.GameObject("FguiGameUI");
                fguiGameUI.AddComponent<FguiGameUI>();
            }
            FguiGameUI.Instance?.Initialize();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Client
{
    /// <summary>
    /// 服务器状态
    /// </summary>
    public enum ServerStatus
    {
        Maintenance = 0,  // 维护中
        Smooth = 1,       // 流畅
        Busy = 2,         // 火爆
        Full = 3          // 爆满
    }

    /// <summary>
    /// 服务器信息（区服逻辑元数据，连接地址由 cfg.ini 控制）
    /// </summary>
    [Serializable]
    public class ServerInfo
    {
        public int ServerID;           // 服务器ID
        public string ServerName;      // 服务器名称
        public ServerStatus Status;    // 服务器状态
        public bool IsRecommend;       // 是否推荐
        public bool IsNew;             // 是否新服

        public ServerInfo() { }

        public ServerInfo(int id, string name, ServerStatus status = ServerStatus.Smooth, bool recommend = false, bool isNew = false)
        {
            ServerID = id;
            ServerName = name;
            Status = status;
            IsRecommend = recommend;
            IsNew = isNew;
        }

        /// <summary>
        /// 获取状态显示文本
        /// </summary>
        public string GetStatusText()
        {
            switch (Status)
            {
                case ServerStatus.Maintenance: return "维护中";
                case ServerStatus.Smooth: return "流畅";
                case ServerStatus.Busy: return "火爆";
                case ServerStatus.Full: return "爆满";
                default: return "未知";
            }
        }

        /// <summary>
        /// 获取显示名称（带标签）
        /// </summary>
        public string GetDisplayName()
        {
            string name = ServerName;
            if (IsNew) name = "[新服] " + name;
            if (IsRecommend) name = "[推荐] " + name;
            return name;
        }
    }

    /// <summary>
    /// 大区信息
    /// </summary>
    [Serializable]
    public class RegionInfo
    {
        public int RegionID;           // 大区ID
        public string RegionName;      // 大区名称
        public List<ServerInfo> Servers = new List<ServerInfo>();

        public RegionInfo() { }

        public RegionInfo(int id, string name)
        {
            RegionID = id;
            RegionName = name;
        }
    }

    /// <summary>
    /// 服务器配置
    /// </summary>
    [Serializable]
    public class ServerConfig
    {
        public List<RegionInfo> Regions = new List<RegionInfo>();

        /// <summary>
        /// 创建默认配置（内置 fallback，仅当网络拉取失败时使用）
        /// </summary>
        public static ServerConfig CreateDefault()
        {
            var config = new ServerConfig();

            var region1 = new RegionInfo(1, "测试区");
            region1.Servers.Add(new ServerInfo(101, "本地测试服", ServerStatus.Smooth, true, false));
            config.Regions.Add(region1);

            return config;
        }
    }
}

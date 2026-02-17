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
    /// 服务器信息
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
        /// 创建默认配置
        /// </summary>
        public static ServerConfig CreateDefault()
        {
            var config = new ServerConfig();

            // 华南区
            var region1 = new RegionInfo(1, "华南区");
            region1.Servers.Add(new ServerInfo(101, "电信一区", ServerStatus.Smooth, true, false));
            region1.Servers.Add(new ServerInfo(102, "电信二区", ServerStatus.Busy, false, false));
            region1.Servers.Add(new ServerInfo(103, "联通一区", ServerStatus.Smooth, false, false));
            region1.Servers.Add(new ServerInfo(104, "双线一区", ServerStatus.Smooth, false, true));
            config.Regions.Add(region1);

            // 华北区
            var region2 = new RegionInfo(2, "华北区");
            region2.Servers.Add(new ServerInfo(201, "电信一区", ServerStatus.Smooth, false, false));
            region2.Servers.Add(new ServerInfo(202, "电信二区", ServerStatus.Full, false, false));
            region2.Servers.Add(new ServerInfo(203, "联通一区", ServerStatus.Busy, false, false));
            config.Regions.Add(region2);

            // 华东区
            var region3 = new RegionInfo(3, "华东区");
            region3.Servers.Add(new ServerInfo(301, "电信一区", ServerStatus.Smooth, false, false));
            region3.Servers.Add(new ServerInfo(302, "联通一区", ServerStatus.Smooth, false, false));
            region3.Servers.Add(new ServerInfo(303, "双线一区", ServerStatus.Maintenance, false, false));
            config.Regions.Add(region3);

            return config;
        }
    }
}

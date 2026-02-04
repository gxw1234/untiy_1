using System;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using Client.MirScenes;
using Client.MirObjects;
using Client.MirNetwork;
using C = ClientPackets;

namespace Client
{
    /// <summary>
    /// FairyGUI 游戏内 UI 管理器
    /// 替换老的 MirControl 系统，使用 FairyGUI 显示游戏内 UI
    /// </summary>
    public class FguiGameUI : MonoBehaviour
    {
        private static FguiGameUI _instance;
        public static FguiGameUI Instance => _instance;

        // UI 包名
        private const string UI_PACKAGE = "UI";
        private const string UI_RES_PACKAGE = "UIRes";

        // 主要 UI 组件
        private GComponent _mainUI;           // 主界面（血条、技能栏等）
        private GComponent _inventoryUI;      // 背包
        private GComponent _characterUI;      // 角色属性
        private GComponent _skillUI;          // 技能
        private GComponent _chatUI;           // 聊天
        private GComponent _miniMapUI;        // 小地图
        private GComponent _bigMapUI;         // 大地图
        private GComponent _shopUI;           // 商店
        private GComponent _friendUI;         // 好友
        private GComponent _guildUI;          // 工会
        private GComponent _tradeUI;          // 交易
        private GComponent _questUI;          // 任务
        private GComponent _rankUI;           // 排行
        private GComponent _storageUI;        // 仓库

        // UI 是否已初始化
        public bool Initialized { get; private set; } = false;

        // 缓存的组件名列表
        private List<string> _availableComponents = new List<string>();

        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
                return;
            }
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void OnDestroy()
        {
            Cleanup();
            if (_instance == this)
                _instance = null;
        }

        /// <summary>
        /// 初始化游戏内 UI
        /// </summary>
        public void Initialize()
        {
            if (Initialized)
                return;

            // 列出 UI 包中的所有组件
            ListAvailableComponents();

            // 创建主界面
            CreateMainUI();

            Initialized = true;
            Debug.Log("[FguiGameUI] Initialized");
        }

        /// <summary>
        /// 列出 UI 包中所有可用的组件
        /// </summary>
        private void ListAvailableComponents()
        {
            _availableComponents.Clear();

            UIPackage pkg = UIPackage.GetByName(UI_PACKAGE);
            if (pkg == null)
            {
                Debug.LogWarning($"[FguiGameUI] Package '{UI_PACKAGE}' not found");
                return;
            }

            try
            {
                List<PackageItem> items = pkg.GetItems();
                Debug.Log($"[FguiGameUI] Found {items.Count} items in package '{UI_PACKAGE}':");

                foreach (var item in items)
                {
                    if (item == null || !item.exported)
                        continue;

                    if (item.type == PackageItemType.Component)
                    {
                        _availableComponents.Add(item.name);
                        Debug.Log($"  - Component: {item.name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"[FguiGameUI] Error listing components: {ex.Message}");
            }
        }

        /// <summary>
        /// 创建主界面 UI
        /// </summary>
        private void CreateMainUI()
        {
            // 直接使用 UI 包中的主界面组件
            _mainUI = UIPackage.CreateObject(UI_PACKAGE, "主界面_MainUI")?.asCom;
            if (_mainUI == null)
            {
                // 尝试刘海屏版本
                _mainUI = UIPackage.CreateObject(UI_PACKAGE, "主界面刘海屏_MainUI")?.asCom;
            }

            if (_mainUI != null)
            {
                GRoot.inst.AddChild(_mainUI);
                _mainUI.SetSize(GRoot.inst.width, GRoot.inst.height);
                _mainUI.AddRelation(GRoot.inst, RelationType.Size);
                Debug.Log($"[FguiGameUI] Created main UI: 主界面_MainUI");
                BindMainUIEvents();
            }
            else
            {
                Debug.LogError("[FguiGameUI] Failed to create main UI: 主界面_MainUI not found");
            }
        }

        /// <summary>
        /// 创建基础主界面（如果没有预制的）
        /// </summary>
        private void CreateBasicMainUI()
        {
            _mainUI = new GComponent();
            _mainUI.SetSize(GRoot.inst.width, GRoot.inst.height);
            _mainUI.touchable = false; // 不拦截点击，让点击穿透到游戏世界
            GRoot.inst.AddChild(_mainUI);

            // 这里可以添加基础 UI 元素
            // 比如血条、经验条等
        }

        /// <summary>
        /// 绑定主界面事件
        /// </summary>
        private void BindMainUIEvents()
        {
            if (_mainUI == null)
                return;

            // 绑定背包按钮
            BindButtonAction(_mainUI, "InventoryBtn", ToggleInventory);
            BindButtonAction(_mainUI, "DInventory", ToggleInventory);
            BindButtonAction(_mainUI, "DBag", ToggleInventory);
            
            // 绑定角色按钮
            BindButtonAction(_mainUI, "CharacterBtn", ToggleCharacter);
            BindButtonAction(_mainUI, "DCharacter", ToggleCharacter);
            BindButtonAction(_mainUI, "DRole", ToggleCharacter);
            
            // 绑定技能按钮
            BindButtonAction(_mainUI, "SkillBtn", ToggleSkill);
            BindButtonAction(_mainUI, "DSkill", ToggleSkill);
            
            // 绑定设置按钮
            BindButtonAction(_mainUI, "SettingBtn", ToggleSettings);
            BindButtonAction(_mainUI, "DSetting", ToggleSettings);
            BindButtonAction(_mainUI, "DOption", ToggleSettings);

            // 绑定聊天按钮
            BindButtonAction(_mainUI, "ChatBtn", ToggleChat);
            BindButtonAction(_mainUI, "DChat", ToggleChat);

            // 绑定地图按钮
            BindButtonAction(_mainUI, "MapBtn", ToggleBigMap);
            BindButtonAction(_mainUI, "DMap", ToggleBigMap);

            // 绑定商店按钮
            BindButtonAction(_mainUI, "ShopBtn", ToggleShop);
            BindButtonAction(_mainUI, "DShop", ToggleShop);

            // 绑定好友按钮
            BindButtonAction(_mainUI, "FriendBtn", ToggleFriend);
            BindButtonAction(_mainUI, "DFriend", ToggleFriend);

            // 绑定工会按钮
            BindButtonAction(_mainUI, "GuildBtn", ToggleGuild);
            BindButtonAction(_mainUI, "DGuild", ToggleGuild);

            // 绑定任务按钮
            BindButtonAction(_mainUI, "QuestBtn", ToggleQuest);
            BindButtonAction(_mainUI, "DQuest", ToggleQuest);

            // 绑定排行按钮
            BindButtonAction(_mainUI, "RankBtn", ToggleRank);
            BindButtonAction(_mainUI, "DRank", ToggleRank);

            // 绑定仓库按钮
            BindButtonAction(_mainUI, "StorageBtn", ToggleStorage);
            BindButtonAction(_mainUI, "DStorage", ToggleStorage);

            // 递归绑定所有子节点中的按钮
            BindAllButtons(_mainUI);
        }

        /// <summary>
        /// 递归绑定主界面中所有可能的按钮
        /// </summary>
        private void BindAllButtons(GComponent parent)
        {
            if (parent == null) return;

            for (int i = 0; i < parent.numChildren; i++)
            {
                GObject child = parent.GetChildAt(i);
                if (child == null) continue;

                string name = child.name;
                if (string.IsNullOrEmpty(name)) continue;

                // 根据按钮名称绑定对应功能
                if (name.Contains("Bag") || name.Contains("bag") || name.Contains("背包"))
                    BindButtonAction(parent, name, ToggleInventory);
                else if (name.Contains("Role") || name.Contains("role") || name.Contains("角色") || name.Contains("State"))
                    BindButtonAction(parent, name, ToggleCharacter);
                else if (name.Contains("Skill") || name.Contains("skill") || name.Contains("技能"))
                    BindButtonAction(parent, name, ToggleSkill);
                else if (name.Contains("Set") || name.Contains("set") || name.Contains("设置"))
                    BindButtonAction(parent, name, ToggleSettings);
                else if (name.Contains("Chat") || name.Contains("chat") || name.Contains("聊天"))
                    BindButtonAction(parent, name, ToggleChat);
                else if (name.Contains("Map") || name.Contains("map") || name.Contains("地图"))
                    BindButtonAction(parent, name, ToggleBigMap);
                else if (name.Contains("Shop") || name.Contains("shop") || name.Contains("商店"))
                    BindButtonAction(parent, name, ToggleShop);
                else if (name.Contains("Friend") || name.Contains("friend") || name.Contains("好友"))
                    BindButtonAction(parent, name, ToggleFriend);
                else if (name.Contains("Guild") || name.Contains("guild") || name.Contains("工会"))
                    BindButtonAction(parent, name, ToggleGuild);
                else if (name.Contains("Quest") || name.Contains("quest") || name.Contains("任务"))
                    BindButtonAction(parent, name, ToggleQuest);
                else if (name.Contains("Rank") || name.Contains("rank") || name.Contains("排行"))
                    BindButtonAction(parent, name, ToggleRank);
                else if (name.Contains("Storage") || name.Contains("storage") || name.Contains("仓库"))
                    BindButtonAction(parent, name, ToggleStorage);

                // 如果是容器，递归绑定
                if (child is GComponent childComp)
                    BindAllButtons(childComp);
            }
        }

        /// <summary>
        /// 绑定按钮事件
        /// </summary>
        private void BindButtonAction(GComponent parent, string btnName, Action callback)
        {
            if (parent == null || string.IsNullOrEmpty(btnName) || callback == null)
                return;

            GObject btn = parent.GetChild(btnName);
            if (btn != null)
            {
                btn.onClick.Clear();
                btn.onClick.Add((EventContext ctx) => callback());
                Debug.Log($"[FguiGameUI] Bound button: {btnName}");
            }
        }

        /// <summary>
        /// 切换背包显示
        /// </summary>
        public void ToggleInventory()
        {
            if (_inventoryUI == null)
            {
                _inventoryUI = UIPackage.CreateObject(UI_PACKAGE, "背包_DBagUI")?.asCom;
                if (_inventoryUI != null)
                {
                    GRoot.inst.AddChild(_inventoryUI);
                    CenterComponent(_inventoryUI);
                    MakeDraggable(_inventoryUI);
                    BindCloseButton(_inventoryUI);
                    BindInventoryEvents();
                    RefreshInventoryItems();
                    Debug.Log("[FguiGameUI] Created inventory UI: 背包_DBagUI");
                }
            }
            else
            {
                _inventoryUI.visible = !_inventoryUI.visible;
                if (_inventoryUI.visible)
                    RefreshInventoryItems();
            }
        }

        /// <summary>
        /// 刷新背包物品显示
        /// </summary>
        public void RefreshInventoryItems()
        {
            if (_inventoryUI == null || GameScene.User == null)
                return;

            // 获取背包物品列表
            var inventory = GameScene.User.Inventory;
            if (inventory == null)
                return;

            // 遍历背包格子，更新物品显示
            // 背包格子通常命名为 item0, item1, ... 或 slot0, slot1, ...
            for (int i = 0; i < inventory.Length; i++)
            {
                var item = inventory[i];
                
                // 尝试多种可能的格子命名
                GObject slot = _inventoryUI.GetChild($"item{i}") 
                    ?? _inventoryUI.GetChild($"slot{i}")
                    ?? _inventoryUI.GetChild($"cell{i}")
                    ?? _inventoryUI.GetChild($"grid{i}");

                if (slot == null)
                    continue;

                // 获取格子中的图标加载器
                GLoader icon = null;
                if (slot is GComponent slotComp)
                {
                    icon = slotComp.GetChild("icon") as GLoader 
                        ?? slotComp.GetChild("item") as GLoader
                        ?? slotComp.GetChild("image") as GLoader;
                }
                else if (slot is GLoader loader)
                {
                    icon = loader;
                }

                if (icon == null)
                    continue;

                if (item != null && item.Info != null)
                {
                    // 有物品，显示物品图标
                    // 物品图标路径需要根据实际资源路径调整
                    icon.url = $"ui://UIRes/item{item.Info.Image}";
                    icon.visible = true;
                }
                else
                {
                    // 空格子
                    icon.url = "";
                    icon.visible = false;
                }
            }

            // 更新金币显示
            GTextField goldLabel = _inventoryUI.GetChild("GoldLabel") as GTextField
                ?? _inventoryUI.GetChild("gold") as GTextField
                ?? _inventoryUI.GetChild("money") as GTextField;
            if (goldLabel != null)
            {
                goldLabel.text = GameScene.Gold.ToString("N0");
            }

            Debug.Log($"[FguiGameUI] Refreshed inventory, {inventory.Length} slots");
        }

        /// <summary>
        /// 切换角色属性显示
        /// </summary>
        public void ToggleCharacter()
        {
            if (_characterUI == null)
            {
                _characterUI = UIPackage.CreateObject(UI_PACKAGE, "角色_DStateUI")?.asCom;
                if (_characterUI != null)
                {
                    GRoot.inst.AddChild(_characterUI);
                    CenterComponent(_characterUI);
                    MakeDraggable(_characterUI);
                    BindCloseButton(_characterUI);
                    BindCharacterEvents();
                    RefreshCharacterInfo();
                    Debug.Log("[FguiGameUI] Created character UI: 角色_DStateUI");
                }
            }
            else
            {
                _characterUI.visible = !_characterUI.visible;
                if (_characterUI.visible)
                    RefreshCharacterInfo();
            }
        }

        /// <summary>
        /// 刷新角色信息显示
        /// </summary>
        public void RefreshCharacterInfo()
        {
            if (_characterUI == null || MapObject.User == null)
                return;

            var user = MapObject.User;

            // 更新角色名称
            SetTextField(_characterUI, user.Name, "name", "Name", "角色名");

            // 更新等级
            SetTextField(_characterUI, $"Lv.{user.Level}", "level", "Level", "等级");

            // 更新职业
            SetTextField(_characterUI, user.Class.ToString(), "class", "Class", "职业");

            // 更新HP/MP
            SetTextField(_characterUI, $"{user.HP}", "hp", "HP", "生命");
            SetTextField(_characterUI, $"{user.MP}", "mp", "MP", "魔法");

            // 更新经验
            if (user.MaxExperience > 0)
            {
                float expPercent = (float)user.Experience / user.MaxExperience * 100;
                SetTextField(_characterUI, $"{expPercent:F1}%", "exp", "Exp", "经验");
            }

            // 更新装备显示
            RefreshEquipment();

            Debug.Log("[FguiGameUI] Refreshed character info");
        }

        /// <summary>
        /// 刷新装备显示
        /// </summary>
        private void RefreshEquipment()
        {
            if (_characterUI == null || MapObject.User == null)
                return;

            var equipment = MapObject.User.Equipment;
            if (equipment == null)
                return;

            // 装备槽位名称映射
            string[] slotNames = { "weapon", "armor", "helmet", "necklace", "braceletL", "braceletR", "ringL", "ringR", "amulet", "belt", "boots", "stone", "torch", "mount" };

            for (int i = 0; i < equipment.Length && i < slotNames.Length; i++)
            {
                var item = equipment[i];

                // 尝试多种可能的格子命名
                GObject slot = _characterUI.GetChild(slotNames[i])
                    ?? _characterUI.GetChild($"equip{i}")
                    ?? _characterUI.GetChild($"slot{i}");

                if (slot == null)
                    continue;

                // 获取格子中的图标加载器
                GLoader icon = null;
                if (slot is GComponent slotComp)
                {
                    icon = slotComp.GetChild("icon") as GLoader
                        ?? slotComp.GetChild("item") as GLoader
                        ?? slotComp.GetChild("image") as GLoader;
                }
                else if (slot is GLoader loader)
                {
                    icon = loader;
                }

                if (icon == null)
                    continue;

                if (item != null && item.Info != null)
                {
                    icon.url = $"ui://UIRes/item{item.Info.Image}";
                    icon.visible = true;
                }
                else
                {
                    icon.url = "";
                    icon.visible = false;
                }
            }
        }

        /// <summary>
        /// 设置文本字段（尝试多个可能的名字）
        /// </summary>
        private void SetTextField(GComponent parent, string value, params string[] names)
        {
            if (parent == null) return;

            foreach (string name in names)
            {
                GTextField tf = parent.GetChild(name) as GTextField;
                if (tf != null)
                {
                    tf.text = value;
                    return;
                }
            }
        }

        /// <summary>
        /// 切换技能显示
        /// </summary>
        public void ToggleSkill()
        {
            if (_skillUI == null)
            {
                _skillUI = UIPackage.CreateObject(UI_PACKAGE, "技能设置_DSkillConfigUI")?.asCom;
                if (_skillUI != null)
                {
                    GRoot.inst.AddChild(_skillUI);
                    CenterComponent(_skillUI);
                    MakeDraggable(_skillUI);
                    BindCloseButton(_skillUI);
                    Debug.Log("[FguiGameUI] Created skill UI: 技能设置_DSkillConfigUI");
                }
            }
            else
            {
                _skillUI.visible = !_skillUI.visible;
            }
        }

        /// <summary>
        /// 切换设置显示
        /// </summary>
        public void ToggleSettings()
        {
            if (_settingsUI == null)
            {
                _settingsUI = UIPackage.CreateObject(UI_PACKAGE, "设置_DSetUI")?.asCom;
                if (_settingsUI != null)
                {
                    GRoot.inst.AddChild(_settingsUI);
                    CenterComponent(_settingsUI);
                    MakeDraggable(_settingsUI);
                    BindCloseButton(_settingsUI);
                    Debug.Log("[FguiGameUI] Created settings UI: 设置_DSetUI");
                }
            }
            else
            {
                _settingsUI.visible = !_settingsUI.visible;
            }
        }

        private GComponent _settingsUI;

        /// <summary>
        /// 切换聊天显示
        /// </summary>
        public void ToggleChat()
        {
            if (_chatUI == null)
            {
                _chatUI = UIPackage.CreateObject(UI_PACKAGE, "聊天_DCharUI")?.asCom;
                if (_chatUI != null)
                {
                    GRoot.inst.AddChild(_chatUI);
                    CenterComponent(_chatUI);
                    MakeDraggable(_chatUI);
                    BindCloseButton(_chatUI);
                    Debug.Log("[FguiGameUI] Created chat UI: 聊天_DCharUI");
                }
            }
            else
            {
                _chatUI.visible = !_chatUI.visible;
            }
        }

        /// <summary>
        /// 切换大地图显示
        /// </summary>
        public void ToggleBigMap()
        {
            if (_bigMapUI == null)
            {
                _bigMapUI = UIPackage.CreateObject(UI_PACKAGE, "地图_DBigMapWindowUI")?.asCom;
                if (_bigMapUI != null)
                {
                    GRoot.inst.AddChild(_bigMapUI);
                    CenterComponent(_bigMapUI);
                    MakeDraggable(_bigMapUI);
                    BindCloseButton(_bigMapUI);
                    Debug.Log("[FguiGameUI] Created big map UI: 地图_DBigMapWindowUI");
                }
            }
            else
            {
                _bigMapUI.visible = !_bigMapUI.visible;
            }
        }

        /// <summary>
        /// 切换商店显示
        /// </summary>
        public void ToggleShop()
        {
            if (_shopUI == null)
            {
                _shopUI = UIPackage.CreateObject(UI_PACKAGE, "商店_DShopUI")?.asCom;
                if (_shopUI != null)
                {
                    GRoot.inst.AddChild(_shopUI);
                    CenterComponent(_shopUI);
                    MakeDraggable(_shopUI);
                    BindCloseButton(_shopUI);
                    Debug.Log("[FguiGameUI] Created shop UI: 商店_DShopUI");
                }
            }
            else
            {
                _shopUI.visible = !_shopUI.visible;
            }
        }

        /// <summary>
        /// 切换好友显示
        /// </summary>
        public void ToggleFriend()
        {
            if (_friendUI == null)
            {
                _friendUI = UIPackage.CreateObject(UI_PACKAGE, "好友_Friends_MainUI")?.asCom;
                if (_friendUI != null)
                {
                    GRoot.inst.AddChild(_friendUI);
                    CenterComponent(_friendUI);
                    MakeDraggable(_friendUI);
                    BindCloseButton(_friendUI);
                    Debug.Log("[FguiGameUI] Created friend UI: 好友_Friends_MainUI");
                }
            }
            else
            {
                _friendUI.visible = !_friendUI.visible;
            }
        }

        /// <summary>
        /// 切换工会显示
        /// </summary>
        public void ToggleGuild()
        {
            if (_guildUI == null)
            {
                _guildUI = UIPackage.CreateObject(UI_PACKAGE, "工会_WinGuild_MainUI")?.asCom;
                if (_guildUI != null)
                {
                    GRoot.inst.AddChild(_guildUI);
                    CenterComponent(_guildUI);
                    MakeDraggable(_guildUI);
                    BindCloseButton(_guildUI);
                    Debug.Log("[FguiGameUI] Created guild UI: 工会_WinGuild_MainUI");
                }
            }
            else
            {
                _guildUI.visible = !_guildUI.visible;
            }
        }

        /// <summary>
        /// 切换任务显示
        /// </summary>
        public void ToggleQuest()
        {
            if (_questUI == null)
            {
                _questUI = UIPackage.CreateObject(UI_PACKAGE, "任务_DA2EWindow1UI")?.asCom;
                if (_questUI != null)
                {
                    GRoot.inst.AddChild(_questUI);
                    CenterComponent(_questUI);
                    MakeDraggable(_questUI);
                    BindCloseButton(_questUI);
                    Debug.Log("[FguiGameUI] Created quest UI: 任务_DA2EWindow1UI");
                }
            }
            else
            {
                _questUI.visible = !_questUI.visible;
            }
        }

        /// <summary>
        /// 切换排行显示
        /// </summary>
        public void ToggleRank()
        {
            if (_rankUI == null)
            {
                _rankUI = UIPackage.CreateObject(UI_PACKAGE, "排行_RankListWinUI")?.asCom;
                if (_rankUI != null)
                {
                    GRoot.inst.AddChild(_rankUI);
                    CenterComponent(_rankUI);
                    MakeDraggable(_rankUI);
                    BindCloseButton(_rankUI);
                    Debug.Log("[FguiGameUI] Created rank UI: 排行_RankListWinUI");
                }
            }
            else
            {
                _rankUI.visible = !_rankUI.visible;
            }
        }

        /// <summary>
        /// 切换仓库显示
        /// </summary>
        public void ToggleStorage()
        {
            if (_storageUI == null)
            {
                _storageUI = UIPackage.CreateObject(UI_PACKAGE, "仓库_StorageUI")?.asCom;
                if (_storageUI != null)
                {
                    GRoot.inst.AddChild(_storageUI);
                    CenterComponent(_storageUI);
                    MakeDraggable(_storageUI);
                    BindCloseButton(_storageUI);
                    Debug.Log("[FguiGameUI] Created storage UI: 仓库_StorageUI");
                }
            }
            else
            {
                _storageUI.visible = !_storageUI.visible;
            }
        }

        /// <summary>
        /// 通用绑定关闭按钮（递归查找所有可能的关闭按钮）
        /// </summary>
        private void BindCloseButton(GComponent comp)
        {
            if (comp == null) return;

            // 可能的关闭按钮名称（注意有些拼写错误如 Colse）
            string[] closeNames = { 
                "CloseBtn", "DClose", "closeBtn", "close", "BtnClose", "关闭", 
                "btn_close", "btnClose", "X", "x",
                "DBtnStateColse", "DBtnColse", "Colse", "colse"  // 拼写错误的版本
            };
            
            // 先在当前组件中查找
            foreach (string name in closeNames)
            {
                GObject closeBtn = comp.GetChild(name);
                if (closeBtn != null)
                {
                    closeBtn.onClick.Clear();
                    closeBtn.onClick.Add((EventContext ctx) => comp.visible = false);
                    Debug.Log($"[FguiGameUI] Bound close button: {name}");
                }
            }

            // 递归查找所有子组件中的关闭按钮
            BindCloseButtonRecursive(comp, comp);
        }

        /// <summary>
        /// 递归查找并绑定关闭按钮
        /// </summary>
        private void BindCloseButtonRecursive(GComponent root, GComponent parent)
        {
            if (parent == null) return;

            for (int i = 0; i < parent.numChildren; i++)
            {
                GObject child = parent.GetChildAt(i);
                if (child == null) continue;

                string name = child.name?.ToLower() ?? "";
                
                // 检查是否是关闭按钮（名称包含 close、colse、x、关闭 等）
                bool isCloseBtn = name.Contains("close") || 
                                  name.Contains("colse") ||  // 拼写错误的版本
                                  name.Contains("关闭") || 
                                  name == "x" ||
                                  name.Contains("btn_x") ||
                                  name.Contains("btnx");

                if (isCloseBtn)
                {
                    child.onClick.Clear();
                    child.onClick.Add((EventContext ctx) => root.visible = false);
                    Debug.Log($"[FguiGameUI] Bound close button (recursive): {child.name}");
                }

                // 如果是容器，继续递归
                if (child is GComponent childComp)
                {
                    BindCloseButtonRecursive(root, childComp);
                }
            }
        }

        /// <summary>
        /// 尝试创建组件（尝试多个可能的名字）
        /// </summary>
        private GComponent TryCreateComponent(params string[] names)
        {
            foreach (string name in names)
            {
                if (_availableComponents.Contains(name))
                {
                    GComponent comp = UIPackage.CreateObject(UI_PACKAGE, name)?.asCom;
                    if (comp != null)
                    {
                        Debug.Log($"[FguiGameUI] Created component: {name}");
                        return comp;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 居中组件
        /// </summary>
        private void CenterComponent(GComponent comp)
        {
            if (comp == null)
                return;

            comp.SetXY((GRoot.inst.width - comp.width) / 2, (GRoot.inst.height - comp.height) / 2);
        }

        /// <summary>
        /// 使组件可拖动（点击边框/标题栏可以移动位置）
        /// </summary>
        private void MakeDraggable(GComponent comp)
        {
            if (comp == null)
                return;

            // 设置组件可拖动
            comp.draggable = true;
            
            // 限制拖动范围在屏幕内
            comp.dragBounds = new UnityEngine.Rect(0, 0, GRoot.inst.width, GRoot.inst.height);

            // 点击时置顶
            comp.onTouchBegin.Add((EventContext ctx) =>
            {
                comp.parent?.SetChildIndex(comp, comp.parent.numChildren - 1);
            });

            Debug.Log($"[FguiGameUI] Made draggable: {comp.name}");
        }

        /// <summary>
        /// 绑定背包事件
        /// </summary>
        private void BindInventoryEvents()
        {
            if (_inventoryUI == null)
                return;

            // 绑定关闭按钮
            GObject closeBtn = _inventoryUI.GetChild("CloseBtn") ?? _inventoryUI.GetChild("DClose");
            if (closeBtn != null)
            {
                closeBtn.onClick.Clear();
                closeBtn.onClick.Add(() => _inventoryUI.visible = false);
            }
        }

        /// <summary>
        /// 绑定角色属性事件
        /// </summary>
        private void BindCharacterEvents()
        {
            if (_characterUI == null)
                return;

            // 绑定关闭按钮
            GObject closeBtn = _characterUI.GetChild("CloseBtn") ?? _characterUI.GetChild("DClose");
            if (closeBtn != null)
            {
                closeBtn.onClick.Clear();
                closeBtn.onClick.Add(() => _characterUI.visible = false);
            }
        }

        /// <summary>
        /// 更新 UI（每帧调用）
        /// </summary>
        public void UpdateUI()
        {
            if (!Initialized || GameScene.Scene == null)
                return;

            UpdatePlayerInfo();
        }

        /// <summary>
        /// 更新玩家信息显示
        /// </summary>
        private void UpdatePlayerInfo()
        {
            if (_mainUI == null || MapObject.User == null)
                return;

            // 更新血量 (UserObject 只有 HP, MP，没有 MaxHP, MaxMP)
            UpdateTextField("HPLabel", "DHP", $"{MapObject.User.HP}");
            
            // 更新魔法
            UpdateTextField("MPLabel", "DMP", $"{MapObject.User.MP}");
            
            // 更新等级
            UpdateTextField("LevelLabel", "DLevel", $"Lv.{MapObject.User.Level}");
            
            // 更新经验
            if (MapObject.User.MaxExperience > 0)
            {
                float expPercent = (float)MapObject.User.Experience / MapObject.User.MaxExperience * 100;
                UpdateTextField("ExpLabel", "DExp", $"{expPercent:F1}%");
            }

            // 更新金币 (Gold 在 GameScene 中)
            UpdateTextField("GoldLabel", "DGold", $"{GameScene.Gold}");
        }

        /// <summary>
        /// 更新文本字段（尝试多个可能的名字）
        /// </summary>
        private void UpdateTextField(params string[] args)
        {
            if (_mainUI == null || args.Length < 2)
                return;

            string value = args[args.Length - 1];

            for (int i = 0; i < args.Length - 1; i++)
            {
                string name = args[i];
                GTextField tf = _mainUI.GetChild(name) as GTextField;
                if (tf != null)
                {
                    tf.text = value;
                    return;
                }
            }
        }

        /// <summary>
        /// 清理资源
        /// </summary>
        public void Cleanup()
        {
            if (_mainUI != null)
            {
                _mainUI.RemoveFromParent();
                _mainUI.Dispose();
                _mainUI = null;
            }

            if (_inventoryUI != null)
            {
                _inventoryUI.RemoveFromParent();
                _inventoryUI.Dispose();
                _inventoryUI = null;
            }

            if (_characterUI != null)
            {
                _characterUI.RemoveFromParent();
                _characterUI.Dispose();
                _characterUI = null;
            }

            if (_skillUI != null)
            {
                _skillUI.RemoveFromParent();
                _skillUI.Dispose();
                _skillUI = null;
            }

            if (_settingsUI != null)
            {
                _settingsUI.RemoveFromParent();
                _settingsUI.Dispose();
                _settingsUI = null;
            }

            if (_chatUI != null)
            {
                _chatUI.RemoveFromParent();
                _chatUI.Dispose();
                _chatUI = null;
            }

            if (_bigMapUI != null)
            {
                _bigMapUI.RemoveFromParent();
                _bigMapUI.Dispose();
                _bigMapUI = null;
            }

            if (_shopUI != null)
            {
                _shopUI.RemoveFromParent();
                _shopUI.Dispose();
                _shopUI = null;
            }

            if (_friendUI != null)
            {
                _friendUI.RemoveFromParent();
                _friendUI.Dispose();
                _friendUI = null;
            }

            if (_guildUI != null)
            {
                _guildUI.RemoveFromParent();
                _guildUI.Dispose();
                _guildUI = null;
            }

            if (_tradeUI != null)
            {
                _tradeUI.RemoveFromParent();
                _tradeUI.Dispose();
                _tradeUI = null;
            }

            if (_questUI != null)
            {
                _questUI.RemoveFromParent();
                _questUI.Dispose();
                _questUI = null;
            }

            if (_rankUI != null)
            {
                _rankUI.RemoveFromParent();
                _rankUI.Dispose();
                _rankUI = null;
            }

            if (_storageUI != null)
            {
                _storageUI.RemoveFromParent();
                _storageUI.Dispose();
                _storageUI = null;
            }

            _availableComponents.Clear();
            Initialized = false;
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        public static void ShowToast(string message)
        {
            FguiBootstrap.ShowToast(message);
        }
    }
}

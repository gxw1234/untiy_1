using System;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using Client.MirScenes;
using Client.MirObjects;
using Client.MirNetwork;
using Client.MirGraphics;
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
        private GComponent _inventoryUI;      // 背包（老 UI 备用）
        private home.UI_Component1 _bagUI;    // 新 FairyGUI 背包
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
        /// 切换背包显示（使用新 FairyGUI home.Component1）
        /// </summary>
        public void ToggleInventory()
        {
            if (_bagUI == null)
            {
                _bagUI = UIPackage.CreateObjectFromURL(home.UI_Component1.URL) as home.UI_Component1;
                if (_bagUI == null) { Debug.LogError("[FguiGameUI] Failed to create bag UI"); return; }

                GRoot.inst.AddChild(_bagUI);
                _bagUI.SetXY(100, 50);

                // 关闭按钮
                _bagUI.m_close.onClick.Add(() => _bagUI.visible = false);

                // 格子渲染：8列 × 5行 = 40格
                _bagUI.m_item_list.columnCount = 8;
                _bagUI.m_item_list.itemRenderer = RenderInventorySlot;
                _bagUI.m_item_list.numItems = 40;

                Debug.Log("[FguiGameUI] Created new bag UI (Component1)");
            }
            else
            {
                _bagUI.visible = !_bagUI.visible;
            }

            if (_bagUI.visible)
                RefreshBagItems();
        }

        private void RenderInventorySlot(int index, GObject item)
        {
            var slot = item as GComponent;
            if (slot == null) return;

            var loader = slot.GetChild("n0") as GLoader;
            if (loader == null) return;

            var user = MapObject.User;
            var inv = user?.Inventory;
            // 背包格从 BeltIdx 开始，跳过腰带格
            int realIndex = (user?.BeltIdx ?? 6) + index;

            if (inv == null || realIndex >= inv.Length || inv[realIndex] == null || inv[realIndex].Info == null)
            {
                loader.texture = null;
                loader.visible = false;
                return;
            }

            var texture = Libraries.Items.GetTexture(inv[realIndex].Image);
            if (texture != null)
            {
                loader.texture = new NTexture(texture);
                loader.visible = true;
            }
            else
            {
                loader.texture = null;
                loader.visible = false;
            }
        }

        public void RefreshBagItems()
        {
            if (_bagUI == null) return;
            _bagUI.m_item_list.numItems = 0;
            _bagUI.m_item_list.numItems = 40;
        }

        /// <summary>
        /// 刷新背包物品显示
        /// </summary>
        public void RefreshInventoryItems()
        {
            if (_inventoryUI == null || MapObject.User == null)
                return;

            // 获取背包物品列表
            var inventory = MapObject.User.Inventory;
            if (inventory == null)
                return;

            // FairyGUI 背包 UI 使用 DBagGrid 列表来显示物品
            GList bagGrid = _inventoryUI.GetChild("DBagGrid") as GList;
            if (bagGrid != null)
            {
                // 设置列表项数量
                bagGrid.numItems = inventory.Length;
                
                // 遍历列表项，更新物品显示
                for (int i = 0; i < inventory.Length && i < bagGrid.numItems; i++)
                {
                    var item = inventory[i];
                    GComponent slot = bagGrid.GetChildAt(i) as GComponent;
                    if (slot == null) continue;

                    SetInventorySlotItem(slot, item, i);
                }
                
                Debug.Log($"[FguiGameUI] Refreshed inventory via DBagGrid, {inventory.Length} slots");
            }
            else
            {
                // 备用方案：尝试直接查找格子
                for (int i = 0; i < inventory.Length; i++)
                {
                    var item = inventory[i];
                    
                    GObject slot = _inventoryUI.GetChild($"item{i}") 
                        ?? _inventoryUI.GetChild($"slot{i}")
                        ?? _inventoryUI.GetChild($"cell{i}");

                    if (slot == null) continue;

                    if (slot is GComponent slotComp)
                    {
                        SetInventorySlotItem(slotComp, item, i);
                    }
                }
                
                Debug.Log($"[FguiGameUI] Refreshed inventory via direct slots, {inventory.Length} slots");
            }

            // 更新金币显示
            GTextField goldLabel = _inventoryUI.GetChild("GoldLabel") as GTextField
                ?? _inventoryUI.GetChild("gold") as GTextField
                ?? _inventoryUI.GetChild("money") as GTextField;
            if (goldLabel != null)
            {
                goldLabel.text = GameScene.Gold.ToString("N0");
            }
        }

        /// <summary>
        /// 设置背包格子的物品显示
        /// </summary>
        private void SetInventorySlotItem(GComponent slot, UserItem item, int slotIndex)
        {
            if (slot == null) return;

            // 获取格子中的图标加载器
            GLoader icon = slot.GetChild("icon") as GLoader 
                ?? slot.GetChild("item") as GLoader
                ?? slot.GetChild("image") as GLoader;

            if (icon == null) return;

            if (item != null && item.Info != null)
            {
                // 有物品，从 Libraries.Items 获取背包物品图标
                var texture = MirGraphics.Libraries.Items.GetTexture(item.Info.Image);
                if (texture != null)
                {
                    icon.url = null;
                    NTexture nTex = new NTexture(texture);
                    icon.texture = nTex;
                    icon.visible = true;
                }
                else
                {
                    icon.texture = null;
                    icon.visible = false;
                }
            }
            else
            {
                // 空格子
                icon.texture = null;
                icon.visible = false;
            }

            // 绑定点击事件（双击装备物品）
            BindInventorySlotClick(slot, slotIndex);
        }

        /// <summary>
        /// 绑定背包格子点击事件（双击装备物品）
        /// </summary>
        private void BindInventorySlotClick(GComponent slot, int slotIndex)
        {
            if (slot == null) return;

            slot.onClick.Clear();
            slot.onClick.Add((EventContext ctx) =>
            {
                if (MapObject.User == null || MapObject.User.Inventory == null)
                    return;

                var item = MapObject.User.Inventory[slotIndex];
                if (item == null || item.Info == null)
                    return;

                // 双击装备物品
                if (ctx.inputEvent.isDoubleClick)
                {
                    UseInventoryItem(item, slotIndex);
                }
            });
        }

        /// <summary>
        /// 使用背包物品（装备）
        /// </summary>
        private void UseInventoryItem(UserItem item, int slotIndex)
        {
            if (item == null || item.Info == null)
                return;

            // 根据物品类型发送装备请求
            int equipSlot = -1;
            switch (item.Info.Type)
            {
                case ItemType.Weapon:
                    equipSlot = (int)EquipmentSlot.Weapon;
                    break;
                case ItemType.Armour:
                    equipSlot = (int)EquipmentSlot.Armour;
                    break;
                case ItemType.Helmet:
                    equipSlot = (int)EquipmentSlot.Helmet;
                    break;
                case ItemType.Necklace:
                    equipSlot = (int)EquipmentSlot.Necklace;
                    break;
                case ItemType.Bracelet:
                    // 手镯优先右手，如果右手有了就左手
                    if (MapObject.User.Equipment[(int)EquipmentSlot.BraceletR] == null)
                        equipSlot = (int)EquipmentSlot.BraceletR;
                    else
                        equipSlot = (int)EquipmentSlot.BraceletL;
                    break;
                case ItemType.Ring:
                    // 戒指优先右手，如果右手有了就左手
                    if (MapObject.User.Equipment[(int)EquipmentSlot.RingR] == null)
                        equipSlot = (int)EquipmentSlot.RingR;
                    else
                        equipSlot = (int)EquipmentSlot.RingL;
                    break;
                case ItemType.Amulet:
                    equipSlot = (int)EquipmentSlot.Amulet;
                    break;
                case ItemType.Belt:
                    equipSlot = (int)EquipmentSlot.Belt;
                    break;
                case ItemType.Boots:
                    equipSlot = (int)EquipmentSlot.Boots;
                    break;
                case ItemType.Stone:
                    equipSlot = (int)EquipmentSlot.Stone;
                    break;
                case ItemType.Torch:
                    equipSlot = (int)EquipmentSlot.Torch;
                    break;
                case ItemType.Mount:
                    equipSlot = (int)EquipmentSlot.Mount;
                    break;
                case ItemType.Potion:
                case ItemType.Scroll:
                    // 药水和卷轴直接使用
                    MirNetwork.Network.Enqueue(new C.UseItem { UniqueID = item.UniqueID, Grid = MirGridType.Inventory });
                    Debug.Log($"[FguiGameUI] Use item: {item.Info.Name}");
                    return;
                default:
                    Debug.Log($"[FguiGameUI] Cannot equip item type: {item.Info.Type}");
                    return;
            }

            if (equipSlot >= 0)
            {
                // 发送装备请求
                MirNetwork.Network.Enqueue(new C.EquipItem { Grid = MirGridType.Inventory, UniqueID = item.UniqueID, To = equipSlot });
                Debug.Log($"[FguiGameUI] Equip item: {item.Info.Name} to slot {equipSlot}");
            }
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
            {
                Debug.LogWarning("[FguiGameUI] RefreshEquipment: _characterUI or User is null");
                return;
            }

            var equipment = MapObject.User.Equipment;
            if (equipment == null)
            {
                Debug.LogWarning("[FguiGameUI] RefreshEquipment: Equipment is null");
                return;
            }

            Debug.Log($"[FguiGameUI] RefreshEquipment: Equipment count = {equipment.Length}");

            // 打印所有装备信息
            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] != null)
                    Debug.Log($"[FguiGameUI] Equipment[{i}]: {equipment[i].Info?.Name}, Image={equipment[i].Info?.Image}");
            }

            // 获取第一页（装备页）DA2EPage1
            GComponent page1 = _characterUI.GetChild("DA2EPage1") as GComponent;
            if (page1 == null)
            {
                Debug.Log("[FguiGameUI] DA2EPage1 not found directly, searching in children...");
                // 递归查找
                page1 = FindChildComponent(_characterUI, "DA2EPage1");
            }

            if (page1 == null)
            {
                Debug.LogWarning("[FguiGameUI] DA2EPage1 not found!");
                // 打印 _characterUI 的所有子节点
                Debug.Log($"[FguiGameUI] _characterUI children count: {_characterUI.numChildren}");
                for (int i = 0; i < _characterUI.numChildren; i++)
                {
                    var child = _characterUI.GetChildAt(i);
                    Debug.Log($"[FguiGameUI] Child[{i}]: {child?.name} ({child?.GetType().Name})");
                }
                return;
            }

            Debug.Log($"[FguiGameUI] Found DA2EPage1, children count: {page1.numChildren}");

            // 显示基础角色模型（DA2EPage1 中的 role loader）
            // role loader 位置: xy="60,181" size="235,294"
            GLoader roleLoader = page1.GetChild("role") as GLoader;
            if (roleLoader != null)
            {
                roleLoader.visible = true;
            }

            // 隐藏 Equip 组件（我们用动态创建的 loader 来显示装备）
            GComponent equipComp = page1.GetChild("Equip") as GComponent;
            if (equipComp != null)
            {
                equipComp.visible = false;
            }

            // 动态创建 loader 来显示武器和衣服
            // 需要手动调整位置和缩放比例来匹配角色模型
            var user = MapObject.User;
            
            // 衣服 (equipment[1]) - 先绘制，在下层
            if (equipment.Length > 1 && equipment[1] != null && equipment[1].Info != null)
            {
                ItemInfo realItem = Functions.GetRealItem(equipment[1].Info, user.Level, user.Class, GameScene.ItemInfoList);
                DrawEquipmentOverlay(page1, roleLoader, realItem.Image, "armor", 1);
            }
            else
            {
                HideEquipmentOverlay("armor");
            }
            
            // 武器 (equipment[0]) - 后绘制，在上层
            if (equipment.Length > 0 && equipment[0] != null && equipment[0].Info != null)
            {
                ItemInfo realItem = Functions.GetRealItem(equipment[0].Info, user.Level, user.Class, GameScene.ItemInfoList);
                DrawEquipmentOverlay(page1, roleLoader, realItem.Image, "weapon", 0);
            }
            else
            {
                HideEquipmentOverlay("weapon");
            }

            // EquipmentSlot 到 FairyGUI EquipCell 的映射
            // EquipmentSlot 枚举: Weapon=0, Armour=1, Helmet=2, Torch=3, Necklace=4, BraceletL=5, BraceletR=6, RingL=7, RingR=8, Amulet=9, Belt=10, Boots=11, Stone=12, Mount=13
            // FairyGUI DA2EPage1 中的 EquipCell:
            //   武器和衣服(slot 0,1)显示在角色模型上(Equip组件)，不是独立槽位，用 -1 表示跳过
            //   EquipCell2 = 头盔 (xy=31,255)
            //   EquipCell3 = 项链 (xy=256,190)
            //   EquipCell5 = 左手镯 (xy=31,320)
            //   EquipCell6 = 右手镯 (xy=256,320)
            //   EquipCell7 = 左戒指 (xy=31,385)
            //   EquipCell8 = 右戒指 (xy=256,385)
            //   EquipCell9 = 护身符 (xy=31,453)
            //   EquipCell10 = 腰带 (xy=106,453)
            //   EquipCell11 = 鞋子 (xy=181,450)
            //   EquipCell12 = 宝石 (xy=256,450)
            //   EquipCell14 = 火把 (xy=256,255)
            //   EquipCell15 = 坐骑 (xy=31,190)
            // 映射: slotToCell[EquipmentSlot] = EquipCell编号，-1 表示跳过
            // Weapon=0->-1(跳过), Armour=1->-1(跳过), Helmet=2->2, Torch=3->14, Necklace=4->3, BraceletL=5->5, BraceletR=6->6, RingL=7->7, RingR=8->8, Amulet=9->9, Belt=10->10, Boots=11->11, Stone=12->12, Mount=13->15
            int[] slotToCell = { -1, -1, 2, 14, 3, 5, 6, 7, 8, 9, 10, 11, 12, 15 };

            for (int i = 0; i < equipment.Length && i < slotToCell.Length; i++)
            {
                var item = equipment[i];
                int cellIndex = slotToCell[i];

                // 跳过武器和衣服（它们显示在角色模型上，不是独立槽位）
                if (cellIndex < 0)
                    continue;

                // 查找装备格子（在 DA2EPage1 中，不在 Equip 子组件中）
                GComponent slot = page1.GetChild($"EquipCell{cellIndex}") as GComponent;

                if (slot == null)
                {
                    if (item != null)
                        Debug.LogWarning($"[FguiGameUI] EquipCell{cellIndex} not found for slot {i} (has item: {item.Info?.Name})");
                    continue;
                }

                // 获取格子中的图标加载器
                GLoader icon = slot.GetChild("item") as GLoader;
                if (icon == null)
                    icon = slot.GetChild("icon") as GLoader;

                if (icon == null)
                {
                    // 打印 slot 的所有子节点用于调试
                    Debug.LogWarning($"[FguiGameUI] No icon loader found in EquipCell{cellIndex}, listing children:");
                    for (int j = 0; j < slot.numChildren; j++)
                    {
                        var child = slot.GetChildAt(j);
                        Debug.Log($"[FguiGameUI] EquipCell{cellIndex} child[{j}]: {child?.name} ({child?.GetType().Name})");
                    }
                    continue;
                }

                if (item != null && item.Info != null)
                {
                    // 从 Libraries.StateItems 获取装备外观图标（不是 Libraries.Items 的背包小图标）
                    var texture = MirGraphics.Libraries.StateItems.GetTexture(item.Info.Image);
                    if (texture != null)
                    {
                        // 直接设置 url 为空，然后设置纹理
                        icon.url = null;
                        
                        // 使用 NTexture 包装 Texture2D 并设置到 GLoader
                        NTexture nTex = new NTexture(texture);
                        
                        // 保存原始大小
                        float origWidth = icon.width;
                        float origHeight = icon.height;
                        
                        icon.texture = nTex;
                        
                        // 恢复原始大小（防止被纹理大小覆盖）
                        icon.SetSize(origWidth, origHeight);
                        
                        // 设置填充模式为 Scale（等比缩放）并居中
                        icon.fill = FillType.Scale;
                        icon.align = AlignType.Center;
                        icon.verticalAlign = VertAlignType.Middle;
                        
                        // 确保图标可见
                        icon.visible = true;
                        
                        Debug.Log($"[FguiGameUI] Set EquipCell{cellIndex} StateItem texture for: {item.Info.Name}, Image={item.Info.Image}, texSize={texture.width}x{texture.height}");
                    }
                    else
                    {
                        icon.texture = null;
                        icon.visible = false;
                        Debug.LogWarning($"[FguiGameUI] Failed to get StateItem texture for: {item.Info.Name}, Image={item.Info.Image}");
                    }
                }
                else
                {
                    icon.texture = null;
                    icon.visible = false;
                }

                // 绑定点击事件（卸下装备）
                BindEquipSlotClick(slot, i);
            }

            Debug.Log("[FguiGameUI] Refreshed equipment display");
        }

        /// <summary>
        /// 设置装备格子的纹理
        /// </summary>
        private void SetEquipCellTexture(GComponent parent, string cellName, UserItem item, int slotIndex)
        {
            if (parent == null || item == null || item.Info == null)
                return;

            GComponent slot = parent.GetChild(cellName) as GComponent;
            if (slot == null)
            {
                Debug.LogWarning($"[FguiGameUI] {cellName} not found in {parent.name}");
                return;
            }

            GLoader icon = slot.GetChild("item") as GLoader;
            if (icon == null)
                icon = slot.GetChild("icon") as GLoader;

            if (icon == null)
            {
                Debug.LogWarning($"[FguiGameUI] No icon loader found in {cellName}");
                return;
            }

            var texture = MirGraphics.Libraries.StateItems.GetTexture(item.Info.Image);
            if (texture != null)
            {
                icon.url = null;
                NTexture nTex = new NTexture(texture);
                float origWidth = icon.width;
                float origHeight = icon.height;
                icon.texture = nTex;
                icon.SetSize(origWidth, origHeight);
                icon.fill = FillType.Scale;
                icon.align = AlignType.Center;
                icon.verticalAlign = VertAlignType.Middle;
                icon.visible = true;
                Debug.Log($"[FguiGameUI] Set {cellName} texture for: {item.Info.Name}");
            }

            // 绑定点击事件
            BindEquipSlotClick(slot, slotIndex);
        }

        // 存储动态创建的装备叠加 loader
        private Dictionary<string, GLoader> _equipOverlayLoaders = new Dictionary<string, GLoader>();

        /// <summary>
        /// 在角色模型上绘制装备叠加图标
        /// </summary>
        private void DrawEquipmentOverlay(GComponent page, GLoader roleLoader, int imageIndex, string equipType, int slotIndex)
        {
            if (page == null || roleLoader == null)
                return;

            var texture = Libraries.StateItems.GetTexture(imageIndex);
            if (texture == null)
            {
                Debug.LogWarning($"[FguiGameUI] Failed to get StateItems texture for imageIndex: {imageIndex}");
                return;
            }

            string loaderName = $"_overlay_{equipType}";
            GLoader loader;

            // role loader 位置: xy="60,181" size="235,294"
            // 计算装备图标的位置和大小
            float roleW = roleLoader.width;
            float roleH = roleLoader.height;
            float roleX = roleLoader.x;
            float roleY = roleLoader.y;
            
            float scale, posX, posY, texWidth, texHeight;
            
            if (equipType == "armor")
            {
                // 衣服：缩小到角色高度的 50%，居中显示，往下一点点
                float targetHeight = roleH * 0.55f;
                scale = targetHeight / texture.height;
                texWidth = texture.width * scale;
                texHeight = texture.height * scale;
                posX = roleX + (roleW - texWidth) / 2;
                posY = roleY + (roleH - texHeight) / 2 + roleH * 0.05f;
            }
            else if (equipType == "weapon")
            {
                // 武器：缩小到角色高度的 45%，放在角色手上位置
                float targetHeight = roleH * 0.45f;
                scale = targetHeight / texture.height;
                texWidth = texture.width * scale;
                texHeight = texture.height * scale;
                // 武器位置：往左一点点
                posX = roleX + roleW * 0.05f;
                posY = roleY + roleH * 0.05f;
            }
            else
            {
                // 其他装备：默认居中
                float targetHeight = roleH * 0.7f;
                scale = targetHeight / texture.height;
                texWidth = texture.width * scale;
                texHeight = texture.height * scale;
                posX = roleX + (roleW - texWidth) / 2;
                posY = roleY + (roleH - texHeight) / 2;
            }

            if (_equipOverlayLoaders.TryGetValue(loaderName, out loader))
            {
                // 更新现有 loader
                NTexture nTex = new NTexture(texture);
                loader.texture = nTex;
                loader.SetXY(posX, posY);
                loader.SetSize(texWidth, texHeight);
                loader.visible = true;
            }
            else
            {
                // 创建新的 loader
                loader = new GLoader();
                loader.name = loaderName;
                loader.SetXY(posX, posY);
                loader.SetSize(texWidth, texHeight);
                
                NTexture nTex = new NTexture(texture);
                loader.texture = nTex;
                loader.fill = FillType.ScaleFree;
                loader.touchable = false;
                loader.visible = true;

                page.AddChild(loader);
                _equipOverlayLoaders[loaderName] = loader;
                
                Debug.Log($"[FguiGameUI] Created overlay loader: {loaderName}, pos=({posX},{posY}), size=({texWidth},{texHeight}), scale={scale}");
            }
        }

        /// <summary>
        /// 隐藏装备叠加图标
        /// </summary>
        private void HideEquipmentOverlay(string equipType)
        {
            string loaderName = $"_overlay_{equipType}";
            if (_equipOverlayLoaders.TryGetValue(loaderName, out GLoader loader))
            {
                loader.visible = false;
            }
        }

        /// <summary>
        /// 查找装备格子组件
        /// </summary>
        private GComponent FindEquipCell(GComponent parent, int cellIndex)
        {
            if (parent == null) return null;

            string cellName = $"EquipCell{cellIndex}";

            // 先在当前组件中查找
            GComponent cell = parent.GetChild(cellName) as GComponent;
            if (cell != null) return cell;

            // 在 Equip 子组件中查找
            GComponent equip = parent.GetChild("Equip") as GComponent;
            if (equip != null)
            {
                cell = equip.GetChild(cellName) as GComponent;
                if (cell != null) return cell;
            }

            // 递归查找
            return FindChildComponent(parent, cellName);
        }

        /// <summary>
        /// 递归查找子组件
        /// </summary>
        private GComponent FindChildComponent(GComponent parent, string name)
        {
            if (parent == null) return null;

            for (int i = 0; i < parent.numChildren; i++)
            {
                GObject child = parent.GetChildAt(i);
                if (child == null) continue;

                if (child.name == name && child is GComponent comp)
                    return comp;

                if (child is GComponent childComp)
                {
                    GComponent found = FindChildComponent(childComp, name);
                    if (found != null) return found;
                }
            }
            return null;
        }

        /// <summary>
        /// 绑定装备槽点击事件（卸下装备到背包）
        /// </summary>
        private void BindEquipSlotClick(GComponent slot, int equipmentSlot)
        {
            if (slot == null) return;

            slot.onClick.Clear();
            slot.onClick.Add((EventContext ctx) =>
            {
                // 检查该槽位是否有装备
                if (MapObject.User == null || MapObject.User.Equipment == null)
                    return;

                var item = MapObject.User.Equipment[equipmentSlot];
                if (item == null)
                {
                    Debug.Log($"[FguiGameUI] Equipment slot {equipmentSlot} is empty");
                    return;
                }

                // 发送卸下装备请求到服务器
                // 老代码: Network.Enqueue(new C.RemoveItem { Grid = MirGridType.Inventory, UniqueID = Item.UniqueID, To = itemCell.ItemSlot });
                // Grid 是目标位置（背包），不是源位置（装备）
                MirNetwork.Network.Enqueue(new C.RemoveItem { Grid = MirGridType.Inventory, UniqueID = item.UniqueID, To = GetFirstEmptyInventorySlot() });
                Debug.Log($"[FguiGameUI] Request to unequip item: {item.Info?.Name} from slot {equipmentSlot}");
            });
        }

        /// <summary>
        /// 获取背包中第一个空槽位
        /// </summary>
        private int GetFirstEmptyInventorySlot()
        {
            if (GameScene.User == null || GameScene.User.Inventory == null)
                return 0;

            for (int i = 0; i < GameScene.User.Inventory.Length; i++)
            {
                if (GameScene.User.Inventory[i] == null)
                    return i;
            }
            return 0;
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

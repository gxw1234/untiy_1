using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public enum MirControlEnum
{
    MirAudioSource,
    MirControl,
    MirLabel,
    MirImageControl,
    MirButton,
    MirAnimatedControl,
    MirMessageBox,
    MirAmountBox,
    MirInputBox,
    MirItemCell,
    MirTextBox
}
public class MirObjectPool : MonoBehaviour
{
    private static MirObjectPool _MirObjectPool;
    private static Dictionary<MirControlEnum, ObjectPool<GameObject>> objectPoolDictionary;

    private void Awake()
    {
        if (_MirObjectPool == null)
        {
            _MirObjectPool = this;
            objectPoolDictionary = new Dictionary<MirControlEnum, ObjectPool<GameObject>>();
        }
    }

    public static MirObjectPool Instance()
    {
        return _MirObjectPool;
    }

    public void CreateObjectPool(MirControlEnum mirControlEnum, int initialPoolSize = 1)
    {
        if (!objectPoolDictionary.ContainsKey(mirControlEnum))
        {
            List<GameObject> objectList = new List<GameObject>();
            Func<GameObject> instantiateFunc = () => InstantiatePrefab(mirControlEnum); // 放在这里

            for (int i = 0; i < initialPoolSize; i++)
            {
                GameObject obj = instantiateFunc.Invoke(); // 调用委托来实例化
                obj.SetActive(false);
                objectList.Add(obj);
            }

            ObjectPool<GameObject> objectPool = new ObjectPool<GameObject>(instantiateFunc);
            objectPoolDictionary.Add(mirControlEnum, objectPool);
        }
    }



    public GameObject GetObjectFromPool(MirControlEnum mirControlEnum)
    {
        if (objectPoolDictionary.ContainsKey(mirControlEnum))
        {
            ObjectPool<GameObject> objectPool = objectPoolDictionary[mirControlEnum];
            GameObject obj = objectPool.Get();

            if (obj == null)
            {
                // 如果对象池中没有可用的对象，动态创建一个新对象
                obj = Instantiate(InstantiatePrefab(mirControlEnum));
                obj.SetActive(false);
                objectPool.Release(obj);
            }

            obj.SetActive(true);
            return obj;
        }
        else
        {
            Debug.LogWarning("No object pool found for type " + mirControlEnum);
            return null;
        }
    }


    public void ReturnObjectToPool(MirControlEnum mirControlEnum, GameObject obj)
    {
        if (obj == null) return;

        if (objectPoolDictionary.ContainsKey(mirControlEnum))
        {
            if (mirControlEnum != MirControlEnum.MirAudioSource)
            {
                if (obj.transform != null)
                {
                    obj.transform.SetParent(null);
                    obj.SetActive(false);
                }
                switch (mirControlEnum)
                {
                    case MirControlEnum.MirLabel:
                        if (obj.transform != null)
                        {
                            Text label = obj.GetComponent<Text>();
                            //Debug.Log("清除内容" + label.text);
                            label.text = "";
                        }
                        obj.name = "MirLabel";
                        break;
                    case MirControlEnum.MirImageControl:
                    case MirControlEnum.MirButton:
                    case MirControlEnum.MirAnimatedControl:
                    case MirControlEnum.MirMessageBox:
                    case MirControlEnum.MirAmountBox:
                    case MirControlEnum.MirInputBox:
                    case MirControlEnum.MirItemCell:
                    case MirControlEnum.MirTextBox:
                        if (obj.transform != null)
                        {
                            Image image = obj.GetComponent<Image>();
                            image.sprite = null;
                        }
                        break;
                }
                obj.name = mirControlEnum.ToString();
                ResetRectTransform(obj);
            }

            objectPoolDictionary[mirControlEnum]?.Release(obj); //小退会触发二次回收 待处理
        }
        else
        {
            Debug.LogWarning("Object pool for MirControlEnum " + mirControlEnum + " does not exist.");
        }
    }

    public void ResetRectTransform(GameObject obj)
    {
        // 手动设置默认值
        RectTransform rectTransform = obj.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(0, 0);
        rectTransform.sizeDelta = new Vector2(0, 0);
        rectTransform.localScale = new Vector3(1, 1, 1);
    }
    private GameObject InstantiatePrefab(MirControlEnum mirControlEnum)
    {
        string prefabName = mirControlEnum.ToString();

        // 从 "Resources" 文件夹中加载预制体
        GameObject prefab = Resources.Load<GameObject>(prefabName);

        if (prefab == null)
        {
            Debug.LogError("Prefab not found with name: " + prefabName);
            return null;
        }

        // 在这里根据需要实例化你的预制体
        GameObject prefabInstance = Instantiate(prefab);
        return prefabInstance;
    }
}

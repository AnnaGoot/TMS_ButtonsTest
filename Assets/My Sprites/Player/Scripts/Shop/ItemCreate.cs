using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCreate : MonoBehaviour
{
    [SerializeField] private ShopItem itemPrefab;
    private ShopItem currentItem;

    public string[] randomNames;
    public int[] randomPrice;

    [SerializeField] private List<ShopItem> allItemsCreated;

    private bool savedItems = false;

    private void OnEnable()
    {
        savedItems = PlayerPrefs.GetInt("Items") == 1;

        if (allItemsCreated.Count <= 0)
        {
            if (savedItems)
            {
                for (int i = 0; i < 200; i++)
                {
                    GetSavedItems(i);
                }
            }
            else
            {
                for (int i = 0; i < 200; i++)
                {
                    CreateItem(i);
                }
            }
        }
        else
        {
            foreach (var item in allItemsCreated)
            {
                Debug.Log(item._name);
            }
        }

    }

    public void CreateItem(int index)
    {
        currentItem = Instantiate(itemPrefab, transform.position, Quaternion.identity, transform);

        currentItem.SetupItem(randomNames[Random.Range(0, randomNames.Length)], randomPrice[Random.Range(0, randomPrice.Length)]);
        currentItem.index = index;

        allItemsCreated.Add(currentItem);

    }

    private void GetSavedItems(int i)
    {
        currentItem = Instantiate(itemPrefab, transform.position, Quaternion.identity, transform);

        currentItem.SetupItem(PlayerPrefs.GetString(i.ToString() + "name"), PlayerPrefs.GetInt(i.ToString() + "price"));
        currentItem.index = i;

        allItemsCreated.Add(currentItem);

    }


    void OnDestroy()
    {
        PlayerPrefs.SetInt("Items", 1);

        foreach (var item in allItemsCreated)
        {
            PlayerPrefs.SetString(item.index.ToString() + "name", item._name);
            PlayerPrefs.SetInt(item.index.ToString() + "price", item._price);
        }
    }

}

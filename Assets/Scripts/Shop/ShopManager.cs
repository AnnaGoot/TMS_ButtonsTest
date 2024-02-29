using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using static UnityEditor.Progress;

public class ShopManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI inventoryText;
    public Button buyButton;

    [SerializeField]

    private string[] _name = new string[3] { "CoverCloth", "Potion", "Ring" };

    private string[] _subName = new string[5] { "Old", "Ancient", "Suspicious", "Cursed", "Glowing" };


    Dictionary<string, ShopItem> items = new Dictionary<string, ShopItem>();

    Dictionary<string, int> inventory = new Dictionary<string, int>();
    int money = 500; // Начальное количество денег

    void Start()
    {
        items.Add("CoverCloth", new ShopItem("CoverCloth", 50)); // Добавляем предметы без начальных цен
        items.Add("Potion", new ShopItem("Potion", 30));
        items.Add("Ring", new ShopItem("Ring", 20));

        GenerateRandomItems(5);



        //buyButton.onClick.AddListener(BuyItem);



        UpdateMoneyText();
        UpdateInventoryText();
    }


    void GenerateRandomItems(int count)
    {

        string[] possibleNames = { "Cloth", "Potion", "Ring" };



        for (int i = 0; i < count; i++)
        {
            string randomName = possibleNames[Random.Range(0, possibleNames.Length)];
            int randomPrice = Random.Range(50, 200); // Цены був диапазоне от 50 до 200

            items[randomName].price = randomPrice;

            Debug.Log("Item: " + randomName + ", Price: " + randomPrice);
        }
    }



    void BuyItem()
    {
        string itemName = inventoryText.text;
        if (items.ContainsKey(itemName))
        {
            ShopItem item = items[itemName];
            if (money >= item.price)
            {
                money -= item.price;
                UpdateMoneyText();
                if (inventory.ContainsKey(itemName))
                    inventory[itemName]++;
                else
                    inventory[itemName] = 1;
                UpdateInventoryText();
            }
            else
            {
                Debug.Log("Not enough money to buy " + itemName);
            }
        }
        else
        {
            Debug.Log("Item not found in shop: " + itemName);
        }
    }

    void UpdateMoneyText()
    {
        moneyText.text = "Money: " + money.ToString();
    }

    void UpdateInventoryText()
    {
        inventoryText.text = "Sword"; // Имя предмета по умолчанию
    }





    [ContextMenu("Default")]
    public void SaveAsDefault()
    {
        string defaultJson = JsonUtility.ToJson(items);
        Debug.Log(defaultJson);

    }

    [ContextMenu("Newtonsoft")]
    public void SaveAsNewtonsoft()
    {
        string newtonsoft = JsonConvert.SerializeObject(items);
        Debug.Log(newtonsoft);
    }

}

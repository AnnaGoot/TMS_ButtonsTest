using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopItem: MonoBehaviour
{
    [SerializeField] public Image itemImage;

    [SerializeField] public string name;
    [SerializeField] public int price;


        public ShopItem(string name, int price)
        {
            this.name = name;
            this.price = price;

        }
}

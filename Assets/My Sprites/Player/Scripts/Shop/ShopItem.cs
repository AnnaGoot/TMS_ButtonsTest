using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopItem: MonoBehaviour
{
    [SerializeField] public Image itemImage;

    [SerializeField] private TextMeshProUGUI priceText, nameText;

    public string _name;
    public int _price;
    public int index;

    public void SetupItem(string name, int price)
    {
        _name = name;
        _price = price;

        priceText.text = price.ToString();
        nameText.text = name;

    }

}

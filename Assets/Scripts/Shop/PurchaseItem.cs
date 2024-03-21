using UnityEngine;
using UnityEngine.UI;

public class PurchaseItem : MonoBehaviour
{
    public int itemPrice;
    public CoinsAvaliable coinsManager;
    public ShopItem shopItem;

    private UnityEngine.UI.Button itemButton;


    void Start()
    {
        itemButton = GetComponent<UnityEngine.UI.Button>();
        itemButton.onClick.AddListener(() => BuyItem());
    }

    public void BuyItem()
    {
        if (shopItem != null)
        {
            bool isPurchased = coinsManager.BuyItem(shopItem._price);

            if (isPurchased)
            {
                itemButton.GetComponent<Image>().color = Color.green;
                Debug.Log("Item bought!");

                coinsManager.SetScore();
            }
            else
            {
                Debug.Log("Not enough money!");
            }
        }
        else
        {
            Debug.LogError("No ShopItem component attached");
        }
    }

}

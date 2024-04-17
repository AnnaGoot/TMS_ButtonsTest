using UnityEngine;
using TMPro;

public class CoinsAvaliable : MonoBehaviour
{
    [SerializeField] private int coins = 100;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        SetScore();
    }

    public void SetScore()
    {
        text.text = $"{coins}";
    }

    public bool BuyItem(int _price)
    {
        if (coins >= _price)
        {
            coins -= _price;
            SetScore();
            return true;
        }
        else
        {
            return false;
        
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

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

    public void BuyItem(int price)
    {
        if (coins > price)
            coins -= price;
    }

}

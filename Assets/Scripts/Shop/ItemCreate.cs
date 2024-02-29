using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCreate : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private GameObject currentItem;


    private void Start()
    {
        for (int i = 0; i < 200; i++)
        {
            CreateItem();
        }
    }

    public void CreateItem()
    {
        currentItem = Instantiate(prefab, transform.position, Quaternion.identity);

        currentItem.transform.SetParent(transform, true);
    }
}

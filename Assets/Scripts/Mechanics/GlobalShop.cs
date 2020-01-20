using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject shopText;
    public GameObject shopStats;
    public static int numberOfShops = 0;
    public static float shopValue = 10;


    // Update is called once per frame
    void Update()
    {
        shopStats.GetComponent<Text>().text = "Shop: " + numberOfShops + " @ " + numberOfShops + " cps";
        shopText.GetComponent<Text>().text = "Buy Shop - $" + Mathf.FloorToInt(shopValue);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyShop : MonoBehaviour
{
    public GameObject shopButton;
    public GameObject AutoSellController;
    public AudioSource buyShopSound;
    public AudioSource noCookie;
    public int currentCash;

    void PurchaseLog()
    {
        {
            GlobalCash.CashCount -= Mathf.FloorToInt(GlobalShop.shopValue);
            AutoSell.CashIncrease += 1;
            AutoSellController.SetActive(true);
            GlobalShop.numberOfShops += 1;
            GlobalShop.shopValue *= 1.1f;
        }
    }

    public void ClickTheButton()
    {
        currentCash = GlobalCash.CashCount;
        if (currentCash >= Mathf.Floor(GlobalShop.shopValue))
        {
            if (BGMControll.soundEffect.activeSelf)
            {
                buyShopSound.Play();
            }
            PurchaseLog();
        }
        else
        {
            if (BGMControll.soundEffect.activeSelf)
            {
                noCookie.Play();
            }
        }
    }
}

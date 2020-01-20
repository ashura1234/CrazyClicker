using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyOprah : MonoBehaviour
{
    public GameObject bakerButton;
    public GameObject AutoCookieController;
    public AudioSource buyBakerSound;
    public AudioSource noMoney;
    public int currentCash;

    void PurchaseLog()
    {
        {
            GlobalCash.CashCount -= Mathf.FloorToInt(GlobalBaker.bakerValue);
            AutoCookie.CookieIncrease += 1;
            AutoCookieController.SetActive(true);
            GlobalBaker.numberOfBakers += 1;
            GlobalBaker.bakerValue *= 1.15f;
        }
    }

    public void ClickTheButton()
    {
        currentCash = GlobalCash.CashCount;
        if (currentCash >= Mathf.Floor(GlobalBaker.bakerValue))
        {
            if (BGMControll.soundEffect.activeSelf)
            {
                buyBakerSound.Play();
            }
            PurchaseLog();
        }
        else
        {
            if (BGMControll.soundEffect.activeSelf)
            {
                noMoney.Play();
            }
        }
    }
}

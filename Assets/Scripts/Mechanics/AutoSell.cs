using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int CashIncrease = 0;
    public int InternalIncrease = 0;

    // Update is called once per frame
    void Update()
    {
        InternalIncrease = CashIncrease;
        if (!SellingCookie)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }
    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount >= InternalIncrease)
        {
            GlobalCookies.CookieCount -= InternalIncrease;
            GlobalCash.CashCount += InternalIncrease;
        }

        yield return new WaitForSeconds(1);
        SellingCookie = false; 
    }
}   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    int savedCookies;
    int savedCash;
    int savedNumberOfBakers;
    int savedNumberOfShops;
    int savedCookieIncrease;
    int savedCashIncrease;
    float savedBakerValue;
    float savedShopValue;
    bool savedCreatingCookie;
    bool savedSellingCookie;

    // Start is called before the first frame update
    void Start()
    {
        
        if (MainMenuOptions.isLoading)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedNumberOfBakers = PlayerPrefs.GetInt("SavedNumberOfBakers");
            GlobalBaker.numberOfBakers = savedNumberOfBakers;
            savedNumberOfShops = PlayerPrefs.GetInt("SavedNumberOfShops");
            GlobalShop.numberOfShops = savedNumberOfShops;
            savedCookieIncrease = PlayerPrefs.GetInt("SavedCookieIncrease");
            AutoCookie.CookieIncrease = savedCookieIncrease;
            savedCashIncrease = PlayerPrefs.GetInt("SavedCashIncrease");
            AutoSell.CashIncrease = savedCashIncrease;
            savedBakerValue = PlayerPrefs.GetFloat("SavedBakerValue");
            GlobalBaker.bakerValue = savedBakerValue;
            savedShopValue = PlayerPrefs.GetFloat("SavedShopValue");
            GlobalShop.shopValue = savedShopValue;
            savedCreatingCookie = PlayerPrefs.GetInt("SavedCreatingCookie") == 1;
            AutoCookie.CreatingCookie = savedCreatingCookie;
            savedSellingCookie = PlayerPrefs.GetInt("SavedSellingCookie") == 1;
            AutoSell.SellingCookie = savedSellingCookie;
        }
    }
}

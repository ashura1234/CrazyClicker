using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    public GameObject statusText;

    public void ClickTheButton()
    {
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("SavedNumberOfBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("SavedNumberOfShops", GlobalShop.numberOfShops);
        PlayerPrefs.SetInt("SavedCookieIncrease", AutoCookie.CookieIncrease);
        PlayerPrefs.SetInt("SavedCashIncrease", AutoSell.CashIncrease);

        PlayerPrefs.SetFloat("SavedBakerValue", GlobalBaker.bakerValue);
        PlayerPrefs.SetFloat("SavedShopValue", GlobalShop.shopValue);

        PlayerPrefs.SetInt("SavedCreatingCookie", AutoCookie.CreatingCookie ? 1 : 0);
        PlayerPrefs.SetInt("SavedSellingCookie", AutoSell.SellingCookie ? 1 : 0);

        statusText.GetComponent<Text>().text = "Game Saved!!!";
        statusText.GetComponent<Animation>().Play("StatusAnim");
    }
}

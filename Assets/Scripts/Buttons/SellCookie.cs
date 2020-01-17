using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
    
    public GameObject statusBox;
    public GameObject sellAllCookiesToggle;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public AudioSource noCookie;
    int generateTone;
    int sellNumber = 1;

    void PlaySound()
    {
        if (BGMControll.soundEffect.activeSelf)
        {
            generateTone =
                Random.Range(0, 2);
            switch (generateTone)
            {
                case 0:
                    cashOne.Play();
                    break;
                case 1:
                    cashTwo.Play();
                    break;
                default:
                    cashOne.Play();
                    break;
            }
        }
    }

    void CheckToggle()
    {
        if (sellAllCookiesToggle.GetComponent<Toggle>().isOn)
        {
            sellNumber = GlobalCookies.CookieCount;
        }
        else
        {
            sellNumber = 1;
        }
    }

    public void ClickTheButton()
    {
        if (GlobalCookies.CookieCount > 0)
        {
            PlaySound();
            CheckToggle();
            GlobalCookies.CookieCount -= sellNumber;
            GlobalCash.CashCount += sellNumber;
        }
        else
        {
            noCookie.Play();
            statusBox.GetComponent<Text>().text = "Not Enough Cookies to Sell!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }

}
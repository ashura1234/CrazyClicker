using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour
{
    public static bool CreatingCookie = false;
    public static int CookieIncrease = 0;
    public int InternalIncrease = 0;

    // Update is called once per frame
    void Update()
    {
        InternalIncrease = CookieIncrease;
        if (!CreatingCookie)
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }
    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }

}   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;

    // Update is called once per frame
    void Update()
    {
        cookieCheck = GlobalCookies.CookieCount / 10;
        if (!disasterActive)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20);
        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.FloorToInt(GlobalCookies.CookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookies in a factory fire.";
            GlobalCookies.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(3.0f);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1.0f);
            statusBox.SetActive(false);
            statusBox.SetActive(true); 
        }
        yield return new WaitForSeconds(10.0f);
        disasterActive = false;
    }
}

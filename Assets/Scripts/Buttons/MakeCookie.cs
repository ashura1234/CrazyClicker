using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCookie : MonoBehaviour
{

    public GameObject makeButton;
    public AudioSource makeSound;

    public void ClickTheButton()
    {
        if (makeSound.isActiveAndEnabled)
        {
            makeSound.Play();
        }
        GlobalCookies.CookieCount += 1;
    }

}
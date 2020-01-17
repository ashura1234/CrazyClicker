using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject bakerText;
    public GameObject bakerStats;
    public static int numberOfBakers = 0;
    public static float bakerValue = 10;

    // Update is called once per frame
    void Update()
    {
        bakerStats.GetComponent<Text>().text = "Oprah: " + numberOfBakers + " @ " + numberOfBakers + " cps";
        bakerText.GetComponent<Text>().text = "Buy Oprah - $" + Mathf.FloorToInt(bakerValue);
    }
}

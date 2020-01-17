using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMControll : MonoBehaviour
{
    public AudioSource BGM;
    public GameObject internalSoundEffect;
    public static GameObject soundEffect;
    public GameObject BGMOnButton;
    public GameObject BGMOffButton;
    public GameObject soundEffectOnButton;
    public GameObject soundEffectOffButton;

    void Start()
    {
        soundEffect = internalSoundEffect;
    }

    public void BGMOn()
    {
        BGM.volume = 0.05f;
        BGMOffButton.SetActive(false);
        BGMOnButton.SetActive(true);
    }

    public void BGMOff()
    {
        BGM.volume = 0.0f;
        BGMOffButton.SetActive(true);
        BGMOnButton.SetActive(false);
    }
    
    public void SoundEffectOn()
    {
        soundEffect.SetActive(true);
        soundEffectOffButton.SetActive(false);
        soundEffectOnButton.SetActive(true);
    }

    public void SoundEffectOff()
    {
        soundEffect.SetActive(false);
        soundEffectOffButton.SetActive(true);
        soundEffectOnButton.SetActive(false);
    }
}

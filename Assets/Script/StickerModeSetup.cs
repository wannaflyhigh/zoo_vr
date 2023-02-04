using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickerModeSetup : MonoBehaviour
{
    public int initValue;

    public Slider slider;

    int currentValue;

    string key = "stickerMode";

    // Start is called before the first frame update
    void Start()
    {
        slider.value = (float) initValue;
        currentValue = initValue;
        PlayerPrefs.SetInt (key, initValue);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentValue != (int) slider.value)
        {
            currentValue = (int) slider.value;
            PlayerPrefs.SetInt (key, currentValue);
        }
    }

    public void clearGotStickers()
    {
        for (int i = 1; i <= 33; i++)
        {
            PlayerPrefs.SetInt(key + i, 0);
        }
    }
}

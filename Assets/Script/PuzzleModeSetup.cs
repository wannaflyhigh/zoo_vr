using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleModeSetup : MonoBehaviour
{
    public int initValue;

    public Slider slider;

    int currentValue;

    string key = "puzzleMode";

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
}

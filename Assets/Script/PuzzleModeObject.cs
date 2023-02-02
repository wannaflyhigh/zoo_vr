using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleModeObject : MonoBehaviour
{
    string key = "puzzleMode";

    // Start is called before the first frame update
    void Start()
    {
        int PuzzleModeValue = PlayerPrefs.GetInt(key);
        if (PuzzleModeValue == 1)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

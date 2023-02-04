using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerModeStickers : MonoBehaviour
{
    string key = "stickerMode";

    public string id;

    // Start is called before the first frame update
    void Start()
    {
        int value = PlayerPrefs.GetInt(key + id);
        if (value == 1)
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

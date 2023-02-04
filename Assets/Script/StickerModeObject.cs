using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerModeObject : MonoBehaviour
{
    string key = "stickerMode";

    public string id;

    // Start is called before the first frame update
    void Start()
    {
        StickerModeShowOrNot();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void StickerModeShowOrNot()
    {
        int StickerModeValue = PlayerPrefs.GetInt(key);
        if (StickerModeValue == 1)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    public void getSticker()
    {
        PlayerPrefs.SetInt(key + id, 1);
    }
}

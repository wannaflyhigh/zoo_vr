using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerModeObject : MonoBehaviour
{
    string key = "stickerMode";

    public string id;

    public GameObject notifyOnGet;

    int countDown = 60;

    // Start is called before the first frame update
    void Start()
    {
        StickerModeShowOrNot();
    }

    // Update is called once per frame
    void Update()
    {
        countDown--;
        if (notifyOnGet == null) return;
        if (countDown <= 0) notifyOnGet.SetActive(false);
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
        if (PlayerPrefs.GetInt(key + id) == 1) return;

        PlayerPrefs.SetInt(key + id, 1);
        countDown = 1000;
        notifyOnGet.SetActive(true);
    }
}

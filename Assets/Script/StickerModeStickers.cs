using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerModeStickers : MonoBehaviour
{
    string key = "stickerMode";

    void Awake()
    {
        for (int i = 1; i <= 33; i++)
        {
            if (PlayerPrefs.GetInt(key + i) == 1)
            {
                try
                {
                    transform
                        .Find("Image_Sticker" + i)
                        .gameObject
                        .SetActive(true);
                }
                catch (System.Exception)
                {
                    // throw;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
}

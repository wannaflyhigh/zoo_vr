using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Avatar : MonoBehaviour
{
    string key = "avatar";

    public Sprite[] AvatarSprites;

    public Image AvatarImage;

    // Start is called before the first frame update
    void Start()
    {
        int value = PlayerPrefs.GetInt(key);
        if (value == 0) return;
        AvatarImage.sprite = AvatarSprites[value - 1];
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void chooseAvatar(int id)
    {
        PlayerPrefs.SetInt(key, id + 1);
        AvatarImage.sprite = AvatarSprites[id];
    }
}

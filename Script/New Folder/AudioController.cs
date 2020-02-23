using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public GameObject SoundButton;

    public Sprite[] SoundButtonSprites;

    public string SoundKey = "_sound";
    public static AudioController instance;
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Debug.Log("Sound key: " + PlayerPrefs.GetInt(SoundKey));
    }

    public void OnclickSoundButton()
    {
        if (PlayerPrefs.GetInt(SoundKey) == 0)
        {
            PlayerPrefs.SetInt(SoundKey, 1);
        }
        else
        {
            PlayerPrefs.SetInt(SoundKey, 0);

        }
        Debug.Log("" + PlayerPrefs.GetInt(SoundKey));
        AudioManager.instance.SoundMuteControl(PlayerPrefs.GetInt(SoundKey));
        SoundButton.GetComponent<Image>().sprite = SoundButtonSprites[PlayerPrefs.GetInt(SoundKey)];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public bool audioMuted;
    public static AudioManager instance;
    public void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlayAudio(int id)
    {
        if (!audioMuted)
        {
            AudioSource _sc = GetComponent<AudioSource>();
            if (_sc.enabled)
            {
                _sc.PlayOneShot(audioClips[id]);
            }
            else
            {
                GameObject SoundManager = GameObject.Find("SoundManager");
               // AudioSource _newsc = SoundManager.gameObject.GetComponent<AudioSource>();

            }
            Debug.Log("Working");

        }
    }
    public void SoundMuteControl(int id)
    {
        AudioSource sc = GetComponent<AudioSource>();
        if (id == 0)
        {
            sc.enabled = true; //true
        }
        else if (id == 1)
        {
            sc.enabled = false; //false
        }

    }

}

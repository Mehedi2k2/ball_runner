using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int highPoint1;
    public int score1;
    public static UIManager instance;
    public string firstEntry1;
    public Text HighPoint1;
    void Start()
    {
        instance = this;

        if (PlayerPrefs.HasKey(firstEntry1))
        {
            LoadPlayerData1();

        }
        else
        {
            Debug.Log("2");
            PlayerPrefs.SetInt(firstEntry1, 1);


        }
        GameHighscoreshow();
    }
    public void LoadPlayerData1()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        highPoint1 = data.highScore;

    }
    public void SavePlayerData()
    {
        if (score1 >= highPoint1)
        {
            highPoint1 = score1;

        }
    }

    public void GameHighscoreshow()
    {
        SavePlayerData();
        HighPoint1.text = "" + highPoint1.ToString();
        GameManager.instance.point.text = score1.ToString();
    }
    void Update()
    {
      
       

    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlayAudio(3);
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        AudioManager.instance.PlayAudio(3);
    
    }

    public void home()
    {
        SceneManager.LoadScene(0);
        AudioManager.instance.PlayAudio(3);
       
    }

  
}

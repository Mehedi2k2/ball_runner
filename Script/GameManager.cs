using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public float AfterGameover_timescale = 70;
    public bool timetoGameover = false;
    public int highPoint;
    public Text point;
    public Text YourScore;
    public int score;
    public float scoreCounter = 0;
    public float SpeedCounter = 0;
    public int speed;
    public static GameManager instance;
    public GameObject destroyParticleEffect;
    public Transform particlePostion;
    public Text HighPoint;
    public string firstEntry;
    void Start()
    {
        instance = this;

        if (PlayerPrefs.HasKey(firstEntry))
        {
           LoadPlayerData();
    

        }
        else
        {
            Debug.Log("2");
            PlayerPrefs.SetInt(firstEntry, 1);


        }
    }
    public void LoadPlayerData()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        highPoint = data.highScore;

    }


    public void SavePlayerData()
    {
        if (score >= highPoint)
        {
            highPoint = score;
           
        }

        SaveSystem.SavePlayer(this);
    }
    void Update()
    {
        SavePlayerData();
        HighPoint.text =""+ highPoint.ToString();
        point.text = score.ToString();
        YourScore.text = ""+ score.ToString();
        score = (int)scoreCounter;
        speed = (int)SpeedCounter;

        if (speed >= 100)
        {
            EnemyManager.instance.Zspeed +=100;
            EnviromentPartical.instance.speed += 0.50f;
            BallRotate.instance.RotateSpeed += 5;
            SpeedCounter = 0;
        }

        
        if (score >= 750)
        {
           
            EnemyManager.instance.TimeSpeed = 1;
        }


    }

    public void GameOver()
    {
        EnemyManager.instance.destry = false;
        point.gameObject.SetActive(false);
        timetoGameover = true;
      
        
       
    }

    public void ParticleInstFun(Transform particlePos)
    {
        Instantiate(destroyParticleEffect, particlePos.position, Quaternion.identity);

      
    }

    public void FixedUpdate()
    {
        if(timetoGameover==true)
        {
            AfterGameover_timescale--;
        }
        if (AfterGameover_timescale <= 0)
        {
            gameOverPanel.gameObject.SetActive(true);
            timetoGameover = false;
        }
    }

}

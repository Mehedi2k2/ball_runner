using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public bool swipeMove;
    public static PlayerControl instance;

    public float maxPos;
    void Start()
    {

        instance = this;
    }

    void Update()
    {
        GameManager.instance.scoreCounter += Time.deltaTime * 10;
        GameManager.instance.SpeedCounter += Time.deltaTime * 10;

        if (swipeMove==true)
        {
            transform.Translate(-12.99f, 0, 0);
            
        }
        else { }
        if (transform.position.y< 10)
        {
            gameOver();
        }
        if (transform.position.x == 20 || transform.position.x==-20)
        {
            gameOver();
        }
        

        if (Input.GetKey("a"))
        {
                MoveLeft();

        }

        if (Input.GetKey("d")) 
        {
            MoveRight();
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.position.x < Screen.width/2)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }

       
    }


    public void MovePlayer()
    {
        if (transform.position.x > 0f)
        {
            transform.position = new Vector3(-12f,transform.position.y,transform.position.z);
        }
        else
        {
            transform.position = new Vector3(12f, transform.position.y, transform.position.z);
        }
    }

    public void MoveRight()
    {
        transform.Translate(50 * Time.smoothDeltaTime, 0, 0);

    }

    public void MoveLeft()
    {
        transform.Translate(-50 * Time.smoothDeltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
       if( collision.gameObject.CompareTag("enemy"))
        {
            gameOver();
            Handheld.Vibrate();
            AudioManager.instance.PlayAudio(2);
        }
    }


    public void gameOver()
    {
        GameManager.instance.GameOver();
        AudioManager.instance.PlayAudio(1);
        GameManager.instance.ParticleInstFun(this.transform);
        EnviromentPartical.instance.destroyPratical();  
        Destroy(gameObject);

    }
}

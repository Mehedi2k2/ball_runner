using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject[] EnemyRemdom;
    public float speed = 1f;

    public Transform enemyPosition;
    public float counter;
    public static EnemyManager instance;
    public int TimeSpeed;
    public float Zspeed ;
    public bool destry = true;

    // Start is called before the first frame update
    void Start()
    {

        instance = this;
        GenrateEnemy();

    }

    // Update is called once per frame
    void Update()
    {
        if (counter < 0)
        {
            if (destry == true)
            {
                GenrateEnemy();
            }
          
        }
        else
        {
            counter -= Time.deltaTime;
        }

        GameObject currentChild;
        for (int i = 0; i < transform.childCount; i++)
        {
            currentChild = transform.GetChild(i).gameObject;
            Speedenemy(currentChild);
            if (currentChild.transform.position.z < -100)
            {
                Destroy(currentChild);
            }
        }


    }

    void GenrateEnemy()
    {
        GameObject enemyTask = Instantiate(EnemyRemdom[Random.Range(0, EnemyRemdom.Length)], enemyPosition.transform.position, Quaternion.identity);
        enemyTask.transform.parent = transform;
        counter = TimeSpeed;

    }

    void Speedenemy(GameObject courrentSpeed)
    {
        if (destry == true)
        {
            courrentSpeed.transform.Translate(0, 0, -Zspeed * Time.smoothDeltaTime);
        }
      

    }
}


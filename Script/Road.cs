using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{

    public bool ply=true;
    public Material[] RoadMaterials;
    public int colour=0;
    public static Road instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

      
    }

    // Update is called once per frame
    void Update()
    {
        moveRoad();
        road();


    }
    private void FixedUpdate()
    {
       

        

    }

    void road()
    {
        switch (colour)
        {
            case 0:
                GetComponent<MeshRenderer>().material = RoadMaterials[0];
                //  cam.gameObject.SetActive(true);
                break;
            case 1:
                GetComponent<MeshRenderer>().material = RoadMaterials[1];
                //cam1.gameObject.SetActive(true);
                break;
            case 2:
                GetComponent<MeshRenderer>().material = RoadMaterials[2];
                //cam2.gameObject.SetActive(true);
                break;
            case 3:
                //cam3.gameObject.SetActive(true);
                break;
            case 4:
                //cam4.gameObject.SetActive(true);
                break;
            case 5:
                //cam5.gameObject.SetActive(true);
                break;
            case 6:
                //cam6.gameObject.SetActive(true);
                break;

        }
    }

    void moveRoad ()
    {
        if (ply == true)
        {
            transform.Translate(0, 0, -50 * Time.smoothDeltaTime);
        }

        if (transform.position.z < 584)
        {
            ply = false;
        }
    }
}


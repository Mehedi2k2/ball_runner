using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl  : MonoBehaviour
{
    public static CameraControl instance;
    public int colour = 0;
    public GameObject[] bg;
    void Start()
    {
        instance = this;
       
        colour = Random.Range(0, 3);

    }
    void Update()
    {

    }

    private void FixedUpdate()
    {
        ColourChange();
    }
    void ColourChange ()
    {
        switch (colour)
        {
            case 0:
                bg[0].gameObject.SetActive(true);
                Road.instance.colour = 0;
                break;
            case 1:
                Road.instance.colour = 1;
                bg[1].gameObject.SetActive(true);
                break;
            case 2:
                Road.instance.colour = 2;
                bg[2].gameObject.SetActive(true);
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;

        }

    }
}

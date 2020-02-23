using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl2 : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (null != Player)
        {
            transform.position = Player.transform.position + offset;
        }
    }
}

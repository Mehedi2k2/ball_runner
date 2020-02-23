using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentPartical : MonoBehaviour
{
    public ParticleSystem thisParticle;
    public static EnviromentPartical instance;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        thisParticle = GetComponent<ParticleSystem>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
          var main = thisParticle.main;
         main.simulationSpeed = speed;
    }

    public void destroyPratical ()
    {
        thisParticle.Pause();
        
    }
}

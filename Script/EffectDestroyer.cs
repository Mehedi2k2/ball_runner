using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroyer : MonoBehaviour
{
    public ParticleSystem thisParticle;
    public static EffectDestroyer instance;
    float deathTime;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        thisParticle = GetComponent<ParticleSystem>();
        deathTime = thisParticle.main.duration;
        Destroy(gameObject, deathTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
      //  var main = thisParticle.main;
       // main.simulationSpeed = speed;
    }
}

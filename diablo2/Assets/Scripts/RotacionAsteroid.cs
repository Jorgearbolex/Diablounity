using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionAsteroid : MonoBehaviour
{
    private Rigidbody rig;
    float veloAsteroid = 4;
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
        
    }
    
    void Start()
    {
       rig.angularVelocity = Random.insideUnitSphere * veloAsteroid; //aqui se le aplica las velocidades ramdom con una magnitud de 1, aplicando normalize    
    }

  
}

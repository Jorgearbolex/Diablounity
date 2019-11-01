using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveDisparo : MonoBehaviour
{
    private Rigidbody rig;
    public float speed = 10;
     void Awake()
    {
        rig = GetComponent<Rigidbody> ();
        
    }
    
    void Start()
    {
        rig.velocity = transform.forward * speed;
    }

}

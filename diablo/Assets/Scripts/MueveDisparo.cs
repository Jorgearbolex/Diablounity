using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveDisparo : MonoBehaviour
{
    private Rigidbody rig;
    public float speed = 20;
     void Awake()
    {
        rig = GetComponent<Rigidbody> ();
        
    }
    
    void Start()
    {
        rig.velocity = transform.forward * speed; // ingresamos al componente de velocidad del rigibody y lo igualamos al forward por el speed
    }

}

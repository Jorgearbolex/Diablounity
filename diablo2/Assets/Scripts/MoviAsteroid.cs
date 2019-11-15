using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviAsteroid : MonoBehaviour
{
    private Rigidbody rig;
    
     void Awake()
    {
        rig = GetComponent<Rigidbody> ();
        
    }
    
    void Start()
    {
        rig.velocity = -(transform.forward * 3); // ingresamos al componente de velocidad del rigibody y lo igualamos al forward por el speed
    }
}



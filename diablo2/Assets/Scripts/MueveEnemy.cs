using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveEnemy : MonoBehaviour
{
        private Rigidbody rig;
        public float velocidad = 5;
         public Animator Cabeza;

    
     void Awake()
    {
        rig = GetComponent<Rigidbody> ();
        Cabeza.enabled=false;
        
        
    }
    
    void Start()
    {
        rig.velocity = -(transform.forward * velocidad); // ingresamos al componente de velocidad del rigibody y lo igualamos al forward por el speed
    

    }

    void Update() 
    {
         Cabeza.enabled=true;
         

    }

    
}

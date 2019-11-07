using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorContacto : MonoBehaviour
{
    public GameObject explosion;
    public GameObject exploPlayer;


    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "DestroyAlSalir") return;

        Instantiate (explosion, transform.position, transform.rotation);
        if (other.CompareTag("Player"))
        {
            Instantiate (exploPlayer, other.transform.position, other.transform.rotation);
        }
        Destroy (other.gameObject);
        Destroy (gameObject);
    }
    
    
}

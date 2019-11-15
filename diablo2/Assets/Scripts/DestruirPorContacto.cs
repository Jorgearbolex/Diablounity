using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorContacto : MonoBehaviour
{
    public ParticleSystem explosion;
    public ParticleSystem exploPlayer;


    void OnCollisionEnter(Collision other) 
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "DestroyAlSalir") return;

        if (other.gameObject.tag == "Rayo")
        {
        explosion.Stop();
        explosion.Play();
        }
        

        if (other.gameObject.tag == "Player")
        {
            exploPlayer.Stop();
            exploPlayer.Play();
        }   
    }      
}

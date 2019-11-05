using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [Header("MoviDisparo")]
    public GameObject tiro;
    GameObject copiaTiro;
    public Transform tiroAparece;
    float tiempo= 0.5f;
    float newDispa;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetButton("Fire1")&& Time.time>newDispa)
        {

            copiaTiro =  Instantiate(tiro, tiroAparece.position, tiroAparece.rotation);
            newDispa = Time.time + tiempo;
            Destroy(copiaTiro, 3f);


        }



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject asteroide;
    public Vector3 asteroidAparece;

    public int cuentaAsteroides;

    void Start()
    {
        InstaciarAsteroide ();
    }

    void InstaciarAsteroide ()
    { 
        for (int i = 0; i < cuentaAsteroides; i++)
        {
            Vector3 zonaApareceAsteroid = new Vector3 (Random.Range (-asteroidAparece.x, asteroidAparece.x), asteroidAparece.y, asteroidAparece.z);
            Instantiate(asteroide, zonaApareceAsteroid, Quaternion.identity);
        }
            
    }
}


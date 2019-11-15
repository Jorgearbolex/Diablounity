using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] asteroides;
 
    public Vector3 asteroidAparece;

    public int cuentaAsteroides;
    float tiempoEsperaAsteroid = 2f;
    float tiempoEsperaInicial = 1f;
    float ordaDeAsteroides = 1f;

    void Start()
    {
        StartCoroutine("InstaciarAsteroide");
        
    }

    IEnumerator InstaciarAsteroide ()
    { 
        yield return new WaitForSeconds (tiempoEsperaInicial);
        while (true) 
        {
            for (int i = 0; i < cuentaAsteroides; i++)
          {
            GameObject asteroide = asteroides[Random.Range (0,asteroides.Length)]; // aqui se convierte el array en la variable asteroide que contiene el prefab que se eleige y aleatorio con random
            Vector3 zonaApareceAsteroid = new Vector3 (Random.Range (-asteroidAparece.x, asteroidAparece.x), asteroidAparece.y, asteroidAparece.z);
            Instantiate(asteroide, zonaApareceAsteroid, Quaternion.identity);

            yield return new WaitForSeconds (tiempoEsperaAsteroid);
          }
          yield return new WaitForSeconds (ordaDeAsteroides);
        }
        
            
    }
}


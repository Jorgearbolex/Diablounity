using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
 public class LimitesEncuadre
{
    public float xMin, xMax, zMin, zMax;


}

public class PlayerControl : MonoBehaviour
{
    public LimitesEncuadre limitesEncu;
    private Rigidbody rig;
    Vector3 veloMoviNave;
    float moveHorizontal;
    float moveVertical;
    float speed=12f;


    void Awake()
    {
        rig = GetComponent<Rigidbody> ();
        
    }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        mueveNave();
        
    }

    void mueveNave()   
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        veloMoviNave= new Vector3(moveHorizontal*speed, 0f, moveVertical*speed);
        rig.velocity = veloMoviNave;
        rig.position = new Vector3(Mathf.Clamp(rig.position.x, limitesEncu.xMin,limitesEncu.xMax), 0f, Mathf.Clamp(rig.position.z, limitesEncu.zMin,limitesEncu.zMax));

        //rig.rotation = Quaternion.Euler(0f, 0f, 10);
    }
}


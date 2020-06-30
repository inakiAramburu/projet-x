using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PJ1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public float fuerza = 100f;

    // Update is called once per frame
    void Update()
    {

        mover(fuerza);
        

        
    }

    public void mover(float fuerza)
    {
        //fuerza *= Timeout.deltaTime;

        if (Input.GetKey("d"))//derecha
        {
            gameObject.transform.Traslate(fuerza, 0, 0);
        }
    }

}


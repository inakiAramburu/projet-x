using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PJ1 : MonoBehaviour
{
    public float fuerza = 100f;
    public float salto = 300f;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        mover(fuerza);
        
    }

    public void mover(float f)
    {
        if (Input.GetKey("a"))//Izquierda
        {
            gameObject.transform.Translate(-f * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))//Derecha
        {
            gameObject.transform.Translate(f * Time.deltaTime, 0, 0);
        }
    }

}


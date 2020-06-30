using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PJ1 : MonoBehaviour
{
    //lo eh quitado las fuerzas porque se lo damos fuera 
    public float fuerza;
    public float salto ;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        mover(fuerza);
        
    }

    public void mover(float fuerza)
    {
        if (Input.GetKey("a"))//Izquierda
        {
            gameObject.transform.Translate(-fuerza * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))//Derecha
        {
            gameObject.transform.Translate(fuerza * Time.deltaTime, 0, 0);
        }
    }

}


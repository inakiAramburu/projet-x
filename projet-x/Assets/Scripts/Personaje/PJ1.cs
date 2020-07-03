using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJ1 : MonoBehaviour
{

    int salto = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-4000f * Time.deltaTime, 0));
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(4000f * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown("space") && salto<=1)
        {
           
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1200f));
            salto += 1;
        }
        if (Input.GetKeyDown("s") )
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -900f));
        }
        if (salto>0)
        {
            Debug.Log(salto);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -4f));

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "plataforma")
        {
            salto = 0;
        }
        
    }
    
}


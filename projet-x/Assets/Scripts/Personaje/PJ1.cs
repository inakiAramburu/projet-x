using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJ1 : MonoBehaviour
{

    int salto = 1;

    [Header("Disparo")]
    public GameObject disparo;
    public Transform spawn_disparo_R;
    public Transform spawn_disparo_L;
   
    public int cantidad_disparo;

    public float direccion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //dispara a la derecha

        if (Input.GetKey("e")&& gameObject.GetComponent<SpriteRenderer>().flipX == false && cantidad_disparo >0 )//disparar
        {

            Instantiate(disparo, spawn_disparo_R.position, spawn_disparo_R.rotation);
          
            

           
            cantidad_disparo -= 1;

            

        }
        //dispara a la izquierda
        else if (Input.GetKey("e") && gameObject.GetComponent<SpriteRenderer>().flipX == true && cantidad_disparo > 0)//disparar
        {

            Instantiate(disparo, spawn_disparo_L.position, spawn_disparo_L.rotation);
        
          

            cantidad_disparo -= 1;

            
        }



        ///////////////////////////////////////////movimiento///////////////////////////////////////////

        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-8700f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(8700f * Time.deltaTime, 0));
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKeyDown("space") && salto <= 1)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1800f));
            salto += 1;
        }
        if (Input.GetKey("s"))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20f));
        }
        if (salto > 0)
        {
            Debug.Log(salto);
            // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -4f));

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


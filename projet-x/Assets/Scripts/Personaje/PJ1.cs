using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PJ1 : MonoBehaviour
{

    int salto = 1;

    [Header("Disparo")]
    public GameObject disparo;
    public Transform spawn_disparo;
    public int cantidad_disparo;
    public disparo Disparo;

    //swapn L new Vector3(-4.5687f, 0.6783f, 0);
    Vector3 spawn_disparo_L;
    Vector3 spawn_disparo_R;

   


    // Start is called before the first frame update
    void Start()
    {
        







    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cantidad_disparo);
        //asignamos valores a los vectores
        spawn_disparo_L = new Vector3(gameObject.transform.position.x + -0.2687f, gameObject.transform.position.y + -0.1017f, spawn_disparo.transform.position.z);
        spawn_disparo_R = new Vector3(gameObject.transform.position.x + 0.2688f, gameObject.transform.position.y + -0.1017f, spawn_disparo.transform.position.z);
       
        
        //dispara a la derecha R
      
        if (Input.GetKeyDown("e")&& gameObject.GetComponent<SpriteRenderer>().flipX == false && cantidad_disparo >0 )//disparar
        {

            Disparo.direccion = 1;
            cantidad_disparo -= 1;

            Instantiate(disparo, spawn_disparo.position, spawn_disparo.rotation);
          
            

           

            

        }
        //dispara a la izquierda L
        else if (Input.GetKeyDown("e") && gameObject.GetComponent<SpriteRenderer>().flipX == true && cantidad_disparo > 0)//disparar
        {
            Disparo.direccion = -1;
            Instantiate(disparo, spawn_disparo.position, spawn_disparo.rotation);
        
          

            cantidad_disparo -= 1;

            
        }



        ///////////////////////////////////////////movimiento///////////////////////////////////////////

        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-8700f * Time.deltaTime, 0));//mover personaje
            gameObject.GetComponent<SpriteRenderer>().flipX = true;//dar la vuelta al PJ
            //cambiamos la posicion del spwan del disparo
            spawn_disparo.position = spawn_disparo_L;

        }
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(8700f * Time.deltaTime, 0));//mover personaje
            gameObject.GetComponent<SpriteRenderer>().flipX = false;//dar la vuelta al PJ
            //cambiamos la posicion del spwan del disparo
            spawn_disparo.position = spawn_disparo_R;

        }
        if (Input.GetKeyDown("space") && salto <= 1)//salto
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1800f));
            salto += 1;
        }
        if (Input.GetKey("s"))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20f));
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


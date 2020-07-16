using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PJ2 : MonoBehaviour
{
    [SerializeField] float velocidad =8500;
    [SerializeField] private int saltos = 1;
    [SerializeField] private bool rotar = false; //Si es False mira a la derecha, si es True a la izquierda

    [SerializeField] private Transform firePoint;
    public GameObject bala;

    [SerializeField] private float velocidadAtaque = 2f;
    private float sigDisparo = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///////////////////////////////////////////Movimiento///////////////////////////////////////////

        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocidad * Time.deltaTime, 0)); //Mover Izquierda
            if (rotar == false) {
                transform.Rotate(0f, 180f, 0f);
                rotar = true;
            }
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad * Time.deltaTime, 0)); //Mover Derecha
           if (rotar == true) {
                transform.Rotate(0f, 180f, 0f);
                rotar = false;
            }
        }
        if (Input.GetKeyDown("up") && saltos <= 1) //Salto
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1800f));
            saltos += 1;
        }
        if (Input.GetKey("down"))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20f));
        }

        ///////////////////////////////////////////Movimiento///////////////////////////////////////////
        
        if (Input.GetKey("p") && Time.time >= sigDisparo) {
            Shoot();
            sigDisparo = Time.time + 1 / velocidadAtaque;
        }
        void Shoot() {
            Instantiate(bala, firePoint.position, firePoint.rotation);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "plataforma")
        {
            saltos = 0;
        }

        if (collision.transform.tag == "Lava")
        {
            Destroy(gameObject, 0.03f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.transform.tag == "Disparo") {
            Destroy(gameObject, 0.03f);
        }
    }
}


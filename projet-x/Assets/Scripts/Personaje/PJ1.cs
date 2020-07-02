using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PJ1 : MonoBehaviour
{
    //Le he quitado las fuerzas porque se lo damos fuera 
    public float velocidad;
    public float fuerzaSalto;
    private bool salto = false;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update() {
        
    }
    void FixedUpdate()
    {
        mover(velocidad * Time.deltaTime, fuerzaSalto);
    }
    public void mover(float vel, float salt)
    {
        if (Input.GetKey("a"))//Izquierda
        {
            gameObject.transform.Translate(-vel, 0f, 0f);
            //rb.velocity = new Vector2(-vel, rb.velocity.y);
        }
        else if (Input.GetKey("d"))//Derecha
        {
            gameObject.transform.Translate(vel, 0f, 0f);
            //rb.velocity = new Vector2(vel, rb.velocity.y);
        }
        if (Input.GetKey("space"))//Salto
        {
            gameObject.transform.Translate(0f, salt *Time.deltaTime, 0f);
            //rb.AddForce(new Vector2(0f, salt));
        }
    }

}
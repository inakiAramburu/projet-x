using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class disparo : MonoBehaviour
{

    
    public float velocidad;

    public int direccion;
    public PJ1 pj1;



    // Start is called before the first frame update
    void Start()
    {

        disparar(direccion);
    }

    // Update is called once per frame
    void Update()
    {
     

        //velocidad *= direccion;
    }


    void disparar(int direccion)
    {
        velocidad *= direccion;

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidad, 0.0f);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "plataforma")
        {
            Destroy(gameObject, 0.03f);
        }

    }

    
}

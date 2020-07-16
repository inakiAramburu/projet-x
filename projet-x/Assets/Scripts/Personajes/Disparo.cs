using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Disparo : MonoBehaviour
{


    /*public float velocidad;

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
        if (collision.transform.tag == "plataforma" || collision.transform.tag == "Disparo" || collision.transform.tag == "Disparo_azul" || collision.transform.tag == "Disparo_rojo" ||collision.transform.tag == "PJ" )
        {
            Destroy(gameObject, 0.03f);
        }
        if ( collision.transform.tag == "PJ")
        {
            Debug.Log("colision");
        }
    }
    */
    [SerializeField] private Transform firePoint;
    public GameObject fireballPrefab;

    [SerializeField] private float attackRate = 2f;
    private float nextShoot = 0f;

    // Update is called once per frame
    void Update() {
        if (Time.time >= nextShoot) {
            if (Input.GetKeyDown("p")) {
                Shoot();
                nextShoot = Time.time + 1 / attackRate;
            }
        }
    }
    //Shoot method
    void Shoot() {
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
    }

}

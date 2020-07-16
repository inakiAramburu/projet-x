using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    private float distance;

    // Start is called before the first frame update
    void Start() {
        rb.velocity = transform.right * speed;
        distance = rb.position.x;
    }
    void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(collision.name);
        if (collision.tag == "PJ") {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
    /*void OnTriggerEnter2D(Collision2D collision) {
        if (collision.transform.tag == "plataforma" || collision.transform.tag == "Disparo" || collision.transform.tag == "Disparo_azul" || collision.transform.tag == "Disparo_rojo" || collision.transform.tag == "PJ") {
            Destroy(gameObject, 0.03f);
        }
        if (collision.transform.tag == "PJ") {
            Debug.Log("colision");
        }
    }*/
    /*void Update() {
        if (rb.position.x < (distance - 20f) || rb.position.x > (distance + 20f)) {
            Destroy(gameObject);
        }
    }*/
}
